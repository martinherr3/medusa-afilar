Public Class Parametro
    Private selectParametro As New SqlClient.SqlCommand
    Private adaptadorParametro As New SqlClient.SqlDataAdapter
    Private resultado As SqlClient.SqlDataReader

    Public Function obtenerParametro(ByVal label As String) As Object
        selectParametro.Connection = cnn
        selectParametro.CommandType = CommandType.Text
        selectParametro.Connection.Open()
        Dim consulta As String
        consulta = "SELECT * " & _
                   "FROM app_param app " & _
                   "WHERE app.label LIKE '" + label + "'"

        selectParametro.CommandText = consulta

        resultado = selectParametro.ExecuteReader
        Dim value As Object
        value = Nothing
        While resultado.Read
            If (resultado.Item(2) <> Nothing) Then
                value = resultado.Item(2)
            Else
                value = resultado.Item(3)
            End If
        End While

        selectParametro.Connection.Close()

        Return value
    End Function

End Class
