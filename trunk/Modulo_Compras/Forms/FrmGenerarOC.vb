Imports System.Data.SqlClient

Public Class FrmGenerarOC
    Inherits System.Windows.Forms.Form
    Dim SQLconn As New SqlConnection("Server=localhost;" & _
        "DataBase=afilar;" & _
        "Integrated Security=SSPI")
    Dim DS As New DataSet
    Dim dtMP As New DataTable
    Dim dtOC As New DataTable
    Dim dtDOC As New DataTable
    Dim dtProv As New DataTable
    Dim dtproxmp As New DataTable
    Dim dvMP As New DataView
    Dim dvOC As New DataView
    Dim dvDOC As New DataView
    Dim dvProv As New DataView
    Dim dvproxmp As New DataView
    Dim SQLdataadapter1 As New SqlDataAdapter("select idtipomateriaprima as ID, nombre as Nombre, stockactual, stockminimo, loteeconomico, idunidadmedida, clase from tipomateriaprima ", cnn)
    Dim Sqldataadapter2 As New SqlDataAdapter("select * from ordencompramp where  1=2", cnn)
    Dim SQLdataadapter3 As New SqlDataAdapter("select * from detalleordencompra where 1=2", cnn)
    Dim SQLdataadapter4 As New SqlDataAdapter("select * from unidaddemedida", cnn)
    Dim SQLdataadapter5 As New SqlDataAdapter("select idtipomateriaprima, nombre, proveedor.idproveedor from proveedor inner join proveedorxtipomateriaprima on proveedorxtipomateriaprima.idproveedor = proveedor.idproveedor", cnn)
    Dim SQLdataadapter6 As New SqlDataAdapter("select * from proveedor", cnn)
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UltraPictureBox4 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraPictureBox3 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraPictureBox2 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Dim SQLdataadapter7 As New SqlDataAdapter("select max(idordencompra) from ordencompramp ", cnn)

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
    Friend WithEvents UltraCalendarCombo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents BtnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnAceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPrevisualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GrdMP As System.Windows.Forms.DataGrid
    Friend WithEvents grdOC As System.Windows.Forms.DataGrid
    Friend WithEvents GrdDOC As System.Windows.Forms.DataGrid
    Friend WithEvents ultraCmbProovedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCantidad As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TxtPrecio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents CmbFormapago As Infragistics.Win.UltraWinEditors.UltraComboEditor
    'Friend WithEvents DataSetOC1 As Afilar.DataSetOC
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents SqlDataAdapter8 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Dsoc1 As Afilar.dsoc
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Dsoc2 As Afilar.dsoc

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerarOC))
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.UltraPictureBox4 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraPictureBox3 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraPictureBox2 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.CmbFormapago = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.TxtPrecio = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.CmbCantidad = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.BtnAgregar = New Infragistics.Win.Misc.UltraButton
        Me.GrdMP = New System.Windows.Forms.DataGrid
        Me.UltraCalendarCombo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.ultraCmbProovedor = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.grdOC = New System.Windows.Forms.DataGrid
        Me.GrdDOC = New System.Windows.Forms.DataGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BtnAceptar = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrevisualizar = New Infragistics.Win.Misc.UltraButton
        Me.BtnSalir = New Infragistics.Win.Misc.UltraButton
        Me.SqlDataAdapter8 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.Dsoc2 = New Afilar.dsoc
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.CmbFormapago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCalendarCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultraCmbProovedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.grdOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.Dsoc2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(782, 489)
        '
        'UltraGroupBox3
        '
        Appearance1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance1
        Me.UltraGroupBox3.Controls.Add(Me.Label9)
        Me.UltraGroupBox3.Controls.Add(Me.Label8)
        Me.UltraGroupBox3.Controls.Add(Me.Label7)
        Me.UltraGroupBox3.Controls.Add(Me.Label6)
        Me.UltraGroupBox3.Controls.Add(Me.UltraPictureBox4)
        Me.UltraGroupBox3.Controls.Add(Me.UltraPictureBox3)
        Me.UltraGroupBox3.Controls.Add(Me.UltraPictureBox2)
        Me.UltraGroupBox3.Controls.Add(Me.UltraPictureBox1)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(653, 214)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(110, 167)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 15
        Me.UltraGroupBox3.Text = "Referencia"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(25, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "MP Tipo ""C"""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(25, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "MP Tipo ""B"""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(25, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "MP Tipo ""A"""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(25, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "MP Critica"
        '
        'UltraPictureBox4
        '
        Me.UltraPictureBox4.BackColor = System.Drawing.Color.Red
        Me.UltraPictureBox4.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox4.Location = New System.Drawing.Point(8, 59)
        Me.UltraPictureBox4.Name = "UltraPictureBox4"
        Me.UltraPictureBox4.Size = New System.Drawing.Size(11, 14)
        Me.UltraPictureBox4.TabIndex = 3
        '
        'UltraPictureBox3
        '
        Me.UltraPictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.UltraPictureBox3.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox3.Location = New System.Drawing.Point(8, 89)
        Me.UltraPictureBox3.Name = "UltraPictureBox3"
        Me.UltraPictureBox3.Size = New System.Drawing.Size(11, 14)
        Me.UltraPictureBox3.TabIndex = 2
        '
        'UltraPictureBox2
        '
        Me.UltraPictureBox2.BackColor = System.Drawing.Color.Green
        Me.UltraPictureBox2.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox2.Location = New System.Drawing.Point(8, 119)
        Me.UltraPictureBox2.Name = "UltraPictureBox2"
        Me.UltraPictureBox2.Size = New System.Drawing.Size(11, 14)
        Me.UltraPictureBox2.TabIndex = 1
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox1.Location = New System.Drawing.Point(8, 29)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(11, 14)
        Me.UltraPictureBox1.TabIndex = 0
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(653, 394)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(110, 56)
        Me.UltraButton3.TabIndex = 16
        Me.UltraButton3.Text = "&Ordenes de compra"
        '
        'UltraGroupBox1
        '
        Appearance2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance2
        Me.UltraGroupBox1.Controls.Add(Me.CmbFormapago)
        Me.UltraGroupBox1.Controls.Add(Me.TxtPrecio)
        Me.UltraGroupBox1.Controls.Add(Me.CmbCantidad)
        Me.UltraGroupBox1.Controls.Add(Me.BtnAgregar)
        Me.UltraGroupBox1.Controls.Add(Me.GrdMP)
        Me.UltraGroupBox1.Controls.Add(Me.UltraCalendarCombo1)
        Me.UltraGroupBox1.Controls.Add(Me.ultraCmbProovedor)
        Me.UltraGroupBox1.Controls.Add(Me.CmbProveedor)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.Label4)
        Me.UltraGroupBox1.Controls.Add(Me.Label5)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(24, 24)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(741, 184)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 9
        Me.UltraGroupBox1.Text = "Materia prima"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'CmbFormapago
        '
        Me.CmbFormapago.AutoSize = True
        Me.CmbFormapago.Location = New System.Drawing.Point(560, 104)
        Me.CmbFormapago.Name = "CmbFormapago"
        Me.CmbFormapago.Size = New System.Drawing.Size(160, 21)
        Me.CmbFormapago.TabIndex = 19
        Me.CmbFormapago.Text = "--Forma de pago--"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.AutoSize = True
        Me.TxtPrecio.Location = New System.Drawing.Point(560, 56)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(160, 21)
        Me.TxtPrecio.TabIndex = 18
        Me.TxtPrecio.Text = "--Precio unitario--"
        '
        'CmbCantidad
        '
        Me.CmbCantidad.AutoSize = True
        Me.CmbCantidad.Location = New System.Drawing.Point(560, 80)
        Me.CmbCantidad.Name = "CmbCantidad"
        Me.CmbCantidad.Size = New System.Drawing.Size(160, 21)
        Me.CmbCantidad.TabIndex = 17
        Me.CmbCantidad.Text = "--Cantidad--"
        '
        'BtnAgregar
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.BtnAgregar.Appearance = Appearance3
        Me.BtnAgregar.Location = New System.Drawing.Point(366, 156)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(80, 24)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "&Agregar"
        '
        'GrdMP
        '
        Me.GrdMP.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.GrdMP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GrdMP.BackgroundColor = System.Drawing.Color.LightGray
        Me.GrdMP.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.GrdMP.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdMP.DataMember = ""
        Me.GrdMP.FlatMode = True
        Me.GrdMP.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GrdMP.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdMP.GridLineColor = System.Drawing.Color.Gainsboro
        Me.GrdMP.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.GrdMP.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.GrdMP.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GrdMP.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrdMP.LinkColor = System.Drawing.Color.Teal
        Me.GrdMP.Location = New System.Drawing.Point(16, 32)
        Me.GrdMP.Name = "GrdMP"
        Me.GrdMP.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.GrdMP.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.GrdMP.ReadOnly = True
        Me.GrdMP.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.GrdMP.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrdMP.Size = New System.Drawing.Size(430, 120)
        Me.GrdMP.TabIndex = 0
        '
        'UltraCalendarCombo1
        '
        Me.UltraCalendarCombo1.BackColor = System.Drawing.SystemColors.Window
        DateButton1.Caption = "Today"
        Me.UltraCalendarCombo1.DateButtons.Add(DateButton1)
        Me.UltraCalendarCombo1.Location = New System.Drawing.Point(560, 128)
        Me.UltraCalendarCombo1.Name = "UltraCalendarCombo1"
        Me.UltraCalendarCombo1.NonAutoSizeHeight = 16
        Me.UltraCalendarCombo1.Size = New System.Drawing.Size(160, 21)
        Me.UltraCalendarCombo1.TabIndex = 5
        Me.UltraCalendarCombo1.Value = New Date(2005, 10, 7, 0, 0, 0, 0)
        '
        'ultraCmbProovedor
        '
        Me.ultraCmbProovedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ultraCmbProovedor.DisplayMember = ""
        Me.ultraCmbProovedor.Location = New System.Drawing.Point(753, 32)
        Me.ultraCmbProovedor.Name = "ultraCmbProovedor"
        Me.ultraCmbProovedor.Size = New System.Drawing.Size(160, 21)
        Me.ultraCmbProovedor.TabIndex = 1
        Me.ultraCmbProovedor.Text = "--Proveedor--"
        Me.ultraCmbProovedor.ValueMember = ""
        '
        'CmbProveedor
        '
        Me.CmbProveedor.Location = New System.Drawing.Point(560, 32)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(160, 21)
        Me.CmbProveedor.TabIndex = 16
        Me.CmbProveedor.Text = "--Proveedor--"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(487, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Precio unitario:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(511, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(482, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Forma de pago:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(469, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Fecha de entrega:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(506, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Proveedor:"
        '
        'UltraGroupBox2
        '
        Appearance4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance4
        Me.UltraGroupBox2.Controls.Add(Me.UltraButton2)
        Me.UltraGroupBox2.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox2.Controls.Add(Me.grdOC)
        Me.UltraGroupBox2.Controls.Add(Me.GrdDOC)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(24, 216)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(623, 272)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 14
        Me.UltraGroupBox2.Text = "Orden de compra de materia prima"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton2
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButton2.Appearance = Appearance5
        Me.UltraButton2.Location = New System.Drawing.Point(450, 178)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(112, 24)
        Me.UltraButton2.TabIndex = 9
        Me.UltraButton2.Text = "&Eliminar pedido"
        '
        'UltraButton1
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.UltraButton1.Appearance = Appearance6
        Me.UltraButton1.Location = New System.Drawing.Point(450, 210)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(112, 24)
        Me.UltraButton1.TabIndex = 8
        Me.UltraButton1.Text = "&Eliminar item"
        '
        'grdOC
        '
        Me.grdOC.BackgroundColor = System.Drawing.Color.LightGray
        Me.grdOC.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdOC.CaptionText = "Pedido"
        Me.grdOC.DataMember = ""
        Me.grdOC.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdOC.Location = New System.Drawing.Point(16, 32)
        Me.grdOC.Name = "grdOC"
        Me.grdOC.ReadOnly = True
        Me.grdOC.Size = New System.Drawing.Size(591, 120)
        Me.grdOC.TabIndex = 6
        '
        'GrdDOC
        '
        Me.GrdDOC.BackgroundColor = System.Drawing.Color.LightGray
        Me.GrdDOC.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.GrdDOC.CaptionText = "Detalle de pedido"
        Me.GrdDOC.DataMember = ""
        Me.GrdDOC.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GrdDOC.Location = New System.Drawing.Point(16, 160)
        Me.GrdDOC.Name = "GrdDOC"
        Me.GrdDOC.ReadOnly = True
        Me.GrdDOC.Size = New System.Drawing.Size(398, 96)
        Me.GrdDOC.TabIndex = 7
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.crv)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(782, 489)
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Location = New System.Drawing.Point(8, 16)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(688, 464)
        Me.crv.TabIndex = 15
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'BtnAceptar
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.BtnAceptar.Appearance = Appearance7
        Me.BtnAceptar.Location = New System.Drawing.Point(483, 528)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(80, 24)
        Me.BtnAceptar.TabIndex = 10
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnPrevisualizar
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.BtnPrevisualizar.Appearance = Appearance8
        Me.BtnPrevisualizar.Location = New System.Drawing.Point(569, 528)
        Me.BtnPrevisualizar.Name = "BtnPrevisualizar"
        Me.BtnPrevisualizar.Size = New System.Drawing.Size(80, 24)
        Me.BtnPrevisualizar.TabIndex = 12
        Me.BtnPrevisualizar.Text = "&Previa"
        '
        'BtnSalir
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.BtnSalir.Appearance = Appearance9
        Me.BtnSalir.Location = New System.Drawing.Point(707, 528)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 24)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "&Salir"
        '
        'SqlDataAdapter8
        '
        Me.SqlDataAdapter8.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter8.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ordencompramp", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("Expr3", "Expr3"), New System.Data.Common.DataColumnMapping("fecharealizacion", "fecharealizacion"), New System.Data.Common.DataColumnMapping("plazodeentrega", "plazodeentrega"), New System.Data.Common.DataColumnMapping("idordencompra", "idordencompra"), New System.Data.Common.DataColumnMapping("nroorden", "nroorden"), New System.Data.Common.DataColumnMapping("condicionesdepago", "condicionesdepago"), New System.Data.Common.DataColumnMapping("causa", "causa"), New System.Data.Common.DataColumnMapping("idestado", "idestado"), New System.Data.Common.DataColumnMapping("idproveedor", "idproveedor"), New System.Data.Common.DataColumnMapping("Expr4", "Expr4"), New System.Data.Common.DataColumnMapping("idtipomateriaprima", "idtipomateriaprima"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("Expr5", "Expr5")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
            "filar;persist security info=False"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'UltraTabControl1
        '
        Appearance10.BackColor = System.Drawing.Color.Silver
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance11.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance12
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(786, 512)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 17
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Orden de compra"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Visualizacion"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(782, 489)
        '
        'Dsoc2
        '
        Me.Dsoc2.DataSetName = "dsoc"
        Me.Dsoc2.Locale = New System.Globalization.CultureInfo("es-AR")
        Me.Dsoc2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmGenerarOC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(799, 560)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnPrevisualizar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "FrmGenerarOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Generar órden de compra"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.CmbFormapago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCalendarCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultraCmbProovedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.grdOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.Dsoc2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmGenerarOC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)

        cnn.Open()
        SQLdataadapter1.Fill(DS, "tipomateriaprima")
        Sqldataadapter2.Fill(DS, "ordencompramp")
        SQLdataadapter3.Fill(DS, "detalleordencompra")
        SQLdataadapter4.Fill(DS, "unidaddemedida")
        SQLdataadapter5.Fill(DS, "proxmp")
        SQLdataadapter6.Fill(DS, "proov")
        SQLdataadapter7.Fill(DS, "oc_id")
        cnn.Close()
        dtMP = DS.Tables("tipomateriaprima")
        dtOC = DS.Tables("ordencompramp")
        dtDOC = DS.Tables("detalleordencompra")
        dtProv = DS.Tables("proov")
        dtproxmp = DS.Tables("proxmp")
        dvMP = dtMP.DefaultView
        dvOC = dtOC.DefaultView
        dvDOC = dtDOC.DefaultView
        dvProv = dtProv.DefaultView
        dvproxmp = dtproxmp.DefaultView
        Me.CargarGrdMP()
        cargarGrdOC()
        GrdDocCargar()
        Me.grdOC.DataSource = dtOC
        Me.GrdDOC.DataSource = dtDOC
        CmbFormaPago_cargar()
        ' Dim col() As Integer = {1, 2, 3, 4}

        'cargarLista(Me.ListView1, "select idtipomateriaprima as ID, nombre as Nombre, stockactual, stockminimo, loteeconomico, idunidadmedida from tipomateriaprima ", 0, col)


    End Sub
    Sub cargarGrdOC()
        Me.grdOC.CaptionText = "Pedido por proveedor"
        Me.grdOC.DataSource = dtOC



        grdOC.TableStyles.Clear()

        Dim grdTableStyle1 As New DataGridTableStyle
        grdTableStyle1.MappingName = dtOC.TableName
        'DS.Tables("tipomateriaprima").TableName


        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .MappingName = "idordencompra"
            .HeaderText = "Orden de compra"
            .Width = 80
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .MappingName = "fecharealizacion"
            .HeaderText = "Fecha Realizacion"
            .Width = 120
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .MappingName = "plazodeentrega"
            .HeaderText = "Plazo de Entrega"
            .Width = 120
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .MappingName = "condicionesdepago"
            .HeaderText = "Condicion de Pago"
            .Width = 150
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .MappingName = "idproveedor"
            .HeaderText = "Proveedor Nº"
            .Width = 80
        End With


        grdTableStyle1.GridColumnStyles.AddRange(New DataGridColumnStyle() {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5})
        grdOC.TableStyles.Add(grdTableStyle1)

    End Sub
    Private Sub GrdDocCargar()
        Me.GrdDOC.CaptionText = "Detalle de pedido"
        Me.GrdDOC.DataSource = dtDOC



        GrdDOC.TableStyles.Clear()

        Dim grdTableStyle1 As New DataGridTableStyle
        grdTableStyle1.MappingName = dtDOC.TableName
        'DS.Tables("tipomateriaprima").TableName


        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .MappingName = "idordencompra"
            .HeaderText = "Orden de compra"
            .Width = 80
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .MappingName = "idtipomateriaprima"
            .HeaderText = "Nº Materia prima"
            .Width = 80
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .MappingName = "cantidad"
            .HeaderText = "Cantidad"
            .Width = 100
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .MappingName = "precio"
            .HeaderText = "Precio"
            .Width = 100
        End With




        grdTableStyle1.GridColumnStyles.AddRange(New DataGridColumnStyle() {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4})
        GrdDOC.TableStyles.Add(grdTableStyle1)

    End Sub
    Sub CargarGrdMP()

        Me.GrdMP.CaptionText = "Materia prima"
        Me.GrdMP.DataSource = dvMP



        GrdMP.TableStyles.Clear()

        Dim grdTableStyle1 As New DataGridTableStyle
        grdTableStyle1.MappingName = dvMP.Table.TableName
        'DS.Tables("tipomateriaprima").TableName


        'Dim grdColStyle1 As New DataGridTextBoxColumn
        Dim grdColStyle1 As New CustomDataGridTextBoxColumn
        With grdColStyle1
            .MappingName = "nombre"
            .HeaderText = "nombre"
            .Width = 150
        End With

        'Dim grdColStyle2 As New DataGridTextBoxColumn
        Dim grdColStyle2 As New CustomDataGridTextBoxColumn
        With grdColStyle2
            .MappingName = "stockactual"
            .HeaderText = "Stock actual"
            .Width = 80
        End With

        'Dim grdColStyle3 As New DataGridTextBoxColumn
        Dim grdColStyle3 As New CustomDataGridTextBoxColumn
        With grdColStyle3
            .MappingName = "stockminimo"
            .HeaderText = "Stock minimo"
            .Width = 80
        End With
        '

        'Dim grdColStyle4 As New DataGridTextBoxColumn
        Dim grdColStyle4 As New CustomDataGridTextBoxColumn
        With grdColStyle4
            .MappingName = "Clase"
            .HeaderText = "Tipo de materia prima"
            .Width = 80
        End With
        '

        AddHandler grdColStyle1.PaintRow, AddressOf EstablecerColores
        AddHandler grdColStyle2.PaintRow, AddressOf EstablecerColores
        AddHandler grdColStyle3.PaintRow, AddressOf EstablecerColores
        AddHandler grdColStyle4.PaintRow, AddressOf EstablecerColores

        '
        grdTableStyle1.GridColumnStyles.AddRange(New DataGridColumnStyle() {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4})
        GrdMP.TableStyles.Add(grdTableStyle1)
        '*********************************************************

        'Marcar_MP_Critica()

    End Sub
    Private Sub EstablecerColores(ByVal args As PaintRowEventArgs)
        args.BackColor = Brushes.LightGray
        If Me.GrdMP.Item(args.RowNumber, 1) < Me.GrdMP.Item(args.RowNumber, 2) Then
            'args.ForeColor = Brushes.Red
            args.BackColor = Brushes.LightSalmon
        End If
        If Not IsDBNull(Me.GrdMP.Item(args.RowNumber, 3)) Then
            Select Case Me.GrdMP.Item(args.RowNumber, 3)
                Case "A"
                    args.ForeColor = Brushes.Red
                Case "B"
                    args.ForeColor = Brushes.Yellow
                Case "C"
                    args.ForeColor = Brushes.Green
            End Select
        End If

    End Sub

    Private Sub MarcarMPCritica()
        Dim fila As DataRow
        For Each fila In dvMP.Table.Rows
            If fila.Item("stockactual") < fila.Item("stockminimo") Then

            End If
        Next
    End Sub





    Private Sub GrdMP_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdMP.CurrentCellChanged
        GrdMP.Select(GrdMP.CurrentCell.RowNumber)
        CmbProveedor_cargar(dvMP(GrdMP.CurrentRowIndex)("id"))
        CmbCantidad_cargar(dvMP(GrdMP.CurrentRowIndex)("id"), dvMP(GrdMP.CurrentRowIndex)("idunidadmedida"))
        'Mostrar_UnidadMedidda(dvMP(GrdMP.CurrentRowIndex)("idunidadmedida"))

    End Sub
    Private Sub CmbProveedor_cargar(ByVal id As Integer)
        dvproxmp.RowFilter = "idtipomateriaprima = " & id
        With CmbProveedor 'ultracmbproveedor no andaaaaaaaaa!!!!!!!!!!!
            .DataSource = dvproxmp
            .DisplayMember = "nombre"
            .ValueMember = "idproveedor"
        End With
    End Sub

    Private Sub CmbCantidad_cargar(ByVal id As Integer, ByVal idunid As Integer)
        Me.CmbCantidad.Items.Clear()
        Dim dv As New DataView
        dv.Table = DS.Tables("tipomateriaprima")
        dv.RowFilter = "id =" & id
        If dv.Count <> 0 Then
            Me.CmbCantidad.Items.Add(dv.Item(0).Item(4) & "  " & Mostrar_UnidadMedidda(idunid))
        End If
        Me.CmbCantidad.SelectedIndex = 0

    End Sub



    Private Sub CmbFormaPago_cargar()
        Me.CmbFormapago.Items.Add("Contado")
        Me.CmbFormapago.Items.Add("Cuenta corriente")
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If check() Then
            Cargar_OC(Me.CmbProveedor.SelectedValue, dvMP(GrdMP.CurrentRowIndex)("id"), Me.TxtPrecio.Text, Val(Me.CmbCantidad.Text), Me.CmbFormapago.Text, Me.UltraCalendarCombo1.Value)
        End If
    End Sub
    Private Function check() As Boolean
        If Me.CmbProveedor.Text = "--Proveedor--" Or Me.CmbProveedor.Text = "" Then
            MsgBox("No existen proveedores para el material seleccionado", MsgBoxStyle.Exclamation)
            Return False
        End If
        If Me.CmbFormapago.Text = "--Forma de pago--" Or Me.CmbFormapago.Text = "" Then
            MsgBox("Por favor ingrese la forma de pago", MsgBoxStyle.Exclamation)
            Return False
        End If
        If Me.CmbCantidad.Text = "--Cantidad--" Or Me.CmbCantidad.Text = "" Then
            MsgBox("Indique la cantidad de materia prima a ordenar", MsgBoxStyle.Exclamation)
            Return False
        End If
        If Me.TxtPrecio.Text = "--Precio unitario--" Or Not IsNumeric(Me.TxtPrecio.Text) Then
            MsgBox("Indique el precio unitario del material", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True

    End Function
    Private Sub Cargar_OC(ByVal idpro As Integer, ByVal idmp As Integer, ByVal pre As Integer, ByVal cant As Integer, ByVal fpago As String, ByVal fecha As Date)
        Dim x As Integer 'idordencomprA
        x = Existe_OC(idpro)
        If x <> -1 Then 'cargo detalle
            If Not Existe_detalle(idmp, x, cant) Then
                Cargar_detalleOC(x, idmp, cant, pre)
            End If


        Else 'cargo nueva orden compra

            Dim cfilas As DataRowCollection = dtOC.Rows
            Dim nuevafilaoc As DataRow
            nuevafilaoc = dtOC.NewRow
            nuevafilaoc(0) = Today 'fecha realizacion
            nuevafilaoc(1) = fecha 'plazo entrega
            If BindingContext(DS, "ordencompramp").Count = 0 Then
                nuevafilaoc(2) = DS.Tables("oc_id").Rows(0).Item(0) + 1 'id orden compra
            Else
                nuevafilaoc(2) = cfilas(BindingContext(DS, "ordencompramp").Count - 1).Item(2) + 1
            End If
            nuevafilaoc(3) = nuevafilaoc(2) 'nro orden
            nuevafilaoc(4) = fpago  'pago
            nuevafilaoc(5) = "ni" 'causa
            nuevafilaoc(6) = Estado.ORDEN_DE_COMPRA_PENDIENTE 'idestado antes estaba en 1
            nuevafilaoc(7) = idpro 'idproveedor
            cfilas.Add(nuevafilaoc)
            Cargar_detalleOC(nuevafilaoc(2), idmp, cant, pre)

        End If
    End Sub

    Private Sub Cargar_detalleOC(ByVal x As Integer, ByVal idmp As Integer, ByVal cant As Integer, ByVal pre As Integer)
        Dim cfilasdet As DataRowCollection = dtDOC.Rows
        Dim nuevafiladetoc As DataRow
        nuevafiladetoc = dtDOC.NewRow
        nuevafiladetoc(0) = x 'idorden compra
        nuevafiladetoc(1) = idmp 'idtipomp
        nuevafiladetoc(2) = cant  'cant
        nuevafiladetoc(3) = pre 'precio
        nuevafiladetoc(4) = Estado.ORDEN_DE_COMPRA_PENDIENTE  'estado pendiente
        cfilasdet.Add(nuevafiladetoc)
    End Sub
    Private Function Existe_OC(ByVal id As Integer) As Integer
        Dim dv As New DataView
        dv.Table = DS.Tables("ordencompramp")
        dv.RowFilter = "idproveedor =" & id
        If dv.Count <> 0 Then
            Return dv.Item(0).Item(2) 'idordencompra
        Else
            Return -1
        End If
    End Function


    Private Sub grdOC_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdOC.CurrentCellChanged
        grdOC.Select(grdOC.CurrentCell.RowNumber)
        dvDOC.RowFilter = "idordencompra =" & dvOC(grdOC.CurrentRowIndex)("idordencompra")
        Me.GrdDOC.CaptionText = "Detalle de pedido:  " & dvOC(grdOC.CurrentRowIndex)("idordencompra")
    End Sub
    Private Sub Marcar_MP_Critica()
        Dim fila As DataRow
        For Each fila In dtMP.Rows
            If fila.Item("stockactual") < fila.Item("stockminimo") Then

            End If

        Next

    End Sub
    Private Function Existe_detalle(ByVal idmp As Integer, ByVal idoc As Integer, ByVal cant As Integer) As Boolean
        Dim dv As New DataView
        dv.Table = DS.Tables("detalleordencompra")
        dv.RowFilter = "idtipomateriaprima = " & idmp & "and idordencompra=" & idoc
        If dv.Count <> 0 Then
            dv.Item(GrdDOC.CurrentRowIndex).Item(2) = CType(InputBox("La MP tal ya ha sido comprada para este proveedor puede modificar la cant si lo decea", "Compra recurrente", dv.Item(GrdDOC.CurrentRowIndex).Item(2)), Integer)
            Me.GrdDOC.Refresh()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.dvDOC.Item(GrdDOC.CurrentRowIndex).Delete()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click

        Dim dv As New DataView
        dv.Table = DS.Tables("detalleordencompra")
        dv.RowFilter = "idordencompra=" & dvOC(grdOC.CurrentRowIndex)("idordencompra")
        Do While dv.Count <> 0
            dv.Delete(0)
        Loop
        Me.dvOC.Item(grdOC.CurrentRowIndex).Delete()
    End Sub
    Private Function Mostrar_UnidadMedidda(ByVal idunid As Integer) As String
        Dim dv As New DataView
        dv.Table = DS.Tables("unidaddemedida")
        dv.RowFilter = "idunidadmedida= " & idunid
        If dv.Count <> 0 Then
            Return dv.Item(0).Item(1)
        End If

    End Function

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If MsgBox("Confirma creacion de orden de compra", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            Try
                Dim oCommandBuilder_OC As New SqlCommandBuilder(Sqldataadapter2)
                Sqldataadapter2.InsertCommand = oCommandBuilder_OC.GetInsertCommand
                Sqldataadapter2.Update(DS, "ordencompramp")
                Dim oCommandBuilder_DOC As New SqlCommandBuilder(SQLdataadapter3)
                SQLdataadapter3.InsertCommand = oCommandBuilder_DOC.GetInsertCommand
                SQLdataadapter3.Update(DS, "detalleordencompra")

            Catch exp As Exception
                MsgBox(exp.Message, MsgBoxStyle.Critical, Me.Text)
            End Try


        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Dim frm As New consultarOC
        frm.Show()
    End Sub

    Private Sub BtnPrevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevisualizar.Click

        
        Dim SelectFormula As String
        Dim dr As DataRow
        Dim query As String
        Dim i As Integer
        For i = 0 To dtOC.Rows.Count - 1
            query = query & dtOC.Rows(i).Item(2)
            If i < dtOC.Rows.Count - 1 Then
                query = query & ", "
            End If
        Next
       
        If query = "" Then
            MsgBox("No tiene pedidos que mostrar")
        Else
            Dim dsocp As New dsoc
            SqlDataAdapter8.Fill(dsocp)

            Dim p As New CrystalReport1
            p.SetDataSource(dsocp)
            crv.ReportSource = p
            UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(1)
            SelectFormula = "{ordencompramp.idordencompra} in [ " & query & " ]"
            crv.SelectionFormula = SelectFormula
        End If



    End Sub

   
    
End Class
