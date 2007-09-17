
Imports Dundas.Charting.WinControl

Public Class DashboardForm

    Private dashboard As New Dashboard
    Private row As DataRow
    Private reader As SqlClient.SqlDataReader

    Private Sub DashboardForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'gfxProdBarras.Series.Add("fresas")
        'gfxProdBarras.Series.Add("servicios")

        'gfxProdBarras.Series("fresas").Type = Dundas.Charting.WinControl.SeriesChartType.Bar
        'gfxProdBarras.Series("servicios").Type = Dundas.Charting.WinControl.SeriesChartType.Bar

        'gfxProdBarras.Series("fresas").ChartArea = "Default"
        'gfxProdBarras.Series("servicios").ChartArea = "Default"

        'Dim desde As Date = dateDesde.Value
        'Dim hasta As Date = dateHasta.Value

        'Dim ds As DataSet = dashboard.obtenerDatosProduccion(desde, hasta)

        'Dim i As Integer

        'For i = 1 To 6
        '    gfxProdBarras.Series("fresas").Points.AddY(i)
        'Next

    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        'periodo para el que se muestran los datos
        Dim desde As Date = dateDesde.Value
        Dim hasta As Date = dateHasta.Value

        'serie fresas grafico de barras
        gfxProdBarras.Series("fresas").ChartArea = "Default"
        'serie servicio grafico de barras
        gfxProdBarras.Series("servicios").ChartArea = "Default"
        gfxProdBarras.ChartAreas("Default").AxisY.Title = "$"


        'serie fresas
        dashboard.obtenerDatosProduccion(desde, hasta, gfxProdBarras)


        'serie servicios
        dashboard.obtenerDatosServicio(desde, hasta, gfxProdBarras)

        Me.Refresh()

    End Sub
End Class