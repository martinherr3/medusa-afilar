Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCliente
    Inherits System.Windows.Forms.Form
    Dim objcliente As New Cliente
    Dim consultacliente As String = "select idcliente, nombre, apellido, Localidad, Direccion, Telefono, Mail, Celular, documento, idtipodocumento from cliente order by idcliente"
    Dim dscliente As DataSet = objcliente.cargarDSCliente(consultacliente, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer

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
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textBox6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.textBox6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label10 = New System.Windows.Forms.Label
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
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
        CType(Me.textBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UltraTabPageControl1.Controls.Add(Me.textBox6)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox7)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox5)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox4)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label10)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label8)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
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
        'textBox6
        '
        Appearance1.BackColorDisabled = System.Drawing.Color.White
        Appearance1.BackColorDisabled2 = System.Drawing.Color.White
        Me.textBox6.Appearance = Appearance1
        Me.textBox6.AutoSize = True
        Me.textBox6.Enabled = False
        Me.textBox6.Location = New System.Drawing.Point(74, 112)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(128, 21)
        Me.textBox6.TabIndex = 8
        '
        'TextBox3
        '
        Appearance2.BackColorDisabled = System.Drawing.Color.White
        Appearance2.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox3.Appearance = Appearance2
        Me.TextBox3.AutoSize = True
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(432, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 21)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox7
        '
        Appearance3.BackColorDisabled = System.Drawing.Color.White
        Appearance3.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox7.Appearance = Appearance3
        Me.TextBox7.AutoSize = True
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(432, 40)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(184, 21)
        Me.TextBox7.TabIndex = 3
        '
        'TextBox1
        '
        Appearance4.BackColorDisabled = System.Drawing.Color.White
        Appearance4.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox1.Appearance = Appearance4
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(432, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 21)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox5
        '
        Appearance5.BackColorDisabled = System.Drawing.Color.White
        Appearance5.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox5.Appearance = Appearance5
        Me.TextBox5.AutoSize = True
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(74, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(190, 21)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox4
        '
        Appearance6.BackColorDisabled = System.Drawing.Color.White
        Appearance6.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox4.Appearance = Appearance6
        Me.TextBox4.AutoSize = True
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(74, 64)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 21)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox2
        '
        Appearance7.BackColorDisabled = System.Drawing.Color.White
        Appearance7.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox2.Appearance = Appearance7
        Me.TextBox2.AutoSize = True
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(74, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(190, 21)
        Me.TextBox2.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(389, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Apellido"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton8)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton9)
        Me.UltraGroupBox1.Controls.Add(Me.Label9)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(72, 160)
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
        Me.ComboBox2.Location = New System.Drawing.Point(432, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(36, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Celular"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(48, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(380, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(382, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(390, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Tipo doc."
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(74, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nombre"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(552, 152)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 32)
        Me.UltraButton2.TabIndex = 12
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton1
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.UltraButton1.Appearance = Appearance8
        Me.UltraButton1.Location = New System.Drawing.Point(464, 152)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 32)
        Me.UltraButton1.TabIndex = 11
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton5
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.UltraButton5.Appearance = Appearance9
        Me.UltraButton5.Location = New System.Drawing.Point(552, 192)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(80, 31)
        Me.UltraButton5.TabIndex = 10
        Me.UltraButton5.Text = "&Cancelar"
        '
        'UltraButton4
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.UltraButton4.Appearance = Appearance10
        Me.UltraButton4.Location = New System.Drawing.Point(464, 192)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(80, 31)
        Me.UltraButton4.TabIndex = 9
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton3
        '
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        Me.UltraButton3.Appearance = Appearance11
        Me.UltraButton3.Location = New System.Drawing.Point(638, 152)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(82, 32)
        Me.UltraButton3.TabIndex = 13
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton10
        '
        Me.UltraButton10.Location = New System.Drawing.Point(640, 192)
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
        Me.DataGrid1.CaptionText = "Clientes"
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
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance12.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance12
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance13
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance14.BackColor = System.Drawing.Color.Silver
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance14
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
        'frmCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 264)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestionar Clientes"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.textBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
        Dim bmbase As BindingManagerBase = BindingContext.Item(dscliente, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label9.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label9.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub frmCliente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dscliente
        DataGrid1.DataMember = "cliente"

        Dim nombrescol(10) As String
        nombrescol(0) = "ID Cliente"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Apellido"
        nombrescol(4) = "Direccion"
        nombrescol(5) = "Telefono"
        nombrescol(7) = "Celular"
        nombrescol(8) = "Nro Documento"

        Dim anchosgrid(10) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(4) = 100
        anchosgrid(5) = 75
        anchosgrid(7) = 75
        anchosgrid(8) = 110

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dscliente.Tables.Item(0), nombrescol, anchosgrid)

        cargarCombo("select idtipodocumento,nombre from tipodocumento", ComboBox1, "nombre", "idtipodocumento")
        cargarCombo("select idlocalidad,nombre from localidad", ComboBox2, "nombre", "idlocalidad")

        TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        TextBox2.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
        TextBox3.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
        TextBox4.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
        TextBox5.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5)

        ComboBox1.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)


        objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0))

        'objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0))

        objcliente.mostrarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
        TextBox4.Text, textBox6.Text, TextBox7.Text, TextBox1.Text)
    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        'objcliente.nuevoCliente(dscliente)
        bandGrabar = 1
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        TextBox1.Enabled = True

        TextBox1.Text = ""
        ComboBox1.Enabled = True

        TextBox1.Focus()

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        textBox6.Text = ""
        TextBox7.Text = ""
        'UltraButton6.PerformClick()  'voy al ultimo registro
        'mostrarPosicion("cliente")

    End Sub


    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bandGrabar = 2
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        'TextBox1.Enabled = True
        'ComboBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        textBox6.Enabled = True
        TextBox7.Enabled = True
        ComboBox2.Enabled = True
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objcliente.eliminarCliente(dscliente)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click

        objcliente.tomarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
        TextBox4.Text, CType(TextBox1.Text, Decimal), textBox6.Text, TextBox7.Text, DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))

        If bandGrabar = 1 Then
            objcliente.registrarCliente(dscliente)
        Else
            objcliente.modificarCliente(dscliente)
        End If
        If objcliente.varCancelar = 0 Then
            UltraButton1.Enabled = True
            UltraButton2.Enabled = True
            UltraButton3.Enabled = True
            UltraButton4.Enabled = False
            UltraButton5.Enabled = False

            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            textBox6.Enabled = False
            TextBox7.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        End If

    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        textBox6.Enabled = False
        TextBox7.Enabled = False
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


    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(TextBox1.Text) > 0 Then
            'podria ser asi objcliente.validarCliente(dscliente, txtDocumento, cmbtipodoc)
            'pero prefiero usar el tomarDatos() ya creado 
            objcliente.tomarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
            TextBox4.Text, CType(TextBox1.Text, Decimal), textBox6.Text, TextBox7.Text, DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
            If Not objcliente.validarCliente(dscliente) Then
                TextBox2.Focus()
                MsgBox("Documento existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dscliente, "cliente").Position = BindingContext(dscliente, "cliente").Count - 1
        mostrarPosicion("cliente")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dscliente, "cliente").Position = 0
        mostrarPosicion("cliente")
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(dscliente, "cliente").Position -= 1
        mostrarPosicion("cliente")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dscliente, "cliente").Position += 1
        mostrarPosicion("cliente")
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0))

        objcliente.mostrarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
        TextBox4.Text, textBox6.Text, TextBox7.Text, TextBox1.Text)


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


    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TextBox1_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If Len(TextBox1.Text) > 0 Then
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            textBox6.Enabled = True
            TextBox7.Enabled = True
            ComboBox2.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            textBox6.Enabled = False
            TextBox7.Enabled = False
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged

    End Sub

    Private Sub TextBox1_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If Len(TextBox1.Text) > 0 Then
            'podria ser asi objcliente.validarCliente(dscliente, txtDocumento, cmbtipodoc)
            'pero prefiero usar el tomarDatos() ya creado 
            objcliente.tomarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
            TextBox4.Text, CType(TextBox1.Text, Decimal), textBox6.Text, TextBox7.Text, DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
            If Not objcliente.validarCliente(dscliente) Then
                TextBox2.Focus()
                MsgBox("Documento existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
            End If
        End If
    End Sub


    Private Sub TextBox1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.ValueChanged

    End Sub

    Private Sub UltraButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim form As New frmUsuarios
        ' form.MdiParent = Me
        form.Tag = objcliente.id
        form.Show()
    End Sub
End Class
