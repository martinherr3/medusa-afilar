Public Class abmOperacion
    Inherits System.Windows.Forms.Form
    Private operacion As New operacion
    Private dif As New gradoDificultad
    Private ds As New DataSet
    Private nom(6) As String
    Private ancho(6) As Integer
    Private ds2 As New DataSet
    Private tabla As String = "operacion"
    Private fila As DataRow


    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(ds, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label8.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label8.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub


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
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents combo1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboDif As Infragistics.Win.UltraWinEditors.UltraComboEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.comboDif = New Infragistics.Win.UltraWinEditors.UltraComboEditor
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
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.comboDif, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.comboDif)
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
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(644, 257)
        '
        'UltraGroupBox1
        '
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
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(95, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 24)
        Me.Label8.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Tolerancia"
        '
        'comboDif
        '
        Me.comboDif.Location = New System.Drawing.Point(96, 120)
        Me.comboDif.Name = "comboDif"
        Me.comboDif.Size = New System.Drawing.Size(176, 21)
        Me.comboDif.TabIndex = 44
        '
        'UltraButton4
        '
        Me.UltraButton4.Location = New System.Drawing.Point(344, 224)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton4.TabIndex = 40
        Me.UltraButton4.Text = "Nuevo"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(416, 224)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton3.TabIndex = 39
        Me.UltraButton3.Text = "Guardar"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(488, 224)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton2.TabIndex = 38
        Me.UltraButton2.Text = "Modificar"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(560, 224)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton1.TabIndex = 37
        Me.UltraButton1.Text = "Salir"
        '
        'combo1
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Me.combo1.Appearance = Appearance1
        Me.combo1.Location = New System.Drawing.Point(96, 72)
        Me.combo1.Name = "combo1"
        Me.combo1.ReadOnly = True
        Me.combo1.Size = New System.Drawing.Size(176, 21)
        Me.combo1.TabIndex = 36
        '
        'text4
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Me.text4.Appearance = Appearance2
        Me.text4.Location = New System.Drawing.Point(96, 96)
        Me.text4.Name = "text4"
        Me.text4.ReadOnly = True
        Me.text4.Size = New System.Drawing.Size(88, 21)
        Me.text4.TabIndex = 35
        '
        'text3
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Me.text3.Appearance = Appearance3
        Me.text3.Location = New System.Drawing.Point(96, 144)
        Me.text3.Name = "text3"
        Me.text3.ReadOnly = True
        Me.text3.Size = New System.Drawing.Size(176, 21)
        Me.text3.TabIndex = 34
        '
        'text2
        '
        Appearance4.BackColor = System.Drawing.Color.White
        Me.text2.Appearance = Appearance4
        Me.text2.Location = New System.Drawing.Point(96, 48)
        Me.text2.Name = "text2"
        Me.text2.ReadOnly = True
        Me.text2.Size = New System.Drawing.Size(176, 21)
        Me.text2.TabIndex = 33
        '
        'text1
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Me.text1.Appearance = Appearance5
        Me.text1.Location = New System.Drawing.Point(96, 24)
        Me.text1.Name = "text1"
        Me.text1.ReadOnly = True
        Me.text1.Size = New System.Drawing.Size(88, 21)
        Me.text1.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Dificultad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Duración promedio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tipo máquina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ID"
        '
        'text5
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Me.text5.Appearance = Appearance6
        Me.text5.Location = New System.Drawing.Point(312, 48)
        Me.text5.Multiline = True
        Me.text5.Name = "text5"
        Me.text5.ReadOnly = True
        Me.text5.Size = New System.Drawing.Size(296, 112)
        Me.text5.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
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
        Me.DataGrid1.CaptionText = "Operaciones"
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
        Me.DataGrid1.Size = New System.Drawing.Size(600, 200)
        Me.DataGrid1.TabIndex = 0
        '
        'UltraTabControl1
        '
        Appearance7.BackColor = System.Drawing.Color.Silver
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance9
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(648, 280)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 1
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
        'abmOperacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(642, 288)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 106)
        Me.Name = "abmOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión operación"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.comboDif, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub abmOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        operacion.cargarAdaptador()
        operacion.cargarDatos(ds, "operacion")

        dif.cargarAdaptador()
        dif.cargarDatos(ds, "gradoDificultad")

        crearRelacion(ds, "gradoDificultad", "operacion", "idgradodificultad", "idgradodificultad", "Dificultad")

        nom(0) = "ID"
        nom(1) = "Nombre"
        nom(2) = "ID maquina"
        nom(3) = "Duración promedio"
        nom(4) = "ID dificultad"
        nom(5) = "Tolerancia"
        nom(6) = "Descripción"

        ancho(0) = 60
        ancho(1) = 120
        ancho(2) = 75
        ancho(3) = 110
        ancho(4) = 75
        ancho(5) = 75
        ancho(6) = 75

        cargarGrilla(DataGrid1, ds.Tables("operacion"), nom, ancho)

        DataGrid1.DataSource = ds
        DataGrid1.DataMember = "operacion"

        Me.text1.DataBindings.Add("Text", ds, "operacion.idoperacion")
        Me.text2.DataBindings.Add("Text", ds, "operacion.nombre")
        Me.text3.DataBindings.Add("Text", ds, "operacion.tolerancia")
        Me.text4.DataBindings.Add("Text", ds, "operacion.duracionpromedio")
        Me.text5.DataBindings.Add("Text", ds, "operacion.descripcion")
        Me.combo1.DataBindings.Add("Text", ds, "operacion.maquina")
        Me.comboDif.DataBindings.Add("Tag", ds, "operacion.idgradodificultad")


        cargarComboTag("select idgradodificultad, nombre from gradodificultad", comboDif, 0, 12)

        fila = ds.Tables("operacion").Rows(text1.Text - 1).GetParentRow("Dificultad")
        comboDif.Text = fila.Item(1)

        mostrarPosicion("operacion")


        princ.barra.agregarBoton(Me)


    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub



    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click

        'comboDif.DataBindings.Clear()
        'comboDif.Clear()
        'cargarComboTag("select idgradodificultad, nombre from gradodificultad", comboDif, 0, 2)

        'text1.ReadOnly = False
        text2.ReadOnly = False
        text3.ReadOnly = False
        text4.ReadOnly = False
        text5.ReadOnly = False
        combo1.ReadOnly = False
        comboDif.ReadOnly = False

        text1.Focus()

        'text1.BackColor() = System.Drawing.Color.LightCyan
        text2.BackColor() = System.Drawing.Color.LightCyan
        text3.BackColor() = System.Drawing.Color.LightCyan
        text4.BackColor() = System.Drawing.Color.LightCyan
        text5.BackColor() = System.Drawing.Color.LightCyan
        combo1.BackColor() = System.Drawing.Color.LightCyan
        comboDif.BackColor() = System.Drawing.Color.LightCyan
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click

        BindingContext(ds, tabla).Position += 1
        BindingContext(ds, tabla).Position -= 1
        mostrarPosicion(tabla)

        'UltraButton9.PerformClick()     'comandos mágicos para que actualice la base
        'UltraButton7.PerformClick()
        'MsgBox(comboDif.SelectedItem.Tag)

        operacion.actualizarDatos(ds, "operacion")

        text1.ReadOnly = True
        text2.ReadOnly = True
        text3.ReadOnly = True
        text4.ReadOnly = True
        text5.ReadOnly = True
        combo1.ReadOnly = True
        comboDif.ReadOnly = True

        text1.BackColor() = System.Drawing.Color.White      'cambio color de los text
        text2.BackColor() = System.Drawing.Color.White
        text3.BackColor() = System.Drawing.Color.White
        text4.BackColor() = System.Drawing.Color.White
        text5.BackColor() = System.Drawing.Color.White
        combo1.BackColor() = System.Drawing.Color.White
        comboDif.BackColor() = System.Drawing.Color.White

        

    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Dim nuevo As DataRow
        Dim id As Integer

        id = ds.Tables(0).Rows.Count + 1


        Try
            nuevo = ds.Tables(0).NewRow     'creo una nueva fila de la tabla maquinafresa



            nuevo("idoperacion") = id         'le doy valores nulos
            nuevo("nombre") = ""
            nuevo("maquina") = 0
            nuevo("duracionpromedio") = 0
            'nuevo("idgradodificultad") = 1
            nuevo("tolerancia") = 0
            nuevo("descripcion") = ""



            ds.Tables(0).Rows.Add(nuevo)

            'cargarComboTag("select idgradodificultad, nombre from gradodificultad", comboDif, 0, 2)

            BindingContext(ds, tabla).Position = BindingContext(ds, tabla).Count - 1

            mostrarPosicion(tabla)

            text1.Focus()


        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try


        text1.ReadOnly = False          'seteo la propiedad de los text para que se pueda escribir
        text2.ReadOnly = False
        text3.ReadOnly = False
        text4.ReadOnly = False
        text5.ReadOnly = False
        combo1.ReadOnly = False
        comboDif.ReadOnly = False

        text1.Focus()

        text1.BackColor() = System.Drawing.Color.LightCyan      'cambio color de los text
        text2.BackColor() = System.Drawing.Color.LightCyan
        text3.BackColor() = System.Drawing.Color.LightCyan
        text4.BackColor() = System.Drawing.Color.LightCyan
        text5.BackColor() = System.Drawing.Color.LightCyan
        combo1.BackColor() = System.Drawing.Color.LightCyan
        comboDif.BackColor() = System.Drawing.Color.LightCyan

    End Sub



    Private Sub UltraButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(ds, tabla).Position += 1
        mostrarPosicion(tabla)
        fila = ds.Tables("operacion").Rows(text1.Text - 1).GetParentRow("Dificultad")
        comboDif.Text = fila.Item(1)
    End Sub

    Private Sub UltraButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(ds, tabla).Position = BindingContext(ds, tabla).Count - 1
        mostrarPosicion(tabla)
        fila = ds.Tables("operacion").Rows(text1.Text - 1).GetParentRow("Dificultad")
        comboDif.Text = fila.Item(1)
    End Sub

    Private Sub UltraButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(ds, tabla).Position = 0
        mostrarPosicion(tabla)
        fila = ds.Tables("operacion").Rows(text1.Text - 1).GetParentRow("Dificultad")
        comboDif.Text = fila.Item(1)
    End Sub

    Private Sub UltraButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(ds, tabla).Position -= 1
        mostrarPosicion(tabla)
        fila = ds.Tables("operacion").Rows(text1.Text - 1).GetParentRow("Dificultad")
        comboDif.Text = fila.Item(1)
    End Sub

    Private Sub abmOperacion_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub
End Class
