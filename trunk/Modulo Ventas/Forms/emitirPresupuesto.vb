Public Class emitirPresupuesto
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet
    Dim fresa As New tipoFresa
    Dim parteAdicional As New parteAdicional
    Dim modelo As New modeloFresa
    Dim pres As New presupuesto
    Dim dp As New detallePresupuesto



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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents text1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboEmpleado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents dataGridMF As System.Windows.Forms.DataGrid
    Friend WithEvents textPresupuesto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents afresa As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents aAdicional As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFresa1 As Afilar.DSFresa
    Friend WithEvents DsAdicional1 As Afilar.DSAdicional
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(emitirPresupuesto))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.comboCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.textPresupuesto = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.comboEmpleado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.radioCodigo = New System.Windows.Forms.RadioButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.text1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
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
        Me.afresa = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.cnn = New System.Data.SqlClient.SqlConnection
        Me.aAdicional = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsFresa1 = New Afilar.DSFresa
        Me.DsAdicional1 = New Afilar.DSAdicional
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.comboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.text1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        CType(Me.DsFresa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdicional1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl1.Controls.Add(Me.comboCliente)
        Me.UltraTabPageControl1.Controls.Add(Me.textPresupuesto)
        Me.UltraTabPageControl1.Controls.Add(Me.comboEmpleado)
        Me.UltraTabPageControl1.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton2)
        Me.UltraTabPageControl1.Controls.Add(Me.text1)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.textFecha)
        Me.UltraTabPageControl1.Controls.Add(Me.dataGridMF)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(812, 537)
        '
        'UltraButton4
        '
        Me.UltraButton4.Location = New System.Drawing.Point(504, 496)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(128, 24)
        Me.UltraButton4.TabIndex = 20
        Me.UltraButton4.Text = "Generar presupuesto"
        '
        'comboCliente
        '
        Me.comboCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboCliente.Location = New System.Drawing.Point(392, 445)
        Me.comboCliente.Name = "comboCliente"
        Me.comboCliente.Size = New System.Drawing.Size(240, 21)
        Me.comboCliente.TabIndex = 18
        '
        'textPresupuesto
        '
        Me.textPresupuesto.Location = New System.Drawing.Point(80, 32)
        Me.textPresupuesto.Name = "textPresupuesto"
        Me.textPresupuesto.ReadOnly = True
        Me.textPresupuesto.Size = New System.Drawing.Size(120, 21)
        Me.textPresupuesto.TabIndex = 16
        '
        'comboEmpleado
        '
        Me.comboEmpleado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboEmpleado.Location = New System.Drawing.Point(72, 445)
        Me.comboEmpleado.Name = "comboEmpleado"
        Me.comboEmpleado.Size = New System.Drawing.Size(240, 21)
        Me.comboEmpleado.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.radioCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 40)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'RadioButton2
        '
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton2.Location = New System.Drawing.Point(168, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Nombre"
        '
        'radioCodigo
        '
        Me.radioCodigo.Checked = True
        Me.radioCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radioCodigo.Location = New System.Drawing.Point(88, 12)
        Me.radioCodigo.Name = "radioCodigo"
        Me.radioCodigo.Size = New System.Drawing.Size(72, 24)
        Me.radioCodigo.TabIndex = 0
        Me.radioCodigo.TabStop = True
        Me.radioCodigo.Text = "Código"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(408, 54)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(96, 24)
        Me.UltraButton2.TabIndex = 11
        Me.UltraButton2.Text = "Buscar"
        '
        'text1
        '
        Me.text1.Location = New System.Drawing.Point(264, 56)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(136, 21)
        Me.text1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha"
        '
        'textFecha
        '
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
        Me.Label3.Location = New System.Drawing.Point(14, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Presupuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Cliente"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(720, 496)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton3.TabIndex = 12
        Me.UltraButton3.Text = "Salir"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.crv)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(812, 537)
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.Location = New System.Drawing.Point(16, 32)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = Nothing
        Me.crv.Size = New System.Drawing.Size(784, 448)
        Me.crv.TabIndex = 5
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.MappingName = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'UltraTabControl1
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance1.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance2
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance3.BackColor = System.Drawing.Color.Silver
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance3
        Me.UltraTabControl1.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.UltraButton3})
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(816, 560)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 11
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Datos presupuesto"
        Appearance4.BackColor = System.Drawing.Color.Silver
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        UltraTab2.SelectedAppearance = Appearance4
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Generar presupuesto"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.UltraButton3)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(812, 537)
        '
        'afresa
        '
        Me.afresa.SelectCommand = Me.SqlSelectCommand1
        Me.afresa.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detallepresupuesto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("iddetpre", "iddetpre"), New System.Data.Common.DataColumnMapping("idpresupuesto", "idpresupuesto"), New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("idproducto", "idproducto"), New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("precio", "precio")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT tipofresa.nombre, tipofresa.precio AS Expr1, detallepresupuesto.iddetpre, " & _
        "detallepresupuesto.idpresupuesto, detallepresupuesto.idmodelo, detallepresupuest" & _
        "o.idproducto, detallepresupuesto.tipo, detallepresupuesto.cantidad, detallepresu" & _
        "puesto.precio FROM detallepresupuesto INNER JOIN tipofresa ON detallepresupuesto" & _
        ".idmodelo = tipofresa.idmodelo AND detallepresupuesto.idproducto = tipofresa.idt" & _
        "ipo WHERE (detallepresupuesto.tipo = 1)"
        Me.SqlSelectCommand1.Connection = Me.cnn
        '
        'cnn
        '
        Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        "filar;persist security info=False"
        '
        'aAdicional
        '
        Me.aAdicional.SelectCommand = Me.SqlSelectCommand2
        Me.aAdicional.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detallepresupuesto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("iddetpre", "iddetpre"), New System.Data.Common.DataColumnMapping("idpresupuesto", "idpresupuesto"), New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("idproducto", "idproducto"), New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("precio", "precio")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT parteadicional.nombre, parteadicional.precio AS Expr1, detallepresupuesto." & _
        "iddetpre, detallepresupuesto.idpresupuesto, detallepresupuesto.idmodelo, detalle" & _
        "presupuesto.idproducto, detallepresupuesto.tipo, detallepresupuesto.cantidad, de" & _
        "tallepresupuesto.precio FROM detallepresupuesto INNER JOIN parteadicional ON det" & _
        "allepresupuesto.idmodelo = parteadicional.idmodelo AND detallepresupuesto.idprod" & _
        "ucto = parteadicional.idadicional WHERE (detallepresupuesto.tipo = 2)"
        Me.SqlSelectCommand2.Connection = Me.cnn
        '
        'DsFresa1
        '
        Me.DsFresa1.DataSetName = "DSFresa"
        Me.DsFresa1.Locale = New System.Globalization.CultureInfo("es-AR")
        '
        'DsAdicional1
        '
        Me.DsAdicional1.DataSetName = "DSAdicional"
        Me.DsAdicional1.Locale = New System.Globalization.CultureInfo("es-AR")
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
        CType(Me.comboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.text1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        CType(Me.DsFresa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdicional1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub emitirPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' seteo el estilo del datagrid 
        modelo.setearGrilla(dataGridMF)
        fresa.setearGrilla(dataGridMF)
        parteAdicional.setearGrilla(dataGridMF)

        ' cargo la fecha actual en el text
        Dim f As Date
        textFecha.Text = f.Today


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

        princ.barra.agregarBoton(Me)






    End Sub


    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If radioCodigo.Checked = True Then
        '    ds.Tables("tipofresa").Rows.Find(text1.Text)
        '    dataGridMF.Refresh()
        'End If

    End Sub


    Private Sub emitirPresupuesto_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub



    Private Sub dataGridMF_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataGridMF.CurrentCellChanged
        'dataGridMF.Select(dataGridMF.CurrentCell.RowNumber)
    End Sub


    Private Sub dataGridMF_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dataGridMF.MouseUp

        Dim row As Integer
        row = dataGridMF.CurrentCell.RowNumber

        If sel_check_col(dataGridMF, 0, e) And dataGridMF.DataMember = "modelofresa" Then

            Dim i As Integer
            i = dataGridMF.Item(dataGridMF.CurrentRowIndex, 1) - 1

            Select Case ds.Tables("modelofresa").Rows(dataGridMF.CurrentRowIndex).Item("seleccionarMF")

                Case False

                    ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = True
                    'MsgBox("paso a TRUE")


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


                    'Dim element As DataRow

                    'For Each element In ds.Tables("modelofresa").Rows.Item(i).GetChildRows("Fresas individuales")
                    '    element.Item("seleccionarTF") = True
                    'Next


                Case True

                    ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False
                    'MsgBox("paso a FALSE")

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



    Private Sub dataGridMF_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dataGridMF.MouseDown
        'Dim myGrid As DataGrid = CType(sender, DataGrid)
        'Dim hti As System.Windows.Forms.DataGrid.HitTestInfo
        'hti = myGrid.HitTest(e.X, e.Y)
        'Dim message As String = "You clicked "

        'Select Case hti.Type
        '    Case System.Windows.Forms.DataGrid.HitTestType.None
        '        message &= "the background."

        '    Case System.Windows.Forms.DataGrid.HitTestType.Cell
        '        message &= "cell at row " & hti.Row & ", col " & hti.Column

        '    Case System.Windows.Forms.DataGrid.HitTestType.ColumnHeader
        '        message &= "the column header for column " & hti.Column

        '    Case System.Windows.Forms.DataGrid.HitTestType.RowHeader
        '        message &= "the row header for row " & hti.Row

        '    Case System.Windows.Forms.DataGrid.HitTestType.ColumnResize
        '        message &= "the column resizer for column " & hti.Column

        '    Case System.Windows.Forms.DataGrid.HitTestType.RowResize
        '        message &= "the row resizer for row " & hti.Row

        '    Case System.Windows.Forms.DataGrid.HitTestType.Caption
        '        message &= "the caption"

        '    Case System.Windows.Forms.DataGrid.HitTestType.ParentRows
        '        message &= "the parent row"
        'End Select

        'MsgBox(message)
    End Sub


    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        'Dim band As Boolean = False

        'If comboCliente.Text = "" Then
        '    MsgBox("Debe seleccionar cliente", MsgBoxStyle.Information)
        '    band = True
        '    UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(0)
        '    comboCliente.Focus()
        '    Exit Sub
        'End If

        'If comboEmpleado.Text = "" Then
        '    MsgBox("Debe seleccionar empleado", MsgBoxStyle.Information)
        '    band = True
        '    UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(0)
        '    comboEmpleado.Focus()
        '    Exit Sub
        'End If


        'If band = True Then

        '    If UltraTabControl1.Tabs(1).Selected Then
        '        dp.cargarAdaptador()
        '        dp.cargarDatos(ds, "detallepresupuesto")

        '        Dim i As Integer = 1
        '        Dim fila As DataRow
        '        Dim nueva As DataRow
        '        Dim f As Date
        '        band = False



        '        nueva = ds.Tables("presupuesto").NewRow

        '        nueva("idpresupuesto") = textPresupuesto.Text
        '        nueva("fecha") = f.Today
        '        nueva("idcliente") = comboCliente.SelectedItem.Tag
        '        nueva("idempleado") = comboEmpleado.SelectedItem.Tag

        '        ds.Tables("presupuesto").Rows.Add(nueva)


        '        For Each fila In ds.Tables("tipofresa").Rows

        '            If fila("seleccionarTF") = True Then
        '                nueva = ds.Tables("detallepresupuesto").NewRow

        '                nueva("iddetpre") = i
        '                nueva("idpresupuesto") = textPresupuesto.Text
        '                nueva("idmodelo") = fila("idmodelo")
        '                nueva("idproducto") = fila("idtipo")
        '                nueva("tipo") = 1
        '                nueva("cantidad") = 1
        '                nueva("precio") = fila("precio")

        '                ds.Tables("detallepresupuesto").Rows.Add(nueva)

        '                i = i + 1

        '                band = True

        '            End If
        '        Next

        '        For Each fila In ds.Tables("parteadicional").Rows

        '            If fila("seleccionarPA") = True Then
        '                nueva = ds.Tables("detallepresupuesto").NewRow

        '                nueva("iddetpre") = i
        '                nueva("idpresupuesto") = textPresupuesto.Text
        '                nueva("idmodelo") = fila("idmodelo")
        '                nueva("tipo") = 2
        '                nueva("idproducto") = fila("idadicional")
        '                nueva("cantidad") = 1
        '                nueva("precio") = fila("precio")

        '                ds.Tables("detallepresupuesto").Rows.Add(nueva)

        '                i = i + 1

        '                band = True

        '            End If
        '        Next


        '        If band = True Then
        '            pres.actualizarDatos(ds, "presupuesto")
        '            dp.actualizarDatos(ds, "detallepresupuesto")



        '            Dim ds2 As New DataSet

        '            aAdicional.Fill(ds2)
        '            afresa.Fill(ds2)
        '            Dim p As New repPres

        '            p.SetDataSource(ds2)
        '            p.SetDataSource(ds2)
        '            crv.ReportSource = p

        '            Dim SelectFormula As String
        '            SelectFormula = "{detallepresupuesto.idpresupuesto} = " & textPresupuesto.Text
        '            'SelectFormula = "{detallepresupuesto.idpresupuesto} = " & textPresupuesto.Text & "and {detallepresupuesto_Fresa.idpresupuesto} = " & textPresupuesto.Text
        '            crv.SelectionFormula = SelectFormula

        '        End If
        '    End If
        'End If




        



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
            Dim f As Date
            band = False



            nueva = ds.Tables("presupuesto").NewRow

            nueva("idpresupuesto") = textPresupuesto.Text
            nueva("fecha") = f.Today
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
                    nueva("tipo") = 1
                    nueva("cantidad") = 1
                    nueva("precio") = fila("precio")

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
                    nueva("tipo") = 2
                    nueva("idproducto") = fila("idadicional")
                    nueva("cantidad") = 1
                    nueva("precio") = fila("precio")

                    ds.Tables("detallepresupuesto").Rows.Add(nueva)

                    i = i + 1

                    band = True

                End If
            Next


            If band = True Then
                pres.actualizarDatos(ds, "presupuesto")
                dp.actualizarDatos(ds, "detallepresupuesto")



                Dim ds2 As New DataSet

                aAdicional.Fill(ds2)
                afresa.Fill(ds2)
                Dim p As New repPres

                p.SetDataSource(ds2)
                'p.SetDataSource(ds2)
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
End Class
