Public Class partepedida
    Private ts As DataGridTableStyle
    Private mdapartepedida As SqlClient.SqlDataAdapter
    Private cmdbuilder As SqlClient.SqlCommandBuilder

    Public Sub cargaradaptador(ByVal strsql As String, ByVal conexion As SqlClient.SqlConnection)
        mdapartepedida = New SqlClient.SqlDataAdapter(strsql, conexion)
    End Sub
    Public Sub cargardatos(ByVal ds As DataSet, ByVal tabla As String)
        mdapartepedida.Fill(ds, tabla)
    End Sub
    Public Sub cargaresquema(ByVal ds As DataSet, ByVal tabla As String)
        mdapartepedida.FillSchema(ds, SchemaType.Source, tabla)
    End Sub
    Public Sub actualizar(ByVal ds As DataSet, ByVal tabla As String)
        cmdbuilder = New SqlClient.SqlCommandBuilder(mdapartepedida)
        mdapartepedida.Update(ds, tabla)
    End Sub
    Public Sub setearGrilla(ByVal dg As DataGrid)

        ts = New DataGridTableStyle

        ts.MappingName = "partepedida"

        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarPP", 30, HorizontalAlignment.Center, False, "", "", False, True, False, Nothing)
        ts.GridColumnStyles.Add(c0)

        Dim c1 As New grdstyle.CGridTextBoxStyle("nombre", 100, HorizontalAlignment.Center, True, "NOMBRE PARTE", "", "")
        ts.GridColumnStyles.Add(c1)

        'Dim c2 As New grdstyle.CGridTextBoxStyle("cantidad", 150, HorizontalAlignment.Center, True, "CANTIDAD", "", "")
        'ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("precio", 75, HorizontalAlignment.Center, True, "PRECIO", "", "")
        ts.GridColumnStyles.Add(c3)

        dg.TableStyles.Add(ts)
    End Sub



    Public Sub agregarCol(ByVal ds As DataSet)
        ds.Tables("partepedida").Columns.Add("seleccionarPP", GetType(Boolean)).DefaultValue = False
        ds.Tables("partepedida").Columns.Add("nombre", GetType(String)).DefaultValue = String.Empty
    End Sub
End Class
