Public Class GradoDificultad
    Private selectGradoDificultad As New SqlClient.SqlCommand
    Private insertGradoDificultad As New SqlClient.SqlCommand
    Private updateGradoDificultad As New SqlClient.SqlCommand
    Private deleteGradoDificultad As New SqlClient.SqlCommand
    Private adaptadorGradoDificultad As New SqlClient.SqlDataAdapter


    Public Sub cargarAdaptador()
        '
        'adaptadorGradoDificultad
        '
        Me.adaptadorGradoDificultad.DeleteCommand = Me.deleteGradoDificultad
        Me.adaptadorGradoDificultad.InsertCommand = Me.insertGradoDificultad
        Me.adaptadorGradoDificultad.SelectCommand = Me.selectGradoDificultad
        Me.adaptadorGradoDificultad.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "gradodificultad", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idgradodificultad", "idgradodificultad"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.adaptadorGradoDificultad.UpdateCommand = Me.updateGradoDificultad
        '
        'SqlSelectCommand1
        '
        Me.selectGradoDificultad.CommandText = "SELECT idgradodificultad, nombre, descripcion FROM gradodificultad"
        Me.selectGradoDificultad.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertGradoDificultad.CommandText = "INSERT INTO gradodificultad(idgradodificultad, nombre, descripcion) VALUES (@idgr" & _
        "adodificultad, @nombre, @descripcion); SELECT idgradodificultad, nombre, descrip" & _
        "cion FROM gradodificultad WHERE (idgradodificultad = @idgradodificultad)"
        Me.insertGradoDificultad.Connection = cnn
        Me.insertGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idgradodificultad", System.Data.SqlDbType.Int, 4, "idgradodificultad"))
        Me.insertGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"))
        Me.insertGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        '
        'SqlUpdateCommand1
        '
        Me.updateGradoDificultad.CommandText = "UPDATE gradodificultad SET idgradodificultad = @idgradodificultad, nombre = @nomb" & _
        "re, descripcion = @descripcion WHERE (idgradodificultad = @Original_idgradodific" & _
        "ultad) AND (nombre = @Original_nombre OR @Original_nombre IS NULL AND nombre IS " & _
        "NULL); SELECT idgradodificultad, nombre, descripcion FROM gradodificultad WHERE " & _
        "(idgradodificultad = @idgradodificultad)"
        Me.updateGradoDificultad.Connection = cnn
        Me.updateGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idgradodificultad", System.Data.SqlDbType.Int, 4, "idgradodificultad"))
        Me.updateGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"))
        Me.updateGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.updateGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idgradodificultad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idgradodificultad", System.Data.DataRowVersion.Original, Nothing))
        Me.updateGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteGradoDificultad.CommandText = "DELETE FROM gradodificultad WHERE (idgradodificultad = @Original_idgradodificulta" & _
        "d) AND (nombre = @Original_nombre OR @Original_nombre IS NULL AND nombre IS NULL" & _
        ")"
        Me.deleteGradoDificultad.Connection = cnn
        Me.deleteGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idgradodificultad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idgradodificultad", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteGradoDificultad.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorGradoDificultad.Fill(ds, tabla)
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorGradoDificultad.Update(ds, tabla)
    End Sub

End Class
