Public Class abmProveedores
    Inherits System.Windows.Forms.Form
    Dim consulta As String = "select idproveedor,proveedor.nombre,direccion,telefono,mail,nombrecontacto,localidad.nombre,proveedor.idlocalidad from proveedor,localidad where proveedor.idlocalidad=localidad.idlocalidad"
    Dim adaptadorP As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(consulta, cnn)
    Dim dsProveedor As New DataSet
    Dim bandgrabar As Integer

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
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Salir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents TextBox3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton11 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lista2 As System.Windows.Forms.ListView
    Friend WithEvents lista1 As System.Windows.Forms.ListView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraButton12 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmProveedores))
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
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Salir = New Infragistics.Win.Misc.UltraButton
        Me.TextBox3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TextBox2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton11 = New Infragistics.Win.Misc.UltraButton
        Me.lista2 = New System.Windows.Forms.ListView
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.lista1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label10 = New System.Windows.Forms.Label
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton12 = New Infragistics.Win.Misc.UltraButton
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ComboBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox5)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox4)
        Me.UltraTabPageControl1.Controls.Add(Me.Salir)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.Label10)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.TextBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(644, 369)
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(408, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(356, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Localidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(383, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Mail"
        '
        'TextBox5
        '
        Appearance1.BackColorDisabled = System.Drawing.Color.White
        Appearance1.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox5.Appearance = Appearance1
        Me.TextBox5.AutoSize = True
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(112, 64)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(216, 21)
        Me.TextBox5.TabIndex = 9
        '
        'TextBox4
        '
        Appearance2.BackColorDisabled = System.Drawing.Color.White
        Appearance2.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox4.Appearance = Appearance2
        Me.TextBox4.AutoSize = True
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(408, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(216, 21)
        Me.TextBox4.TabIndex = 8
        '
        'Salir
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.Salir.Appearance = Appearance3
        Me.Salir.Location = New System.Drawing.Point(544, 336)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(80, 26)
        Me.Salir.TabIndex = 42
        Me.Salir.Text = "Salir"
        '
        'TextBox3
        '
        Appearance4.BackColorDisabled = System.Drawing.Color.White
        Appearance4.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox3.Appearance = Appearance4
        Me.TextBox3.AutoSize = True
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(112, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 21)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Appearance5.BackColorDisabled = System.Drawing.Color.White
        Appearance5.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox2.Appearance = Appearance5
        Me.TextBox2.AutoSize = True
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(408, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 21)
        Me.TextBox2.TabIndex = 6
        '
        'UltraGroupBox3
        '
        Appearance6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance6
        Me.UltraGroupBox3.Controls.Add(Me.UltraButton10)
        Me.UltraGroupBox3.Controls.Add(Me.UltraButton11)
        Me.UltraGroupBox3.Controls.Add(Me.lista2)
        Me.UltraGroupBox3.Controls.Add(Me.lista1)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(16, 178)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(608, 152)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 39
        Me.UltraGroupBox3.Text = "Listado de Materias Primas                                                       " & _
            "             Materias Primas que provee"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton10
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton10.Appearance = Appearance7
        Me.UltraButton10.Enabled = False
        Me.UltraButton10.Location = New System.Drawing.Point(272, 88)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(56, 24)
        Me.UltraButton10.TabIndex = 2
        '
        'UltraButton11
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton11.Appearance = Appearance8
        Me.UltraButton11.Enabled = False
        Me.UltraButton11.Location = New System.Drawing.Point(272, 56)
        Me.UltraButton11.Name = "UltraButton11"
        Me.UltraButton11.Size = New System.Drawing.Size(56, 24)
        Me.UltraButton11.TabIndex = 1
        '
        'lista2
        '
        Me.lista2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lista2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lista2.FullRowSelect = True
        Me.lista2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista2.Location = New System.Drawing.Point(336, 24)
        Me.lista2.Name = "lista2"
        Me.lista2.Size = New System.Drawing.Size(264, 120)
        Me.lista2.TabIndex = 3
        Me.lista2.UseCompatibleStateImageBehavior = False
        Me.lista2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ID Tipo MP"
        Me.ColumnHeader10.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nombre Tipo MP"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Stock"
        '
        'lista1
        '
        Me.lista1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lista1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lista1.FullRowSelect = True
        Me.lista1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista1.Location = New System.Drawing.Point(8, 24)
        Me.lista1.Name = "lista1"
        Me.lista1.Size = New System.Drawing.Size(256, 120)
        Me.lista1.TabIndex = 0
        Me.lista1.UseCompatibleStateImageBehavior = False
        Me.lista1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Tipo MP"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre Tipo MP"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(357, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Direccion"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton8)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton9)
        Me.UltraGroupBox1.Controls.Add(Me.Label9)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 104)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(248, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 36
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraButton7
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Appearance9.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton7.Appearance = Appearance9
        Me.UltraButton7.Location = New System.Drawing.Point(192, 24)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton7.TabIndex = 3
        '
        'UltraButton6
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton6.Appearance = Appearance10
        Me.UltraButton6.Location = New System.Drawing.Point(152, 24)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton6.TabIndex = 2
        '
        'UltraButton8
        '
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        Appearance11.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton8.Appearance = Appearance11
        Me.UltraButton8.Location = New System.Drawing.Point(56, 24)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton8.TabIndex = 1
        '
        'UltraButton9
        '
        Appearance12.Image = CType(resources.GetObject("Appearance12.Image"), Object)
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton9.Appearance = Appearance12
        Me.UltraButton9.Location = New System.Drawing.Point(16, 24)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton9.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(105, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(65, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Telefono"
        '
        'TextBox1
        '
        Appearance13.BackColorDisabled = System.Drawing.Color.White
        Appearance13.BackColorDisabled2 = System.Drawing.Color.White
        Me.TextBox1.Appearance = Appearance13
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(112, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 21)
        Me.TextBox1.TabIndex = 5
        '
        'UltraButton4
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.ForeColor = System.Drawing.Color.Black
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButton4.Appearance = Appearance14
        Me.UltraButton4.Location = New System.Drawing.Point(458, 142)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(80, 26)
        Me.UltraButton4.TabIndex = 3
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton1
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.UltraButton1.Appearance = Appearance15
        Me.UltraButton1.Location = New System.Drawing.Point(372, 112)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 26)
        Me.UltraButton1.TabIndex = 0
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton2
        '
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Me.UltraButton2.Appearance = Appearance16
        Me.UltraButton2.Location = New System.Drawing.Point(372, 142)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 26)
        Me.UltraButton2.TabIndex = 1
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton3
        '
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.UltraButton3.Appearance = Appearance17
        Me.UltraButton3.Location = New System.Drawing.Point(458, 112)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(80, 26)
        Me.UltraButton3.TabIndex = 2
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton5
        '
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Me.UltraButton5.Appearance = Appearance18
        Me.UltraButton5.Location = New System.Drawing.Point(544, 142)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(80, 26)
        Me.UltraButton5.TabIndex = 4
        Me.UltraButton5.Text = "&Cancelar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(69, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nombre contacto"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton12)
        Me.UltraTabPageControl2.Controls.Add(Me.DataGrid1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(644, 369)
        '
        'UltraButton12
        '
        Appearance19.Image = CType(resources.GetObject("Appearance19.Image"), Object)
        Me.UltraButton12.Appearance = Appearance19
        Me.UltraButton12.Location = New System.Drawing.Point(536, 336)
        Me.UltraButton12.Name = "UltraButton12"
        Me.UltraButton12.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton12.TabIndex = 43
        Me.UltraButton12.Text = "Salir"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.CaptionText = "Proveedores"
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
        Me.DataGrid1.Location = New System.Drawing.Point(24, 24)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(592, 296)
        Me.DataGrid1.TabIndex = 20
        '
        'UltraTabControl1
        '
        Appearance20.BackColor = System.Drawing.Color.Silver
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance21.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance21
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance22.BackHatchStyle = Infragistics.Win.BackHatchStyle.None
        Me.UltraTabControl1.ClientAreaAppearance = Appearance22
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(648, 392)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 22
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Gestionar"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Consultar"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(644, 369)
        '
        'abmProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 400)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 106)
        Me.Name = "abmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestionar proveedores"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(dsProveedor, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label9.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label9.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub



    Private Sub abmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        adaptadorP.Fill(dsProveedor, "proveedor")
        DataGrid1.DataSource = dsProveedor
        DataGrid1.DataMember = "Proveedor"

        Dim nombrescol(7) As String
        nombrescol(0) = "ID Proveedor"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Direccion"
        nombrescol(3) = "Telefono"
        nombrescol(4) = "Mail"
        nombrescol(5) = "Contacto"
        nombrescol(6) = "Localidad"

        Dim anchosgrid(7) As Integer
        anchosgrid(0) = 30
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(3) = 80
        anchosgrid(4) = 80
        anchosgrid(5) = 80
        anchosgrid(6) = 80

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsProveedor.Tables.Item(0), nombrescol, anchosgrid)

        Dim consulta As String
        Dim indice As Integer
        Dim columnas() As Integer = {0, 1, 3}
        consulta = "select * from tipomateriaprima"         'cargo lista de localidades
        indice = 0
        cargarLista(lista1, consulta, indice, columnas)

        TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        TextBox2.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
        TextBox3.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
        TextBox4.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
        TextBox5.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5)
        cargarCombo("select idlocalidad,nombre from localidad", ComboBox1, "nombre", "idlocalidad")

        ComboBox1.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)

        consulta = "select * from tipomateriaprima,proveedorxtipomateriaprima where proveedorxtipomateriaprima.idtipomateriaprima=tipomateriaprima.idtipomateriaprima and proveedorxtipomateriaprima.idproveedor=" & DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)
        indice = 0
        cargarLista(lista2, consulta, indice, columnas)


    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
       
        TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        TextBox2.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
        TextBox3.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
        TextBox4.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
        TextBox5.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5)

        ComboBox1.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)

        'TextBox1.Text = dsProveedor.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(1)
        'TextBox2.Text = dsProveedor.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2)
        'TextBox3.Text = dsProveedor.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3)
        'TextBox4.Text = dsProveedor.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4)
        'TextBox5.Text = dsProveedor.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5)
        'ComboBox1.SelectedValue = dsProveedor.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7)




        For i As Integer = 0 To lista2.SelectedIndices.Count - 1
            lista2.SelectedItems.Item(0).Remove()
        Next
        lista2.Items.Clear()
        Dim consulta As String
        Dim indice As Integer
        Dim columnas() As Integer = {0, 1, 3}
        consulta = "select * from tipomateriaprima,proveedorxtipomateriaprima where proveedorxtipomateriaprima.idtipomateriaprima=tipomateriaprima.idtipomateriaprima and proveedorxtipomateriaprima.idproveedor=" & DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)
        indice = 0
        cargarLista(lista2, consulta, indice, columnas)
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(dsProveedor, "proveedor").Position -= 1
        mostrarPosicion("proveedor")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dsProveedor, "proveedor").Position = 0
        mostrarPosicion("proveedor")
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dsProveedor, "proveedor").Position = BindingContext(dsProveedor, "proveedor").Count - 1
        mostrarPosicion("proveedor")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dsProveedor, "proveedor").Position += 1
        mostrarPosicion("proveedor")
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        bandgrabar = 1
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        UltraButton10.Enabled = True
        UltraButton11.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.SelectedIndex = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        lista2.Items.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bandgrabar = 2
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        UltraButton10.Enabled = True
        UltraButton11.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        If 6 = MsgBox("Esta seguro que desea eliminar a " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 1), MsgBoxStyle.YesNo, "Eliminar Proveedor") Then
            cnn.Open()
            Dim filaEliminar As Integer
            filaEliminar = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
            Dim tbemptransp As DataTable = dsProveedor.Tables.Item(0)
            For i As Integer = 0 To tbemptransp.Rows.Count - 1
                If tbemptransp.Rows(i)(0) = filaEliminar Then
                    tbemptransp.Rows(i).Delete()
                End If
            Next
            adaptadorP.DeleteCommand = New SqlClient.SqlCommand("DELETE from proveedorxtipomateriaprima WHERE (idproveedor =" & filaEliminar & ")", cnn)
            adaptadorP.DeleteCommand.ExecuteNonQuery()
            adaptadorP.DeleteCommand = New SqlClient.SqlCommand("DELETE from proveedor WHERE (idproveedor =" & filaEliminar & ")", cnn)
            adaptadorP.DeleteCommand.ExecuteNonQuery()
            cnn.Close()
        End If

        Call UltraButton8_Click(Nothing, Nothing)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        If lista2.Items.Count < 1 Then
            MessageBox.Show("Debe agregar Materias Primas", "Materia Prima", MessageBoxButtons.OK)
            Exit Sub
        End If
        Dim tbproveedor As DataTable = dsProveedor.Tables.Item(0)
        cnn.Open()
        If bandgrabar = 1 Then
            Dim idmaximo() As DataRow
            Dim maximo As Integer
            idmaximo = tbproveedor.Select("idproveedor=max(idproveedor)")
            maximo = CType(idmaximo(0).Item(0), Integer) + 1
            'Dim cfilas As DataRowCollection = tbcliente.Rows
            Dim nuevafila As DataRow

            Try
                nuevafila = tbproveedor.NewRow()
                nuevafila(0) = maximo
                nuevafila(1) = TextBox1.Text
                nuevafila(2) = TextBox2.Text
                nuevafila(3) = TextBox3.Text
                nuevafila(4) = TextBox4.Text
                nuevafila(5) = TextBox5.Text
                nuevafila(6) = ComboBox1.Text
                nuevafila(7) = ComboBox1.SelectedValue
                tbproveedor.Rows.Add(nuevafila)
                'cfilas.Add(nuevafila)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'adaptador.Update(dscliente, "cliente")
            adaptadorP.InsertCommand = New SqlClient.SqlCommand("INSERT INTO proveedor(idproveedor, nombre, direccion, telefono,mail,nombrecontacto,idlocalidad) VALUES(" & maximo & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "'," & ComboBox1.SelectedValue & ")", cnn)
            adaptadorP.InsertCommand.ExecuteNonQuery()
            For i As Integer = 0 To lista2.Items.Count - 1
                adaptadorP.InsertCommand = New SqlClient.SqlCommand("INSERT INTO proveedorxtipomateriaprima(idproveedor, idtipomateriaprima) VALUES(" & maximo & "," & lista2.Items(i).SubItems(0).Text & ")", cnn)
                adaptadorP.InsertCommand.ExecuteNonQuery()
            Next


        Else
            For Each updatefila As DataRow In tbproveedor.Rows
                If updatefila(0) = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) Then
                    updatefila(1) = TextBox1.Text
                    updatefila(2) = TextBox2.Text
                    updatefila(3) = TextBox3.Text
                    updatefila(4) = TextBox4.Text
                    updatefila(5) = TextBox5.Text
                    updatefila(6) = ComboBox1.Text
                    updatefila(7) = ComboBox1.SelectedValue
                End If
            Next

            adaptadorP.UpdateCommand = New SqlClient.SqlCommand("UPDATE proveedor SET nombre ='" & TextBox1.Text & "', direccion='" & TextBox2.Text & "', telefono='" & TextBox3.Text & "',mail='" & TextBox4.Text & "',nombrecontacto='" & TextBox5.Text & "',idlocalidad=" & ComboBox1.SelectedValue & " WHERE (idproveedor =" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & ")", cnn)
            adaptadorP.UpdateCommand.ExecuteNonQuery()

            adaptadorP.DeleteCommand = New SqlClient.SqlCommand("DELETE from proveedorxtipomateriaprima WHERE (idproveedor =" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & ")", cnn)
            adaptadorP.DeleteCommand.ExecuteNonQuery()

            For i As Integer = 0 To lista2.Items.Count - 1
                adaptadorP.InsertCommand = New SqlClient.SqlCommand("INSERT INTO proveedorxtipomateriaprima(idproveedor, idtipomateriaprima) VALUES(" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & "," & lista2.Items(i).SubItems(0).Text & ")", cnn)
                adaptadorP.InsertCommand.ExecuteNonQuery()
            Next

        End If
        cnn.Close()
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False
        UltraButton10.Enabled = False
        UltraButton11.Enabled = False

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False
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
        ComboBox1.Enabled = False
    End Sub

    Private Sub abmProveedores_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub UltraButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton11.Click
        Dim item As ListViewItem
        Dim t As Integer



        If lista1.SelectedIndices.Count <> 0 Then

            t = lista1.SelectedItems.Item(0).SubItems(0).Text
            For Each item In lista2.Items
                If t = item.SubItems(0).Text Then
                    MsgBox("Esta Materia Prima ya se encuentra en la lista", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Next
            item = lista2.Items.Add(lista1.SelectedItems.Item(0).SubItems(0).Text)
            item.SubItems.Add(lista1.SelectedItems.Item(0).SubItems(1).Text)
            item.SubItems.Add(lista1.SelectedItems.Item(0).SubItems(2).Text)
            item.Tag = lista1.SelectedItems.Item(0).Tag
        End If
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        If lista2.SelectedIndices.Count <> 0 Then
            lista2.SelectedItems.Item(0).Remove()
        End If
    End Sub

End Class