Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmFormulario
    Inherits System.Windows.Forms.Form
    Dim objformulario As New Formulario
    Dim consultaformulario As String = "select * from formulario order by idformulario"
    Dim dsformulario As DataSet = objformulario.cargarDSFormulario(consultaformulario, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub


    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    'Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    'Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    'Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    'Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    'Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    'Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    'Friend WithEvents Label8 As System.Windows.Forms.Label
    'Friend WithEvents Label7 As System.Windows.Forms.Label
    'Friend WithEvents Label6 As System.Windows.Forms.Label
    'Friend WithEvents Label5 As System.Windows.Forms.Label
    'Friend WithEvents Label4 As System.Windows.Forms.Label
    'Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    'Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    'Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    'Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    'Friend WithEvents Label9 As System.Windows.Forms.Label
    'Friend WithEvents Label10 As System.Windows.Forms.Label
    'Friend WithEvents TextBox2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    'Friend WithEvents TextBox4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    'Friend WithEvents TextBox5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    'Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    'Friend WithEvents TextBox7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    'Friend WithEvents TextBox3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    'Friend WithEvents textBox6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    'Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormulario))
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txtID = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TxtDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TxtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraCheckEditor1)
        Me.UltraTabPageControl1.Controls.Add(Me.txtID)
        Me.UltraTabPageControl1.Controls.Add(Me.TxtDescripcion)
        Me.UltraTabPageControl1.Controls.Add(Me.TxtNombre)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton10)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(740, 233)
        '
        'UltraCheckEditor1
        '
        Me.UltraCheckEditor1.BackColor = System.Drawing.Color.Transparent
        Me.UltraCheckEditor1.Location = New System.Drawing.Point(102, 125)
        Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
        Me.UltraCheckEditor1.Size = New System.Drawing.Size(120, 20)
        Me.UltraCheckEditor1.TabIndex = 37
        Me.UltraCheckEditor1.Text = "Activo"
        '
        'txtID
        '
        Appearance1.BackColorDisabled = System.Drawing.Color.White
        Appearance1.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtID.Appearance = Appearance1
        Me.txtID.AutoSize = True
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(440, 28)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(108, 21)
        Me.txtID.TabIndex = 1
        '
        'TxtDescripcion
        '
        Appearance2.BackColorDisabled = System.Drawing.Color.White
        Appearance2.BackColorDisabled2 = System.Drawing.Color.White
        Me.TxtDescripcion.Appearance = Appearance2
        Me.TxtDescripcion.AutoSize = True
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(102, 89)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(240, 21)
        Me.TxtDescripcion.TabIndex = 4
        '
        'TxtNombre
        '
        Appearance3.BackColorDisabled = System.Drawing.Color.White
        Appearance3.BackColorDisabled2 = System.Drawing.Color.White
        Me.TxtNombre.Appearance = Appearance3
        Me.TxtNombre.AutoSize = True
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(102, 57)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(240, 21)
        Me.TxtNombre.TabIndex = 2
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton8)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton9)
        Me.UltraGroupBox1.Controls.Add(Me.Label9)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(102, 173)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(240, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 36
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraButton7
        '
        Me.UltraButton7.Location = New System.Drawing.Point(192, 24)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton7.TabIndex = 8
        Me.UltraButton7.Text = ">"
        '
        'UltraButton6
        '
        Me.UltraButton6.Location = New System.Drawing.Point(152, 24)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton6.TabIndex = 7
        Me.UltraButton6.Text = ">>"
        '
        'UltraButton8
        '
        Me.UltraButton8.Location = New System.Drawing.Point(48, 24)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton8.TabIndex = 6
        Me.UltraButton8.Text = "<<"
        '
        'UltraButton9
        '
        Me.UltraButton9.Location = New System.Drawing.Point(8, 24)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton9.TabIndex = 5
        Me.UltraButton9.Text = "<"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(104, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 24)
        Me.Label9.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Location = New System.Drawing.Point(440, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(392, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Modulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(33, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(390, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Menu asociado"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(102, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(52, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nombre"
        '
        'UltraButton2
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButton2.Appearance = Appearance4
        Me.UltraButton2.Location = New System.Drawing.Point(554, 160)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 32)
        Me.UltraButton2.TabIndex = 12
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton1
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButton1.Appearance = Appearance5
        Me.UltraButton1.Location = New System.Drawing.Point(468, 160)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 32)
        Me.UltraButton1.TabIndex = 11
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(554, 198)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(80, 31)
        Me.UltraButton5.TabIndex = 10
        Me.UltraButton5.Text = "&Cancelar"
        '
        'UltraButton4
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.ForeColor = System.Drawing.Color.Black
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.UltraButton4.Appearance = Appearance6
        Me.UltraButton4.Location = New System.Drawing.Point(468, 198)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(80, 31)
        Me.UltraButton4.TabIndex = 9
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton3
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.UltraButton3.Appearance = Appearance7
        Me.UltraButton3.Location = New System.Drawing.Point(638, 160)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(82, 32)
        Me.UltraButton3.TabIndex = 13
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton10
        '
        Me.UltraButton10.Location = New System.Drawing.Point(640, 198)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(80, 31)
        Me.UltraButton10.TabIndex = 14
        Me.UltraButton10.Text = "Salir"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.DataGrid1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(740, 233)
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.CaptionText = "Formularios"
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
        Me.DataGrid1.Location = New System.Drawing.Point(16, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(704, 176)
        Me.DataGrid1.TabIndex = 20
        '
        'UltraTabControl1
        '
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance8.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance9
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance10.BackColor = System.Drawing.Color.Silver
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance10
        Me.UltraTabControl1.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.UltraButton10})
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(744, 256)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Gestionar"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Consultar"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraButton10)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(740, 233)
        '
        'frmFormulario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 264)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmFormulario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestionar Formularios"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(dsformulario, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label9.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label9.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub frmFormulario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmFormulario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsformulario
        DataGrid1.DataMember = "formulario"

        Dim nombrescol(10) As String
        nombrescol(0) = "ID Formulario"
        nombrescol(1) = "Descripcion"
        nombrescol(2) = "ID modulo"
        nombrescol(3) = "Nombre"
        nombrescol(4) = "ID Menu"
        nombrescol(5) = "Activo"


        Dim anchosgrid(10) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(3) = 100
        anchosgrid(4) = 75
        anchosgrid(5) = 75


        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsformulario.Tables.Item(0), nombrescol, anchosgrid)

        cargarCombo("select idmenu, nombre from menupadre where activo = 1", ComboBox1, "nombre", "idmenu")
        cargarCombo("select idmodulo, descripcion from modulo", ComboBox2, "descripcion", "idmodulo")

        TxtDescripcion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        TxtNombre.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
        If DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5) = 1 Then
            UltraCheckEditor1.CheckedValue = True
        Else
            UltraCheckEditor1.CheckedValue = False
        End If

        txtID.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)

        ComboBox1.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
        ComboBox2.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)

        objformulario.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5))


        objformulario.mostrarDatos(txtID.Text, TxtNombre.Text, ComboBox2.SelectedValue, TxtNombre.Text, ComboBox1.SelectedValue, UltraCheckEditor1.CheckedValue)
    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click

        bandGrabar = 1
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        txtID.Enabled = False
        txtID.Text = objformulario.nuevoID
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        TxtNombre.Enabled = True
        TxtDescripcion.Enabled = True
        TxtNombre.Focus()
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""
        UltraCheckEditor1.Enabled = True
    End Sub


    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bandGrabar = 2
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        TxtNombre.Enabled = True
        TxtDescripcion.Enabled = True
        ComboBox2.Enabled = True
        ComboBox1.Enabled = True
        UltraCheckEditor1.Enabled = True
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objformulario.eliminarformulario(dsformulario)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Dim act As Integer
        If UltraCheckEditor1.CheckedValue Then
            act = 1
        Else
            act = 0
        End If
        objformulario.tomarDatos(txtID.Text, TxtDescripcion.Text, ComboBox2.SelectedValue, TxtNombre.Text, ComboBox1.SelectedValue, act)
        If bandGrabar = 1 Then
            objformulario.registrarFormulario(dsformulario)
        Else
            objformulario.modificarFormulario(dsformulario)
        End If
        If objformulario.varCancelar = 0 Then
            UltraButton1.Enabled = True
            UltraButton2.Enabled = True
            UltraButton3.Enabled = True
            UltraButton4.Enabled = False
            UltraButton5.Enabled = False

            txtID.Enabled = False
            TxtNombre.Enabled = False
            TxtDescripcion.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            UltraCheckEditor1.Enabled = False
        End If

    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False
        txtID.Enabled = False
        TxtNombre.Enabled = False
        TxtDescripcion.Enabled = False
        UltraCheckEditor1.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
    End Sub


    'Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If Len(TextBox1.Text) > 0 Then
    '        TextBox2.Enabled = True
    '        TextBox3.Enabled = True
    '        TextBox4.Enabled = True
    '        TextBox5.Enabled = True
    '        TextBox6.Enabled = True
    '        TextBox7.Enabled = True
    '        ComboBox2.Enabled = True
    '    Else
    '        TextBox2.Enabled = False
    '        TextBox3.Enabled = False
    '        TextBox4.Enabled = False
    '        TextBox5.Enabled = False
    '        TextBox6.Enabled = False
    '        TextBox7.Enabled = False
    '        ComboBox2.Enabled = False
    '    End If
    'End Sub


    'Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Len(TextBox1.Text) > 0 Then
    '        'podria ser asi objcliente.validarCliente(dscliente, txtDocumento, cmbtipodoc)
    '        'pero prefiero usar el tomarDatos() ya creado 
    '        objcliente.tomarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
    '        TextBox4.Text, CType(TextBox1.Text, Decimal), textBox6.Text, TextBox7.Text, DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
    '        If Not objcliente.validarCliente(dscliente) Then
    '            TextBox2.Focus()
    '            MsgBox("Documento existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
    '        End If
    '    End If
    'End Sub

    Private Sub frmFormulario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dsformulario, "formulario").Position = BindingContext(dsformulario, "formulario").Count - 1
        mostrarPosicion("formulario")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dsformulario, "formulario").Position = 0
        mostrarPosicion("formulario")
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(dsformulario, "formulario").Position -= 1
        mostrarPosicion("formulario")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dsformulario, "formulario").Position += 1
        mostrarPosicion("formulario")
    End Sub


    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        objformulario.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5))




        objformulario.mostrarDatos(txtID.Text, TxtDescripcion.Text, ComboBox2.SelectedValue, TxtNombre.Text, ComboBox1.SelectedValue, UltraCheckEditor1.CheckedValue)




        'TextBox2.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(1)
        'TextBox3.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3)
        'TextBox4.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4)
        'TextBox5.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5)
        'TextBox6.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6)
        'TextBox1.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7)
        'TextBox7.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9)
        'ComboBox1.SelectedValue = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8)
        'ComboBox2.SelectedValue = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2)
        'DataGrid1.CurrentCell.RowNumber()
        'dscliente.Tables.Item(0).Rows(BindingContext(dscliente, "cliente").Position).Item(1)
    End Sub

    'Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub


    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress, txtID.KeyPress
        soloNumeros(e)
    End Sub

    '    Private Sub TextBox1_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) , txtID.KeyUp
    'msgbox("metodo loco")
    '        'If Len(TxtNombre.Text) > 0 Then
    '        '    TxtNombre.Enabled = True
    '        '    TxtDescripcion.Enabled = True
    '        '    ComboBox2.Enabled = True
    '        'Else
    '        '    TxtNombre.Enabled = False
    '        '    TxtDescripcion.Enabled = False
    '        '    ComboBox2.Enabled = False
    '        'End If
    '    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged

    End Sub

    'Private Sub TextBox1_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) , txtID.LostFocus
    '    If Len(txtID.Text) > 0 Then
    '        'podria ser asi objcliente.validarCliente(dscliente, txtDocumento, cmbtipodoc)
    '        'pero prefiero usar el tomarDatos() ya creado 
    '        objformulario.tomarDatos(TextBox7.Text, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, ComboBox1.SelectedValue, True)
    '        'If Not objformulario.validarCliente(dsformulario) Then
    '        '    TextBox2.Focus()
    '        '    MsgBox("Documento existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
    '        'End If
    '    End If
    'End Sub


    'Private Sub TextBox1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) , txtID.ValueChanged

    'End Sub
End Class