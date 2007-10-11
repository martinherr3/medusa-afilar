Public Class Dashboard

    Private selectCommand As New SqlClient.SqlCommand
    Private adapter As New SqlClient.SqlDataAdapter
    Private ds As New DataSet
    Private reader As SqlClient.SqlDataReader

    Public Sub obtenerDatosProduccion(ByVal desde As Date, ByVal hasta As Date, ByRef graph As Dundas.Charting.WinControl.Chart)

        selectCommand.Connection = cnn
        selectCommand.Connection.Open()
        selectCommand.CommandText = "SELECT TOP 12 SUM(f.precio) As precio, SUM(f.costofabricacion) As costo, MONTH(f.fechafinfabricacion) As mes, YEAR(f.fechafinfabricacion) As ano" & _
                                       " FROM fresa f" & _
                                       " WHERE f.fechafinfabricacion > '" + desde.Date + "'" & _
                                       " AND f.fechafinfabricacion < '" + hasta.Date + "'" & _
                                       " GROUP BY MONTH(f.fechafinfabricacion), YEAR(f.fechafinfabricacion)" & _
                                       " ORDER BY YEAR(f.fechafinfabricacion) asc, MONTH(f.fechafinfabricacion)"

        selectCommand.CommandType = CommandType.Text
        adapter.SelectCommand = selectCommand
        ds.Clear()
        adapter.Fill(ds, "fresas")

        Dim i As Integer = ds.Tables("fresas").Rows.Count - 1
        reader = selectCommand.ExecuteReader

        Dim yval(i) As Double
        Dim xval(i) As String
        i = 0

        While reader.Read
            yval.SetValue(Convert.ToDouble(reader.Item(0)), i)
            xval.SetValue(Convert.ToString(reader.Item(2)) + "-" + Convert.ToString(reader.Item(3)), i)
            i = i + 1
        End While

        graph.Series("fresas").Points.DataBindXY(xval, yval)

        selectCommand.Connection.Close()


    End Sub


    Public Sub obtenerDatosServicio(ByVal desde As Date, ByVal hasta As Date, ByRef graph As Dundas.Charting.WinControl.Chart)

        selectCommand.Connection = cnn
        selectCommand.Connection.Open()
        selectCommand.CommandText = "SELECT TOP 12 SUM(s.precio) As precio, MONTH(p.fecharealizacion) As mes, YEAR(p.fecharealizacion) As ano" & _
                                    " FROM detalleordenservicio s" & _
                                    " INNER JOIN pedido p ON s.idpedido = p.idpedido" & _
                                    " WHERE p.fecharealizacion > '" + desde.Date + "'" & _
                                    " AND p.fecharealizacion < '" + hasta.Date + "'" & _
                                    " GROUP BY MONTH(p.fecharealizacion), YEAR(p.fecharealizacion)" & _
                                    " ORDER BY YEAR(p.fecharealizacion) asc, MONTH(p.fecharealizacion)"

        selectCommand.CommandType = CommandType.Text
        adapter.SelectCommand = selectCommand
        adapter.Fill(ds, "servicios")
        Dim i As Integer = ds.Tables("servicios").Rows.Count - 1
        reader = selectCommand.ExecuteReader

        Dim yval(i) As Double
        Dim xval(i) As String
        i = 0

        While reader.Read
            yval.SetValue(Convert.ToDouble(reader.Item(0)), i)
            xval.SetValue(Convert.ToString(reader.Item(1)) + "-" + Convert.ToString(reader.Item(2)), i)
            i = i + 1
        End While

        graph.Series("servicios").Points.DataBindXY(xval, yval)

        selectCommand.Connection.Close()

    End Sub


    Public Sub obtenerPorcentajesServicio(ByVal desde As Date, ByVal hasta As Date, ByRef graph As Dundas.Charting.WinControl.Chart)

        selectCommand.Connection = cnn
        selectCommand.Connection.Open()
        selectCommand.CommandText = "SELECT TOP 6 o.nombre, COUNT(o.nombre)" & _
                                    " FROM detalleordenservicio dos" & _
                                    " INNER JOIN operacion o ON dos.idoperacion = o.idoperacion" & _
                                    " INNER JOIN pedido p ON dos.idpedido = p.idpedido" & _
                                    " WHERE p.fecharealizacion > '" + desde.Date + "'" & _
                                    " AND p.fecharealizacion < '" + hasta.Date + "'" & _
                                    " GROUP BY o.nombre" & _
                                    " ORDER BY COUNT(o.nombre) desc"

        selectCommand.CommandType = CommandType.Text
        adapter.SelectCommand = selectCommand
        adapter.Fill(ds, "porcentajeServicios")
        Dim i As Integer = ds.Tables("porcentajeServicios").Rows.Count - 1
        reader = selectCommand.ExecuteReader

        Dim yval(i) As Double
        Dim xval(i) As String
        i = 0

        While reader.Read
            yval.SetValue(Convert.ToDouble(reader.Item(1)), i)
            xval.SetValue(Convert.ToString(reader.Item(0)), i)
            i = i + 1
        End While

        graph.Series("Servicios").Points.DataBindXY(xval, yval)

        selectCommand.Connection.Close()

    End Sub


    Public Sub obtenerPorcentajesFresa(ByVal desde As Date, ByVal hasta As Date, ByRef graph As Dundas.Charting.WinControl.Chart)

        selectCommand.Connection = cnn
        selectCommand.Connection.Open()
        selectCommand.CommandText = "SELECT TOP 6 mf.nombre, COUNT(mf.idmodelo)" & _
                                    " FROM fresa f" & _
                                    " INNER JOIN modelofresa mf ON f.idmodelo = mf.idmodelo" & _
                                    " INNER JOIN pedido p ON f.nropedido = p.idpedido" & _
                                    " WHERE p.fecharealizacion > '" + desde.Date + "'" & _
                                    " AND p.fecharealizacion < '" + hasta.Date + "'" & _
                                    " GROUP BY mf.nombre" & _
                                    " ORDER BY COUNT(mf.idmodelo) desc"

        selectCommand.CommandType = CommandType.Text
        adapter.SelectCommand = selectCommand
        adapter.Fill(ds, "porcentajeFresas")
        Dim i As Integer = ds.Tables("porcentajeFresas").Rows.Count - 1
        reader = selectCommand.ExecuteReader

        Dim yval(i) As Double
        Dim xval(i) As String
        i = 0

        While reader.Read
            yval.SetValue(Convert.ToDouble(reader.Item(1)), i)
            xval.SetValue(Convert.ToString(reader.Item(0)), i)
            i = i + 1
        End While

        graph.Series("Fresas").Points.DataBindXY(xval, yval)

        selectCommand.Connection.Close()

    End Sub


    Public Function obtenerPorcentajeCostoProduccion(ByVal desde As Date, ByVal hasta As Date) As Double

        selectCommand.Connection = cnn
        selectCommand.Connection.Open()
        selectCommand.CommandText = "SELECT SUM(f.precio) As precio, SUM(f.costofabricacion) As costo" & _
                                    " FROM fresa f" & _
                                    " WHERE f.fechafinfabricacion > '" + desde.Date + "'" & _
                                    " AND f.fechafinfabricacion < '" + hasta.Date + "'"

        selectCommand.CommandType = CommandType.Text
        adapter.SelectCommand = selectCommand
        reader = selectCommand.ExecuteReader
        Dim costo As Double
        Dim precio As Double

        reader.Read()
        If reader.Item(0) IsNot DBNull.Value Then
            precio = reader.Item(0)
            costo = reader.Item(1)
        End If

        selectCommand.Connection.Close()

        Return ((costo * 100) / precio)

    End Function


    Public Function obtenerExactitudPlanificacionInicio(ByVal desde As Date, ByVal hasta As Date) As Double

        selectCommand.Connection = cnn
        selectCommand.Connection.Open()
        selectCommand.CommandText = "SELECT AVG(DATEDIFF(hh,dhr.fechahorainicioplanificada, dhr.fechahorainicioreal))" & _
                                    " FROM detallehojaderuta dhr" & _
                                    " WHERE dhr.fechahorainicioreal > '" + desde.Date + "'" & _
                                    " AND dhr.fechahorafinreal < '" + hasta.Date + "'"

        selectCommand.CommandType = CommandType.Text
        adapter.SelectCommand = selectCommand
        reader = selectCommand.ExecuteReader
        Dim desviacion As Double

        reader.Read()
        If reader.Item(0) IsNot DBNull.Value Then
            desviacion = reader.Item(0)
        End If

        selectCommand.Connection.Close()

        Return desviacion

    End Function


    Public Function obtenerExactitudPlanificacionFin(ByVal desde As Date, ByVal hasta As Date) As Double

        selectCommand.Connection = cnn
        selectCommand.Connection.Open()
        selectCommand.CommandText = "SELECT AVG(DATEDIFF(hh,dhr.fechahorafinplanificada, dhr.fechahorafinreal))" & _
                                    " FROM detallehojaderuta dhr" & _
                                    " WHERE dhr.fechahorainicioreal > '" + desde.Date + "'" & _
                                    " AND dhr.fechahorafinreal < '" + hasta.Date + "'"

        selectCommand.CommandType = CommandType.Text
        adapter.SelectCommand = selectCommand
        reader = selectCommand.ExecuteReader
        Dim desviacion As Double

        While reader.Read
            If reader.Item(0) IsNot DBNull.Value Then
                desviacion = reader.Item(0)
            End If
        End While

        selectCommand.Connection.Close()

        Return desviacion

    End Function

End Class
