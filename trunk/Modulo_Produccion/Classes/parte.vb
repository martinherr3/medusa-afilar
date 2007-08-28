Public Class parte

    Private madaptadorParte As New SqlClient.SqlDataAdapter
    Private selectParte As New SqlClient.SqlCommand
    Private insertParte As New SqlClient.SqlCommand
    Private updateParte As New SqlClient.SqlCommand
    Private deleteParte As New SqlClient.SqlCommand


    Property adaptadorParte() As SqlClient.SqlDataAdapter
        Get
            Return madaptadorParte
        End Get

        Set(ByVal Value As SqlClient.SqlDataAdapter)
            madaptadorParte = Value
        End Set
    End Property


    Public Sub cargarAdaptador()
        '
        'adaptadorParte
        '
        Me.adaptadorParte.DeleteCommand = Me.deleteParte
        Me.adaptadorParte.InsertCommand = Me.insertParte
        Me.adaptadorParte.SelectCommand = Me.selectParte
        Me.adaptadorParte.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "parte", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("idtipofresa", "idtipofresa"), New System.Data.Common.DataColumnMapping("idparte", "idparte"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("idtipomateriaprima", "idtipomateriaprima")})})
        Me.adaptadorParte.UpdateCommand = Me.updateParte
        '
        'SqlSelectCommand1
        '
        Me.selectParte.CommandText = "SELECT idmodelo, idtipofresa, idparte, cantidad, nombre, descripcion, idtipomater" & _
        "iaprima FROM parte"
        Me.selectParte.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertParte.CommandText = "INSERT INTO parte(idmodelo, idtipofresa, idparte, cantidad, nombre, descripcion, " & _
        "idtipomateriaprima) VALUES (@idmodelo, @idtipofresa, @idparte, @cantidad, @nombr" & _
        "e, @descripcion, @idtipomateriaprima); SELECT idmodelo, idtipofresa, idparte, ca" & _
        "ntidad, nombre, descripcion, idtipomateriaprima FROM parte WHERE (idmodelo = @id" & _
        "modelo) AND (idparte = @idparte) AND (idtipofresa = @idtipofresa)"
        Me.insertParte.Connection = cnn
        Me.insertParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.insertParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipofresa", System.Data.SqlDbType.Int, 4, "idtipofresa"))
        Me.insertParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idparte", System.Data.SqlDbType.Int, 4, "idparte"))
        Me.insertParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Int, 4, "cantidad"))
        Me.insertParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.insertParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.insertParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipomateriaprima", System.Data.SqlDbType.Int, 4, "idtipomateriaprima"))
        '
        'SqlUpdateCommand1
        '
        Me.updateParte.CommandText = "UPDATE parte SET idmodelo = @idmodelo, idtipofresa = @idtipofresa, idparte = @idp" & _
        "arte, cantidad = @cantidad, nombre = @nombre, descripcion = @descripcion, idtipo" & _
        "materiaprima = @idtipomateriaprima WHERE (idmodelo = @Original_idmodelo) AND (id" & _
        "parte = @Original_idparte) AND (idtipofresa = @Original_idtipofresa) AND (cantid" & _
        "ad = @Original_cantidad OR @Original_cantidad IS NULL AND cantidad IS NULL) AND " & _
        "(idtipomateriaprima = @Original_idtipomateriaprima OR @Original_idtipomateriapri" & _
        "ma IS NULL AND idtipomateriaprima IS NULL) AND (nombre = @Original_nombre OR @Or" & _
        "iginal_nombre IS NULL AND nombre IS NULL); SELECT idmodelo, idtipofresa, idparte" & _
        ", cantidad, nombre, descripcion, idtipomateriaprima FROM parte WHERE (idmodelo =" & _
        " @idmodelo) AND (idparte = @idparte) AND (idtipofresa = @idtipofresa)"
        Me.updateParte.Connection = cnn
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipofresa", System.Data.SqlDbType.Int, 4, "idtipofresa"))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idparte", System.Data.SqlDbType.Int, 4, "idparte"))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Int, 4, "cantidad"))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipomateriaprima", System.Data.SqlDbType.Int, 4, "idtipomateriaprima"))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idparte", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idparte", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipofresa", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipofresa", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipomateriaprima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipomateriaprima", System.Data.DataRowVersion.Original, Nothing))
        Me.updateParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteParte.CommandText = "DELETE FROM parte WHERE (idmodelo = @Original_idmodelo) AND (idparte = @Original_" & _
        "idparte) AND (idtipofresa = @Original_idtipofresa) AND (cantidad = @Original_can" & _
        "tidad OR @Original_cantidad IS NULL AND cantidad IS NULL) AND (idtipomateriaprim" & _
        "a = @Original_idtipomateriaprima OR @Original_idtipomateriaprima IS NULL AND idt" & _
        "ipomateriaprima IS NULL) AND (nombre = @Original_nombre OR @Original_nombre IS N" & _
        "ULL AND nombre IS NULL)"
        Me.deleteParte.Connection = cnn
        Me.deleteParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idparte", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idparte", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipofresa", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipofresa", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipomateriaprima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipomateriaprima", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteParte.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorParte.Update(ds, tabla)
    End Sub

    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorParte.Fill(ds, tabla)
    End Sub
End Class
