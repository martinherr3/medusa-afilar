Public Class abmMateriaPrima
    Inherits System.Windows.Forms.Form

    Dim objMP As New MateriaPrima
    Dim consultaMP As String = "select * from tipomateriaprima"
    Dim dsMP As DataSet = objMP.cargarDSMateriaPrima(consultaMP, cnn)


    Dim bandcombo As Integer
    Friend WithEvents cboUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As Infragistics.Win.Misc.UltraButton
    Dim bandGrabar As Integer
#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnAfter As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVeryAfter As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVeryBefore As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBefore As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtStockSeguridad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtStockActual As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdMP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtStockMinimo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtLote As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmMateriaPrima))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLote = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtStockMinimo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnAfter = New Infragistics.Win.Misc.UltraButton
        Me.btnVeryAfter = New Infragistics.Win.Misc.UltraButton
        Me.btnVeryBefore = New Infragistics.Win.Misc.UltraButton
        Me.btnBefore = New Infragistics.Win.Misc.UltraButton
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnNuevo = New Infragistics.Win.Misc.UltraButton
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton
        Me.btnEditar = New Infragistics.Win.Misc.UltraButton
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton
        Me.txtStockSeguridad = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtStockActual = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtIdMP = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDireccion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txtLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtStockSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.btnEliminar)
        Me.UltraTabPageControl1.Controls.Add(Me.cboUnidadMedida)
        Me.UltraTabPageControl1.Controls.Add(Me.Label9)
        Me.UltraTabPageControl1.Controls.Add(Me.txtLote)
        Me.UltraTabPageControl1.Controls.Add(Me.txtStockMinimo)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.btnNuevo)
        Me.UltraTabPageControl1.Controls.Add(Me.btnGuardar)
        Me.UltraTabPageControl1.Controls.Add(Me.btnEditar)
        Me.UltraTabPageControl1.Controls.Add(Me.btnSalir)
        Me.UltraTabPageControl1.Controls.Add(Me.txtStockSeguridad)
        Me.UltraTabPageControl1.Controls.Add(Me.txtStockActual)
        Me.UltraTabPageControl1.Controls.Add(Me.txtNombre)
        Me.UltraTabPageControl1.Controls.Add(Me.txtIdMP)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.txtDireccion)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(644, 257)
        '
        'btnEliminar
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnEliminar.Appearance = Appearance1
        Me.btnEliminar.Location = New System.Drawing.Point(484, 217)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 31)
        Me.btnEliminar.TabIndex = 55
        Me.btnEliminar.Text = "&Eliminar"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.Location = New System.Drawing.Point(547, 75)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(87, 21)
        Me.cboUnidadMedida.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(448, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Unidad de medida"
        '
        'txtLote
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Me.txtLote.Appearance = Appearance2
        Me.txtLote.AutoSize = True
        Me.txtLote.Location = New System.Drawing.Point(96, 145)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(88, 21)
        Me.txtLote.TabIndex = 6
        '
        'txtStockMinimo
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Me.txtStockMinimo.Appearance = Appearance3
        Me.txtStockMinimo.AutoSize = True
        Me.txtStockMinimo.Location = New System.Drawing.Point(96, 97)
        Me.txtStockMinimo.Name = "txtStockMinimo"
        Me.txtStockMinimo.Size = New System.Drawing.Size(88, 21)
        Me.txtStockMinimo.TabIndex = 4
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.Controls.Add(Me.btnAfter)
        Me.UltraGroupBox1.Controls.Add(Me.btnVeryAfter)
        Me.UltraGroupBox1.Controls.Add(Me.btnVeryBefore)
        Me.UltraGroupBox1.Controls.Add(Me.btnBefore)
        Me.UltraGroupBox1.Controls.Add(Me.lblCantidad)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(96, 192)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(224, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 49
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'btnAfter
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnAfter.Appearance = Appearance4
        Me.btnAfter.Location = New System.Drawing.Point(176, 24)
        Me.btnAfter.Name = "btnAfter"
        Me.btnAfter.Size = New System.Drawing.Size(40, 24)
        Me.btnAfter.TabIndex = 3
        '
        'btnVeryAfter
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnVeryAfter.Appearance = Appearance5
        Me.btnVeryAfter.Location = New System.Drawing.Point(136, 24)
        Me.btnVeryAfter.Name = "btnVeryAfter"
        Me.btnVeryAfter.Size = New System.Drawing.Size(40, 24)
        Me.btnVeryAfter.TabIndex = 2
        '
        'btnVeryBefore
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnVeryBefore.Appearance = Appearance6
        Me.btnVeryBefore.Location = New System.Drawing.Point(48, 24)
        Me.btnVeryBefore.Name = "btnVeryBefore"
        Me.btnVeryBefore.Size = New System.Drawing.Size(40, 24)
        Me.btnVeryBefore.TabIndex = 1
        '
        'btnBefore
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnBefore.Appearance = Appearance7
        Me.btnBefore.Location = New System.Drawing.Point(8, 24)
        Me.btnBefore.Name = "btnBefore"
        Me.btnBefore.Size = New System.Drawing.Size(40, 24)
        Me.btnBefore.TabIndex = 0
        '
        'lblCantidad
        '
        Me.lblCantidad.BackColor = System.Drawing.SystemColors.Control
        Me.lblCantidad.ForeColor = System.Drawing.Color.Black
        Me.lblCantidad.Location = New System.Drawing.Point(92, 24)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(39, 24)
        Me.lblCantidad.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(40, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Stock act."
        '
        'btnNuevo
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.btnNuevo.Appearance = Appearance8
        Me.btnNuevo.Location = New System.Drawing.Point(406, 181)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 32)
        Me.btnNuevo.TabIndex = 40
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.btnGuardar.Appearance = Appearance9
        Me.btnGuardar.Location = New System.Drawing.Point(406, 216)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 32)
        Me.btnGuardar.TabIndex = 39
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.btnEditar.Appearance = Appearance10
        Me.btnEditar.Location = New System.Drawing.Point(484, 181)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(72, 32)
        Me.btnEditar.TabIndex = 38
        Me.btnEditar.Text = "Editar"
        '
        'btnSalir
        '
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        Me.btnSalir.Appearance = Appearance11
        Me.btnSalir.Location = New System.Drawing.Point(562, 216)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 32)
        Me.btnSalir.TabIndex = 37
        Me.btnSalir.Text = "Salir"
        '
        'txtStockSeguridad
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Me.txtStockSeguridad.Appearance = Appearance12
        Me.txtStockSeguridad.AutoSize = True
        Me.txtStockSeguridad.Location = New System.Drawing.Point(96, 121)
        Me.txtStockSeguridad.Name = "txtStockSeguridad"
        Me.txtStockSeguridad.Size = New System.Drawing.Size(88, 21)
        Me.txtStockSeguridad.TabIndex = 5
        '
        'txtStockActual
        '
        Appearance13.BackColor = System.Drawing.Color.White
        Me.txtStockActual.Appearance = Appearance13
        Me.txtStockActual.AutoSize = True
        Me.txtStockActual.Location = New System.Drawing.Point(96, 72)
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.Size = New System.Drawing.Size(88, 21)
        Me.txtStockActual.TabIndex = 3
        '
        'txtNombre
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance14
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Location = New System.Drawing.Point(96, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(187, 21)
        Me.txtNombre.TabIndex = 2
        '
        'txtIdMP
        '
        Appearance15.BackColor = System.Drawing.Color.White
        Me.txtIdMP.Appearance = Appearance15
        Me.txtIdMP.AutoSize = True
        Me.txtIdMP.Location = New System.Drawing.Point(96, 24)
        Me.txtIdMP.Name = "txtIdMP"
        Me.txtIdMP.Size = New System.Drawing.Size(88, 21)
        Me.txtIdMP.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(40, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Lote econ."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(40, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Stock seg."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(40, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Stock m�n."
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
        'txtDireccion
        '
        Appearance16.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Appearance = Appearance16
        Me.txtDireccion.AutoSize = True
        Me.txtDireccion.Location = New System.Drawing.Point(333, 24)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(301, 45)
        Me.txtDireccion.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(269, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Descripci�n"
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
        Appearance17.BackColor = System.Drawing.Color.Silver
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance18
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance19
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
        UltraTab1.Text = "Gesti�n"
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
        Me.Text = "Gesti�n Materia prima"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txtLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txtStockSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If cboUnidadMedida.SelectedValue > -1 And Not (IsNothing(cboUnidadMedida.SelectedValue)) Then


                Dim valorId As Integer
                If DataGrid1.CurrentRowIndex = -1 Then
                    valorId = 0
                Else
                    valorId = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
                End If
                objMP.tomarDatos(valorId, txtNombre.Text, txtDireccion.Text, txtStockActual.Text, txtStockMinimo.Text, txtStockSeguridad.Text, txtLote.Text, cboUnidadMedida.SelectedValue)

                'objcliente.tomarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
                '        TextBox4.Text, CType(TextBox1.Text, Decimal), textBox6.Text, TextBox7.Text, valorId)

                If bandGrabar = 1 Then
                    objMP.registrarMP(dsMP)
                Else
                    objMP.modificarMP(dsMP)
                End If
                If objMP.varCancelar = 0 Then
                    btnGuardar.Enabled = False
                    btnNuevo.Enabled = True
                    btnEditar.Enabled = True
                    btnEliminar.Enabled = True

                    txtIdMP.Enabled = False
                    txtNombre.Enabled = False
                    txtNombre.Focus()
                    txtDireccion.Enabled = False
                    txtStockActual.Enabled = False
                    txtStockMinimo.Enabled = False
                    txtStockSeguridad.Enabled = False
                    txtLote.Enabled = False
                    cboUnidadMedida.Enabled = False
                End If
            Else
                MessageBox.Show("Debe seleccionar un tipo de Unidad de Medida", "Unidad de Medida", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub abmMateriaPrima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DataGrid1.DataSource = dsMP
            DataGrid1.DataMember = "tipomateriaprima"

            Dim nombrescol(8) As String
            nombrescol(0) = "ID MP"
            nombrescol(1) = "Nombre"
            nombrescol(3) = "Stock Actual"
            nombrescol(4) = "Stock Minimo"

            Dim anchosgrid(8) As Integer
            anchosgrid(0) = 75
            anchosgrid(1) = 225
            anchosgrid(3) = 125
            anchosgrid(4) = 125

            ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
            cargarGrilla(DataGrid1, dsMP.Tables.Item(0), nombrescol, anchosgrid)

            cargarCombo("select idunidadmedida,nombre from unidaddemedida", cboUnidadMedida, "nombre", "idunidadmedida")


            objMP.mostrarDatos(txtIdMP.Text, txtNombre.Text, txtDireccion.Text, txtStockActual.Text, txtStockMinimo.Text, txtStockSeguridad.Text, txtLote.Text, cboUnidadMedida.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            bandGrabar = 1
            btnGuardar.Enabled = True
            btnNuevo.Enabled = False
            btnEditar.Enabled = False
            btnEliminar.Enabled = False

            txtIdMP.Enabled = False
            txtIdMP.Text = ""
            txtNombre.Enabled = True
            txtNombre.Text = ""
            txtNombre.Focus()
            txtDireccion.Enabled = True
            txtDireccion.Text = ""
            txtStockActual.Enabled = True
            txtStockActual.Text = ""
            txtStockMinimo.Enabled = True
            txtStockMinimo.Text = ""
            txtStockSeguridad.Enabled = True
            txtStockSeguridad.Text = ""
            txtLote.Enabled = True
            txtLote.Text = ""
            cboUnidadMedida.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Try
            bandGrabar = 2
            btnGuardar.Enabled = True
            btnNuevo.Enabled = False
            btnEditar.Enabled = False
            btnEliminar.Enabled = False

            txtIdMP.Enabled = False
            txtNombre.Enabled = True
            txtNombre.Focus()
            txtDireccion.Enabled = True
            txtStockActual.Enabled = True
            txtStockMinimo.Enabled = True
            txtStockSeguridad.Enabled = True
            txtLote.Enabled = True
            cboUnidadMedida.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            objMP.eliminarMP(dsMP)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBefore.Click
        Try
            BindingContext(dsMP, "tipomateriaprima").Position -= 1
            mostrarPosicion("tipomateriaprima")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnVeryBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeryBefore.Click
        Try
            BindingContext(dsMP, "tipomateriaprima").Position = 0
            mostrarPosicion("tipomateriaprima")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnVeryAfter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeryAfter.Click
        Try
            BindingContext(dsMP, "tipomateriaprima").Position = BindingContext(dsMP, "tipomateriaprima").Count - 1
            mostrarPosicion("tipomateriaprima")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAfter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfter.Click
        Try
            BindingContext(dsMP, "tipomateriaprima").Position += 1
            mostrarPosicion("tipomateriaprima")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mostrarPosicion(ByVal tabla As String)
        Try
            Dim bmbase As BindingManagerBase = BindingContext.Item(dsMP, tabla)
            Dim iTotal As Integer = bmbase.Count
            Dim iPos As Integer

            If iTotal = 0 Then
                lblCantidad.Text = "0"

            Else
                iPos = bmbase.Position + 1
                lblCantidad.Text = iPos.ToString & " de " & iTotal.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        Try
            objMP.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1).ToString, DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2).ToString, DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), _
            DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7))


            objMP.mostrarDatos(txtIdMP.Text, txtNombre.Text, txtDireccion.Text, txtStockActual.Text, txtStockMinimo.Text, txtStockSeguridad.Text, _
            txtLote.Text, cboUnidadMedida.SelectedValue)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
