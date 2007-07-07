Public Class servicio
    Private ts As DataGridTableStyle
    Private mdaservicio As SqlClient.SqlDataAdapter
    Private cmdbuilder As SqlClient.SqlCommandBuilder

    Public Sub cargaradaptador(ByVal strsql As String, ByVal conexion As SqlClient.SqlConnection)
        mdaservicio = New SqlClient.SqlDataAdapter(strsql, conexion)
    End Sub
    Public Sub cargardatos(ByVal ds As DataSet, ByVal tabla As String)
        mdaservicio.Fill(ds, tabla)
    End Sub
    Public Sub cargaresquema(ByVal ds As DataSet, ByVal tabla As String)
        mdaservicio.FillSchema(ds, SchemaType.Source, tabla)
    End Sub
    Public Sub actualizar(ByVal ds As DataSet, ByVal tabla As String)
        cmdbuilder = New SqlClient.SqlCommandBuilder(mdaservicio)
        mdaservicio.Update(ds, tabla)
    End Sub
    Public Sub cargarcol(ByVal ds As DataSet)
        ds.Tables("servicios").Columns.Add("seleccionarServ", GetType(Boolean)).DefaultValue = False
        ds.Tables("servicios").Columns.Add("precio", GetType(Decimal)).DefaultValue = 0
    End Sub
    Public Sub setearGrilla(ByVal dg As DataGrid)

        ts = New DataGridTableStyle

        ts.MappingName = "servicios"

        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarServ", 20, HorizontalAlignment.Center, False, "", "", False, True, False, "")
        ts.GridColumnStyles.Add(c0)


        Dim c1 As New grdstyle.CGridTextBoxStyle("nombre", 105, HorizontalAlignment.Center, True, "SERVICIO", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridNumericUpDownStyle("precio", 50, "PRECIO", 0, 1000, 2, 1, LeftRightAlignment.Right, 0, "")
        ts.GridColumnStyles.Add(c2)

        dg.TableStyles.Add(ts)
    End Sub
End Class
