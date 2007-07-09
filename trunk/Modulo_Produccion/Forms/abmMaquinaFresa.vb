Public Class abmMaquinaFresa
    Inherits System.Windows.Forms.Form
    Dim adaptador As New SqlClient.SqlDataAdapter
    Dim SqlDeleteCommand1 As New SqlClient.SqlCommand
    Dim SqlInsertCommand1 As New SqlClient.SqlCommand
    Dim SqlUpdateCommand1 As New SqlClient.SqlCommand
    Dim SqlSelectCommand1 As New SqlClient.SqlCommand
    Dim ds As New DataSet
    Dim tabla As String
    Dim nombres(6) As String
    Dim ancho() As Integer = {50, 75, 75, 75, 100, 120, 75}
    Dim dt As DataTable


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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents text4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents text3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents text2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents text1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents text5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents combo1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents combo2 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.combo2 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.combo1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
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
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.combo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label8)
        Me.UltraTabPageControl1.Controls.Add(Me.combo2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.combo1)
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
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(644, 257)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(448, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Estado"
        '
        'combo2
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Me.combo2.Appearance = Appearance1
        Me.combo2.AutoSize = True
        ValueListItem1.DataValue = "Alta"
        ValueListItem2.DataValue = "Baja"
        Me.combo2.Items.Add(ValueListItem1)
        Me.combo2.Items.Add(ValueListItem2)
        Me.combo2.Location = New System.Drawing.Point(488, 144)
        Me.combo2.Name = "combo2"
        Me.combo2.ReadOnly = True
        Me.combo2.Size = New System.Drawing.Size(120, 21)
        Me.combo2.TabIndex = 42
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(330, 197)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton5.TabIndex = 41
        Me.UltraButton5.Text = "Baja"
        '
        'UltraButton4
        '
        Me.UltraButton4.Location = New System.Drawing.Point(330, 227)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton4.TabIndex = 40
        Me.UltraButton4.Text = "Nuevo"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(408, 227)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton3.TabIndex = 39
        Me.UltraButton3.Text = "Guardar"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(408, 197)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton2.TabIndex = 38
        Me.UltraButton2.Text = "Modificar"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(536, 227)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton1.TabIndex = 37
        Me.UltraButton1.Text = "Salir"
        '
        'combo1
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Me.combo1.Appearance = Appearance2
        Me.combo1.AutoSize = True
        ValueListItem3.DataValue = "Horario"
        ValueListItem4.DataValue = "Antihorario"
        Me.combo1.Items.Add(ValueListItem3)
        Me.combo1.Items.Add(ValueListItem4)
        Me.combo1.Location = New System.Drawing.Point(96, 120)
        Me.combo1.Name = "combo1"
        Me.combo1.ReadOnly = True
        Me.combo1.Size = New System.Drawing.Size(176, 21)
        Me.combo1.TabIndex = 36
        '
        'text4
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Me.text4.Appearance = Appearance3
        Me.text4.AutoSize = True
        Me.text4.Location = New System.Drawing.Point(96, 96)
        Me.text4.Name = "text4"
        Me.text4.ReadOnly = True
        Me.text4.Size = New System.Drawing.Size(176, 21)
        Me.text4.TabIndex = 35
        '
        'text3
        '
        Appearance4.BackColor = System.Drawing.Color.White
        Me.text3.Appearance = Appearance4
        Me.text3.AutoSize = True
        Me.text3.Location = New System.Drawing.Point(96, 72)
        Me.text3.Name = "text3"
        Me.text3.ReadOnly = True
        Me.text3.Size = New System.Drawing.Size(176, 21)
        Me.text3.TabIndex = 34
        '
        'text2
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Me.text2.Appearance = Appearance5
        Me.text2.AutoSize = True
        Me.text2.Location = New System.Drawing.Point(96, 48)
        Me.text2.Name = "text2"
        Me.text2.ReadOnly = True
        Me.text2.Size = New System.Drawing.Size(176, 21)
        Me.text2.TabIndex = 33
        '
        'text1
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Me.text1.Appearance = Appearance6
        Me.text1.AutoSize = True
        Me.text1.Location = New System.Drawing.Point(96, 24)
        Me.text1.Name = "text1"
        Me.text1.ReadOnly = True
        Me.text1.Size = New System.Drawing.Size(176, 21)
        Me.text1.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(18, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Sentido de giro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(32, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "RPM de eje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(45, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Potencia"
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
        Appearance7.BackColor = System.Drawing.Color.White
        Me.text5.Appearance = Appearance7
        Me.text5.AutoSize = True
        Me.text5.Location = New System.Drawing.Point(312, 32)
        Me.text5.Multiline = True
        Me.text5.Name = "text5"
        Me.text5.ReadOnly = True
        Me.text5.Size = New System.Drawing.Size(296, 104)
        Me.text5.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(312, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Características"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(51, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton10)
        Me.UltraTabPageControl2.Controls.Add(Me.DataGrid1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 21)
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
        Me.DataGrid1.CaptionText = "Maquinas"
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
        Me.DataGrid1.Location = New System.Drawing.Point(24, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(600, 184)
        Me.DataGrid1.TabIndex = 0
        '
        'UltraTabControl1
        '
        Appearance8.BackColor = System.Drawing.Color.Silver
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance9.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance10
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(648, 280)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 0
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
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton8)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton9)
        Me.UltraGroupBox1.Controls.Add(Me.Label7)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(48, 195)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(224, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraButton7
        '
        Me.UltraButton7.Location = New System.Drawing.Point(176, 24)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton7.TabIndex = 3
        Me.UltraButton7.Text = ">"
        '
        'UltraButton6
        '
        Me.UltraButton6.Location = New System.Drawing.Point(136, 24)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton6.TabIndex = 2
        Me.UltraButton6.Text = ">>"
        '
        'UltraButton8
        '
        Me.UltraButton8.Location = New System.Drawing.Point(48, 24)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton8.TabIndex = 1
        Me.UltraButton8.Text = "<<"
        '
        'UltraButton9
        '
        Me.UltraButton9.Location = New System.Drawing.Point(8, 24)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton9.TabIndex = 0
        Me.UltraButton9.Text = "<"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(95, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 24)
        Me.Label7.TabIndex = 2
        '
        'abmMaquinaFresa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(646, 288)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 106)
        Me.Name = "abmMaquinaFresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión Máquina para fresa"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.combo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(ds, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label7.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label7.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub


    Private Sub abmMaquinaFresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        'adaptador
        '
        Me.adaptador.DeleteCommand = Me.SqlDeleteCommand1
        Me.adaptador.InsertCommand = Me.SqlInsertCommand1
        Me.adaptador.SelectCommand = Me.SqlSelectCommand1
        Me.adaptador.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "maquinaFresa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idmaquina", "idmaquina"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("potencia", "potencia"), New System.Data.Common.DataColumnMapping("rpmdeleje", "rpmdeleje"), New System.Data.Common.DataColumnMapping("sentidodegiro", "sentidodegiro"), New System.Data.Common.DataColumnMapping("caracteristicas", "caracteristicas"), New System.Data.Common.DataColumnMapping("estado", "estado")})})
        Me.adaptador.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT idmaquina, nombre, potencia, rpmdeleje, sentidodegiro, caracteristicas, es" & _
        "tado FROM maquinaFresa"
        Me.SqlSelectCommand1.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO maquinaFresa(idmaquina, nombre, potencia, rpmdeleje, sentidodegiro, c" & _
        "aracteristicas, estado) VALUES (@idmaquina, @nombre, @potencia, @rpmdeleje, @sen" & _
        "tidodegiro, @caracteristicas, @estado); SELECT idmaquina, nombre, potencia, rpmd" & _
        "eleje, sentidodegiro, caracteristicas, estado FROM maquinaFresa WHERE (idmaquina" & _
        " = @idmaquina)"
        Me.SqlInsertCommand1.Connection = cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmaquina", System.Data.SqlDbType.Int, 4, "idmaquina"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 2147483647, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@potencia", System.Data.SqlDbType.Float, 8, "potencia"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@rpmdeleje", System.Data.SqlDbType.Float, 8, "rpmdeleje"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sentidodegiro", System.Data.SqlDbType.VarChar, 30, "sentidodegiro"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@caracteristicas", System.Data.SqlDbType.VarChar, 2147483647, "caracteristicas"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 25, "estado"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE maquinaFresa SET idmaquina = @idmaquina, nombre = @nombre, potencia = @pot" & _
        "encia, rpmdeleje = @rpmdeleje, sentidodegiro = @sentidodegiro, caracteristicas =" & _
        " @caracteristicas, estado = @estado WHERE (idmaquina = @Original_idmaquina) AND " & _
        "(estado = @Original_estado OR @Original_estado IS NULL AND estado IS NULL) AND (" & _
        "potencia = @Original_potencia OR @Original_potencia IS NULL AND potencia IS NULL" & _
        ") AND (rpmdeleje = @Original_rpmdeleje OR @Original_rpmdeleje IS NULL AND rpmdel" & _
        "eje IS NULL) AND (sentidodegiro = @Original_sentidodegiro OR @Original_sentidode" & _
        "giro IS NULL AND sentidodegiro IS NULL); SELECT idmaquina, nombre, potencia, rpm" & _
        "deleje, sentidodegiro, caracteristicas, estado FROM maquinaFresa WHERE (idmaquin" & _
        "a = @idmaquina)"
        Me.SqlUpdateCommand1.Connection = cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmaquina", System.Data.SqlDbType.Int, 4, "idmaquina"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 2147483647, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@potencia", System.Data.SqlDbType.Float, 8, "potencia"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@rpmdeleje", System.Data.SqlDbType.Float, 8, "rpmdeleje"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sentidodegiro", System.Data.SqlDbType.VarChar, 30, "sentidodegiro"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@caracteristicas", System.Data.SqlDbType.VarChar, 2147483647, "caracteristicas"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 25, "estado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmaquina", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmaquina", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_potencia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "potencia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_rpmdeleje", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "rpmdeleje", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sentidodegiro", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sentidodegiro", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM maquinaFresa WHERE (idmaquina = @Original_idmaquina) AND (estado = @O" & _
        "riginal_estado OR @Original_estado IS NULL AND estado IS NULL) AND (potencia = @" & _
        "Original_potencia OR @Original_potencia IS NULL AND potencia IS NULL) AND (rpmde" & _
        "leje = @Original_rpmdeleje OR @Original_rpmdeleje IS NULL AND rpmdeleje IS NULL)" & _
        " AND (sentidodegiro = @Original_sentidodegiro OR @Original_sentidodegiro IS NULL" & _
        " AND sentidodegiro IS NULL)"
        Me.SqlDeleteCommand1.Connection = cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmaquina", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmaquina", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_potencia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "potencia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_rpmdeleje", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "rpmdeleje", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sentidodegiro", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sentidodegiro", System.Data.DataRowVersion.Original, Nothing))


        adaptador.Fill(ds)

        Me.text1.DataBindings.Add("Text", ds, "maquinafresa.idmaquina")
        Me.text2.DataBindings.Add("Text", ds, "maquinafresa.nombre")
        Me.text3.DataBindings.Add("Text", ds, "maquinafresa.potencia")
        Me.text4.DataBindings.Add("Text", ds, "maquinafresa.rpmdeleje")
        Me.text5.DataBindings.Add("Text", ds, "maquinafresa.caracteristicas")
        Me.combo1.DataBindings.Add("Text", ds, "maquinafresa.sentidodegiro")
        Me.combo2.DataBindings.Add("Text", ds, "maquinafresa.estado")


        tabla = "maquinafresa"
        Me.mostrarPosicion(tabla)

        DataGrid1.DataSource = ds
        DataGrid1.DataMember = "maquinafresa"

        nombres(0) = "ID"
        nombres(1) = "Nombre"
        nombres(2) = "Potencia"
        nombres(3) = "RPM del eje"
        nombres(4) = "Sentido de giro"
        nombres(5) = "Caracteristicas"
        nombres(6) = "Estado"

        dt = ds.Tables(0)

        cargarGrilla(DataGrid1, dt, nombres, ancho)

        princ.barra.agregarBoton(Me)



    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(ds, tabla).Position = BindingContext(ds, tabla).Count - 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(ds, tabla).Position += 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(ds, tabla).Position = 0
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(ds, tabla).Position -= 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        text1.ReadOnly = False
        text2.ReadOnly = False
        text3.ReadOnly = False
        text4.ReadOnly = False
        text5.ReadOnly = False
        combo1.ReadOnly = False
        combo2.ReadOnly = False

        text1.Focus()

        text1.BackColor() = System.Drawing.Color.LightCyan
        text2.BackColor() = System.Drawing.Color.LightCyan
        text3.BackColor() = System.Drawing.Color.LightCyan
        text4.BackColor() = System.Drawing.Color.LightCyan
        text5.BackColor() = System.Drawing.Color.LightCyan
        combo1.BackColor() = System.Drawing.Color.LightCyan
        combo2.BackColor() = System.Drawing.Color.LightCyan

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click

        Dim nuevo As DataRow
        Dim id As Integer

        id = ds.Tables(0).Rows.Count + 1


        Try
            nuevo = ds.Tables(0).NewRow     'creo una nueva fila de la tabla maquinafresa



            nuevo("idmaquina") = id         'le doy valores nulos
            nuevo("nombre") = ""
            nuevo("potencia") = 0
            nuevo("rpmdeleje") = 0
            nuevo("sentidodegiro") = ""
            nuevo("caracteristicas") = ""
            nuevo("estado") = "Alta"



            ds.Tables(0).Rows.Add(nuevo)

            UltraButton6.PerformClick()  'voy al ultimo registro
            mostrarPosicion(tabla)
            text1.Focus()

        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try


        'text1.ReadOnly = False          'seteo la propiedad de los text para que se pueda escribir
        text2.ReadOnly = False
        text3.ReadOnly = False
        text4.ReadOnly = False
        text5.ReadOnly = False
        combo1.ReadOnly = False
        combo2.ReadOnly = False

        text2.Focus()

        'text1.BackColor() = System.Drawing.Color.LightCyan      'cambio color de los text
        text2.BackColor() = System.Drawing.Color.LightCyan
        text3.BackColor() = System.Drawing.Color.LightCyan
        text4.BackColor() = System.Drawing.Color.LightCyan
        text5.BackColor() = System.Drawing.Color.LightCyan
        combo1.BackColor() = System.Drawing.Color.LightCyan
        combo2.BackColor() = System.Drawing.Color.LightCyan
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        UltraButton9.PerformClick()     'comandos mágicos para que actualice la base
        UltraButton7.PerformClick()

        adaptador.Update(ds)

        'text1.ReadOnly = True
        text2.ReadOnly = True
        text3.ReadOnly = True
        text4.ReadOnly = True
        text5.ReadOnly = True
        combo1.ReadOnly = True
        combo2.ReadOnly = True

        'text1.BackColor() = System.Drawing.Color.White      'cambio color de los text
        text2.BackColor() = System.Drawing.Color.White
        text3.BackColor() = System.Drawing.Color.White
        text4.BackColor() = System.Drawing.Color.White
        text5.BackColor() = System.Drawing.Color.White
        combo1.BackColor() = System.Drawing.Color.White
        combo2.BackColor() = System.Drawing.Color.White
    End Sub

    
    
    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        If (MessageBox.Show("¿Desea dar de baja esta máquina?", "Dar de baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            combo2.Text = "Baja"
            UltraButton9.PerformClick()     'comandos mágicos para que actualice la base
            UltraButton7.PerformClick()
            adaptador.Update(ds)
        End If

    End Sub

    Private Sub abmMaquinaFresa_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub
End Class
