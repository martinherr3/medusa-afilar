Public Class Dashboard

    Private selectCommand As New SqlClient.SqlCommand
    Private adapter As New SqlClient.SqlDataAdapter
    Private ds As New DataSet
    Private reader As SqlClient.SqlDataReader

    Public Sub obtenerDatosProduccion(ByVal desde As Date, ByVal hasta As Date, ByRef graph As Dundas.Charting.WinControl.Chart)


        'Dim resultado As New SqlClient.SqlDataReader
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

        'graph.Series("servicios").Points.DataBind(reader, "mes", "precio", "Tooltip=mes, Label=precio{C1}")

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

        'graph.Series("servicios").Points.DataBind(reader, "mes", "precio", "Tooltip=mes, Label=precio{C1}")

        graph.Series("servicios").Points.DataBindXY(xval, yval)

        selectCommand.Connection.Close()

    End Sub



End Class
