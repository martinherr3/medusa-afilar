Imports Infragistics.Win.UltraWinExplorerBar
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
Public Class frmSegProd
    Public borrar As String ' prometo borrar
    Public obj As ProdTacking

    Private Sub frmSegProd_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmSegProd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        txtIDHR.Focus()
    End Sub


    Private Sub frmSegProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        Dim constante As New Constantes
        cargarUltraCombo("select rtrim(apellido) + ', ' + rtrim(nombre) as empleado, idlegajo  from empleado where idcargo = " & constante.CargoOperario & " order by apellido", cmbEmpleado, "empleado", "idlegajo")
        cargarUltraCombo("select rtrim(apellido) + ', '+ rtrim(nombre) as nombre, idtornero from tornero ", cmbTornero, "nombre", "idtornero")
        BtnAceptar.Enabled = False
        cmbEmpleado.Enabled = False
        txtIDHR.Focus()
        'Dim i As Integer
        'For i = 0 To 2
        '    Dim grupo As New UltraExplorerBarGroup
        '    grupo.Text = "grupo" & i
        '    '

        '    Dim projectPath As String
        '    projectPath = getAppPath()
        '    Dim Apariencia As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        '    'aca hay que poner el nombre de la imagen sacada de la base de datos puede ser del nombre del grupo para no poner otro campo a la base de datos
        '    Apariencia.Image = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\mailNew.GIF")
        '    Dim str As String
        '    str = projectPath + AppSettings.Get("ImagesPath") + "\Done.ico"
        '    grupo.Settings.AppearancesLarge.HeaderAppearance = Apariencia

        '    '


        '    grupo.Items.Add("key" & i, "text" & i)
        '    grupo.Items.Add("key" & i, "text" & i)
        '    'grupo.Enabled = False
        '    barra.Groups.Add(grupo)

        'Next i
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        obj = New ProdTacking(borrar)
        obj.getDatos(barra)
        lblFresa.Text = obj.getNombreFresa()
        imagen.Image = obj.getImagen()

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        obj.dataDeOperacion(obj.getProximaOp())
        LblOperacion.Text = obj.Poperacion
        lblInicioPlan.Text = obj.PinicioPlanificado
        lblInicioReal.Text = obj.PinicioReal
        lblFinPlan.Text = obj.PfinPlanificado
        lblfinReal.Text = obj.PfinReal
        lblDuracion.Text = obj.Pduracion
        lblMaquina.Text = obj.Pmaquina
        lblOperario.Text = obj.Poperario


        'Dim proximaOP As Integer
        'proximaOP = obj.getProximaOp() - 1
        'If proximaOP <> -1 Then
        '    ProdTacking.selectGrupo(proximaOP, barra)
        'Else
        '    MsgBox("La fabricacion de este articulo ya a finalizado", MsgBoxStyle.Information, "Hoja de ruta finalizada")
        'End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'obj.dataDeOperacion(obj.getProximaOp())
        'LblOperacion.Text = obj.Poperacion
        'lblInicioPlan.Text = obj.PinicioPlanificado
        'lblInicioReal.Text = obj.PinicioReal
        'lblFinPlan.Text = obj.PfinPlanificado
        'lblfinReal.Text = obj.PfinReal
        'lblDuracion.Text = obj.Pduracion
        'lblMaquina.Text = obj.Pmaquina
        'lblOperario.Text = obj.Poperario



    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Application.DoEvents()

        If obj.registrarAvance(cmbEmpleado.Value, cmbTornero.Value) Then
            'MsgBox("se registro con exito")
            'PictureBox3.Visible = True
            obj = New ProdTacking(borrar)
            obj.getDatos(barra)
            lblFresa.Text = obj.getNombreFresa()
            imagen.Image = obj.getImagen()
            BtnAceptar.Enabled = False
            cmbEmpleado.Enabled = False
            txtIDHR.Focus()

        Else
            'MsgBox("no se pudo continuar")
            cmbEmpleado.Focus()
        End If
        cmbEmpleado.Value = ""
        cmbTornero.Value = ""
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Visible = False
        txtIDHR.Focus()
    End Sub

    Private Sub txtIDHR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDHR.KeyPress
        soloNumeros(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            'cargala imagen y los datos de las operaciones de la Hoja de ruta

            If txtIDHR.Text <> "" Then
                borrar = txtIDHR.Text
                obj = New ProdTacking(txtIDHR.Text)
                obj.getDatos(barra)
                lblFresa.Text = obj.getNombreFresa()
                imagen.Image = obj.getImagen()
                'Actualiza la infode la operacion actual
                If obj.dataDeOperacion(obj.getProximaOp()) Then
                    cmbEmpleado.Visible = obj.visible
                    cmbTornero.Visible = False
                Else
                    cmbTornero.Visible = obj.visible
                    cmbEmpleado.Visible = False
                End If
                LblOperacion.Text = obj.Poperacion
                lblInicioPlan.Text = obj.PinicioPlanificado
                lblInicioReal.Text = obj.PinicioReal
                lblFinPlan.Text = obj.PfinPlanificado
                lblfinReal.Text = obj.PfinReal
                lblDuracion.Text = obj.Pduracion
                lblMaquina.Text = obj.Pmaquina
                lblOperario.Text = obj.Poperario
                'Limpio el codigo
                txtIDHR.Text = ""
                'habilito los botones
                BtnAceptar.Enabled = True
                cmbEmpleado.Enabled = True
                'selecciono la operacion de la barra
                Dim proximaOP As Integer
                proximaOP = obj.getProximaOp()
                If proximaOP <> -1 Then
                    ProdTacking.selectGrupo(proximaOP - 1, barra)
                Else
                    If obj.HasRecords Then
                        If obj.registrarFinHR() Then
                            MsgBox("La fabricacion de este articulo ya a finalizado", MsgBoxStyle.Information, "Hoja de ruta finalizada")
                        End If
                        BtnAceptar.Enabled = False
                        cmbEmpleado.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub UltraButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub

    Private Sub timerSeg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerSeg.Tick
        PictureBox3.Visible = True
    End Sub

    Private Sub BtnAceptar_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.EnabledChanged
        timerSeg.Enabled = Not BtnAceptar.Enabled
    End Sub

    Private Sub UltraButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        cmbEmpleado.Enabled = False
        BtnAceptar.Enabled = False
        txtIDHR.Focus()
    End Sub


End Class









Public Class ProdTacking
    Private adapterfresa As SqlDataAdapter
    Private DS As DataSet
    Private IdHojaRuta As Integer
    Private PidFresa As Integer
    Public Poperacion As String
    Public PinicioReal As String
    Public PinicioPlanificado As String
    Public PfinReal As String
    Public PfinPlanificado As String
    Public Pduracion As String
    Public Pmaquina As String
    Public Poperario As String
    Private Ptorneado As String



    Public Sub New(ByVal idfresa As Integer)
        ptorneado = ""
        PidFresa = idfresa

        adapterfresa = New SqlDataAdapter("select rtrim (empleado.apellido) + ', ' + rtrim(empleado.nombre) as nombreempleado, detallehojaderuta.idlegajo, detallehojaderuta.idhojaderuta, detallehojaderuta.idetapadefabricacion, operacion.duracionpromedio, tipofresa.imagen, etapadefabricacion.idetapafabricacion, fresa.nroserie, etapadefabricacion.orden, operacion.nombre as nombreoperacion, detallehojaderuta.fechahorainicioreal, detallehojaderuta.fechahorainicioplanificada, detallehojaderuta.fechahorafinreal, detallehojaderuta.fechahorafinplanificada, hojaderuta.fechainicioproduccion, operacion.maquina, tipofresa.nombre, operacion.idoperacion, detallehojaderuta.idtorneado from fresa inner join hojaderuta on hojaderuta.idhojaderuta = fresa.idhojaderuta inner join tipofresa on fresa.idtipo = tipofresa.idtipo and fresa.idmodelo = tipofresa.idmodelo inner join detallehojaderuta on detallehojaderuta.idhojaderuta = fresa.idhojaderuta inner join etapadefabricacion on etapadefabricacion.idetapafabricacion = detallehojaderuta.idetapadefabricacion and fresa.idmodelo = etapadefabricacion.idmodelo and fresa.idtipo = etapadefabricacion.idtipofresa inner join operacion on etapadefabricacion.idoperacion = operacion.idoperacion left outer join empleado on empleado.idlegajo =  detallehojaderuta.idlegajo where Fresa.nroserie = " & idfresa & " order by etapadefabricacion.orden", cnn)
        DS = New DataSet
        adapterfresa.Fill(DS, "Fresa")
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If TFresa.Rows.Count > 0 Then
            If Not IsDBNull(TFresa.Rows(0).Item("idhojaderuta")) Then
                IdHojaRuta = TFresa.Rows(0).Item("idhojaderuta")
            Else
                MsgBox("Esta fresa no tiene una Hoja de ruta asociada", MsgBoxStyle.Information, "Entidad no planeada")
            End If
        Else
            MsgBox("Esta fresa no tiene una Hoja de ruta asociada", MsgBoxStyle.Information, "Entidad no planeada")
        End If
    End Sub



    Public Shared Sub selectGrupo(ByVal ordenOperacion As Integer, ByRef barra As UltraExplorerBar)
        'aca le paso el numero de orden de la operacion para que se seleccione el gupo adecuado 
        barra.SelectedGroup = barra.Groups.GetItem(ordenOperacion)
    End Sub
    Public Function visible() As Boolean
        If PinicioReal <> "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function dataDeOperacion(ByVal operacion As Integer) As Boolean
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        Dim fila() As DataRow
        fila = TFresa.Select("orden = " & operacion)
        If (fila.Length <> 0) Then
            Dim constante As New Constantes
            If fila(0).Item("idoperacion") <> constante.OperacionTorneado Then
                Poperacion = IIf(IsDBNull(fila(0).Item("nombreoperacion")), "", Trim(fila(0).Item("nombreoperacion")))
                PinicioReal = IIf(IsDBNull(fila(0).Item("fechahorainicioreal")), "", fila(0).Item("fechahorainicioreal"))
                PinicioPlanificado = IIf(IsDBNull(fila(0).Item("fechahorainicioplanificada")), "", fila(0).Item("fechahorainicioplanificada"))
                PfinReal = IIf(IsDBNull(fila(0).Item("fechahorafinreal")), "", fila(0).Item("fechahorafinreal"))
                PfinPlanificado = IIf(IsDBNull(fila(0).Item("fechahorafinplanificada")), "", fila(0).Item("fechahorafinplanificada"))
                Pduracion = IIf(IsDBNull(fila(0).Item("duracionpromedio")), "", fila(0).Item("duracionpromedio"))
                Pmaquina = IIf(IsDBNull(fila(0).Item("maquina")), "", Trim(fila(0).Item("maquina")))
                Poperario = IIf(IsDBNull(fila(0).Item("nombreempleado")), "", fila(0).Item("nombreempleado"))
                Ptorneado = ""
                Return True
            Else
                Dim dr As DataRow
                Dim obj As New ProdTacking(PidFresa)
                dr = obj.torneado(fila(0).Item("idtorneado"))
                Poperacion = IIf(IsDBNull(fila(0).Item("nombreoperacion")), "", Trim(fila(0).Item("nombreoperacion")))
                PinicioReal = IIf(IsDBNull(dr.Item("fechasalidad")), "", dr.Item("fechasalidad"))
                PinicioPlanificado = IIf(IsDBNull(fila(0).Item("fechahorainicioplanificada")), "", TFresa.Rows(0).Item("fechahorainicioplanificada"))
                PfinReal = IIf(IsDBNull(dr.Item("fecharecepcion")), "", dr.Item("fecharecepcion"))
                PfinPlanificado = IIf(IsDBNull(fila(0).Item("fechahorafinplanificada")), "", fila(0).Item("fechahorafinplanificada"))
                Pduracion = IIf(IsDBNull(fila(0).Item("duracionpromedio")), "", fila(0).Item("duracionpromedio"))
                Pmaquina = ""
                If IsDBNull(dr.Item("apellido")) Or IsDBNull(dr.Item("nombre")) Then
                    Poperario = ""
                Else
                    Poperario = IIf(IsDBNull(dr.Item("apellido")), "", Trim(dr.Item("apellido")) & ", " & Trim(dr.Item("nombre")))
                End If

                Ptorneado = fila(0).Item("idtorneado")
                Return False
            End If

        Else
            Poperacion = ""
            PinicioReal = ""
            PinicioPlanificado = ""
            PfinReal = ""
            PfinPlanificado = ""
            Pduracion = ""
            Pmaquina = ""
            Poperario = ""
            Return False
        End If
    End Function
    Public Function getNombreFresa() As String
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If TFresa.Rows.Count > 0 Then
            If Not IsDBNull(TFresa.Rows(0).Item("nombre")) Then
                Return TFresa.Rows(0).Item("nombre")
            Else
                Return "Fresa Generica AFILAR"
            End If
        End If
    End Function
    Public Function getImagen() As Image
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If TFresa.Rows.Count > 0 Then
        If Not IsDBNull(TFresa.Rows(0).Item("imagen")) Then
            Return Bytes2Image(TFresa.Rows(0).Item("imagen"))
        Else : Return Nothing ' tener en cuenta esto
            End If
        End If
    End Function

    Public Function getProximaOp() As Integer
        Dim adapttemp As SqlDataAdapter
        adapttemp = New SqlDataAdapter("select min(etapadefabricacion.orden) as proximaoperacion from detallehojaderuta inner join etapadefabricacion on etapadefabricacion.idetapafabricacion = detallehojaderuta.idetapadefabricacion where fechahorafinreal is null and idhojaderuta = " & IdHojaRuta, cnn)
        Dim DS As New DataSet
        adapttemp.Fill(DS, "Fresa")
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If Not IsDBNull(TFresa.Rows(0).Item("proximaoperacion")) Then
            Return TFresa.Rows(0).Item("proximaoperacion")
        Else : Return -1
        End If


    End Function
    
    Public Function registrarAvance(ByVal empleado As Integer, ByVal tornero As Integer) As Boolean
        Dim responsable As Integer
        responsable = 0
        If empleado <> 0 Then
            responsable = empleado
        ElseIf tornero <> 0 Then
            responsable = tornero
            ' tomar un empleado x ya que no importa quien lo registra solo el tornero importa
            empleado = 1
        End If

        If responsable <> 0 Or PinicioReal <> "" Then
            Dim nextOp As Integer
            nextOp = getProximaOp()
            Dim conn As SqlConnection
            conn = cnn
            conn.Open()
            'Try
            Dim sql2 As String
            Dim comm2 As SqlCommand
            If nextOp = 1 Then
                'cambio es estado de la fresa a en produccion
                sql2 = "update fresa set estado = " & Estado.FRESA_FABRICANDO & " where nroserie = " & PidFresa
                comm2 = New SqlCommand(sql2, conn)
                comm2.ExecuteNonQuery()
            End If

            If PinicioReal = "" Then
                sql2 = "UPDATE detallehojaderuta set fechahorainicioreal = getdate() , idlegajo = " & empleado & "where idhojaderuta = " & IdHojaRuta & " and idetapadefabricacion in (select idetapafabricacion from etapadefabricacion where orden = " & nextOp & ")"
                comm2 = New SqlCommand(sql2, conn)
                comm2.ExecuteNonQuery()
            ElseIf PfinReal = "" Then
                sql2 = "UPDATE detallehojaderuta set fechahorafinreal = getdate() where idhojaderuta = " & IdHojaRuta & " and idetapadefabricacion in (select idetapafabricacion from etapadefabricacion where orden = " & nextOp & ")"
                comm2 = New SqlCommand(sql2, conn)
                comm2.ExecuteNonQuery()
            End If
            If Ptorneado <> "" Then
                If PinicioReal = "" Then
                    sql2 = "UPDATE torneado SET fechasalidad = getdate() , idtornero = " & responsable & " where idtorneado = " & Ptorneado
                    comm2 = New SqlCommand(sql2, conn)
                    comm2.ExecuteNonQuery()
                Else
                    sql2 = "UPDATE torneado SET fecharecepcion = getdate() where idtorneado = " & Ptorneado
                    comm2 = New SqlCommand(sql2, conn)
                    comm2.ExecuteNonQuery()
                End If
            End If
            'If nextOp = 1 And PinicioReal = "" Then
            '    'marco el comienzo de la primera operacion
            '    Dim sql2 As String = "UPDATE detallehojaderuta set fechahorainicioreal = getdate() where idhojaderuta = " & IdHojaRuta & " and idetapadefabricacion in (select idetapafabricacion from etapadefabricacion where orden = " & nextOp & ")"
            '    Dim comm2 As New SqlCommand(sql2, conn)
            '    comm2.ExecuteNonQuery()
            '    'cambio es estado de la fresa a en produccion
            '    sql2 = "update fresa set estado = " & Estado.FRESA_FABRICANDO & " where nroserie = " & PidFresa
            '    comm2 = New SqlCommand(sql2, conn)
            '    comm2.ExecuteNonQuery()

            'Else


            '    'Aca registro la fecha de fin de la operacion actual
            '    Dim sql1 As String = "UPDATE detallehojaderuta set fechahorafinreal = getdate(), idlegajo = " & empleado & " where idhojaderuta = " & IdHojaRuta & " and idetapadefabricacion in (select idetapafabricacion from etapadefabricacion where orden = " & nextOp & ")"
            '    Dim comm1 As New SqlCommand(sql1, conn)

            '    comm1.ExecuteNonQuery()


            '    'Aca registro el comienzo de la proxima operacion
            '    Dim sql2 As String = "UPDATE detallehojaderuta set fechahorainicioreal = getdate() where idhojaderuta = " & IdHojaRuta & " and idetapadefabricacion in (select idetapafabricacion from etapadefabricacion where orden = " & nextOp + 1 & ")"
            '    Dim comm2 As New SqlCommand(sql2, conn)

            '    comm2.ExecuteNonQuery()
            'End If


            conn.Close()
            Return True
            'Catch
            'conn.Close()
            ' Return False

            'End Try
        Else
            MsgBox("Recuerde indicar la persona responsable de la operacion", MsgBoxStyle.Information)
            Return False

        End If


    End Function
    Public Sub getDatos(ByRef barra As UltraExplorerBar)
        'Falta validar los dbnull por que se pudre todo si no 
        barra.Groups.Clear()


        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        Dim DrFresa As DataRow


        For Each DrFresa In TFresa.Rows

            Dim grupo As New UltraExplorerBarGroup
            grupo.Text = DrFresa.Item("nombreoperacion")

            '
            Dim projectPath As String
            projectPath = getAppPath()
            Dim Apariencia As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            'aca hay que poner el nombre de la imagen sacada de la base de datos puede ser del nombre del grupo para no poner otro campo a la base de datos
            If IsDBNull(DrFresa.Item("fechahorafinreal")) Then
                Apariencia.Image = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\Pending.png")
            Else
                Apariencia.Image = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\Done.png")
            End If

            Dim str As String

            grupo.Settings.AppearancesLarge.HeaderAppearance = Apariencia
            '
            Dim constante As New Constantes

            grupo.Items.Add("orden", "Numero de orden:" & DrFresa.Item("orden"))
            grupo.Items.Add("fechahorainicioreal", "Inicio real de operacion: " & DrFresa.Item("fechahorainicioreal"))
            If DrFresa.Item("idoperacion") <> constante.OperacionTorneado Then

                'grupo.Items.Add("fechahorainicioreal", "Inicio real de operacion: " & DrFresa.Item("fechahorainicioreal"))
                grupo.Items.Add("fechahorainicioplanificada", "Inicio planificado de operacion: " & DrFresa.Item("fechahorainicioplanificada"))
                grupo.Items.Add("fechahorafinreal", "Operacion finalizada: " & DrFresa.Item("fechahorafinreal"))
                grupo.Items.Add("fechahorafinplanificada", "Fecha planificada de finalizacion: " & DrFresa.Item("fechahorafinplanificada"))
                grupo.Items.Add("duracionpromedio", "Duracion promedio: " & DrFresa.Item("duracionpromedio"))
                If IsDBNull(DrFresa.Item("maquina")) Then
                    grupo.Items.Add("maquina", "Maquina de trabajo: " & "")
                Else
                    grupo.Items.Add("maquina", "Maquina de trabajo: " & DrFresa.Item("maquina"))
                End If
                If IsDBNull(DrFresa.Item("idlegajo")) Then
                    grupo.Items.Add("operacion", "Operario resposable: " & "")

                Else
                    grupo.Items.Add("operacion", "Operario resposable: " & nombreEmpleado(DrFresa.Item("idlegajo")))
                End If

            Else
                Dim DrTorneado As DataRow

                DrTorneado = torneado(DrFresa.Item("idtorneado"))
                'grupo.Items.Add("fechahorainicioreal", "Inicio real de operacion: " & DrFresa.Item("fechahorainicioreal"))
                grupo.Items.Add("fechahorainicioplanificada", "Pieza enviada el: " & DrTorneado.Item("fechasalidad"))
                grupo.Items.Add("fechahorainicioplanificada", "Pieza recibida el: " & DrTorneado.Item("fecharecepcion"))
                grupo.Items.Add("fechahorafinplanificada", "Fecha planificada de finalizacion: " & DrFresa.Item("fechahorafinplanificada"))
                If IsDBNull(DrTorneado.Item("apellido")) Or IsDBNull(DrTorneado.Item("nombre")) Then
                    grupo.Items.Add("torneroresponsable", "Tornero responsable: ")
                Else
                    grupo.Items.Add("torneroresponsable", "Tornero responsable: " & Trim(DrTorneado.Item("apellido")) & ", " & Trim(DrTorneado.Item("nombre")))
                End If

                grupo.Items.Add("cantidadtorneado", "Cantidad de piezas torneadas: " & DrTorneado.Item("cantidadtorneados"))
            End If
            barra.Groups.Add(grupo)
            Apariencia.Dispose()

        Next


    End Sub

    Public Function torneado(ByVal idTorneado As Integer) As DataRow
        Dim adapterTorneado As SqlDataAdapter

        adapterTorneado = New SqlDataAdapter("select * from torneado left outer join tornero on tornero.idtornero = torneado.idtornero where idtorneado = " & idTorneado, cnn)
        Dim DST As New DataSet
        adapterTorneado.Fill(DST, "torneado")
        Dim TTorneado As DataTable = DST.Tables.Item("torneado")
        Return TTorneado.Rows(0)

       
    End Function
    Public Function nombreEmpleado(ByVal legajo As Integer) As String
        Dim adapterEmpleado As SqlDataAdapter

        adapterEmpleado = New SqlDataAdapter("select rtrim(apellido) + ', ' + rtrim(nombre) as nombre  from empleado where idlegajo = " & legajo, cnn)
        Dim DSE As New DataSet
        adapterEmpleado.Fill(DSE, "empleado")
        Dim TEmpleado As DataTable = DSE.Tables.Item("empleado")
        If IsDBNull(TEmpleado.Rows(0).Item("nombre")) Then
            Return ""
        Else
            Return TEmpleado.Rows(0).Item("nombre")
        End If

    End Function

    Public Function registrarFinHR() As Boolean
        Dim conn As SqlConnection
        conn = cnn
        conn.Open()
        Dim sql2 As String = "update fresa set estado = " & Estado.FRESA_FINALIZADO & " , fechafinfabricacion = getdate() where nroserie = " & PidFresa
        Dim comm2 As New SqlCommand(sql2, conn)
        comm2.ExecuteNonQuery()
        conn.Close()
        Return True
        

    End Function

    Public Function HasRecords() As Boolean
        If DS.Tables.Item("fresa").Rows.Count > 0 Then
            Return True

        Else
            Return False
        End If
    End Function
End Class