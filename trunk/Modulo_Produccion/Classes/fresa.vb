Public Class fresa
    Private ts As DataGridTableStyle
    Private mdafresa As SqlClient.SqlDataAdapter
    Private cmdbuilder As SqlClient.SqlCommandBuilder

    Public Sub cargaradaptador(ByVal strsql As String, ByVal conexion As SqlClient.SqlConnection)
        mdafresa = New SqlClient.SqlDataAdapter(strsql, conexion)
    End Sub
    Public Sub cargardatos(ByVal ds As DataSet, ByVal tabla As String)
        mdafresa.Fill(ds, tabla)
    End Sub
    Public Sub cargaresquema(ByVal ds As DataSet, ByVal tabla As String)
        mdafresa.FillSchema(ds, SchemaType.Source, tabla)
    End Sub
    Public Sub actualizar(ByVal ds As DataSet, ByVal tabla As String)
        cmdbuilder = New SqlClient.SqlCommandBuilder(mdafresa)
        mdafresa.Update(ds, tabla)
    End Sub
    Public Sub cargarcol(ByVal ds As DataSet)
        ds.Tables("fresa").Columns.Add("seleccionarF", GetType(Boolean)).DefaultValue = False
        'Dim dc1 As New DataColumn("seleccionarF")
        'dc1.DefaultValue = False
        'ds.Tables("fresa").Columns.Add(dc1)
        ds.Tables("fresa").Columns.Add("nombre", GetType(String)).DefaultValue = String.Empty
    End Sub
    Public Sub setearGrilla(ByVal dg As DataGrid)

        ts = New DataGridTableStyle

        ts.MappingName = "fresa"

        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarF", 20, HorizontalAlignment.Center, False, "", "", False, True, False, "")
        ts.GridColumnStyles.Add(c0)


        Dim c1 As New grdstyle.CGridTextBoxStyle("nroserie", 90, HorizontalAlignment.Center, True, "NRO SERIE", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("nombre", 150, HorizontalAlignment.Center, True, "NOMBRE", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("precio", 75, HorizontalAlignment.Center, True, "PRECIO", "", "")
        ts.GridColumnStyles.Add(c3)

        dg.TableStyles.Add(ts)
    End Sub
End Class
