Public Class Form1

    Dim selectMaestro As New SqlClient.SqlCommand
    Dim selectDetalle As New SqlClient.SqlCommand
    Dim adapterMaestro As New SqlClient.SqlDataAdapter
    Dim adapterDetalle As New SqlClient.SqlDataAdapter
    Dim query As String
    Dim reporteHR As RptHojaRuta

    Public pNrofresa As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        query = "SELECT '*' + ltrim(str(fresa.nroserie)) + '*' as nroseriebarra, fresa.nroserie,  fresa.fechafinfabricacion, fresa.costofabricacion, fresa.estado, fresa.nropedido, fresa.controlcalidad, fresa.idhojaderuta, fresa.precio," & _
                " fresa.idtipo, fresa.idmodelo, tipofresa.nombre, tipofresa.diametroexterior, tipofresa.diametroagujero, tipofresa.cantidaddientes, tipofresa.plano," & _
                " TipoFresa.caracteristicas, TipoFresa.imagen" & _
                " FROM fresa INNER JOIN" & _
                " tipofresa ON fresa.idtipo = tipofresa.idtipo AND fresa.idmodelo = tipofresa.idmodelo"
        cnn.Open()
        selectMaestro.CommandType = CommandType.Text
        selectMaestro.CommandText = query
        selectMaestro.Connection = cnn
        adapterMaestro.SelectCommand = selectMaestro

        query = "SELECT detallehojaderuta.idhojaderuta, detallehojaderuta.idetapadefabricacion, detallehojaderuta.idlegajo, detallehojaderuta.idtorneado," & _
                " detallehojaderuta.fechahorainicioreal, detallehojaderuta.fechahorainicioplanificada, detallehojaderuta.fechahorafinreal," & _
                " detallehojaderuta.fechahorafinplanificada, detallehojaderuta.observaciones, operacion.nombre, operacion.maquina, operacion.duracionpromedio," & _
                " etapadefabricacion.detalle, etapadefabricacion.orden, etapadefabricacion.tiempoadicional" & _
                " FROM operacion INNER JOIN" & _
                " etapadefabricacion ON operacion.idoperacion = etapadefabricacion.idoperacion INNER JOIN" & _
                " detallehojaderuta ON etapadefabricacion.idetapafabricacion = detallehojaderuta.idetapadefabricacion  inner join fresa on fresa.idhojaderuta = detallehojaderuta.idhojaderuta where fresa.idmodelo = etapadefabricacion.idmodelo and fresa.idtipo = etapadefabricacion.idtipofresa" ' and fresa.idmodelo = etapadefabricacion.idmodelo and fresa.idtipo = etapadefabricacion.idtipofresa"

        selectDetalle.CommandType = CommandType.Text
        selectDetalle.CommandText = query
        selectDetalle.Connection = cnn
        adapterDetalle.SelectCommand = selectDetalle

        Dim ds As New DSHojaDeRuta
        adapterMaestro.Fill(ds, "maestro_hr")
        adapterDetalle.Fill(ds, "detalle_hr")

        reporteHR = New RptHojaRuta
        reporteHR.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = reporteHR

        'CrystalReportViewer1.SelectionFormula = "{maestro_hr.nroserie} = 19"
        CrystalReportViewer1.SelectionFormula = "{maestro_hr.nroserie} = " & pNrofresa
        cnn.Close()

        'adaptadorCompra2.Fill(DsHojaRuta1)
        'Dim p As New rptHojaRuta
        'p.SetDataSource(DsHojaRuta1)
        'CrystalReportViewer1.ReportSource = p
        'Dim SelectFormula As String


        'SelectFormula = "{hojaderuta.idhojaderuta} = " & "1"
        'CrystalReportViewer1.SelectionFormula = SelectFormula

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class