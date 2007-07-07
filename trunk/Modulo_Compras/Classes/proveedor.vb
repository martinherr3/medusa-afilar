Public Class proveedor
    Private insertProveedor As New SqlClient.SqlCommand
    Private deleteProveedor As New SqlClient.SqlCommand
    Private updateProveedor As New SqlClient.SqlCommand
    Private selectProveedor As New SqlClient.SqlCommand
    Private adaptadorProveedor As New SqlClient.SqlDataAdapter


    Public Sub cargarAdaptador()
        '
        'adaptadorProveedor
        '
        Me.adaptadorProveedor.DeleteCommand = Me.deleteProveedor
        Me.adaptadorProveedor.InsertCommand = Me.insertProveedor
        Me.adaptadorProveedor.SelectCommand = Me.selectProveedor
        Me.adaptadorProveedor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "proveedor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idproveedor", "idproveedor"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("mail", "mail"), New System.Data.Common.DataColumnMapping("nombrecontacto", "nombrecontacto"), New System.Data.Common.DataColumnMapping("idlocalidad", "idlocalidad")})})
        Me.adaptadorProveedor.UpdateCommand = Me.updateProveedor
        '
        'SqlSelectCommand1
        '
        Me.selectProveedor.CommandText = "SELECT idproveedor, nombre, direccion, telefono, mail, nombrecontacto, idlocalida" & _
        "d FROM proveedor"
        Me.selectProveedor.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertProveedor.CommandText = "INSERT INTO proveedor(idproveedor, nombre, direccion, telefono, mail, nombreconta" & _
        "cto, idlocalidad) VALUES (@idproveedor, @nombre, @direccion, @telefono, @mail, @" & _
        "nombrecontacto, @idlocalidad); SELECT idproveedor, nombre, direccion, telefono, " & _
        "mail, nombrecontacto, idlocalidad FROM proveedor WHERE (idproveedor = @idproveed" & _
        "or)"
        Me.insertProveedor.Connection = cnn
        Me.insertProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idproveedor", System.Data.SqlDbType.Int, 4, "idproveedor"))
        Me.insertProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 80, "nombre"))
        Me.insertProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 80, "direccion"))
        Me.insertProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 20, "telefono"))
        Me.insertProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mail", System.Data.SqlDbType.VarChar, 80, "mail"))
        Me.insertProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombrecontacto", System.Data.SqlDbType.VarChar, 80, "nombrecontacto"))
        Me.insertProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idlocalidad", System.Data.SqlDbType.Int, 4, "idlocalidad"))
        '
        'SqlUpdateCommand1
        '
        Me.updateProveedor.CommandText = "UPDATE proveedor SET idproveedor = @idproveedor, nombre = @nombre, direccion = @d" & _
        "ireccion, telefono = @telefono, mail = @mail, nombrecontacto = @nombrecontacto, " & _
        "idlocalidad = @idlocalidad WHERE (idproveedor = @Original_idproveedor) AND (dire" & _
        "ccion = @Original_direccion OR @Original_direccion IS NULL AND direccion IS NULL" & _
        ") AND (idlocalidad = @Original_idlocalidad OR @Original_idlocalidad IS NULL AND " & _
        "idlocalidad IS NULL) AND (mail = @Original_mail OR @Original_mail IS NULL AND ma" & _
        "il IS NULL) AND (nombre = @Original_nombre OR @Original_nombre IS NULL AND nombr" & _
        "e IS NULL) AND (nombrecontacto = @Original_nombrecontacto OR @Original_nombrecon" & _
        "tacto IS NULL AND nombrecontacto IS NULL) AND (telefono = @Original_telefono OR " & _
        "@Original_telefono IS NULL AND telefono IS NULL); SELECT idproveedor, nombre, di" & _
        "reccion, telefono, mail, nombrecontacto, idlocalidad FROM proveedor WHERE (idpro" & _
        "veedor = @idproveedor)"
        Me.updateProveedor.Connection = cnn
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idproveedor", System.Data.SqlDbType.Int, 4, "idproveedor"))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 80, "nombre"))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 80, "direccion"))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 20, "telefono"))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mail", System.Data.SqlDbType.VarChar, 80, "mail"))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombrecontacto", System.Data.SqlDbType.VarChar, 80, "nombrecontacto"))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idlocalidad", System.Data.SqlDbType.Int, 4, "idlocalidad"))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idproveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idproveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idlocalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idlocalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mail", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mail", System.Data.DataRowVersion.Original, Nothing))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombrecontacto", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombrecontacto", System.Data.DataRowVersion.Original, Nothing))
        Me.updateProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteProveedor.CommandText = "DELETE FROM proveedor WHERE (idproveedor = @Original_idproveedor) AND (direccion " & _
        "= @Original_direccion OR @Original_direccion IS NULL AND direccion IS NULL) AND " & _
        "(idlocalidad = @Original_idlocalidad OR @Original_idlocalidad IS NULL AND idloca" & _
        "lidad IS NULL) AND (mail = @Original_mail OR @Original_mail IS NULL AND mail IS " & _
        "NULL) AND (nombre = @Original_nombre OR @Original_nombre IS NULL AND nombre IS N" & _
        "ULL) AND (nombrecontacto = @Original_nombrecontacto OR @Original_nombrecontacto " & _
        "IS NULL AND nombrecontacto IS NULL) AND (telefono = @Original_telefono OR @Origi" & _
        "nal_telefono IS NULL AND telefono IS NULL)"
        Me.deleteProveedor.Connection = cnn
        Me.deleteProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idproveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idproveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idlocalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idlocalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mail", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mail", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombrecontacto", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombrecontacto", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteProveedor.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorProveedor.Fill(ds, tabla)
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorProveedor.Update(ds, tabla)
    End Sub


End Class
