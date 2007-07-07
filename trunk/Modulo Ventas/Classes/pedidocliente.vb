Public Class pedidocliente
    Private mdapedidocliente As SqlClient.SqlDataAdapter
    Private cmdbuilder As SqlClient.SqlCommandBuilder
    Public Sub cargaradaptador(ByVal strsql As String, ByVal conexion As SqlClient.SqlConnection)
        mdapedidocliente = New SqlClient.SqlDataAdapter(strsql, conexion)
    End Sub
    Public Sub cargardatos(ByVal ds As DataSet, ByVal tabla As String)
        mdapedidocliente.Fill(ds, tabla)
    End Sub
    Public Sub cargaresquema(ByVal ds As DataSet, ByVal tabla As String)
        mdapedidocliente.FillSchema(ds, SchemaType.Source, tabla)
    End Sub
    Public Sub actualizar(ByVal ds As DataSet, ByVal tabla As String)
        cmdbuilder = New SqlClient.SqlCommandBuilder(mdapedidocliente)
        mdapedidocliente.Update(ds, tabla)
    End Sub
End Class
