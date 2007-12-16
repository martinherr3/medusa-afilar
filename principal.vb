Imports System.Configuration.ConfigurationSettings

Public Class principal
    Inherits System.Windows.Forms.Form
    Friend barra As BarraDeEstado
    Private i As System.Drawing.Image
    Private band As Boolean = True
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public mMenu As New System.Windows.Forms.MainMenu()
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Private logeo As New LoginForm
    Friend WithEvents myMenu As New MenuItem("Ayuda")



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
    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents UltraStatusBar1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents etiPrin As System.Windows.Forms.Label
    Friend WithEvents botonPinche As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.UltraStatusBar1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar
        Me.etiPrin = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.botonPinche = New Infragistics.Win.Misc.UltraButton
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraExplorerBar1
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(197, Byte), Integer))
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.ItalicAsString = "False"
        Appearance1.FontData.Name = "Arial"
        Appearance1.FontData.UnderlineAsString = "False"
        Appearance1.ForeColor = System.Drawing.Color.White
        Me.UltraExplorerBar1.Appearance = Appearance1
        Me.UltraExplorerBar1.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.UltraExplorerBar1.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 7.8!
        Appearance2.ImageAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraExplorerBar1.ItemSettings.AppearancesSmall.Appearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance3.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.UltraExplorerBar1.ItemSettings.AppearancesSmall.HotTrackAppearance = Appearance3
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(0, 108)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.ShowDefaultContextMenu = False
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(200, 585)
        Me.UltraExplorerBar1.StateButtonCheckStyle = Infragistics.Win.UltraWinExplorerBar.StateButtonCheckStyle.ExclusiveWithinGroup
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Listbar
        Me.UltraExplorerBar1.TabIndex = 2
        Me.UltraExplorerBar1.UseLargeGroupHeaderImages = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraExplorerBar1.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.Office2003
        '
        'UltraStatusBar1
        '
        Appearance4.BackColor = System.Drawing.Color.SteelBlue
        Appearance4.BackColor2 = System.Drawing.Color.SteelBlue
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Appearance4.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Appearance4.BorderColor3DBase = System.Drawing.Color.White
        Appearance4.ForeColor = System.Drawing.Color.White
        Me.UltraStatusBar1.Appearance = Appearance4
        Me.UltraStatusBar1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D
        Me.UltraStatusBar1.Location = New System.Drawing.Point(0, 699)
        Me.UltraStatusBar1.Name = "UltraStatusBar1"
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.Name = "Microsoft Sans Serif"
        Appearance5.FontData.SizeInPoints = 8.0!
        Appearance5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UltraStatusBar1.PanelAppearance = Appearance5
        Me.UltraStatusBar1.Size = New System.Drawing.Size(960, 26)
        Me.UltraStatusBar1.SupportThemes = False
        Me.UltraStatusBar1.TabIndex = 8
        '
        'etiPrin
        '
        Me.etiPrin.AutoSize = True
        Me.etiPrin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.etiPrin.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPrin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.etiPrin.Location = New System.Drawing.Point(192, 36)
        Me.etiPrin.Name = "etiPrin"
        Me.etiPrin.Size = New System.Drawing.Size(163, 41)
        Me.etiPrin.TabIndex = 13
        Me.etiPrin.Text = "MEDUSA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(787, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tiempo"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 20
        '
        'botonPinche
        '
        Appearance6.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonPinche.Appearance = Appearance6
        Me.botonPinche.Location = New System.Drawing.Point(110, 85)
        Me.botonPinche.Name = "botonPinche"
        Me.botonPinche.ShapeImage = CType(resources.GetObject("botonPinche.ShapeImage"), System.Drawing.Image)
        Me.botonPinche.Size = New System.Drawing.Size(18, 22)
        Me.botonPinche.TabIndex = 16
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(72, 56)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1030, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(788, 56)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 15)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LinkLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.LinkLabel3.Location = New System.Drawing.Point(148, 11)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(52, 15)
        Me.LinkLabel3.TabIndex = 26
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Sing Off"
        '
        'principal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(960, 725)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.etiPrin)
        Me.Controls.Add(Me.botonPinche)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.UltraExplorerBar1)
        Me.Controls.Add(Me.UltraStatusBar1)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "principal"
        Me.Text = "Medusa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub principal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    'Private Sub principal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    MessageBox.Show("KD")
    '    If e.KeyCode = Keys.F1 Then
    '        MessageBox.Show("KD1")
    '    End If
    'End Sub

    'Private Sub principal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    '    MessageBox.Show("KP1")
    '    If e.KeyChar = Keys.F1.ToString Then
    '        MessageBox.Show("KP")
    '    End If
    'End Sub

    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquearPantalla(True)
        logeo.ShowDialog()
        bloquearPantalla(False)
        
        barra = New BarraDeEstado(UltraStatusBar1)
        Actualizar()

        mMenu.MenuItems.Add(myMenu)
        'GestorFrm.InitMenu(Me.UltraExplorerBar1, mMenu, Me)
        'Me.Menu = mMenu
        Mensajeria.getMensajes(seguridad.id, LinkLabel1)
        acomodarImagenes()

    End Sub

    Private Sub myMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myMenu.Click
        Help.ShowHelp(Me, "C:\Documents and Settings\Agu699\Mis documentos\Afilar\Ayuda\ayuda_medusa.chm")
    End Sub

    'private sub btnAyuda_Click() Handle myMenu.Click

    Public Sub acomodarImagenes()
        PictureBox1.Width = Me.Width
        UltraExplorerBar1.Height = Me.Height - 185

    End Sub

    Public Sub Actualizar()
        UltraExplorerBar1.Groups.Clear()
        mMenu.MenuItems.Clear()

        '
        Me.etiPrin.Text = "Afilar"
        Me.barra.ClearAll()
        Dim formulario As Form
        For Each formulario In Me.MdiChildren
            formulario.Close()
        Next


        '
        GestorFrm.InitMenu(Me.UltraExplorerBar1, mMenu, Me)
        Me.Menu = mMenu
        Me.Refresh()

    End Sub

    Public Sub mnu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim formtoopen As String
        formtoopen = CType(sender, MenuItem).Tag
        formtoopen = Trim(formtoopen)
        GestorFrm.OpenForm(formtoopen, Me)
    End Sub

    Private Sub bloquearPantalla(ByVal ban As Boolean)
        If ban Then
            Panel1.Height = Me.Height
            Panel1.Width = Me.Width
        Else
            Panel1.Height = 0
            Panel1.Width = 0
        End If

    End Sub

    Private Sub UltraExplorerBar1_ItemClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles UltraExplorerBar1.ItemClick
        GestorFrm.OpenForm(Me.UltraExplorerBar1.ActiveItem.Key, Me)
    End Sub

    Private Sub UltraStatusBar1_ButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinStatusBar.PanelEventArgs) Handles UltraStatusBar1.ButtonClick
        barra.click()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmControlCalidad
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Registrar Control"
    End Sub

    Private Sub UltraExplorerBar1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraExplorerBar1.MouseHover
        If band = False Then
            Dim i As Integer
            For i = 40 To 220 Step 36
                Me.UltraExplorerBar1.Width = i
                Me.UltraExplorerBar1.Refresh()
            Next
            Me.UltraExplorerBar1.Width = 220
            Me.UltraExplorerBar1.Refresh()
        End If

    End Sub

    Private Sub UltraExplorerBar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraExplorerBar1.MouseLeave
        If band = False Then
            Me.UltraExplorerBar1.Width = 40
            Me.UltraExplorerBar1.Refresh()
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonPinche.Click
        Dim projectPath As String
        projectPath = getAppPath()

        If band = True Then
            botonPinche.ShapeImage = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\pinche4.ico")
            Me.UltraExplorerBar1.Width = 40
            band = False
        Else
            botonPinche.ShapeImage = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\pinche3.ico")
            Me.UltraExplorerBar1.Width = 200
            band = True
        End If
    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Help.ShowHelp(Me, "D:\TESIS\Medusa\Afilar 14-11-05\ayuda2\afilar.chm")
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Now '.Hour & ":" & Now.Minute & ":" & Now.Second
        Mensajeria.getMensajes(seguridad.id, LinkLabel1)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form As New frmMensajes
        form.MdiParent = Me
        form.Show()
        form.Location = New Point(200, 106)
    End Sub

    Private Sub principal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        acomodarImagenes()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        bloquearPantalla(True)
        logeo.ShowDialog()
        bloquearPantalla(False)
        'Dim form As New frmSegProd
        ' form.MdiParent = Me
        ' form.Show()
        ' form.Location = New Point(500, 200)

        barra = New BarraDeEstado(UltraStatusBar1)
        Actualizar()
        'GestorFrm.InitMenu(Me.UltraExplorerBar1, mMenu, Me)
        'Me.Menu = mMenu
        Mensajeria.getMensajes(seguridad.id, LinkLabel1)
        acomodarImagenes()

    End Sub
End Class
