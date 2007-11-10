<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestorReportesForm
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
        Me.btnPedido = New Infragistics.Win.Misc.UltraButton
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.checkPedidoEstado = New System.Windows.Forms.CheckBox
        Me.checkPedidoPrioridad = New System.Windows.Forms.CheckBox
        Me.checkPedidoCliente = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.comboPedidoCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboPedidoPrioridad = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboPedidoEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.tabReportes = New System.Windows.Forms.TabControl
        Me.tabPedidos = New System.Windows.Forms.TabPage
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.checkPedidoFecha = New System.Windows.Forms.CheckBox
        Me.pedidoHasta = New System.Windows.Forms.DateTimePicker
        Me.pedidoDesde = New System.Windows.Forms.DateTimePicker
        Me.tabFresas = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.comboFresaModelo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkFresaModelo = New System.Windows.Forms.CheckBox
        Me.comboFresaEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkFresaEstado = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.checkFechaFresa = New System.Windows.Forms.CheckBox
        Me.fresaHasta = New System.Windows.Forms.DateTimePicker
        Me.fresaDesde = New System.Windows.Forms.DateTimePicker
        Me.btnFresas = New Infragistics.Win.Misc.UltraButton
        Me.tabCliente = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.comboClienteProvincia = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkClienteProvincia = New System.Windows.Forms.CheckBox
        Me.comboClienteLocalidad = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkClienteLocalidad = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnCliente = New Infragistics.Win.Misc.UltraButton
        Me.tabServicios = New System.Windows.Forms.TabPage
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.comboServicioCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkServicioCliente = New System.Windows.Forms.CheckBox
        Me.btnServicio = New Infragistics.Win.Misc.UltraButton
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportes.SuspendLayout()
        Me.tabPedidos.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.tabFresas.SuspendLayout()
        CType(Me.comboFresaModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboFresaEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.tabCliente.SuspendLayout()
        CType(Me.comboClienteProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboClienteLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServicios.SuspendLayout()
        CType(Me.comboServicioCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPedido
        '
        Me.btnPedido.Location = New System.Drawing.Point(424, 102)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(72, 21)
        Me.btnPedido.TabIndex = 39
        Me.btnPedido.Text = "Ejecutar"
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Location = New System.Drawing.Point(12, 175)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(790, 373)
        Me.crv.TabIndex = 40
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'checkPedidoEstado
        '
        Me.checkPedidoEstado.AutoSize = True
        Me.checkPedidoEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoEstado.Location = New System.Drawing.Point(643, 78)
        Me.checkPedidoEstado.Name = "checkPedidoEstado"
        Me.checkPedidoEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoEstado.TabIndex = 52
        Me.checkPedidoEstado.Text = "Activar"
        Me.checkPedidoEstado.UseVisualStyleBackColor = False
        '
        'checkPedidoPrioridad
        '
        Me.checkPedidoPrioridad.AutoSize = True
        Me.checkPedidoPrioridad.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoPrioridad.Location = New System.Drawing.Point(643, 56)
        Me.checkPedidoPrioridad.Name = "checkPedidoPrioridad"
        Me.checkPedidoPrioridad.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoPrioridad.TabIndex = 51
        Me.checkPedidoPrioridad.Text = "Activar"
        Me.checkPedidoPrioridad.UseVisualStyleBackColor = False
        '
        'checkPedidoCliente
        '
        Me.checkPedidoCliente.AutoSize = True
        Me.checkPedidoCliente.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoCliente.Location = New System.Drawing.Point(643, 34)
        Me.checkPedidoCliente.Name = "checkPedidoCliente"
        Me.checkPedidoCliente.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoCliente.TabIndex = 50
        Me.checkPedidoCliente.Text = "Activar"
        Me.checkPedidoCliente.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(378, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(370, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Prioridad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(379, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Cliente"
        '
        'comboPedidoCliente
        '
        Me.comboPedidoCliente.AutoSize = True
        Me.comboPedidoCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoCliente.Location = New System.Drawing.Point(424, 31)
        Me.comboPedidoCliente.Name = "comboPedidoCliente"
        Me.comboPedidoCliente.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoCliente.TabIndex = 53
        '
        'comboPedidoPrioridad
        '
        Me.comboPedidoPrioridad.AutoSize = True
        Me.comboPedidoPrioridad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoPrioridad.Location = New System.Drawing.Point(424, 53)
        Me.comboPedidoPrioridad.Name = "comboPedidoPrioridad"
        Me.comboPedidoPrioridad.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoPrioridad.TabIndex = 54
        '
        'comboPedidoEstado
        '
        Me.comboPedidoEstado.AutoSize = True
        Me.comboPedidoEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoEstado.Location = New System.Drawing.Point(424, 75)
        Me.comboPedidoEstado.Name = "comboPedidoEstado"
        Me.comboPedidoEstado.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoEstado.TabIndex = 55
        '
        'tabReportes
        '
        Me.tabReportes.Controls.Add(Me.tabPedidos)
        Me.tabReportes.Controls.Add(Me.tabFresas)
        Me.tabReportes.Controls.Add(Me.tabCliente)
        Me.tabReportes.Controls.Add(Me.tabServicios)
        Me.tabReportes.Location = New System.Drawing.Point(12, 12)
        Me.tabReportes.Name = "tabReportes"
        Me.tabReportes.SelectedIndex = 0
        Me.tabReportes.Size = New System.Drawing.Size(790, 157)
        Me.tabReportes.TabIndex = 56
        '
        'tabPedidos
        '
        Me.tabPedidos.Controls.Add(Me.comboPedidoEstado)
        Me.tabPedidos.Controls.Add(Me.UltraGroupBox1)
        Me.tabPedidos.Controls.Add(Me.comboPedidoPrioridad)
        Me.tabPedidos.Controls.Add(Me.Label2)
        Me.tabPedidos.Controls.Add(Me.comboPedidoCliente)
        Me.tabPedidos.Controls.Add(Me.Label3)
        Me.tabPedidos.Controls.Add(Me.checkPedidoEstado)
        Me.tabPedidos.Controls.Add(Me.btnPedido)
        Me.tabPedidos.Controls.Add(Me.checkPedidoPrioridad)
        Me.tabPedidos.Controls.Add(Me.Label4)
        Me.tabPedidos.Controls.Add(Me.checkPedidoCliente)
        Me.tabPedidos.Location = New System.Drawing.Point(4, 22)
        Me.tabPedidos.Name = "tabPedidos"
        Me.tabPedidos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPedidos.Size = New System.Drawing.Size(782, 131)
        Me.tabPedidos.TabIndex = 0
        Me.tabPedidos.Text = "Pedidos"
        Me.tabPedidos.UseVisualStyleBackColor = True
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.checkPedidoFecha)
        Me.UltraGroupBox1.Controls.Add(Me.pedidoHasta)
        Me.UltraGroupBox1.Controls.Add(Me.pedidoDesde)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(54, 9)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(223, 95)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 43
        Me.UltraGroupBox1.Text = "Fecha entrega"
        '
        'checkPedidoFecha
        '
        Me.checkPedidoFecha.AutoSize = True
        Me.checkPedidoFecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkPedidoFecha.Location = New System.Drawing.Point(6, 70)
        Me.checkPedidoFecha.Name = "checkPedidoFecha"
        Me.checkPedidoFecha.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoFecha.TabIndex = 43
        Me.checkPedidoFecha.Text = "Activar"
        Me.checkPedidoFecha.UseVisualStyleBackColor = False
        '
        'pedidoHasta
        '
        Me.pedidoHasta.Location = New System.Drawing.Point(6, 42)
        Me.pedidoHasta.Name = "pedidoHasta"
        Me.pedidoHasta.Size = New System.Drawing.Size(203, 20)
        Me.pedidoHasta.TabIndex = 42
        '
        'pedidoDesde
        '
        Me.pedidoDesde.Location = New System.Drawing.Point(6, 20)
        Me.pedidoDesde.Name = "pedidoDesde"
        Me.pedidoDesde.Size = New System.Drawing.Size(203, 20)
        Me.pedidoDesde.TabIndex = 41
        '
        'tabFresas
        '
        Me.tabFresas.Controls.Add(Me.Label5)
        Me.tabFresas.Controls.Add(Me.comboFresaModelo)
        Me.tabFresas.Controls.Add(Me.checkFresaModelo)
        Me.tabFresas.Controls.Add(Me.comboFresaEstado)
        Me.tabFresas.Controls.Add(Me.checkFresaEstado)
        Me.tabFresas.Controls.Add(Me.Label1)
        Me.tabFresas.Controls.Add(Me.UltraGroupBox2)
        Me.tabFresas.Controls.Add(Me.btnFresas)
        Me.tabFresas.Location = New System.Drawing.Point(4, 22)
        Me.tabFresas.Name = "tabFresas"
        Me.tabFresas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFresas.Size = New System.Drawing.Size(782, 131)
        Me.tabFresas.TabIndex = 1
        Me.tabFresas.Text = "Pedidos Fresa"
        Me.tabFresas.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(373, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Modelo"
        '
        'comboFresaModelo
        '
        Me.comboFresaModelo.AutoSize = True
        Me.comboFresaModelo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboFresaModelo.Location = New System.Drawing.Point(418, 61)
        Me.comboFresaModelo.Name = "comboFresaModelo"
        Me.comboFresaModelo.Size = New System.Drawing.Size(205, 21)
        Me.comboFresaModelo.TabIndex = 61
        '
        'checkFresaModelo
        '
        Me.checkFresaModelo.AutoSize = True
        Me.checkFresaModelo.BackColor = System.Drawing.SystemColors.Control
        Me.checkFresaModelo.Location = New System.Drawing.Point(637, 66)
        Me.checkFresaModelo.Name = "checkFresaModelo"
        Me.checkFresaModelo.Size = New System.Drawing.Size(59, 17)
        Me.checkFresaModelo.TabIndex = 60
        Me.checkFresaModelo.Text = "Activar"
        Me.checkFresaModelo.UseVisualStyleBackColor = False
        '
        'comboFresaEstado
        '
        Me.comboFresaEstado.AutoSize = True
        Me.comboFresaEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboFresaEstado.Location = New System.Drawing.Point(418, 39)
        Me.comboFresaEstado.Name = "comboFresaEstado"
        Me.comboFresaEstado.Size = New System.Drawing.Size(205, 21)
        Me.comboFresaEstado.TabIndex = 58
        '
        'checkFresaEstado
        '
        Me.checkFresaEstado.AutoSize = True
        Me.checkFresaEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkFresaEstado.Location = New System.Drawing.Point(637, 39)
        Me.checkFresaEstado.Name = "checkFresaEstado"
        Me.checkFresaEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkFresaEstado.TabIndex = 57
        Me.checkFresaEstado.Text = "Activar"
        Me.checkFresaEstado.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(373, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Estado"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.checkFechaFresa)
        Me.UltraGroupBox2.Controls.Add(Me.fresaHasta)
        Me.UltraGroupBox2.Controls.Add(Me.fresaDesde)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(53, 11)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(223, 95)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 44
        Me.UltraGroupBox2.Text = "Fecha fin fabricacion"
        '
        'checkFechaFresa
        '
        Me.checkFechaFresa.AutoSize = True
        Me.checkFechaFresa.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkFechaFresa.Location = New System.Drawing.Point(6, 70)
        Me.checkFechaFresa.Name = "checkFechaFresa"
        Me.checkFechaFresa.Size = New System.Drawing.Size(59, 17)
        Me.checkFechaFresa.TabIndex = 43
        Me.checkFechaFresa.Text = "Activar"
        Me.checkFechaFresa.UseVisualStyleBackColor = False
        '
        'fresaHasta
        '
        Me.fresaHasta.Location = New System.Drawing.Point(6, 42)
        Me.fresaHasta.Name = "fresaHasta"
        Me.fresaHasta.Size = New System.Drawing.Size(203, 20)
        Me.fresaHasta.TabIndex = 42
        '
        'fresaDesde
        '
        Me.fresaDesde.Location = New System.Drawing.Point(6, 20)
        Me.fresaDesde.Name = "fresaDesde"
        Me.fresaDesde.Size = New System.Drawing.Size(203, 20)
        Me.fresaDesde.TabIndex = 41
        '
        'btnFresas
        '
        Me.btnFresas.Location = New System.Drawing.Point(418, 85)
        Me.btnFresas.Name = "btnFresas"
        Me.btnFresas.Size = New System.Drawing.Size(72, 21)
        Me.btnFresas.TabIndex = 41
        Me.btnFresas.Text = "Ejecutar"
        '
        'tabCliente
        '
        Me.tabCliente.Controls.Add(Me.Label6)
        Me.tabCliente.Controls.Add(Me.comboClienteProvincia)
        Me.tabCliente.Controls.Add(Me.checkClienteProvincia)
        Me.tabCliente.Controls.Add(Me.comboClienteLocalidad)
        Me.tabCliente.Controls.Add(Me.checkClienteLocalidad)
        Me.tabCliente.Controls.Add(Me.Label7)
        Me.tabCliente.Controls.Add(Me.btnCliente)
        Me.tabCliente.Location = New System.Drawing.Point(4, 22)
        Me.tabCliente.Name = "tabCliente"
        Me.tabCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCliente.Size = New System.Drawing.Size(782, 131)
        Me.tabCliente.TabIndex = 2
        Me.tabCliente.Text = "Clientes"
        Me.tabCliente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(23, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Provincia"
        '
        'comboClienteProvincia
        '
        Me.comboClienteProvincia.AutoSize = True
        Me.comboClienteProvincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboClienteProvincia.Location = New System.Drawing.Point(77, 48)
        Me.comboClienteProvincia.Name = "comboClienteProvincia"
        Me.comboClienteProvincia.Size = New System.Drawing.Size(205, 21)
        Me.comboClienteProvincia.TabIndex = 67
        '
        'checkClienteProvincia
        '
        Me.checkClienteProvincia.AutoSize = True
        Me.checkClienteProvincia.BackColor = System.Drawing.SystemColors.Control
        Me.checkClienteProvincia.Location = New System.Drawing.Point(296, 53)
        Me.checkClienteProvincia.Name = "checkClienteProvincia"
        Me.checkClienteProvincia.Size = New System.Drawing.Size(59, 17)
        Me.checkClienteProvincia.TabIndex = 66
        Me.checkClienteProvincia.Text = "Activar"
        Me.checkClienteProvincia.UseVisualStyleBackColor = False
        '
        'comboClienteLocalidad
        '
        Me.comboClienteLocalidad.AutoSize = True
        Me.comboClienteLocalidad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboClienteLocalidad.Location = New System.Drawing.Point(77, 26)
        Me.comboClienteLocalidad.Name = "comboClienteLocalidad"
        Me.comboClienteLocalidad.Size = New System.Drawing.Size(205, 21)
        Me.comboClienteLocalidad.TabIndex = 64
        '
        'checkClienteLocalidad
        '
        Me.checkClienteLocalidad.AutoSize = True
        Me.checkClienteLocalidad.BackColor = System.Drawing.SystemColors.Control
        Me.checkClienteLocalidad.Location = New System.Drawing.Point(296, 26)
        Me.checkClienteLocalidad.Name = "checkClienteLocalidad"
        Me.checkClienteLocalidad.Size = New System.Drawing.Size(59, 17)
        Me.checkClienteLocalidad.TabIndex = 63
        Me.checkClienteLocalidad.Text = "Activar"
        Me.checkClienteLocalidad.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(21, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Localidad"
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(77, 88)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(72, 21)
        Me.btnCliente.TabIndex = 40
        Me.btnCliente.Text = "Ejecutar"
        '
        'tabServicios
        '
        Me.tabServicios.Controls.Add(Me.btnServicio)
        Me.tabServicios.Controls.Add(Me.Label8)
        Me.tabServicios.Controls.Add(Me.comboServicioCliente)
        Me.tabServicios.Controls.Add(Me.checkServicioCliente)
        Me.tabServicios.Location = New System.Drawing.Point(4, 22)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServicios.Size = New System.Drawing.Size(782, 131)
        Me.tabServicios.TabIndex = 3
        Me.tabServicios.Text = "Servicios"
        Me.tabServicios.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(6, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Activar"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker1.TabIndex = 42
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 20)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(40, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Cliente"
        '
        'comboServicioCliente
        '
        Me.comboServicioCliente.AutoSize = True
        Me.comboServicioCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboServicioCliente.Location = New System.Drawing.Point(85, 30)
        Me.comboServicioCliente.Name = "comboServicioCliente"
        Me.comboServicioCliente.Size = New System.Drawing.Size(205, 21)
        Me.comboServicioCliente.TabIndex = 56
        '
        'checkServicioCliente
        '
        Me.checkServicioCliente.AutoSize = True
        Me.checkServicioCliente.BackColor = System.Drawing.SystemColors.Control
        Me.checkServicioCliente.Location = New System.Drawing.Point(304, 33)
        Me.checkServicioCliente.Name = "checkServicioCliente"
        Me.checkServicioCliente.Size = New System.Drawing.Size(59, 17)
        Me.checkServicioCliente.TabIndex = 55
        Me.checkServicioCliente.Text = "Activar"
        Me.checkServicioCliente.UseVisualStyleBackColor = False
        '
        'btnServicio
        '
        Me.btnServicio.Location = New System.Drawing.Point(85, 74)
        Me.btnServicio.Name = "btnServicio"
        Me.btnServicio.Size = New System.Drawing.Size(72, 21)
        Me.btnServicio.TabIndex = 57
        Me.btnServicio.Text = "Ejecutar"
        '
        'GestorReportesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 560)
        Me.Controls.Add(Me.tabReportes)
        Me.Controls.Add(Me.crv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "GestorReportesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestor de Reportes"
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportes.ResumeLayout(False)
        Me.tabPedidos.ResumeLayout(False)
        Me.tabPedidos.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.tabFresas.ResumeLayout(False)
        Me.tabFresas.PerformLayout()
        CType(Me.comboFresaModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboFresaEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        Me.tabCliente.ResumeLayout(False)
        Me.tabCliente.PerformLayout()
        CType(Me.comboClienteProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboClienteLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServicios.ResumeLayout(False)
        Me.tabServicios.PerformLayout()
        CType(Me.comboServicioCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPedido As Infragistics.Win.Misc.UltraButton
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents checkPedidoEstado As System.Windows.Forms.CheckBox
    Friend WithEvents checkPedidoPrioridad As System.Windows.Forms.CheckBox
    Friend WithEvents checkPedidoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboPedidoEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboPedidoPrioridad As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboPedidoCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents tabReportes As System.Windows.Forms.TabControl
    Friend WithEvents tabPedidos As System.Windows.Forms.TabPage
    Friend WithEvents tabFresas As System.Windows.Forms.TabPage
    Friend WithEvents tabCliente As System.Windows.Forms.TabPage
    Friend WithEvents btnCliente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnFresas As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents checkPedidoFecha As System.Windows.Forms.CheckBox
    Friend WithEvents pedidoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents pedidoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents checkFechaFresa As System.Windows.Forms.CheckBox
    Friend WithEvents fresaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fresaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comboFresaModelo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkFresaModelo As System.Windows.Forms.CheckBox
    Friend WithEvents comboFresaEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkFresaEstado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents comboClienteProvincia As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkClienteProvincia As System.Windows.Forms.CheckBox
    Friend WithEvents comboClienteLocalidad As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkClienteLocalidad As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabServicios As System.Windows.Forms.TabPage
    Friend WithEvents btnServicio As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboServicioCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkServicioCliente As System.Windows.Forms.CheckBox
End Class
