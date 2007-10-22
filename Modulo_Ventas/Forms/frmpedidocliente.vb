Imports Afilar.grdstyle


Public Class frmpedidocliente
    Inherits System.Windows.Forms.Form

#Region "Members"
    Dim ds As New DataSet
    Dim tipofresa As New TipoFresa
    Dim parteAdicional As New ParteAdicional
    Dim modelo As New ModeloFresa
    Dim fresa As New Fresa
    Dim nroserie As Integer
    Dim idobj As Integer
    Dim pedido As New pedidocliente
    Dim partepedida As New partepedida
    Dim bandeabm As Boolean
    Dim idpartepedida As Object
    Dim dvpedidos As New DataView
    Dim dvclientes As New DataView
    Dim idcliente As Object
    Dim serv As New servicio
    Dim fresasfab As New DataTable
    Dim DOS As New detalleordenservicio
    Dim obj As New objdelservicio
    Dim bnuevo As Boolean
    Private _idPesupuesto As Integer = Nothing
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbFiltrar As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnFiltrar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFiltrar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents radioRealizacion As System.Windows.Forms.RadioButton
    Friend WithEvents radioEntrega As System.Windows.Forms.RadioButton
    Dim bpedido As Boolean
#End Region


#Region "Properties"
    Public Property IdPesupuesto() As Integer
        Set(ByVal value As Integer)
            _idPesupuesto = value
        End Set
        Get
            Return _idPesupuesto
        End Get
    End Property
#End Region


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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents DataGridMf As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridF As System.Windows.Forms.DataGrid
    Friend WithEvents btnagregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblnropedido As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblfecharealizacion As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnnuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btngrabar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGridpp As System.Windows.Forms.DataGrid
    Friend WithEvents btnmodificar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgpedidos As System.Windows.Forms.DataGrid
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraOptionSet1 As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents btnquiter As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsubtotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents DataGridservicios As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridfresasfab As System.Windows.Forms.DataGrid
    Friend WithEvents DataGriddos As System.Windows.Forms.DataGrid
    Friend WithEvents botagregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsubtot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtitem As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents botquitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtimportetotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents comboestado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboformaentrega As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents fechaentrega As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents combocliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.txtimportetotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnmodificar = New Infragistics.Win.Misc.UltraButton
        Me.btngrabar = New Infragistics.Win.Misc.UltraButton
        Me.btnnuevo = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.combocliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.fechaentrega = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.comboformaentrega = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboestado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraOptionSet1 = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.lblfecharealizacion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblnropedido = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtsubtotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnquiter = New Infragistics.Win.Misc.UltraButton
        Me.btnagregar = New Infragistics.Win.Misc.UltraButton
        Me.DataGridpp = New System.Windows.Forms.DataGrid
        Me.DataGridF = New System.Windows.Forms.DataGrid
        Me.DataGridMf = New System.Windows.Forms.DataGrid
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.botquitar = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtcantidad = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtitem = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtsubtot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label10 = New System.Windows.Forms.Label
        Me.botagregar = New Infragistics.Win.Misc.UltraButton
        Me.DataGriddos = New System.Windows.Forms.DataGrid
        Me.DataGridservicios = New System.Windows.Forms.DataGrid
        Me.DataGridfresasfab = New System.Windows.Forms.DataGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radioNinguno = New System.Windows.Forms.RadioButton
        Me.radioRealizacion = New System.Windows.Forms.RadioButton
        Me.radioEntrega = New System.Windows.Forms.RadioButton
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dateHasta = New System.Windows.Forms.DateTimePicker
        Me.dateDesde = New System.Windows.Forms.DateTimePicker
        Me.cmbFiltrar = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnFiltrar = New Infragistics.Win.Misc.UltraButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFiltrar = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton
        Me.dgpedidos = New System.Windows.Forms.DataGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txtimportetotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.combocliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaentrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboformaentrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboestado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtsubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridpp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridMf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubtot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGriddos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridservicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridfresasfab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txtimportetotal)
        Me.UltraTabPageControl1.Controls.Add(Me.Label11)
        Me.UltraTabPageControl1.Controls.Add(Me.btnmodificar)
        Me.UltraTabPageControl1.Controls.Add(Me.btngrabar)
        Me.UltraTabPageControl1.Controls.Add(Me.btnnuevo)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(813, 545)
        '
        'txtimportetotal
        '
        Me.txtimportetotal.AutoSize = True
        Me.txtimportetotal.Location = New System.Drawing.Point(664, 512)
        Me.txtimportetotal.Name = "txtimportetotal"
        Me.txtimportetotal.ReadOnly = True
        Me.txtimportetotal.Size = New System.Drawing.Size(65, 21)
        Me.txtimportetotal.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(585, 520)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Importe total: $"
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(200, 509)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(88, 24)
        Me.btnmodificar.TabIndex = 4
        Me.btnmodificar.Text = "Modificar"
        '
        'btngrabar
        '
        Me.btngrabar.Location = New System.Drawing.Point(106, 509)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(88, 24)
        Me.btngrabar.TabIndex = 3
        Me.btngrabar.Text = "Grabar"
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(12, 509)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(88, 24)
        Me.btnnuevo.TabIndex = 2
        Me.btnnuevo.Text = "Nuevo"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.BackColor = System.Drawing.Color.Transparent
        Appearance1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance1
        Me.UltraGroupBox2.Controls.Add(Me.Label12)
        Me.UltraGroupBox2.Controls.Add(Me.combocliente)
        Me.UltraGroupBox2.Controls.Add(Me.fechaentrega)
        Me.UltraGroupBox2.Controls.Add(Me.comboformaentrega)
        Me.UltraGroupBox2.Controls.Add(Me.comboestado)
        Me.UltraGroupBox2.Controls.Add(Me.UltraOptionSet1)
        Me.UltraGroupBox2.Controls.Add(Me.Label6)
        Me.UltraGroupBox2.Controls.Add(Me.Label5)
        Me.UltraGroupBox2.Controls.Add(Me.Label4)
        Me.UltraGroupBox2.Controls.Add(Me.label3)
        Me.UltraGroupBox2.Controls.Add(Me.lblfecharealizacion)
        Me.UltraGroupBox2.Controls.Add(Me.Label2)
        Me.UltraGroupBox2.Controls.Add(Me.lblnropedido)
        Me.UltraGroupBox2.Controls.Add(Me.Label1)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(11, 8)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(790, 96)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Datos del cliente"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(700, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Tipo de pedido"
        '
        'combocliente
        '
        Me.combocliente.AutoSize = True
        Me.combocliente.Location = New System.Drawing.Point(53, 69)
        Me.combocliente.Name = "combocliente"
        Me.combocliente.Size = New System.Drawing.Size(176, 21)
        Me.combocliente.TabIndex = 18
        '
        'fechaentrega
        '
        Me.fechaentrega.BackColor = System.Drawing.SystemColors.Window
        DateButton1.Caption = "Today"
        Me.fechaentrega.DateButtons.Add(DateButton1)
        Me.fechaentrega.Location = New System.Drawing.Point(464, 21)
        Me.fechaentrega.Name = "fechaentrega"
        Me.fechaentrega.NonAutoSizeHeight = 16
        Me.fechaentrega.NullDateLabel = ""
        Me.fechaentrega.Size = New System.Drawing.Size(176, 21)
        Me.fechaentrega.TabIndex = 17
        Me.fechaentrega.Value = New Date(2007, 10, 10, 0, 0, 0, 0)
        '
        'comboformaentrega
        '
        Me.comboformaentrega.AutoSize = True
        Me.comboformaentrega.Location = New System.Drawing.Point(464, 45)
        Me.comboformaentrega.Name = "comboformaentrega"
        Me.comboformaentrega.Size = New System.Drawing.Size(176, 21)
        Me.comboformaentrega.TabIndex = 16
        '
        'comboestado
        '
        Me.comboestado.AutoSize = True
        Me.comboestado.HideSelection = False
        Me.comboestado.Location = New System.Drawing.Point(464, 69)
        Me.comboestado.Name = "comboestado"
        Me.comboestado.Size = New System.Drawing.Size(176, 21)
        Me.comboestado.TabIndex = 15
        '
        'UltraOptionSet1
        '
        Me.UltraOptionSet1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UltraOptionSet1.ItemAppearance = Appearance2
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Fabricación"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Reparación"
        Me.UltraOptionSet1.Items.Add(ValueListItem1)
        Me.UltraOptionSet1.Items.Add(ValueListItem2)
        Me.UltraOptionSet1.Location = New System.Drawing.Point(703, 58)
        Me.UltraOptionSet1.Name = "UltraOptionSet1"
        Me.UltraOptionSet1.Size = New System.Drawing.Size(82, 32)
        Me.UltraOptionSet1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(8, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(424, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(387, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Forma Entrega"
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Location = New System.Drawing.Point(387, 27)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Fecha Entrega"
        '
        'lblfecharealizacion
        '
        Me.lblfecharealizacion.BackColor = System.Drawing.Color.Transparent
        Me.lblfecharealizacion.Location = New System.Drawing.Point(106, 50)
        Me.lblfecharealizacion.Name = "lblfecharealizacion"
        Me.lblfecharealizacion.Size = New System.Drawing.Size(77, 16)
        Me.lblfecharealizacion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha realizacion"
        '
        'lblnropedido
        '
        Me.lblnropedido.BackColor = System.Drawing.Color.Transparent
        Me.lblnropedido.Location = New System.Drawing.Point(69, 27)
        Me.lblnropedido.Name = "lblnropedido"
        Me.lblnropedido.Size = New System.Drawing.Size(114, 15)
        Me.lblnropedido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Pedido"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.Color.Transparent
        Appearance3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance3
        Me.UltraGroupBox1.Controls.Add(Me.txtsubtotal)
        Me.UltraGroupBox1.Controls.Add(Me.Label7)
        Me.UltraGroupBox1.Controls.Add(Me.btnquiter)
        Me.UltraGroupBox1.Controls.Add(Me.btnagregar)
        Me.UltraGroupBox1.Controls.Add(Me.DataGridpp)
        Me.UltraGroupBox1.Controls.Add(Me.DataGridF)
        Me.UltraGroupBox1.Controls.Add(Me.DataGridMf)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(790, 391)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Productos a Fabricar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtsubtotal
        '
        Me.txtsubtotal.AutoSize = True
        Me.txtsubtotal.Location = New System.Drawing.Point(652, 361)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(65, 22)
        Me.txtsubtotal.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(589, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Subtotal:  $"
        '
        'btnquiter
        '
        Me.btnquiter.Location = New System.Drawing.Point(112, 171)
        Me.btnquiter.Name = "btnquiter"
        Me.btnquiter.Size = New System.Drawing.Size(80, 24)
        Me.btnquiter.TabIndex = 4
        Me.btnquiter.Text = "Quitar Item"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(24, 171)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(82, 24)
        Me.btnagregar.TabIndex = 3
        Me.btnagregar.Text = "Agregar Item"
        '
        'DataGridpp
        '
        Me.DataGridpp.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridpp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridpp.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridpp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridpp.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridpp.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridpp.CaptionText = "Partes Solicitadas"
        Me.DataGridpp.DataMember = ""
        Me.DataGridpp.FlatMode = True
        Me.DataGridpp.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridpp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridpp.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGridpp.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGridpp.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridpp.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridpp.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridpp.LinkColor = System.Drawing.Color.Teal
        Me.DataGridpp.Location = New System.Drawing.Point(440, 196)
        Me.DataGridpp.Name = "DataGridpp"
        Me.DataGridpp.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridpp.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridpp.ReadOnly = True
        Me.DataGridpp.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridpp.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridpp.Size = New System.Drawing.Size(328, 148)
        Me.DataGridpp.TabIndex = 2
        '
        'DataGridF
        '
        Me.DataGridF.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridF.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridF.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridF.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridF.CaptionText = "Produtos Solicitados"
        Me.DataGridF.DataMember = ""
        Me.DataGridF.FlatMode = True
        Me.DataGridF.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridF.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGridF.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGridF.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridF.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridF.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridF.LinkColor = System.Drawing.Color.Teal
        Me.DataGridF.Location = New System.Drawing.Point(24, 196)
        Me.DataGridF.Name = "DataGridF"
        Me.DataGridF.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridF.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridF.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridF.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridF.Size = New System.Drawing.Size(376, 148)
        Me.DataGridF.TabIndex = 1
        '
        'DataGridMf
        '
        Me.DataGridMf.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridMf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridMf.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridMf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridMf.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridMf.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridMf.CaptionText = "Produtos"
        Me.DataGridMf.DataMember = ""
        Me.DataGridMf.FlatMode = True
        Me.DataGridMf.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridMf.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridMf.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGridMf.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGridMf.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridMf.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridMf.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridMf.LinkColor = System.Drawing.Color.Teal
        Me.DataGridMf.Location = New System.Drawing.Point(24, 23)
        Me.DataGridMf.Name = "DataGridMf"
        Me.DataGridMf.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridMf.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridMf.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridMf.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridMf.Size = New System.Drawing.Size(744, 144)
        Me.DataGridMf.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.BackColor = System.Drawing.Color.Transparent
        Appearance4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance4
        Me.UltraGroupBox3.Controls.Add(Me.botquitar)
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox4)
        Me.UltraGroupBox3.Controls.Add(Me.txtsubtot)
        Me.UltraGroupBox3.Controls.Add(Me.Label10)
        Me.UltraGroupBox3.Controls.Add(Me.botagregar)
        Me.UltraGroupBox3.Controls.Add(Me.DataGriddos)
        Me.UltraGroupBox3.Controls.Add(Me.DataGridservicios)
        Me.UltraGroupBox3.Controls.Add(Me.DataGridfresasfab)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(12, 112)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(790, 391)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.Text = "Servicios a Realizar"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'botquitar
        '
        Me.botquitar.Location = New System.Drawing.Point(118, 171)
        Me.botquitar.Name = "botquitar"
        Me.botquitar.Size = New System.Drawing.Size(96, 24)
        Me.botquitar.TabIndex = 12
        Me.botquitar.Text = "Quiter Item"
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox4.ContentAreaAppearance = Appearance5
        Me.UltraGroupBox4.Controls.Add(Me.txtcantidad)
        Me.UltraGroupBox4.Controls.Add(Me.Label9)
        Me.UltraGroupBox4.Controls.Add(Me.txtitem)
        Me.UltraGroupBox4.Controls.Add(Me.Label8)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(560, 39)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(224, 129)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 10
        Me.UltraGroupBox4.Text = "Otro Item"
        '
        'txtcantidad
        '
        Me.txtcantidad.AutoSize = True
        Me.txtcantidad.Location = New System.Drawing.Point(58, 52)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(56, 21)
        Me.txtcantidad.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(8, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cantidad"
        '
        'txtitem
        '
        Me.txtitem.AutoSize = True
        Me.txtitem.Location = New System.Drawing.Point(58, 26)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(160, 21)
        Me.txtitem.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(13, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre"
        '
        'txtsubtot
        '
        Me.txtsubtot.AutoSize = True
        Me.txtsubtot.Location = New System.Drawing.Point(652, 361)
        Me.txtsubtot.Name = "txtsubtot"
        Me.txtsubtot.ReadOnly = True
        Me.txtsubtot.Size = New System.Drawing.Size(65, 21)
        Me.txtsubtot.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(592, 369)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Subtotal: $"
        '
        'botagregar
        '
        Me.botagregar.Location = New System.Drawing.Point(24, 171)
        Me.botagregar.Name = "botagregar"
        Me.botagregar.Size = New System.Drawing.Size(88, 24)
        Me.botagregar.TabIndex = 3
        Me.botagregar.Text = "Agregar Item"
        '
        'DataGriddos
        '
        Me.DataGriddos.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGriddos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGriddos.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGriddos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGriddos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGriddos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGriddos.CaptionText = "Servicios a Realizar"
        Me.DataGriddos.DataMember = ""
        Me.DataGriddos.FlatMode = True
        Me.DataGriddos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGriddos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGriddos.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGriddos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGriddos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGriddos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGriddos.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGriddos.LinkColor = System.Drawing.Color.Teal
        Me.DataGriddos.Location = New System.Drawing.Point(24, 200)
        Me.DataGriddos.Name = "DataGriddos"
        Me.DataGriddos.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGriddos.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGriddos.ReadOnly = True
        Me.DataGriddos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGriddos.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGriddos.Size = New System.Drawing.Size(520, 182)
        Me.DataGriddos.TabIndex = 2
        '
        'DataGridservicios
        '
        Me.DataGridservicios.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridservicios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridservicios.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridservicios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridservicios.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridservicios.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridservicios.CaptionText = "Servicios"
        Me.DataGridservicios.DataMember = ""
        Me.DataGridservicios.FlatMode = True
        Me.DataGridservicios.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridservicios.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridservicios.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGridservicios.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGridservicios.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridservicios.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridservicios.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridservicios.LinkColor = System.Drawing.Color.Teal
        Me.DataGridservicios.Location = New System.Drawing.Point(323, 24)
        Me.DataGridservicios.Name = "DataGridservicios"
        Me.DataGridservicios.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridservicios.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridservicios.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridservicios.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridservicios.Size = New System.Drawing.Size(232, 144)
        Me.DataGridservicios.TabIndex = 1
        '
        'DataGridfresasfab
        '
        Me.DataGridfresasfab.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridfresasfab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridfresasfab.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridfresasfab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridfresasfab.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridfresasfab.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridfresasfab.CaptionText = "Fresas Fabricadas"
        Me.DataGridfresasfab.DataMember = ""
        Me.DataGridfresasfab.FlatMode = True
        Me.DataGridfresasfab.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridfresasfab.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridfresasfab.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGridfresasfab.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGridfresasfab.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridfresasfab.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridfresasfab.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridfresasfab.LinkColor = System.Drawing.Color.Teal
        Me.DataGridfresasfab.Location = New System.Drawing.Point(24, 24)
        Me.DataGridfresasfab.Name = "DataGridfresasfab"
        Me.DataGridfresasfab.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridfresasfab.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridfresasfab.ReadOnly = True
        Me.DataGridfresasfab.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridfresasfab.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridfresasfab.Size = New System.Drawing.Size(280, 144)
        Me.DataGridfresasfab.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl2.Controls.Add(Me.Label15)
        Me.UltraTabPageControl2.Controls.Add(Me.Label14)
        Me.UltraTabPageControl2.Controls.Add(Me.dateHasta)
        Me.UltraTabPageControl2.Controls.Add(Me.dateDesde)
        Me.UltraTabPageControl2.Controls.Add(Me.cmbFiltrar)
        Me.UltraTabPageControl2.Controls.Add(Me.btnFiltrar)
        Me.UltraTabPageControl2.Controls.Add(Me.Label13)
        Me.UltraTabPageControl2.Controls.Add(Me.txtFiltrar)
        Me.UltraTabPageControl2.Controls.Add(Me.btnSalir)
        Me.UltraTabPageControl2.Controls.Add(Me.dgpedidos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(813, 545)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radioNinguno)
        Me.GroupBox1.Controls.Add(Me.radioRealizacion)
        Me.GroupBox1.Controls.Add(Me.radioEntrega)
        Me.GroupBox1.Location = New System.Drawing.Point(679, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 74)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar fecha por:"
        '
        'radioNinguno
        '
        Me.radioNinguno.AutoSize = True
        Me.radioNinguno.Location = New System.Drawing.Point(6, 52)
        Me.radioNinguno.Name = "radioNinguno"
        Me.radioNinguno.Size = New System.Drawing.Size(65, 17)
        Me.radioNinguno.TabIndex = 2
        Me.radioNinguno.Text = "Ninguno"
        Me.radioNinguno.UseVisualStyleBackColor = True
        '
        'radioRealizacion
        '
        Me.radioRealizacion.AutoSize = True
        Me.radioRealizacion.Checked = True
        Me.radioRealizacion.Location = New System.Drawing.Point(6, 20)
        Me.radioRealizacion.Name = "radioRealizacion"
        Me.radioRealizacion.Size = New System.Drawing.Size(80, 17)
        Me.radioRealizacion.TabIndex = 1
        Me.radioRealizacion.TabStop = True
        Me.radioRealizacion.Text = "Realizacion"
        Me.radioRealizacion.UseVisualStyleBackColor = True
        '
        'radioEntrega
        '
        Me.radioEntrega.AutoSize = True
        Me.radioEntrega.Location = New System.Drawing.Point(6, 36)
        Me.radioEntrega.Name = "radioEntrega"
        Me.radioEntrega.Size = New System.Drawing.Size(62, 17)
        Me.radioEntrega.TabIndex = 0
        Me.radioEntrega.Text = "Entrega"
        Me.radioEntrega.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(410, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Desde"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(412, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Hasta"
        '
        'dateHasta
        '
        Me.dateHasta.Location = New System.Drawing.Point(449, 57)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.Size = New System.Drawing.Size(201, 20)
        Me.dateHasta.TabIndex = 26
        '
        'dateDesde
        '
        Me.dateDesde.Location = New System.Drawing.Point(449, 31)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.Size = New System.Drawing.Size(201, 20)
        Me.dateDesde.TabIndex = 25
        '
        'cmbFiltrar
        '
        Me.cmbFiltrar.AutoSize = True
        ValueListItem3.DataValue = "ValueListItem0"
        ValueListItem3.DisplayText = "Nombre cliente"
        ValueListItem3.Tag = "nombreCliente"
        ValueListItem4.DataValue = "ValueListItem1"
        ValueListItem4.DisplayText = "Numero Pedido"
        ValueListItem4.Tag = "NroPedido"
        Appearance6.FontData.BoldAsString = "True"
        ValueListItem5.Appearance = Appearance6
        ValueListItem5.DataValue = "ValueListItem7"
        ValueListItem5.DisplayText = "Ninguno"
        ValueListItem5.Tag = "ninguno"
        Me.cmbFiltrar.Items.Add(ValueListItem3)
        Me.cmbFiltrar.Items.Add(ValueListItem4)
        Me.cmbFiltrar.Items.Add(ValueListItem5)
        Me.cmbFiltrar.Location = New System.Drawing.Point(65, 30)
        Me.cmbFiltrar.Name = "cmbFiltrar"
        Me.cmbFiltrar.Size = New System.Drawing.Size(224, 21)
        Me.cmbFiltrar.TabIndex = 24
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(295, 30)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(80, 48)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Text = "Filtrar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(11, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Filtrar por:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.AutoSize = True
        Me.txtFiltrar.Location = New System.Drawing.Point(65, 57)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(224, 21)
        Me.txtFiltrar.TabIndex = 21
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(708, 509)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 24)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'dgpedidos
        '
        Me.dgpedidos.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgpedidos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgpedidos.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgpedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgpedidos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgpedidos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgpedidos.CaptionText = "Pedidos Realizados"
        Me.dgpedidos.DataMember = ""
        Me.dgpedidos.FlatMode = True
        Me.dgpedidos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgpedidos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgpedidos.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgpedidos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgpedidos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgpedidos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgpedidos.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgpedidos.LinkColor = System.Drawing.Color.Teal
        Me.dgpedidos.Location = New System.Drawing.Point(10, 100)
        Me.dgpedidos.Name = "dgpedidos"
        Me.dgpedidos.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgpedidos.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgpedidos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgpedidos.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgpedidos.Size = New System.Drawing.Size(786, 403)
        Me.dgpedidos.TabIndex = 0
        '
        'UltraTabControl1
        '
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance7.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance8
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance9.BackColor = System.Drawing.Color.Silver
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance9
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(817, 568)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Nota de Pedido"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Consultas"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(813, 545)
        '
        'frmpedidocliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 566)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "frmpedidocliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar pedido"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txtimportetotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.combocliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaentrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboformaentrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboestado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txtsubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridpp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridMf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubtot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGriddos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridservicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridfresasfab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Metodos"
    Private Sub frmpedidocliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' seteo el estilo del datagrid 
        modelo.setearGrilla(DataGridMf)
        tipofresa.setearGrilla(DataGridMf)
        parteAdicional.setearGrilla(DataGridMf)
        fresa.setearGrilla(DataGridF)
        partepedida.setearGrilla(DataGridpp)
        serv.setearGrilla(Me.DataGridservicios)
        DOS.setearGrilla(Me.DataGriddos)

        ' cargo los datos en el dataset (de las tablas modelofresa, tipofresa, parteadicional)
        modelo.cargarAdaptador()
        modelo.cargarDatos(ds, "modelofresa")
        tipofresa.cargarAdaptador()
        tipofresa.cargarDatos(ds, "tipofresa")
        parteAdicional.cargarAdaptador()
        parteAdicional.cargarDatos(ds, "parteadicional")
        fresa.cargaradaptador("select * from fresa", cnn)
        fresa.cargaresquema(ds, "fresa")
        pedido.cargaradaptador("select * from pedido", cnn)
        pedido.cargaresquema(ds, "pedidocliente")
        partepedida.cargaradaptador("select * from partepedido", cnn)
        partepedida.cargaresquema(ds, "partepedida")
        serv.cargaradaptador("select * from operacion", cnn)
        serv.cargardatos(ds, "servicios")
        DOS.cargaradaptador("select * from detalleordenservicio", cnn)
        DOS.cargaresquema(ds, "DOS")
        obj.cargaradaptador("select * from objetodelservicio", cnn)
        obj.cargaresquema(ds, "OBJ")
        ' agrego la columna check los datatables de cada clase
        modelo.agregarCheck(ds)
        tipofresa.agregarCheck(ds)
        parteAdicional.agregarCheck(ds)
        fresa.cargarcol(ds)
        partepedida.agregarCol(ds)
        serv.cargarcol(ds)
        DOS.cargarcol(ds)
        ' pongo la columna check de todas las filas de la tabla en falso para que no me aparezcan seleccionadas 
        Dim i As Integer
        For i = 0 To ds.Tables("modelofresa").Rows.Count - 1
            ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False
        Next
        For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
            ds.Tables("tipofresa").Rows(i).Item("seleccionarTF") = False
        Next
        For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
            ds.Tables("parteadicional").Rows(i).Item("seleccionarPA") = False
        Next
        For i = 0 To ds.Tables("servicios").Rows.Count - 1
            ds.Tables("servicios").Rows(i).Item("seleccionarserv") = False
        Next
        For i = 0 To ds.Tables("servicios").Rows.Count - 1
            ds.Tables("servicios").Rows(i)("precio") = 0
        Next
        ' creo las relaciones entre las tablas
        crearRelacion(ds, "modelofresa", "tipofresa", "idmodelo", "idmodelo", "Fresas individuales")
        crearRelacion(ds, "modelofresa", "parteadicional", "idmodelo", "idmodelo", "Partes adicionales")

        ' vinculo el datagrid con el origen de datos
        DataGridMf.SetDataBinding(ds, "modelofresa")
        DataGridF.SetDataBinding(ds, "fresa")
        DataGridpp.SetDataBinding(ds, "partepedida")
        DataGridservicios.SetDataBinding(ds, "servicios")
        DataGriddos.SetDataBinding(ds, "DOS")
        ' cargo los combos de empleados y clientes

        cargarComboTag("select nombre,idestado from estado", comboestado, 1, 1)
        cargarComboTag("select nombre,idformadeentrega from formadeentrega", comboformaentrega, 1, 1)
        cargarComboTag("select * from cliente", combocliente, 0, 23)
        'comboestado.Text = comboestado.Items(7).DisplayText
        comboformaentrega.Text = comboformaentrega.Items(0).DisplayText

        princ.barra.agregarBoton(Me)

        bandeabm = False

        UltraGroupBox1.Visible = True
        UltraGroupBox3.Visible = False

        Me.combocliente.ReadOnly = True
        Me.fechaentrega.ReadOnly = True
        Me.comboestado.ReadOnly = True
        Me.comboformaentrega.ReadOnly = True
        Me.DataGriddos.ReadOnly = True
        Me.DataGridMf.ReadOnly = True
        Me.DataGridfresasfab.ReadOnly = True
        Me.DataGridF.ReadOnly = True
        Me.txtcantidad.ReadOnly = True
        Me.txtimportetotal.ReadOnly = True
        Me.txtsubtot.ReadOnly = True
        Me.txtsubtotal.ReadOnly = True
        Me.txtitem.ReadOnly = True
        Me.DataGridservicios.ReadOnly = True
        Me.btnagregar.Enabled = False
        Me.btnquiter.Enabled = False
        Me.botagregar.Enabled = False
        Me.botquitar.Enabled = False

        Me.btngrabar.Enabled = False
        Me.btnmodificar.Enabled = False
        UltraOptionSet1.CheckedIndex = 0

        Dim str As String = "select pedido.idpedido As NroPedido, pedido.fecharealizacion, pedido.fechaentrega, estado.nombre as estado," _
                   & "cliente.nombre as NombreCliente, cliente.apellido as ApellidoCliente from cliente, pedido, estado where cliente.idcliente=pedido.idcliente and pedido.idestado=estado.idestado"
        Dim da As New SqlClient.SqlDataAdapter(str, cnn)
        da.Fill(ds, "PR")
        Setearpedidos(dgpedidos)
        dgpedidos.SetDataBinding(ds, "PR")

        str = "select fresa.nroserie,tipofresa.nombre,fresa.fechafinfabricacion from fresa,pedido," _
        & "tipofresa where fresa.nropedido = pedido.idpedido And fresa.idtipo = tipofresa.idtipo And " _
        & " fresa.idmodelo=tipofresa.idmodelo and fresa.fechafinfabricacion is not null and  pedido.idcliente = " & CLng(idcliente)
        da = New SqlClient.SqlDataAdapter(str, cnn)
        da.FillSchema(ds, SchemaType.Source, "FF")
        setearfresas(DataGridfresasfab)
        DataGridfresasfab.SetDataBinding(ds, "FF")

        'nroserie = calcularnroserie()
        idpartepedida = 0
        idobj = 0
        nroserie = 0

        If Me.IdPesupuesto <> Nothing Then
            cargarPresupuesto()
        End If

    End Sub

    Function calcularnroserie() As Object
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        Dim nroserie As Object
        Dim cmd As New SqlClient.SqlCommand
        Dim strsql = "select max(nroserie) from fresa"
        cmd.Connection = cnn
        cmd.CommandText = strsql
        nroserie = cmd.ExecuteScalar
        If IsDBNull(nroserie) Then
            nroserie = 0
        End If
        calcularnroserie = nroserie
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
    End Function

    Function calcularidobj() As Object
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        Dim id As Object
        Dim cmd As New SqlClient.SqlCommand
        Dim strsql = "select max(idobjetodelservicio) from objetodelservicio"
        cmd.Connection = cnn
        cmd.CommandText = strsql
        id = cmd.ExecuteScalar
        If IsDBNull(id) Then
            id = 0
        End If
        calcularidobj = id
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
    End Function


    Function calcularNropedido() As Object
        cnn.Open()
        Dim strsql = "select max(idpedido) from pedido"
        Dim cmd As New SqlClient.SqlCommand(strsql, cnn)
        Dim nropedido As Object
        nropedido = cmd.ExecuteScalar
        cnn.Close()
        If IsDBNull(nropedido) Then
            nropedido = 0
        End If
        nropedido += 1
        calcularNropedido = nropedido
    End Function


    Private Sub DataGridMF_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim row As Integer
        row = DataGridMf.CurrentCell.RowNumber

        If sel_check_col(DataGridMf, 0, e) And DataGridMf.DataMember = "modelofresa" Then

            Dim i As Integer
            i = DataGridMf.Item(DataGridMf.CurrentRowIndex, 1) - 1

            Select Case ds.Tables("modelofresa").Rows(DataGridMf.CurrentRowIndex).Item("seleccionarMF")

                Case False

                    ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = True
                    'MsgBox("paso a TRUE")


                    Dim elemento As DataRow
                    Dim hijos As Array

                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Fresas individuales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarTF") = True
                    Next


                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Partes adicionales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarPA") = True
                    Next


                Case True

                    ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False
                    'MsgBox("paso a FALSE")

                    Dim elemento As DataRow
                    Dim hijos As Array

                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Fresas individuales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarTF") = False
                    Next


                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Partes adicionales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarPA") = False
                    Next

            End Select

            DataGridMf.Select(row)

        End If

        DataGridMf.Refresh()
    End Sub


    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Try
            Dim i As Integer
            Dim j As Integer
            'Cargo los tipos de fresas
            For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
                If ds.Tables("tipofresa").Rows(i).Item("seleccionarTF") = True Then
                    nroserie += 1
                    Dim dr As DataRow = ds.Tables("fresa").NewRow
                    dr("nroserie") = CInt(nroserie)
                    dr("idtipo") = ds.Tables("tipofresa").Rows(i).Item("idtipo")
                    dr("idmodelo") = ds.Tables("tipofresa").Rows(i).Item("idmodelo")
                    dr("nropedido") = CLng(lblnropedido.Text)
                    dr("estado") = comboestado.SelectedItem.Tag()
                    dr("nombre") = ds.Tables("tipofresa").Rows(i).Item("nombre")
                    ds.Tables("fresa").Rows.Add(dr)
                    dr("precio") = CDec(ds.Tables("tipofresa").Rows(i).Item("precio"))
                    ds.Tables("tipofresa").Rows(i).Item("seleccionarTF") = False
                End If
            Next
            For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                idpartepedida += 1
                Dim dr As DataRow = ds.Tables("partepedida").NewRow
                dr("idpartepedida") = CInt(idpartepedida)
                dr("idmodelo") = ds.Tables("parteadicional").Rows(i).Item("idmodelo")
                dr("idadicional") = ds.Tables("parteadicional").Rows(i).Item("idadicional")
                dr("idpedido") = CLng(lblnropedido.Text)
                dr("nombre") = ds.Tables("parteadicional").Rows(i).Item("nombre")
                dr("precio") = ds.Tables("parteadicional").Rows(i).Item("precio")
                ds.Tables("partepedida").Rows.Add(dr)
                ds.Tables("parteadicional").Rows(i).Item("seleccionarpa") = False
            Next
            Dim subtotal As Decimal = 0
            For i = 0 To ds.Tables("fresa").Rows.Count - 1
                subtotal += ds.Tables("fresa").Rows(i).Item("precio")
            Next
            For i = 0 To ds.Tables("partepedida").Rows.Count - 1
                subtotal += CDec(ds.Tables("partepedida").Rows(i).Item("precio"))
            Next

            txtsubtotal.Text = CStr(subtotal)
            txtimportetotal.Text = CStr(CDec(txtsubtotal.Text) + CDec(txtsubtot.Text))
        Catch ex As Exception
            MessageBox.Show("Problemas de Red, consulte a su Admnistrador")
        End Try
        
    End Sub


    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        lblnropedido.Text = calcularNropedido()
        idobj = calcularidobj()
        lblfecharealizacion.Text = Format(Now, "dd/MM/yyyy")
        'txtcliente.Enabled = True
        'txtcliente.Text = ""
        txtsubtotal.Text = "0"
        txtimportetotal.Text = "0"
        txtsubtot.Text = "0"
        'txtprioridad.Text = ""
        'txtcliente.Focus()
        ds.Tables("fresa").Clear()
        ds.Tables("pedidocliente").Clear()
        ds.Tables("partepedida").Clear()
        ds.Tables("DOS").Clear()
        ds.Tables("OBJ").Clear()
        ds.Tables("FF").Clear()
        bandeabm = False
        bnuevo = True
        bpedido = True
        nroserie = calcularnroserie()
        idpartepedida = 0
        Me.combocliente.ReadOnly = False
        Me.fechaentrega.ReadOnly = False
        Me.comboestado.ReadOnly = False
        Me.comboformaentrega.ReadOnly = False
        'Me.DataGriddos.ReadOnly = False
        Me.DataGridMf.ReadOnly = False
        'Me.DataGridfresasfab.ReadOnly = False
        'Me.DataGridF.ReadOnly = False
        'Me.DataGridpp.ReadOnly = False
        Me.txtcantidad.ReadOnly = False
        Me.txtimportetotal.ReadOnly = False
        Me.txtsubtot.ReadOnly = False
        Me.txtsubtotal.ReadOnly = False
        Me.txtitem.ReadOnly = False
        Me.DataGridservicios.ReadOnly = False
        Me.btnagregar.Enabled = True
        Me.btnquiter.Enabled = True
        Me.botagregar.Enabled = True
        Me.botquitar.Enabled = True

        Me.btngrabar.Enabled = True
        combocliente.Text = String.Empty
    End Sub


    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Dim i As Integer
        Dim b1 As Boolean
        Dim b2 As Boolean
        b1 = False
        b2 = False
        If combocliente.Text = String.Empty Then
            MsgBox("selecccione un cliente")
            Exit Sub
        End If
        If CDate(lblfecharealizacion.Text) > CDate(fechaentrega.Value) Then
            MsgBox("fecha entrega no válida")
            Exit Sub
        End If

        If bandeabm = False Then
            Dim dr As DataRow = ds.Tables("pedidocliente").NewRow
            dr("idpedido") = CObj(lblnropedido.Text)
            dr("fecharealizacion") = CDate(lblfecharealizacion.Text)
            'dr("prioridad") = CInt(txtprioridad.Text)
            dr("idestado") = comboestado.SelectedItem.Tag()
            'dr("idestado") = CInt(comboestado.Items(comboestado.SelectedIndex).Tag())
            idcliente = combocliente.SelectedItem.Tag
            dr("idcliente") = idcliente
            dr("fechaentrega") = fechaentrega.Value
            'dr("idformadeentrega") = CInt(comboformaentrega.Items(comboformaentrega.SelectedIndex).Tag)
            dr("idformadeentrega") = comboformaentrega.SelectedItem.Tag
            ds.Tables("pedidocliente").Rows.Add(dr)
        Else
            'ds.Tables("pedido").Rows(0).Item("prioridad") = CInt(txtprioridad.Text)
            ds.Tables("pedidocliente").Rows(0).Item("idestado") = comboestado.SelectedItem.Tag
            'ds.Tables("pedido").Rows(0).Item("idcliente") = idcliente
            ds.Tables("pedidocliente").Rows(0).Item("fechaentrega") = fechaentrega.Value
            ds.Tables("pedidocliente").Rows(0).Item("idformadeentrega") = comboformaentrega.SelectedItem.Tag
        End If
        pedido.actualizar(ds, "pedidocliente")
        fresa.actualizar(ds, "fresa")
        partepedida.actualizar(ds, "partepedida")
        obj.actualizar(ds, "OBJ")
        DOS.actualizar(ds, "DOS")

        btngrabar.Enabled = False
        'txtprioridad.Text = ""
        'txtcliente.Text = ""
        'txtimportetotal.Text = ""
        'txtsubtot.Text = ""
        'txtsubtotal.Text = ""
        'txtcliente.Enabled = False
        'UltraGroupBox1.Enabled = False
        'UltraGroupBox2.Enabled = False

        btnnuevo.Focus()
        bnuevo = False
        bpedido = False
        btnmodificar.Enabled = False
    End Sub


    Private Sub UltraTabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraTabControl1.Click
        If UltraTabControl1.SelectedTab.Index = 1 Then

            'periodo inicial (ultimos seis meses)
            Dim desde As New Date(Now.Year, Now.Month - 6, Now.Day)
            dateDesde.Value = desde
            dateHasta.Value = Now

            cmbFiltrar.Text = "Ninguno"

            Dim consulta As String = "SELECT pedido.idpedido AS NroPedido, " & _
                                  "pedido.fecharealizacion, " & _
                                  "pedido.fechaentrega, " & _
                                  "estado.nombre AS estado, " & _
                                  "rtrim(cliente.apellido) + ', ' + cliente.nombre AS nombreCliente " & _
                                  "FROM cliente, pedido, estado " & _
                                  "WHERE cliente.idcliente = pedido.idcliente And pedido.idestado = estado.idestado " & _
                                  "AND pedido.fecharealizacion >= '" + dateDesde.Value + "' " & _
                                  "AND pedido.fecharealizacion <= '" + dateHasta.Value + "'"

            Dim da As SqlClient.SqlDataAdapter
            da = New SqlClient.SqlDataAdapter(consulta, cnn)

            ds.Tables("PR").Clear()
            da.Fill(ds, "PR")
            Dim dvpedidos As New DataView(ds.Tables("PR"))
            dgpedidos.DataSource = dvpedidos

            dgpedidos.Refresh()

        End If
    End Sub

    Sub setearfresas(ByVal dg As DataGrid)
        Dim ts As New DataGridTableStyle

        ts.MappingName = "FF"

        Dim c1 As New grdstyle.CGridTextBoxStyle("Nroserie", 80, HorizontalAlignment.Center, True, "NRO SERIE", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("nombre", 90, HorizontalAlignment.Center, True, "TIPO FRESA", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("fechafinfabricacion", 100, HorizontalAlignment.Center, True, "FIN FABRICACION", "", "")
        ts.GridColumnStyles.Add(c3)

        dg.TableStyles.Add(ts)
    End Sub

    Sub Setearpedidos(ByVal dg As DataGrid)
        Dim ts As New DataGridTableStyle

        ts.MappingName = "pr"

        Dim c1 As New grdstyle.CGridTextBoxStyle("Nropedido", 100, HorizontalAlignment.Center, True, "NRO PEDIDO", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("fecharealizacion", 120, HorizontalAlignment.Center, True, "FECHA REALIZACION", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("fechaentrega", 120, HorizontalAlignment.Center, True, "FECHA ENTREGA", "", "")
        ts.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("estado", 115, HorizontalAlignment.Center, True, "ESTADO", "", "")
        ts.GridColumnStyles.Add(c4)

        Dim c6 As New grdstyle.CGridTextBoxStyle("nombrecliente", 295, HorizontalAlignment.Center, True, "CLIENTE", "", "")
        ts.GridColumnStyles.Add(c6)

        dg.TableStyles.Add(ts)
    End Sub


    Private Sub dgpedidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgpedidos.DoubleClick

        Dim cmd As New SqlClient.SqlCommand
        Dim i As Integer
        Dim j As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        Dim str As String = "select fresa.* from fresa where fresa.nropedido =" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        ds.Tables("fresa").Clear()
        fresa.cargaradaptador(str, cnn)
        fresa.cargardatos(ds, "fresa")
        'dafresa = New SqlDataAdapter(str, cnn)
        'dafresa.Fill(ds, "fresa")

        For j = 0 To ds.Tables("fresa").Rows.Count - 1
            For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
                If ds.Tables("fresa").Rows(j).Item("idtipo") = ds.Tables("tipofresa").Rows(i).Item("idtipo") And _
                ds.Tables("fresa").Rows(j).Item("idmodelo") = ds.Tables("tipofresa").Rows(i).Item("idmodelo") Then
                    ds.Tables("fresa").Rows(j).Item("nombre") = ds.Tables("tipofresa").Rows(i).Item("nombre")
                End If
            Next
        Next

        str = "select * from partepedido where idpedido =" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        ds.Tables("partepedida").Clear()
        partepedida.cargaradaptador(str, cnn)
        partepedida.cargardatos(ds, "partepedida")
        'dapartepedida = New SqlDataAdapter(str, cnn)
        'dapartepedida.Fill(ds, "partepedida")
        For j = 0 To ds.Tables("partepedida").Rows.Count - 1
            For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                If ds.Tables("partepedida").Rows(j).Item("idadicional") = ds.Tables("parteadicional").Rows(i).Item("idadicional") And _
                ds.Tables("partepedida").Rows(j).Item("idmodelo") = ds.Tables("parteadicional").Rows(i).Item("idmodelo") Then
                    ds.Tables("partepedida").Rows(j).Item("nombre") = ds.Tables("parteadicional").Rows(i).Item("nombre")
                End If
            Next
        Next

        ds.Tables("pedidocliente").Clear()
        pedido.cargaradaptador("select * from pedido where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)), cnn)
        pedido.cargardatos(ds, "pedidocliente")
        'dapedido = New SqlDataAdapter("select * from pedido where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)), cnn)
        'dapedido.Fill(ds, "pedido")
        idcliente = ds.Tables("pedidocliente").Rows(0).Item("idcliente")
        For i = 0 To combocliente.Items.Count - 1
            If combocliente.Items.Item(i).Tag = idcliente Then
                combocliente.Text = combocliente.Items.Item(i).DisplayText
                combocliente.ReadOnly = True
                Exit For
            End If
        Next
        'cmd.CommandText = "select apellido from cliente where idcliente=" & idcliente
        cmd.Connection = cnn
        'txtcliente.Text = RTrim(CStr((cmd.ExecuteScalar)))
        'cmd.CommandText = "select nombre from cliente where idcliente=" & idcliente
        'cmd.Connection = cnn
        'txtcliente.Text &= ", " & RTrim(CStr(cmd.ExecuteScalar))
        'txtcliente.AutoSize = True
        'txtprioridad.Text = dtpedido.Rows(0).Item("prioridad")
        lblnropedido.Text = CStr(ds.Tables("pedidocliente").Rows(0).Item("idpedido"))
        'cmbestado.SelectedValue = ds.Tables("pedidocliente").Rows(0).Item("idestado")
        comboestado.Text = comboestado.Items(ds.Tables("pedidocliente").Rows(0).Item("idestado") - 1).DisplayText
        fechaentrega.Value = CDate(ds.Tables("pedidocliente").Rows(0).Item("fechaentrega"))
        Try
            comboformaentrega.Text = comboformaentrega.Items(ds.Tables("pedidocliente").Rows(0).Item("idformadeentrega") - 1).DisplayText
        Catch

        End Try

        'cmbformaentrega.SelectedValue = ds.Tables("pedidocliente").Rows(0).Item("idformadeentrega")

        lblfecharealizacion.Text = CStr(ds.Tables("pedidocliente").Rows(0).Item("fecharealizacion"))
        cmd.CommandText = "select max(idpartepedida) from partepedido where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        idpartepedida = cmd.ExecuteScalar
        If IsDBNull(idpartepedida) Then
            idpartepedida = 0
        End If
        cnn.Close()
        btngrabar.Enabled = False
        'txtcliente.Enabled = False

        Me.combocliente.ReadOnly = True
        Me.fechaentrega.ReadOnly = True
        Me.comboestado.ReadOnly = True
        Me.comboformaentrega.ReadOnly = True
        Me.DataGriddos.ReadOnly = True
        Me.DataGridMf.ReadOnly = True
        Me.DataGridfresasfab.ReadOnly = True
        Me.DataGridF.ReadOnly = True
        Me.DataGridpp.ReadOnly = True
        Me.txtcantidad.ReadOnly = True
        Me.txtimportetotal.ReadOnly = True
        Me.txtsubtot.ReadOnly = True
        Me.txtsubtotal.ReadOnly = True
        Me.txtitem.ReadOnly = True
        Me.DataGridservicios.ReadOnly = True
        Me.btnagregar.Enabled = False
        Me.btnquiter.Enabled = False
        Me.botagregar.Enabled = False
        Me.botquitar.Enabled = False

        bandeabm = True
        If Not (comboformaentrega.Items(comboformaentrega.SelectedIndex).Tag = 8) Then
            btnmodificar.Enabled = True
        Else
            btnmodificar.Enabled = False
        End If

        nroserie = calcularnroserie()
        idobj = calcularidobj()
        ds.Tables("DOS").Clear()
        str = "select * from detalleordenservicio where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        DOS.cargaradaptador(str, cnn)
        DOS.cargardatos(ds, "DOS")
        ds.Tables("OBJ").Clear()
        str = "select * from objetodelservicio where idobjetodelservicio in (select idobjetodelservicio from detalleordenservicio" _
        & " where idpedido= " & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)) & ")"
        ''¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡
        obj.cargaradaptador(str, cnn)
        obj.cargardatos(ds, "OBJ")
        For i = 0 To ds.Tables("DOS").Rows.Count - 1
            For j = 0 To ds.Tables("OBJ").Rows.Count - 1
                If ds.Tables("DOS").Rows(i).Item("idobjetodelservicio") = ds.Tables("OBJ").Rows(j).Item("idobjetodelservicio") Then
                    ds.Tables("DOS").Rows(i).Item("item") = ds.Tables("OBJ").Rows(j).Item("nombre")
                    ds.Tables("DOS").Rows(i).Item("cantidad") = ds.Tables("OBJ").Rows(j).Item("cantidad")
                End If
            Next
        Next
        For i = 0 To ds.Tables("DOS").Rows.Count - 1
            For j = 0 To ds.Tables("servicios").Rows.Count - 1
                If ds.Tables("DOS").Rows(i).Item("idoperacion") = ds.Tables("servicios").Rows(j).Item("idoperacion") Then
                    ds.Tables("DOS").Rows(i).Item("operacion") = ds.Tables("servicios").Rows(j).Item("nombre")
                End If
            Next
        Next

        txtimportetotal.Text = ""
        Dim subtotal1 As Decimal
        For i = 0 To ds.Tables("fresa").Rows.Count - 1
            subtotal1 += ds.Tables("fresa").Rows(i).Item("precio")
        Next
        For i = 0 To ds.Tables("partepedida").Rows.Count - 1
            subtotal1 += CDec(ds.Tables("partepedida").Rows(i).Item("precio")) ' CInt(ds.Tables("partepedida").Rows(i).Item("cantidad")) * CDec(ds.Tables("partepedida").Rows(i).Item("precio"))
        Next
        txtsubtotal.Text = CStr(subtotal1)
        Dim total As Decimal
        If Not (txtimportetotal.Text = String.Empty) Then
            total = CDec(txtimportetotal.Text)
        Else
            total = 0
        End If
        total += subtotal1
        txtimportetotal.Text = total

        Dim subtotal As Decimal
        For i = 0 To ds.Tables("DOS").Rows.Count - 1
            If Not (ds.Tables("DOS").Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += CDec(ds.Tables("DOS").Rows(i).Item("precio")) * CDec(ds.Tables("DOS").Rows(i).Item("cantidad"))
            End If
        Next
        txtsubtot.Text = subtotal
        If Not (txtimportetotal.Text = String.Empty) Then
            total = CDec(txtimportetotal.Text)
        Else
            total = 0
        End If
        total += subtotal
        txtimportetotal.Text = total
        UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(0)



    End Sub


    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click

        Me.combocliente.ReadOnly = False
        Me.fechaentrega.ReadOnly = False
        Me.comboestado.ReadOnly = False
        Me.comboformaentrega.ReadOnly = False
        'Me.DataGriddos.ReadOnly = False
        Me.DataGridMf.ReadOnly = False
        'Me.DataGridfresasfab.ReadOnly = False
        'Me.DataGridF.ReadOnly = False
        'Me.DataGridpp.ReadOnly = False
        Me.txtcantidad.ReadOnly = False
        Me.txtimportetotal.ReadOnly = False
        Me.txtsubtot.ReadOnly = False
        Me.txtsubtotal.ReadOnly = False
        Me.txtitem.ReadOnly = False
        Me.DataGridservicios.ReadOnly = False
        Me.btnagregar.Enabled = True
        Me.btnquiter.Enabled = True
        Me.botagregar.Enabled = True
        Me.botquitar.Enabled = True

        Me.btngrabar.Enabled = True
        'txtprioridad.Enabled = True
        bandeabm = True
        btnmodificar.Enabled = False
        idobj = calcularidobj()
    End Sub


    Private Sub UltraOptionSet1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraOptionSet1.Click
        If Me.UltraOptionSet1.CheckedIndex = 0 Then
            UltraGroupBox1.Visible = False
            UltraGroupBox3.Visible = True
        End If
        If Me.UltraOptionSet1.CheckedIndex = 1 Then
            UltraGroupBox1.Visible = True
            UltraGroupBox3.Visible = False
        End If
    End Sub


    Private Sub btnquiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquiter.Click
        Dim i As Integer
        If MsgBox("Está seguro", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        If ds.Tables("fresa").Rows.Count > 0 Then
            For i = ds.Tables("fresa").Rows.Count - 1 To 0 Step -1
                If Not (ds.Tables("fresa").Rows(i).RowState = DataRowState.Deleted) Then
                    If ds.Tables("fresa").Rows(i).Item("seleccionarf") = True Then
                        ds.Tables("fresa").Rows(i).Delete()
                        DataGridF.Refresh()
                    End If
                End If
            Next
            'For i = dtfresa.Rows.Count - 1 To 0 Step -1
            'If dtfresa.Rows(i).RowState = DataRowState.Deleted Then
            'dtfresa.Rows.Remove(dtfresa.Rows(i))
            'MsgBox(dtfresa.Rows.Count)
            'End If
            'Next
        End If
        'MsgBox(dtfresa.Rows.Count)
        If ds.Tables("partepedida").Rows.Count > 0 Then
            For i = ds.Tables("partepedida").Rows.Count - 1 To 0 Step -1
                If Not (ds.Tables("partepedida").Rows(i).RowState = DataRowState.Deleted) Then
                    If ds.Tables("partepedida").Rows(i).Item("seleccionarpp") = True Then
                        ds.Tables("partepedida").Rows(i).Delete()
                        DataGridpp.Refresh()
                    End If
                End If
            Next
            'For i = dtpartepedida.Rows.Count - 1 To 0 Step -1
            'If dtpartepedida.Rows(i).RowState = DataRowState.Deleted Then
            'dtpartepedida.Rows.Remove(dtpartepedida.Rows(i))
            'End If
            'Next
        End If
        'For i = 0 To ds.Tables("modelofresa").Rows.Count - 1
        'ds.Tables("modelofresa").Rows(i).Item("select") = "N"
        'Next
        Dim subtotal As Decimal
        For i = 0 To ds.Tables("fresa").Rows.Count - 1
            If Not (ds.Tables("fresa").Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += ds.Tables("fresa").Rows(i).Item("precio")
            End If

        Next
        For i = 0 To ds.Tables("partepedida").Rows.Count - 1
            If Not (ds.Tables("partepedida").Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += ds.Tables("partepedida").Rows(i).Item("precio") 'ds.Tables("partepedida").Rows(i).Item("cantidad")
            End If
        Next
        txtsubtotal.Text = subtotal
        txtimportetotal.Text = CDec(txtsubtot.Text) + CDec(txtsubtotal.Text)
    End Sub


    Private Sub DataGridMf_MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridMf.MouseUp
        Dim row As Integer
        row = DataGridMf.CurrentCell.RowNumber

        If sel_check_col(DataGridMf, 0, e) And DataGridMf.DataMember = "modelofresa" Then

            Dim i As Integer
            i = DataGridMf.Item(DataGridMf.CurrentRowIndex, 1) - 1
            Try
                Select Case ds.Tables("modelofresa").Rows(DataGridMf.CurrentRowIndex).Item("seleccionarMF")

                    Case False

                        ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = True
                        'MsgBox("paso a TRUE")


                        Dim elemento As DataRow
                        Dim hijos As Array

                        hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Fresas individuales")
                        For Each elemento In hijos
                            elemento.Item("seleccionarTF") = True
                        Next


                        hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Partes adicionales")
                        For Each elemento In hijos
                            elemento.Item("seleccionarPA") = True
                        Next


                    Case True

                        ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False
                        'MsgBox("paso a FALSE")

                        Dim elemento As DataRow
                        Dim hijos As Array

                        hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Fresas individuales")
                        For Each elemento In hijos
                            elemento.Item("seleccionarTF") = False
                        Next


                        hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Partes adicionales")
                        For Each elemento In hijos
                            elemento.Item("seleccionarPA") = False
                        Next

                End Select
            Catch
                'nada
            End Try

            DataGridMf.Select(row)

        End If

        DataGridMf.Refresh()
    End Sub


    Private Sub botagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botagregar.Click
        Try
            Dim i As Integer
            Dim b As Boolean
            b = False
            For i = 0 To ds.Tables("servicios").Rows.Count - 1
                If ds.Tables("servicios").Rows(i).Item("seleccionarserv") = True Then
                    b = True
                End If

            Next
            If b = False Then
                MsgBox("seleccione un servicio")
                Exit Sub
            End If
            Dim dr2 As DataRow = ds.Tables("OBJ").NewRow
            idobj = CInt(idobj) + 1
            If txtitem.Text = String.Empty Then
                dr2("idobjetodelservicio") = idobj
                dr2("nombre") = ds.Tables("FF").Rows(DataGridfresasfab.CurrentRowIndex).Item("nombre")
                dr2("cantidad") = 1
                dr2("nroserie") = ds.Tables("FF").Rows(DataGridfresasfab.CurrentRowIndex).Item("nroserie")
                ds.Tables("OBJ").Rows.Add(dr2)
                For i = 0 To ds.Tables("servicios").Rows.Count - 1
                    If ds.Tables("servicios").Rows(i).Item("seleccionarserv") = True Then
                        Dim dr1 As DataRow = ds.Tables("dos").NewRow
                        dr1("idpedido") = CLng(lblnropedido.Text)
                        dr1("idoperacion") = ds.Tables("servicios").Rows(i).Item("idoperacion")
                        dr1("idobjetodelservicio") = idobj
                        dr1("item") = ds.Tables("FF").Rows(DataGridfresasfab.CurrentRowIndex).Item("nombre")
                        dr1("operacion") = ds.Tables("servicios").Rows(i).Item("nombre")
                        dr1("cantidad") = 1
                        dr1("nroserie") = ds.Tables("FF").Rows(DataGridfresasfab.CurrentRowIndex).Item("nroserie")
                        If ds.Tables("servicios").Rows(i).Item("precio") = 0 Then
                            MsgBox("Falta Precio de Servicio")
                            Exit Sub
                        Else
                            dr1("precio") = CDec(ds.Tables("servicios").Rows(i).Item("precio"))
                        End If
                        ds.Tables("dos").Rows.Add(dr1)
                    End If
                Next
            End If
            If Not (txtitem.Text = String.Empty) Then
                dr2("idobjetodelservicio") = idobj
                dr2("nombre") = txtitem.Text
                dr2("cantidad") = CInt(txtcantidad.Text)
                ds.Tables("OBJ").Rows.Add(dr2)
                For i = 0 To ds.Tables("servicios").Rows.Count - 1
                    If ds.Tables("servicios").Rows(i).Item("seleccionarserv") = True Then

                        Dim dr1 As DataRow = ds.Tables("DOS").NewRow
                        dr1("idpedido") = CLng(lblnropedido.Text)
                        dr1("idoperacion") = ds.Tables("servicios").Rows(i).Item("idoperacion")
                        dr1("idobjetodelservicio") = idobj
                        dr1("item") = txtitem.Text
                        dr1("operacion") = ds.Tables("servicios").Rows(i).Item("nombre")
                        If txtcantidad.Text = "" Then
                            MsgBox("Ingrese cantidad")
                            Exit Sub
                        End If
                        dr1("cantidad") = CInt(txtcantidad.Text)
                        If ds.Tables("servicios").Rows(i).Item("precio") = 0 Then
                            MsgBox("Falta Precio de Servicio")
                            Exit Sub
                        Else
                            dr1("precio") = CDec(ds.Tables("servicios").Rows(i).Item("precio"))
                        End If
                        ds.Tables("DOS").Rows.Add(dr1)
                    End If
                Next
            End If
            For i = 0 To ds.Tables("servicios").Rows.Count - 1
                ds.Tables("servicios").Rows(i).Item("seleccionarserv") = False
            Next
            Dim subtotal As Decimal
            For i = 0 To ds.Tables("DOS").Rows.Count - 1
                If Not (ds.Tables("DOS").Rows(i).RowState = DataRowState.Deleted) Then
                    subtotal += CDec(ds.Tables("DOS").Rows(i).Item("precio")) * CInt(ds.Tables("DOS").Rows(i).Item("cantidad"))
                End If
            Next
            txtsubtot.Text = subtotal
            Dim total As Decimal
            If Not (txtimportetotal.Text = String.Empty) Then
                total = CDec(txtimportetotal.Text)
            Else
                total = 0
            End If
            total += subtotal
            txtimportetotal.Text = total
            'Va al ultimo
            txtitem.Text = ""
            'txtdescripcion.Text = ""
            txtcantidad.Text = ""
            'txtitem.Enabled = False
            'txtdescripcion.Enabled = False
            'txtcantidad.Enabled = False
            For i = 0 To ds.Tables("servicios").Rows.Count - 1
                ds.Tables("servicios").Rows(i)("precio") = 0
            Next
        Catch ex As Exception
            MessageBox.Show("Problemas de red, consulte a su Administrador")
        End Try

        
    End Sub


    Private Sub botquitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botquitar.Click
        ds.Tables("DOS").Rows(Me.DataGriddos.CurrentRowIndex).Delete()
        DataGriddos.Refresh()
        Dim i As Integer
        Dim subtotal As Decimal

        For i = 0 To ds.Tables("DOS").Rows.Count - 1
            If Not (ds.Tables("DOS").Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += ds.Tables("DOS").Rows(i)("precio") * ds.Tables("DOS").Rows(i)("cantidad")
            End If
        Next
        txtimportetotal.Text = CDec(txtsubtot.Text) + CDec(txtsubtotal.Text)
    End Sub

    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Function validarfecha(ByVal Keyascii As Short) As Short
        If InStr("1234567890/", Chr(Keyascii)) = 0 Then
            validarfecha = 0
        Else
            validarfecha = Keyascii
        End If
        Select Case Keyascii
            Case 8
                validarfecha = Keyascii
            Case 13
                validarfecha = Keyascii
        End Select
    End Function

    Function SoloLETRAS(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
        ' Intercepta un código ASCII recibido admitiendo solamente
        ' letras, además:
        ' deja pasar sin afectar si recibe tecla de Backspace o enter
        If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ", Chr(KeyAscii)) = 0 Then
            SoloLETRAS = 0
        Else
            SoloLETRAS = KeyAscii
        End If
        ' teclas adicionales permitidas
        If KeyAscii = 8 Then SoloLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoloLETRAS = KeyAscii ' Enter
    End Function


    Private Sub txtfecharealizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(validarfecha(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub frmpedidocliente_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub


    Private Sub combocliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combocliente.ValueChanged
        If combocliente.Text = String.Empty Then
            Exit Sub
        End If
        idcliente = combocliente.SelectedItem.Tag
        Dim strsql As String = "select fresa.nroserie,tipofresa.nombre,fresa.fechafinfabricacion from fresa,pedido," _
        & "tipofresa where fresa.nropedido = pedido.idpedido And fresa.idtipo = tipofresa.idtipo And " _
        & " fresa.idmodelo=tipofresa.idmodelo and fresa.fechafinfabricacion is not null and  pedido.idcliente = " & CLng(idcliente)
        ds.Tables("FF").Clear()
        Dim da As New SqlClient.SqlDataAdapter(strsql, cnn)
        da.Fill(ds, "FF")
        DataGridfresasfab.Refresh()
    End Sub


    Private Sub DataGridF_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridF.MouseUp
        Try
            If sel_check_col(DataGridF, 0, e) Then

                Select Case ds.Tables("fresa").Rows(DataGridF.CurrentRowIndex).Item("seleccionarf")
                    Case False
                        ds.Tables("fresa").Rows(DataGridF.CurrentRowIndex).Item("seleccionarf") = True

                    Case True
                        ds.Tables("fresa").Rows(DataGridF.CurrentRowIndex).Item("seleccionarF") = False
                        DataGridF.Refresh()
                End Select
                DataGridF.Select(DataGridF.CurrentCell.RowNumber)
                DataGridF.Refresh()
            End If
        Catch
            'nada
        End Try
    End Sub


    Private Sub DataGridpp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridpp.MouseUp
        Try
            If sel_check_col(DataGridpp, 0, e) Then

                Select Case ds.Tables("partepedida").Rows(DataGridpp.CurrentRowIndex).Item("seleccionarpp")
                    Case False
                        ds.Tables("partepedida").Rows(DataGridpp.CurrentRowIndex).Item("seleccionarpp") = True

                    Case True
                        ds.Tables("partepedida").Rows(DataGridpp.CurrentRowIndex).Item("seleccionarpp") = False

                End Select
                DataGridpp.Select(DataGridpp.CurrentCell.RowNumber)
                DataGridpp.Refresh()
            End If
        Catch
            'nada
        End Try
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Dim consulta As String = ""

        If radioRealizacion.Checked = True Then
            consulta = "SELECT pedido.idpedido AS NroPedido, " & _
                      "pedido.fecharealizacion, " & _
                      "pedido.fechaentrega, " & _
                      "estado.nombre AS estado, " & _
                      "rtrim(cliente.apellido) + ', ' + cliente.nombre AS nombreCliente " & _
                      "FROM cliente, pedido, estado " & _
                      "WHERE cliente.idcliente = pedido.idcliente And pedido.idestado = estado.idestado " & _
                      "AND pedido.fecharealizacion >= '" + dateDesde.Value + "' " & _
                      "AND pedido.fecharealizacion <= '" + dateHasta.Value + "'"
        End If

        If radioEntrega.Checked = True Then
            consulta = "SELECT pedido.idpedido AS NroPedido, " & _
                      "pedido.fecharealizacion, " & _
                      "pedido.fechaentrega, " & _
                      "estado.nombre AS estado, " & _
                      "rtrim(cliente.apellido) + ', ' + cliente.nombre AS nombreCliente " & _
                      "FROM cliente, pedido, estado " & _
                      "WHERE cliente.idcliente = pedido.idcliente And pedido.idestado = estado.idestado " & _
                      "AND pedido.fechaentrega >= '" + dateDesde.Value + "' " & _
                      "AND pedido.fechaentrega <= '" + dateHasta.Value + "'"
        End If

        If radioNinguno.Checked = True Then
            consulta = "SELECT pedido.idpedido AS NroPedido, " & _
                      "pedido.fecharealizacion, " & _
                      "pedido.fechaentrega, " & _
                      "estado.nombre AS estado, " & _
                      "rtrim(cliente.apellido) + ', ' + cliente.nombre AS nombreCliente " & _
                      "FROM cliente, pedido, estado " & _
                      "WHERE cliente.idcliente = pedido.idcliente And pedido.idestado = estado.idestado "
        End If


        Dim da As SqlClient.SqlDataAdapter
        da = New SqlClient.SqlDataAdapter(consulta, cnn)

        ds.Tables("PR").Clear()
        da.Fill(ds, "PR")

        Dim dataView As New DataView(ds.Tables("PR"))
        Dim filtrar As Boolean
        Const FILTRO_NINGUNO As String = "ninguno"

        If (txtFiltrar.Text = "" And cmbFiltrar.SelectedItem.Tag <> FILTRO_NINGUNO) Then
            MsgBox("Debe ingresar condicion a filtrar", MsgBoxStyle.Information)
            filtrar = False
            txtFiltrar.Focus()
            Exit Sub
        End If

        'Por si hace falta filtrar por estado mas adelante
        'Dim estado As String
        'If radioAlta.Checked Then
        '    estado = Constantes.MODELO_FRESA_ESTADO_ALTA
        'Else
        '    estado = Constantes.MODELO_FRESA_ESTADO_BAJA
        'End If


        Select Case cmbFiltrar.SelectedItem.Tag.ToString
            Case "NroPedido"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " = " & txtFiltrar.Text '& " And estado = '" & estado & "'"
            Case "nombreCliente"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " LIKE '%" & txtFiltrar.Text.Trim & "%'" '& " And estado = '" & estado & "'"
            Case FILTRO_NINGUNO
                'nothing to do
            Case Else
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " LIKE '%" & txtFiltrar.Text.Trim & "%'" '& " And estado = '" & estado & "'"
        End Select

        dgpedidos.DataSource = dataView

        dgpedidos.Refresh()

    End Sub


    Private Sub cargarPresupuesto()
        Dim presupuesto As New presupuesto
        Dim detallePresupuesto As New detallePresupuesto

        'Dim readerPresupuesto As SqlClient.SqlDataReader
        Dim dsPresupuesto As New DataSet
        Dim dsDetalle As New DataSet

        dsPresupuesto = presupuesto.obtenerPresupuesto(Me.IdPesupuesto)
        dsDetalle = detallePresupuesto.obtenerDetallePresupuesto(Me.IdPesupuesto)

        'seteo fecha, numero de pedido
        lblnropedido.Text = calcularNropedido()
        nroserie = calcularnroserie()
        lblfecharealizacion.Text = Format(Now, "dd/MM/yyyy")

        'Jose code
        Dim i As Integer
        Dim j As Integer
        'Cargo los tipos de fresas
        For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
            For j = 0 To dsDetalle.Tables("detallepresupuesto").Rows.Count - 1
                If ds.Tables("tipofresa").Rows(i).Item("idtipo") = dsDetalle.Tables("detallepresupuesto").Rows(j).Item("idproducto") And ds.Tables("tipofresa").Rows(i).Item("idmodelo") = dsDetalle.Tables("detallepresupuesto").Rows(j).Item("idmodelo") And dsDetalle.Tables("detallepresupuesto").Rows(j).Item("tipo") = Constantes.PRESUPUESTO_TIPO_FRESA Then
                    nroserie += 1
                    Dim dr As DataRow = ds.Tables("fresa").NewRow
                    dr("nroserie") = CInt(nroserie)
                    dr("idtipo") = ds.Tables("tipofresa").Rows(i).Item("idtipo")
                    dr("idmodelo") = ds.Tables("tipofresa").Rows(i).Item("idmodelo")
                    dr("nropedido") = lblnropedido.Text
                    dr("estado") = Estado.PEDIDO_PENDIENTE
                    dr("nombre") = ds.Tables("tipofresa").Rows(i).Item("nombre")
                    ds.Tables("fresa").Rows.Add(dr)
                    dr("precio") = CDec(ds.Tables("tipofresa").Rows(i).Item("precio"))
                    ds.Tables("tipofresa").Rows(i).Item("seleccionarTF") = False
                End If
            Next
        Next

        For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
            For j = 0 To dsDetalle.Tables("detallepresupuesto").Rows.Count - 1
                If ds.Tables("tipofresa").Rows(i).Item("idtipo") = dsDetalle.Tables("detallepresupuesto").Rows(j).Item("idproducto") And ds.Tables("tipofresa").Rows(i).Item("idmodelo") = dsDetalle.Tables("detallepresupuesto").Rows(j).Item("idmodelo") And dsDetalle.Tables("detallepresupuesto").Rows(j).Item("tipo") = Constantes.PRESUPUESTO_PARTE_ADICIONAL Then
                    idpartepedida += 1
                    Dim dr As DataRow = ds.Tables("partepedida").NewRow
                    dr("idpartepedida") = CInt(idpartepedida)
                    dr("idmodelo") = ds.Tables("parteadicional").Rows(i).Item("idmodelo")
                    dr("idadicional") = ds.Tables("parteadicional").Rows(i).Item("idadicional")
                    dr("idpedido") = CLng(lblnropedido.Text)
                    dr("nombre") = ds.Tables("parteadicional").Rows(i).Item("nombre")
                    dr("precio") = ds.Tables("parteadicional").Rows(i).Item("precio")
                    ds.Tables("partepedida").Rows.Add(dr)
                    ds.Tables("parteadicional").Rows(i).Item("seleccionarpa") = False
                End If
            Next
        Next

        'calculo totales y subtotales
        Dim subtotal As Decimal = 0
        For i = 0 To ds.Tables("fresa").Rows.Count - 1
            subtotal += ds.Tables("fresa").Rows(i).Item("precio")
        Next
        For i = 0 To ds.Tables("partepedida").Rows.Count - 1
            subtotal += CDec(ds.Tables("partepedida").Rows(i).Item("precio"))
        Next

        txtsubtot.Text = "0"
        txtsubtotal.Text = CStr(subtotal)
        If txtsubtotal.Text <> "" And txtsubtot.Text <> "" Then
            txtimportetotal.Text = CStr(CDec(txtsubtotal.Text) + CDec(txtsubtot.Text))
        End If

        'seteo combo cliente
        Dim idCliente As Integer = dsPresupuesto.Tables("presupuesto").Rows(0).Item("idcliente")
        Dim item As Infragistics.Win.ValueListItem
        For Each item In combocliente.Items
            If item.Tag = idCliente Then
                combocliente.SelectedItem = item
            End If
        Next

        'habitilo y dehabitilo controles
        btngrabar.Enabled = True
        Me.fechaentrega.ReadOnly = False
        Me.comboestado.ReadOnly = False
        Me.comboformaentrega.ReadOnly = False

    End Sub


#End Region

End Class
