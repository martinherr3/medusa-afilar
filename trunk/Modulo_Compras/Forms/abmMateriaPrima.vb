Public Class abmMateriaPrima
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents text4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents text3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents text2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents text1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents text5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraComboEditor1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmMateriaPrima))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.UltraComboEditor1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton
        Me.text4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.text3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.text2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.text1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.text5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.text4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Label9)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraComboEditor1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTextEditor2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTextEditor1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton2)
        Me.UltraTabPageControl1.Controls.Add(Me.btnSalir)
        Me.UltraTabPageControl1.Controls.Add(Me.text4)
        Me.UltraTabPageControl1.Controls.Add(Me.text3)
        Me.UltraTabPageControl1.Controls.Add(Me.text2)
        Me.UltraTabPageControl1.Controls.Add(Me.text1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.text5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(644, 257)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(200, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Unidad de medida"
        '
        'UltraComboEditor1
        '
        Me.UltraComboEditor1.AutoSize = True
        Me.UltraComboEditor1.Location = New System.Drawing.Point(200, 144)
        Me.UltraComboEditor1.Name = "UltraComboEditor1"
        Me.UltraComboEditor1.Size = New System.Drawing.Size(96, 21)
        Me.UltraComboEditor1.TabIndex = 52
        '
        'UltraTextEditor2
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Me.UltraTextEditor2.Appearance = Appearance1
        Me.UltraTextEditor2.AutoSize = True
        Me.UltraTextEditor2.Location = New System.Drawing.Point(96, 120)
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.ReadOnly = True
        Me.UltraTextEditor2.Size = New System.Drawing.Size(88, 21)
        Me.UltraTextEditor2.TabIndex = 51
        '
        'UltraTextEditor1
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Me.UltraTextEditor1.Appearance = Appearance2
        Me.UltraTextEditor1.AutoSize = True
        Me.UltraTextEditor1.Location = New System.Drawing.Point(96, 72)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.ReadOnly = True
        Me.UltraTextEditor1.Size = New System.Drawing.Size(88, 21)
        Me.UltraTextEditor1.TabIndex = 50
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton8)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton9)
        Me.UltraGroupBox1.Controls.Add(Me.Label8)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(96, 192)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(224, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 49
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraButton7
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton7.Appearance = Appearance3
        Me.UltraButton7.Location = New System.Drawing.Point(176, 24)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton7.TabIndex = 3
        '
        'UltraButton6
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton6.Appearance = Appearance4
        Me.UltraButton6.Location = New System.Drawing.Point(136, 24)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton6.TabIndex = 2
        '
        'UltraButton8
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton8.Appearance = Appearance5
        Me.UltraButton8.Location = New System.Drawing.Point(48, 24)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton8.TabIndex = 1
        '
        'UltraButton9
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton9.Appearance = Appearance6
        Me.UltraButton9.Location = New System.Drawing.Point(8, 24)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton9.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(92, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 24)
        Me.Label8.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(40, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Stock act."
        '
        'UltraButton4
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.UltraButton4.Appearance = Appearance7
        Me.UltraButton4.Location = New System.Drawing.Point(404, 216)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(72, 32)
        Me.UltraButton4.TabIndex = 40
        Me.UltraButton4.Text = "Nuevo"
        '
        'UltraButton3
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.UltraButton3.Appearance = Appearance8
        Me.UltraButton3.Location = New System.Drawing.Point(326, 216)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(72, 32)
        Me.UltraButton3.TabIndex = 39
        Me.UltraButton3.Text = "Guardar"
        '
        'UltraButton2
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.UltraButton2.Appearance = Appearance9
        Me.UltraButton2.Location = New System.Drawing.Point(482, 216)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(72, 32)
        Me.UltraButton2.TabIndex = 38
        Me.UltraButton2.Text = "Editar"
        '
        'btnSalir
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.btnSalir.Appearance = Appearance10
        Me.btnSalir.Location = New System.Drawing.Point(560, 216)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 32)
        Me.btnSalir.TabIndex = 37
        Me.btnSalir.Text = "Salir"
        '
        'text4
        '
        Appearance11.BackColor = System.Drawing.Color.White
        Me.text4.Appearance = Appearance11
        Me.text4.AutoSize = True
        Me.text4.Location = New System.Drawing.Point(96, 96)
        Me.text4.Name = "text4"
        Me.text4.ReadOnly = True
        Me.text4.Size = New System.Drawing.Size(88, 21)
        Me.text4.TabIndex = 35
        '
        'text3
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Me.text3.Appearance = Appearance12
        Me.text3.AutoSize = True
        Me.text3.Location = New System.Drawing.Point(96, 144)
        Me.text3.Name = "text3"
        Me.text3.ReadOnly = True
        Me.text3.Size = New System.Drawing.Size(88, 21)
        Me.text3.TabIndex = 34
        '
        'text2
        '
        Appearance13.BackColor = System.Drawing.Color.White
        Me.text2.Appearance = Appearance13
        Me.text2.AutoSize = True
        Me.text2.Location = New System.Drawing.Point(96, 48)
        Me.text2.Name = "text2"
        Me.text2.ReadOnly = True
        Me.text2.Size = New System.Drawing.Size(176, 21)
        Me.text2.TabIndex = 33
        '
        'text1
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Me.text1.Appearance = Appearance14
        Me.text1.AutoSize = True
        Me.text1.Location = New System.Drawing.Point(96, 24)
        Me.text1.Name = "text1"
        Me.text1.ReadOnly = True
        Me.text1.Size = New System.Drawing.Size(88, 21)
        Me.text1.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(40, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Lote econ."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(40, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Stock seg."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(40, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Stock mín."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(79, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ID"
        '
        'text5
        '
        Appearance15.BackColor = System.Drawing.Color.White
        Me.text5.Appearance = Appearance15
        Me.text5.AutoSize = True
        Me.text5.Location = New System.Drawing.Point(326, 53)
        Me.text5.Multiline = True
        Me.text5.Name = "text5"
        Me.text5.ReadOnly = True
        Me.text5.Size = New System.Drawing.Size(306, 112)
        Me.text5.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(323, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(52, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton10)
        Me.UltraTabPageControl2.Controls.Add(Me.DataGrid1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(644, 257)
        '
        'UltraButton10
        '
        Me.UltraButton10.Location = New System.Drawing.Point(552, 224)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton10.TabIndex = 1
        Me.UltraButton10.Text = "Salir"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.CaptionText = "Insumos"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid1.Location = New System.Drawing.Point(24, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(600, 200)
        Me.DataGrid1.TabIndex = 0
        '
        'UltraTabControl1
        '
        Appearance16.BackColor = System.Drawing.Color.Silver
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance17.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance17
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance18
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(-8, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(648, 280)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Gestión"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Consultar"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(644, 257)
        '
        'abmMateriaPrima
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 286)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 106)
        Me.Name = "abmMateriaPrima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión Materia prima"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.text4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub abmMateriaPrima_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub abmMateriaPrima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
