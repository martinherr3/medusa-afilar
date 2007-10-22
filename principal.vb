Imports System.Configuration.ConfigurationSettings

Public Class principal
    Inherits System.Windows.Forms.Form
    Friend barra As BarraDeEstado
    Private i As System.Drawing.Image
    Private band As Boolean = True
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public mMenu As New System.Windows.Forms.MainMenu()
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Private logeo As New LoginForm


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
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(200, 588)
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

    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquearPantalla(True)
        logeo.ShowDialog()
        bloquearPantalla(False)
        Dim form As New frmSegProd
        form.MdiParent = Me
        form.Show()
        form.Location = New Point(500, 200)
        barra = New BarraDeEstado(UltraStatusBar1)
        Actualizar()
        'GestorFrm.InitMenu(Me.UltraExplorerBar1, mMenu, Me)
        'Me.Menu = mMenu
        Mensajeria.getMensajes(seguridad.id, LinkLabel1)
        acomodarImagenes()

    End Sub

    Public Sub acomodarImagenes()
        PictureBox1.Width = Me.Width
        UltraExplorerBar1.Height = Me.Height - 192

    End Sub

    Public Sub Actualizar()
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

        'If Me.UltraExplorerBar1.Groups(0).Items(0).Active Then
        '    Dim programarProduccion As New registrarModeloFresa
        '    programarProduccion.MdiParent = Me
        '    programarProduccion.Show()
        '    'etiPrin.Text = "Registrar modelo de fresa"
        'End If

        'If Me.UltraExplorerBar1.Groups(0).Items(1).Active Then
        '    Dim form8 As New programarProduccion
        '    form8.MdiParent = Me
        '    form8.Show()

        'End If



        'If Me.UltraExplorerBar1.Groups(1).Items(0).Active Then
        '    Dim FrmGenerarOC As New FrmGenerarOC
        '    FrmGenerarOC.MdiParent = Me
        '    FrmGenerarOC.Show()
        '    etiPrin.Text = "Generar orden de compra de MP"
        'End If

        'If Me.UltraExplorerBar1.Groups(1).Items(1).Active Then
        '    Dim FrmRecibirMP As New frmRecibirMPII
        '    FrmRecibirMP.MdiParent = Me
        '    FrmRecibirMP.Show()
        '    etiPrin.Text = "Recibir materia prima"
        'End If

        'If Me.UltraExplorerBar1.Groups(1).Items(2).Active Then
        '    Dim frmp As New FrmPagoProveedor
        '    frmp.MdiParent = Me
        '    frmp.Show()
        '    etiPrin.Text = "Pago a proveedores"
        'End If

        'If Me.UltraExplorerBar1.Groups(1).Items(3).Active Then
        '    Dim ABC As New Diagrama_ABC
        '    ABC.MdiParent = Me
        '    ABC.Show()
        '    'etiPrin.Text = "Pago a proveedores"
        'End If


        'If Me.UltraExplorerBar1.Groups(2).Items(0).Active Then
        '    Dim frmC As New frmCliente
        '    frmC.MdiParent = Me
        '    frmC.Show()
        '    etiPrin.Text = "Gestionar cliente"
        'End If

        'If Me.UltraExplorerBar1.Groups(3).Items(3).Active Then
        '    Dim frmE As New frmEntrega
        '    frmE.MdiParent = Me
        '    frmE.Show()
        '    etiPrin.Text = "Gestionar entrega de pedidos"
        'End If
        'If Me.UltraExplorerBar1.Groups(3).Items(0).Active Then
        '    Dim frmPedidocliente As New frmpedidocliente
        '    frmPedidocliente.MdiParent = Me
        '    frmPedidocliente.Show()
        '    etiPrin.Text = "Pedido del Cliente"
        'End If
        'If Me.UltraExplorerBar1.Groups(3).Items(1).Active Then
        '    Dim frmPres As New emitirPresupuesto
        '    frmPres.MdiParent = Me
        '    frmPres.Show()
        '    etiPrin.Text = "Emitir presupuesto"
        'End If

        'If Me.UltraExplorerBar1.Groups(1).Items(4).Active Then
        '    Dim frmParam As New paramCompra
        '    frmParam.MdiParent = Me
        '    frmParam.Show()
        '    etiPrin.Text = "Calcular parametros de compra"
        'End If

        'If Me.UltraExplorerBar1.Groups(1).Items(5).Active Then
        '    Dim frmConsOC As New consultarOC
        '    frmConsOC.MdiParent = Me
        '    frmConsOC.Show()
        '    etiPrin.Text = "Consultar ordenes de compra"
        'End If

        'If Me.UltraExplorerBar1.Groups(1).Items(6).Active Then
        '    Dim prov As New abmProveedores
        '    prov.MdiParent = Me
        '    prov.Show()
        '    'etiPrin.Text = "Generar orden de compra de MP"
        'End If
    End Sub


    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New abmMatTrab
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Gestionar mat. a trabajar"
    End Sub


    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New abmTipoAcabado
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Gestionar tipo acabado"
    End Sub


    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New abmModoAvance
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Gestionar modo de avance"
    End Sub


    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New registrarModeloFresa
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Registrar modelo de fresa"
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New emitirPresupuesto
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Emitir presupuesto"
    End Sub


    Private Sub UltraStatusBar1_ButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinStatusBar.PanelEventArgs) Handles UltraStatusBar1.ButtonClick
        barra.click()
    End Sub



    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New abmMaquinaFresa
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Registrar máquina-fresa"
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New abmTipoParte
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Gestionar tipo parte"
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New abmOperacion
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Gestionar operaciones"
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New abmProveedores
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmEmpresaTransp
        f.MdiParent = Me
        f.Show()
        'etiPrin.Text = "Gestionar Empresa"
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


    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Help.ShowHelp(Me, "D:\TESIS\Medusa\Afilar 14-11-05\ayuda2\afilar.chm")
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Now '.Hour & ":" & Now.Minute & ":" & Now.Second
        Mensajeria.getMensajes(seguridad.id, LinkLabel1)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New programarProduccion
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmCliente
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New FrmGenerarOC
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New FrmRecibirMP
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New FrmPagoProveedor
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New paramCompra
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New consultarOC
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New informeCompras
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New informeCompras2
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmEmpleado
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmProvincia
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmLocalidad
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmCargo
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmIngresos
        f.MdiParent = Me
        f.Show()
    End Sub

    
    
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form As New frmMensajes
        form.MdiParent = Me
        form.Show()
        form.Location = New Point(500, 200)
    End Sub

    Private Sub principal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        acomodarImagenes()
    End Sub
End Class
