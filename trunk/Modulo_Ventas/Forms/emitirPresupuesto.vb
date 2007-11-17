Public Class emitirPresupuesto
    Inherits System.Windows.Forms.Form

#Region "Declaraciones"
    Dim ds As New DataSet
    Dim fresa As New TipoFresa
    Dim parteAdicional As New ParteAdicional
    Dim modelo As New ModeloFresa
    Dim pres As New presupuesto
    Friend WithEvents cmbFiltrar As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnFiltrar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFiltrar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Dim dp As New detallePresupuesto
    Const FILTRO_NINGUNO As String = "ninguno"
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Dim filtrar As Boolean
    Dim aPresupuesto As New SqlClient.SqlDataAdapter
#End Region


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
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textFecha As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboEmpleado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents dataGridMF As System.Windows.Forms.DataGrid
    Friend WithEvents textPresupuesto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(emitirPresupuesto))
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmbFiltrar = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnFiltrar = New Infragistics.Win.Misc.UltraButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFiltrar = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.comboCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.textPresupuesto = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.comboEmpleado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.textFecha = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.dataGridMF = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.PictureBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmbFiltrar)
        Me.UltraTabPageControl1.Controls.Add(Me.btnFiltrar)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.txtFiltrar)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl1.Controls.Add(Me.comboCliente)
        Me.UltraTabPageControl1.Controls.Add(Me.textPresupuesto)
        Me.UltraTabPageControl1.Controls.Add(Me.comboEmpleado)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.textFecha)
        Me.UltraTabPageControl1.Controls.Add(Me.dataGridMF)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(812, 537)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(201, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'cmbFiltrar
        '
        Me.cmbFiltrar.AutoSize = True
        ValueListItem9.DataValue = "ValueListItem0"
        ValueListItem9.DisplayText = "Nombre"
        ValueListItem9.Tag = "nombre"
        ValueListItem10.DataValue = "ValueListItem1"
        ValueListItem10.DisplayText = "ID"
        ValueListItem10.Tag = "idmodelo"
        ValueListItem11.DataValue = "ValueListItem2"
        ValueListItem11.DisplayText = "Grupo modelo"
        ValueListItem11.Tag = "grupomodelo"
        ValueListItem12.DataValue = "ValueListItem3"
        ValueListItem12.DisplayText = "Material a trabajar"
        ValueListItem12.Tag = "materialatrabajar"
        ValueListItem13.DataValue = "ValueListItem4"
        ValueListItem13.DisplayText = "Tipo acabado"
        ValueListItem13.Tag = "tipoacabado"
        ValueListItem14.DataValue = "ValueListItem5"
        ValueListItem14.DisplayText = "Tipo modelo"
        ValueListItem14.Tag = "tipomodelo"
        ValueListItem15.DataValue = "ValueListItem6"
        ValueListItem15.DisplayText = "Precio"
        ValueListItem15.Tag = "precio"
        Appearance9.FontData.BoldAsString = "True"
        ValueListItem16.Appearance = Appearance9
        ValueListItem16.DataValue = "ValueListItem7"
        ValueListItem16.DisplayText = "Ninguno"
        ValueListItem16.Tag = "ninguno"
        Me.cmbFiltrar.Items.Add(ValueListItem9)
        Me.cmbFiltrar.Items.Add(ValueListItem10)
        Me.cmbFiltrar.Items.Add(ValueListItem11)
        Me.cmbFiltrar.Items.Add(ValueListItem12)
        Me.cmbFiltrar.Items.Add(ValueListItem13)
        Me.cmbFiltrar.Items.Add(ValueListItem14)
        Me.cmbFiltrar.Items.Add(ValueListItem15)
        Me.cmbFiltrar.Items.Add(ValueListItem16)
        Me.cmbFiltrar.Location = New System.Drawing.Point(322, 32)
        Me.cmbFiltrar.Name = "cmbFiltrar"
        Me.cmbFiltrar.Size = New System.Drawing.Size(224, 21)
        Me.cmbFiltrar.TabIndex = 24
        '
        'btnFiltrar
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.btnFiltrar.Appearance = Appearance10
        Me.btnFiltrar.Location = New System.Drawing.Point(552, 32)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(80, 45)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Text = "Filtrar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(268, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Filtrar por:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.AutoSize = True
        Me.txtFiltrar.Location = New System.Drawing.Point(322, 56)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(224, 21)
        Me.txtFiltrar.TabIndex = 21
        '
        'UltraButton4
        '
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        Me.UltraButton4.Appearance = Appearance11
        Me.UltraButton4.Location = New System.Drawing.Point(483, 489)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(149, 31)
        Me.UltraButton4.TabIndex = 20
        Me.UltraButton4.Text = "Generar presupuesto"
        '
        'comboCliente
        '
        Me.comboCliente.AutoSize = True
        Me.comboCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboCliente.Location = New System.Drawing.Point(392, 445)
        Me.comboCliente.Name = "comboCliente"
        Me.comboCliente.Size = New System.Drawing.Size(240, 21)
        Me.comboCliente.TabIndex = 18
        '
        'textPresupuesto
        '
        Me.textPresupuesto.AutoSize = True
        Me.textPresupuesto.Location = New System.Drawing.Point(80, 32)
        Me.textPresupuesto.Name = "textPresupuesto"
        Me.textPresupuesto.ReadOnly = True
        Me.textPresupuesto.Size = New System.Drawing.Size(120, 21)
        Me.textPresupuesto.TabIndex = 16
        '
        'comboEmpleado
        '
        Me.comboEmpleado.AutoSize = True
        Me.comboEmpleado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboEmpleado.Location = New System.Drawing.Point(72, 445)
        Me.comboEmpleado.Name = "comboEmpleado"
        Me.comboEmpleado.Size = New System.Drawing.Size(240, 21)
        Me.comboEmpleado.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(43, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha"
        '
        'textFecha
        '
        Me.textFecha.AutoSize = True
        Me.textFecha.Location = New System.Drawing.Point(80, 56)
        Me.textFecha.Name = "textFecha"
        Me.textFecha.Size = New System.Drawing.Size(120, 21)
        Me.textFecha.TabIndex = 4
        '
        'dataGridMF
        '
        Me.dataGridMF.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dataGridMF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridMF.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataGridMF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridMF.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dataGridMF.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.CaptionText = "Modelos de fresas"
        Me.dataGridMF.DataMember = ""
        Me.dataGridMF.FlatMode = True
        Me.dataGridMF.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dataGridMF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dataGridMF.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dataGridMF.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dataGridMF.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridMF.LinkColor = System.Drawing.Color.Teal
        Me.dataGridMF.Location = New System.Drawing.Point(16, 96)
        Me.dataGridMF.Name = "dataGridMF"
        Me.dataGridMF.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dataGridMF.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dataGridMF.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridMF.Size = New System.Drawing.Size(784, 328)
        Me.dataGridMF.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(14, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Presupuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(354, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Cliente"
        '
        'UltraButton3
        '
        Appearance12.Image = CType(resources.GetObject("Appearance12.Image"), Object)
        Me.UltraButton3.Appearance = Appearance12
        Me.UltraButton3.Location = New System.Drawing.Point(720, 489)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(80, 31)
        Me.UltraButton3.TabIndex = 12
        Me.UltraButton3.Text = "Salir"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.crv)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(812, 537)
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Location = New System.Drawing.Point(16, 32)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(784, 448)
        Me.crv.TabIndex = 5
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Width = 75
        '
        'UltraTabControl1
        '
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance13.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance13
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance14
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance15.BackColor = System.Drawing.Color.Silver
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance15
        Me.UltraTabControl1.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.UltraButton3})
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(816, 560)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 11
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Datos presupuesto"
        Appearance16.BackColor = System.Drawing.Color.Silver
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraTab4.SelectedAppearance = Appearance16
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Generar presupuesto"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraButton3)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(812, 537)
        '
        'emitirPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(818, 563)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "emitirPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Emitir presupuesto"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Evento load"
    Private Sub emitirPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' seteo el estilo del datagrid 
        modelo.setearGrilla(dataGridMF)
        fresa.setearGrilla(dataGridMF)
        parteAdicional.setearGrilla(dataGridMF)

        ' cargo la fecha actual en el text
        textFecha.Text = Date.Today


        ' cargo los datos en el dataset (de las tablas modelofresa, tipofresa, parteadicional)
        modelo.cargarAdaptador()
        modelo.cargarDatos(ds, "modelofresa")
        fresa.cargarAdaptador()
        fresa.cargarDatos(ds, "tipofresa")
        parteAdicional.cargarAdaptador()
        parteAdicional.cargarDatos(ds, "parteadicional")

        pres.cargarAdaptador()
        pres.cargarDatos(ds, "presupuesto")

        ' numero de presupuesto
        textPresupuesto.Text = ds.Tables("presupuesto").Rows.Count + 1


        ' agrego la columna check los datatables de cada clase
        modelo.agregarCheck(ds)
        fresa.agregarCheck(ds)
        parteAdicional.agregarCheck(ds)



        ' pongo la columna check de todas las filas de la tabla en falso para que no me aparezcan seleccionadas 
        Dim i As Integer
        For i = 0 To ds.Tables("modelofresa").Rows.Count - 1
            ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False
        Next

        For i = 0 To ds.Tables("tipofresa").Rows.Count - 1
            ds.Tables("tipofresa").Rows(i).Item("seleccionarTF") = False
        Next

        For i = 0 To ds.Tables("parteadicional").Rows.Count - 1
            ds.Tables("parteadicional").Rows(i).Item("seleccionarPA") = False
        Next


        ' creo las relaciones entre las tablas
        crearRelacion(ds, "modelofresa", "tipofresa", "idmodelo", "idmodelo", "Fresas individuales")
        crearRelacion(ds, "modelofresa", "parteadicional", "idmodelo", "idmodelo", "Partes adicionales")



        ' vinculo el datagrid con el origen de datos
        dataGridMF.SetDataBinding(ds, "modelofresa")


        ' cargo los combos de empleados y clientes
        cargarComboTag("select * from cliente", comboCliente, 0, 23)
        cargarComboTag("select * from empleado", comboEmpleado, 0, 23)

        'seteo combo empleado
        Dim legajo As Integer = seguridad.id
        Dim item As Infragistics.Win.ValueListItem
        For Each item In comboEmpleado.Items
            If item.Tag = legajo Then
                comboEmpleado.SelectedItem = item
            End If
        Next

        'seteo los DataAdapter para el reporte
        Dim queryReporte As String
        queryReporte = "SELECT iddetpre, idpresupuesto, idmodelo, idproducto, tipo, cantidad, precio, nombreProducto FROM dbo.detallepresupuesto"
        Dim selectFresa As New SqlClient.SqlCommand
        selectFresa.CommandType = CommandType.Text
        selectFresa.Connection = cnn
        selectFresa.CommandText = queryReporte
        aPresupuesto.SelectCommand = selectFresa


        princ.barra.agregarBoton(Me)

    End Sub
#End Region


#Region "Demas eventos"

    Private Sub emitirPresupuesto_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub


    Private Sub dataGridMF_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dataGridMF.MouseUp

        Dim row As Integer
        row = dataGridMF.CurrentCell.RowNumber

        If sel_check_col(dataGridMF, 0, e) And dataGridMF.DataMember = "modelofresa" Then

            Dim i As Integer
            'Ver el - 1 que es muy dudoso, codigo basura
            i = dataGridMF.Item(dataGridMF.CurrentRowIndex, 1) - 1
            'i = dataGridMF.Item(dataGridMF.CurrentRowIndex, 1)

            Select Case ds.Tables("modelofresa").Rows(i).Item("seleccionarMF")

                Case False

                    ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = True                   

                    Dim elemento As DataRow
                    Dim hijos As Array

                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Fresas individuales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarTF") = True
                    Next


                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Partes adicionales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarPA") = True
                    Next


                Case True

                    ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False

                    Dim elemento As DataRow
                    Dim hijos As Array

                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Fresas individuales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarTF") = False
                    Next


                    hijos = obtenerHijos(ds.Tables("modelofresa").Rows.Item(i), "Partes adicionales")
                    For Each elemento In hijos
                        elemento.Item("seleccionarPA") = False
                    Next

            End Select

            dataGridMF.Select(row)

        End If

        dataGridMF.Refresh()

    End Sub


    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Me.Close()
    End Sub


    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Dim band As Boolean = False

        If comboCliente.Text = "" Then
            MsgBox("Debe seleccionar cliente", MsgBoxStyle.Information)
            band = True
            UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(0)
            comboCliente.Focus()
            Exit Sub
        End If

        If comboEmpleado.Text = "" Then
            MsgBox("Debe seleccionar empleado", MsgBoxStyle.Information)
            band = True
            UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(0)
            comboEmpleado.Focus()
            Exit Sub
        End If


        If band = False Then

            dp.cargarAdaptador()
            dp.cargarDatos(ds, "detallepresupuesto")

            Dim i As Integer = 1
            Dim fila As DataRow
            Dim nueva As DataRow
            band = False

            nueva = ds.Tables("presupuesto").NewRow

            nueva("idpresupuesto") = textPresupuesto.Text
            nueva("fecha") = Date.Today
            nueva("idcliente") = comboCliente.SelectedItem.Tag
            nueva("idempleado") = comboEmpleado.SelectedItem.Tag

            ds.Tables("presupuesto").Rows.Add(nueva)


            For Each fila In ds.Tables("tipofresa").Rows

                If fila("seleccionarTF") = True Then
                    nueva = ds.Tables("detallepresupuesto").NewRow

                    nueva("iddetpre") = i
                    nueva("idpresupuesto") = textPresupuesto.Text
                    nueva("idmodelo") = fila("idmodelo")
                    nueva("idproducto") = fila("idtipo")
                    nueva("tipo") = Constantes.PRESUPUESTO_TIPO_FRESA
                    nueva("cantidad") = 1
                    nueva("precio") = fila("precio")
                    nueva("nombreProducto") = fila("nombre")

                    ds.Tables("detallepresupuesto").Rows.Add(nueva)

                    i = i + 1

                    band = True

                End If
            Next

            For Each fila In ds.Tables("parteadicional").Rows

                If fila("seleccionarPA") = True Then
                    nueva = ds.Tables("detallepresupuesto").NewRow

                    nueva("iddetpre") = i
                    nueva("idpresupuesto") = textPresupuesto.Text
                    nueva("idmodelo") = fila("idmodelo")
                    nueva("tipo") = Constantes.PRESUPUESTO_PARTE_ADICIONAL
                    nueva("idproducto") = fila("idadicional")
                    nueva("cantidad") = 1
                    nueva("precio") = fila("precio")
                    nueva("nombreProducto") = fila("nombre")

                    ds.Tables("detallepresupuesto").Rows.Add(nueva)

                    i = i + 1

                    band = True

                End If
            Next


            If band = True Then

                pres.actualizarDatos(ds, "presupuesto")
                dp.actualizarDatos(ds, "detallepresupuesto")

                Dim ds2 As New DSPresupuesto

                aPresupuesto.Fill(ds2, "detallepresupuesto")

                Dim p As New RptPresupuesto

                p.SetDataSource(ds2)
                crv.ReportSource = p

                Dim SelectFormula As String
                SelectFormula = "{detallepresupuesto.idpresupuesto} = " & textPresupuesto.Text

                crv.SelectionFormula = SelectFormula

                UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(1)

            Else
                MsgBox("Debe seleccionar un modelo de fresa o algun componente")
            End If
        End If

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim dataView As New DataView(ds.Tables("modelofresa"))

        If (txtFiltrar.Text = "" And cmbFiltrar.SelectedItem.Tag <> FILTRO_NINGUNO) Then
            MsgBox("Debe ingresar condicion a filtrar", MsgBoxStyle.Information)
            filtrar = False
            txtFiltrar.Focus()
            Exit Sub
        End If

        Dim estado As String
        estado = Constantes.MODELO_FRESA_ESTADO_ALTA

        Select Case cmbFiltrar.SelectedItem.Tag.ToString
            Case "idmodelo"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " = " & txtFiltrar.Text & " And estado = '" & estado & "'"
            Case "precio"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " = " & txtFiltrar.Text & " And estado = '" & estado & "'"
            Case FILTRO_NINGUNO
                'nothing to do
            Case Else
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " LIKE '%" & txtFiltrar.Text.Trim & "%'" & " And estado = '" & estado & "'"
        End Select

        dataGridMF.DataSource = dataView

    End Sub

#End Region


End Class
