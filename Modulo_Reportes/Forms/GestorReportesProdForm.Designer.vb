<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestorReportesProdForm
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestorReportesProdForm))
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tabProduccion = New System.Windows.Forms.TabControl
        Me.tabOrdenDeCompra = New System.Windows.Forms.TabPage
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNroPedido = New System.Windows.Forms.TextBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.comboPedidoModelo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkPedidoModelo = New System.Windows.Forms.CheckBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.comboPedidoEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.checkPedidoFecha = New System.Windows.Forms.CheckBox
        Me.pedidoHasta = New System.Windows.Forms.DateTimePicker
        Me.pedidoDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.comboPedidoCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkPedidoEstado = New System.Windows.Forms.CheckBox
        Me.btnPedido = New Infragistics.Win.Misc.UltraButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.checkPedidoCliente = New System.Windows.Forms.CheckBox
        Me.tabDetalle = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNroSerieSeguimiento = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtNroPedidoSeguimiento = New System.Windows.Forms.TextBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.comboSeguimientoModelo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkSeguimientoModelo = New System.Windows.Forms.CheckBox
        Me.comboSeguimientoEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkSeguimientoEstado = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.checkSeguimientoFecha = New System.Windows.Forms.CheckBox
        Me.fechaSeguimientoHasta = New System.Windows.Forms.DateTimePicker
        Me.fechaSeguimientoDesde = New System.Windows.Forms.DateTimePicker
        Me.btnSeguimiento = New Infragistics.Win.Misc.UltraButton
        Me.tabServicios = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNroPedidoServicio = New System.Windows.Forms.TextBox
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox17 = New System.Windows.Forms.PictureBox
        Me.checkFechaEntrega = New System.Windows.Forms.CheckBox
        Me.fechaEntregaHasta = New System.Windows.Forms.DateTimePicker
        Me.fechaEntregaDesde = New System.Windows.Forms.DateTimePicker
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox18 = New System.Windows.Forms.PictureBox
        Me.checkFechaRealizacion = New System.Windows.Forms.CheckBox
        Me.fechaRealizacionHasta = New System.Windows.Forms.DateTimePicker
        Me.fechaRealizacionDesde = New System.Windows.Forms.DateTimePicker
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.checkServicioEstado = New System.Windows.Forms.CheckBox
        Me.checkServicioOperacion = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.comboServicioEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboServicioOperacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnServicio = New Infragistics.Win.Misc.UltraButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.comboServicioCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkServicioCliente = New System.Windows.Forms.CheckBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox16 = New System.Windows.Forms.PictureBox
        Me.checkFechaRecepcion = New System.Windows.Forms.CheckBox
        Me.fechaRecepcionHasta = New System.Windows.Forms.DateTimePicker
        Me.fechaRecepcionDesde = New System.Windows.Forms.DateTimePicker
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.PictureBox15 = New System.Windows.Forms.PictureBox
        Me.checkFechaSalida = New System.Windows.Forms.CheckBox
        Me.fechaSalidaHasta = New System.Windows.Forms.DateTimePicker
        Me.fechaSalidaDesde = New System.Windows.Forms.DateTimePicker
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        Me.PictureBox14 = New System.Windows.Forms.PictureBox
        Me.checkTorneadoNroserie = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.comboTorneadoNroserie = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnTorneado = New Infragistics.Win.Misc.UltraButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.comboTornero = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkTornero = New System.Windows.Forms.CheckBox
        Me.imageLoading = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.tabProduccion.SuspendLayout()
        Me.tabOrdenDeCompra.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalle.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboSeguimientoModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboSeguimientoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServicios.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboServicioEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboServicioOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboServicioCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboTorneadoNroserie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboTornero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Location = New System.Drawing.Point(15, 172)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(786, 378)
        Me.crv.TabIndex = 41
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'tabProduccion
        '
        Me.tabProduccion.Controls.Add(Me.tabOrdenDeCompra)
        Me.tabProduccion.Controls.Add(Me.tabDetalle)
        Me.tabProduccion.Controls.Add(Me.tabServicios)
        Me.tabProduccion.Controls.Add(Me.TabPage1)
        Me.tabProduccion.Location = New System.Drawing.Point(15, 9)
        Me.tabProduccion.Name = "tabProduccion"
        Me.tabProduccion.SelectedIndex = 0
        Me.tabProduccion.Size = New System.Drawing.Size(786, 157)
        Me.tabProduccion.TabIndex = 58
        '
        'tabOrdenDeCompra
        '
        Me.tabOrdenDeCompra.Controls.Add(Me.Label14)
        Me.tabOrdenDeCompra.Controls.Add(Me.txtNroPedido)
        Me.tabOrdenDeCompra.Controls.Add(Me.PictureBox7)
        Me.tabOrdenDeCompra.Controls.Add(Me.Label6)
        Me.tabOrdenDeCompra.Controls.Add(Me.comboPedidoModelo)
        Me.tabOrdenDeCompra.Controls.Add(Me.checkPedidoModelo)
        Me.tabOrdenDeCompra.Controls.Add(Me.PictureBox2)
        Me.tabOrdenDeCompra.Controls.Add(Me.PictureBox1)
        Me.tabOrdenDeCompra.Controls.Add(Me.comboPedidoEstado)
        Me.tabOrdenDeCompra.Controls.Add(Me.UltraGroupBox1)
        Me.tabOrdenDeCompra.Controls.Add(Me.Label2)
        Me.tabOrdenDeCompra.Controls.Add(Me.comboPedidoCliente)
        Me.tabOrdenDeCompra.Controls.Add(Me.checkPedidoEstado)
        Me.tabOrdenDeCompra.Controls.Add(Me.btnPedido)
        Me.tabOrdenDeCompra.Controls.Add(Me.Label4)
        Me.tabOrdenDeCompra.Controls.Add(Me.checkPedidoCliente)
        Me.tabOrdenDeCompra.Location = New System.Drawing.Point(4, 22)
        Me.tabOrdenDeCompra.Name = "tabOrdenDeCompra"
        Me.tabOrdenDeCompra.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrdenDeCompra.Size = New System.Drawing.Size(778, 131)
        Me.tabOrdenDeCompra.TabIndex = 0
        Me.tabOrdenDeCompra.Text = "Pedidos detallados"
        Me.tabOrdenDeCompra.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(662, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Nro. Pedido"
        '
        'txtNroPedido
        '
        Me.txtNroPedido.Location = New System.Drawing.Point(661, 51)
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(96, 20)
        Me.txtNroPedido.TabIndex = 103
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(559, 88)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 71
        Me.PictureBox7.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(306, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Modelo"
        '
        'comboPedidoModelo
        '
        Me.comboPedidoModelo.AutoSize = True
        Me.comboPedidoModelo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoModelo.Location = New System.Drawing.Point(351, 88)
        Me.comboPedidoModelo.Name = "comboPedidoModelo"
        Me.comboPedidoModelo.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoModelo.TabIndex = 70
        '
        'checkPedidoModelo
        '
        Me.checkPedidoModelo.AutoSize = True
        Me.checkPedidoModelo.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoModelo.Location = New System.Drawing.Point(584, 91)
        Me.checkPedidoModelo.Name = "checkPedidoModelo"
        Me.checkPedidoModelo.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoModelo.TabIndex = 69
        Me.checkPedidoModelo.Text = "Activar"
        Me.checkPedidoModelo.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(557, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(557, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'comboPedidoEstado
        '
        Me.comboPedidoEstado.AutoSize = True
        Me.comboPedidoEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoEstado.Location = New System.Drawing.Point(351, 61)
        Me.comboPedidoEstado.Name = "comboPedidoEstado"
        Me.comboPedidoEstado.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoEstado.TabIndex = 65
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.PictureBox3)
        Me.UltraGroupBox1.Controls.Add(Me.checkPedidoFecha)
        Me.UltraGroupBox1.Controls.Add(Me.pedidoHasta)
        Me.UltraGroupBox1.Controls.Add(Me.pedidoDesde)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(62, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(223, 107)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 59
        Me.UltraGroupBox1.Text = "Fecha entrega"
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
        'checkPedidoFecha
        '
        Me.checkPedidoFecha.AutoSize = True
        Me.checkPedidoFecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkPedidoFecha.Location = New System.Drawing.Point(33, 76)
        Me.checkPedidoFecha.Name = "checkPedidoFecha"
        Me.checkPedidoFecha.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoFecha.TabIndex = 43
        Me.checkPedidoFecha.Text = "Activar"
        Me.checkPedidoFecha.UseVisualStyleBackColor = False
        '
        'pedidoHasta
        '
        Me.pedidoHasta.Location = New System.Drawing.Point(6, 49)
        Me.pedidoHasta.Name = "pedidoHasta"
        Me.pedidoHasta.Size = New System.Drawing.Size(211, 20)
        Me.pedidoHasta.TabIndex = 42
        '
        'pedidoDesde
        '
        Me.pedidoDesde.Location = New System.Drawing.Point(6, 23)
        Me.pedidoDesde.Name = "pedidoDesde"
        Me.pedidoDesde.Size = New System.Drawing.Size(211, 20)
        Me.pedidoDesde.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(310, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Cliente"
        '
        'comboPedidoCliente
        '
        Me.comboPedidoCliente.AutoSize = True
        Me.comboPedidoCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoCliente.Location = New System.Drawing.Point(351, 34)
        Me.comboPedidoCliente.Name = "comboPedidoCliente"
        Me.comboPedidoCliente.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoCliente.TabIndex = 64
        '
        'checkPedidoEstado
        '
        Me.checkPedidoEstado.AutoSize = True
        Me.checkPedidoEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoEstado.Location = New System.Drawing.Point(584, 65)
        Me.checkPedidoEstado.Name = "checkPedidoEstado"
        Me.checkPedidoEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoEstado.TabIndex = 63
        Me.checkPedidoEstado.Text = "Activar"
        Me.checkPedidoEstado.UseVisualStyleBackColor = False
        '
        'btnPedido
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.btnPedido.Appearance = Appearance6
        Me.btnPedido.Location = New System.Drawing.Point(661, 77)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(96, 31)
        Me.btnPedido.TabIndex = 58
        Me.btnPedido.Text = "Actualizar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(310, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Estado"
        '
        'checkPedidoCliente
        '
        Me.checkPedidoCliente.AutoSize = True
        Me.checkPedidoCliente.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoCliente.Location = New System.Drawing.Point(584, 37)
        Me.checkPedidoCliente.Name = "checkPedidoCliente"
        Me.checkPedidoCliente.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoCliente.TabIndex = 62
        Me.checkPedidoCliente.Text = "Activar"
        Me.checkPedidoCliente.UseVisualStyleBackColor = False
        '
        'tabDetalle
        '
        Me.tabDetalle.AutoScroll = True
        Me.tabDetalle.Controls.Add(Me.Label10)
        Me.tabDetalle.Controls.Add(Me.txtNroSerieSeguimiento)
        Me.tabDetalle.Controls.Add(Me.Label13)
        Me.tabDetalle.Controls.Add(Me.txtNroPedidoSeguimiento)
        Me.tabDetalle.Controls.Add(Me.PictureBox6)
        Me.tabDetalle.Controls.Add(Me.PictureBox5)
        Me.tabDetalle.Controls.Add(Me.Label5)
        Me.tabDetalle.Controls.Add(Me.comboSeguimientoModelo)
        Me.tabDetalle.Controls.Add(Me.checkSeguimientoModelo)
        Me.tabDetalle.Controls.Add(Me.comboSeguimientoEstado)
        Me.tabDetalle.Controls.Add(Me.checkSeguimientoEstado)
        Me.tabDetalle.Controls.Add(Me.Label1)
        Me.tabDetalle.Controls.Add(Me.UltraGroupBox2)
        Me.tabDetalle.Controls.Add(Me.btnSeguimiento)
        Me.tabDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalle.Size = New System.Drawing.Size(778, 131)
        Me.tabDetalle.TabIndex = 1
        Me.tabDetalle.Text = "Seguimiento produccion"
        Me.tabDetalle.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(515, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Nro. Serie"
        '
        'txtNroSerieSeguimiento
        '
        Me.txtNroSerieSeguimiento.Location = New System.Drawing.Point(514, 91)
        Me.txtNroSerieSeguimiento.Name = "txtNroSerieSeguimiento"
        Me.txtNroSerieSeguimiento.Size = New System.Drawing.Size(96, 20)
        Me.txtNroSerieSeguimiento.TabIndex = 105
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(406, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Nro. Pedido"
        '
        'txtNroPedidoSeguimiento
        '
        Me.txtNroPedidoSeguimiento.Location = New System.Drawing.Point(405, 91)
        Me.txtNroPedidoSeguimiento.Name = "txtNroPedidoSeguimiento"
        Me.txtNroPedidoSeguimiento.Size = New System.Drawing.Size(96, 20)
        Me.txtNroPedidoSeguimiento.TabIndex = 103
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(613, 46)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 63
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(613, 20)
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
        Me.Label5.Location = New System.Drawing.Point(362, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Modelo"
        '
        'comboSeguimientoModelo
        '
        Me.comboSeguimientoModelo.AutoSize = True
        Me.comboSeguimientoModelo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboSeguimientoModelo.Location = New System.Drawing.Point(405, 46)
        Me.comboSeguimientoModelo.Name = "comboSeguimientoModelo"
        Me.comboSeguimientoModelo.Size = New System.Drawing.Size(205, 21)
        Me.comboSeguimientoModelo.TabIndex = 61
        '
        'checkSeguimientoModelo
        '
        Me.checkSeguimientoModelo.AutoSize = True
        Me.checkSeguimientoModelo.BackColor = System.Drawing.SystemColors.Control
        Me.checkSeguimientoModelo.Location = New System.Drawing.Point(640, 48)
        Me.checkSeguimientoModelo.Name = "checkSeguimientoModelo"
        Me.checkSeguimientoModelo.Size = New System.Drawing.Size(59, 17)
        Me.checkSeguimientoModelo.TabIndex = 60
        Me.checkSeguimientoModelo.Text = "Activar"
        Me.checkSeguimientoModelo.UseVisualStyleBackColor = False
        '
        'comboSeguimientoEstado
        '
        Me.comboSeguimientoEstado.AutoSize = True
        Me.comboSeguimientoEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboSeguimientoEstado.Location = New System.Drawing.Point(405, 20)
        Me.comboSeguimientoEstado.Name = "comboSeguimientoEstado"
        Me.comboSeguimientoEstado.Size = New System.Drawing.Size(205, 21)
        Me.comboSeguimientoEstado.TabIndex = 58
        '
        'checkSeguimientoEstado
        '
        Me.checkSeguimientoEstado.AutoSize = True
        Me.checkSeguimientoEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkSeguimientoEstado.Location = New System.Drawing.Point(640, 22)
        Me.checkSeguimientoEstado.Name = "checkSeguimientoEstado"
        Me.checkSeguimientoEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkSeguimientoEstado.TabIndex = 57
        Me.checkSeguimientoEstado.Text = "Activar"
        Me.checkSeguimientoEstado.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(362, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Estado"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.PictureBox4)
        Me.UltraGroupBox2.Controls.Add(Me.checkSeguimientoFecha)
        Me.UltraGroupBox2.Controls.Add(Me.fechaSeguimientoHasta)
        Me.UltraGroupBox2.Controls.Add(Me.fechaSeguimientoDesde)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(24, 6)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(257, 105)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 44
        Me.UltraGroupBox2.Text = "Fecha inicio producción"
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
        'checkSeguimientoFecha
        '
        Me.checkSeguimientoFecha.AutoSize = True
        Me.checkSeguimientoFecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkSeguimientoFecha.Location = New System.Drawing.Point(33, 74)
        Me.checkSeguimientoFecha.Name = "checkSeguimientoFecha"
        Me.checkSeguimientoFecha.Size = New System.Drawing.Size(59, 17)
        Me.checkSeguimientoFecha.TabIndex = 43
        Me.checkSeguimientoFecha.Text = "Activar"
        Me.checkSeguimientoFecha.UseVisualStyleBackColor = False
        '
        'fechaSeguimientoHasta
        '
        Me.fechaSeguimientoHasta.Location = New System.Drawing.Point(6, 46)
        Me.fechaSeguimientoHasta.Name = "fechaSeguimientoHasta"
        Me.fechaSeguimientoHasta.Size = New System.Drawing.Size(211, 20)
        Me.fechaSeguimientoHasta.TabIndex = 42
        '
        'fechaSeguimientoDesde
        '
        Me.fechaSeguimientoDesde.Location = New System.Drawing.Point(6, 20)
        Me.fechaSeguimientoDesde.Name = "fechaSeguimientoDesde"
        Me.fechaSeguimientoDesde.Size = New System.Drawing.Size(211, 20)
        Me.fechaSeguimientoDesde.TabIndex = 41
        '
        'btnSeguimiento
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.btnSeguimiento.Appearance = Appearance5
        Me.btnSeguimiento.Location = New System.Drawing.Point(640, 80)
        Me.btnSeguimiento.Name = "btnSeguimiento"
        Me.btnSeguimiento.Size = New System.Drawing.Size(96, 31)
        Me.btnSeguimiento.TabIndex = 41
        Me.btnSeguimiento.Text = "Actualizar"
        '
        'tabServicios
        '
        Me.tabServicios.Controls.Add(Me.Label7)
        Me.tabServicios.Controls.Add(Me.txtNroPedidoServicio)
        Me.tabServicios.Controls.Add(Me.UltraGroupBox5)
        Me.tabServicios.Controls.Add(Me.UltraGroupBox6)
        Me.tabServicios.Controls.Add(Me.PictureBox11)
        Me.tabServicios.Controls.Add(Me.PictureBox10)
        Me.tabServicios.Controls.Add(Me.PictureBox9)
        Me.tabServicios.Controls.Add(Me.checkServicioEstado)
        Me.tabServicios.Controls.Add(Me.checkServicioOperacion)
        Me.tabServicios.Controls.Add(Me.Label9)
        Me.tabServicios.Controls.Add(Me.Label3)
        Me.tabServicios.Controls.Add(Me.comboServicioEstado)
        Me.tabServicios.Controls.Add(Me.comboServicioOperacion)
        Me.tabServicios.Controls.Add(Me.btnServicio)
        Me.tabServicios.Controls.Add(Me.Label8)
        Me.tabServicios.Controls.Add(Me.comboServicioCliente)
        Me.tabServicios.Controls.Add(Me.checkServicioCliente)
        Me.tabServicios.Location = New System.Drawing.Point(4, 22)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServicios.Size = New System.Drawing.Size(778, 131)
        Me.tabServicios.TabIndex = 3
        Me.tabServicios.Text = "Servicios detallados"
        Me.tabServicios.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(683, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Nro. Pedido"
        '
        'txtNroPedidoServicio
        '
        Me.txtNroPedidoServicio.Location = New System.Drawing.Point(682, 45)
        Me.txtNroPedidoServicio.Name = "txtNroPedidoServicio"
        Me.txtNroPedidoServicio.Size = New System.Drawing.Size(90, 20)
        Me.txtNroPedidoServicio.TabIndex = 101
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.PictureBox17)
        Me.UltraGroupBox5.Controls.Add(Me.checkFechaEntrega)
        Me.UltraGroupBox5.Controls.Add(Me.fechaEntregaHasta)
        Me.UltraGroupBox5.Controls.Add(Me.fechaEntregaDesde)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(174, 6)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(162, 107)
        Me.UltraGroupBox5.SupportThemes = False
        Me.UltraGroupBox5.TabIndex = 100
        Me.UltraGroupBox5.Text = "Fecha entrega"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(6, 73)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox17.TabIndex = 58
        Me.PictureBox17.TabStop = False
        '
        'checkFechaEntrega
        '
        Me.checkFechaEntrega.AutoSize = True
        Me.checkFechaEntrega.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkFechaEntrega.Location = New System.Drawing.Point(33, 76)
        Me.checkFechaEntrega.Name = "checkFechaEntrega"
        Me.checkFechaEntrega.Size = New System.Drawing.Size(59, 17)
        Me.checkFechaEntrega.TabIndex = 43
        Me.checkFechaEntrega.Text = "Activar"
        Me.checkFechaEntrega.UseVisualStyleBackColor = False
        '
        'fechaEntregaHasta
        '
        Me.fechaEntregaHasta.Location = New System.Drawing.Point(6, 49)
        Me.fechaEntregaHasta.Name = "fechaEntregaHasta"
        Me.fechaEntregaHasta.Size = New System.Drawing.Size(148, 20)
        Me.fechaEntregaHasta.TabIndex = 42
        '
        'fechaEntregaDesde
        '
        Me.fechaEntregaDesde.Location = New System.Drawing.Point(6, 23)
        Me.fechaEntregaDesde.Name = "fechaEntregaDesde"
        Me.fechaEntregaDesde.Size = New System.Drawing.Size(148, 20)
        Me.fechaEntregaDesde.TabIndex = 41
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.PictureBox18)
        Me.UltraGroupBox6.Controls.Add(Me.checkFechaRealizacion)
        Me.UltraGroupBox6.Controls.Add(Me.fechaRealizacionHasta)
        Me.UltraGroupBox6.Controls.Add(Me.fechaRealizacionDesde)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(162, 107)
        Me.UltraGroupBox6.SupportThemes = False
        Me.UltraGroupBox6.TabIndex = 99
        Me.UltraGroupBox6.Text = "Fecha realizacion"
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox18.Image = CType(resources.GetObject("PictureBox18.Image"), System.Drawing.Image)
        Me.PictureBox18.Location = New System.Drawing.Point(6, 73)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox18.TabIndex = 58
        Me.PictureBox18.TabStop = False
        '
        'checkFechaRealizacion
        '
        Me.checkFechaRealizacion.AutoSize = True
        Me.checkFechaRealizacion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkFechaRealizacion.Location = New System.Drawing.Point(33, 76)
        Me.checkFechaRealizacion.Name = "checkFechaRealizacion"
        Me.checkFechaRealizacion.Size = New System.Drawing.Size(59, 17)
        Me.checkFechaRealizacion.TabIndex = 43
        Me.checkFechaRealizacion.Text = "Activar"
        Me.checkFechaRealizacion.UseVisualStyleBackColor = False
        '
        'fechaRealizacionHasta
        '
        Me.fechaRealizacionHasta.Location = New System.Drawing.Point(6, 49)
        Me.fechaRealizacionHasta.Name = "fechaRealizacionHasta"
        Me.fechaRealizacionHasta.Size = New System.Drawing.Size(148, 20)
        Me.fechaRealizacionHasta.TabIndex = 42
        '
        'fechaRealizacionDesde
        '
        Me.fechaRealizacionDesde.Location = New System.Drawing.Point(6, 23)
        Me.fechaRealizacionDesde.Name = "fechaRealizacionDesde"
        Me.fechaRealizacionDesde.Size = New System.Drawing.Size(148, 20)
        Me.fechaRealizacionDesde.TabIndex = 41
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(585, 83)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox11.TabIndex = 84
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(585, 57)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox10.TabIndex = 83
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(585, 30)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 82
        Me.PictureBox9.TabStop = False
        '
        'checkServicioEstado
        '
        Me.checkServicioEstado.AutoSize = True
        Me.checkServicioEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkServicioEstado.Location = New System.Drawing.Point(614, 87)
        Me.checkServicioEstado.Name = "checkServicioEstado"
        Me.checkServicioEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkServicioEstado.TabIndex = 81
        Me.checkServicioEstado.Text = "Activar"
        Me.checkServicioEstado.UseVisualStyleBackColor = False
        '
        'checkServicioOperacion
        '
        Me.checkServicioOperacion.AutoSize = True
        Me.checkServicioOperacion.BackColor = System.Drawing.SystemColors.Control
        Me.checkServicioOperacion.Location = New System.Drawing.Point(614, 61)
        Me.checkServicioOperacion.Name = "checkServicioOperacion"
        Me.checkServicioOperacion.Size = New System.Drawing.Size(59, 17)
        Me.checkServicioOperacion.TabIndex = 80
        Me.checkServicioOperacion.Text = "Activar"
        Me.checkServicioOperacion.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(362, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(347, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Operacion"
        '
        'comboServicioEstado
        '
        Me.comboServicioEstado.AutoSize = True
        Me.comboServicioEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboServicioEstado.Location = New System.Drawing.Point(405, 84)
        Me.comboServicioEstado.Name = "comboServicioEstado"
        Me.comboServicioEstado.Size = New System.Drawing.Size(177, 21)
        Me.comboServicioEstado.TabIndex = 77
        '
        'comboServicioOperacion
        '
        Me.comboServicioOperacion.AutoSize = True
        Me.comboServicioOperacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboServicioOperacion.Location = New System.Drawing.Point(405, 57)
        Me.comboServicioOperacion.Name = "comboServicioOperacion"
        Me.comboServicioOperacion.Size = New System.Drawing.Size(177, 21)
        Me.comboServicioOperacion.TabIndex = 76
        '
        'btnServicio
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.btnServicio.Appearance = Appearance7
        Me.btnServicio.Location = New System.Drawing.Point(682, 71)
        Me.btnServicio.Name = "btnServicio"
        Me.btnServicio.Size = New System.Drawing.Size(90, 34)
        Me.btnServicio.TabIndex = 75
        Me.btnServicio.Text = "Ejecutar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(364, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Cliente"
        '
        'comboServicioCliente
        '
        Me.comboServicioCliente.AutoSize = True
        Me.comboServicioCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboServicioCliente.Location = New System.Drawing.Point(405, 30)
        Me.comboServicioCliente.Name = "comboServicioCliente"
        Me.comboServicioCliente.Size = New System.Drawing.Size(177, 21)
        Me.comboServicioCliente.TabIndex = 74
        '
        'checkServicioCliente
        '
        Me.checkServicioCliente.AutoSize = True
        Me.checkServicioCliente.BackColor = System.Drawing.SystemColors.Control
        Me.checkServicioCliente.Location = New System.Drawing.Point(614, 34)
        Me.checkServicioCliente.Name = "checkServicioCliente"
        Me.checkServicioCliente.Size = New System.Drawing.Size(59, 17)
        Me.checkServicioCliente.TabIndex = 73
        Me.checkServicioCliente.Text = "Activar"
        Me.checkServicioCliente.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.UltraGroupBox4)
        Me.TabPage1.Controls.Add(Me.UltraGroupBox3)
        Me.TabPage1.Controls.Add(Me.PictureBox13)
        Me.TabPage1.Controls.Add(Me.PictureBox14)
        Me.TabPage1.Controls.Add(Me.checkTorneadoNroserie)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.comboTorneadoNroserie)
        Me.TabPage1.Controls.Add(Me.btnTorneado)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.comboTornero)
        Me.TabPage1.Controls.Add(Me.checkTornero)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(778, 131)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Torneados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.PictureBox16)
        Me.UltraGroupBox4.Controls.Add(Me.checkFechaRecepcion)
        Me.UltraGroupBox4.Controls.Add(Me.fechaRecepcionHasta)
        Me.UltraGroupBox4.Controls.Add(Me.fechaRecepcionDesde)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(178, 9)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(162, 107)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 98
        Me.UltraGroupBox4.Text = "Fecha recepción"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(6, 73)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox16.TabIndex = 58
        Me.PictureBox16.TabStop = False
        '
        'checkFechaRecepcion
        '
        Me.checkFechaRecepcion.AutoSize = True
        Me.checkFechaRecepcion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkFechaRecepcion.Location = New System.Drawing.Point(33, 76)
        Me.checkFechaRecepcion.Name = "checkFechaRecepcion"
        Me.checkFechaRecepcion.Size = New System.Drawing.Size(59, 17)
        Me.checkFechaRecepcion.TabIndex = 43
        Me.checkFechaRecepcion.Text = "Activar"
        Me.checkFechaRecepcion.UseVisualStyleBackColor = False
        '
        'fechaRecepcionHasta
        '
        Me.fechaRecepcionHasta.Location = New System.Drawing.Point(6, 49)
        Me.fechaRecepcionHasta.Name = "fechaRecepcionHasta"
        Me.fechaRecepcionHasta.Size = New System.Drawing.Size(148, 20)
        Me.fechaRecepcionHasta.TabIndex = 42
        '
        'fechaRecepcionDesde
        '
        Me.fechaRecepcionDesde.Location = New System.Drawing.Point(6, 23)
        Me.fechaRecepcionDesde.Name = "fechaRecepcionDesde"
        Me.fechaRecepcionDesde.Size = New System.Drawing.Size(148, 20)
        Me.fechaRecepcionDesde.TabIndex = 41
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.PictureBox15)
        Me.UltraGroupBox3.Controls.Add(Me.checkFechaSalida)
        Me.UltraGroupBox3.Controls.Add(Me.fechaSalidaHasta)
        Me.UltraGroupBox3.Controls.Add(Me.fechaSalidaDesde)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(10, 9)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(162, 107)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 97
        Me.UltraGroupBox3.Text = "Fecha salida"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(6, 73)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox15.TabIndex = 58
        Me.PictureBox15.TabStop = False
        '
        'checkFechaSalida
        '
        Me.checkFechaSalida.AutoSize = True
        Me.checkFechaSalida.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkFechaSalida.Location = New System.Drawing.Point(33, 76)
        Me.checkFechaSalida.Name = "checkFechaSalida"
        Me.checkFechaSalida.Size = New System.Drawing.Size(59, 17)
        Me.checkFechaSalida.TabIndex = 43
        Me.checkFechaSalida.Text = "Activar"
        Me.checkFechaSalida.UseVisualStyleBackColor = False
        '
        'fechaSalidaHasta
        '
        Me.fechaSalidaHasta.Location = New System.Drawing.Point(6, 49)
        Me.fechaSalidaHasta.Name = "fechaSalidaHasta"
        Me.fechaSalidaHasta.Size = New System.Drawing.Size(148, 20)
        Me.fechaSalidaHasta.TabIndex = 42
        '
        'fechaSalidaDesde
        '
        Me.fechaSalidaDesde.Location = New System.Drawing.Point(6, 23)
        Me.fechaSalidaDesde.Name = "fechaSalidaDesde"
        Me.fechaSalidaDesde.Size = New System.Drawing.Size(148, 20)
        Me.fechaSalidaDesde.TabIndex = 41
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(668, 55)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox13.TabIndex = 96
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(668, 28)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox14.TabIndex = 95
        Me.PictureBox14.TabStop = False
        '
        'checkTorneadoNroserie
        '
        Me.checkTorneadoNroserie.AutoSize = True
        Me.checkTorneadoNroserie.BackColor = System.Drawing.SystemColors.Control
        Me.checkTorneadoNroserie.Location = New System.Drawing.Point(703, 59)
        Me.checkTorneadoNroserie.Name = "checkTorneadoNroserie"
        Me.checkTorneadoNroserie.Size = New System.Drawing.Size(59, 17)
        Me.checkTorneadoNroserie.TabIndex = 93
        Me.checkTorneadoNroserie.Text = "Activar"
        Me.checkTorneadoNroserie.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(403, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Nro Serie"
        '
        'comboTorneadoNroserie
        '
        Me.comboTorneadoNroserie.AutoSize = True
        Me.comboTorneadoNroserie.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboTorneadoNroserie.Location = New System.Drawing.Point(460, 55)
        Me.comboTorneadoNroserie.Name = "comboTorneadoNroserie"
        Me.comboTorneadoNroserie.Size = New System.Drawing.Size(205, 21)
        Me.comboTorneadoNroserie.TabIndex = 89
        '
        'btnTorneado
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.btnTorneado.Appearance = Appearance8
        Me.btnTorneado.Location = New System.Drawing.Point(575, 82)
        Me.btnTorneado.Name = "btnTorneado"
        Me.btnTorneado.Size = New System.Drawing.Size(90, 34)
        Me.btnTorneado.TabIndex = 88
        Me.btnTorneado.Text = "Ejecutar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(408, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Tornero"
        '
        'comboTornero
        '
        Me.comboTornero.AutoSize = True
        Me.comboTornero.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboTornero.Location = New System.Drawing.Point(460, 28)
        Me.comboTornero.Name = "comboTornero"
        Me.comboTornero.Size = New System.Drawing.Size(205, 21)
        Me.comboTornero.TabIndex = 87
        '
        'checkTornero
        '
        Me.checkTornero.AutoSize = True
        Me.checkTornero.BackColor = System.Drawing.SystemColors.Control
        Me.checkTornero.Location = New System.Drawing.Point(703, 32)
        Me.checkTornero.Name = "checkTornero"
        Me.checkTornero.Size = New System.Drawing.Size(59, 17)
        Me.checkTornero.TabIndex = 86
        Me.checkTornero.Text = "Activar"
        Me.checkTornero.UseVisualStyleBackColor = False
        '
        'imageLoading
        '
        Me.imageLoading.Image = CType(resources.GetObject("imageLoading.Image"), System.Drawing.Image)
        Me.imageLoading.Location = New System.Drawing.Point(370, 344)
        Me.imageLoading.Name = "imageLoading"
        Me.imageLoading.Size = New System.Drawing.Size(32, 32)
        Me.imageLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imageLoading.TabIndex = 72
        Me.imageLoading.TabStop = False
        Me.imageLoading.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(6, 73)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 58
        Me.PictureBox8.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(33, 76)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Activar"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker1.TabIndex = 42
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 23)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'GestorReportesProdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 562)
        Me.Controls.Add(Me.imageLoading)
        Me.Controls.Add(Me.tabProduccion)
        Me.Controls.Add(Me.crv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "GestorReportesProdForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestor Reportes Producción"
        Me.tabProduccion.ResumeLayout(False)
        Me.tabOrdenDeCompra.ResumeLayout(False)
        Me.tabOrdenDeCompra.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalle.ResumeLayout(False)
        Me.tabDetalle.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboSeguimientoModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboSeguimientoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServicios.ResumeLayout(False)
        Me.tabServicios.PerformLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboServicioEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboServicioOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboServicioCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboTorneadoNroserie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboTornero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents tabProduccion As System.Windows.Forms.TabControl
    Friend WithEvents tabOrdenDeCompra As System.Windows.Forms.TabPage
    Friend WithEvents tabDetalle As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comboSeguimientoModelo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkSeguimientoModelo As System.Windows.Forms.CheckBox
    Friend WithEvents comboSeguimientoEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkSeguimientoEstado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents checkSeguimientoFecha As System.Windows.Forms.CheckBox
    Friend WithEvents fechaSeguimientoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaSeguimientoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSeguimiento As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tabServicios As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents comboPedidoEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents checkPedidoFecha As System.Windows.Forms.CheckBox
    Friend WithEvents pedidoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents pedidoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboPedidoCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkPedidoEstado As System.Windows.Forms.CheckBox
    Friend WithEvents btnPedido As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents checkPedidoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents checkServicioEstado As System.Windows.Forms.CheckBox
    Friend WithEvents checkServicioOperacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboServicioEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboServicioOperacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnServicio As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboServicioCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkServicioCliente As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents comboPedidoModelo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkPedidoModelo As System.Windows.Forms.CheckBox
    Friend WithEvents imageLoading As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents checkTorneadoNroserie As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents comboTorneadoNroserie As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnTorneado As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents comboTornero As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkTornero As System.Windows.Forms.CheckBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents checkFechaRecepcion As System.Windows.Forms.CheckBox
    Friend WithEvents fechaRecepcionHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaRecepcionDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents checkFechaSalida As System.Windows.Forms.CheckBox
    Friend WithEvents fechaSalidaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaSalidaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents checkFechaEntrega As System.Windows.Forms.CheckBox
    Friend WithEvents fechaEntregaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaEntregaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents checkFechaRealizacion As System.Windows.Forms.CheckBox
    Friend WithEvents fechaRealizacionHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaRealizacionDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNroPedidoServicio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNroPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNroPedidoSeguimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNroSerieSeguimiento As System.Windows.Forms.TextBox
End Class
