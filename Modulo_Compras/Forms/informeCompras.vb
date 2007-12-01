Public Class informeCompras
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DsCompras1 As Afilar.DSCompras
    Friend WithEvents cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents adaptadorCompra2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsComprasDos1 As Afilar.dsComprasDos
    Friend WithEvents comboProveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkProveedor As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents checkPeriodo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents comboDesde As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents comboHasta As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents comboMP As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkMP As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(informeCompras))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.checkProveedor = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.checkPeriodo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.comboProveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboDesde = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.comboHasta = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.cnn = New System.Data.SqlClient.SqlConnection
        Me.DsCompras1 = New Afilar.DSCompras
        Me.adaptadorCompra2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsComprasDos1 = New Afilar.dsComprasDos
        Me.comboMP = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkMP = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.comboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComprasDos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Location = New System.Drawing.Point(16, 80)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(784, 440)
        Me.crv.TabIndex = 0
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'checkProveedor
        '
        Me.checkProveedor.Location = New System.Drawing.Point(512, 16)
        Me.checkProveedor.Name = "checkProveedor"
        Me.checkProveedor.Size = New System.Drawing.Size(144, 16)
        Me.checkProveedor.TabIndex = 1
        Me.checkProveedor.Text = "Por proveedor"
        '
        'checkPeriodo
        '
        Me.checkPeriodo.Location = New System.Drawing.Point(512, 32)
        Me.checkPeriodo.Name = "checkPeriodo"
        Me.checkPeriodo.Size = New System.Drawing.Size(144, 16)
        Me.checkPeriodo.TabIndex = 2
        Me.checkPeriodo.Text = "Por período"
        '
        'comboProveedor
        '
        Me.comboProveedor.AutoSize = True
        Me.comboProveedor.Location = New System.Drawing.Point(96, 16)
        Me.comboProveedor.Name = "comboProveedor"
        Me.comboProveedor.Size = New System.Drawing.Size(184, 21)
        Me.comboProveedor.TabIndex = 3
        '
        'comboDesde
        '
        Me.comboDesde.BackColor = System.Drawing.SystemColors.Window
        DateButton1.Caption = "Today"
        Me.comboDesde.DateButtons.Add(DateButton1)
        Me.comboDesde.Location = New System.Drawing.Point(376, 16)
        Me.comboDesde.Name = "comboDesde"
        Me.comboDesde.NonAutoSizeHeight = 16
        Me.comboDesde.Size = New System.Drawing.Size(112, 21)
        Me.comboDesde.TabIndex = 7
        Me.comboDesde.Value = New Date(2005, 11, 22, 0, 0, 0, 0)
        '
        'comboHasta
        '
        Me.comboHasta.BackColor = System.Drawing.SystemColors.Window
        DateButton2.Caption = "Today"
        Me.comboHasta.DateButtons.Add(DateButton2)
        Me.comboHasta.Location = New System.Drawing.Point(376, 40)
        Me.comboHasta.Name = "comboHasta"
        Me.comboHasta.NonAutoSizeHeight = 16
        Me.comboHasta.Size = New System.Drawing.Size(112, 21)
        Me.comboHasta.TabIndex = 8
        Me.comboHasta.Value = New Date(2005, 11, 22, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(41, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha hasta"
        '
        'UltraButton1
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButton1.Appearance = Appearance1
        Me.UltraButton1.Location = New System.Drawing.Point(720, 528)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 4
        Me.UltraButton1.Text = "Salir"
        '
        'UltraButton2
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButton2.Appearance = Appearance2
        Me.UltraButton2.Location = New System.Drawing.Point(686, 32)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(114, 32)
        Me.UltraButton2.TabIndex = 12
        Me.UltraButton2.Text = "Generar informe"
        '
        'cnn
        '
        Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
            "filar;persist security info=False"
        Me.cnn.FireInfoMessageEventOnUserErrors = False
        '
        'DsCompras1
        '
        Me.DsCompras1.DataSetName = "DSCompras"
        Me.DsCompras1.Locale = New System.Globalization.CultureInfo("es-AR")
        Me.DsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'adaptadorCompra2
        '
        Me.adaptadorCompra2.SelectCommand = Me.SqlSelectCommand2
        Me.adaptadorCompra2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ordencompramp", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("fecharealizacion", "fecharealizacion"), New System.Data.Common.DataColumnMapping("idordencompra", "idordencompra"), New System.Data.Common.DataColumnMapping("idestado", "idestado"), New System.Data.Common.DataColumnMapping("idproveedor", "idproveedor"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("idtipomateriaprima", "idtipomateriaprima"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("Expr3", "Expr3"), New System.Data.Common.DataColumnMapping("Expr4", "Expr4"), New System.Data.Common.DataColumnMapping("Expr5", "Expr5"), New System.Data.Common.DataColumnMapping("Expr6", "Expr6"), New System.Data.Common.DataColumnMapping("Expr7", "Expr7")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.cnn
        '
        'DsComprasDos1
        '
        Me.DsComprasDos1.DataSetName = "dsComprasDos"
        Me.DsComprasDos1.Locale = New System.Globalization.CultureInfo("es-AR")
        Me.DsComprasDos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'comboMP
        '
        Me.comboMP.AutoSize = True
        Me.comboMP.Location = New System.Drawing.Point(96, 40)
        Me.comboMP.Name = "comboMP"
        Me.comboMP.Size = New System.Drawing.Size(184, 21)
        Me.comboMP.TabIndex = 13
        '
        'checkMP
        '
        Me.checkMP.Location = New System.Drawing.Point(512, 48)
        Me.checkMP.Name = "checkMP"
        Me.checkMP.Size = New System.Drawing.Size(144, 16)
        Me.checkMP.TabIndex = 14
        Me.checkMP.Text = "Por insumo"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(27, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Materia prima"
        '
        'informeCompras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(818, 562)
        Me.Controls.Add(Me.checkMP)
        Me.Controls.Add(Me.comboMP)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.comboHasta)
        Me.Controls.Add(Me.comboDesde)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.comboProveedor)
        Me.Controls.Add(Me.checkPeriodo)
        Me.Controls.Add(Me.checkProveedor)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "informeCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Informe de compra de MP"
        CType(Me.comboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComprasDos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click

        'Dim ds As New DataSet

        'adaptadorCompra.Fill(ds)

        'Dim p As New RepCompras

        'p.SetDataSource(ds)

        'crv.ReportSource = p

        'Dim SelectFormula As String
        'SelectFormula = "{detallepresupuesto.idpresupuesto} = " & textPresupuesto.Text

        'crv.SelectionFormula = SelectFormula



        Dim ds As New DataSet
        adaptadorCompra2.Fill(ds)
        Dim p As New repCompras2
        p.SetDataSource(ds)
        crv.ReportSource = p

        Dim SelectFormula As String

        If checkProveedor.CheckState = CheckState.Checked And checkMP.CheckState = CheckState.Checked And checkPeriodo.CheckState = CheckState.Unchecked Then
            SelectFormula = "{ordencompramp.idproveedor} = " & comboProveedor.SelectedItem.Tag & " And {ordencompramp.idtipomateriaprima} = " & comboMP.SelectedItem.Tag
            crv.SelectionFormula = SelectFormula
        End If


        If checkProveedor.CheckState = CheckState.Checked And checkMP.CheckState = CheckState.Unchecked And checkPeriodo.CheckState = CheckState.Unchecked Then
            SelectFormula = "{ordencompramp.idproveedor} = " & comboProveedor.SelectedItem.Tag
            crv.SelectionFormula = SelectFormula
        End If


        If checkProveedor.CheckState = CheckState.Unchecked And checkMP.CheckState = CheckState.Checked And checkPeriodo.CheckState = CheckState.Unchecked Then
            SelectFormula = "{ordencompramp.idtipomateriaprima} = " & comboMP.SelectedItem.Tag
            crv.SelectionFormula = SelectFormula
        End If


        If checkProveedor.CheckState = CheckState.Unchecked And checkMP.CheckState = CheckState.Unchecked And checkPeriodo.CheckState = CheckState.Checked Then
            SelectFormula = "{ordencompramp.fecharealizacion} in #" & comboDesde.Text & "# to #" & comboHasta.Text & "#"
            crv.SelectionFormula = SelectFormula
        End If

        If checkProveedor.CheckState = CheckState.Checked And checkMP.CheckState = CheckState.Unchecked And checkPeriodo.CheckState = CheckState.Checked Then
            SelectFormula = "{ordencompramp.fecharealizacion} in #" & comboDesde.Text & "# to #" & comboHasta.Text & "# and {ordencompramp.idproveedor} = " & comboProveedor.SelectedItem.Tag
            crv.SelectionFormula = SelectFormula
        End If

        If checkProveedor.CheckState = CheckState.Unchecked And checkMP.CheckState = CheckState.Checked And checkPeriodo.CheckState = CheckState.Checked Then
            SelectFormula = "{ordencompramp.fecharealizacion} in #" & comboDesde.Text & "# to #" & comboHasta.Text & "# and {ordencompramp.idtipomateriaprima} = " & comboMP.SelectedItem.Tag
            crv.SelectionFormula = SelectFormula
        End If

        If checkProveedor.CheckState = CheckState.Checked And checkMP.CheckState = CheckState.Checked And checkPeriodo.CheckState = CheckState.Checked Then
            SelectFormula = "{ordencompramp.fecharealizacion} in #" & comboDesde.Text & "# to #" & comboHasta.Text & "# and {ordencompramp.idtipomateriaprima} = " & comboMP.SelectedItem.Tag & " and {ordencompramp.idproveedor} = " & comboProveedor.SelectedItem.Tag
            crv.SelectionFormula = SelectFormula
        End If





    End Sub

    Private Sub informeCompras_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    

    Private Sub informeCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComboTag("select idproveedor, nombre from proveedor", comboProveedor, 0, 2)
        cargarComboTag("select idtipomateriaprima, nombre from tipomateriaprima", comboMP, 0, 2)
        princ.barra.agregarBoton(Me)

    End Sub

    
End Class
