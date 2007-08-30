Imports System.Data.SqlClient
Imports Afilar.grdstyle
Public Class frmRecibirMPII
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
    Friend WithEvents BtnSiguiente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnAtras As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gpbox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents gpbox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents DgOc As System.Windows.Forms.DataGrid
    Friend WithEvents DgDoc As System.Windows.Forms.DataGrid
    Friend WithEvents dgDocP As System.Windows.Forms.DataGrid
    Friend WithEvents LstDoc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gpbox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents textRemito As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecibirMPII))
        Me.gpbox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.DgOc = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSiguiente = New Infragistics.Win.Misc.UltraButton
        Me.BtnAtras = New Infragistics.Win.Misc.UltraButton
        Me.BtnSalir = New Infragistics.Win.Misc.UltraButton
        Me.gpbox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.DgDoc = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.gpbox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.textRemito = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.LstDoc = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.dgDocP = New System.Windows.Forms.DataGrid
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.gpbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbox1.SuspendLayout()
        CType(Me.DgOc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbox2.SuspendLayout()
        CType(Me.DgDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbox3.SuspendLayout()
        CType(Me.textRemito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDocP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbox1
        '
        Appearance1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gpbox1.ContentAreaAppearance = Appearance1
        Me.gpbox1.Controls.Add(Me.DgOc)
        Me.gpbox1.Controls.Add(Me.Label2)
        Me.gpbox1.Location = New System.Drawing.Point(16, 8)
        Me.gpbox1.Name = "gpbox1"
        Me.gpbox1.Size = New System.Drawing.Size(624, 288)
        Me.gpbox1.SupportThemes = False
        Me.gpbox1.TabIndex = 0
        Me.gpbox1.Text = "Pendientes"
        Me.gpbox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'DgOc
        '
        Me.DgOc.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DgOc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgOc.BackgroundColor = System.Drawing.Color.LightGray
        Me.DgOc.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DgOc.CaptionForeColor = System.Drawing.Color.DimGray
        Me.DgOc.CaptionText = "Pedidos"
        Me.DgOc.DataMember = ""
        Me.DgOc.FlatMode = True
        Me.DgOc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgOc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DgOc.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DgOc.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DgOc.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DgOc.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgOc.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgOc.LinkColor = System.Drawing.Color.Teal
        Me.DgOc.Location = New System.Drawing.Point(32, 56)
        Me.DgOc.Name = "DgOc"
        Me.DgOc.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DgOc.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DgOc.ReadOnly = True
        Me.DgOc.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DgOc.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgOc.Size = New System.Drawing.Size(480, 216)
        Me.DgOc.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione el pedido a recibir"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(416, 304)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(96, 24)
        Me.BtnSiguiente.TabIndex = 1
        Me.BtnSiguiente.Text = "&Siguiente>>"
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(320, 304)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(96, 24)
        Me.BtnAtras.TabIndex = 2
        Me.BtnAtras.Text = "<<&Atras"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(552, 304)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(88, 24)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "&Salir"
        '
        'gpbox2
        '
        Appearance2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gpbox2.ContentAreaAppearance = Appearance2
        Me.gpbox2.Controls.Add(Me.DgDoc)
        Me.gpbox2.Controls.Add(Me.Label1)
        Me.gpbox2.Location = New System.Drawing.Point(16, 8)
        Me.gpbox2.Name = "gpbox2"
        Me.gpbox2.Size = New System.Drawing.Size(624, 288)
        Me.gpbox2.SupportThemes = False
        Me.gpbox2.TabIndex = 4
        Me.gpbox2.Text = "Pendientes"
        Me.gpbox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'DgDoc
        '
        Me.DgDoc.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DgDoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgDoc.BackgroundColor = System.Drawing.Color.LightGray
        Me.DgDoc.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DgDoc.CaptionForeColor = System.Drawing.Color.DimGray
        Me.DgDoc.CaptionText = "Items de pedido"
        Me.DgDoc.DataMember = ""
        Me.DgDoc.FlatMode = True
        Me.DgDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DgDoc.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DgDoc.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DgDoc.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DgDoc.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDoc.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgDoc.LinkColor = System.Drawing.Color.Teal
        Me.DgDoc.Location = New System.Drawing.Point(24, 72)
        Me.DgDoc.Name = "DgDoc"
        Me.DgDoc.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DgDoc.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DgDoc.ReadOnly = True
        Me.DgDoc.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DgDoc.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgDoc.Size = New System.Drawing.Size(472, 192)
        Me.DgDoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'gpbox3
        '
        Appearance3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gpbox3.ContentAreaAppearance = Appearance3
        Me.gpbox3.Controls.Add(Me.UltraLabel2)
        Me.gpbox3.Controls.Add(Me.textRemito)
        Me.gpbox3.Controls.Add(Me.LstDoc)
        Me.gpbox3.Controls.Add(Me.dgDocP)
        Me.gpbox3.Controls.Add(Me.UltraLabel1)
        Me.gpbox3.Location = New System.Drawing.Point(16, 8)
        Me.gpbox3.Name = "gpbox3"
        Me.gpbox3.Size = New System.Drawing.Size(624, 288)
        Me.gpbox3.SupportThemes = False
        Me.gpbox3.TabIndex = 5
        Me.gpbox3.Text = "Pendientes"
        Me.gpbox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraLabel2
        '
        Me.UltraLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 168)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel2.TabIndex = 6
        Me.UltraLabel2.Text = "Recibidos"
        '
        'textRemito
        '
        Me.textRemito.Location = New System.Drawing.Point(280, 208)
        Me.textRemito.Name = "textRemito"
        Me.textRemito.Size = New System.Drawing.Size(96, 21)
        Me.textRemito.TabIndex = 4
        '
        'LstDoc
        '
        Me.LstDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstDoc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstDoc.FullRowSelect = True
        Me.LstDoc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstDoc.Location = New System.Drawing.Point(16, 184)
        Me.LstDoc.Name = "LstDoc"
        Me.LstDoc.Size = New System.Drawing.Size(224, 88)
        Me.LstDoc.TabIndex = 3
        Me.LstDoc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Materia prima"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Precio"
        Me.ColumnHeader2.Width = 59
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        Me.ColumnHeader3.Width = 80
        '
        'dgDocP
        '
        Me.dgDocP.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgDocP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgDocP.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgDocP.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgDocP.CaptionForeColor = System.Drawing.Color.DimGray
        Me.dgDocP.CaptionText = "Pendientes"
        Me.dgDocP.DataMember = ""
        Me.dgDocP.FlatMode = True
        Me.dgDocP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDocP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgDocP.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgDocP.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgDocP.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgDocP.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDocP.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgDocP.LinkColor = System.Drawing.Color.Teal
        Me.dgDocP.Location = New System.Drawing.Point(16, 32)
        Me.dgDocP.Name = "dgDocP"
        Me.dgDocP.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgDocP.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgDocP.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgDocP.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgDocP.Size = New System.Drawing.Size(592, 132)
        Me.dgDocP.TabIndex = 2
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.BackColor2 = System.Drawing.Color.Transparent
        Appearance4.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Appearance4.BackColorDisabled = System.Drawing.Color.Transparent
        Appearance4.BackColorDisabled2 = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Location = New System.Drawing.Point(280, 192)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Numero de remito"
        '
        'frmRecibirMPII
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 344)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.gpbox1)
        Me.Controls.Add(Me.gpbox2)
        Me.Controls.Add(Me.gpbox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "frmRecibirMPII"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recepcion materia prima"
        CType(Me.gpbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbox1.ResumeLayout(False)
        CType(Me.DgOc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpbox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbox2.ResumeLayout(False)
        CType(Me.DgDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpbox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbox3.ResumeLayout(False)
        CType(Me.textRemito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDocP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim DS As New DataSet
    Dim dtOC As New DataTable
    Dim dvDOC As New DataView
    Dim Sqldataadapter1 As New SqlDataAdapter("select fecharealizacion, nroorden,ordencompramp.idordencompra, ordencompramp.idproveedor, proveedor.nombre from ordencompramp inner join proveedor on ordencompramp.idproveedor = proveedor.idproveedor where ordencompramp.idestado=1", cnn)
    Dim Sqldataadapter2 As New SqlDataAdapter("select tipomateriaprima.nombre, cantidad, precio, idordencompra, detalleordencompra.idtipomateriaprima from detalleordencompra inner join tipomateriaprima on detalleordencompra.idtipomateriaprima = tipomateriaprima.idtipomateriaprima where idordencompra in (select idordencompra from ordencompramp where idestado =1) and idestado =1 ", cnn)
    ''IDESTADO =1 ES "PENDIENTE DE ENTREGA" tendriamos que agregar la tabra estado


    Private Sub frmRecibirMPII_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'princ.barra.agregarBoton(Me)

        cnn.Open()
        Sqldataadapter1.Fill(DS, "ordencompramp")
        Sqldataadapter2.Fill(DS, "detalleordencompra")
        cnn.Close()
        gpbox1.Visible = True
        gpbox2.Visible = False
        gpbox3.Visible = False


        dtOC = DS.Tables("ordencompramp")
        dvDOC = DS.Tables("detalleordencompra").DefaultView
        Dim colsdv As DataColumnCollection
        Dim dcoldv1 As New DataColumn
        dcoldv1.DefaultValue = "N"
        colsdv = dvDOC.Table.Columns
        colsdv.Add(dcoldv1)
        Dim dcoldv2 As New DataColumn
        dcoldv2.DefaultValue = "No recibido"
        dcoldv2.ColumnName = "causa"
        colsdv.Add(dcoldv2)
        Dim dcoldv3 As New DataColumn
        dcoldv3.DefaultValue = ""
        dcoldv3.ColumnName = "descripcion"
        colsdv.Add(dcoldv3)
        Dim dcoldv4 As New DataColumn
        dcoldv4.ColumnName = "cantidadr"
        colsdv.Add(dcoldv4)
        CargarColCantR()

        LoadGrid_oc()
        LoadGrid_docP()
        LoadGrid_doc()
        
    End Sub
    Private Sub CargarColCantR()
        Dim fila As DataRow
        For Each fila In dvDOC.Table.Rows
            fila.Item("cantidadr") = fila.Item("cantidad")
        Next
    End Sub
    Private Sub LoadGrid_oc()
        'por que tengo que poner esto aca si lo estoy pasando por parametro
        DgOc.DataSource = dtOC
        Dim nom(4) As String
        nom(0) = "Fecha realizacion"
        nom(1) = "Numero orden"
        nom(3) = "Proveedor"
        Dim ancho(4) As Integer
        ancho(0) = 150
        ancho(1) = 120
        ancho(3) = 150
        cargarGrilla(DgOc, dtOC, nom, ancho)

    End Sub
    Private Sub LoadGrid_doc()

        Dim ts As DataGridTableStyle = CGrid.GetTableStyle(dvDOC)

        'CheckBox Column columnstyle1
        Dim cs1 As New CGridCheckBoxStyle("Column1", 55, _
                                          HorizontalAlignment.Center, False, _
                                          "Recibir", "", "N", "Y", False, "")
        CGrid.AddColumn(ts, cs1)

        'TextBox Column
        Dim cs2 As New CGridTextBoxStyle("nombre", 150, _
                                          HorizontalAlignment.Center, True, _
                                          "Materia Prima", String.Empty, "")
        CGrid.AddColumn(ts, cs2)
        'text box
        Dim cs3 As New CGridTextBoxStyle("precio", 130, _
                                        HorizontalAlignment.Center, True, _
                                        "Precio", String.Empty, "")


        CGrid.AddColumn(ts, cs3)

        'TextBox Column - ReadOnly
        'Dim cs4 As New CGridTextBoxStyle("cantidad", 80, _
        '                                 HorizontalAlignment.Left, True, _
        '                                 "Cantidad", String.Empty, "")
        Dim cs4 As New CGridNumericUpDownStyle("cantidadr", 80, _
                                                "Cantidad", 0, _
                                                1000, _
                                                0, 1, LeftRightAlignment.Right, _
                                                0, "")

        CGrid.AddColumn(ts, cs4)


        CGrid.SetGridStyle(Me.DgDoc, DS.Tables("detalleordencompra"), ts)
    End Sub
    Private Sub LoadGrid_docP()


        Dim ts1 As DataGridTableStyle = CGrid.GetTableStyle(dvDOC)


        'TextBox Column
        Dim cs2 As New CGridTextBoxStyle("nombre", 110, _
                                          HorizontalAlignment.Center, True, _
                                          "Materia Prima", String.Empty, "")
        CGrid.AddColumn(ts1, cs2)
        'text box
        Dim cs3 As New CGridTextBoxStyle("precio", 80, _
                                        HorizontalAlignment.Center, True, _
                                        "Precio", String.Empty, "")


        CGrid.AddColumn(ts1, cs3)

        'TextBox Column - ReadOnly
        Dim cs4 As New CGridTextBoxStyle("cantidad", 50, _
                                         HorizontalAlignment.Left, True, _
                                         "Cantidad", String.Empty, "")
        CGrid.AddColumn(ts1, cs4)
        'combo box rechazado--no recibido

        Dim Items() As String = {"No recibido", "Entrega parcial", "Rechazado"}
        Dim cs5 As New CGridComboBoxStyle("causa", 100, _
                                         HorizontalAlignment.Left, _
                                        "Causa de no recepcion", "(null)", _
                                       Items, ComboBoxStyle.DropDown)
        CGrid.AddColumn(ts1, cs5)
        Dim cs6 As New CGridMultiLineTextBoxStyle("descripcion", 200, _
                                                    HorizontalAlignment.Left, False, _
                                                    "Descripcion", "")
        CGrid.AddColumn(ts1, cs6)




        CGrid.SetGridStyle(Me.dgDocP, DS.Tables("detalleordencompra"), ts1)
    End Sub
    Private Sub cargar_lista()
        Dim i As Integer
        Dim item As ListViewItem
        For i = 0 To dvDOC.Count - 1
            If dvDOC.Item(i).Item("Column1") = "Y" Then
                item = LstDoc.Items.Add(dvDOC.Item(i).Item("nombre"))
                item.SubItems.Add(dvDOC.Item(i).Item("precio"))
                item.SubItems.Add(dvDOC.Item(i).Item("cantidadr"))

            End If
        Next i
    End Sub
    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        If gpbox1.Visible Then
            Me.gpbox1.Visible = False
            Me.gpbox2.Visible = True
            Me.Label1.Text = "Orden de compra Nº: " & DgOc.Item(DgOc.CurrentCell.RowNumber, 1) & "  Realizada el dia: " & DgOc.Item(DgOc.CurrentCell.RowNumber, 0) & " Proveedor: " & DgOc.Item(DgOc.CurrentCell.RowNumber, 4)
            dvDOC.RowFilter = "idordencompra =" & DgOc.Item(DgOc.CurrentCell.RowNumber, 2)
        Else
            If gpbox2.Visible Then
                Me.gpbox2.Visible = False
                Me.gpbox3.Visible = True
                BtnSiguiente.Text = "&Finalizar"
                LstDoc.Items.Clear()
                cargar_lista()
                Dim i As Integer
                For i = 0 To dvDOC.Count - 1
                    If dvDOC.Item(i).Item("Column1") <> "N" Then
                        dvDOC.Item(i).Item("cantidad") = dvDOC.Item(i).Item("cantidad") - dvDOC.Item(i).Item("cantidadr")
                        dvDOC.Item(i).Item("causa") = "Entrega parcial"
                    End If

                Next i
                dvDOC.RowFilter = "(column1='N'or cantidad <> 0) and idordencompra =" & DgOc.Item(DgOc.CurrentCell.RowNumber, 2)


            Else
                If gpbox3.Visible Then
                    If textRemito.Text <> "" Then
                        carga()
                    Else
                        MsgBox("Primero debe cargar el numero de remito", MsgBoxStyle.OKOnly, "Remito")
                    End If
                End If
                End If
        End If


    End Sub

    Private Sub BtnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtras.Click
        If gpbox2.Visible Then
            Dim i As Integer
            For i = 0 To dvDOC.Count - 1
                dvDOC.Item(i).Item("Column1") = "N"
                dvDOC.Item(i).Item("cantidadr") = dvDOC.Item(i).Item("cantidad")
            Next i
            Me.gpbox1.Visible = True
            Me.gpbox2.Visible = False
        Else
            If gpbox3.Visible Then
                Me.gpbox2.Visible = True
                Me.gpbox3.Visible = False
                BtnSiguiente.Text = "&Siguiente"
                dvDOC.RowFilter = "idordencompra =" & DgOc.Item(DgOc.CurrentCell.RowNumber, 2)
                Dim i As Integer
                For i = 0 To dvDOC.Count - 1
                    If dvDOC.Item(i).Item("Column1") <> "N" Or dvDOC.Item(i).Item("cantidad") <> dvDOC.Item(i).Item("cantidadr") Then
                        dvDOC.Item(i).Item("cantidad") = dvDOC.Item(i).Item("cantidad") + dvDOC.Item(i).Item("cantidadr")
                    End If

                Next i

            End If
        End If
    End Sub

    Private Sub DgDoc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgDoc.MouseUp
        Dim row As Integer
        row = DgDoc.CurrentCell.RowNumber
        If sel_check_col(DgDoc, 0, e) Then
            Select Case dvDOC.Item(DgDoc.CurrentRowIndex).Item("Column1")
                Case "N"
                    dvDOC.Item(DgDoc.CurrentRowIndex).Item("Column1") = "Y"

                Case "Y"
                    dvDOC.Item(DgDoc.CurrentRowIndex).Item("Column1") = "N"

            End Select
            DgDoc.Select(row)
        End If
        DgDoc.Refresh()

    End Sub

    'Private Sub DgDoc_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgDoc.CurrentCellChanged
        
    ' DgDoc.Select(DgDoc.CurrentCell.RowNumber)
    ' End Sub
    
    Private Sub dgOC_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgOc.CurrentCellChanged
        DgOc.Select(DgOc.CurrentCell.RowNumber)
        dvDOC.RowFilter = "idordencompra =" & DgOc.Item(DgOc.CurrentCell.RowNumber, 2)
    End Sub

    Private Sub carga()
        If MsgBox("Confirma recepcion", MsgBoxStyle.YesNo, "Confirmacion") Then
            dvDOC.RowFilter = "idordencompra =" & DgOc.Item(DgOc.CurrentCell.RowNumber, 2)
            Try
                Dim mprec As Integer
                Dim sqlcommandDMPR As New SqlCommand
                Dim sqlcommandOC As New SqlCommand
                Dim sqlcommandMPR As New SqlCommand
                Dim sqlcommandTMP As New SqlCommand
                sqlcommandDMPR.CommandType = CommandType.Text
                sqlcommandDMPR.Connection = cnn
                sqlcommandOC.CommandType = CommandType.Text
                sqlcommandOC.Connection = cnn
                sqlcommandTMP.Connection = cnn
                sqlcommandMPR.CommandType = CommandType.Text
                sqlcommandMPR.Connection = cnn
                cnn.Open()
                ''' para sacar el nro max de mprecibida
                Dim sqlcommandMPR2 As New SqlCommand
                sqlcommandMPR2.CommandType = CommandType.Text
                sqlcommandMPR2.Connection = cnn
                sqlcommandMPR2.CommandText = "select max(idmprecibida) from  mprecibida"
                mprec = sqlcommandMPR2.ExecuteScalar() + 1

                Dim banpedincompleto As New Boolean
                banpedincompleto = False





                'cambio estado doc
                Dim sqlcommandDOC As New SqlCommand
                sqlcommandDOC.CommandType = CommandType.Text
                sqlcommandDOC.Connection = cnn
                'Dim fila As DataRow
                Dim band As Boolean
                band = False



                Dim i As Integer


                For i = 0 To dvDOC.Count - 1

                    If dvDOC.Item(i).Item("Column1") = "Y" Then
                        If dvDOC.Item(i).Item("cantidad") = 0 Then
                            sqlcommandDOC.CommandText = "update detalleordencompra set idestado = 3 where idordencompra=" _
                                                & DgOc.Item(DgOc.CurrentCell.RowNumber, 2) & _
                                                "and idtipomateriaprima =" & dvDOC.Item(i).Item("idtipomateriaprima")
                        Else
                            banpedincompleto = True

                            sqlcommandDOC.CommandText = "update detalleordencompra set cantidad = " & CType(dvDOC.Item(i).Item("cantidad"), Integer) _
                                                                        & "  where idordencompra=" _
                                                                        & DgOc.Item(DgOc.CurrentCell.RowNumber, 2) & _
                                                                        "and idtipomateriaprima =" & dvDOC.Item(i).Item("idtipomateriaprima")

                        End If
                        sqlcommandDOC.ExecuteNonQuery()
                        sqlcommandTMP.CommandText = "update tipomateriaprima set stockactual = stockactual + " & dvDOC.Item(i).Item("cantidadr") & "where idtipomateriaprima = " & dvDOC.Item(i).Item("idtipomateriaprima")
                        sqlcommandTMP.ExecuteNonQuery()

                        If band = False Then 'cargo mprecibida 1 sola vez                  
                            sqlcommandMPR.CommandText = "insert into mprecibida values (" & mprec & ", '" & Today & "'," _
                                    & CType(textRemito.Text, Integer) & ", " & DgOc.Item(DgOc.CurrentCell.RowNumber, 2) & ")"
                            sqlcommandMPR.ExecuteNonQuery()
                            band = True
                        End If 'falta la causa
                        'cargo detalle mp recibida
                        Dim mpr As String
                        mpr = "insert into detallemprecibida values (" & mprec & "," _
                        & CType(dvDOC.Item(i).Item("cantidadr"), Integer) & ",$" & dvDOC.Item(i).Item("precio") & ",'', 3," _
                        & dvDOC.Item(i).Item("idtipomateriaprima") & ")"
                        'sqlcommandDMPR.CommandText = "insert into detallemprecibida values (" & mprec & "," _
                        '& CType(dvDOC.Item(i).Item("cantidadr"), Integer) & "," & dvDOC.Item(i).Item("precio") & ",'', 3," _
                        '& dvDOC.Item(i).Item("idtipomateriaprima") & ")"
                        sqlcommandDMPR.CommandText = mpr
                        sqlcommandDMPR.ExecuteNonQuery()
                    Else 'no la pongo como recibida pero si registro  se rechazo a una materia prima especifica
                        banpedincompleto = True

                        'estado RECHAZADO =6
                        If dvDOC.Item(i).Item("causa") = "Rechazado" Then

                            If band = False Then 'cargo mprecibida 1 sola vez                  
                                sqlcommandMPR.CommandText = "insert into mprecibida values (" & mprec & ", '" & Today & "'," _
                                        & CType(textRemito.Text, Integer) & ", " & DgOc.Item(DgOc.CurrentCell.RowNumber, 2) & ")"
                                sqlcommandMPR.ExecuteNonQuery()
                                band = True
                            End If

                            sqlcommandDMPR.CommandText = "insert into detallemprecibida values (" & mprec & "," _
                            & CType(dvDOC.Item(i).Item("cantidad"), Integer) & " , " & dvDOC.Item(i).Item("precio") & "," & "'" _
                            & dvDOC.Item(i).Item("descripcion") & "', 6," & dvDOC.Item(i).Item("idtipomateriaprima") _
                            & ")"
                            sqlcommandDMPR.ExecuteNonQuery()

                        End If
                    End If

                Next
                If Not banpedincompleto Then
                    sqlcommandOC.CommandText = "update ordencompramp set idestado =3 where nroorden=" _
                                           & DgOc.Item(DgOc.CurrentCell.RowNumber, 1)
                    sqlcommandOC.ExecuteNonQuery()

                End If

                cnn.Close()
                MsgBox("Recepcion registrada", MsgBoxStyle.Information, "Materiales recibidos")

                Me.Close()

            Catch exp As Exception
                MsgBox(exp.Message, MsgBoxStyle.Critical, Me.Text)
                cnn.Close()
            End Try
        End If

    End Sub


    ' Private Sub dgDocP_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDocP.CurrentCellChanged
    '  dgDocP.Select(dgDocP.CurrentCell.RowNumber)
    'End Sub

    Private Sub frmRecibirMPII_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub gpbox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpbox3.Click

    End Sub

    Private Sub gpbox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpbox2.Click

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
