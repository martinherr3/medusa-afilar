Public Class presupuesto
    Private selectPresupuesto As New SqlClient.SqlCommand
    Private deletePresupuesto As New SqlClient.SqlCommand
    Private insertPresupuesto As New SqlClient.SqlCommand
    Private updatePresupuesto As New SqlClient.SqlCommand
    Private adaptadorPresupuesto As New SqlClient.SqlDataAdapter

    Public Sub cargarAdaptador()
        '
        'adaptadorPresupuesto
        '
        Me.adaptadorPresupuesto.DeleteCommand = Me.deletePresupuesto
        Me.adaptadorPresupuesto.InsertCommand = Me.insertPresupuesto
        Me.adaptadorPresupuesto.SelectCommand = Me.selectPresupuesto
        Me.adaptadorPresupuesto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "presupuesto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idpresupuesto", "idpresupuesto"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("idcliente", "idcliente"), New System.Data.Common.DataColumnMapping("idempleado", "idempleado")})})
        Me.adaptadorPresupuesto.UpdateCommand = Me.updatePresupuesto
        '
        'SqlSelectCommand1
        '
        'Me.selectPresupuesto.CommandText = "SELECT idpresupuesto, fecha, idcliente, idempleado FROM presupuesto"
        Me.selectPresupuesto.CommandText = "SELECT p.idpresupuesto, p.fecha, p.idcliente, p.idempleado, " & _
                                           "rtrim(c.apellido) + ', ' + c.nombre AS 'nombreCliente', " & _
                                           "rtrim(e.apellido) + ', ' + e.nombre AS 'nombreEmpleado' " & _
                                           "FROM presupuesto p " & _
                                           "INNER JOIN cliente c ON c.idcliente = p.idcliente " & _
                                           "INNER JOIN empleado e ON e.idlegajo = p.idempleado"

        Me.selectPresupuesto.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertPresupuesto.CommandText = "INSERT INTO presupuesto(idpresupuesto, fecha, idcliente, idempleado) VALUES (@idp" & _
        "resupuesto, @fecha, @idcliente, @idempleado); SELECT idpresupuesto, fecha, idcli" & _
        "ente, idempleado FROM presupuesto WHERE (idpresupuesto = @idpresupuesto)"
        Me.insertPresupuesto.Connection = cnn
        Me.insertPresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idpresupuesto", System.Data.SqlDbType.Int, 4, "idpresupuesto"))
        Me.insertPresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"))
        Me.insertPresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idcliente", System.Data.SqlDbType.Int, 4, "idcliente"))
        Me.insertPresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idempleado", System.Data.SqlDbType.Int, 4, "idempleado"))
        '
        'SqlUpdateCommand1
        '
        Me.updatePresupuesto.CommandText = "UPDATE presupuesto SET idpresupuesto = @idpresupuesto, fecha = @fecha, idcliente " & _
        "= @idcliente, idempleado = @idempleado WHERE (idpresupuesto = @Original_idpresup" & _
        "uesto) AND (fecha = @Original_fecha OR @Original_fecha IS NULL AND fecha IS NULL" & _
        ") AND (idcliente = @Original_idcliente OR @Original_idcliente IS NULL AND idclie" & _
        "nte IS NULL) AND (idempleado = @Original_idempleado OR @Original_idempleado IS N" & _
        "ULL AND idempleado IS NULL); SELECT idpresupuesto, fecha, idcliente, idempleado " & _
        "FROM presupuesto WHERE (idpresupuesto = @idpresupuesto)"
        Me.updatePresupuesto.Connection = cnn
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idpresupuesto", System.Data.SqlDbType.Int, 4, "idpresupuesto"))
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"))
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idcliente", System.Data.SqlDbType.Int, 4, "idcliente"))
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idempleado", System.Data.SqlDbType.Int, 4, "idempleado"))
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idpresupuesto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idpresupuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idcliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idcliente", System.Data.DataRowVersion.Original, Nothing))
        Me.updatePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idempleado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idempleado", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deletePresupuesto.CommandText = "DELETE FROM presupuesto WHERE (idpresupuesto = @Original_idpresupuesto) AND (fech" & _
        "a = @Original_fecha OR @Original_fecha IS NULL AND fecha IS NULL) AND (idcliente" & _
        " = @Original_idcliente OR @Original_idcliente IS NULL AND idcliente IS NULL) AND" & _
        " (idempleado = @Original_idempleado OR @Original_idempleado IS NULL AND idemplea" & _
        "do IS NULL)"
        Me.deletePresupuesto.Connection = cnn
        Me.deletePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idpresupuesto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idpresupuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.deletePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.deletePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idcliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idcliente", System.Data.DataRowVersion.Original, Nothing))
        Me.deletePresupuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idempleado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idempleado", System.Data.DataRowVersion.Original, Nothing))

    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorPresupuesto.Fill(ds, tabla)
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorPresupuesto.Update(ds, tabla)
    End Sub


    Public Function selectPorFecha(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataSet
        Dim consulta As String = "SELECT p.idpresupuesto, p.fecha, " & _
                                 "rtrim(c.apellido) + ', ' + c.nombre AS 'nombreCliente', " & _
                                 "rtrim(e.apellido) + ', ' + e.nombre AS 'nombreEmpleado' " & _
                                 "FROM presupuesto p " & _
                                 "INNER JOIN cliente c ON c.idcliente = p.idcliente " & _
                                 "INNER JOIN empleado e ON e.idlegajo = p.idempleado " & _
                                 "WHERE p.fecha >= '" + fechaDesde.Date + "' " & _
                                 "AND p.fecha <= '" + fechaHasta.Date + "'"

        Me.selectPresupuesto.CommandText = consulta
        Dim ds As New DataSet

        adaptadorPresupuesto.Fill(ds, "presupuesto")

        Return ds

    End Function


    Public Function selectTodo() As DataSet
        Dim consulta As String = "SELECT p.idpresupuesto, p.fecha, " & _
                                 "rtrim(c.apellido) + ', ' + c.nombre AS 'nombreCliente', " & _
                                 "rtrim(e.apellido) + ', ' + e.nombre AS 'nombreEmpleado' " & _
                                 "FROM presupuesto p " & _
                                 "INNER JOIN cliente c ON c.idcliente = p.idcliente " & _
                                 "INNER JOIN empleado e ON e.idlegajo = p.idempleado"

        Me.selectPresupuesto.CommandText = consulta
        Dim ds As New DataSet

        adaptadorPresupuesto.Fill(ds, "presupuesto")

        Return ds

    End Function
End Class
