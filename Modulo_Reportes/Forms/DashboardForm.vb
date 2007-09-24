
Imports Dundas.Charting.WinControl

Public Class DashboardForm

    Private dashboard As New Dashboard
    Private row As DataRow
    Private reader As SqlClient.SqlDataReader

    Private Sub DashboardForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'periodo inicial (ultimos seis meses)
        Dim desde As New Date(Now.Year, Now.Month - 6, Now.Day)
        dateDesde.Value = desde
        dateHasta.Value = Now

        realizarCalculos(dateDesde.Value, dateHasta.Value)

    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        'periodo para el que se muestran los datos
        Dim desde As Date = dateDesde.Value
        Dim hasta As Date = dateHasta.Value

        If (desde > hasta) Then
            MsgBox("La fecha desde es mayor a la fecha hasta")
            Exit Sub
        End If

        realizarCalculos(desde, hasta)

    End Sub


    Private Sub realizarCalculos(ByVal desde As Date, ByVal hasta As Date)
        'serie fresas grafico de barras
        gfxProdBarras.Series("fresas").ChartArea = "Default"
        'serie servicio grafico de barras
        gfxProdBarras.Series("servicios").ChartArea = "Default"
        gfxProdBarras.ChartAreas("Default").AxisY.Title = "$"
        'serie fresas
        dashboard.obtenerDatosProduccion(desde, hasta, gfxProdBarras)
        'serie servicios
        dashboard.obtenerDatosServicio(desde, hasta, gfxProdBarras)

        'Gauge costo
        Dim porcentajeCosto As Double = dashboard.obtenerPorcentajeCostoProduccion(desde, hasta)
        gaugeCosto.CircularGauges("Default").Pointers("Default").Value = porcentajeCosto

        'Gauge Exactitud planificacion
        Dim horasDesviacionInicio As Double = dashboard.obtenerExactitudPlanificacionInicio(desde, hasta)
        gaugePlanificacionInicio.CircularGauges("Default").Pointers("Default").Value = horasDesviacionInicio
        gaugePlanificacionInicio.NumericIndicators("NumericIndicator1").Value = horasDesviacionInicio
        Dim horasDesviacionFin As Double = dashboard.obtenerExactitudPlanificacionFin(desde, hasta)
        gaugePlanificacionFin.CircularGauges("Default").Pointers("Default").Value = horasDesviacionFin
        gaugePlanificacionFin.NumericIndicators("NumericIndicator1").Value = horasDesviacionFin

        'Grafico de torta servicios
        dashboard.obtenerPorcentajesServicio(desde, hasta, gfxServicios)

        'Grafico de torta Modelo Fresa
        dashboard.obtenerPorcentajesFresa(desde, hasta, gfxFresas)

        Me.Refresh()
    End Sub

End Class