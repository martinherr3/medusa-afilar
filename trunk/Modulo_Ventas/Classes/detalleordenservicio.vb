Public Class detalleordenservicio
    Private ts As DataGridTableStyle
    Private mdaDOs As SqlClient.SqlDataAdapter
    Private cmdbuilder As SqlClient.SqlCommandBuilder

    Public Sub cargaradaptador(ByVal strsql As String, ByVal conexion As SqlClient.SqlConnection)
        mdaDOs = New SqlClient.SqlDataAdapter(strsql, conexion)
    End Sub
    Public Sub cargardatos(ByVal ds As DataSet, ByVal tabla As String)
        mdaDOs.Fill(ds, tabla)
    End Sub
    Public Sub cargaresquema(ByVal ds As DataSet, ByVal tabla As String)
        mdaDOs.FillSchema(ds, SchemaType.Source, tabla)
    End Sub
    Public Sub actualizar(ByVal ds As DataSet, ByVal tabla As String)
        cmdbuilder = New SqlClient.SqlCommandBuilder(mdaDOs)
        mdaDOs.Update(ds, tabla)
    End Sub
    Public Sub cargarcol(ByVal ds As DataSet)
        'ds.Tables("DOS").Columns.Add("seleccionarDOS", GetType(Boolean)).DefaultValue = False
        ds.Tables("DOS").Columns.Add("item", GetType(String)).DefaultValue = String.Empty
        ds.Tables("DOS").Columns.Add("operacion", GetType(String)).DefaultValue = String.Empty
        ds.Tables("DOS").Columns.Add("cantidad", GetType(Integer)).DefaultValue = 0
        ds.Tables("DOS").Columns.Add("nroserie", GetType(Integer)).DefaultValue = 0
    End Sub
    Public Sub setearGrilla(ByVal dg As DataGrid)

        ts = New DataGridTableStyle

        ts.MappingName = "DOS"

        'Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarDOS", 20, HorizontalAlignment.Center, False, "", "", False, True, False, "")
        'ts.GridColumnStyles.Add(c0)


        Dim c1 As New grdstyle.CGridTextBoxStyle("item", 90, HorizontalAlignment.Center, True, "OBJETO", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("operacion", 150, HorizontalAlignment.Center, True, "SERVICIO", "", "")
        ts.GridColumnStyles.Add(c2)
        Dim c4 As New grdstyle.CGridTextBoxStyle("cantidad", 75, HorizontalAlignment.Center, True, "CANTIDAD", "", "")
        ts.GridColumnStyles.Add(c4)
        Dim c3 As New grdstyle.CGridTextBoxStyle("precio", 75, HorizontalAlignment.Center, True, "PRECIO", "", "")
        ts.GridColumnStyles.Add(c3)
        Dim c5 As New grdstyle.CGridTextBoxStyle("nroserie", 75, HorizontalAlignment.Center, True, "NRO.SERIE", "", "")
        ts.GridColumnStyles.Add(c5)
        dg.TableStyles.Add(ts)
    End Sub
End Class
