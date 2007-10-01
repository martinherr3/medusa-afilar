<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.adaptadorCompra2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'adaptadorCompra2
        '
        Me.adaptadorCompra2.SelectCommand = Me.SqlSelectCommand2
        Me.adaptadorCompra2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hojaderuta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("Expr3", "Expr3"), New System.Data.Common.DataColumnMapping("Expr5", "Expr5"), New System.Data.Common.DataColumnMapping("Expr4", "Expr4"), New System.Data.Common.DataColumnMapping("Expr6", "Expr6"), New System.Data.Common.DataColumnMapping("Expr7", "Expr7"), New System.Data.Common.DataColumnMapping("Expr8", "Expr8"), New System.Data.Common.DataColumnMapping("Expr9", "Expr9"), New System.Data.Common.DataColumnMapping("Expr10", "Expr10"), New System.Data.Common.DataColumnMapping("Expr11", "Expr11"), New System.Data.Common.DataColumnMapping("idhojaderuta", "idhojaderuta"), New System.Data.Common.DataColumnMapping("fechainicioproduccion", "fechainicioproduccion"), New System.Data.Common.DataColumnMapping("Expr12", "Expr12"), New System.Data.Common.DataColumnMapping("idetapadefabricacion", "idetapadefabricacion"), New System.Data.Common.DataColumnMapping("Expr13", "Expr13"), New System.Data.Common.DataColumnMapping("idtorneado", "idtorneado"), New System.Data.Common.DataColumnMapping("fechahorainicioreal", "fechahorainicioreal"), New System.Data.Common.DataColumnMapping("fechahorainicioplanificada", "fechahorainicioplanificada"), New System.Data.Common.DataColumnMapping("fechahorafinreal", "fechahorafinreal"), New System.Data.Common.DataColumnMapping("fechahorafinplanificada", "fechahorafinplanificada"), New System.Data.Common.DataColumnMapping("Expr14", "Expr14"), New System.Data.Common.DataColumnMapping("idlegajo", "idlegajo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("apellido", "apellido"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("idcargo", "idcargo"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("titulo", "titulo"), New System.Data.Common.DataColumnMapping("idlocalidad", "idlocalidad"), New System.Data.Common.DataColumnMapping("turno", "turno"), New System.Data.Common.DataColumnMapping("idperfil", "idperfil"), New System.Data.Common.DataColumnMapping("idetapafabricacion", "idetapafabricacion"), New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("idtipofresa", "idtipofresa"), New System.Data.Common.DataColumnMapping("idoperacion", "idoperacion"), New System.Data.Common.DataColumnMapping("orden", "orden"), New System.Data.Common.DataColumnMapping("tiempoadicional", "tiempoadicional"), New System.Data.Common.DataColumnMapping("detalle", "detalle"), New System.Data.Common.DataColumnMapping("idoperacion1", "idoperacion1"), New System.Data.Common.DataColumnMapping("nombre1", "nombre1"), New System.Data.Common.DataColumnMapping("maquina", "maquina"), New System.Data.Common.DataColumnMapping("duracionpromedio", "duracionpromedio"), New System.Data.Common.DataColumnMapping("idgradodificultad", "idgradodificultad"), New System.Data.Common.DataColumnMapping("tolerancia", "tolerancia"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=NOTEBOOK;Initial Catalog=Afilar;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(927, 589)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 589)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents adaptadorCompra2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
