

Public Class MateriaPrima

    Private selectMateriaPrima As New SqlClient.SqlCommand
    Private adaptadorMateriaPrima As New SqlClient.SqlDataAdapter
    Private resultado As SqlClient.SqlDataReader

    Public Function obtenerPrecioMateriaPrima(ByVal idMateriaPrima As Integer) As Double
        selectMateriaPrima.Connection = cnn
        selectMateriaPrima.Connection.Open()
        selectMateriaPrima.CommandText = "SELECT tmp.idtipomateriaprima, tmp.nombre, doc.precio, MAX(ocmp.fecharealizacion) " & _
                "FROM tipomateriaprima tmp, detalleordencompra doc, ordencompramp ocmp " & _
                "WHERE(tmp.idtipomateriaprima = doc.idtipomateriaprima) " & _
                "AND doc.idordencompra = ocmp.idordencompra " & _
                "AND doc.idestado IN (12, 13) " & _
                "AND tmp.idtipomateriaprima = " + idMateriaPrima.ToString & _
                "GROUP BY tmp.idtipomateriaprima, tmp.nombre, doc.precio, ocmp.fecharealizacion"

        selectMateriaPrima.CommandType = CommandType.Text
        resultado = selectMateriaPrima.ExecuteReader
        Dim precio As Double
        While resultado.Read
            precio = resultado.Item(2)
        End While

        selectMateriaPrima.Connection.Close()

        Return precio

    End Function


    Public Function obtenerNombreMateriaPrima(ByVal idMateriaPrima As Integer) As String
        selectMateriaPrima.Connection = cnn
        selectMateriaPrima.Connection.Open()
        selectMateriaPrima.CommandText = "SELECT tmp.nombre " & _
                                         "FROM tipomateriaprima tmp " & _
                                         "WHERE tmp.idtipomateriaprima = " + idMateriaPrima.ToString


        selectMateriaPrima.CommandType = CommandType.Text
        resultado = selectMateriaPrima.ExecuteReader
        Dim nombre As String = ""
        While resultado.Read
            nombre = resultado.Item(0)
        End While

        selectMateriaPrima.Connection.Close()

        Return nombre.Trim
    End Function
End Class
