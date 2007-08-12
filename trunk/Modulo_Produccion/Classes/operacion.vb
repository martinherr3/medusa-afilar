Public Class Operacion
    Private insertOperacion As New SqlClient.SqlCommand
    Private deleteOperacion As New SqlClient.SqlCommand
    Private selectOperacion As New SqlClient.SqlCommand
    Private updateOperacion As New SqlClient.SqlCommand
    Private madaptadorOperacion As New SqlClient.SqlDataAdapter
    Private resultado As SqlClient.SqlDataReader

    Property adaptadorOperacion() As SqlClient.SqlDataAdapter
        Get
            Return madaptadorOperacion
        End Get
        Set
            madaptadorOperacion = value
        End Set
    End Property

    Public Sub cargarAdaptador()
        '
        'adaptadorOperacion
        '
        Me.adaptadorOperacion.DeleteCommand = Me.deleteOperacion
        Me.adaptadorOperacion.InsertCommand = Me.insertOperacion
        Me.adaptadorOperacion.SelectCommand = Me.selectOperacion
        Me.adaptadorOperacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "operacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idoperacion", "idoperacion"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("maquina", "maquina"), New System.Data.Common.DataColumnMapping("duracionpromedio", "duracionpromedio"), New System.Data.Common.DataColumnMapping("idgradodificultad", "idgradodificultad"), New System.Data.Common.DataColumnMapping("tolerancia", "tolerancia"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.adaptadorOperacion.UpdateCommand = Me.updateOperacion
        '
        'SqlSelectCommand1
        '
        Me.selectOperacion.CommandText = "SELECT idoperacion, nombre, maquina, duracionpromedio, idgradodificultad, toleran" & _
        "cia, descripcion FROM operacion"
        Me.selectOperacion.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertOperacion.CommandText = "INSERT INTO operacion(idoperacion, nombre, maquina, duracionpromedio, idgradodifi" & _
        "cultad, tolerancia, descripcion) VALUES (@idoperacion, @nombre, @maquina, @durac" & _
        "ionpromedio, @idgradodificultad, @tolerancia, @descripcion); SELECT idoperacion," & _
        " nombre, maquina, duracionpromedio, idgradodificultad, tolerancia, descripcion F" & _
        "ROM operacion WHERE (idoperacion = @idoperacion)"
        Me.insertOperacion.Connection = cnn
        Me.insertOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idoperacion", System.Data.SqlDbType.Int, 4, "idoperacion"))
        Me.insertOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.insertOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@maquina", System.Data.SqlDbType.VarChar, 40, "maquina"))
        Me.insertOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@duracionpromedio", System.Data.SqlDbType.Float, 8, "duracionpromedio"))
        Me.insertOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idgradodificultad", System.Data.SqlDbType.Int, 4, "idgradodificultad"))
        Me.insertOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tolerancia", System.Data.SqlDbType.Float, 8, "tolerancia"))
        Me.insertOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        '
        'SqlUpdateCommand1
        '
        Me.updateOperacion.CommandText = "UPDATE operacion SET idoperacion = @idoperacion, nombre = @nombre, maquina = @maq" & _
        "uina, duracionpromedio = @duracionpromedio, idgradodificultad = @idgradodificult" & _
        "ad, tolerancia = @tolerancia, descripcion = @descripcion WHERE (idoperacion = @O" & _
        "riginal_idoperacion) AND (duracionpromedio = @Original_duracionpromedio OR @Orig" & _
        "inal_duracionpromedio IS NULL AND duracionpromedio IS NULL) AND (idgradodificult" & _
        "ad = @Original_idgradodificultad OR @Original_idgradodificultad IS NULL AND idgr" & _
        "adodificultad IS NULL) AND (maquina = @Original_maquina OR @Original_maquina IS " & _
        "NULL AND maquina IS NULL) AND (nombre = @Original_nombre OR @Original_nombre IS " & _
        "NULL AND nombre IS NULL) AND (tolerancia = @Original_tolerancia OR @Original_tol" & _
        "erancia IS NULL AND tolerancia IS NULL); SELECT idoperacion, nombre, maquina, du" & _
        "racionpromedio, idgradodificultad, tolerancia, descripcion FROM operacion WHERE " & _
        "(idoperacion = @idoperacion)"
        Me.updateOperacion.Connection = cnn
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idoperacion", System.Data.SqlDbType.Int, 4, "idoperacion"))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@maquina", System.Data.SqlDbType.VarChar, 40, "maquina"))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@duracionpromedio", System.Data.SqlDbType.Float, 8, "duracionpromedio"))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idgradodificultad", System.Data.SqlDbType.Int, 4, "idgradodificultad"))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tolerancia", System.Data.SqlDbType.Float, 8, "tolerancia"))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idoperacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idoperacion", System.Data.DataRowVersion.Original, Nothing))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_duracionpromedio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "duracionpromedio", System.Data.DataRowVersion.Original, Nothing))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idgradodificultad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idgradodificultad", System.Data.DataRowVersion.Original, Nothing))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_maquina", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maquina", System.Data.DataRowVersion.Original, Nothing))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.updateOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tolerancia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tolerancia", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteOperacion.CommandText = "DELETE FROM operacion WHERE (idoperacion = @Original_idoperacion) AND (duracionpr" & _
        "omedio = @Original_duracionpromedio OR @Original_duracionpromedio IS NULL AND du" & _
        "racionpromedio IS NULL) AND (idgradodificultad = @Original_idgradodificultad OR " & _
        "@Original_idgradodificultad IS NULL AND idgradodificultad IS NULL) AND (maquina " & _
        "= @Original_maquina OR @Original_maquina IS NULL AND maquina IS NULL) AND (nombr" & _
        "e = @Original_nombre OR @Original_nombre IS NULL AND nombre IS NULL) AND (tolera" & _
        "ncia = @Original_tolerancia OR @Original_tolerancia IS NULL AND tolerancia IS NU" & _
        "LL)"
        Me.deleteOperacion.Connection = cnn
        Me.deleteOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idoperacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idoperacion", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_duracionpromedio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "duracionpromedio", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idgradodificultad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idgradodificultad", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_maquina", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maquina", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteOperacion.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tolerancia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tolerancia", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorOperacion.Update(ds, tabla)
    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorOperacion.Fill(ds, tabla)
    End Sub

    Public Function obtenerTiempoOperacion(ByVal idOperacion As Integer) As Double

        selectOperacion.Connection = cnn
        selectOperacion.Connection.Open()
        selectOperacion.CommandText = "SELECT op.idoperacion, op.duracionpromedio " & _
                                      "FROM operacion op " & _
                                      "WHERE op.idoperacion = " + idOperacion.ToString

        selectOperacion.CommandType = CommandType.Text
        resultado = selectOperacion.ExecuteReader
        Dim tiempo As Double
        While resultado.Read
            tiempo = resultado.Item(1)
        End While

        selectOperacion.Connection.Close()

        Return tiempo

    End Function
End Class
