Public Class frmVerProgramacion
    Dim maquinas As Collection
    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click

        Dim HoraInicio As DateTime
        Dim HoraFin As DateTime
        Dim splitedIni() As String
        Dim splitedFin() As String

        GanttChart1.RemoveBars()

        If RadioButton1.Checked Then
            Try

                splitedIni = TXTInicioSim.Text.Split(":")
                splitedFin = TXTFinSim.Text.Split(":")
                HoraInicio = DTPickerInicioSim.Value.Date
                HoraFin = DTPickerFinSim.Value.Date

                HoraInicio = HoraInicio.AddHours(splitedIni(0))
                HoraInicio = HoraInicio.AddMinutes(splitedIni(1))
                HoraFin = HoraFin.AddHours(splitedFin(0))
                HoraFin = HoraFin.AddMinutes(splitedFin(1))

                'If HoraInicio < Date.Now Then
                ' MsgBox("La hora de inicio no puede ser menor a la hora actual del sistema")
                ' Exit Sub
                'End If

            Catch ex As Exception

                MsgBox("Hora incorrecta")
                Exit Sub

            End Try
        End If

        'carga de mauqinas
        Dim maquina As New MaquinaProd
        Dim coltareas As New Collection
        Dim d As Boolean = False
        Dim indice As Integer = 0
        Dim minMax As DateTime()

        maquinas = maquina.getCustom("SELECT * FROM maquina WHERE idestado = " & Estado.MAQUINA_OPERANDO)
        ''----< debug >----
        For Each maqu As MaquinaProd In maquinas
            Debug.WriteLine("--> MAQUINAS <-- id " & maqu.idMaquina & " - tipo " & maqu.tipo & " - nombre " & maqu.nombre)
        Next

        If RadioButton1.Checked Then
            minMax = cargarProgramacion(HoraInicio, HoraFin)
            GanttChart1.FromDate = HoraInicio
            GanttChart1.ToDate = HoraFin
        Else
            minMax = cargarProgramacion(Date.Now, Date.Now, TXTNroSerie.Text)
            GanttChart1.FromDate = minMax(0)
            GanttChart1.ToDate = minMax(1)
        End If


        For Each maq As MaquinaProd In maquinas
            For Each tar As tareasProd In maq.tareas
                coltareas.Add(New BarInformation(maq.nombre, tar.inicio, tar.fin, tar.color, Color.Bisque, indice, tar.idFresa, tar.getNombreOperacion()))
                d = True
            Next
            If d Then
                indice += 1
                d = False
            End If
        Next

        For Each bar As BarInformation In coltareas
            GanttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index)
        Next

        GanttChart1.Refresh()
        GanttChart1.Enabled = True

    End Sub


    Private Function cargarProgramacion(ByVal inicio As DateTime, ByVal fin As DateTime, Optional ByVal nroSerie As Integer = 0) As DateTime()
        Dim DS As New DataSet
        Dim sql As String
        Dim minMax(1) As DateTime
        Dim i As Boolean = False

        If nroSerie = 0 Then 'POR RANGO
            ' agregar la subconsulta a la prog de produccion
            sql = "SELECT (SELECT f.nroserie FROM fresa f WHERE f.idhojaderuta = det.idhojaderuta) nroserie, " & _
                  "idhojaderuta, idetapadefabricacion, fechahorainicioplanificada, fechahorafinplanificada,fechahorainicioreal,fechahorafinreal, idmaquina " & _
                  ", (SELECT e.idoperacion FROM etapadefabricacion e WHERE e.idetapafabricacion = det.idetapadefabricacion) idoperacion " & _
                  "FROM detallehojaderuta det " & _
                  "WHERE fechahorafinplanificada > '" & inicio.ToString("s") & "' AND fechahorainicioplanificada < '" & fin.ToString("s") & "'"
        Else ' POR NRO SERIE
            sql = "SELECT f.nroserie, d.idhojaderuta, d.idetapadefabricacion, d.fechahorainicioplanificada, " & _
                  "d.fechahorafinplanificada, d.fechahorainicioreal, d.fechahorafinreal, d.idmaquina " & _
                  ", (SELECT e.idoperacion FROM etapadefabricacion e WHERE e.idetapafabricacion = d.idetapadefabricacion) idoperacion " & _
                  "FROM fresa f INNER JOIN detallehojaderuta d ON f.idhojaderuta = d.idhojaderuta " & _
                  "WHERE f.nroserie = " & nroSerie
        End If

        Dim comm As New SqlClient.SqlCommand(sql, cnn)
        Dim DA As New SqlClient.SqlDataAdapter(comm)

        DA.Fill(DS, "planificados")

        Dim tar As tareasProd
        For Each DR As DataRow In DS.Tables.Item(0).Rows
            ' por cada row crear el objeto tarea y asignarlo a la maquina correspondiente
            tar = New tareasProd
            tar.inicio = DR("fechahorainicioplanificada")
            tar.fin = DR("fechahorafinplanificada")
            tar.idEtapa = DR("idetapadefabricacion")
            tar.idFresa = DR("nroserie")
            tar.idOperacion = DR("idoperacion")


            If Not i Then
                minMax(0) = tar.inicio
                minMax(1) = tar.fin
                i = True
            Else
                If tar.inicio < minMax(0) Then
                    minMax(0) = tar.inicio
                End If
                If tar.fin > minMax(1) Then
                    minMax(1) = tar.fin
                End If
            End If

            If Not IsDBNull(DR("fechahorafinreal")) Then ' tarea finalizada
                tar.color = Color.Green
            ElseIf Not IsDBNull(DR("fechahorainicioreal")) Then ' tarea en proceso
                tar.color = Color.OrangeRed
            Else 'tarea programada
                tar.color = Color.DarkGray
            End If

            For Each maq As MaquinaProd In maquinas
                If maq.idMaquina = DR("idmaquina") Then
                    maq.programarTarea(tar)
                    Exit For
                End If
            Next
        Next

        Return minMax
    End Function
    Private Sub GanttChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GanttChart1.MouseMove
        With GanttChart1
            Dim toolTipText As New System.Collections.Generic.List(Of String)

            If .MouseOverRowText.Length > 0 Then
                Dim val As BarInformation = CType(.MouseOverRowValue, BarInformation)
                toolTipText.Add("[b]Date:")
                toolTipText.Add("From ")
                toolTipText.Add(val.FromTime.ToLongDateString & " - " & val.FromTime.ToString("HH:mm"))
                toolTipText.Add("To ")
                toolTipText.Add(val.ToTime.ToLongDateString & " - " & val.ToTime.ToString("HH:mm"))
                If val.nroFresa = -1 Then
                    toolTipText.Add("[b]Cerrado")
                ElseIf val.nroFresa = -2 Then
                    toolTipText.Add("[b]Programacion previa")
                Else
                    toolTipText.Add("[b]Fresa Nro:" & val.nroFresa)
                End If
                toolTipText.Add("[b]Operacion:" & val.operacion)

            Else
                toolTipText.Add("")
            End If

            .ToolTipTextTitle = .MouseOverRowText
            .ToolTipText = toolTipText

        End With
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TXTNroSerie.Enabled = False
        GroupBox3.Enabled = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TXTNroSerie.Enabled = True
        GroupBox3.Enabled = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub frmVerProgramacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmVerProgramacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        princ.barra.agregarBoton(Me)
    End Sub
End Class