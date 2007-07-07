Public Class frmEmpresaTransp
    Inherits System.Windows.Forms.Form
    Dim consulta As String = "select idempresa, nombre, Direccion, Telefono from empresatransporte"
    Dim adaptadorET As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(consulta, cnn)
    Dim dsET As New DataSet
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton11 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lista2 As System.Windows.Forms.ListView
    Friend WithEvents lista1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TextBox3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Salir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton12 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
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
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton12 = New Infragistics.Win.Misc.UltraButton
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
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
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(644, 305)
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(544, 276)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(80, 24)
        Me.Salir.TabIndex = 42
        Me.Salir.Text = "Salir"
        '
        'TextBox3
        '
        Appearance1.BackColorDisabled = System.Drawing.Color.White
        Me.TextBox3.Appearance = Appearance1
        Me.TextBox3.AutoSize = True
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(72, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 21)
        Me.TextBox3.TabIndex = 41
        '
        'TextBox2
        '
        Appearance2.BackColorDisabled = System.Drawing.Color.White
        Me.TextBox2.Appearance = Appearance2
        Me.TextBox2.AutoSize = True
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(376, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(248, 21)
        Me.TextBox2.TabIndex = 40
        '
        'UltraGroupBox3
        '
        Appearance3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance3
        Me.UltraGroupBox3.Controls.Add(Me.UltraButton10)
        Me.UltraGroupBox3.Controls.Add(Me.UltraButton11)
        Me.UltraGroupBox3.Controls.Add(Me.lista2)
        Me.UltraGroupBox3.Controls.Add(Me.lista1)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(16, 136)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(608, 136)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 39
        Me.UltraGroupBox3.Text = "Localidades Disponibles                                                          " & _
            "                Localidades a donde llega actualmente"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton10
        '
        Me.UltraButton10.Enabled = False
        Me.UltraButton10.Location = New System.Drawing.Point(272, 80)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(56, 24)
        Me.UltraButton10.TabIndex = 2
        Me.UltraButton10.Text = "<<"
        '
        'UltraButton11
        '
        Me.UltraButton11.Enabled = False
        Me.UltraButton11.Location = New System.Drawing.Point(272, 48)
        Me.UltraButton11.Name = "UltraButton11"
        Me.UltraButton11.Size = New System.Drawing.Size(56, 24)
        Me.UltraButton11.TabIndex = 1
        Me.UltraButton11.Text = ">>"
        '
        'lista2
        '
        Me.lista2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lista2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lista2.FullRowSelect = True
        Me.lista2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista2.Location = New System.Drawing.Point(336, 24)
        Me.lista2.Name = "lista2"
        Me.lista2.Size = New System.Drawing.Size(264, 104)
        Me.lista2.TabIndex = 3
        Me.lista2.UseCompatibleStateImageBehavior = False
        Me.lista2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ID"
        Me.ColumnHeader10.Width = 57
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nombre"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Provincia"
        Me.ColumnHeader6.Width = 80
        '
        'lista1
        '
        Me.lista1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lista1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lista1.FullRowSelect = True
        Me.lista1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista1.Location = New System.Drawing.Point(8, 24)
        Me.lista1.Name = "lista1"
        Me.lista1.Size = New System.Drawing.Size(256, 104)
        Me.lista1.TabIndex = 0
        Me.lista1.UseCompatibleStateImageBehavior = False
        Me.lista1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Provincia"
        Me.ColumnHeader3.Width = 80
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(325, 20)
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
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(240, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 36
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraButton7
        '
        Me.UltraButton7.Location = New System.Drawing.Point(184, 24)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton7.TabIndex = 3
        Me.UltraButton7.Text = ">"
        '
        'UltraButton6
        '
        Me.UltraButton6.Location = New System.Drawing.Point(144, 24)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton6.TabIndex = 2
        Me.UltraButton6.Text = ">>"
        '
        'UltraButton8
        '
        Me.UltraButton8.Location = New System.Drawing.Point(56, 24)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton8.TabIndex = 1
        Me.UltraButton8.Text = "<<"
        '
        'UltraButton9
        '
        Me.UltraButton9.Location = New System.Drawing.Point(16, 24)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton9.TabIndex = 0
        Me.UltraButton9.Text = "<"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(101, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 22)
        Me.Label9.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Telefono"
        '
        'TextBox1
        '
        Appearance4.BackColorDisabled = System.Drawing.Color.White
        Me.TextBox1.Appearance = Appearance4
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(72, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 21)
        Me.TextBox1.TabIndex = 5
        '
        'UltraButton4
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.UltraButton4.Appearance = Appearance5
        Me.UltraButton4.Location = New System.Drawing.Point(368, 104)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(120, 24)
        Me.UltraButton4.TabIndex = 3
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(368, 72)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 0
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(456, 72)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton2.TabIndex = 1
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(544, 72)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton3.TabIndex = 2
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(512, 104)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(112, 24)
        Me.UltraButton5.TabIndex = 4
        Me.UltraButton5.Text = "&Cancelar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nombre"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton12)
        Me.UltraTabPageControl2.Controls.Add(Me.DataGrid1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(644, 305)
        '
        'UltraButton12
        '
        Me.UltraButton12.Location = New System.Drawing.Point(520, 272)
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
        Me.DataGrid1.CaptionText = "Empresa de transporte"
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
        Me.DataGrid1.Location = New System.Drawing.Point(40, 24)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(560, 232)
        Me.DataGrid1.TabIndex = 20
        '
        'UltraTabControl1
        '
        Appearance6.BackColor = System.Drawing.Color.Silver
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance7.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance8.BackHatchStyle = Infragistics.Win.BackHatchStyle.None
        Me.UltraTabControl1.ClientAreaAppearance = Appearance8
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 16)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(648, 328)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 21
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
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(644, 305)
        '
        'frmEmpresaTransp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 344)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmEmpresaTransp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestionar Empresa de Transporte"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
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
        Dim bmbase As BindingManagerBase = BindingContext.Item(dsET, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label9.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label9.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub frmEmpresaTransp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        adaptadorET.Fill(dsET, "empresatransporte")
        DataGrid1.DataSource = dsET
        DataGrid1.DataMember = "empresatransporte"

        Dim nombrescol(4) As String
        nombrescol(0) = "ID Empresa"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Direccion"
        nombrescol(3) = "Telefono"

        Dim anchosgrid(4) As Integer
        anchosgrid(0) = 100
        anchosgrid(1) = 150
        anchosgrid(2) = 150
        anchosgrid(3) = 100
        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsET.Tables.Item(0), nombrescol, anchosgrid)
        Dim consulta As String
        Dim indice As Integer
        Dim columnas() As Integer = {0, 5, 3}
        consulta = "select * from localidad"         'cargo lista de localidades
        indice = 0
        cargarLista(lista1, consulta, indice, columnas)

        TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        TextBox2.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
        TextBox3.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)

        
        consulta = "select * from localidad,empresaxlocalidad where empresaxlocalidad.idlocalidad=localidad.idlocalidad and empresaxlocalidad.idempresa=" & DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)
        indice = 0
        cargarLista(lista2, consulta, indice, columnas)

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        TextBox2.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
        TextBox3.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)



        'TextBox1.Text = dsET.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(1)
        'TextBox2.Text = dsET.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2)
        'TextBox3.Text = dsET.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3)
        'For i As Integer = 0 To lista2.SelectedIndices.Count - 1
        '    lista2.SelectedItems.Item(0).Remove()
        'Next
        lista2.Items.Clear()
        Dim consulta As String
        Dim indice As Integer
        Dim columnas() As Integer = {0, 5, 3}
        consulta = "select * from localidad,empresaxlocalidad where empresaxlocalidad.idlocalidad=localidad.idlocalidad and empresaxlocalidad.idempresa=" & DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)
        indice = 0
        cargarLista(lista2, consulta, indice, columnas)
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(dsET, "empresatransporte").Position -= 1
        mostrarPosicion("empresatransporte")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dsET, "empresatransporte").Position = 0
        mostrarPosicion("empresatransporte")
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dsET, "empresatransporte").Position = BindingContext(dsET, "empresatransporte").Count - 1
        mostrarPosicion("empresatransporte")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dsET, "empresatransporte").Position += 1
        mostrarPosicion("empresatransporte")
    End Sub

    Private Sub frmEmpresaTransp_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
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
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
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
        TextBox1.Focus()
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        If 6 = MsgBox("Esta seguro que desea eliminar a " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 1), MsgBoxStyle.YesNo, "Eliminar Empresa Transporte") Then
            cnn.Open()
            Dim filaEliminar As Integer
            filaEliminar = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
            Dim tbemptransp As DataTable = dsET.Tables.Item(0)
            For i As Integer = 0 To tbemptransp.Rows.Count - 1
                If tbemptransp.Rows(i)(0) = filaEliminar Then
                    tbemptransp.Rows(i).Delete()
                End If
            Next
            adaptadorET.DeleteCommand = New SqlClient.SqlCommand("DELETE from empresaxlocalidad WHERE (idempresa =" & filaEliminar & ")", cnn)
            adaptadorET.DeleteCommand.ExecuteNonQuery()
            adaptadorET.DeleteCommand = New SqlClient.SqlCommand("DELETE from empresatransporte WHERE (idempresa =" & filaEliminar & ")", cnn)
            adaptadorET.DeleteCommand.ExecuteNonQuery()
            
            cnn.Close()
        End If
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        If lista2.Items.Count < 1 Then
            MessageBox.Show("Debe agregar localidades", "Localidades", MessageBoxButtons.OK)
            Exit Sub
        End If
        Dim tbemptransp As DataTable = dsET.Tables.Item(0)
        cnn.Open()
        If bandgrabar = 1 Then
            Dim idmaximo() As DataRow
            Dim maximo As Integer
            idmaximo = tbemptransp.Select("idempresa=max(idempresa)")
            maximo = CType(idmaximo(0).Item(0), Integer) + 1
            'Dim cfilas As DataRowCollection = tbcliente.Rows
            Dim nuevafila As DataRow

            Try
                nuevafila = tbemptransp.NewRow()
                nuevafila(0) = maximo
                nuevafila(1) = TextBox1.Text
                nuevafila(2) = TextBox2.Text
                nuevafila(3) = TextBox3.Text
                tbemptransp.Rows.Add(nuevafila)
                'cfilas.Add(nuevafila)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'adaptador.Update(dscliente, "cliente")
            adaptadorET.InsertCommand = New SqlClient.SqlCommand("INSERT INTO empresatransporte(idempresa, nombre, direccion, telefono) VALUES(" & maximo & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", cnn)
            adaptadorET.InsertCommand.ExecuteNonQuery()
            For i As Integer = 0 To lista2.Items.Count - 1
                adaptadorET.InsertCommand = New SqlClient.SqlCommand("INSERT INTO empresaxlocalidad(idempresa, idlocalidad) VALUES(" & maximo & "," & lista2.Items(i).SubItems(0).Text & ")", cnn)
                adaptadorET.InsertCommand.ExecuteNonQuery()
            Next


        Else
            For Each updatefila As DataRow In tbemptransp.Rows
                If updatefila(0) = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) Then
                    updatefila(1) = TextBox1.Text
                    updatefila(2) = TextBox2.Text
                    updatefila(3) = TextBox3.Text
                End If
            Next

            adaptadorET.UpdateCommand = New SqlClient.SqlCommand("UPDATE empresatransporte SET nombre ='" & TextBox1.Text & "', direccion='" & TextBox2.Text & "', telefono='" & TextBox3.Text & "' WHERE (idempresa =" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & ")", cnn)
            adaptadorET.UpdateCommand.ExecuteNonQuery()

            adaptadorET.DeleteCommand = New SqlClient.SqlCommand("DELETE from empresaxlocalidad WHERE (idempresa =" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & ")", cnn)
            adaptadorET.DeleteCommand.ExecuteNonQuery()

            For i As Integer = 0 To lista2.Items.Count - 1
                adaptadorET.InsertCommand = New SqlClient.SqlCommand("INSERT INTO empresaxlocalidad(idempresa, idlocalidad) VALUES(" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & "," & lista2.Items(i).SubItems(0).Text & ")", cnn)
                adaptadorET.InsertCommand.ExecuteNonQuery()
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
    End Sub

    Private Sub UltraButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton11.Click
        Dim item As ListViewItem
        Dim t As Integer



        If lista1.SelectedIndices.Count <> 0 Then

            t = lista1.SelectedItems.Item(0).SubItems(0).Text
            For Each item In lista2.Items
                If t = item.SubItems(0).Text Then
                    MsgBox("Esta Localidad ya existe en la lista", MsgBoxStyle.Information)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As String
        s = "hh"
    End Sub

  
    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub UltraButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton12.Click
        Me.Close()
    End Sub


End Class
