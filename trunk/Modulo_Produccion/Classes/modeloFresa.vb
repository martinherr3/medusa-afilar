Public Class ModeloFresa

    Private insertModeloFresa As New SqlClient.SqlCommand
    Private deleteModeloFresa As New SqlClient.SqlCommand
    Private updateModeloFresa As New SqlClient.SqlCommand
    Private updateEstado As New SqlClient.SqlCommand
    Private selectModeloFresa As New SqlClient.SqlCommand
    Private adaptadorModeloFresa As New SqlClient.SqlDataAdapter
    Private ts As DataGridTableStyle



    Public Sub cargarAdaptador()
        '
        'adaptadorModeloFresa
        '
        Me.adaptadorModeloFresa.DeleteCommand = Me.deleteModeloFresa
        Me.adaptadorModeloFresa.InsertCommand = Me.insertModeloFresa
        Me.adaptadorModeloFresa.SelectCommand = Me.selectModeloFresa
        Me.adaptadorModeloFresa.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "modelofresa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("grupomodelo", "grupomodelo"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("materialatrabajar", "materialatrabajar"), New System.Data.Common.DataColumnMapping("mododeavance", "mododeavance"), New System.Data.Common.DataColumnMapping("tipoacabado", "tipoacabado"), New System.Data.Common.DataColumnMapping("velocidaddeavance", "velocidaddeavance"), New System.Data.Common.DataColumnMapping("tipomodelo", "tipomodelo"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("estado", "estado")})})
        Me.adaptadorModeloFresa.UpdateCommand = Me.updateModeloFresa
        '
        'SqlSelectCommand1
        '
        Me.selectModeloFresa.CommandText = "SELECT idmodelo, nombre, grupomodelo, descripcion, materialatrabajar, mododeavanc" & _
        "e, tipoacabado, velocidaddeavance, tipomodelo, precio, estado FROM modelofresa"
        Me.selectModeloFresa.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertModeloFresa.CommandText = "INSERT INTO modelofresa(idmodelo, nombre, grupomodelo, descripcion, materialatrab" & _
        "ajar, mododeavance, tipoacabado, velocidaddeavance, tipomodelo, precio, estado) " & _
        "VALUES (@idmodelo, @nombre, @grupomodelo, @descripcion, @materialatrabajar, @mod" & _
        "odeavance, @tipoacabado, @velocidaddeavance, @tipomodelo, @precio, @estado); SEL" & _
        "ECT idmodelo, nombre, grupomodelo, descripcion, materialatrabajar, mododeavance," & _
        " tipoacabado, velocidaddeavance, tipomodelo, precio, estado FROM modelofresa WHE" & _
        "RE (idmodelo = @idmodelo)"
        Me.insertModeloFresa.Connection = cnn
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupomodelo", System.Data.SqlDbType.VarChar, 50, "grupomodelo"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@materialatrabajar", System.Data.SqlDbType.VarChar, 40, "materialatrabajar"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mododeavance", System.Data.SqlDbType.VarChar, 40, "mododeavance"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoacabado", System.Data.SqlDbType.VarChar, 40, "tipoacabado"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@velocidaddeavance", System.Data.SqlDbType.Float, 8, "velocidaddeavance"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipomodelo", System.Data.SqlDbType.VarChar, 40, "tipomodelo"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        Me.insertModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 15, "estado"))
        '
        'SqlUpdateCommand1
        '
        Me.updateModeloFresa.CommandText = "UPDATE modelofresa SET idmodelo = @idmodelo, nombre = @nombre, grupomodelo = @gru" & _
        "pomodelo, descripcion = @descripcion, materialatrabajar = @materialatrabajar, mo" & _
        "dodeavance = @mododeavance, tipoacabado = @tipoacabado, velocidaddeavance = @vel" & _
        "ocidaddeavance, tipomodelo = @tipomodelo, precio = @precio, estado = @estado WHE" & _
        "RE (idmodelo = @Original_idmodelo) AND (estado = @Original_estado OR @Original_e" & _
        "stado IS NULL AND estado IS NULL) AND (grupomodelo = @Original_grupomodelo OR @O" & _
        "riginal_grupomodelo IS NULL AND grupomodelo IS NULL) AND (materialatrabajar = @O" & _
        "riginal_materialatrabajar OR @Original_materialatrabajar IS NULL AND materialatr" & _
        "abajar IS NULL) AND (mododeavance = @Original_mododeavance OR @Original_mododeav" & _
        "ance IS NULL AND mododeavance IS NULL) AND (nombre = @Original_nombre OR @Origin" & _
        "al_nombre IS NULL AND nombre IS NULL) AND (precio = @Original_precio OR @Origina" & _
        "l_precio IS NULL AND precio IS NULL) AND (tipoacabado = @Original_tipoacabado OR" & _
        " @Original_tipoacabado IS NULL AND tipoacabado IS NULL) AND (tipomodelo = @Origi" & _
        "nal_tipomodelo OR @Original_tipomodelo IS NULL AND tipomodelo IS NULL) AND (velo" & _
        "cidaddeavance = @Original_velocidaddeavance OR @Original_velocidaddeavance IS NU" & _
        "LL AND velocidaddeavance IS NULL); SELECT idmodelo, nombre, grupomodelo, descrip" & _
        "cion, materialatrabajar, mododeavance, tipoacabado, velocidaddeavance, tipomodel" & _
        "o, precio, estado FROM modelofresa WHERE (idmodelo = @idmodelo)"
        Me.updateModeloFresa.Connection = cnn
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupomodelo", System.Data.SqlDbType.VarChar, 50, "grupomodelo"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@materialatrabajar", System.Data.SqlDbType.VarChar, 40, "materialatrabajar"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mododeavance", System.Data.SqlDbType.VarChar, 40, "mododeavance"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoacabado", System.Data.SqlDbType.VarChar, 40, "tipoacabado"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@velocidaddeavance", System.Data.SqlDbType.Float, 8, "velocidaddeavance"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipomodelo", System.Data.SqlDbType.VarChar, 40, "tipomodelo"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 15, "estado"))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_grupomodelo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupomodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_materialatrabajar", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materialatrabajar", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mododeavance", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mododeavance", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoacabado", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoacabado", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipomodelo", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipomodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_velocidaddeavance", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "velocidaddeavance", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteModeloFresa.CommandText = "DELETE FROM modelofresa WHERE (idmodelo = @Original_idmodelo) AND (estado = @Orig" & _
        "inal_estado OR @Original_estado IS NULL AND estado IS NULL) AND (grupomodelo = @" & _
        "Original_grupomodelo OR @Original_grupomodelo IS NULL AND grupomodelo IS NULL) A" & _
        "ND (materialatrabajar = @Original_materialatrabajar OR @Original_materialatrabaj" & _
        "ar IS NULL AND materialatrabajar IS NULL) AND (mododeavance = @Original_mododeav" & _
        "ance OR @Original_mododeavance IS NULL AND mododeavance IS NULL) AND (nombre = @" & _
        "Original_nombre OR @Original_nombre IS NULL AND nombre IS NULL) AND (precio = @O" & _
        "riginal_precio OR @Original_precio IS NULL AND precio IS NULL) AND (tipoacabado " & _
        "= @Original_tipoacabado OR @Original_tipoacabado IS NULL AND tipoacabado IS NULL" & _
        ") AND (tipomodelo = @Original_tipomodelo OR @Original_tipomodelo IS NULL AND tip" & _
        "omodelo IS NULL) AND (velocidaddeavance = @Original_velocidaddeavance OR @Origin" & _
        "al_velocidaddeavance IS NULL AND velocidaddeavance IS NULL)"
        Me.deleteModeloFresa.Connection = cnn
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_grupomodelo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupomodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_materialatrabajar", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materialatrabajar", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mododeavance", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mododeavance", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoacabado", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoacabado", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipomodelo", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipomodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteModeloFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_velocidaddeavance", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "velocidaddeavance", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub



    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorModeloFresa.Update(ds, tabla)
    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorModeloFresa.Fill(ds, tabla)
    End Sub


    Public Sub setearGrilla(ByVal datagridMF As DataGrid)
        ts = New DataGridTableStyle

        ts.MappingName = "modelofresa"
        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarMF", 100, HorizontalAlignment.Center, False, "Seleccionar Modelo", "", False, True, False, Nothing)

        ts.GridColumnStyles.Add(c0)

        Dim c1 As New grdstyle.CGridTextBoxStyle("idmodelo", 50, HorizontalAlignment.Center, True, "ID", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("nombre", 100, HorizontalAlignment.Center, True, "Nombre", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("tipomodelo", 200, HorizontalAlignment.Center, True, "Tipo modelo", "", "")
        ts.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("grupomodelo", 200, HorizontalAlignment.Center, True, "Grupo modelo", "", "")
        ts.GridColumnStyles.Add(c4)

        Dim c5 As New grdstyle.CGridTextBoxStyle("materialatrabajar", 100, HorizontalAlignment.Center, True, "Mat. a trabajar", "", "")
        ts.GridColumnStyles.Add(c5)

        Dim c6 As New grdstyle.CGridTextBoxStyle("mododeavance", 100, HorizontalAlignment.Center, True, "Mod. de avance", "", "")
        ts.GridColumnStyles.Add(c6)

        Dim c7 As New grdstyle.CGridTextBoxStyle("tipoacabado", 100, HorizontalAlignment.Center, True, "Tipo acabado", "", "")
        ts.GridColumnStyles.Add(c7)

        Dim c8 As New grdstyle.CGridTextBoxStyle("velocidaddeavance", 75, HorizontalAlignment.Center, True, "Vel.de avance", "", "")
        ts.GridColumnStyles.Add(c8)

        Dim c9 As New grdstyle.CGridTextBoxStyle("precio", 75, HorizontalAlignment.Center, True, "Precio", "", "")
        ts.GridColumnStyles.Add(c9)

        datagridMF.TableStyles.Add(ts)
    End Sub


    Public Sub agregarCheck(ByVal ds As DataSet)
        ds.Tables("modelofresa").Columns.Add("seleccionarMF", Type.GetType("System.Boolean"))
    End Sub

    Public Sub cambiarEstado(ByVal id As Integer, ByVal nuevoEstado As String)
        updateEstado.Connection = cnn
        updateEstado.Connection.Open()
        updateEstado.CommandText = "UPDATE modelofresa " & _
                                   "SET estado = '" + nuevoEstado + "' " & _
                                   "WHERE idmodelo = " + id.ToString

        updateEstado.CommandType = CommandType.Text
        Dim numFilasAfectadas As Integer
        numFilasAfectadas = updateEstado.ExecuteNonQuery

        updateEstado.Connection.Close()

    End Sub

End Class
