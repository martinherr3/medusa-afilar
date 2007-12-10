<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestorReportesComForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestorReportesComForm))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tabCompra = New System.Windows.Forms.TabControl
        Me.tabOrdenDeCompra = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.comboCompraEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.checkCompraFecha = New System.Windows.Forms.CheckBox
        Me.compraHasta = New System.Windows.Forms.DateTimePicker
        Me.compraDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.comboCompraProveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkCompraEstado = New System.Windows.Forms.CheckBox
        Me.btnCompra = New Infragistics.Win.Misc.UltraButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.checkCompraProveedor = New System.Windows.Forms.CheckBox
        Me.tabDetalle = New System.Windows.Forms.TabPage
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.comboDetalleOCMP = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkDetalleOCMP = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.comboDetalleOCProveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkDetalleOCProveedor = New System.Windows.Forms.CheckBox
        Me.comboDetalleOCEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkDetalleOCEstado = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.checkFechaDetalleOC = New System.Windows.Forms.CheckBox
        Me.detalleOCHasta = New System.Windows.Forms.DateTimePicker
        Me.detalleOCDesde = New System.Windows.Forms.DateTimePicker
        Me.btnDetalleOC = New Infragistics.Win.Misc.UltraButton
        Me.tabServicios = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.checkStockSeguridad = New System.Windows.Forms.CheckBox
        Me.checkStockMinimo = New System.Windows.Forms.CheckBox
        Me.btnMP = New Infragistics.Win.Misc.UltraButton
        Me.comboABC = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkMPABC = New System.Windows.Forms.CheckBox
        Me.imageLoading = New System.Windows.Forms.PictureBox
        Me.tabCompra.SuspendLayout()
        Me.tabOrdenDeCompra.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboCompraEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboCompraProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalle.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboDetalleOCMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboDetalleOCProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboDetalleOCEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServicios.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Location = New System.Drawing.Point(12, 173)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(790, 377)
        Me.crv.TabIndex = 41
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'tabCompra
        '
        Me.tabCompra.Controls.Add(Me.tabOrdenDeCompra)
        Me.tabCompra.Controls.Add(Me.tabDetalle)
        Me.tabCompra.Controls.Add(Me.tabServicios)
        Me.tabCompra.Location = New System.Drawing.Point(12, 10)
        Me.tabCompra.Name = "tabCompra"
        Me.tabCompra.SelectedIndex = 0
        Me.tabCompra.Size = New System.Drawing.Size(790, 157)
        Me.tabCompra.TabIndex = 57
        '
        'tabOrdenDeCompra
        '
        Me.tabOrdenDeCompra.Controls.Add(Me.PictureBox2)
        Me.tabOrdenDeCompra.Controls.Add(Me.PictureBox1)
        Me.tabOrdenDeCompra.Controls.Add(Me.comboCompraEstado)
        Me.tabOrdenDeCompra.Controls.Add(Me.UltraGroupBox1)
        Me.tabOrdenDeCompra.Controls.Add(Me.Label2)
        Me.tabOrdenDeCompra.Controls.Add(Me.comboCompraProveedor)
        Me.tabOrdenDeCompra.Controls.Add(Me.checkCompraEstado)
        Me.tabOrdenDeCompra.Controls.Add(Me.btnCompra)
        Me.tabOrdenDeCompra.Controls.Add(Me.Label4)
        Me.tabOrdenDeCompra.Controls.Add(Me.checkCompraProveedor)
        Me.tabOrdenDeCompra.Location = New System.Drawing.Point(4, 22)
        Me.tabOrdenDeCompra.Name = "tabOrdenDeCompra"
        Me.tabOrdenDeCompra.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrdenDeCompra.Size = New System.Drawing.Size(782, 131)
        Me.tabOrdenDeCompra.TabIndex = 0
        Me.tabOrdenDeCompra.Text = "Orden de compra"
        Me.tabOrdenDeCompra.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(554, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(554, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'comboCompraEstado
        '
        Me.comboCompraEstado.AutoSize = True
        Me.comboCompraEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboCompraEstado.Location = New System.Drawing.Point(348, 57)
        Me.comboCompraEstado.Name = "comboCompraEstado"
        Me.comboCompraEstado.Size = New System.Drawing.Size(205, 21)
        Me.comboCompraEstado.TabIndex = 55
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.PictureBox3)
        Me.UltraGroupBox1.Controls.Add(Me.checkCompraFecha)
        Me.UltraGroupBox1.Controls.Add(Me.compraHasta)
        Me.UltraGroupBox1.Controls.Add(Me.compraDesde)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(54, 9)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(223, 107)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 43
        Me.UltraGroupBox1.Text = "Fecha estimada entrega"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 73)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 58
        Me.PictureBox3.TabStop = False
        '
        'checkCompraFecha
        '
        Me.checkCompraFecha.AutoSize = True
        Me.checkCompraFecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkCompraFecha.Location = New System.Drawing.Point(33, 76)
        Me.checkCompraFecha.Name = "checkCompraFecha"
        Me.checkCompraFecha.Size = New System.Drawing.Size(59, 17)
        Me.checkCompraFecha.TabIndex = 43
        Me.checkCompraFecha.Text = "Activar"
        Me.checkCompraFecha.UseVisualStyleBackColor = False
        '
        'compraHasta
        '
        Me.compraHasta.Location = New System.Drawing.Point(6, 49)
        Me.compraHasta.Name = "compraHasta"
        Me.compraHasta.Size = New System.Drawing.Size(211, 20)
        Me.compraHasta.TabIndex = 42
        '
        'compraDesde
        '
        Me.compraDesde.Location = New System.Drawing.Point(6, 23)
        Me.compraDesde.Name = "compraDesde"
        Me.compraDesde.Size = New System.Drawing.Size(211, 20)
        Me.compraDesde.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(291, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Proveedor"
        '
        'comboCompraProveedor
        '
        Me.comboCompraProveedor.AutoSize = True
        Me.comboCompraProveedor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboCompraProveedor.Location = New System.Drawing.Point(348, 30)
        Me.comboCompraProveedor.Name = "comboCompraProveedor"
        Me.comboCompraProveedor.Size = New System.Drawing.Size(205, 21)
        Me.comboCompraProveedor.TabIndex = 53
        '
        'checkCompraEstado
        '
        Me.checkCompraEstado.AutoSize = True
        Me.checkCompraEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkCompraEstado.Location = New System.Drawing.Point(581, 61)
        Me.checkCompraEstado.Name = "checkCompraEstado"
        Me.checkCompraEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkCompraEstado.TabIndex = 52
        Me.checkCompraEstado.Text = "Activar"
        Me.checkCompraEstado.UseVisualStyleBackColor = False
        '
        'btnCompra
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnCompra.Appearance = Appearance1
        Me.btnCompra.Location = New System.Drawing.Point(457, 85)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(96, 31)
        Me.btnCompra.TabIndex = 39
        Me.btnCompra.Text = "Actualizar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(307, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Estado"
        '
        'checkCompraProveedor
        '
        Me.checkCompraProveedor.AutoSize = True
        Me.checkCompraProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.checkCompraProveedor.Location = New System.Drawing.Point(581, 33)
        Me.checkCompraProveedor.Name = "checkCompraProveedor"
        Me.checkCompraProveedor.Size = New System.Drawing.Size(59, 17)
        Me.checkCompraProveedor.TabIndex = 50
        Me.checkCompraProveedor.Text = "Activar"
        Me.checkCompraProveedor.UseVisualStyleBackColor = False
        '
        'tabDetalle
        '
        Me.tabDetalle.AutoScroll = True
        Me.tabDetalle.Controls.Add(Me.PictureBox12)
        Me.tabDetalle.Controls.Add(Me.comboDetalleOCMP)
        Me.tabDetalle.Controls.Add(Me.checkDetalleOCMP)
        Me.tabDetalle.Controls.Add(Me.Label10)
        Me.tabDetalle.Controls.Add(Me.PictureBox6)
        Me.tabDetalle.Controls.Add(Me.PictureBox5)
        Me.tabDetalle.Controls.Add(Me.Label5)
        Me.tabDetalle.Controls.Add(Me.comboDetalleOCProveedor)
        Me.tabDetalle.Controls.Add(Me.checkDetalleOCProveedor)
        Me.tabDetalle.Controls.Add(Me.comboDetalleOCEstado)
        Me.tabDetalle.Controls.Add(Me.checkDetalleOCEstado)
        Me.tabDetalle.Controls.Add(Me.Label1)
        Me.tabDetalle.Controls.Add(Me.UltraGroupBox2)
        Me.tabDetalle.Controls.Add(Me.btnDetalleOC)
        Me.tabDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalle.Size = New System.Drawing.Size(782, 131)
        Me.tabDetalle.TabIndex = 1
        Me.tabDetalle.Text = "Orden de compra con detalles"
        Me.tabDetalle.UseVisualStyleBackColor = True
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(548, 83)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox12.TabIndex = 67
        Me.PictureBox12.TabStop = False
        '
        'comboDetalleOCMP
        '
        Me.comboDetalleOCMP.AutoSize = True
        Me.comboDetalleOCMP.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboDetalleOCMP.Location = New System.Drawing.Point(340, 83)
        Me.comboDetalleOCMP.Name = "comboDetalleOCMP"
        Me.comboDetalleOCMP.Size = New System.Drawing.Size(205, 21)
        Me.comboDetalleOCMP.TabIndex = 66
        '
        'checkDetalleOCMP
        '
        Me.checkDetalleOCMP.AutoSize = True
        Me.checkDetalleOCMP.BackColor = System.Drawing.SystemColors.Control
        Me.checkDetalleOCMP.Location = New System.Drawing.Point(575, 87)
        Me.checkDetalleOCMP.Name = "checkDetalleOCMP"
        Me.checkDetalleOCMP.Size = New System.Drawing.Size(59, 17)
        Me.checkDetalleOCMP.TabIndex = 65
        Me.checkDetalleOCMP.Text = "Activar"
        Me.checkDetalleOCMP.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(270, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Materia prima"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(548, 56)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 63
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(548, 30)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 62
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(281, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Proveedor"
        '
        'comboDetalleOCProveedor
        '
        Me.comboDetalleOCProveedor.AutoSize = True
        Me.comboDetalleOCProveedor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboDetalleOCProveedor.Location = New System.Drawing.Point(340, 56)
        Me.comboDetalleOCProveedor.Name = "comboDetalleOCProveedor"
        Me.comboDetalleOCProveedor.Size = New System.Drawing.Size(205, 21)
        Me.comboDetalleOCProveedor.TabIndex = 61
        '
        'checkDetalleOCProveedor
        '
        Me.checkDetalleOCProveedor.AutoSize = True
        Me.checkDetalleOCProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.checkDetalleOCProveedor.Location = New System.Drawing.Point(575, 58)
        Me.checkDetalleOCProveedor.Name = "checkDetalleOCProveedor"
        Me.checkDetalleOCProveedor.Size = New System.Drawing.Size(59, 17)
        Me.checkDetalleOCProveedor.TabIndex = 60
        Me.checkDetalleOCProveedor.Text = "Activar"
        Me.checkDetalleOCProveedor.UseVisualStyleBackColor = False
        '
        'comboDetalleOCEstado
        '
        Me.comboDetalleOCEstado.AutoSize = True
        Me.comboDetalleOCEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboDetalleOCEstado.Location = New System.Drawing.Point(340, 30)
        Me.comboDetalleOCEstado.Name = "comboDetalleOCEstado"
        Me.comboDetalleOCEstado.Size = New System.Drawing.Size(205, 21)
        Me.comboDetalleOCEstado.TabIndex = 58
        '
        'checkDetalleOCEstado
        '
        Me.checkDetalleOCEstado.AutoSize = True
        Me.checkDetalleOCEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkDetalleOCEstado.Location = New System.Drawing.Point(575, 32)
        Me.checkDetalleOCEstado.Name = "checkDetalleOCEstado"
        Me.checkDetalleOCEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkDetalleOCEstado.TabIndex = 57
        Me.checkDetalleOCEstado.Text = "Activar"
        Me.checkDetalleOCEstado.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(297, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Estado"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.PictureBox4)
        Me.UltraGroupBox2.Controls.Add(Me.checkFechaDetalleOC)
        Me.UltraGroupBox2.Controls.Add(Me.detalleOCHasta)
        Me.UltraGroupBox2.Controls.Add(Me.detalleOCDesde)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(43, 11)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(223, 105)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 44
        Me.UltraGroupBox2.Text = "Fecha estimada entrega"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 71)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 59
        Me.PictureBox4.TabStop = False
        '
        'checkFechaDetalleOC
        '
        Me.checkFechaDetalleOC.AutoSize = True
        Me.checkFechaDetalleOC.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkFechaDetalleOC.Location = New System.Drawing.Point(33, 74)
        Me.checkFechaDetalleOC.Name = "checkFechaDetalleOC"
        Me.checkFechaDetalleOC.Size = New System.Drawing.Size(59, 17)
        Me.checkFechaDetalleOC.TabIndex = 43
        Me.checkFechaDetalleOC.Text = "Activar"
        Me.checkFechaDetalleOC.UseVisualStyleBackColor = False
        '
        'detalleOCHasta
        '
        Me.detalleOCHasta.Location = New System.Drawing.Point(6, 46)
        Me.detalleOCHasta.Name = "detalleOCHasta"
        Me.detalleOCHasta.Size = New System.Drawing.Size(211, 20)
        Me.detalleOCHasta.TabIndex = 42
        '
        'detalleOCDesde
        '
        Me.detalleOCDesde.Location = New System.Drawing.Point(6, 20)
        Me.detalleOCDesde.Name = "detalleOCDesde"
        Me.detalleOCDesde.Size = New System.Drawing.Size(211, 20)
        Me.detalleOCDesde.TabIndex = 41
        '
        'btnDetalleOC
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnDetalleOC.Appearance = Appearance2
        Me.btnDetalleOC.Location = New System.Drawing.Point(640, 73)
        Me.btnDetalleOC.Name = "btnDetalleOC"
        Me.btnDetalleOC.Size = New System.Drawing.Size(96, 31)
        Me.btnDetalleOC.TabIndex = 41
        Me.btnDetalleOC.Text = "Actualizar"
        '
        'tabServicios
        '
        Me.tabServicios.Controls.Add(Me.Label3)
        Me.tabServicios.Controls.Add(Me.PictureBox9)
        Me.tabServicios.Controls.Add(Me.checkStockSeguridad)
        Me.tabServicios.Controls.Add(Me.checkStockMinimo)
        Me.tabServicios.Controls.Add(Me.btnMP)
        Me.tabServicios.Controls.Add(Me.comboABC)
        Me.tabServicios.Controls.Add(Me.checkMPABC)
        Me.tabServicios.Location = New System.Drawing.Point(4, 22)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServicios.Size = New System.Drawing.Size(782, 131)
        Me.tabServicios.TabIndex = 3
        Me.tabServicios.Text = "Materia Prima"
        Me.tabServicios.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Clasificacion"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(421, 32)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 69
        Me.PictureBox9.TabStop = False
        '
        'checkStockSeguridad
        '
        Me.checkStockSeguridad.AutoSize = True
        Me.checkStockSeguridad.BackColor = System.Drawing.SystemColors.Control
        Me.checkStockSeguridad.Location = New System.Drawing.Point(213, 82)
        Me.checkStockSeguridad.Name = "checkStockSeguridad"
        Me.checkStockSeguridad.Size = New System.Drawing.Size(199, 17)
        Me.checkStockSeguridad.TabIndex = 63
        Me.checkStockSeguridad.Text = "Stock debajo del stock de seguridad"
        Me.checkStockSeguridad.UseVisualStyleBackColor = False
        '
        'checkStockMinimo
        '
        Me.checkStockMinimo.AutoSize = True
        Me.checkStockMinimo.BackColor = System.Drawing.SystemColors.Control
        Me.checkStockMinimo.Location = New System.Drawing.Point(213, 59)
        Me.checkStockMinimo.Name = "checkStockMinimo"
        Me.checkStockMinimo.Size = New System.Drawing.Size(141, 17)
        Me.checkStockMinimo.TabIndex = 62
        Me.checkStockMinimo.Text = "Stock debajo del minimo"
        Me.checkStockMinimo.UseVisualStyleBackColor = False
        '
        'btnMP
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnMP.Appearance = Appearance3
        Me.btnMP.Location = New System.Drawing.Point(456, 65)
        Me.btnMP.Name = "btnMP"
        Me.btnMP.Size = New System.Drawing.Size(90, 34)
        Me.btnMP.TabIndex = 57
        Me.btnMP.Text = "Ejecutar"
        '
        'comboABC
        '
        Me.comboABC.AutoSize = True
        Me.comboABC.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "A"
        ValueListItem1.DisplayText = "Clasificacion Tipo A"
        ValueListItem1.Tag = "A"
        ValueListItem2.DataValue = "B"
        ValueListItem2.DisplayText = "Clasificacion Tipo B"
        ValueListItem2.Tag = "B"
        ValueListItem3.DataValue = "C"
        ValueListItem3.DisplayText = "Clasificacion Tipo C"
        ValueListItem3.Tag = "C"
        Me.comboABC.Items.Add(ValueListItem1)
        Me.comboABC.Items.Add(ValueListItem2)
        Me.comboABC.Items.Add(ValueListItem3)
        Me.comboABC.Location = New System.Drawing.Point(213, 32)
        Me.comboABC.Name = "comboABC"
        Me.comboABC.Size = New System.Drawing.Size(205, 21)
        Me.comboABC.TabIndex = 56
        '
        'checkMPABC
        '
        Me.checkMPABC.AutoSize = True
        Me.checkMPABC.BackColor = System.Drawing.SystemColors.Control
        Me.checkMPABC.Location = New System.Drawing.Point(456, 36)
        Me.checkMPABC.Name = "checkMPABC"
        Me.checkMPABC.Size = New System.Drawing.Size(59, 17)
        Me.checkMPABC.TabIndex = 55
        Me.checkMPABC.Text = "Activar"
        Me.checkMPABC.UseVisualStyleBackColor = False
        '
        'imageLoading
        '
        Me.imageLoading.Image = CType(resources.GetObject("imageLoading.Image"), System.Drawing.Image)
        Me.imageLoading.Location = New System.Drawing.Point(364, 342)
        Me.imageLoading.Name = "imageLoading"
        Me.imageLoading.Size = New System.Drawing.Size(44, 36)
        Me.imageLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imageLoading.TabIndex = 58
        Me.imageLoading.TabStop = False
        Me.imageLoading.Visible = False
        '
        'GestorReportesComForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 562)
        Me.Controls.Add(Me.imageLoading)
        Me.Controls.Add(Me.tabCompra)
        Me.Controls.Add(Me.crv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "GestorReportesComForm"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestor Reportes Compras"
        Me.tabCompra.ResumeLayout(False)
        Me.tabOrdenDeCompra.ResumeLayout(False)
        Me.tabOrdenDeCompra.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboCompraEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboCompraProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalle.ResumeLayout(False)
        Me.tabDetalle.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboDetalleOCMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboDetalleOCProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboDetalleOCEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServicios.ResumeLayout(False)
        Me.tabServicios.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents tabCompra As System.Windows.Forms.TabControl
    Friend WithEvents tabOrdenDeCompra As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents comboCompraEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents checkCompraFecha As System.Windows.Forms.CheckBox
    Friend WithEvents compraHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents compraDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboCompraProveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkCompraEstado As System.Windows.Forms.CheckBox
    Friend WithEvents btnCompra As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents checkCompraProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents tabDetalle As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comboDetalleOCProveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkDetalleOCProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents comboDetalleOCEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkDetalleOCEstado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents checkFechaDetalleOC As System.Windows.Forms.CheckBox
    Friend WithEvents detalleOCHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents detalleOCDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDetalleOC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tabServicios As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents checkStockSeguridad As System.Windows.Forms.CheckBox
    Friend WithEvents checkStockMinimo As System.Windows.Forms.CheckBox
    Friend WithEvents btnMP As Infragistics.Win.Misc.UltraButton
    Friend WithEvents comboABC As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkMPABC As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents comboDetalleOCMP As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkDetalleOCMP As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents imageLoading As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
