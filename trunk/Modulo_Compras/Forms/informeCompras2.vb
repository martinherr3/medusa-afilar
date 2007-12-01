Public Class informeCompras2
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
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents comboHasta As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents comboDesde As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents comboProveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents checkPeriodo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents checkProveedor As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents adaptadorCompra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cnn As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(informeCompras2))
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.comboHasta = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.comboDesde = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.comboProveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.checkPeriodo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.checkProveedor = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.adaptadorCompra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.cnn = New System.Data.SqlClient.SqlConnection
        CType(Me.comboHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraButton2
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButton2.Appearance = Appearance1
        Me.UltraButton2.Location = New System.Drawing.Point(685, 31)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(115, 33)
        Me.UltraButton2.TabIndex = 25
        Me.UltraButton2.Text = "Generar informe"
        '
        'comboHasta
        '
        Me.comboHasta.BackColor = System.Drawing.SystemColors.Window
        DateButton1.Caption = "Today"
        Me.comboHasta.DateButtons.Add(DateButton1)
        Me.comboHasta.Location = New System.Drawing.Point(376, 40)
        Me.comboHasta.Name = "comboHasta"
        Me.comboHasta.NonAutoSizeHeight = 16
        Me.comboHasta.Size = New System.Drawing.Size(112, 21)
        Me.comboHasta.TabIndex = 21
        Me.comboHasta.Value = New Date(2005, 11, 22, 0, 0, 0, 0)
        '
        'comboDesde
        '
        Me.comboDesde.BackColor = System.Drawing.SystemColors.Window
        DateButton2.Caption = "Today"
        Me.comboDesde.DateButtons.Add(DateButton2)
        Me.comboDesde.Location = New System.Drawing.Point(376, 16)
        Me.comboDesde.Name = "comboDesde"
        Me.comboDesde.NonAutoSizeHeight = 16
        Me.comboDesde.Size = New System.Drawing.Size(112, 21)
        Me.comboDesde.TabIndex = 20
        Me.comboDesde.Value = New Date(2005, 11, 22, 0, 0, 0, 0)
        '
        'comboProveedor
        '
        Me.comboProveedor.AutoSize = True
        Me.comboProveedor.Location = New System.Drawing.Point(80, 16)
        Me.comboProveedor.Name = "comboProveedor"
        Me.comboProveedor.Size = New System.Drawing.Size(184, 21)
        Me.comboProveedor.TabIndex = 19
        '
        'checkPeriodo
        '
        Me.checkPeriodo.Location = New System.Drawing.Point(507, 31)
        Me.checkPeriodo.Name = "checkPeriodo"
        Me.checkPeriodo.Size = New System.Drawing.Size(144, 16)
        Me.checkPeriodo.TabIndex = 18
        Me.checkPeriodo.Text = "Por período"
        '
        'checkProveedor
        '
        Me.checkProveedor.Location = New System.Drawing.Point(507, 15)
        Me.checkProveedor.Name = "checkProveedor"
        Me.checkProveedor.Size = New System.Drawing.Size(144, 16)
        Me.checkProveedor.TabIndex = 17
        Me.checkProveedor.Text = "Por proveedor"
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Location = New System.Drawing.Point(16, 72)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(784, 440)
        Me.crv.TabIndex = 16
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Fecha desde"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Proveedor"
        '
        'UltraButton1
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.Location = New System.Drawing.Point(720, 520)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 28
        Me.UltraButton1.Text = "Salir"
        '
        'adaptadorCompra
        '
        Me.adaptadorCompra.SelectCommand = Me.SqlSelectCommand1
        Me.adaptadorCompra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ordencompramp", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("fecharealizacion", "fecharealizacion"), New System.Data.Common.DataColumnMapping("idordencompra", "idordencompra"), New System.Data.Common.DataColumnMapping("idproveedor", "idproveedor"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("plazodeentrega", "plazodeentrega"), New System.Data.Common.DataColumnMapping("condicionesdepago", "condicionesdepago")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.cnn
        '
        'cnn
        '
        Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
            "filar;persist security info=False"
        Me.cnn.FireInfoMessageEventOnUserErrors = False
        '
        'informeCompras2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 552)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.comboHasta)
        Me.Controls.Add(Me.comboDesde)
        Me.Controls.Add(Me.comboProveedor)
        Me.Controls.Add(Me.checkPeriodo)
        Me.Controls.Add(Me.checkProveedor)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "informeCompras2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Informe compras realizadas"
        CType(Me.comboHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click

        Dim ds As New DataSet

        adaptadorCompra.Fill(ds)

        Dim p As New repCompras

        p.SetDataSource(ds)

        crv.ReportSource = p

        'Dim SelectFormula As String
        'SelectFormula = "{detallepresupuesto.idpresupuesto} = " & textPresupuesto.Text

        'crv.SelectionFormula = SelectFormula

    End Sub

    Private Sub informeCompras2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub informeCompras2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
    End Sub
End Class
