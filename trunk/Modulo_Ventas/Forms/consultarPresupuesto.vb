Public Class consultarPresupuesto


    Private presupuesto As New presupuesto
    Private ds As New DataSet


    Private Sub consultarPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        presupuesto.cargarAdaptador()
        presupuesto.cargarDatos(ds, "Presupuesto")
        Dim dv As New DataView(ds.Tables("Presupuesto"))

        dataGridPresupuesto.DataSource = dv



    End Sub
End Class