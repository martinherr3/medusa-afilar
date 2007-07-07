Public Class etapaFabricacion
    Dim madaptadorEtapa As New SqlClient.SqlDataAdapter
    Dim selectEtapa As New SqlClient.SqlCommand
    Dim insertEtapa As New SqlClient.SqlCommand
    Dim deleteEtapa As New SqlClient.SqlCommand
    Dim updateEtapa As New SqlClient.SqlCommand


    Property adaptadorEtapa()
        Get
            Return madaptadorEtapa
        End Get

        Set(ByVal Value)
            madaptadorEtapa = Value
        End Set
    End Property


    Public Sub cargarAdaptador()
        '
        'adaptadorEtapa
        '
        Me.madaptadorEtapa.DeleteCommand = Me.deleteEtapa
        Me.madaptadorEtapa.InsertCommand = Me.insertEtapa
        Me.madaptadorEtapa.SelectCommand = Me.selectEtapa
        Me.madaptadorEtapa.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "etapadefabricacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idetapafabricacion", "idetapafabricacion"), New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("idtipofresa", "idtipofresa"), New System.Data.Common.DataColumnMapping("idoperacion", "idoperacion"), New System.Data.Common.DataColumnMapping("orden", "orden"), New System.Data.Common.DataColumnMapping("tiempoadicional", "tiempoadicional"), New System.Data.Common.DataColumnMapping("detalle", "detalle")})})
        Me.madaptadorEtapa.UpdateCommand = Me.updateEtapa
        '
        'SqlSelectCommand1
        '
        Me.selectEtapa.CommandText = "SELECT idetapafabricacion, idmodelo, idtipofresa, idoperacion, orden, tiempoadici" & _
        "onal, detalle FROM etapadefabricacion"
        Me.selectEtapa.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertEtapa.CommandText = "INSERT INTO etapadefabricacion(idetapafabricacion, idmodelo, idtipofresa, idopera" & _
        "cion, orden, tiempoadicional, detalle) VALUES (@idetapafabricacion, @idmodelo, @" & _
        "idtipofresa, @idoperacion, @orden, @tiempoadicional, @detalle); SELECT idetapafa" & _
        "bricacion, idmodelo, idtipofresa, idoperacion, orden, tiempoadicional, detalle F" & _
        "ROM etapadefabricacion WHERE (idetapafabricacion = @idetapafabricacion) AND (idm" & _
        "odelo = @idmodelo) AND (idtipofresa = @idtipofresa)"
        Me.insertEtapa.Connection = cnn
        Me.insertEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idetapafabricacion", System.Data.SqlDbType.Int, 4, "idetapafabricacion"))
        Me.insertEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.insertEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipofresa", System.Data.SqlDbType.Int, 4, "idtipofresa"))
        Me.insertEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idoperacion", System.Data.SqlDbType.Int, 4, "idoperacion"))
        Me.insertEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@orden", System.Data.SqlDbType.Int, 4, "orden"))
        Me.insertEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tiempoadicional", System.Data.SqlDbType.Float, 8, "tiempoadicional"))
        Me.insertEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@detalle", System.Data.SqlDbType.VarChar, 2147483647, "detalle"))
        '
        'SqlUpdateCommand1
        '
        Me.updateEtapa.CommandText = "UPDATE etapadefabricacion SET idetapafabricacion = @idetapafabricacion, idmodelo " & _
        "= @idmodelo, idtipofresa = @idtipofresa, idoperacion = @idoperacion, orden = @or" & _
        "den, tiempoadicional = @tiempoadicional, detalle = @detalle WHERE (idetapafabric" & _
        "acion = @Original_idetapafabricacion) AND (idmodelo = @Original_idmodelo) AND (i" & _
        "dtipofresa = @Original_idtipofresa) AND (idoperacion = @Original_idoperacion OR " & _
        "@Original_idoperacion IS NULL AND idoperacion IS NULL) AND (orden = @Original_or" & _
        "den OR @Original_orden IS NULL AND orden IS NULL) AND (tiempoadicional = @Origin" & _
        "al_tiempoadicional OR @Original_tiempoadicional IS NULL AND tiempoadicional IS N" & _
        "ULL); SELECT idetapafabricacion, idmodelo, idtipofresa, idoperacion, orden, tiem" & _
        "poadicional, detalle FROM etapadefabricacion WHERE (idetapafabricacion = @idetap" & _
        "afabricacion) AND (idmodelo = @idmodelo) AND (idtipofresa = @idtipofresa)"
        Me.updateEtapa.Connection = cnn
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idetapafabricacion", System.Data.SqlDbType.Int, 4, "idetapafabricacion"))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipofresa", System.Data.SqlDbType.Int, 4, "idtipofresa"))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idoperacion", System.Data.SqlDbType.Int, 4, "idoperacion"))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@orden", System.Data.SqlDbType.Int, 4, "orden"))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tiempoadicional", System.Data.SqlDbType.Float, 8, "tiempoadicional"))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@detalle", System.Data.SqlDbType.VarChar, 2147483647, "detalle"))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idetapafabricacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idetapafabricacion", System.Data.DataRowVersion.Original, Nothing))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipofresa", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipofresa", System.Data.DataRowVersion.Original, Nothing))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idoperacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idoperacion", System.Data.DataRowVersion.Original, Nothing))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_orden", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orden", System.Data.DataRowVersion.Original, Nothing))
        Me.updateEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tiempoadicional", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tiempoadicional", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteEtapa.CommandText = "DELETE FROM etapadefabricacion WHERE (idetapafabricacion = @Original_idetapafabri" & _
        "cacion) AND (idmodelo = @Original_idmodelo) AND (idtipofresa = @Original_idtipof" & _
        "resa) AND (idoperacion = @Original_idoperacion OR @Original_idoperacion IS NULL " & _
        "AND idoperacion IS NULL) AND (orden = @Original_orden OR @Original_orden IS NULL" & _
        " AND orden IS NULL) AND (tiempoadicional = @Original_tiempoadicional OR @Origina" & _
        "l_tiempoadicional IS NULL AND tiempoadicional IS NULL)"
        Me.deleteEtapa.Connection = cnn
        Me.deleteEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idetapafabricacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idetapafabricacion", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipofresa", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipofresa", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idoperacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idoperacion", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_orden", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orden", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteEtapa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tiempoadicional", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tiempoadicional", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorEtapa.Update(ds, tabla)
    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorEtapa.Fill(ds, tabla)
    End Sub
End Class
