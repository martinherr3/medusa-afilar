Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings



Module ModuloPrincipal

    ' negrada de gerardo, prometo cambiar
    Public bandasignar As Integer
    Public idlocalidades(10) As Integer
    Public bandd As Integer  'negrada para el FOR de asignar  "controlar"
    Public idViajOEmp As Integer
    'fin negrada

    Public cnn As New SqlClient.SqlConnection
    Public princ As New principal
    Public seguridad As New ClsSeg
    Private splash As PantallaInicio


    Sub main()

        Dim oBaseDatos As New BaseDatos
        cnn.ConnectionString = oBaseDatos.GetConection()
        oBaseDatos = Nothing

        If AppSettings.Get("splashScreen") = "TRUE" Then
            splash = New PantallaInicio
            splash.Show()
            splash.Refresh()

            Threading.Thread.Sleep(8000)

            princ.Show()
            splash.Close()
        End If

        'Try
        System.Windows.Forms.Application.Run(princ)
        'Catch

        'End Try

    End Sub



    Public Sub cargarCombo(ByVal consulta As String, ByVal combo As Infragistics.Win.UltraWinEditors.UltraComboEditor)

        Dim sel As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader

        cnn.Open()

        sel.CommandText = consulta
        sel.CommandType = CommandType.Text
        sel.Connection = cnn

        reader = sel.ExecuteReader


        While reader.Read
            combo.Items.Add(reader.Item(0))
        End While

        cnn.Close()

    End Sub

    Sub cargarCombo(ByVal consulta As String, ByRef combo As ComboBox, ByVal nombreColumna As String, ByVal idcolumna As String)
        Dim adaptadorCombo As SqlDataAdapter = New SqlDataAdapter(consulta, cnn)
        Dim dsCombo As New DataSet
        adaptadorCombo.Fill(dsCombo)
        combo.DataSource = dsCombo.Tables.Item(0)
        combo.DisplayMember = nombreColumna
        combo.ValueMember = idcolumna
        If combo.Items.Count Then
            combo.SelectedIndex = 0
        End If
    End Sub


    Public Sub cargarGrilla(ByRef grd As DataGrid, ByRef dt As DataTable, ByVal nom() As String, ByVal ancho() As Integer)

        Dim estilo As New DataGridTableStyle

        estilo.MappingName = dt.TableName

        Dim estiloCol(dt.Columns.Count - 1) As DataGridTextBoxColumn



        Dim a As DataColumn

        Dim i As Integer = 0

        For Each a In dt.Columns

            estiloCol(i) = New DataGridTextBoxColumn

            With estiloCol(i)

                .MappingName = a.ColumnName

                .HeaderText = nom(i)

                .Width = ancho(i)

                i += 1

            End With

        Next

        estilo.GridColumnStyles.AddRange(estiloCol)

        grd.TableStyles.Add(estilo)

    End Sub

    Public Sub cargarGrilla(ByRef grd As DataGrid, ByRef dv As DataView, ByVal nom() As String, ByVal ancho() As Integer)

        Dim estilo As New DataGridTableStyle

        estilo.MappingName = dv.table.TableName

        Dim estiloCol(dv.Table.Columns.Count - 1) As DataGridTextBoxColumn



        Dim a As DataColumn

        Dim i As Integer = 0

        For Each a In dv.Table.Columns

            estiloCol(i) = New DataGridTextBoxColumn

            With estiloCol(i)

                .MappingName = a.ColumnName

                .HeaderText = nom(i)

                .Width = ancho(i)

                i += 1

            End With

        Next

        estilo.GridColumnStyles.AddRange(estiloCol)

        grd.TableStyles.Add(estilo)

    End Sub


    Public Sub cargarLista(ByVal lista As ListView, ByVal consulta As String, ByVal tag As Integer, ByVal col() As Integer)


        Dim dr As SqlClient.SqlDataReader
        Dim sel As New SqlClient.SqlCommand
        Dim i As Integer
        Dim item As New ListViewItem



        cnn.Open()
        sel.CommandText = consulta
        sel.CommandType = CommandType.Text
        sel.Connection = cnn

        dr = sel.ExecuteReader

        lista.BeginUpdate()

        While dr.Read
            item = lista.Items.Add(dr.Item(col(0)))
            item.Tag = dr.Item(tag)

            For i = 1 To col.GetUpperBound(0)
                item.SubItems.Add(dr.Item(col(i)))
            Next i

        End While

        lista.EndUpdate()

        cnn.Close()

    End Sub

    Public Sub cargarLista(ByVal lista As ListView, ByVal consulta As String, ByVal tag As Integer, ByVal col() As Integer, ByVal colName() As String)

        lista.Clear()
        Dim dr As SqlClient.SqlDataReader
        Dim sel As New SqlClient.SqlCommand
        Dim i As Integer
        Dim item As ListViewItem

        Dim column As String
        lista.Columns.Add("", 10, HorizontalAlignment.Left)
        For Each column In colName
            lista.Columns.Add(column, 110, HorizontalAlignment.Left)
        Next

        cnn.Open()
        sel.CommandText = consulta
        sel.CommandType = CommandType.Text
        sel.Connection = cnn

        dr = sel.ExecuteReader

        lista.BeginUpdate()

        While dr.Read
            item = New ListViewItem()
            item.Tag = dr.Item(tag)

            For i = 0 To col.GetUpperBound(0)
                item.SubItems.Add(dr.Item(col(i)).ToString.Trim)
            Next i

            lista.Items.Add(item)

        End While

        lista.EndUpdate()

        cnn.Close()

    End Sub

    Public Sub cargarComboTag(ByVal consulta As String, ByVal combo As Infragistics.Win.UltraWinEditors.UltraComboEditor, ByVal tag As Integer, ByVal items As Integer)
        Dim sel As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Dim item As Infragistics.Win.ValueListItem

        cnn.Open()

        sel.CommandText = consulta
        sel.CommandType = CommandType.Text
        sel.Connection = cnn

        reader = sel.ExecuteReader

        Select Case items
            Case 1
                While reader.Read
                    item = combo.Items.Add(reader.Item(0))
                    item.Tag = reader.Item(tag)

                End While
            Case 2
                While reader.Read
                    item = combo.Items.Add(reader.Item(1))
                    item.Tag = reader.Item(tag)

                End While
            Case 3
                While reader.Read
                    item = combo.Items.Add(reader.Item(2))
                    item.Tag = reader.Item(tag)

                End While
            Case 12
                While reader.Read
                    item = combo.Items.Add(RTrim(reader.Item(0)) & " " & RTrim(reader.Item(1)))
                    item.Tag = reader.Item(tag)

                End While
            Case 23
                While reader.Read
                    item = combo.Items.Add(RTrim(reader.Item(1)) & " " & RTrim(reader.Item(2)))
                    item.Tag = reader.Item(tag)
                End While
        End Select

        cnn.Close()
    End Sub


    Public Sub soloNumeros(ByVal k As System.Windows.Forms.KeyPressEventArgs)

        Select Case Asc(k.KeyChar)
            Case 8
            Case Asc("0") To Asc("9")
            Case 13
            Case 32
            Case 44
            Case Asc(".")
            Case Else
                k.Handled = True
        End Select
    End Sub


    Public Sub cargarComboOp(ByVal consulta As String, ByVal combo As Infragistics.Win.UltraWinEditors.UltraComboEditor, ByVal tag As Integer)
        Dim sel As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Dim item As Infragistics.Win.ValueListItem

        cnn.Open()

        sel.CommandText = consulta
        sel.CommandType = CommandType.Text
        sel.Connection = cnn

        reader = sel.ExecuteReader


        While reader.Read
            item = combo.Items.Add(reader.Item(1) & reader.Item(2) & " min.")
            item.Tag = reader.Item(tag)
        End While

        cnn.Close()

    End Sub


    Public Sub crearRelacion(ByVal ds As DataSet, ByVal tablaPadre As String, ByVal tablaHijo As String, ByVal colPadre As String, ByVal colHijo As String, ByVal nombre As String)
        Try
            'obtiene los objetos dataColumn de las tablas
            Dim padre As DataColumn
            Dim hijo As DataColumn
            padre = ds.Tables(tablaPadre).Columns(colPadre)
            hijo = ds.Tables(tablaHijo).Columns(colHijo)
            'crea la relacion
            Dim relacion As DataRelation
            relacion = New DataRelation(nombre, padre, hijo)
            'agrego la relacion en el dataset
            ds.Relations.Add(relacion)
        Catch
            'Nada
        End Try
    End Sub



    Public Function sel_check_col(ByRef dg As DataGrid, ByVal col As Integer, ByVal e As MouseEventArgs) As Boolean

        Dim pt As System.Drawing.Point = New Point(e.X, e.Y)

        Dim hti As DataGrid.HitTestInfo = dg.HitTest(pt)

        If hti.Type = DataGrid.HitTestType.Cell Then

            If col = hti.Column Then
                dg.CurrentCell = New DataGridCell(hti.Row, hti.Column)
                Return True
            End If

        End If

        Return False

    End Function


    Public Function obtenerHijos(ByVal filaPadre As DataRow, ByVal relacion As String) As Array

        Dim drarray() As DataRow
        drarray = filaPadre.GetChildRows(relacion)
        Return drarray

    End Function

    Public Sub cargarUltraCombo(ByVal consulta As String, ByRef combo As Infragistics.Win.UltraWinEditors.UltraComboEditor, ByVal display As String, ByVal value As String)

        Dim sel As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader

        cnn.Open()

        sel.CommandText = consulta
        sel.CommandType = CommandType.Text
        sel.Connection = cnn

        reader = sel.ExecuteReader


        While reader.Read
            combo.Items.Add(Trim(reader.Item(value)), Trim(reader.Item(display)))
        End While

        cnn.Close()

    End Sub

    Public Function getAppPath() As String
        Dim projectPath As String
        projectPath = AppSettings.Get("appPath")
        Return projectPath
    End Function


    Public Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = IO.Path.GetTempFileName()
        Dim fs As New IO.FileStream(sTemp, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0
        '
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function


    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New IO.MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function


    Public Function Redondear(ByVal Numero As String) As String
        Dim ParteEntera As String = Int(Numero)
        Dim ParteDecimal As String
        If Not (Len(Numero) - Len(ParteEntera)) = 0 Then
            ParteDecimal = Right(Numero, Len(Numero) - Len(ParteEntera) - 1)
        Else
            ParteDecimal = "00"
        End If
        Dim Num As Double
        If Len(ParteDecimal) >= 3 Then
            ParteDecimal = Left(ParteDecimal, 3)
            If Mid(ParteDecimal, 3, 1) >= "5" Then
                ParteDecimal = Left(ParteDecimal, 2)
                Num = Convert.ToDouble(ParteDecimal)
                Num = Num + 1
                If Len(CStr(Num)) = 3 Then ParteEntera = ParteEntera + 1
                ParteDecimal = Right(CStr(Num), 2)
            End If
        Else
            ParteDecimal = Left(ParteDecimal, 2) '<-- El problema estaba aquí. Si el tercer decimal no
            ' empezaba por un numero mayor de 5, saltaba y retornaba
            ' el mismo valor de entrada.

        End If
        Redondear = ParteEntera & "," & ParteDecimal
    End Function

    '''<summary>
    ''' Retorna la Fecha enviada como parametro en formato ANSI como String
    ''' </summary>
    ''' <param name="pFecha">Fecha a convertir, del tipo DATE</param>
    ''' <returns>Fceha en ANSI, del tipo String</returns>
    Public Function FormatoANSI(ByVal pFecha As Date) As String

        Return String.Format("{0:D2}", pFecha.Year) + String.Format("{0:D2}", pFecha.Month) + String.Format("{0:D2}", pFecha.Day) + " " + String.Format("{0:D2}", pFecha.Hour) + ":" + String.Format("{0:D2}", pFecha.Minute) + ":" + String.Format("{0:D2}", pFecha.Second)

    End Function



End Module
