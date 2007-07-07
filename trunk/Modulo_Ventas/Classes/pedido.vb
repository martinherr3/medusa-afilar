Public Class pedido

    Public Function buscarPedidos(ByVal IDcliente As Integer, ByVal Estado As Integer) As DataSet
        Dim sql As String = "select P.idpedido, P.fechaRealizacion, E.nombre, SUM(PP.cantidad*PP.precio) as total, C.nombre " & _
                            "from pedido P, estado E, cliente C, partepedido PP " & _
                            "where P.idestado = E.idestado And P.idcliente = C.idcliente And P.idestado =" & Estado & " And P.idpedido = PP.idpedido And P.idcliente =" & IDcliente & _
                            "group by P.idpedido, P.fechaRealizacion, E.nombre, C.nombre"

        Dim comm As New SqlClient.SqlCommand(sql, cnn)
        Dim DA As New SqlClient.SqlDataAdapter(comm)
        Dim DS As DataSet
        DS = New DataSet
        DA.Fill(DS, "pedidos")
        Return DS
    End Function

    Public Sub ActualizarPedido(ByVal IdPedido As Integer, ByVal Estado As Integer)

        Dim Cmm As New SqlClient.SqlCommand

        Cmm.CommandText = "update pedido set idestado=" & Estado & " where idpedido=" & IdPedido
        cnn.Open()
        Cmm.Connection = cnn
        Cmm.ExecuteNonQuery()
        cnn.Close()
    End Sub
End Class
