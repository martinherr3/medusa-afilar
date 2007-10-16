Public Class detallePresupuesto
    Private insertDP As New SqlClient.SqlCommand
    Private deleteDP As New SqlClient.SqlCommand
    Private selectDP As New SqlClient.SqlCommand
    Private updateDP As New SqlClient.SqlCommand
    Private adaptadorDP As New SqlClient.SqlDataAdapter



    Public Sub cargarAdaptador()
        '
        'adaptadorDP
        '
        Me.adaptadorDP.DeleteCommand = Me.deleteDP
        Me.adaptadorDP.InsertCommand = Me.insertDP
        Me.adaptadorDP.SelectCommand = Me.selectDP
        Me.adaptadorDP.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detallepresupuesto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("iddetpre", "iddetpre"), New System.Data.Common.DataColumnMapping("idpresupuesto", "idpresupuesto"), New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("idproducto", "idproducto"), New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("precio", "precio")})})
        Me.adaptadorDP.UpdateCommand = Me.updateDP
        '
        'SqlSelectCommand3
        '
        'Me.selectDP.CommandText = "SELECT iddetpre, idpresupuesto, idmodelo, idproducto, tipo, cantidad, precio FROM" & _
        '" detallepresupuesto"
        Me.selectDP.CommandText = "SELECT dp.iddetpre, dp.idpresupuesto, dp.idmodelo, mf.nombre AS 'nombreModelo', " & _
                                  "dp.idproducto, dp.tipo, (case when dp.tipo = '1' then tf.nombre else pa.nombre end) AS 'nombreProducto', dp.cantidad, dp.precio, " & _
                                  "(case when dp.tipo = '1' then 'Tipo Fresa' else 'Parte Adicional' end) As 'tipoProducto'" & _
                                  "FROM detallepresupuesto dp " & _
                                  "INNER JOIN modelofresa mf ON mf.idmodelo = dp.idmodelo " & _
                                  "INNER JOIN tipofresa tf ON tf.idtipo = dp.idproducto " & _
                                  "AND tf.idmodelo = dp.idmodelo " & _
                                  "INNER JOIN parteadicional pa ON pa.idadicional = dp.idproducto " & _
                                  "AND pa.idmodelo = dp.idmodelo"
        Me.selectDP.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertDP.CommandText = "INSERT INTO detallepresupuesto(iddetpre, idpresupuesto, idmodelo, idproducto, tip" & _
        "o, cantidad, precio) VALUES (@iddetpre, @idpresupuesto, @idmodelo, @idproducto, " & _
        "@tipo, @cantidad, @precio); SELECT iddetpre, idpresupuesto, idmodelo, idproducto" & _
        ", tipo, cantidad, precio FROM detallepresupuesto WHERE (iddetpre = @iddetpre) AN" & _
        "D (idpresupuesto = @idpresupuesto)"
        Me.insertDP.Connection = cnn
        Me.insertDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@iddetpre", System.Data.SqlDbType.Int, 4, "iddetpre"))
        Me.insertDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idpresupuesto", System.Data.SqlDbType.Int, 4, "idpresupuesto"))
        Me.insertDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.insertDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idproducto", System.Data.SqlDbType.Int, 4, "idproducto"))
        Me.insertDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.Int, 4, "tipo"))
        Me.insertDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Int, 4, "cantidad"))
        Me.insertDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        '
        'SqlUpdateCommand1
        '
        Me.updateDP.CommandText = "UPDATE detallepresupuesto SET iddetpre = @iddetpre, idpresupuesto = @idpresupuest" & _
        "o, idmodelo = @idmodelo, idproducto = @idproducto, tipo = @tipo, cantidad = @can" & _
        "tidad, precio = @precio WHERE (iddetpre = @Original_iddetpre) AND (idpresupuesto" & _
        " = @Original_idpresupuesto) AND (cantidad = @Original_cantidad OR @Original_cant" & _
        "idad IS NULL AND cantidad IS NULL) AND (idmodelo = @Original_idmodelo OR @Origin" & _
        "al_idmodelo IS NULL AND idmodelo IS NULL) AND (idproducto = @Original_idproducto" & _
        " OR @Original_idproducto IS NULL AND idproducto IS NULL) AND (precio = @Original" & _
        "_precio OR @Original_precio IS NULL AND precio IS NULL) AND (tipo = @Original_ti" & _
        "po OR @Original_tipo IS NULL AND tipo IS NULL); SELECT iddetpre, idpresupuesto, " & _
        "idmodelo, idproducto, tipo, cantidad, precio FROM detallepresupuesto WHERE (idde" & _
        "tpre = @iddetpre) AND (idpresupuesto = @idpresupuesto)"
        Me.updateDP.Connection = cnn
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@iddetpre", System.Data.SqlDbType.Int, 4, "iddetpre"))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idpresupuesto", System.Data.SqlDbType.Int, 4, "idpresupuesto"))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idproducto", System.Data.SqlDbType.Int, 4, "idproducto"))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.Int, 4, "tipo"))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Int, 4, "cantidad"))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_iddetpre", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "iddetpre", System.Data.DataRowVersion.Original, Nothing))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idpresupuesto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idpresupuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idproducto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idproducto", System.Data.DataRowVersion.Original, Nothing))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        Me.updateDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteDP.CommandText = "DELETE FROM detallepresupuesto WHERE (iddetpre = @Original_iddetpre) AND (idpresu" & _
        "puesto = @Original_idpresupuesto) AND (cantidad = @Original_cantidad OR @Origina" & _
        "l_cantidad IS NULL AND cantidad IS NULL) AND (idmodelo = @Original_idmodelo OR @" & _
        "Original_idmodelo IS NULL AND idmodelo IS NULL) AND (idproducto = @Original_idpr" & _
        "oducto OR @Original_idproducto IS NULL AND idproducto IS NULL) AND (precio = @Or" & _
        "iginal_precio OR @Original_precio IS NULL AND precio IS NULL) AND (tipo = @Origi" & _
        "nal_tipo OR @Original_tipo IS NULL AND tipo IS NULL)"
        Me.deleteDP.Connection = cnn
        Me.deleteDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_iddetpre", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "iddetpre", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idpresupuesto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idpresupuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idproducto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idproducto", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteDP.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo", System.Data.DataRowVersion.Original, Nothing))

    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorDP.Fill(ds, tabla)
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        adaptadorDP.Update(ds, tabla)
    End Sub



End Class
