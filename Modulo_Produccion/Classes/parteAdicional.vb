Public Class ParteAdicional
    Private selectParteAdicional As New SqlClient.SqlCommand
    Private insertParteAdicional As New SqlClient.SqlCommand
    Private updateParteAdicional As New SqlClient.SqlCommand
    Private deleteParteAdicional As New SqlClient.SqlCommand
    Private adaptadorParteAdicional As New SqlClient.SqlDataAdapter
    Private ts As DataGridTableStyle



    Public Sub cargarAdaptador()
        '
        'adaptadorParteAdicional
        '
        Me.adaptadorParteAdicional.DeleteCommand = Me.deleteParteAdicional
        Me.adaptadorParteAdicional.InsertCommand = Me.insertParteAdicional
        Me.adaptadorParteAdicional.SelectCommand = Me.selectParteAdicional
        Me.adaptadorParteAdicional.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "parteadicional", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idadicional", "idadicional"), New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("plano", "plano"), New System.Data.Common.DataColumnMapping("imagen", "imagen"), New System.Data.Common.DataColumnMapping("idmateriaprima", "idmateriaprima"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("tiempo", "tiempo"), New System.Data.Common.DataColumnMapping("costo", "costo"), New System.Data.Common.DataColumnMapping("precio", "precio")})})
        Me.adaptadorParteAdicional.UpdateCommand = Me.updateParteAdicional
        '
        'SqlSelectCommand1
        '
        Me.selectParteAdicional.CommandText = "SELECT idadicional, idmodelo, nombre, plano, imagen, idmateriaprima, cantidad, de" & _
        "scripcion, tiempo, costo, precio FROM parteadicional"
        Me.selectParteAdicional.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertParteAdicional.CommandText = "INSERT INTO parteadicional(idadicional, idmodelo, nombre, plano, imagen, idmateri" & _
        "aprima, cantidad, descripcion, tiempo, costo, precio) VALUES (@idadicional, @idm" & _
        "odelo, @nombre, @plano, @imagen, @idmateriaprima, @cantidad, @descripcion, @tiem" & _
        "po, @costo, @precio); SELECT idadicional, idmodelo, nombre, plano, imagen, idmat" & _
        "eriaprima, cantidad, descripcion, tiempo, costo, precio FROM parteadicional WHER" & _
        "E (idadicional = @idadicional) AND (idmodelo = @idmodelo)"
        Me.insertParteAdicional.Connection = cnn
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idadicional", System.Data.SqlDbType.Int, 4, "idadicional"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 60, "nombre"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plano", System.Data.SqlDbType.VarChar, 80, "plano"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@imagen", System.Data.SqlDbType.VarBinary, 2147483647, "imagen"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmateriaprima", System.Data.SqlDbType.Int, 4, "idmateriaprima"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Float, 8, "cantidad"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tiempo", System.Data.SqlDbType.Float, 8, "tiempo"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Float, 8, "costo"))
        Me.insertParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        '
        'SqlUpdateCommand1
        '
        Me.updateParteAdicional.CommandText = "UPDATE parteadicional SET idadicional = @idadicional, idmodelo = @idmodelo, nombr" & _
        "e = @nombre, plano = @plano, imagen = @imagen, idmateriaprima = @idmateriaprima," & _
        " cantidad = @cantidad, descripcion = @descripcion, tiempo = @tiempo, costo = @co" & _
        "sto, precio = @precio WHERE (idadicional = @Original_idadicional) AND (idmodelo " & _
        "= @Original_idmodelo) AND (cantidad = @Original_cantidad OR @Original_cantidad I" & _
        "S NULL AND cantidad IS NULL) AND (costo = @Original_costo OR @Original_costo IS " & _
        "NULL AND costo IS NULL) AND (idmateriaprima = @Original_idmateriaprima OR @Origi" & _
        "nal_idmateriaprima IS NULL AND idmateriaprima IS NULL) AND (nombre = @Original_n" & _
        "ombre OR @Original_nombre IS NULL AND nombre IS NULL) AND (plano = @Original_pla" & _
        "no OR @Original_plano IS NULL AND plano IS NULL) AND (precio = @Original_precio " & _
        "OR @Original_precio IS NULL AND precio IS NULL) AND (tiempo = @Original_tiempo O" & _
        "R @Original_tiempo IS NULL AND tiempo IS NULL); SELECT idadicional, idmodelo, no" & _
        "mbre, plano, imagen, idmateriaprima, cantidad, descripcion, tiempo, costo, preci" & _
        "o FROM parteadicional WHERE (idadicional = @idadicional) AND (idmodelo = @idmode" & _
        "lo)"
        Me.updateParteAdicional.Connection = cnn
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idadicional", System.Data.SqlDbType.Int, 4, "idadicional"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 60, "nombre"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plano", System.Data.SqlDbType.VarChar, 80, "plano"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@imagen", System.Data.SqlDbType.VarBinary, 2147483647, "imagen"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmateriaprima", System.Data.SqlDbType.Int, 4, "idmateriaprima"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Float, 8, "cantidad"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tiempo", System.Data.SqlDbType.Float, 8, "tiempo"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Float, 8, "costo"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idadicional", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idadicional", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmateriaprima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmateriaprima", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_plano", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "plano", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tiempo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tiempo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteParteAdicional.CommandText = "DELETE FROM parteadicional WHERE (idadicional = @Original_idadicional) AND (idmod" & _
        "elo = @Original_idmodelo) AND (cantidad = @Original_cantidad OR @Original_cantid" & _
        "ad IS NULL AND cantidad IS NULL) AND (costo = @Original_costo OR @Original_costo" & _
        " IS NULL AND costo IS NULL) AND (idmateriaprima = @Original_idmateriaprima OR @O" & _
        "riginal_idmateriaprima IS NULL AND idmateriaprima IS NULL) AND (nombre = @Origin" & _
        "al_nombre OR @Original_nombre IS NULL AND nombre IS NULL) AND (plano = @Original" & _
        "_plano OR @Original_plano IS NULL AND plano IS NULL) AND (precio = @Original_pre" & _
        "cio OR @Original_precio IS NULL AND precio IS NULL) AND (tiempo = @Original_tiem" & _
        "po OR @Original_tiempo IS NULL AND tiempo IS NULL)"
        Me.deleteParteAdicional.Connection = cnn
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idadicional", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idadicional", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmateriaprima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmateriaprima", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_plano", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "plano", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParteAdicional.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tiempo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tiempo", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorParteAdicional.Fill(ds, tabla)
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorParteAdicional.Update(ds, tabla)
    End Sub


    Public Sub setearGrilla(ByVal dg As DataGrid)
        ts = New DataGridTableStyle

        ts.MappingName = "parteadicional"

        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarPA", 30, HorizontalAlignment.Center, False, "", "", False, True, False, Nothing)
        ts.GridColumnStyles.Add(c0)

        Dim c1 As New grdstyle.CGridTextBoxStyle("idadicional", 50, HorizontalAlignment.Center, True, "ID", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("nombre", 150, HorizontalAlignment.Center, True, "Nombre", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("descripcion", 300, HorizontalAlignment.Center, True, "Descripción", "", "")
        ts.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("costo", 100, HorizontalAlignment.Center, True, "Costo", "", "")
        ts.GridColumnStyles.Add(c4)

        'Dim c5 As New grdstyle.CGridTextBoxStyle("precio", 100, HorizontalAlignment.Center, True, "Precio", "", "")
        'ts.GridColumnStyles.Add(c5)

        Dim c5 As New grdstyle.CGridNumericUpDownStyle("precio", 100, "Precio", 1, 10000, 2, 1, LeftRightAlignment.Right, 0, "")
        ts.GridColumnStyles.Add(c5)

        dg.TableStyles.Add(ts)

    End Sub

    Public Sub agregarCheck(ByVal ds As DataSet)
        ds.Tables("parteadicional").Columns.Add("seleccionarPA", Type.GetType("System.Boolean"))
    End Sub
End Class
