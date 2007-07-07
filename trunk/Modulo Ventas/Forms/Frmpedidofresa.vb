Imports Afilar.grdstyle
Imports System.Data.SqlClient
Public Class Frmpedidofresa
    Inherits System.Windows.Forms.Form
    Dim nroserie As Object
    Dim idpartepedida As Object
    Dim ds As New DataSet
    Dim damodelofresa As SqlDataAdapter
    Dim daparteadicional As SqlDataAdapter
    Dim datipofresa As SqlDataAdapter
    Dim dvtipofresa As New DataView
    Dim dvparteadicional As New DataView
    Dim dafresa As SqlDataAdapter
    Dim dtfresa As New DataTable
    Dim dapartepedida As SqlDataAdapter
    Dim dtpartepedida As New DataTable
    Dim dapedido As SqlDataAdapter
    Dim idcliente As Object
    Dim daestado As SqlDataAdapter
    Dim dtpedido As New DataTable
    Dim bandeabm As Boolean
    Dim dafresasfab As SqlDataAdapter
    Dim dtfresasfab As DataTable
    Dim daoperacion As SqlDataAdapter
    Dim dtoperacion As DataTable
    Dim daDOS As SqlDataAdapter
    Dim daOBJ As SqlDataAdapter
    Dim dtDOS As New DataTable
    Dim dtOBJ As DataTable
    Dim idOBJ As Object
    Dim daformadeentrega As SqlDataAdapter
    Dim dvclientes As New DataView
    Dim dvpedidos As New DataView
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
    Friend WithEvents btnnuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblnropedido As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnagregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgmodelofresa As System.Windows.Forms.DataGrid
    Friend WithEvents dgtipofresa As System.Windows.Forms.DataGrid
    Friend WithEvents dgparteadicional As System.Windows.Forms.DataGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtsubtotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnquitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgpartepedida As System.Windows.Forms.DataGrid
    Friend WithEvents dgfresa As System.Windows.Forms.DataGrid
    Friend WithEvents btnguardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtimportetotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprioridad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbfecha As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbnropedido As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbestado As System.Windows.Forms.ComboBox
    Friend WithEvents dgpedidos As System.Windows.Forms.DataGrid
    Friend WithEvents btnmodificar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dgfresafab As System.Windows.Forms.DataGrid
    Friend WithEvents botnuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents botagregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtitem As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents botquitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtsubtot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dgservicio As System.Windows.Forms.DataGrid
    Friend WithEvents dgDETOS As System.Windows.Forms.DataGrid
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbformadeentrega As System.Windows.Forms.ComboBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtfecharealizacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtfechaentrega As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dgclientes As System.Windows.Forms.DataGrid
    Friend WithEvents dtpfechaentrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkapellido As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chknombre As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtapellido As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtnombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkfechaentrega As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkfecharealizacion As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnnuevo = New Infragistics.Win.Misc.UltraButton
        Me.lblnropedido = New System.Windows.Forms.Label
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.dgDETOS = New System.Windows.Forms.DataGrid
        Me.txtsubtot = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label11 = New System.Windows.Forms.Label
        Me.botquitar = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.cmbformadeentrega = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpfechaentrega = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cmbestado = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtprioridad = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbfecha = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbnropedido = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtsubtotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnquitar = New Infragistics.Win.Misc.UltraButton
        Me.dgpartepedida = New System.Windows.Forms.DataGrid
        Me.dgfresa = New System.Windows.Forms.DataGrid
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnagregar = New Infragistics.Win.Misc.UltraButton
        Me.dgmodelofresa = New System.Windows.Forms.DataGrid
        Me.dgtipofresa = New System.Windows.Forms.DataGrid
        Me.dgparteadicional = New System.Windows.Forms.DataGrid
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.dgservicio = New System.Windows.Forms.DataGrid
        Me.txtcantidad = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtdescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtitem = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label8 = New System.Windows.Forms.Label
        Me.botagregar = New Infragistics.Win.Misc.UltraButton
        Me.botnuevo = New Infragistics.Win.Misc.UltraButton
        Me.dgfresafab = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.txtnombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtapellido = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.chknombre = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkapellido = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dgclientes = New System.Windows.Forms.DataGrid
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.chkfechaentrega = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkfecharealizacion = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txtfechaentrega = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtfecharealizacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.dgpedidos = New System.Windows.Forms.DataGrid
        Me.btnguardar = New Infragistics.Win.Misc.UltraButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtimportetotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnmodificar = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.dgDETOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubtot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtprioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txtsubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpartepedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgfresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.dgmodelofresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtipofresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgparteadicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.dgservicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgfresafab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.txtnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txtfechaentrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecharealizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtimportetotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(24, 528)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(80, 24)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "Nuevo"
        '
        'lblnropedido
        '
        Me.lblnropedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnropedido.Location = New System.Drawing.Point(16, 32)
        Me.lblnropedido.Name = "lblnropedido"
        Me.lblnropedido.Size = New System.Drawing.Size(55, 16)
        Me.lblnropedido.TabIndex = 1
        Me.lblnropedido.Text = "Nº Pedido"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.Location = New System.Drawing.Point(72, 30)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(56, 21)
        Me.UltraTextEditor1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 520)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.UltraGroupBox5)
        Me.TabPage1.Controls.Add(Me.UltraGroupBox3)
        Me.TabPage1.Controls.Add(Me.UltraGroupBox2)
        Me.TabPage1.Controls.Add(Me.UltraGroupBox1)
        Me.TabPage1.Controls.Add(Me.UltraGroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(720, 494)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pedido Del Cliente"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox5.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rectangular3D
        Appearance1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox5.ContentAreaAppearance = Appearance1
        Me.UltraGroupBox5.Controls.Add(Me.dgDETOS)
        Me.UltraGroupBox5.Controls.Add(Me.txtsubtot)
        Me.UltraGroupBox5.Controls.Add(Me.Label11)
        Me.UltraGroupBox5.Controls.Add(Me.botquitar)
        Me.UltraGroupBox5.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.UltraGroupBox5.Location = New System.Drawing.Point(72, 331)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(552, 136)
        Me.UltraGroupBox5.SupportThemes = False
        Me.UltraGroupBox5.TabIndex = 26
        Me.UltraGroupBox5.Text = "Servicios Solicitados"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'dgDETOS
        '
        Me.dgDETOS.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgDETOS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgDETOS.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgDETOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDETOS.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgDETOS.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgDETOS.DataMember = ""
        Me.dgDETOS.FlatMode = True
        Me.dgDETOS.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgDETOS.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgDETOS.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgDETOS.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgDETOS.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgDETOS.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgDETOS.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgDETOS.LinkColor = System.Drawing.Color.Teal
        Me.dgDETOS.Location = New System.Drawing.Point(8, 26)
        Me.dgDETOS.Name = "dgDETOS"
        Me.dgDETOS.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgDETOS.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgDETOS.ReadOnly = True
        Me.dgDETOS.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgDETOS.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgDETOS.Size = New System.Drawing.Size(440, 102)
        Me.dgDETOS.TabIndex = 5
        '
        'txtsubtot
        '
        Me.txtsubtot.Location = New System.Drawing.Point(456, 96)
        Me.txtsubtot.Name = "txtsubtot"
        Me.txtsubtot.Size = New System.Drawing.Size(80, 21)
        Me.txtsubtot.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(456, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Subtotal :"
        '
        'botquitar
        '
        Me.botquitar.Location = New System.Drawing.Point(456, 27)
        Me.botquitar.Name = "botquitar"
        Me.botquitar.Size = New System.Drawing.Size(80, 24)
        Me.botquitar.TabIndex = 2
        Me.botquitar.Text = "Quitar Item"
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rectangular3D
        Me.UltraGroupBox3.Controls.Add(Me.cmbformadeentrega)
        Me.UltraGroupBox3.Controls.Add(Me.Label13)
        Me.UltraGroupBox3.Controls.Add(Me.dtpfechaentrega)
        Me.UltraGroupBox3.Controls.Add(Me.Label12)
        Me.UltraGroupBox3.Controls.Add(Me.GroupBox1)
        Me.UltraGroupBox3.Controls.Add(Me.cmbestado)
        Me.UltraGroupBox3.Controls.Add(Me.Label7)
        Me.UltraGroupBox3.Controls.Add(Me.txtprioridad)
        Me.UltraGroupBox3.Controls.Add(Me.Label6)
        Me.UltraGroupBox3.Controls.Add(Me.txtcliente)
        Me.UltraGroupBox3.Controls.Add(Me.Label4)
        Me.UltraGroupBox3.Controls.Add(Me.lbfecha)
        Me.UltraGroupBox3.Controls.Add(Me.Label5)
        Me.UltraGroupBox3.Controls.Add(Me.lbnropedido)
        Me.UltraGroupBox3.Controls.Add(Me.Label3)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, -2)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(712, 75)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 24
        '
        'cmbformadeentrega
        '
        Me.cmbformadeentrega.Location = New System.Drawing.Point(440, 51)
        Me.cmbformadeentrega.Name = "cmbformadeentrega"
        Me.cmbformadeentrega.Size = New System.Drawing.Size(152, 21)
        Me.cmbformadeentrega.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(352, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Forma Entrega"
        '
        'dtpfechaentrega
        '
        Me.dtpfechaentrega.Location = New System.Drawing.Point(440, 5)
        Me.dtpfechaentrega.Name = "dtpfechaentrega"
        Me.dtpfechaentrega.Size = New System.Drawing.Size(152, 20)
        Me.dtpfechaentrega.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(352, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Fecha Entrega"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(592, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 69)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(16, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(73, 13)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Servicios"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(16, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 14)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Fabricación"
        '
        'cmbestado
        '
        Me.cmbestado.Location = New System.Drawing.Point(440, 28)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(152, 21)
        Me.cmbestado.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(389, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Estado"
        '
        'txtprioridad
        '
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.txtprioridad.Appearance = Appearance2
        Me.txtprioridad.Enabled = False
        Me.txtprioridad.Location = New System.Drawing.Point(200, 32)
        Me.txtprioridad.MaxLength = 1
        Me.txtprioridad.Name = "txtprioridad"
        Me.txtprioridad.Size = New System.Drawing.Size(16, 21)
        Me.txtprioridad.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Prioridad"
        '
        'txtcliente
        '
        Me.txtcliente.Enabled = False
        Me.txtcliente.Location = New System.Drawing.Point(56, 32)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(88, 21)
        Me.txtcliente.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cliente"
        '
        'lbfecha
        '
        Me.lbfecha.AutoSize = True
        Me.lbfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbfecha.Location = New System.Drawing.Point(272, 8)
        Me.lbfecha.Name = "lbfecha"
        Me.lbfecha.Size = New System.Drawing.Size(0, 19)
        Me.lbfecha.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Fecha De Realización:"
        '
        'lbnropedido
        '
        Me.lbnropedido.AutoSize = True
        Me.lbnropedido.Location = New System.Drawing.Point(88, 8)
        Me.lbnropedido.Name = "lbnropedido"
        Me.lbnropedido.Size = New System.Drawing.Size(0, 16)
        Me.lbnropedido.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nro. Pedido"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rectangular3D
        Appearance3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance3
        Me.UltraGroupBox2.Controls.Add(Me.txtsubtotal)
        Me.UltraGroupBox2.Controls.Add(Me.Label1)
        Me.UltraGroupBox2.Controls.Add(Me.btnquitar)
        Me.UltraGroupBox2.Controls.Add(Me.dgpartepedida)
        Me.UltraGroupBox2.Controls.Add(Me.dgfresa)
        Me.UltraGroupBox2.Enabled = False
        Me.UltraGroupBox2.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 330)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(712, 136)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 13
        Me.UltraGroupBox2.Text = "Productos Seleccionados"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(608, 104)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(80, 21)
        Me.txtsubtotal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(608, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subtotal:  $"
        '
        'btnquitar
        '
        Me.btnquitar.Location = New System.Drawing.Point(608, 32)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(80, 24)
        Me.btnquitar.TabIndex = 2
        Me.btnquitar.Text = "Quitar"
        '
        'dgpartepedida
        '
        Me.dgpartepedida.CaptionText = "Partes Solicitadas"
        Me.dgpartepedida.DataMember = ""
        Me.dgpartepedida.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgpartepedida.Location = New System.Drawing.Point(312, 26)
        Me.dgpartepedida.Name = "dgpartepedida"
        Me.dgpartepedida.ReadOnly = True
        Me.dgpartepedida.Size = New System.Drawing.Size(288, 104)
        Me.dgpartepedida.TabIndex = 1
        '
        'dgfresa
        '
        Me.dgfresa.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgfresa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgfresa.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgfresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgfresa.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgfresa.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgfresa.CaptionText = "Fresas Solicitadas"
        Me.dgfresa.DataMember = ""
        Me.dgfresa.FlatMode = True
        Me.dgfresa.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgfresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgfresa.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgfresa.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgfresa.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgfresa.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgfresa.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgfresa.LinkColor = System.Drawing.Color.Teal
        Me.dgfresa.Location = New System.Drawing.Point(16, 26)
        Me.dgfresa.Name = "dgfresa"
        Me.dgfresa.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgfresa.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgfresa.ReadOnly = True
        Me.dgfresa.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgfresa.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgfresa.Size = New System.Drawing.Size(288, 104)
        Me.dgfresa.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance4
        Me.UltraGroupBox1.Controls.Add(Me.btnagregar)
        Me.UltraGroupBox1.Controls.Add(Me.dgmodelofresa)
        Me.UltraGroupBox1.Controls.Add(Me.dgtipofresa)
        Me.UltraGroupBox1.Controls.Add(Me.dgparteadicional)
        Me.UltraGroupBox1.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 72)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(712, 256)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 12
        Me.UltraGroupBox1.Text = "Productos"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(7, 225)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(88, 24)
        Me.btnagregar.TabIndex = 15
        Me.btnagregar.Text = "Agregar"
        '
        'dgmodelofresa
        '
        Me.dgmodelofresa.AllowNavigation = False
        Me.dgmodelofresa.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgmodelofresa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgmodelofresa.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgmodelofresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgmodelofresa.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgmodelofresa.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgmodelofresa.CaptionText = "Modelo De Fresas"
        Me.dgmodelofresa.DataMember = ""
        Me.dgmodelofresa.FlatMode = True
        Me.dgmodelofresa.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgmodelofresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgmodelofresa.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgmodelofresa.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgmodelofresa.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgmodelofresa.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgmodelofresa.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgmodelofresa.LinkColor = System.Drawing.Color.Teal
        Me.dgmodelofresa.Location = New System.Drawing.Point(6, 24)
        Me.dgmodelofresa.Name = "dgmodelofresa"
        Me.dgmodelofresa.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgmodelofresa.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgmodelofresa.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgmodelofresa.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgmodelofresa.Size = New System.Drawing.Size(698, 88)
        Me.dgmodelofresa.TabIndex = 14
        '
        'dgtipofresa
        '
        Me.dgtipofresa.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgtipofresa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgtipofresa.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgtipofresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgtipofresa.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgtipofresa.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgtipofresa.CaptionText = "Tipos de Fresas"
        Me.dgtipofresa.DataMember = ""
        Me.dgtipofresa.FlatMode = True
        Me.dgtipofresa.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgtipofresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgtipofresa.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgtipofresa.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgtipofresa.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgtipofresa.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgtipofresa.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgtipofresa.LinkColor = System.Drawing.Color.Teal
        Me.dgtipofresa.Location = New System.Drawing.Point(376, 120)
        Me.dgtipofresa.Name = "dgtipofresa"
        Me.dgtipofresa.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgtipofresa.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgtipofresa.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgtipofresa.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgtipofresa.Size = New System.Drawing.Size(328, 104)
        Me.dgtipofresa.TabIndex = 13
        '
        'dgparteadicional
        '
        Me.dgparteadicional.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgparteadicional.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgparteadicional.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgparteadicional.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgparteadicional.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgparteadicional.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgparteadicional.CaptionText = "Partes Adicionales"
        Me.dgparteadicional.DataMember = ""
        Me.dgparteadicional.FlatMode = True
        Me.dgparteadicional.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgparteadicional.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgparteadicional.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgparteadicional.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgparteadicional.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgparteadicional.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgparteadicional.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgparteadicional.LinkColor = System.Drawing.Color.Teal
        Me.dgparteadicional.Location = New System.Drawing.Point(5, 120)
        Me.dgparteadicional.Name = "dgparteadicional"
        Me.dgparteadicional.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgparteadicional.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgparteadicional.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgparteadicional.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgparteadicional.Size = New System.Drawing.Size(363, 104)
        Me.dgparteadicional.TabIndex = 12
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rectangular3D
        Me.UltraGroupBox4.Controls.Add(Me.dgservicio)
        Me.UltraGroupBox4.Controls.Add(Me.txtcantidad)
        Me.UltraGroupBox4.Controls.Add(Me.Label10)
        Me.UltraGroupBox4.Controls.Add(Me.txtdescripcion)
        Me.UltraGroupBox4.Controls.Add(Me.Label9)
        Me.UltraGroupBox4.Controls.Add(Me.txtitem)
        Me.UltraGroupBox4.Controls.Add(Me.Label8)
        Me.UltraGroupBox4.Controls.Add(Me.botagregar)
        Me.UltraGroupBox4.Controls.Add(Me.botnuevo)
        Me.UltraGroupBox4.Controls.Add(Me.dgfresafab)
        Appearance5.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.UltraGroupBox4.HeaderAppearance = Appearance5
        Me.UltraGroupBox4.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 72)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(712, 232)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 25
        Me.UltraGroupBox4.Text = "Productos y Servicios"
        '
        'dgservicio
        '
        Me.dgservicio.DataMember = ""
        Me.dgservicio.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgservicio.Location = New System.Drawing.Point(16, 121)
        Me.dgservicio.Name = "dgservicio"
        Me.dgservicio.Size = New System.Drawing.Size(280, 88)
        Me.dgservicio.TabIndex = 10
        '
        'txtcantidad
        '
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Location = New System.Drawing.Point(512, 120)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(48, 21)
        Me.txtcantidad.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(464, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Cantidad"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(512, 80)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(192, 32)
        Me.txtdescripcion.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(446, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Descripción :"
        '
        'txtitem
        '
        Me.txtitem.Enabled = False
        Me.txtitem.Location = New System.Drawing.Point(512, 48)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(192, 21)
        Me.txtitem.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(480, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Item :"
        '
        'botagregar
        '
        Me.botagregar.Location = New System.Drawing.Point(304, 168)
        Me.botagregar.Name = "botagregar"
        Me.botagregar.Size = New System.Drawing.Size(80, 24)
        Me.botagregar.TabIndex = 3
        Me.botagregar.Text = "Agregar Item"
        '
        'botnuevo
        '
        Me.botnuevo.Location = New System.Drawing.Point(304, 56)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(80, 24)
        Me.botnuevo.TabIndex = 2
        Me.botnuevo.Text = "Nuevo Item"
        '
        'dgfresafab
        '
        Me.dgfresafab.CaptionText = "Fresas"
        Me.dgfresafab.DataMember = ""
        Me.dgfresafab.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgfresafab.Location = New System.Drawing.Point(16, 23)
        Me.dgfresafab.Name = "dgfresafab"
        Me.dgfresafab.Size = New System.Drawing.Size(280, 96)
        Me.dgfresafab.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.UltraGroupBox7)
        Me.TabPage2.Controls.Add(Me.dgclientes)
        Me.TabPage2.Controls.Add(Me.UltraGroupBox6)
        Me.TabPage2.Controls.Add(Me.dgpedidos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(720, 494)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta De Pedido"
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox7.Controls.Add(Me.txtnombre)
        Me.UltraGroupBox7.Controls.Add(Me.txtapellido)
        Me.UltraGroupBox7.Controls.Add(Me.chknombre)
        Me.UltraGroupBox7.Controls.Add(Me.chkapellido)
        Me.UltraGroupBox7.Location = New System.Drawing.Point(432, 264)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(280, 104)
        Me.UltraGroupBox7.SupportThemes = False
        Me.UltraGroupBox7.TabIndex = 3
        Me.UltraGroupBox7.Text = "Filtros Cliente"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(184, 72)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 4
        Me.UltraButton1.Text = "Filtrar"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(144, 40)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(120, 21)
        Me.txtnombre.TabIndex = 3
        '
        'txtapellido
        '
        Me.txtapellido.Enabled = False
        Me.txtapellido.Location = New System.Drawing.Point(144, 16)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(120, 21)
        Me.txtapellido.TabIndex = 2
        '
        'chknombre
        '
        Me.chknombre.Location = New System.Drawing.Point(16, 42)
        Me.chknombre.Name = "chknombre"
        Me.chknombre.Size = New System.Drawing.Size(64, 16)
        Me.chknombre.TabIndex = 1
        Me.chknombre.Text = "Nombre"
        '
        'chkapellido
        '
        Me.chkapellido.Location = New System.Drawing.Point(16, 18)
        Me.chkapellido.Name = "chkapellido"
        Me.chkapellido.Size = New System.Drawing.Size(64, 16)
        Me.chkapellido.TabIndex = 0
        Me.chkapellido.Text = "Apellido"
        '
        'dgclientes
        '
        Me.dgclientes.CaptionText = "Clientes"
        Me.dgclientes.DataMember = ""
        Me.dgclientes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgclientes.Location = New System.Drawing.Point(16, 264)
        Me.dgclientes.Name = "dgclientes"
        Me.dgclientes.ReadOnly = True
        Me.dgclientes.Size = New System.Drawing.Size(408, 160)
        Me.dgclientes.TabIndex = 2
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.UltraButton2)
        Me.UltraGroupBox6.Controls.Add(Me.chkfechaentrega)
        Me.UltraGroupBox6.Controls.Add(Me.chkfecharealizacion)
        Me.UltraGroupBox6.Controls.Add(Me.txtfechaentrega)
        Me.UltraGroupBox6.Controls.Add(Me.txtfecharealizacion)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(432, 64)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(280, 112)
        Me.UltraGroupBox6.SupportThemes = False
        Me.UltraGroupBox6.TabIndex = 1
        Me.UltraGroupBox6.Text = "Filtros Pedido"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(184, 80)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton2.TabIndex = 10
        Me.UltraButton2.Text = "Filtrar"
        '
        'chkfechaentrega
        '
        Me.chkfechaentrega.Location = New System.Drawing.Point(16, 50)
        Me.chkfechaentrega.Name = "chkfechaentrega"
        Me.chkfechaentrega.Size = New System.Drawing.Size(96, 16)
        Me.chkfechaentrega.TabIndex = 5
        Me.chkfechaentrega.Text = "Fecha entrega"
        '
        'chkfecharealizacion
        '
        Me.chkfecharealizacion.Location = New System.Drawing.Point(16, 25)
        Me.chkfecharealizacion.Name = "chkfecharealizacion"
        Me.chkfecharealizacion.Size = New System.Drawing.Size(120, 16)
        Me.chkfecharealizacion.TabIndex = 4
        Me.chkfecharealizacion.Text = "Fecha Realización"
        '
        'txtfechaentrega
        '
        Me.txtfechaentrega.Enabled = False
        Me.txtfechaentrega.Location = New System.Drawing.Point(136, 48)
        Me.txtfechaentrega.Name = "txtfechaentrega"
        Me.txtfechaentrega.Size = New System.Drawing.Size(128, 21)
        Me.txtfechaentrega.TabIndex = 3
        '
        'txtfecharealizacion
        '
        Me.txtfecharealizacion.Enabled = False
        Me.txtfecharealizacion.Location = New System.Drawing.Point(136, 23)
        Me.txtfecharealizacion.Name = "txtfecharealizacion"
        Me.txtfecharealizacion.Size = New System.Drawing.Size(128, 21)
        Me.txtfecharealizacion.TabIndex = 1
        '
        'dgpedidos
        '
        Me.dgpedidos.CaptionText = "Pedidos Realizados"
        Me.dgpedidos.DataMember = ""
        Me.dgpedidos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgpedidos.Location = New System.Drawing.Point(16, 72)
        Me.dgpedidos.Name = "dgpedidos"
        Me.dgpedidos.ReadOnly = True
        Me.dgpedidos.Size = New System.Drawing.Size(408, 184)
        Me.dgpedidos.TabIndex = 0
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(128, 528)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(80, 24)
        Me.btnguardar.TabIndex = 14
        Me.btnguardar.Text = "Grabar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(544, 504)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Importe Total:  $"
        '
        'txtimportetotal
        '
        Me.txtimportetotal.Location = New System.Drawing.Point(624, 500)
        Me.txtimportetotal.Name = "txtimportetotal"
        Me.txtimportetotal.Size = New System.Drawing.Size(72, 21)
        Me.txtimportetotal.TabIndex = 16
        '
        'btnmodificar
        '
        Me.btnmodificar.Enabled = False
        Me.btnmodificar.Location = New System.Drawing.Point(232, 528)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(88, 24)
        Me.btnmodificar.TabIndex = 17
        Me.btnmodificar.Text = "Modificar"
        '
        'Frmpedidofresa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 565)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.txtimportetotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.lblnropedido)
        Me.Controls.Add(Me.btnnuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "Frmpedidofresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pedido de Fresas"
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.dgDETOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubtot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtprioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.txtsubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpartepedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgfresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.dgmodelofresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtipofresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgparteadicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.dgservicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgfresafab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.txtnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.txtfechaentrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecharealizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtimportetotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private WithEvents check As New CheckBox
    Private Sub Frmpedidofresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nroserie = calcularnroserie()
        idpartepedida = 0
        idOBJ = 0
        damodelofresa = New SqlDataAdapter("select * from modelofresa", cnn)
        damodelofresa.Fill(ds, "modelofresa")
        Dim modelofresadc0 As New DataColumn("select")
        modelofresadc0.DefaultValue = "N"
        ds.Tables("modelofresa").Columns.Add(modelofresadc0)

        daDOS = New SqlDataAdapter("select * from detalleordenservicio", cnn)
        daDOS.FillSchema(ds, SchemaType.Source, "DOS")
        dtDOS = ds.Tables("DOS")
        Dim DOSdc0 As New DataColumn("Item")
        DOSdc0.DefaultValue = String.Empty
        dtDOS.Columns.Add(DOSdc0)
        Dim DOSdc1 As New DataColumn("operacion")
        dtDOS.Columns.Add(DOSdc1)
        Dim DOSdc2 As New DataColumn("cantidad")
        dtDOS.Columns.Add(DOSdc2)
        Dim DOSdc3 As New DataColumn("nroserie")
        dtDOS.Columns.Add(DOSdc3)

        daOBJ = New SqlDataAdapter("select * from objetodelservicio", cnn)
        daOBJ.FillSchema(ds, SchemaType.Source, "OBJ")

        daparteadicional = New SqlDataAdapter("Select * from parteadicional", cnn)
        daparteadicional.Fill(ds, "parteadicional")
        Dim parteadicionaldc0 As New DataColumn("select")
        parteadicionaldc0.DefaultValue = "N"
        ds.Tables("parteadicional").Columns.Add(parteadicionaldc0)
        Dim parteadicionaldc1 As New DataColumn("CantSolicitada")
        'parteadicionaldc1.DefaultValue = String.Empty
        parteadicionaldc1.DefaultValue = 0
        ds.Tables("parteadicional").Columns.Add(parteadicionaldc1)
        Dim parteadicionaldc2 As New DataColumn("precioventa")
        parteadicionaldc2.DefaultValue = 0
        ds.Tables("parteadicional").Columns.Add(parteadicionaldc2)

        RadioButton1.Checked = True
        datipofresa = New SqlDataAdapter("select * from tipofresa", cnn)
        datipofresa.Fill(ds, "tipofresa")
        Dim tipofresadc0 As New DataColumn("select")
        tipofresadc0.DefaultValue = "N"
        ds.Tables("tipofresa").Columns.Add(tipofresadc0)
        Dim tipofresadc1 As New DataColumn("Cantsolicitada")
        tipofresadc1.DefaultValue = 0
        ds.Tables("tipofresa").Columns.Add(tipofresadc1)
        Dim tipofresadc2 As New DataColumn("precioventa")
        tipofresadc2.DefaultValue = 0
        ds.Tables("tipofresa").Columns.Add(tipofresadc2)

        'dvtipofresa = ds.Tables("tipofresa").DefaultView
        'dvparteadicional = ds.Tables("parteadicional").DefaultView

        dafresa = New SqlDataAdapter("select * from fresa", cnn)
        dafresa.FillSchema(ds, SchemaType.Source, "fresa")
        dtfresa = ds.Tables("fresa")
        Dim fresadc0 As New DataColumn("nombre")
        dtfresa.Columns.Add(fresadc0)
        Dim fresadc1 As New DataColumn("Select")
        fresadc1.DefaultValue = "N"
        dtfresa.Columns.Add(fresadc1)

        dapartepedida = New SqlDataAdapter("select * from partepedido", cnn)
        dapartepedida.FillSchema(ds, SchemaType.Source, "partepedida")
        dtpartepedida = ds.Tables("partepedida")
        Dim partepedidadc0 As New DataColumn("nombre")
        dtpartepedida.Columns.Add(partepedidadc0)
        Dim partepedidadc1 As New DataColumn("select")
        partepedidadc1.DefaultValue = "N"
        dtpartepedida.Columns.Add(partepedidadc1)
        'Dim partepedidadc1 As New DataColumn("precioventa")
        'dtpartepedida.Columns.Add(partepedidadc1)
        dapedido = New SqlDataAdapter("select * from pedido", cnn)
        dapedido.FillSchema(ds, SchemaType.Source, "pedido")
        dtpedido = ds.Tables("pedido")

        ds.Relations.Add("modelofresa_tipofresa", ds.Tables("modelofresa").Columns("idmodelo"), ds.Tables("tipofresa").Columns("idmodelo"))
        ds.Relations.Add("modelofresa_parteadicional", ds.Tables("modelofresa").Columns("idmodelo"), ds.Tables("parteadicional").Columns("idmodelo"))

        daestado = New SqlDataAdapter("select idestado,nombre from estado", cnn)
        daestado.Fill(ds, "estado")
        cmbestado.DataSource = ds.Tables("estado")
        cmbestado.DisplayMember = "nombre"
        cmbestado.ValueMember = "idestado"
        cmbestado.Enabled = False

        daformadeentrega = New SqlDataAdapter("select idformadeentrega,nombre from formadeentrega", cnn)
        daformadeentrega.Fill(ds, "FDE")
        cmbformadeentrega.DataSource = ds.Tables("FDE")
        cmbformadeentrega.DisplayMember = "nombre"
        cmbformadeentrega.ValueMember = "idformadeentrega"
        cmbformadeentrega.Enabled = False
        dtpfechaentrega.Enabled = False

        daoperacion = New SqlDataAdapter("select * from operacion", cnn)
        daoperacion.Fill(ds, "operacion")
        Dim operaciondc0 As New DataColumn("select")
        operaciondc0.DefaultValue = "N"
        ds.Tables("operacion").Columns.Add(operaciondc0)
        Dim operaciondc1 As New DataColumn("precio")
        operaciondc1.DefaultValue = String.Empty
        ds.Tables("operacion").Columns.Add(operaciondc1)
        dtoperacion = ds.Tables("operacion")
        'dgservicio.DataSource = ds
        'dgservicio.DataMember = "operacion"


        UltraGroupBox4.Visible = False
        UltraGroupBox5.Visible = False

        Dim DOSts As DataGridTableStyle = CGrid.GetTableStyle(dtDOS)
        'Dim DOScs0 As New CGridCheckBoxStyle("select", 30, _
        '                                 HorizontalAlignment.Center, False, _
        '                                  "", "", "N", "Y", False, "")
        'CGrid.AddColumn(modelofresats, modelofresacs0)
        Dim DOScs1 As New CGridTextBoxStyle("item", 120, HorizontalAlignment.Left, True, _
        "ITEM", String.Empty, "")
        CGrid.AddColumn(DOSts, DOScs1)
        Dim DOScs2 As New CGridTextBoxStyle("operacion", 120, HorizontalAlignment.Left, True, "Servicio", String.Empty, "")
        CGrid.AddColumn(DOSts, DOScs2)
        Dim DOScs3 As New CGridTextBoxStyle("precio", 50, HorizontalAlignment.Center, True, _
        "Precio", String.Empty, "")
        CGrid.AddColumn(DOSts, DOScs3)
        Dim DOScs4 As New CGridTextBoxStyle("cantidad", 55, HorizontalAlignment.Center, True, _
        "Cantidad", String.Empty, "")
        CGrid.AddColumn(DOSts, DOScs4)
        Dim DOScs5 As New CGridTextBoxStyle("nroserie", 55, HorizontalAlignment.Center, True, _
        "NroSerie", String.Empty, "")
        CGrid.AddColumn(DOSts, DOScs5)
        CGrid.SetGridStyle(Me.dgDETOS, dtDOS, DOSts)
        'dgmodelofresa.DataSource = ds
        'dgmodelofresa.DataMember = "modelofresa"

        'establecer la grilla asociada a operaciones
        Dim operacionts As DataGridTableStyle = CGrid.GetTableStyle(dtoperacion)
        Dim operacioncs0 As New CGridCheckBoxStyle("select", 30, _
                                         HorizontalAlignment.Center, False, _
                                          "", "", "N", "Y", False, "")
        CGrid.AddColumn(operacionts, operacioncs0)
        Dim operacioncs1 As New CGridTextBoxStyle("nombre", 133, HorizontalAlignment.Left, True, _
        "Servcios", String.Empty, "")
        CGrid.AddColumn(operacionts, operacioncs1)
        Dim operacioncs2 As New CGridTextBoxStyle("precio", 50, HorizontalAlignment.Left, False, _
        "Precio", String.Empty, "")
        CGrid.AddColumn(operacionts, operacioncs2)
        CGrid.SetGridStyle(Me.dgservicio, dtoperacion, operacionts)


        'Establecer los datos asociados a la grilla "MODELO FRESA"
        Dim modelofresats As DataGridTableStyle = CGrid.GetTableStyle(ds.Tables("modelofresa"))
        Dim modelofresacs0 As New CGridCheckBoxStyle("select", 30, _
                                         HorizontalAlignment.Center, False, _
                                          "", "", "N", "Y", False, "")
        CGrid.AddColumn(modelofresats, modelofresacs0)
        Dim modelofresacs1 As New CGridTextBoxStyle("nombre", 100, HorizontalAlignment.Left, True, _
        "Modelo", String.Empty, "")
        CGrid.AddColumn(modelofresats, modelofresacs1)
        Dim modelofresacs2 As New CGridTextBoxStyle("grupomodelo", 90, HorizontalAlignment.Center, True, "Grupo Modelo", String.Empty, "")
        CGrid.AddColumn(modelofresats, modelofresacs2)
        Dim modelofresacs3 As New CGridTextBoxStyle("materialatrabajar", 90, HorizontalAlignment.Center, True, "Grupo Modelo", String.Empty, "")
        CGrid.AddColumn(modelofresats, modelofresacs3)
        Dim modelofresacs4 As New CGridTextBoxStyle("mododeavance", 85, HorizontalAlignment.Center, True, "Modo Avanvce", String.Empty, "")
        CGrid.AddColumn(modelofresats, modelofresacs4)
        Dim modelofresacs5 As New CGridTextBoxStyle("tipoacabado", 90, HorizontalAlignment.Center, True, "Tipoacabado", String.Empty, "")
        CGrid.AddColumn(modelofresats, modelofresacs5)
        Dim modelofresacs6 As New CGridTextBoxStyle("velocidaddeavance", 70, HorizontalAlignment.Center, True, "Vel. Avance", String.Empty, "")
        CGrid.AddColumn(modelofresats, modelofresacs6)
        Dim modelofresacs10 As New CGridTextBoxStyle("precio", 60, HorizontalAlignment.Center, True, "Precio", String.Empty, "")
        CGrid.AddColumn(modelofresats, modelofresacs10)
        CGrid.SetGridStyle(Me.dgmodelofresa, ds.Tables("modelofresa"), modelofresats)
        dgmodelofresa.DataSource = ds
        dgmodelofresa.DataMember = "modelofresa"
        
        'Establecer los datos asociados a la grilla "PARTE ADICIONAL"
        'Dim parteadicionalts As DataGridTableStyle = CGrid.GetTableStyle(dvparteadicional)
        Dim parteadicionalts As DataGridTableStyle = CGrid.GetTableStyle(ds.Tables("parteadicional"))
        Dim parteadicionalcs0 As New CGridCheckBoxStyle("select", 30, _
                                          HorizontalAlignment.Center, False, _
                                          "", "", "N", "Y", False, "")
        CGrid.AddColumn(parteadicionalts, parteadicionalcs0)
        Dim parteadicionalcs1 As New CGridTextBoxStyle("nombre", 80, HorizontalAlignment.Left, True, _
        "Modelo", String.Empty, "")
        CGrid.AddColumn(parteadicionalts, parteadicionalcs1)
        Dim parteadicionalcs4 As New CGridTextBoxStyle("cantidad Real", 40, HorizontalAlignment.Center, False, "Cant.", String.Empty, "")
        CGrid.AddColumn(parteadicionalts, parteadicionalcs4)
        Dim parteadicionalcs5 As New CGridNumericUpDownStyle("cantsolicitada", 50, "Cantidad", 0, 1000, 0, 1, LeftRightAlignment.Left, 0, "0")
        CGrid.AddColumn(parteadicionalts, parteadicionalcs5)
        Dim parteadicionalcs6 As New CGridNumericUpDownStyle("precioventa", 50, "Descuento", 0, 1000, 3, 1, LeftRightAlignment.Left, 0, "0")
        CGrid.AddColumn(parteadicionalts, parteadicionalcs6)
        'Dim parteadicionalcs6 As New CGridTextBoxStyle("precioventa", 60, HorizontalAlignment.Center, False, "Descuento (%)", String.Empty, "")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs6)
        Dim parteadicionalcs2 As New CGridTextBoxStyle("precio", 60, HorizontalAlignment.Center, True, "Precio", String.Empty, "")
        CGrid.AddColumn(parteadicionalts, parteadicionalcs2)
        'Dim parteadicionalcs5 As New CGridTextBoxStyle("cantidad", 60, HorizontalAlignment.Center, True, "Cant.Real", String.Empty, "")
        'CGrid.AddColumn(parteadicionalts, parteadicionalcs5)
        Dim parteadicionalcs3 As New CGridTextBoxStyle("descripcion", 60, HorizontalAlignment.Center, True, "Descripción", String.Empty, "")
        CGrid.AddColumn(parteadicionalts, parteadicionalcs3)
        CGrid.SetGridStyle(Me.dgparteadicional, ds.Tables("parteadicional"), parteadicionalts)
        dgparteadicional.DataSource = ds
        dgparteadicional.DataMember = "modelofresa.modelofresa_parteadicional"


        'Establecer los datos asociados a la grilla "Tipo FRESA"
        'Dim tipofresats As DataGridTableStyle = CGrid.GetTableStyle(dvtipofresa)
        Dim tipofresats As DataGridTableStyle = CGrid.GetTableStyle(ds.Tables("tipofresa"))
        Dim tipofresacs0 As New CGridCheckBoxStyle("select", 30, _
                                          HorizontalAlignment.Center, False, _
                                          "", "", "N", "Y", False, "")
        CGrid.AddColumn(tipofresats, tipofresacs0)
        Dim tipofresacs1 As New CGridTextBoxStyle("nombre", 80, HorizontalAlignment.Left, True, _
        "Modelo", String.Empty, "")
        CGrid.AddColumn(tipofresats, tipofresacs1)
        Dim tipofresacs5 As New CGridNumericUpDownStyle("cantsolicitada", 50, "Cantidad", 0, 1000, 0, 1, LeftRightAlignment.Left, 0, "0")
        CGrid.AddColumn(tipofresats, tipofresacs5)
        Dim tipofresacs4 As New CGridNumericUpDownStyle("precioventa", 50, "Descuento", 0, 1000, 3, 1, LeftRightAlignment.Left, 0, "0")
        CGrid.AddColumn(tipofresats, tipofresacs4)
        Dim tipofresacs2 As New CGridTextBoxStyle("precio", 60, HorizontalAlignment.Center, True, "Precio", String.Empty, "")
        CGrid.AddColumn(tipofresats, tipofresacs2)
        CGrid.SetGridStyle(Me.dgtipofresa, ds.Tables("tipofresa"), tipofresats)
        dgtipofresa.DataSource = ds
        dgtipofresa.DataMember = "modelofresa.modelofresa_tipofresa"

        'Establecer los datos asociados a la grilla "FRESA"
        Dim fresats As DataGridTableStyle = CGrid.GetTableStyle(dtfresa)
        Dim fresacs3 As New CGridCheckBoxStyle("select", 30, _
                                                  HorizontalAlignment.Center, False, _
                                                  "", "", "N", "Y", False, "")
        CGrid.AddColumn(fresats, fresacs3)
        Dim fresacs0 As New CGridTextBoxStyle("nroserie", 60, HorizontalAlignment.Center, False, "Nro.Serie", String.Empty, "")
        CGrid.AddColumn(fresats, fresacs0)
        Dim fresacs1 As New CGridTextBoxStyle("nombre", 110, HorizontalAlignment.Left, True, _
        "Tipo Fresa", String.Empty, "")
        CGrid.AddColumn(fresats, fresacs1)
        Dim fresacs2 As New CGridTextBoxStyle("precio", 47, HorizontalAlignment.Center, True, _
                "Precio", String.Empty, "")
        CGrid.AddColumn(fresats, fresacs2)
        CGrid.SetGridStyle(Me.dgfresa, dtfresa, fresats)


        Dim partepedidats As DataGridTableStyle = CGrid.GetTableStyle(dtpartepedida)
        Dim partepedidacs3 As New CGridCheckBoxStyle("select", 30, _
                                                          HorizontalAlignment.Center, False, _
                                                          "", "", "N", "Y", False, "")
        CGrid.AddColumn(partepedidats, partepedidacs3)
        Dim partepedidacs0 As New CGridTextBoxStyle("nombre", 110, HorizontalAlignment.Left, False, "Parte", String.Empty, "")
        CGrid.AddColumn(partepedidats, partepedidacs0)
        Dim partepedidacs1 As New CGridTextBoxStyle("cantidad", 60, HorizontalAlignment.Center, True, _
        "Cantidad", String.Empty, "")
        CGrid.AddColumn(partepedidats, partepedidacs1)
        Dim partepedidacs2 As New CGridTextBoxStyle("precio", 47, HorizontalAlignment.Center, True, _
        "Precio", String.Empty, "")
        CGrid.AddColumn(partepedidats, partepedidacs2)
        CGrid.SetGridStyle(Me.dgpartepedida, dtpartepedida, partepedidats)
        princ.barra.agregarBoton(Me)
    End Sub
    Function calcularnroserie() As Object
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        Dim nroserie As Object
        Dim cmd As New SqlCommand
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
        Dim cmd As New SqlCommand
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
        Dim cmd As New SqlCommand(strsql, cnn)
        Dim nropedido As Object
        nropedido = cmd.ExecuteScalar
        cnn.Close()
        If IsDBNull(nropedido) Then
            nropedido = 0
        End If
        nropedido += 1
        calcularNropedido = nropedido
    End Function

    Private Sub UltraTextEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraTextEditor1.ValueChanged

    End Sub

    Private Sub UltraTextEditor1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraTextEditor1.TextChanged

    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        lbnropedido.Text = calcularNropedido()
        idOBJ = calcularidobj()
        lbfecha.Text = Format(Now, "dd/MM/yyyy")
        txtcliente.Enabled = True
        txtcliente.Text = ""
        txtsubtotal.Text = ""
        txtimportetotal.Text = ""
        txtprioridad.Text = ""
        txtcliente.Focus()
        dtfresa.Clear()
        dtpartepedida.Clear()
        dtpedido.Clear()
        dtDOS.Clear()
        bandeabm = False
        bnuevo = True
        bpedido = True
    End Sub

    Private Sub dgparteadicional_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

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

    Private Sub dgtipofresa_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)
        dgtipofresa.Select(dgtipofresa.CurrentCell.RowNumber)
    End Sub

    Private Sub dgtipofresa_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub dgmodelofresa_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub dgmodelofresa_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgmodelofresa.Select(dgmodelofresa.CurrentCell.RowNumber)
        dvtipofresa.RowFilter = "idmodelo =" & ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
        dvparteadicional.RowFilter = "idmodelo=" & ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
    End Sub



    Private Sub UltraGroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Dim i As Integer
        Dim j As Integer
        For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
            'If dvtipofresa.Item(i).Item("select") = "Y" Then
            'If IsDBNull(dvtipofresa.Item(i).Item("cantsolicitada")) = False Then
            If ds.Tables("tipofresa").Rows(i).Item("select") = "Y" Then

                If Not (ds.Tables("tipofresa").Rows(i).Item("cantsolicitada") = 0) Then

                    For j = 1 To ds.Tables("tipofresa").Rows(i).Item("cantsolicitada")
                        nroserie += 1
                        Dim dr As DataRow = ds.Tables("fresa").NewRow
                        dr("nroserie") = CInt(nroserie)
                        dr("idtipo") = ds.Tables("tipofresa").Rows(i).Item("idtipo")
                        dr("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
                        dr("nropedido") = CLng(lbnropedido.Text)
                        dr("estado") = 8
                        dr("nombre") = ds.Tables("tipofresa").Rows(i).Item("nombre")
                        ds.Tables("fresa").Rows.Add(dr)
                        If ds.Tables("tipofresa").Rows(i).Item("precioventa") = 0 Then
                            dr("precio") = CDec(ds.Tables("tipofresa").Rows(i).Item("precio"))
                        Else
                            'modifique el precio
                            dr("precio") = CDec(CDec(ds.Tables("tipofresa").Rows(i).Item("precio")) * CDec(ds.Tables("tipofresa").Rows(i).Item("precioventa")) / 100)
                        End If
                    Next
                    ds.Tables("tipofresa").Rows(i).Item("cantsolicitada") = 0
                    ds.Tables("tipofresa").Rows(i).Item("precioventa") = 0
                End If
                ds.Tables("tipofresa").Rows(i).Item("select") = "N"
            End If
        Next

        For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
            If ds.Tables("parteadicional").Rows(i).Item("select") = "Y" Then
                idpartepedida += 1
                Dim dr As DataRow = dtpartepedida.NewRow
                dr("idpartepedida") = CInt(idpartepedida)
                dr("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
                dr("idadicional") = ds.Tables("parteadicional").Rows(i).Item("idadicional")
                dr("idpedido") = CLng(lbnropedido.Text)
                dr("nombre") = ds.Tables("parteadicional").Rows(i).Item("nombre")
                If ds.Tables("parteadicional").Rows(i).Item("cantsolicitada") = 0 Then
                    dr("cantidad") = CInt(ds.Tables("parteadicional").Rows(i).Item("cantidad"))
                Else
                    dr("cantidad") = CInt(ds.Tables("parteadicional").Rows(i).Item("cantsolicitada"))
                    ds.Tables("parteadicional").Rows(i).Item("cantsolicitada") = 0
                End If
                If ds.Tables("parteadicional").Rows(i).Item("precioventa") = 0 Then
                    dr("precio") = ds.Tables("parteadicional").Rows(i).Item("precio")
                Else
                    dr("precio") = CDec(CDec(ds.Tables("parteadicional").Rows(i).Item("precioventa") * ds.Tables("parteadicional").Rows(i).Item("precio")) / 100)
                End If
                ds.Tables("parteadicional").Rows(i).Item("precioventa") = 0
                dtpartepedida.Rows.Add(dr)
                ds.Tables("parteadicional").Rows(i).Item("select") = "N"

            End If
        Next
        'For i = 0 To ds.Tables("modelofresa").Rows.Count - 1
        'ds.Tables("modelofresa").Rows(i).Item("select") = "N"
        'Next
        Dim subtotal As Decimal
        For i = 0 To dtfresa.Rows.Count - 1
            subtotal += dtfresa.Rows(i).Item("precio")
        Next
        For i = 0 To dtpartepedida.Rows.Count - 1
            subtotal += CInt(dtpartepedida.Rows(i).Item("cantidad")) * CDec(dtpartepedida.Rows(i).Item("precio"))
        Next
        txtsubtotal.Text = CStr(subtotal)
        Dim total As Decimal
        If Not (txtimportetotal.Text = String.Empty) Then
            total = CDec(txtimportetotal.Text)
        Else
            total = 0
        End If
        total += subtotal
        txtimportetotal.Text = total
    End Sub

    Private Sub dgmodelofresa_Navigate_1(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgmodelofresa.Navigate

    End Sub

    'Private Sub dgmodelofresa_CurrentCellChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgmodelofresa.CurrentCellChanged
    '    dgmodelofresa.Select(dgmodelofresa.CurrentCell.RowNumber)
    '    dvtipofresa.RowFilter = "idmodelo =" & ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
    '    dvparteadicional.RowFilter = "idmodelo=" & ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
    'End Sub

    Private Sub dgmodelofresa_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgmodelofresa.MouseUp
        If sel_check_col(dgmodelofresa, 0, e) Then

            Select Case ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("select")
                Case "N"
                    ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("select") = "Y"
                    Dim i As Integer
                    'For i = 0 To dvtipofresa.Count - 1
                    For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
                        If ds.Tables("tipofresa").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                            ds.Tables("tipofresa").Rows(i).Item("select") = "Y"
                        End If
                        'dvtipofresa.Item(i).Item("select") = "Y"
                    Next i
                    For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                        If ds.Tables("parteadicional").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                            ds.Tables("parteadicional").Rows(i).Item("select") = "Y"
                        End If
                        '                        dvparteadicional.Item(i).Item("select") = "Y"
                    Next i

                Case "Y"
                    ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("select") = "N"
                    dgmodelofresa.Refresh()
                    'Dim i As Integer
                    'For i = 0 To dvtipofresa.Count - 1
                    'dvtipofresa.Item(i).Item("select") = "N"
                    'Next i
                    'For i = 0 To dvparteadicional.Count - 1
                    'dvparteadicional.Item(i).Item("select") = "N"
                    'Next i
                    Dim i As Integer
                    'For i = 0 To dvtipofresa.Count - 1
                    For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
                        If ds.Tables("tipofresa").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                            ds.Tables("tipofresa").Rows(i).Item("select") = "N"
                        End If
                        'dvtipofresa.Item(i).Item("select") = "Y"
                    Next i
                    For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                        If ds.Tables("parteadicional").Rows(i).Item("idmodelo") = ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentRowIndex).Item("idmodelo") Then
                            ds.Tables("parteadicional").Rows(i).Item("select") = "N"
                        End If
                        '                        dvparteadicional.Item(i).Item("select") = "Y"
                    Next i
            End Select
            dgmodelofresa.Select(dgmodelofresa.CurrentCell.RowNumber)
            dgmodelofresa.Refresh()

        End If
    End Sub

    Private Sub dgparteadicional_Navigate_1(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgparteadicional.Navigate

    End Sub

    Private Sub dgmodelofresa_CurrentCellChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgmodelofresa.CurrentCellChanged
        'dgmodelofresa.Select(dgmodelofresa.CurrentCell.RowNumber)
        'dvtipofresa.RowFilter = "idmodelo =" & ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
        'dvparteadicional.RowFilter = "idmodelo=" & ds.Tables("modelofresa").Rows(dgmodelofresa.CurrentCell.RowNumber).Item("idmodelo")
    End Sub

    Private Sub dgtipofresa_Navigate_1(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgtipofresa.Navigate

    End Sub

    Private Sub dgparteadicional_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgparteadicional.CurrentCellChanged
        dgparteadicional.Select(dgparteadicional.CurrentCell.RowNumber)
    End Sub

    Private Sub dgtipofresa_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgtipofresa.CurrentCellChanged
        dgtipofresa.Select(dgtipofresa.CurrentCell.RowNumber)
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim i As Integer
        Dim b1 As Boolean
        Dim b2 As Boolean
        b1 = False
        b2 = False
        If CDate(lbfecha.Text) > CDate(dtpfechaentrega.Value) Then
            MsgBox("fecha entrega no válida")
            Exit Sub
        End If
        If txtprioridad.Text = "" Then
            MsgBox("ingrese prioridad")
            txtprioridad.Focus()
            Exit Sub
        End If

        If dtfresa.Rows.Count < 1 And dtpartepedida.Rows.Count < 1 Then
            MsgBox("falta Detalle Pedido")
            Exit Sub
            'Else
            '   For i = 0 To dtfresa.Rows.Count - 1
            '  If Not (dtfresa.Rows(i).RowState = DataRowState.Deleted) Then
            ' b1 = True
            'End If
            '   Next

        End If
        If bandeabm = False Then
            Dim dr As DataRow = dtpedido.NewRow
            dr("idpedido") = CObj(lbnropedido.Text)
            dr("fecharealizacion") = CDate(lbfecha.Text)
            dr("prioridad") = CInt(txtprioridad.Text)
            dr("idestado") = CInt(cmbestado.SelectedValue)
            dr("idcliente") = idcliente
            dr("fechaentrega") = dtpfechaentrega.Value
            dr("idformadeentrega") = CInt(cmbformadeentrega.SelectedValue)
            dtpedido.Rows.Add(dr)
        Else
            dtpedido.Rows(0).Item("prioridad") = CInt(txtprioridad.Text)
            dtpedido.Rows(0).Item("idestado") = CInt(cmbestado.SelectedValue)
            dtpedido.Rows(0).Item("idcliente") = idcliente
            dtpedido.Rows(0).Item("fechaentrega") = dtpfechaentrega.Value
            dtpedido.Rows(0).Item("idformadeentrega") = CInt(cmbformadeentrega.SelectedValue)
        End If
        Dim cmdb0 As New SqlCommandBuilder(dapedido)
        dapedido.Update(ds, "pedido")
        Dim cmdb1 As New SqlCommandBuilder(dafresa)
        dafresa.Update(ds, "fresa")
        Dim cmb2 As New SqlCommandBuilder(dapartepedida)
        dapartepedida.Update(ds, "partepedida")
        Dim cmb3 As New SqlCommandBuilder(daOBJ)
        daOBJ.Update(ds, "OBJ")
        Dim cmb4 As New SqlCommandBuilder(daDOS)
        daDOS.Update(ds, "DOS")
        btnguardar.Enabled = False
        txtprioridad.Text = ""
        txtcliente.Text = ""
        txtimportetotal.Text = ""
        txtsubtot.Text = ""
        txtsubtotal.Text = ""
        btnguardar.Enabled = False
        txtcliente.Enabled = False
        UltraGroupBox1.Enabled = False
        UltraGroupBox2.Enabled = False

        btnnuevo.Focus()
        bnuevo = False
        bpedido = False
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnquitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquitar.Click
        Dim i As Integer
        If MsgBox("Está seguro", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        If dtfresa.Rows.Count > 0 Then
            For i = dtfresa.Rows.Count - 1 To 0 Step -1
                If Not (dtfresa.Rows(i).RowState = DataRowState.Deleted) Then
                    If dtfresa.Rows(i).Item("select") = "Y" Then
                        dtfresa.Rows(i).Delete()
                        dgfresa.Refresh()
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
        If dtpartepedida.Rows.Count > 0 Then
            For i = dtpartepedida.Rows.Count - 1 To 0 Step -1
                If Not (dtpartepedida.Rows(i).RowState = DataRowState.Deleted) Then
                    If dtpartepedida.Rows(i).Item("select") = "Y" Then
                        dtpartepedida.Rows(i).Delete()
                        dgpartepedida.Refresh()
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
        For i = 0 To dtfresa.Rows.Count - 1
            If Not (dtfresa.Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += dtfresa.Rows(i).Item("precio")
            End If

        Next
        For i = 0 To dtpartepedida.Rows.Count - 1
            If Not (dtpartepedida.Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += dtpartepedida.Rows(i).Item("precio") * dtpartepedida.Rows(i).Item("cantidad")
            End If
        Next
        txtsubtotal.Text = CStr(subtotal)
    End Sub

    Private Sub txtsubtotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubtotal.ValueChanged

    End Sub

    Private Sub dgfresa_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgfresa.Navigate

    End Sub

    Private Sub dgfresa_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgfresa.MouseUp
        If sel_check_col(dgfresa, 0, e) Then
            Select Case dtfresa.Rows(dgfresa.CurrentRowIndex).Item("select")
                Case "N"
                    dtfresa.Rows(dgfresa.CurrentRowIndex).Item("select") = "Y"
                Case "Y"
                    dtfresa.Rows(dgfresa.CurrentRowIndex).Item("select") = "N"
                    dgfresa.Refresh()
            End Select
            dgfresa.Select(dgfresa.CurrentCell.RowNumber)
            dgfresa.Refresh()
        End If
    End Sub

    Private Sub dgpartepedida_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgpartepedida.Navigate

    End Sub

    Private Sub dgpartepedida_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgpartepedida.MouseUp
        If sel_check_col(dgpartepedida, 0, e) Then
            Select Case dtpartepedida.Rows(dgpartepedida.CurrentRowIndex).Item("select")
                Case "N"
                    dtpartepedida.Rows(dgpartepedida.CurrentRowIndex).Item("select") = "Y"
                Case "Y"
                    dtpartepedida.Rows(dgpartepedida.CurrentRowIndex).Item("select") = "N"
                    dgpartepedida.Refresh()
            End Select
            dgpartepedida.Select(dgpartepedida.CurrentCell.RowNumber)
            dgpartepedida.Refresh()
        End If
    End Sub

    Private Sub txtcliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcliente.ValueChanged

    End Sub

    Private Sub txtcliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text = "" Then
            Exit Sub
        End If
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        Dim cmd As New SqlCommand
        cmd.Connection = cnn
        cmd.CommandText = "select apellido from cliente where documento=" & CLng(txtcliente.Text)
        Dim apellido As Object
        apellido = cmd.ExecuteScalar

        If Not (apellido = "") Then
            cmd.CommandText = "select idcliente from cliente where documento=" & CLng(txtcliente.Text)
            idcliente = cmd.ExecuteScalar
            UltraGroupBox1.Enabled = True
            UltraGroupBox2.Enabled = True
            btnguardar.Enabled = True
            txtprioridad.Enabled = True
            cmbestado.Enabled = True
            cmbformadeentrega.Enabled = True
            dtpfechaentrega.Enabled = True
            Dim str As String = "select fresa.nroserie,tipofresa.nombre,fresa.fechafinfabricacion " _
            & "from fresa,tipofresa where fresa.idmodelo=tipofresa.idmodelo and " _
            & "fresa.idtipo=tipofresa.idtipo and fresa.nropedido in (select pedido.idpedido from pedido where" _
            & " pedido.idcliente =" & CInt(idcliente) & ")"
            dafresasfab = New SqlDataAdapter(str, cnn)
            dtfresasfab = New DataTable
            dafresasfab.Fill(dtfresasfab)

            dgfresafab.DataSource = dtfresasfab
            GroupBox1.Enabled = True
        Else
            idcliente = cmd.ExecuteScalar
            UltraGroupBox1.Enabled = False
            UltraGroupBox2.Enabled = False
            btnguardar.Enabled = False
            txtprioridad.Enabled = False
            cmbestado.Enabled = False
            GroupBox1.Enabled = False
            cmbformadeentrega.Enabled = False
            dtpfechaentrega.Enabled = False
        End If
        cnn.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex = 1 Then
            dgpedidos.DataSource = Nothing
            Dim str As String = "select pedido.idpedido As NroPedido, pedido.fecharealizacion, pedido.fechaentrega, estado.nombre as estado," _
            & "cliente.nombre as NombreCliente, cliente.apellido as ApellidoCliente from cliente, pedido, estado where cliente.idcliente=pedido.idcliente and pedido.idestado=estado.idestado"
            Dim da = New SqlDataAdapter(str, cnn)
            Dim pedido As New DataTable
            da.Fill(pedido)
            dvpedidos = pedido.DefaultView
            dgpedidos.DataSource = dvpedidos
            dgclientes.DataSource = Nothing
            str = "select cliente.apellido as Apellido, cliente.nombre As Nombre,cliente.direccion as Direccion,localidad.nombre as Localidad,cliente.documento from cliente," _
            & "localidad where cliente.localidad=localidad.idlocalidad"
            Dim dacli As New SqlDataAdapter(str, cnn)
            Dim clientes As New DataTable
            dacli.Fill(clientes)
            dvclientes = clientes.DefaultView
            dgclientes.DataSource = dvclientes
        End If
    End Sub

    Private Sub dgpedidos_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgpedidos.Navigate

    End Sub

    Private Sub dgpedidos_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles dgpedidos.ControlRemoved

    End Sub

    Private Sub dgpedidos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgpedidos.CurrentCellChanged
        'Dim cmd As New SqlCommand
        'Dim i As Integer
        'Dim j As Integer
        'cnn.Open()
        'Dim str As String = "select fresa.* from fresa where fresa.nropedido =" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        'ds.Tables("fresa").Clear()
        'dafresa = New SqlDataAdapter(str, cnn)
        'dafresa.Fill(ds, "fresa")

        'For j = 0 To ds.Tables("fresa").Rows.Count - 1
        '    For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
        '        If ds.Tables("fresa").Rows(j).Item("idtipo") = ds.Tables("tipofresa").Rows(i).Item("idtipo") And _
        '        ds.Tables("fresa").Rows(j).Item("idmodelo") = ds.Tables("tipofresa").Rows(i).Item("idmodelo") Then
        '            ds.Tables("fresa").Rows(j).Item("nombre") = ds.Tables("tipofresa").Rows(i).Item("nombre")
        '        End If
        '    Next
        'Next

        'str = "select * from partepedido where idpedido =" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        'ds.Tables("partepedida").Clear()
        'dapartepedida = New SqlDataAdapter(str, cnn)
        'dapartepedida.Fill(ds, "partepedida")
        'For j = 0 To ds.Tables("partepedida").Rows.Count - 1
        '    For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
        '        If ds.Tables("partepedida").Rows(j).Item("idadicional") = ds.Tables("parteadicional").Rows(i).Item("idadicional") And _
        '        ds.Tables("partepedida").Rows(j).Item("idmodelo") = ds.Tables("parteadicional").Rows(i).Item("idmodelo") Then
        '            ds.Tables("partepedida").Rows(j).Item("nombre") = ds.Tables("parteadicional").Rows(i).Item("nombre")
        '        End If
        '    Next
        'Next

        'ds.Tables("pedido").Clear()
        'dapedido = New SqlDataAdapter("select * from pedido where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)), cnn)
        'dapedido.Fill(ds, "pedido")
        'dtpedido = ds.Tables("pedido")
        'idcliente = dtpedido.Rows(0).Item("idcliente")


        'cmd.CommandText = "select documento from cliente where idcliente=" & idcliente
        'cmd.Connection = cnn
        'txtcliente.Text = CStr(cmd.ExecuteScalar)
        'txtprioridad.Text = dtpedido.Rows(0).Item("prioridad")
        'lbnropedido.Text = CStr(dtpedido.Rows(0).Item("idpedido"))
        'cmbestado.SelectedValue = dtpedido.Rows(0).Item("idestado")
        'dtpfechaentrega.Value = CDate(dtpedido.Rows(0).Item("fechaentrega"))
        'cmbformadeentrega.SelectedValue = dtpedido.Rows(0).Item("idformadeentrega")
        'cmbformadeentrega.Enabled = False
        'dtpfechaentrega.Enabled = False
        'cmbestado.Enabled = False
        'lbfecha.Text = CStr(dtpedido.Rows(0).Item("fecharealizacion"))
        'cmd.CommandText = "select max(idpartepedida) from partepedido where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        'If cnn.State = ConnectionState.Closed Then
        '    cnn.Open()
        'End If
        'idpartepedida = cmd.ExecuteScalar
        'If IsDBNull(idpartepedida) Then
        '    idpartepedida = 0
        'End If
        'cnn.Close()
        'btnguardar.Enabled = False
        'txtcliente.Enabled = False
        'UltraGroupBox1.Enabled = False
        'UltraGroupBox2.Enabled = False
        'bandeabm = True
        'btnmodificar.Enabled = True
        'nroserie = calcularnroserie()
        'idOBJ = calcularidobj()
        'ds.Tables("DOS").Clear()
        'str = "select * from detalleordenservicio where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        'daDOS = New SqlDataAdapter(str, cnn)
        'daDOS.Fill(ds, "DOS")
        'ds.Tables("OBJ").Clear()
        'str = "select * from objetodelservicio where idobjetodelservicio in (select idobjetodelservicio from detalleordenservicio" _
        '& " where idpedido= " & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)) & ")"
        ''¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡
        'daOBJ = New SqlDataAdapter(str, cnn)
        'daOBJ.Fill(ds, "OBJ")
        'For i = 0 To ds.Tables("DOS").Rows.Count - 1
        '    For j = 0 To ds.Tables("OBJ").Rows.Count - 1
        '        If ds.Tables("DOS").Rows(i).Item("idobjetodelservicio") = ds.Tables("OBJ").Rows(j).Item("idobjetodelservicio") Then
        '            ds.Tables("DOS").Rows(i).Item("item") = ds.Tables("OBJ").Rows(j).Item("nombre")
        '            ds.Tables("DOS").Rows(i).Item("cantidad") = ds.Tables("OBJ").Rows(j).Item("cantidad")
        '        End If
        '    Next
        'Next
        'For i = 0 To ds.Tables("DOS").Rows.Count - 1
        '    For j = 0 To ds.Tables("operacion").Rows.Count - 1
        '        If ds.Tables("DOS").Rows(i).Item("idoperacion") = ds.Tables("operacion").Rows(j).Item("idoperacion") Then
        '            ds.Tables("DOS").Rows(i).Item("operacion") = ds.Tables("operacion").Rows(j).Item("nombre")
        '        End If
        '    Next
        'Next


        'Dim subtotal1 As Decimal
        'For i = 0 To dtfresa.Rows.Count - 1
        '    subtotal1 += dtfresa.Rows(i).Item("precio")
        'Next
        'For i = 0 To dtpartepedida.Rows.Count - 1
        '    subtotal1 += CInt(dtpartepedida.Rows(i).Item("cantidad")) * CDec(dtpartepedida.Rows(i).Item("precio"))
        'Next
        'txtsubtotal.Text = CStr(subtotal1)
        'Dim total As Decimal
        'If Not (txtimportetotal.Text = String.Empty) Then
        '    total = CDec(txtimportetotal.Text)
        'Else
        '    total = 0
        'End If
        'total += subtotal1
        'txtimportetotal.Text = total

        'Dim subtotal As Decimal
        'For i = 0 To dtDOS.Rows.Count - 1
        '    If Not (dtDOS.Rows(i).RowState = DataRowState.Deleted) Then
        '        subtotal += CDec(dtDOS.Rows(i).Item("precio")) * CDec(dtDOS.Rows(i).Item("cantidad"))
        '    End If
        'Next
        'txtsubtot.Text = subtotal

        'If Not (txtimportetotal.Text = String.Empty) Then
        '    total = CDec(txtimportetotal.Text)
        'Else
        '    total = 0
        'End If
        'total += subtotal
        'txtimportetotal.Text = total
        'txtprioridad.Enabled = False
        '???????????????? Tambien hay que calcular el id del objeto del servicio
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        UltraGroupBox1.Enabled = True
        UltraGroupBox2.Enabled = True
        btnguardar.Enabled = True
        txtprioridad.Enabled = True
        cmbestado.Enabled = True
        bandeabm = True
        btnmodificar.Enabled = False
        cmbformadeentrega.Enabled = True
        dtpfechaentrega.Enabled = True
        idOBJ = calcularidobj()
    End Sub

    Private Sub UltraGroupBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGroupBox1.Click

    End Sub

    Private Sub UltraGroupBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGroupBox3.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        UltraGroupBox1.Visible = True
        UltraGroupBox2.Visible = True
        UltraGroupBox4.Visible = False
        UltraGroupBox5.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        UltraGroupBox1.Visible = False
        UltraGroupBox2.Visible = False
        UltraGroupBox4.Visible = True
        UltraGroupBox5.Visible = True
    End Sub

    Private Sub UltraGroupBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGroupBox5.Click

    End Sub

    Private Sub UltraGroupBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGroupBox4.Click

    End Sub

    Private Sub botnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botnuevo.Click
        txtitem.Enabled = True
        txtdescripcion.Enabled = True
        txtcantidad.Enabled = True
    End Sub

    Private Sub botagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botagregar.Click
        Dim i As Integer
        Dim b As Boolean
        b = False
        For i = 0 To dtoperacion.Rows.Count - 1
            If dtoperacion.Rows(i).Item("select") = "Y" Then
                b = True
            End If

        Next
        If b = False Then
            MsgBox("seleccione un servicio")
            Exit Sub
        End If
        Dim dr2 As DataRow = ds.Tables("OBJ").NewRow
        idOBJ = CInt(idOBJ) + 1
        If txtitem.Text = String.Empty Then
            dr2("idobjetodelservicio") = idOBJ
            dr2("nombre") = dtfresasfab.Rows(dgfresafab.CurrentRowIndex).Item("nombre")
            dr2("cantidad") = 1
            dr2("nroserie") = dtfresasfab.Rows(dgfresafab.CurrentRowIndex).Item("nroserie")
            ds.Tables("OBJ").Rows.Add(dr2)
            For i = 0 To dtoperacion.Rows.Count - 1
                If dtoperacion.Rows(i).Item("select") = "Y" Then
                    Dim dr1 As DataRow = dtDOS.NewRow
                    dr1("idpedido") = CLng(lbnropedido.Text)
                    dr1("idoperacion") = dtoperacion.Rows(i).Item("idoperacion")
                    dr1("idobjetodelservicio") = idOBJ
                    dr1("item") = dtfresasfab.Rows(dgfresafab.CurrentRowIndex).Item("nombre")
                    dr1("operacion") = dtoperacion.Rows(i).Item("nombre")
                    dr1("cantidad") = 1
                    dr1("nroserie") = dtfresasfab.Rows(dgfresafab.CurrentRowIndex).Item("nroserie")
                    If Not (dtoperacion.Rows(i).Item("precio") = String.Empty) Then
                        dr1("precio") = CDec(dtoperacion.Rows(i).Item("precio"))
                    Else
                        MsgBox("Falta Precio de Servicio")
                        Exit Sub
                    End If
                    dtDOS.Rows.Add(dr1)
                End If
            Next
        End If
        If Not (txtitem.Text = String.Empty) Then
            dr2("idobjetodelservicio") = idOBJ
            dr2("nombre") = txtitem.Text
            dr2("cantidad") = CInt(txtcantidad.Text)
            ds.Tables("OBJ").Rows.Add(dr2)
            For i = 0 To dtoperacion.Rows.Count - 1
                If dtoperacion.Rows(i).Item("select") = "Y" Then
                    Dim dr1 As DataRow = dtDOS.NewRow
                    dr1("idpedido") = CLng(lbnropedido.Text)
                    dr1("idoperacion") = dtoperacion.Rows(i).Item("idoperacion")
                    dr1("idobjetodelservicio") = idOBJ
                    dr1("item") = txtitem.Text
                    dr1("operacion") = dtoperacion.Rows(i).Item("nombre")
                    If txtcantidad.Text = "" Then
                        MsgBox("Ingrese cantidad")
                        Exit Sub
                    End If
                    dr1("cantidad") = CInt(txtcantidad.Text)
                    If Not (dtoperacion.Rows(i).Item("precio") = String.Empty) Then
                        dr1("precio") = CDec(dtoperacion.Rows(i).Item("precio"))
                    Else
                        MsgBox("Falta Precio de Servicio")
                        Exit Sub
                    End If
                    dtDOS.Rows.Add(dr1)
                End If
            Next
        End If
        For i = 0 To dtoperacion.Rows.Count - 1
            dtoperacion.Rows(i).Item("select") = "N"
        Next
        Dim subtotal As Decimal
        For i = 0 To dtDOS.Rows.Count - 1
            If Not (dtDOS.Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += CDec(dtDOS.Rows(i).Item("precio")) * CDec(dtDOS.Rows(i).Item("cantidad"))
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
        txtdescripcion.Text = ""
        txtcantidad.Text = ""
        txtitem.Enabled = False
        txtdescripcion.Enabled = False
        txtcantidad.Enabled = False

    End Sub

    Private Sub botquitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botquitar.Click
        dtDOS.Rows(Me.dgDETOS.CurrentRowIndex).Delete()
    End Sub

    Private Sub dgclientes_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgclientes.Navigate

    End Sub

    Private Sub dgclientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgclientes.CurrentCellChanged
        If bnuevo = True Then
            txtcliente.Text = dgclientes.Item(dgclientes.CurrentRowIndex, 4)
        End If

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim str As String
        Dim b As Boolean
        b = False
        If chkapellido.Checked = True Then
            If b = False Then
                b = True
                str = "apellido='" & txtapellido.Text & "'"
            Else
                str &= " and apellido='" & txtapellido.Text & "'"

            End If

        End If
        If chknombre.Checked = True Then
            If b = False Then
                b = True
                str = "nombre='" & txtnombre.Text & "'"
            Else
                str &= " and nombre='" & txtnombre.Text & "'"

            End If
        End If
        If b = False Then
            dvclientes.RowFilter = Nothing
        Else
            dvclientes.RowFilter = str
        End If
        dgclientes.Focus()
    End Sub

    Private Sub chkapellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkapellido.CheckedChanged
        If chkapellido.Checked = False Then
            txtapellido.Enabled = False
        Else
            txtapellido.Enabled = True
        End If
    End Sub

    Private Sub chkapellido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkapellido.Click

    End Sub

    Private Sub chknombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknombre.CheckedChanged
        If chknombre.Checked = False Then
            txtnombre.Enabled = False
        Else
            txtnombre.Enabled = True
        End If
    End Sub

    Private Sub chknombre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chknombre.Click

    End Sub

    Private Sub dgclientes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgclientes.LostFocus
        If dvclientes.Count > 0 Then
            If bnuevo = True Then
                txtcliente.Text = dgclientes.Item(dgclientes.CurrentRowIndex, 4)
            End If
        End If
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim str As String
        Dim b As Boolean
        b = False
        Try
            If chkfecharealizacion.Checked = True Then
                If txtfecharealizacion.Text = String.Empty Then
                    MsgBox("Falta Fecha")
                    Exit Sub
                End If
                If b = False Then
                    b = True
                    str = "fecharealizacion=#" & Format(CDate(txtfecharealizacion.Text), "MM/dd/yyyy") & "#"
                Else
                    str &= " and fecharealizacion=#" & Format(CDate(txtfecharealizacion.Text), "MM/dd/yyyy") & "#"

                End If

            End If
            If chkfechaentrega.Checked = True Then
                If txtfechaentrega.Text = String.Empty Then
                    MsgBox("faltafecha")
                    Exit Sub
                End If
                If b = False Then
                    b = True
                    str = "fechaentrega=#" & Format(CDate(txtfechaentrega.Text), "MM/dd/yyyy") & "#"
                Else
                    str &= " and fechaentrega=#" & Format(CDate(txtfechaentrega.Text), "MM/dd/yyyy") & "#"
                End If
            End If
            If b = False Then
                dvpedidos.RowFilter = Nothing
            Else
                dvpedidos.RowFilter = str
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'dgpedidos.Focus()
    End Sub

    Private Sub dgpedidos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgpedidos.LostFocus
        Dim cmd As New SqlCommand
        Dim i As Integer
        Dim j As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        Dim str As String = "select fresa.* from fresa where fresa.nropedido =" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        ds.Tables("fresa").Clear()
        dafresa = New SqlDataAdapter(str, cnn)
        dafresa.Fill(ds, "fresa")

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
        dapartepedida = New SqlDataAdapter(str, cnn)
        dapartepedida.Fill(ds, "partepedida")
        For j = 0 To ds.Tables("partepedida").Rows.Count - 1
            For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
                If ds.Tables("partepedida").Rows(j).Item("idadicional") = ds.Tables("parteadicional").Rows(i).Item("idadicional") And _
                ds.Tables("partepedida").Rows(j).Item("idmodelo") = ds.Tables("parteadicional").Rows(i).Item("idmodelo") Then
                    ds.Tables("partepedida").Rows(j).Item("nombre") = ds.Tables("parteadicional").Rows(i).Item("nombre")
                End If
            Next
        Next

        ds.Tables("pedido").Clear()
        dapedido = New SqlDataAdapter("select * from pedido where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)), cnn)
        dapedido.Fill(ds, "pedido")
        dtpedido = ds.Tables("pedido")
        idcliente = dtpedido.Rows(0).Item("idcliente")


        cmd.CommandText = "select documento from cliente where idcliente=" & idcliente
        cmd.Connection = cnn

        txtcliente.Text = CStr(cmd.ExecuteScalar)
        txtprioridad.Text = dtpedido.Rows(0).Item("prioridad")
        lbnropedido.Text = CStr(dtpedido.Rows(0).Item("idpedido"))
        cmbestado.SelectedValue = dtpedido.Rows(0).Item("idestado")
        dtpfechaentrega.Value = CDate(dtpedido.Rows(0).Item("fechaentrega"))
        cmbformadeentrega.SelectedValue = dtpedido.Rows(0).Item("idformadeentrega")
        cmbformadeentrega.Enabled = False
        dtpfechaentrega.Enabled = False
        cmbestado.Enabled = False
        lbfecha.Text = CStr(dtpedido.Rows(0).Item("fecharealizacion"))
        cmd.CommandText = "select max(idpartepedida) from partepedido where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        idpartepedida = cmd.ExecuteScalar
        If IsDBNull(idpartepedida) Then
            idpartepedida = 0
        End If
        cnn.Close()
        btnguardar.Enabled = False
        txtcliente.Enabled = False
        UltraGroupBox1.Enabled = False
        UltraGroupBox2.Enabled = False
        bandeabm = True
        btnmodificar.Enabled = True
        nroserie = calcularnroserie()
        idOBJ = calcularidobj()
        ds.Tables("DOS").Clear()
        str = "select * from detalleordenservicio where idpedido=" & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0))
        daDOS = New SqlDataAdapter(str, cnn)
        daDOS.Fill(ds, "DOS")
        ds.Tables("OBJ").Clear()
        str = "select * from objetodelservicio where idobjetodelservicio in (select idobjetodelservicio from detalleordenservicio" _
        & " where idpedido= " & CLng(dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)) & ")"
        '¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡
        daOBJ = New SqlDataAdapter(str, cnn)
        daOBJ.Fill(ds, "OBJ")
        For i = 0 To ds.Tables("DOS").Rows.Count - 1
            For j = 0 To ds.Tables("OBJ").Rows.Count - 1
                If ds.Tables("DOS").Rows(i).Item("idobjetodelservicio") = ds.Tables("OBJ").Rows(j).Item("idobjetodelservicio") Then
                    ds.Tables("DOS").Rows(i).Item("item") = ds.Tables("OBJ").Rows(j).Item("nombre")
                    ds.Tables("DOS").Rows(i).Item("cantidad") = ds.Tables("OBJ").Rows(j).Item("cantidad")
                End If
            Next
        Next
        For i = 0 To ds.Tables("DOS").Rows.Count - 1
            For j = 0 To ds.Tables("operacion").Rows.Count - 1
                If ds.Tables("DOS").Rows(i).Item("idoperacion") = ds.Tables("operacion").Rows(j).Item("idoperacion") Then
                    ds.Tables("DOS").Rows(i).Item("operacion") = ds.Tables("operacion").Rows(j).Item("nombre")
                End If
            Next
        Next

        txtimportetotal.Text = ""
        Dim subtotal1 As Decimal
        For i = 0 To dtfresa.Rows.Count - 1
            subtotal1 += dtfresa.Rows(i).Item("precio")
        Next
        For i = 0 To dtpartepedida.Rows.Count - 1
            subtotal1 += CInt(dtpartepedida.Rows(i).Item("cantidad")) * CDec(dtpartepedida.Rows(i).Item("precio"))
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
        For i = 0 To dtDOS.Rows.Count - 1
            If Not (dtDOS.Rows(i).RowState = DataRowState.Deleted) Then
                subtotal += CDec(dtDOS.Rows(i).Item("precio")) * CDec(dtDOS.Rows(i).Item("cantidad"))
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

    Private Sub chkfecharealizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfecharealizacion.CheckedChanged
        If chkfecharealizacion.Checked = True Then
            txtfecharealizacion.Enabled = True
        Else
            txtfecharealizacion.Enabled = False
        End If
    End Sub

    Private Sub chkfechaentrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfechaentrega.CheckedChanged
        If chkfechaentrega.Checked = True Then
            txtfechaentrega.Enabled = True
        Else
            txtfechaentrega.Enabled = False
        End If
    End Sub

    Private Sub dgparteadicional_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgparteadicional.KeyPress


    End Sub

    Private Sub txtcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcliente.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
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

    Private Sub txtprioridad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprioridad.ValueChanged

    End Sub

    Private Sub txtprioridad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprioridad.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfecharealizacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfecharealizacion.ValueChanged

    End Sub

    Private Sub txtfecharealizacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfecharealizacion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(validarfecha(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfechaentrega_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfechaentrega.ValueChanged

    End Sub

    Private Sub txtfechaentrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfechaentrega.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(validarfecha(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
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

    Private Sub txtapellido_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellido.ValueChanged

    End Sub

    Private Sub txtapellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapellido.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.ValueChanged

    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Frmpedidofresa_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub dgpedidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgpedidos.DoubleClick
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub dgclientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgclientes.DoubleClick
        TabControl1.SelectedIndex = 0
    End Sub
End Class
