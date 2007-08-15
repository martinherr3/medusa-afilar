Imports Afilar.grdstyle
Public Class frmpedidocliente
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim tipofresa As New tipoFresa
    Dim parteAdicional As New parteAdicional
    Dim modelo As New modeloFresa
    Dim fresa As New fresa
    Dim nroserie As Integer
    Dim idobj As Integer
    Dim pedido As New pedidocliente
    Dim partepedida As New partepedida
    Dim bandeabm As Boolean
    Dim idpartepedida As Object
    'Dim pedidos As New DataTable
    Dim dvpedidos As New DataView
    Dim dvclientes As New DataView
    Dim idcliente As Object
    Dim serv As New servicio
    Dim fresasfab As New DataTable
    Dim DOS As New detalleordenservicio
    Dim obj As New objdelservicio
    Dim bnuevo As Boolean
    Dim bpedido As Boolean




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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpedidocliente))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.txtimportetotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnmodificar = New Infragistics.Win.Misc.UltraButton
        Me.btngrabar = New Infragistics.Win.Misc.UltraButton
        Me.btnnuevo = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
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
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(868, 537)
        '
        'txtimportetotal
        '
        Me.txtimportetotal.AutoSize = True
        Me.txtimportetotal.Location = New System.Drawing.Point(672, 484)
        Me.txtimportetotal.Name = "txtimportetotal"
        Me.txtimportetotal.ReadOnly = True
        Me.txtimportetotal.Size = New System.Drawing.Size(64, 21)
        Me.txtimportetotal.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(594, 489)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Importe total: $"
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(272, 479)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(88, 24)
        Me.btnmodificar.TabIndex = 4
        Me.btnmodificar.Text = "Modificar"
        '
        'btngrabar
        '
        Me.btngrabar.Location = New System.Drawing.Point(160, 479)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(88, 24)
        Me.btngrabar.TabIndex = 3
        Me.btngrabar.Text = "Grabar"
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(48, 479)
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
        Me.UltraGroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(784, 96)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Datos del cliente"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'combocliente
        '
        Me.combocliente.AutoSize = True
        Me.combocliente.Location = New System.Drawing.Point(48, 64)
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
        Me.fechaentrega.Size = New System.Drawing.Size(176, 21)
        Me.fechaentrega.TabIndex = 17
        Me.fechaentrega.Value = CType(resources.GetObject("fechaentrega.Value"), Object)
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
        Me.UltraOptionSet1.Location = New System.Drawing.Point(672, 23)
        Me.UltraOptionSet1.Name = "UltraOptionSet1"
        Me.UltraOptionSet1.Size = New System.Drawing.Size(88, 32)
        Me.UltraOptionSet1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(10, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(410, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(376, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Forma Entrega"
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Location = New System.Drawing.Point(376, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(120, 16)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Fecha Entrega"
        '
        'lblfecharealizacion
        '
        Me.lblfecharealizacion.BackColor = System.Drawing.Color.Transparent
        Me.lblfecharealizacion.Location = New System.Drawing.Point(104, 45)
        Me.lblfecharealizacion.Name = "lblfecharealizacion"
        Me.lblfecharealizacion.Size = New System.Drawing.Size(64, 16)
        Me.lblfecharealizacion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha realizacion"
        '
        'lblnropedido
        '
        Me.lblnropedido.BackColor = System.Drawing.Color.Transparent
        Me.lblnropedido.Location = New System.Drawing.Point(68, 21)
        Me.lblnropedido.Name = "lblnropedido"
        Me.lblnropedido.Size = New System.Drawing.Size(40, 16)
        Me.lblnropedido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 21)
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
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 112)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(784, 360)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Productos a Fabricar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtsubtotal
        '
        Me.txtsubtotal.AutoSize = True
        Me.txtsubtotal.Location = New System.Drawing.Point(656, 335)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(64, 22)
        Me.txtsubtotal.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(593, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Subtotal:  $"
        '
        'btnquiter
        '
        Me.btnquiter.Location = New System.Drawing.Point(152, 170)
        Me.btnquiter.Name = "btnquiter"
        Me.btnquiter.Size = New System.Drawing.Size(80, 24)
        Me.btnquiter.TabIndex = 4
        Me.btnquiter.Text = "Quitar Item"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(54, 170)
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
        Me.DataGridpp.Location = New System.Drawing.Point(440, 198)
        Me.DataGridpp.Name = "DataGridpp"
        Me.DataGridpp.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridpp.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridpp.ReadOnly = True
        Me.DataGridpp.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridpp.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridpp.Size = New System.Drawing.Size(328, 136)
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
        Me.DataGridF.Location = New System.Drawing.Point(24, 198)
        Me.DataGridF.Name = "DataGridF"
        Me.DataGridF.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridF.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridF.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridF.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridF.Size = New System.Drawing.Size(376, 136)
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
        Me.UltraGroupBox3.Location = New System.Drawing.Point(16, 112)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(784, 360)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.Text = "Servicios a Realizar"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'botquitar
        '
        Me.botquitar.Location = New System.Drawing.Point(136, 173)
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
        Me.UltraGroupBox4.Location = New System.Drawing.Point(544, 48)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(224, 80)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 10
        '
        'txtcantidad
        '
        Me.txtcantidad.AutoSize = True
        Me.txtcantidad.Location = New System.Drawing.Point(72, 46)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(56, 21)
        Me.txtcantidad.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(18, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cantidad"
        '
        'txtitem
        '
        Me.txtitem.AutoSize = True
        Me.txtitem.Location = New System.Drawing.Point(72, 14)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(144, 21)
        Me.txtitem.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(40, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Item"
        '
        'txtsubtot
        '
        Me.txtsubtot.AutoSize = True
        Me.txtsubtot.Location = New System.Drawing.Point(655, 328)
        Me.txtsubtot.Name = "txtsubtot"
        Me.txtsubtot.ReadOnly = True
        Me.txtsubtot.Size = New System.Drawing.Size(65, 21)
        Me.txtsubtot.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(596, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Subtotal: $"
        '
        'botagregar
        '
        Me.botagregar.Location = New System.Drawing.Point(32, 172)
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
        Me.DataGriddos.Location = New System.Drawing.Point(22, 200)
        Me.DataGriddos.Name = "DataGriddos"
        Me.DataGriddos.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGriddos.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGriddos.ReadOnly = True
        Me.DataGriddos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGriddos.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGriddos.Size = New System.Drawing.Size(514, 152)
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
        Me.DataGridservicios.Location = New System.Drawing.Point(304, 24)
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
        Me.DataGridfresasfab.Location = New System.Drawing.Point(16, 24)
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
        Me.UltraTabPageControl2.Controls.Add(Me.dgpedidos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(868, 537)
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
        Me.dgpedidos.Location = New System.Drawing.Point(88, 32)
        Me.dgpedidos.Name = "dgpedidos"
        Me.dgpedidos.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgpedidos.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgpedidos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgpedidos.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgpedidos.Size = New System.Drawing.Size(632, 224)
        Me.dgpedidos.TabIndex = 0
        '
        'UltraTabControl1
        '
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance6.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance7
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance8.BackColor = System.Drawing.Color.Silver
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance8
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(872, 560)
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
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(868, 537)
        '
        'frmpedidocliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(810, 536)
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
        CType(Me.dgpedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmpedidocliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' seteo el estilo del datagrid 
        modelo.setearGrilla(DataGridMF)
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
        comboestado.Text = comboestado.Items(7).DisplayText
        comboformaentrega.Text = comboformaentrega.Items(0).DisplayText
        'Dim da As New SqlClient.SqlDataAdapter("select idestado,nombre from estado", cnn)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'cmbestado.DataSource = dt
        'cmbestado.DisplayMember = "nombre"
        'cmbestado.ValueMember = "idestado"
        'da = New SqlClient.SqlDataAdapter("select nombre,idformadeentrega from formadeentrega", cnn)
        'dt = New DataTable
        'da.Fill(dt)
        'cmbformaentrega.DataSource = dt
        'cmbformaentrega.DisplayMember = "nombre"
        'cmbformaentrega.ValueMember = "idformadeentrega"

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
        'Me.DataGridpp.ReadOnly = True
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


        '------------------------------------------------------------------------------------------------------
        'PARTE NUEVA
        '------------------------------------------------------------------------------------------------------





        nroserie = calcularnroserie()
        idpartepedida = 0
        idobj = 0
        'damodelofresa = New SqlDataAdapter("select * from modelofresa", cnn)
        'damodelofresa.Fill(ds, "modelofresa")
        'Dim modelofresadc0 As New DataColumn("select")
        'modelofresadc0.DefaultValue = "N"
        'ds.Tables("modelofresa").Columns.Add(modelofresadc0)

        'daDOS = New SqlDataAdapter("select * from detalleordenservicio", cnn)
        'daDOS.FillSchema(ds, SchemaType.Source, "DOS")
        'dtDOS = ds.Tables("DOS")
        'Dim DOSdc0 As New DataColumn("Item")
        'DOSdc0.DefaultValue = String.Empty
        'dtDOS.Columns.Add(DOSdc0)
        'Dim DOSdc1 As New DataColumn("operacion")
        'dtDOS.Columns.Add(DOSdc1)
        'Dim DOSdc2 As New DataColumn("cantidad")
        'dtDOS.Columns.Add(DOSdc2)
        'Dim DOSdc3 As New DataColumn("nroserie")
        'dtDOS.Columns.Add(DOSdc3)

        'daOBJ = New SqlDataAdapter("select * from objetodelservicio", cnn)
        'daOBJ.FillSchema(ds, SchemaType.Source, "OBJ")

        'daparteadicional = New SqlDataAdapter("Select * from parteadicional", cnn)
        'daparteadicional.Fill(ds, "parteadicional")
        'Dim parteadicionaldc0 As New DataColumn("select")
        'parteadicionaldc0.DefaultValue = "N"
        'ds.Tables("parteadicional").Columns.Add(parteadicionaldc0)
        'Dim parteadicionaldc1 As New DataColumn("CantSolicitada")
        ''parteadicionaldc1.DefaultValue = String.Empty
        'parteadicionaldc1.DefaultValue = 0
        'ds.Tables("parteadicional").Columns.Add(parteadicionaldc1)
        'Dim parteadicionaldc2 As New DataColumn("precioventa")
        'parteadicionaldc2.DefaultValue = 0
        'ds.Tables("parteadicional").Columns.Add(parteadicionaldc2)

        'RadioButton1.Checked = True
        'datipofresa = New SqlDataAdapter("select * from tipofresa", cnn)
        'datipofresa.Fill(ds, "tipofresa")
        'Dim tipofresadc0 As New DataColumn("select")
        'tipofresadc0.DefaultValue = "N"
        'ds.Tables("tipofresa").Columns.Add(tipofresadc0)
        'Dim tipofresadc1 As New DataColumn("Cantsolicitada")
        'tipofresadc1.DefaultValue = 0
        'ds.Tables("tipofresa").Columns.Add(tipofresadc1)
        'Dim tipofresadc2 As New DataColumn("precioventa")
        'tipofresadc2.DefaultValue = 0
        'ds.Tables("tipofresa").Columns.Add(tipofresadc2)

        ''dvtipofresa = ds.Tables("tipofresa").DefaultView
        ''dvparteadicional = ds.Tables("parteadicional").DefaultView

        'dafresa = New SqlDataAdapter("select * from fresa", cnn)
        'dafresa.FillSchema(ds, SchemaType.Source, "fresa")
        'dtfresa = ds.Tables("fresa")
        'Dim fresadc0 As New DataColumn("nombre")
        'dtfresa.Columns.Add(fresadc0)
        'Dim fresadc1 As New DataColumn("Select")
        'fresadc1.DefaultValue = "N"
        'dtfresa.Columns.Add(fresadc1)

        'dapartepedida = New SqlDataAdapter("select * from partepedido", cnn)
        'dapartepedida.FillSchema(ds, SchemaType.Source, "partepedida")
        'dtpartepedida = ds.Tables("partepedida")
        'Dim partepedidadc0 As New DataColumn("nombre")
        'dtpartepedida.Columns.Add(partepedidadc0)
        'Dim partepedidadc1 As New DataColumn("select")
        'partepedidadc1.DefaultValue = "N"
        'dtpartepedida.Columns.Add(partepedidadc1)
        ''Dim partepedidadc1 As New DataColumn("precioventa")
        ''dtpartepedida.Columns.Add(partepedidadc1)
        'dapedido = New SqlDataAdapter("select * from pedido", cnn)
        'dapedido.FillSchema(ds, SchemaType.Source, "pedido")
        'dtpedido = ds.Tables("pedido")

        'ds.Relations.Add("modelofresa_tipofresa", ds.Tables("modelofresa").Columns("idmodelo"), ds.Tables("tipofresa").Columns("idmodelo"))
        'ds.Relations.Add("modelofresa_parteadicional", ds.Tables("modelofresa").Columns("idmodelo"), ds.Tables("parteadicional").Columns("idmodelo"))

        'daestado = New SqlDataAdapter("select idestado,nombre from estado", cnn)
        'daestado.Fill(ds, "estado")
        'cmbestado.DataSource = ds.Tables("estado")
        'cmbestado.DisplayMember = "nombre"
        'cmbestado.ValueMember = "idestado"
        'cmbestado.Enabled = False

        'daformadeentrega = New SqlDataAdapter("select idformadeentrega,nombre from formadeentrega", cnn)
        'daformadeentrega.Fill(ds, "FDE")
        'cmbformadeentrega.DataSource = ds.Tables("FDE")
        'cmbformadeentrega.DisplayMember = "nombre"
        'cmbformadeentrega.ValueMember = "idformadeentrega"
        'cmbformadeentrega.Enabled = False
        'dtpfechaentrega.Enabled = False

        'daoperacion = New SqlDataAdapter("select * from operacion", cnn)
        'daoperacion.Fill(ds, "operacion")
        'Dim operaciondc0 As New DataColumn("select")
        'operaciondc0.DefaultValue = "N"
        'ds.Tables("operacion").Columns.Add(operaciondc0)
        'Dim operaciondc1 As New DataColumn("precio")
        'operaciondc1.DefaultValue = String.Empty
        'ds.Tables("operacion").Columns.Add(operaciondc1)
        'dtoperacion = ds.Tables("operacion")
        ''dgservicio.DataSource = ds
        ''dgservicio.DataMember = "operacion"


        'UltraGroupBox4.Visible = False
        'UltraGroupBox5.Visible = False

        'Dim DOSts As DataGridTableStyle = CGrid.GetTableStyle(dtDOS)
        ''Dim DOScs0 As New CGridCheckBoxStyle("select", 30, _
        ''                                 HorizontalAlignment.Center, False, _
        ''                                  "", "", "N", "Y", False, "")
        ''CGrid.AddColumn(modelofresats, modelofresacs0)
        'Dim DOScs1 As New CGridTextBoxStyle("item", 120, HorizontalAlignment.Left, True, _
        '"ITEM", String.Empty, "")
        'CGrid.AddColumn(DOSts, DOScs1)
        'Dim DOScs2 As New CGridTextBoxStyle("operacion", 120, HorizontalAlignment.Left, True, "Servicio", String.Empty, "")
        'CGrid.AddColumn(DOSts, DOScs2)
        'Dim DOScs3 As New CGridTextBoxStyle("precio", 50, HorizontalAlignment.Center, True, _
        '"Precio", String.Empty, "")
        'CGrid.AddColumn(DOSts, DOScs3)
        'Dim DOScs4 As New CGridTextBoxStyle("cantidad", 55, HorizontalAlignment.Center, True, _
        '"Cantidad", String.Empty, "")
        'CGrid.AddColumn(DOSts, DOScs4)
        'Dim DOScs5 As New CGridTextBoxStyle("nroserie", 55, HorizontalAlignment.Center, True, _
        '"NroSerie", String.Empty, "")
        'CGrid.AddColumn(DOSts, DOScs5)
        'CGrid.SetGridStyle(Me.dgDETOS, dtDOS, DOSts)
        ''dgmodelofresa.DataSource = ds
        ''dgmodelofresa.DataMember = "modelofresa"

        ''establecer la grilla asociada a operaciones
        'Dim operacionts As DataGridTableStyle = CGrid.GetTableStyle(dtoperacion)
        'Dim operacioncs0 As New CGridCheckBoxStyle("select", 30, _
        '                                 HorizontalAlignment.Center, False, _
        '                                  "", "", "N", "Y", False, "")
        'CGrid.AddColumn(operacionts, operacioncs0)
        'Dim operacioncs1 As New CGridTextBoxStyle("nombre", 133, HorizontalAlignment.Left, True, _
        '"Servcios", String.Empty, "")
        'CGrid.AddColumn(operacionts, operacioncs1)
        'Dim operacioncs2 As New CGridTextBoxStyle("precio", 50, HorizontalAlignment.Left, False, _
        '"Precio", String.Empty, "")
        'CGrid.AddColumn(operacionts, operacioncs2)
        'CGrid.SetGridStyle(Me.dgservicio, dtoperacion, operacionts)


        ''Establecer los datos asociados a la grilla "MODELO FRESA"
        'Dim modelofresats As DataGridTableStyle = CGrid.GetTableStyle(ds.Tables("modelofresa"))
        'Dim modelofresacs0 As New CGridCheckBoxStyle("select", 30, _
        '                                 HorizontalAlignment.Center, False, _
        '                                  "", "", "N", "Y", False, "")
        'CGrid.AddColumn(modelofresats, modelofresacs0)
        'Dim modelofresacs1 As New CGridTextBoxStyle("nombre", 100, HorizontalAlignment.Left, True, _
        '"Modelo", String.Empty, "")
        'CGrid.AddColumn(modelofresats, modelofresacs1)
        'Dim modelofresacs2 As New CGridTextBoxStyle("grupomodelo", 90, HorizontalAlignment.Center, True, "Grupo Modelo", String.Empty, "")
        'CGrid.AddColumn(modelofresats, modelofresacs2)
        'Dim modelofresacs3 As New CGridTextBoxStyle("materialatrabajar", 90, HorizontalAlignment.Center, True, "Grupo Modelo", String.Empty, "")
        'CGrid.AddColumn(modelofresats, modelofresacs3)
        'Dim modelofresacs4 As New CGridTextBoxStyle("mododeavance", 85, HorizontalAlignment.Center, True, "Modo Avanvce", String.Empty, "")
        'CGrid.AddColumn(modelofresats, modelofresacs4)
        'Dim modelofresacs5 As New CGridTextBoxStyle("tipoacabado", 90, HorizontalAlignment.Center, True, "Tipoacabado", String.Empty, "")
        'CGrid.AddColumn(modelofresats, modelofresacs5)
        'Dim modelofresacs6 As New CGridTextBoxStyle("velocidaddeavance", 70, HorizontalAlignment.Center, True, "Vel. Avance", String.Empty, "")
        'CGrid.AddColumn(modelofresats, modelofresacs6)
        'Dim modelofresacs10 As New CGridTextBoxStyle("precio", 60, HorizontalAlignment.Center, True, "Precio", String.Empty, "")
        'CGrid.AddColumn(modelofresats, modelofresacs10)
        'CGrid.SetGridStyle(Me.dgmodelofresa, ds.Tables("modelofresa"), modelofresats)
        'dgmodelofresa.DataSource = ds
        'dgmodelofresa.DataMember = "modelofresa"

        ''Establecer los datos asociados a la grilla "PARTE ADICIONAL"
        ''Dim parteadicionalts As DataGridTableStyle = CGrid.GetTableStyle(dvparteadicional)
        'Dim parteadicionalts As DataGridTableStyle = CGrid.GetTableStyle(ds.Tables("parteadicional"))
        'Dim parteadicionalcs0 As New CGridCheckBoxStyle("select", 30, _
        '                                  HorizontalAlignment.Center, False, _
        '                                  "", "", "N", "Y", False, "")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs0)
        'Dim parteadicionalcs1 As New CGridTextBoxStyle("nombre", 100, HorizontalAlignment.Left, True, _
        '"Modelo", String.Empty, "")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs1)
        'Dim parteadicionalcs4 As New CGridTextBoxStyle("cantidad Real", 40, HorizontalAlignment.Center, False, "Cant.", String.Empty, "")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs4)
        'Dim parteadicionalcs5 As New CGridNumericUpDownStyle("cantsolicitada", 50, "Cantidad", 0, 1000, 0, 1, LeftRightAlignment.Left, 0, "0")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs5)
        'Dim parteadicionalcs6 As New CGridNumericUpDownStyle("precioventa", 67, "Descuento", 0, 1000, 3, 1, LeftRightAlignment.Left, 0, "0")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs6)
        ''Dim parteadicionalcs6 As New CGridTextBoxStyle("precioventa", 60, HorizontalAlignment.Center, False, "Descuento (%)", String.Empty, "")
        ''CGrid.AddColumn(parteadicionalts, parteadicionalcs6)
        'Dim parteadicionalcs2 As New CGridTextBoxStyle("precio", 60, HorizontalAlignment.Center, True, "Precio", String.Empty, "")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs2)
        ''Dim parteadicionalcs5 As New CGridTextBoxStyle("cantidad", 60, HorizontalAlignment.Center, True, "Cant.Real", String.Empty, "")
        ''CGrid.AddColumn(parteadicionalts, parteadicionalcs5)
        ''Dim parteadicionalcs3 As New CGridTextBoxStyle("descripcion", 60, HorizontalAlignment.Center, True, "Descripción", String.Empty, "")
        ''CGrid.AddColumn(parteadicionalts, parteadicionalcs3)
        'CGrid.SetGridStyle(Me.dgparteadicional, ds.Tables("parteadicional"), parteadicionalts)
        'dgparteadicional.DataSource = ds
        'dgparteadicional.DataMember = "modelofresa.modelofresa_parteadicional"


        ''Establecer los datos asociados a la grilla "Tipo FRESA"
        ''Dim tipofresats As DataGridTableStyle = CGrid.GetTableStyle(dvtipofresa)
        'Dim tipofresats As DataGridTableStyle = CGrid.GetTableStyle(ds.Tables("tipofresa"))
        'Dim tipofresacs0 As New CGridCheckBoxStyle("select", 30, _
        '                                  HorizontalAlignment.Center, False, _
        '                                  "", "", "N", "Y", False, "")
        'CGrid.AddColumn(tipofresats, tipofresacs0)
        'Dim tipofresacs1 As New CGridTextBoxStyle("nombre", 80, HorizontalAlignment.Left, True, _
        '"Modelo", String.Empty, "")
        'CGrid.AddColumn(tipofresats, tipofresacs1)
        'Dim tipofresacs5 As New CGridNumericUpDownStyle("cantsolicitada", 50, "Cantidad", 0, 1000, 0, 1, LeftRightAlignment.Left, 0, "0")
        'CGrid.AddColumn(tipofresats, tipofresacs5)
        'Dim tipofresacs4 As New CGridNumericUpDownStyle("precioventa", 50, "Descuento", 0, 1000, 3, 1, LeftRightAlignment.Left, 0, "0")
        'CGrid.AddColumn(tipofresats, tipofresacs4)
        'Dim tipofresacs2 As New CGridTextBoxStyle("precio", 60, HorizontalAlignment.Center, True, "Precio", String.Empty, "")
        'CGrid.AddColumn(tipofresats, tipofresacs2)
        'CGrid.SetGridStyle(Me.dgtipofresa, ds.Tables("tipofresa"), tipofresats)
        'dgtipofresa.DataSource = ds
        'dgtipofresa.DataMember = "modelofresa.modelofresa_tipofresa"

        ''Establecer los datos asociados a la grilla "FRESA"
        'Dim fresats As DataGridTableStyle = CGrid.GetTableStyle(dtfresa)
        'Dim fresacs3 As New CGridCheckBoxStyle("select", 30, _
        '                                          HorizontalAlignment.Center, False, _
        '                                          "", "", "N", "Y", False, "")
        'CGrid.AddColumn(fresats, fresacs3)
        'Dim fresacs0 As New CGridTextBoxStyle("nroserie", 60, HorizontalAlignment.Center, False, "Nro.Serie", String.Empty, "")
        'CGrid.AddColumn(fresats, fresacs0)
        'Dim fresacs1 As New CGridTextBoxStyle("nombre", 110, HorizontalAlignment.Left, True, _
        '"Tipo Fresa", String.Empty, "")
        'CGrid.AddColumn(fresats, fresacs1)
        'Dim fresacs2 As New CGridTextBoxStyle("precio", 47, HorizontalAlignment.Center, True, _
        '        "Precio", String.Empty, "")
        'CGrid.AddColumn(fresats, fresacs2)
        'CGrid.SetGridStyle(Me.dgfresa, dtfresa, fresats)


        'Dim partepedidats As DataGridTableStyle = CGrid.GetTableStyle(dtpartepedida)
        'Dim partepedidacs3 As New CGridCheckBoxStyle("select", 30, _
        '                                                  HorizontalAlignment.Center, False, _
        '                                                  "", "", "N", "Y", False, "")
        'CGrid.AddColumn(partepedidats, partepedidacs3)
        'Dim partepedidacs0 As New CGridTextBoxStyle("nombre", 110, HorizontalAlignment.Left, False, "Parte", String.Empty, "")
        'CGrid.AddColumn(partepedidats, partepedidacs0)
        'Dim partepedidacs1 As New CGridTextBoxStyle("cantidad", 60, HorizontalAlignment.Center, True, _
        '"Cantidad", String.Empty, "")
        'CGrid.AddColumn(partepedidats, partepedidacs1)
        'Dim partepedidacs2 As New CGridTextBoxStyle("precio", 47, HorizontalAlignment.Center, True, _
        '"Precio", String.Empty, "")
        'CGrid.AddColumn(partepedidats, partepedidacs2)
        'CGrid.SetGridStyle(Me.dgpartepedida, dtpartepedida, partepedidats)
        'princ.barra.agregarBoton(Me)
        nroserie = 0
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
    Private Sub UltraTabPageControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles UltraTabPageControl1.Paint

    End Sub

    Private Sub DataGridMF_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

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


                    'Dim element As DataRow

                    'For Each element In ds.Tables("modelofresa").Rows.Item(i).GetChildRows("Fresas individuales")
                    '    element.Item("seleccionarTF") = True
                    'Next


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

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
       
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click

        Dim i As Integer
        Dim j As Integer
        For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
            If ds.Tables("tipofresa").Rows(i).Item("seleccionarTF") = True Then

                'If Not (ds.Tables("tipofresa").Rows(i).Item("cantsolicitada") = 0) Then

                'For j = 1 To ds.Tables("tipofresa").Rows(i).Item("cantsolicitada")
                nroserie += 1
                Dim dr As DataRow = ds.Tables("fresa").NewRow
                dr("nroserie") = CInt(nroserie)
                dr("idtipo") = ds.Tables("tipofresa").Rows(i).Item("idtipo")
                'For j = 0 To ds.Tables("modelofresa").Rows.Count - 1
                'If ds.Tables("modelofresa").Rows(j)("seleccionarMF") = True Then
                'dr("idmodelo") = ds.Tables("modelofresa").Rows(DataGridMf.CurrentCell.RowNumber).Item("idmodelo")
                dr("idmodelo") = ds.Tables("tipofresa").Rows(i).Item("idmodelo")

                'End If
                'Next
                'dr("idmodelo") = ds.Tables("modelofresa").Rows(DataGridMf.CurrentCell.RowNumber).Item("idmodelo")
                dr("nropedido") = CLng(lblnropedido.Text)
                dr("estado") = comboestado.SelectedItem.Tag()
                dr("nombre") = ds.Tables("tipofresa").Rows(i).Item("nombre")
                ds.Tables("fresa").Rows.Add(dr)
                'If ds.Tables("tipofresa").Rows(i).Item("precioventa") = 0 Then
                dr("precio") = CDec(ds.Tables("tipofresa").Rows(i).Item("precio"))
                'Else
                'modifique el precio
                '    dr("precio") = CDec(CDec(ds.Tables("tipofresa").Rows(i).Item("precio")) * CDec(ds.Tables("tipofresa").Rows(i).Item("precioventa")) / 100)
                'End If
                'Next
                'ds.Tables("tipofresa").Rows(i).Item("cantsolicitada") = 0
                'ds.Tables("tipofresa").Rows(i).Item("precioventa") = 0
                'End If
                ds.Tables("tipofresa").Rows(i).Item("seleccionarTF") = False
            End If
        Next

        For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
            If ds.Tables("parteadicional").Rows(i).Item("seleccionarpa") = True Then
                idpartepedida += 1
                Dim dr As DataRow = ds.Tables("partepedida").NewRow
                dr("idpartepedida") = CInt(idpartepedida)

                'For j = 0 To ds.Tables("modelofresa").Rows.Count - 1
                'If ds.Tables("modelofresa").Rows(j)("seleccionarMF") = True Then
                'dr("idmodelo") = ds.Tables("modelofresa").Rows(DataGridMf.CurrentCell.RowNumber).Item("idmodelo")
                dr("idmodelo") = ds.Tables("parteadicional").Rows(i).Item("idmodelo")
                'End If
            'Next
            dr("idadicional") = ds.Tables("parteadicional").Rows(i).Item("idadicional")
            dr("idpedido") = CLng(lblnropedido.Text)
            dr("nombre") = ds.Tables("parteadicional").Rows(i).Item("nombre")
            'If ds.Tables("parteadicional").Rows(i).Item("cantsolicitada") = 0 Then
                'dr("cantidad") = CInt(ds.Tables("parteadicional").Rows(i).Item("cantidad"))
                'ds.Tables("parteadicional").Rows(i).Item("cantidad") = cantidades(i)
                'Else
            '            dr("cantidad") = CInt(ds.Tables("parteadicional").Rows(i).Item("cantsolicitada"))
            '            ds.Tables("parteadicional").Rows(i).Item("cantsolicitada") = 0
            '        End If
            '        If ds.Tables("parteadicional").Rows(i).Item("precioventa") = 0 Then
            dr("precio") = ds.Tables("parteadicional").Rows(i).Item("precio")
            '        Else
            '            dr("precio") = CDec(CDec(ds.Tables("parteadicional").Rows(i).Item("precioventa") * ds.Tables("parteadicional").Rows(i).Item("precio")) / 100)
            '        End If
            '        ds.Tables("parteadicional").Rows(i).Item("precioventa") = 0
            ds.Tables("partepedida").Rows.Add(dr)
            ds.Tables("parteadicional").Rows(i).Item("seleccionarpa") = False
            End If
        Next
        Dim subtotal As Decimal = 0
        For i = 0 To ds.Tables("fresa").Rows.Count - 1
            subtotal += ds.Tables("fresa").Rows(i).Item("precio")
        Next
        For i = 0 To ds.Tables("partepedida").Rows.Count - 1
            subtotal += CDec(ds.Tables("partepedida").Rows(i).Item("precio"))
        Next
        txtsubtotal.Text = CStr(subtotal)
        'Dim total As Decimal = 0
        'If Not (txtimportetotal.Text = String.Empty) Then
        'total = CDec(txtimportetotal.Text)
        'Else
        '    total = 0
        'End If
        txtimportetotal.Text = CStr(CDec(txtsubtotal.Text) + CDec(txtsubtot.Text))
        'MsgBox(total)
        'total += subtotal
        'txtimportetotal.Text = total
        For i = 0 To ds.Tables("modelofresa").Rows.Count - 1
            If ds.Tables("modelofresa").Rows(i)("seleccionarMF") = True Then

            End If
        Next
    End Sub

    Private Sub UltraGroupBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGroupBox2.Click

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
        'Me.comboestado.ReadOnly = False
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

    Private Sub UltraGroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGroupBox1.Click

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
        'If txtprioridad.Text = "" Then
        'MsgBox("ingrese prioridad")
        'txtprioridad.Focus()
        'Exit Sub
        'End If

        'If dtfresa.Rows.Count < 1 And dtpartepedida.Rows.Count < 1 Then
        'MsgBox("falta Detalle Pedido")
        'Exit Sub
        'Else
        '   For i = 0 To dtfresa.Rows.Count - 1
        '  If Not (dtfresa.Rows(i).RowState = DataRowState.Deleted) Then
        ' b1 = True
        'End If
        '   Next

        'End If
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

    Private Sub UltraTabControl1_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles UltraTabControl1.ChangeUICues

    End Sub

    Private Sub UltraTabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraTabControl1.Click
        If UltraTabControl1.SelectedTab.Index = 1 Then
            'dgpedidos.DataSource = Nothing
            Dim str As String = "select pedido.idpedido As NroPedido, pedido.fecharealizacion, pedido.fechaentrega, estado.nombre as estado," _
            & "rtrim(cliente.apellido) + ', ' + cliente.nombre as nombreCliente from cliente, pedido, estado where cliente.idcliente=pedido.idcliente and pedido.idestado=estado.idestado"
            Dim da = New SqlClient.SqlDataAdapter(str, cnn)
            'pedidos.Clear()
            'Dim pedido As New DataTable("pedido")
            ds.Tables("PR").Clear()
            da.Fill(ds, "PR")
            'dvpedidos = pedidos.DefaultView
            'dgpedidos.DataSource = dvpedidos
            dgpedidos.Refresh()
            'dgclientes.DataSource = Nothing
            'str = "select cliente.apellido as Apellido, cliente.nombre As Nombre,cliente.direccion as Direccion,localidad.nombre as Localidad,cliente.documento from cliente," _
            '& "localidad where cliente.localidad=localidad.idlocalidad"
            'Dim dacli As New SqlClient.SqlDataAdapter(str, cnn)
            'Dim clientes As New DataTable
            'dacli.Fill(clientes)
            'dvclientes = clientes.DefaultView
            'dgclientes.DataSource = dvclientes
        End If
    End Sub
    Sub setearfresas(ByVal dg As DataGrid)
        Dim ts As New DataGridTableStyle

        ts.MappingName = "FF"

        'Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarF", 20, HorizontalAlignment.Center, False, "", "", False, True, False, "")
        'ts.GridColumnStyles.Add(c0)


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

        'Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarF", 20, HorizontalAlignment.Center, False, "", "", False, True, False, "")
        'ts.GridColumnStyles.Add(c0)


        Dim c1 As New grdstyle.CGridTextBoxStyle("Nropedido", 85, HorizontalAlignment.Center, True, "NRO PEDIDO", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("fecharealizacion", 115, HorizontalAlignment.Center, True, "FECHA REALIZACION", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("fechaentrega", 115, HorizontalAlignment.Center, True, "FECHA ENTREGA", "", "")
        ts.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("estado", 110, HorizontalAlignment.Center, True, "ESTADO", "", "")
        ts.GridColumnStyles.Add(c4)

        'Dim c5 As New grdstyle.CGridTextBoxStyle("apellidocliente", 100, HorizontalAlignment.Center, True, "APELLIDO", "", "")
        'ts.GridColumnStyles.Add(c5)

        Dim c6 As New grdstyle.CGridTextBoxStyle("nombrecliente", 150, HorizontalAlignment.Center, True, "CLIENTE", "", "")
        ts.GridColumnStyles.Add(c6)

        dg.TableStyles.Add(ts)
    End Sub

    Private Sub dgpedidos_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgpedidos.Navigate

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
        comboformaentrega.Text = comboformaentrega.Items(ds.Tables("pedidocliente").Rows(0).Item("idformadeentrega") - 1).DisplayText
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
    End Sub

    Private Sub dgclientes_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub dgclientes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cnn.State = ConnectionState.Closed Then
        '    cnn.Open()
        'End If
        'Dim cmd As New SqlClient.SqlCommand
        'cmd.CommandText = "select idcliente from cliente where documento=" & dgclientes.Item(dgclientes.CurrentRowIndex, 4)
        'cmd.Connection = cnn
        'idcliente = cmd.ExecuteScalar
        'cnn.Close()
        ''txtcliente.Text = RTrim(dgclientes.Item(dgclientes.CurrentRowIndex, 0)) & ", " & RTrim(dgclientes.Item(dgclientes.CurrentRowIndex, 1))
        ''txtcliente.AutoSize = True


        'DataGridfresasfab.DataSource = Nothing
        'fresasfab.Clear()



    End Sub

    Private Sub dgclientes_DockChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub UltraOptionSet1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraOptionSet1.ValueChanged

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

    Private Sub txtcliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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


                    'Dim element As DataRow

                    'For Each element In ds.Tables("modelofresa").Rows.Item(i).GetChildRows("Fresas individuales")
                    '    element.Item("seleccionarTF") = True
                    'Next


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

    Private Sub UltraGroupBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGroupBox3.Click

    End Sub

    Private Sub botagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botagregar.Click

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
    End Sub

    Private Sub btnotro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btnbuscli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
    Private Sub chkfecharealizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkfecharealizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtfecharealizacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtfecharealizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(validarfecha(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim str As String
        'Dim b As Boolean
        'b = False
        'If chkapellido.Checked = True Then
        '    If b = False Then
        '        b = True
        '        str = "apellido='" & txtapellido.Text & "'"
        '    Else
        '        str &= " and apellido='" & txtapellido.Text & "'"

        '    End If

        'End If
        'If chknombre.Checked = True Then
        '    If b = False Then
        '        b = True
        '        str = "nombre='" & txtnombre.Text & "'"
        '    Else
        '        str &= " and nombre='" & txtnombre.Text & "'"

        '    End If
        'End If
        'If b = False Then
        '    dvclientes.RowFilter = Nothing
        'Else
        '    dvclientes.RowFilter = str
        'End If
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

    Private Sub combocliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles combocliente.Click

    End Sub

    Private Sub DataGridF_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridF.Navigate

    End Sub

    Private Sub DataGridF_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridF.MouseUp
        If sel_check_col(DataGridF, 0, e) Then

            Select Case ds.Tables("fresa").Rows(DataGridF.CurrentRowIndex).Item("seleccionarf")
                Case False
                    ds.Tables("fresa").Rows(DataGridF.CurrentRowIndex).Item("seleccionarf") = True
                    'Dim i As Integer
                    'For i = 0 To ds.Tables("fresa").Rows.Count - 1
                    'If ds.Tables("tipofresa").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("tipofresa").Rows(i).Item("select") = True
                    'End If
                    'Next i
                    'For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                    'If ds.Tables("parteadicional").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("parteadicional").Rows(i).Item("select") = "Y"
                    'End If
                    '                    Next i

                Case True
                    ds.Tables("fresa").Rows(DataGridF.CurrentRowIndex).Item("seleccionarF") = False
                    DataGridF.Refresh()

                    'Dim i As Integer

                    'For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
                    'If ds.Tables("tipofresa").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("tipofresa").Rows(i).Item("select") = "N"
                    'End If
                    '                    Next i
                    'For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                    'If ds.Tables("parteadicional").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("parteadicional").Rows(i).Item("select") = "N"
                    'End If
                    '                    Next i
            End Select
            DataGridF.Select(DataGridF.CurrentCell.RowNumber)
            DataGridF.Refresh()
        End If
    End Sub

    Private Sub DataGridpp_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridpp.Navigate

    End Sub

    Private Sub DataGridpp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridpp.MouseUp
        If sel_check_col(DataGridpp, 0, e) Then

            Select Case ds.Tables("partepedida").Rows(DataGridpp.CurrentRowIndex).Item("seleccionarpp")
                Case False
                    ds.Tables("partepedida").Rows(DataGridpp.CurrentRowIndex).Item("seleccionarpp") = True
                    'Dim i As Integer
                    'For i = 0 To ds.Tables("fresa").Rows.Count - 1
                    'If ds.Tables("tipofresa").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("tipofresa").Rows(i).Item("select") = True
                    'End If
                    'Next i
                    'For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                    'If ds.Tables("parteadicional").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("parteadicional").Rows(i).Item("select") = "Y"
                    'End If
                    '                    Next i

                Case True
                    ds.Tables("partepedida").Rows(DataGridpp.CurrentRowIndex).Item("seleccionarpp") = False
                    'DataGridpp.Refresh()

                    'Dim i As Integer

                    'For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
                    'If ds.Tables("tipofresa").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("tipofresa").Rows(i).Item("select") = "N"
                    'End If
                    '                    Next i
                    'For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                    'If ds.Tables("parteadicional").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                    'ds.Tables("parteadicional").Rows(i).Item("select") = "N"
                    'End If
                    '                    Next i
            End Select
            DataGridpp.Select(DataGridpp.CurrentCell.RowNumber)
            DataGridpp.Refresh()
        End If
    End Sub

    Private Sub UltraTabPageControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles UltraTabPageControl2.Paint

    End Sub

    Private Sub DataGridMf_Navigate_1(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridMf.Navigate

    End Sub
End Class
