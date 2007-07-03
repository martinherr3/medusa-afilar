Imports System.Data.SqlClient
Imports Afilar.grdstyle
Public Class FrmRecibirMP
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents GrdDOC As System.Windows.Forms.DataGrid
    Friend WithEvents GrdOC As System.Windows.Forms.DataGrid
    Friend WithEvents BtnAceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.GrdDOC = New System.Windows.Forms.DataGrid
        Me.GrdOC = New System.Windows.Forms.DataGrid
        Me.BtnAceptar = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.GrdDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Appearance1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance1
        Me.UltraGroupBox1.Controls.Add(Me.GrdDOC)
        Me.UltraGroupBox1.Controls.Add(Me.GrdOC)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(432, 400)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Pedidios  pendientes"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GrdDOC
        '
        Me.GrdDOC.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.GrdDOC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GrdDOC.BackgroundColor = System.Drawing.Color.LightGray
        Me.GrdDOC.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.GrdDOC.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdDOC.CaptionText = "Detalles de pedido"
        Me.GrdDOC.DataMember = ""
        Me.GrdDOC.FlatMode = True
        Me.GrdDOC.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GrdDOC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdDOC.GridLineColor = System.Drawing.Color.Gainsboro
        Me.GrdDOC.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.GrdDOC.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.GrdDOC.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GrdDOC.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrdDOC.LinkColor = System.Drawing.Color.Teal
        Me.GrdDOC.Location = New System.Drawing.Point(24, 232)
        Me.GrdDOC.Name = "GrdDOC"
        Me.GrdDOC.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.GrdDOC.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdDOC.ReadOnly = True
        Me.GrdDOC.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.GrdDOC.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrdDOC.Size = New System.Drawing.Size(376, 152)
        Me.GrdDOC.TabIndex = 1
        '
        'GrdOC
        '
        Me.GrdOC.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.GrdOC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GrdOC.BackgroundColor = System.Drawing.Color.LightGray
        Me.GrdOC.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.GrdOC.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdOC.CaptionText = "Pedidos"
        Me.GrdOC.DataMember = ""
        Me.GrdOC.FlatMode = True
        Me.GrdOC.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GrdOC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdOC.GridLineColor = System.Drawing.Color.Gainsboro
        Me.GrdOC.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.GrdOC.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.GrdOC.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GrdOC.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrdOC.LinkColor = System.Drawing.Color.Teal
        Me.GrdOC.Location = New System.Drawing.Point(24, 32)
        Me.GrdOC.Name = "GrdOC"
        Me.GrdOC.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.GrdOC.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdOC.ReadOnly = True
        Me.GrdOC.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.GrdOC.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrdOC.Size = New System.Drawing.Size(376, 184)
        Me.GrdOC.TabIndex = 0
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(280, 416)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(80, 24)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(368, 416)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 2
        Me.UltraButton1.Text = "&Salir"
        '
        'FrmRecibirMP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 448)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "FrmRecibirMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar recepción MP"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.GrdDOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents check As New CheckBox
    Dim SQLconn As New SqlConnection("Server=localhost;" & _
                   "DataBase=afilar;" & _
                   "Integrated Security=SSPI")
    Dim DS As New DataSet
    Dim dtOC As New DataTable
    ' Dim dvOC As New DataView
    ' Dim dtDOC As New DataTable
    Dim dvDOC As New DataView
    Dim Sqldataadapter1 As New SqlDataAdapter("select fecharealizacion, nroorden, ordencompramp.idproveedor, proveedor.nombre from ordencompramp inner join proveedor on ordencompramp.idproveedor = proveedor.idproveedor where ordencompramp.idestado=1", SQLconn)
    Dim Sqldataadapter2 As New SqlDataAdapter("select idordencompra, detalleordencompra.idtipomateriaprima, cantidad, precio, tipomateriaprima.nombre from detalleordencompra inner join tipomateriaprima on detalleordencompra.idtipomateriaprima = tipomateriaprima.idtipomateriaprima where idordencompra in (select idordencompra from ordencompramp where idestado =1) and idestado =1 ", SQLconn)
    'Dim Sqldataadapter3 As New SqlDataAdapter("select * from mprecibida where 1=2", SQLconn)
    'Dim Sqldataadapter4 As New SqlDataAdapter("select * from detallemprecibida where 1=2", SQLconn)

    ''IDESTADO =1 ES "PENDIENTE DE ENTREGA" tendriamos que agregar la tabra estado


    Private Sub FrmRecibirMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        SQLconn.Open()
        Sqldataadapter1.Fill(DS, "ordencompramp")
        Sqldataadapter2.Fill(DS, "detalleordencompra")
        'Sqldataadapter3.Fill(DS, "mprecibida")
        'Sqldataadapter4.Fill(DS, "detallemprecibiba")

        SQLconn.Close()


        dtOC = DS.Tables("ordencompramp")
        'dtDOC = DS.Tables("detalleordencompra")
        dvDOC = DS.Tables("detalleordencompra").DefaultView
        Dim cols As DataColumnCollection = dtOC.Columns
        Dim dcol As New DataColumn
        dcol.DefaultValue = "N"
        cols.Add(dcol)
        Dim colsdv As DataColumnCollection = dtOC.Columns
        Dim dcoldv As New DataColumn
        dcoldv.DefaultValue = "N"
        colsdv = dvDOC.Table.Columns
        colsdv.Add(dcoldv)
        LoadGrid_oc()
        LoadGrid_doc()
        ''''''''''''''''''''''''''''''
        'esto es para que se seleccione una fila de oc y filtre el detalle desde el comienzo
        'GrdOC.Select(1)
        'GrdOC.Select(GrdOC.CurrentCell.RowNumber)
        'dvDOC.RowFilter = "idordencompra =" & GrdOC.Item(GrdOC.CurrentCell.RowNumber, 1)
        ''''''''''''''''''''''''''''''



    End Sub



    Private Sub LoadGrid_oc()

        Dim ts As DataGridTableStyle = CGrid.GetTableStyle(dtOC)

        'CheckBox Column columnstyle1
        Dim cs1 As New CGridCheckBoxStyle("Column1", 55, _
                                          HorizontalAlignment.Center, False, _
                                          "Recibir", "", "N", "Y", False, "")
        CGrid.AddColumn(ts, cs1)

        'TextBox Column
        Dim cs2 As New CGridTextBoxStyle("nroorden", 80, _
                                          HorizontalAlignment.Center, True, _
                                          "Nº Orden", String.Empty, "")
        CGrid.AddColumn(ts, cs2)
        'text box
        Dim cs3 As New CGridTextBoxStyle("fecharealizacion", 130, _
                                        HorizontalAlignment.Center, True, _
                                        "Fecha de realizacion", String.Empty, "")


        CGrid.AddColumn(ts, cs3)

        'TextBox Column - ReadOnly
        Dim cs4 As New CGridTextBoxStyle("nombre", 80, _
                                         HorizontalAlignment.Left, True, _
                                         "Proveedor", String.Empty, "")
        CGrid.AddColumn(ts, cs4)

        'ComboBox Column
        'Dim Items() As String = {"tarjeta", "efectivo", "Maybe", "Depends"}
        'Dim cs5 As New CGridComboBoxStyle("condicionesdepago", 80, _
        '                                 HorizontalAlignment.Left, _
        '                                "Your Pick", "(null)", _
        '                               Items, ComboBoxStyle.DropDownList)
        'CGrid.AddColumn(ts, cs5)

        'NumericUpDown Column
        ' Dim cs6 As New CGridNumericUpDownStyle("idestado", 60, "Count", 0, 100, _
        '                                       0, 1, LeftRightAlignment.Right, _
        '                                      0, "#,##0")
        'CGrid.AddColumn(ts, cs6)



        'ts.AlternatingBackColor = Color.LightGoldenrodYellow
        CGrid.SetGridStyle(Me.GrdOC, dtOC, ts)



        Me.GrdOC.CaptionVisible = False


    End Sub



    Private Sub LoadGrid_doc()

        Dim ts As DataGridTableStyle = CGrid.GetTableStyle(dvDOC)

        'CheckBox Column columnstyle1
        Dim cs1 As New CGridCheckBoxStyle("Column1", 55, _
                                          HorizontalAlignment.Center, False, _
                                          "Recibir", "", "N", "Y", False, "")
        CGrid.AddColumn(ts, cs1)

        'TextBox Column
        Dim cs2 As New CGridTextBoxStyle("nombre", 110, _
                                          HorizontalAlignment.Center, True, _
                                          "Materia Prima", String.Empty, "")
        CGrid.AddColumn(ts, cs2)
        'text box
        Dim cs3 As New CGridTextBoxStyle("precio", 130, _
                                        HorizontalAlignment.Center, True, _
                                        "Precio", String.Empty, "")


        CGrid.AddColumn(ts, cs3)

        'TextBox Column - ReadOnly
        Dim cs4 As New CGridTextBoxStyle("cantidad", 80, _
                                         HorizontalAlignment.Left, True, _
                                         "Cantidad", String.Empty, "")
        CGrid.AddColumn(ts, cs4)


        CGrid.SetGridStyle(Me.GrdDOC, DS.Tables("detalleordencompra"), ts)



        Me.GrdOC.CaptionVisible = False


    End Sub



    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim x As Integer
            x = 0
            x = CType(InputBox("Por favor ingrese en numero de remito", "REMITO", "0"), Integer)
            Dim mprec As Integer
            Dim causa As String
            Dim sqlcommandDMPR As New SqlCommand
            Dim sqlcommandOC As New SqlCommand
            Dim sqlcommandMPR As New SqlCommand
            sqlcommandDMPR.CommandType = CommandType.Text
            sqlcommandDMPR.Connection = SQLconn
            sqlcommandOC.CommandType = CommandType.Text
            sqlcommandOC.Connection = SQLconn
            sqlcommandMPR.CommandType = CommandType.Text
            sqlcommandMPR.Connection = SQLconn
            SQLconn.Open()
            ''' para sacar el nro max de mprecibida
            Dim sqlcommandMPR2 As New SqlCommand
            sqlcommandMPR2.CommandType = CommandType.Text
            sqlcommandMPR2.Connection = SQLconn
            sqlcommandMPR2.CommandText = "select max(idmprecibida) from  mprecibida"
            mprec = sqlcommandMPR2.ExecuteScalar() + 1


            Dim fila_encontrada As DataRow() = dtOC.Select("column1 = 'Y'") 'cambio estado oc
            If fila_encontrada.Length <> 0 Then
                Dim dr As DataRow = fila_encontrada(0)
                sqlcommandOC.CommandText = "update ordencompramp set idestado =2 where nroorden=" & dr.Item(1)
                sqlcommandOC.ExecuteNonQuery()
                'dtOC.Rows(dtOC.).Delete()
            End If

            'cambio estado doc
            Dim sqlcommandDOC As New SqlCommand
            sqlcommandDOC.CommandType = CommandType.Text
            sqlcommandDOC.Connection = SQLconn
            'Dim fila As DataRow
            Dim band As Boolean
            band = False
            Dim bborrar As Boolean
            bborrar = False

            ' For Each fila In dvDOC.Table.Rows
            Dim i As Integer
            Dim f As Integer
            f = 0

            For i = 0 To dvDOC.Count - 1
                bborrar = False
                If dvDOC.Item(f).Item("Column1") = "Y" Then
                    sqlcommandDOC.CommandText = "update detalleordencompra set idestado = 2 where idordencompra=" & dvDOC.Item(f).Item("idordencompra") & "and idtipomateriaprima =" & dvDOC.Item(f).Item("idtipomateriaprima")
                    sqlcommandDOC.ExecuteNonQuery()
                    bborrar = True
                    'dvDOC.Item(i).Delete()
                    'i -= 1
                    If band = False Then 'cargo mprecibida 1 sola vez                  
                        sqlcommandMPR.CommandText = "insert into mprecibida values (" & mprec & ", '" & Today & "'," & x & ", " & dvDOC.Item(f).Item("idordencompra") & ")"
                        sqlcommandMPR.ExecuteNonQuery()
                        band = True
                    End If 'falta la causa
                    'cargo detalle mp recibida
                    sqlcommandDMPR.CommandText = "insert into detallemprecibida values (" & mprec & "," & dvDOC.Item(f).Item("cantidad") & "," & dvDOC.Item(f).Item("precio") & ",'', 2," & dvDOC.Item(f).Item("idtipomateriaprima") & ")"
                    sqlcommandDMPR.ExecuteNonQuery()
                Else 'no la pongo como recibida pero si registro se la rechazo a una materia prima especifica
                    If band = False Then 'cargo mprecibida 1 sola vez                  
                        sqlcommandMPR.CommandText = "insert into mprecibida values (" & mprec & ", '" & Today & "'," & x & ", " & dvDOC.Item(f).Item("idordencompra") & ")"
                        sqlcommandMPR.ExecuteNonQuery()
                        band = True
                    End If 'falta la causa
                    If MsgBox("Materia prima" & dvDOC.Item(f).Item("nombre") & " rechazada?", MsgBoxStyle.YesNo, "Faltantes") = MsgBoxResult.Yes Then
                        causa = CType(InputBox("Por favor indique la causa de rechazo", "RECHAZO", ""), String)
                        'estado RECHAZADO =3
                        sqlcommandDMPR.CommandText = "insert into detallemprecibida values (" & mprec & ", 0,0,'" & causa & "', 3," & dvDOC.Item(f).Item("idtipomateriaprima") & ")"
                        sqlcommandDMPR.ExecuteNonQuery()
                    End If
                End If
                If bborrar Then
                    dvDOC.Item(f).Delete()
                    f -= 1
                End If
                f += 1
            Next





            SQLconn.Close()
            GrdDOC.Refresh()
            GrdOC.Refresh()

        Catch exp As Exception
            MsgBox(exp.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub GrdOC_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdOC.CurrentCellChanged
        GrdOC.Select(GrdOC.CurrentCell.RowNumber)
        dvDOC.RowFilter = "idordencompra =" & GrdOC.Item(GrdOC.CurrentCell.RowNumber, 1)
    End Sub

    Private Sub GrdDOC_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDOC.CurrentCellChanged
        GrdDOC.Select(GrdDOC.CurrentCell.RowNumber)
    End Sub

    Private Sub GrdOC_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GrdOC.MouseUp
        If sel_check_col(GrdOC, 0, e) Then

            Select Case dtOC.Rows(GrdOC.CurrentRowIndex).Item("Column1")
                Case "N"
                    dtOC.Rows(GrdOC.CurrentRowIndex).Item("Column1") = "Y"
                    Dim i As Integer
                    For i = 0 To dvDOC.Count - 1
                        dvDOC.Item(i).Item("Column1") = "Y"
                    Next i

                Case "Y"
                    dtOC.Rows(GrdOC.CurrentRowIndex).Item("Column1") = "N"
                    GrdOC.Refresh()
                    Dim i As Integer
                    For i = 0 To dvDOC.Count - 1
                        dvDOC.Item(i).Item("Column1") = "N"
                    Next i

            End Select
            GrdOC.Select(GrdOC.CurrentCell.RowNumber)
            GrdDOC.Refresh()
        End If

    End Sub

    Private Sub GrdDOC_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GrdDOC.MouseUp
        Dim row As Integer
        Dim i As Integer
        row = GrdDOC.CurrentCell.RowNumber
        If sel_check_col(GrdDOC, 0, e) Then
            Select Case dvDOC.Item(GrdDOC.CurrentRowIndex).Item("Column1")
                Case "N"
                    dvDOC.Item(GrdDOC.CurrentRowIndex).Item("Column1") = "Y"

                    For i = 0 To dvDOC.Count - 1
                        If dvDOC.Item(i).Item("Column1") <> "Y" Then
                            GrdDOC.Select(row)
                            GrdDOC.Refresh()
                            Exit Sub
                        End If
                    Next i
                    dtOC.Rows(GrdOC.CurrentRowIndex).Item("Column1") = "Y"

                Case "Y"
                    dvDOC.Item(GrdDOC.CurrentRowIndex).Item("Column1") = "N"

                    'For i = 0 To dvDOC.Count - 1
                    'If dvDOC.Item(i).Item("Column1") = "Y" Then
                    'GrdDOC.Select(row)
                    'GrdDOC.Refresh()
                    'Exit Sub
                    'End If
                    '       Next i
                    dtOC.Rows(GrdOC.CurrentRowIndex).Item("Column1") = "N"

            End Select
            GrdDOC.Select(row)
            GrdDOC.Refresh()
        End If
    End Sub

    Private Function sel_check_col(ByRef dg As DataGrid, ByVal col As Integer, ByVal e As MouseEventArgs) As Boolean
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

    Private Sub FrmRecibirMP_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub


End Class
