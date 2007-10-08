Public Class TipoFresa

    Private madaptadorTipoFresa As New SqlClient.SqlDataAdapter
    Private selectTipoFresa As New SqlClient.SqlCommand
    Private insertTipoFresa As New SqlClient.SqlCommand
    Private deleteTipoFresa As New SqlClient.SqlCommand
    Private updateTipoFresa As New SqlClient.SqlCommand
    Private ts As DataGridTableStyle
    'Private cnn As New SqlClient.SqlConnection


    ReadOnly Property adaptadorTipoFresa() As SqlClient.SqlDataAdapter
        Get
            Return madaptadorTipoFresa
        End Get
    End Property


    Public Sub cargarAdaptador()
        '
        'adaptadorTipoFresa
        '
        Me.adaptadorTipoFresa.DeleteCommand = Me.deleteTipoFresa
        Me.adaptadorTipoFresa.InsertCommand = Me.insertTipoFresa
        Me.adaptadorTipoFresa.SelectCommand = Me.selectTipoFresa
        Me.adaptadorTipoFresa.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tipofresa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idtipo", "idtipo"), New System.Data.Common.DataColumnMapping("idmodelo", "idmodelo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("diametroexterior", "diametroexterior"), New System.Data.Common.DataColumnMapping("diametroagujero", "diametroagujero"), New System.Data.Common.DataColumnMapping("cantidaddientes", "cantidaddientes"), New System.Data.Common.DataColumnMapping("plano", "plano"), New System.Data.Common.DataColumnMapping("posiciondetrabajo", "posiciondetrabajo"), New System.Data.Common.DataColumnMapping("caracteristicas", "caracteristicas"), New System.Data.Common.DataColumnMapping("costo", "costo"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("estado", "estado"), New System.Data.Common.DataColumnMapping("imagen", "imagen")})})
        Me.adaptadorTipoFresa.UpdateCommand = Me.updateTipoFresa
        '
        'SqlSelectCommand1
        '
        Me.selectTipoFresa.CommandText = "SELECT idtipo, idmodelo, nombre, diametroexterior, diametroagujero, cantidaddient" & _
        "es, plano, posiciondetrabajo, caracteristicas, costo, precio, estado, imagen FROM tipofr" & _
        "esa"
        Me.selectTipoFresa.Connection = cnn
        '
        'SqlInsertCommand1
        '
        Me.insertTipoFresa.CommandText = "INSERT INTO tipofresa(idtipo, idmodelo, nombre, diametroexterior, diametroagujero" & _
        ", cantidaddientes, plano, posiciondetrabajo, caracteristicas, costo, precio, est" & _
        "ado, imagen) VALUES (@idtipo, @idmodelo, @nombre, @diametroexterior, @diametroagujero, @" & _
        "cantidaddientes, @plano, @posiciondetrabajo, @caracteristicas, @costo, @precio, " & _
        "@estado, @imagen); SELECT idtipo, idmodelo, nombre, diametroexterior, diametroagujero, ca" & _
        "ntidaddientes, plano, posiciondetrabajo, caracteristicas, costo, precio, estado, imagen " & _
        "FROM tipofresa WHERE (idmodelo = @idmodelo) AND (idtipo = @idtipo)"
        Me.insertTipoFresa.Connection = cnn
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipo", System.Data.SqlDbType.Int, 4, "idtipo"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diametroexterior", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroexterior", System.Data.DataRowVersion.Current, Nothing))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diametroagujero", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroagujero", System.Data.DataRowVersion.Current, Nothing))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidaddientes", System.Data.SqlDbType.Int, 4, "cantidaddientes"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plano", System.Data.SqlDbType.VarChar, 80, "plano"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@posiciondetrabajo", System.Data.SqlDbType.VarChar, 40, "posiciondetrabajo"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@caracteristicas", System.Data.SqlDbType.VarChar, 2147483647, "caracteristicas"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Current, Nothing))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Current, Nothing))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 15, "estado"))
        Me.insertTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@imagen", System.Data.SqlDbType.Image, 2147483647, "imagen"))
        '
        'SqlUpdateCommand1
        '
        Me.updateTipoFresa.CommandText = "UPDATE tipofresa SET idtipo = @idtipo, idmodelo = @idmodelo, nombre = @nombre, di" & _
        "ametroexterior = @diametroexterior, diametroagujero = @diametroagujero, cantidad" & _
        "dientes = @cantidaddientes, plano = @plano, posiciondetrabajo = @posiciondetraba" & _
        "jo, caracteristicas = @caracteristicas, costo = @costo, precio = @precio, estado" & _
        " = @estado WHERE (idmodelo = @Original_idmodelo) AND (idtipo = @Original_idtipo)" & _
        " AND (cantidaddientes = @Original_cantidaddientes OR @Original_cantidaddientes I" & _
        "S NULL AND cantidaddientes IS NULL) AND (costo = @Original_costo OR @Original_co" & _
        "sto IS NULL AND costo IS NULL) AND (diametroagujero = @Original_diametroagujero " & _
        "OR @Original_diametroagujero IS NULL AND diametroagujero IS NULL) AND (diametroe" & _
        "xterior = @Original_diametroexterior OR @Original_diametroexterior IS NULL AND d" & _
        "iametroexterior IS NULL) AND (estado = @Original_estado OR @Original_estado IS N" & _
        "ULL AND estado IS NULL) AND (nombre = @Original_nombre OR @Original_nombre IS NU" & _
        "LL AND nombre IS NULL) AND (plano = @Original_plano OR @Original_plano IS NULL A" & _
        "ND plano IS NULL) AND (posiciondetrabajo = @Original_posiciondetrabajo OR @Origi" & _
        "nal_posiciondetrabajo IS NULL AND posiciondetrabajo IS NULL) AND (precio = @Orig" & _
        "inal_precio OR @Original_precio IS NULL AND precio IS NULL); SELECT idtipo, idmo" & _
        "delo, nombre, diametroexterior, diametroagujero, cantidaddientes, plano, posicio" & _
        "ndetrabajo, caracteristicas, costo, precio, estado FROM tipofresa WHERE (idmodel" & _
        "o = @idmodelo) AND (idtipo = @idtipo)"
        Me.updateTipoFresa.Connection = cnn
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idtipo", System.Data.SqlDbType.Int, 4, "idtipo"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idmodelo", System.Data.SqlDbType.Int, 4, "idmodelo"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diametroexterior", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroexterior", System.Data.DataRowVersion.Current, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diametroagujero", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroagujero", System.Data.DataRowVersion.Current, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidaddientes", System.Data.SqlDbType.Int, 4, "cantidaddientes"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plano", System.Data.SqlDbType.VarChar, 80, "plano"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@posiciondetrabajo", System.Data.SqlDbType.VarChar, 40, "posiciondetrabajo"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@caracteristicas", System.Data.SqlDbType.VarChar, 2147483647, "caracteristicas"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Current, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Current, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 15, "estado"))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidaddientes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidaddientes", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_costo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_diametroagujero", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroagujero", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_diametroexterior", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroexterior", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_plano", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "plano", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_posiciondetrabajo", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "posiciondetrabajo", System.Data.DataRowVersion.Original, Nothing))
        Me.updateTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.deleteTipoFresa.CommandText = "DELETE FROM tipofresa WHERE (idmodelo = @Original_idmodelo) AND (idtipo = @Origin" & _
        "al_idtipo) AND (cantidaddientes = @Original_cantidaddientes OR @Original_cantida" & _
        "ddientes IS NULL AND cantidaddientes IS NULL) AND (costo = @Original_costo OR @O" & _
        "riginal_costo IS NULL AND costo IS NULL) AND (diametroagujero = @Original_diamet" & _
        "roagujero OR @Original_diametroagujero IS NULL AND diametroagujero IS NULL) AND " & _
        "(diametroexterior = @Original_diametroexterior OR @Original_diametroexterior IS " & _
        "NULL AND diametroexterior IS NULL) AND (estado = @Original_estado OR @Original_e" & _
        "stado IS NULL AND estado IS NULL) AND (nombre = @Original_nombre OR @Original_no" & _
        "mbre IS NULL AND nombre IS NULL) AND (plano = @Original_plano OR @Original_plano" & _
        " IS NULL AND plano IS NULL) AND (posiciondetrabajo = @Original_posiciondetrabajo" & _
        " OR @Original_posiciondetrabajo IS NULL AND posiciondetrabajo IS NULL) AND (prec" & _
        "io = @Original_precio OR @Original_precio IS NULL AND precio IS NULL)"
        Me.deleteTipoFresa.Connection = cnn
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idmodelo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idmodelo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_idtipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idtipo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidaddientes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidaddientes", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_costo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_diametroagujero", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroagujero", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_diametroexterior", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "diametroexterior", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_plano", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "plano", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_posiciondetrabajo", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "posiciondetrabajo", System.Data.DataRowVersion.Original, Nothing))
        Me.deleteTipoFresa.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnn
        '
        'Me.cnn.ConnectionString = "workstation id=OCTAVO;packet size=4096;integrated security=SSPI;initial catalog=A" & _
        '"filar;persist security info=False"
    End Sub


    Public Sub actualizarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorTipoFresa.Update(ds, tabla)
    End Sub


    Public Sub cargarDatos(ByVal ds As DataSet, ByVal tabla As String)
        madaptadorTipoFresa.Fill(ds, tabla)
    End Sub

    Public Sub setearGrilla(ByVal dg As DataGrid)

        ts = New DataGridTableStyle

        ts.MappingName = "tipofresa"

        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionarTF", 30, HorizontalAlignment.Center, False, "", "", False, True, False, Nothing)
        ts.GridColumnStyles.Add(c0)

        Dim c1 As New grdstyle.CGridTextBoxStyle("idtipo", 50, HorizontalAlignment.Center, True, "ID", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("nombre", 150, HorizontalAlignment.Center, True, "Nombre", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("diametroexterior", 75, HorizontalAlignment.Center, True, "Diam. exterior", "", "")
        ts.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("diametroagujero", 75, HorizontalAlignment.Center, True, "Diam. agujero", "", "")
        ts.GridColumnStyles.Add(c4)

        Dim c5 As New grdstyle.CGridTextBoxStyle("cantidaddientes", 75, HorizontalAlignment.Center, True, "Cant. dientes", "", "")
        ts.GridColumnStyles.Add(c5)

        Dim c6 As New grdstyle.CGridTextBoxStyle("posiciondetrabajo", 100, HorizontalAlignment.Center, True, "Pos. trabajo", "", "")
        ts.GridColumnStyles.Add(c6)

        Dim c7 As New grdstyle.CGridTextBoxStyle("costo", 75, HorizontalAlignment.Center, True, "Costo", "", "")
        ts.GridColumnStyles.Add(c7)

        'Dim c8 As New grdstyle.CGridTextBoxStyle("precio", 75, HorizontalAlignment.Center, True, "Precio", "", "")
        'ts.GridColumnStyles.Add(c8)

        Dim c8 As New grdstyle.CGridNumericUpDownStyle("precio", 75, "Precio", 1, 10000, 2, 1, LeftRightAlignment.Right, 0, "")
        ts.GridColumnStyles.Add(c8)

        dg.TableStyles.Add(ts)
    End Sub


    Public Sub agregarCheck(ByVal ds As DataSet)
        ds.Tables("tipofresa").Columns.Add("seleccionarTF", Type.GetType("System.Boolean"))
    End Sub

End Class
