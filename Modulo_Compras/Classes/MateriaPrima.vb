

Public Class MateriaPrima

    Private selectMateriaPrima As New SqlClient.SqlCommand
    Private adaptadorMateriaPrima As New SqlClient.SqlDataAdapter
    Private resultado As SqlClient.SqlDataReader

    Public Function obtenerPrecioMateriaPrima(ByVal idMateriaPrima As Integer) As Double
        selectMateriaPrima.Connection = cnn
        selectMateriaPrima.Connection.Open()
        selectMateriaPrima.CommandText = "SELECT tmp.idtipomateriaprima, tmp.nombre, doc.precio, MAX(ocmp.fecharealizacion) " & _
                "FROM tipomateriaprima tmp, detalleordencompra doc, ordencompramp ocmp " & _
                "WHERE(tmp.idtipomateriaprima = doc.idtipomateriaprima) " & _
                "AND doc.idordencompra = ocmp.idordencompra " & _
                "AND doc.idestado IN (12, 13) " & _
                "AND tmp.idtipomateriaprima = " + idMateriaPrima.ToString & _
                "GROUP BY tmp.idtipomateriaprima, tmp.nombre, doc.precio, ocmp.fecharealizacion"

        selectMateriaPrima.CommandType = CommandType.Text
        resultado = selectMateriaPrima.ExecuteReader
        Dim precio As Double
        While resultado.Read
            precio = resultado.Item(2)
        End While

        selectMateriaPrima.Connection.Close()

        Return precio

    End Function


    Public Function obtenerNombreMateriaPrima(ByVal idMateriaPrima As Integer) As String
        selectMateriaPrima.Connection = cnn
        selectMateriaPrima.Connection.Open()
        selectMateriaPrima.CommandText = "SELECT tmp.nombre " & _
                                         "FROM tipomateriaprima tmp " & _
                                         "WHERE tmp.idtipomateriaprima = " + idMateriaPrima.ToString


        selectMateriaPrima.CommandType = CommandType.Text
        resultado = selectMateriaPrima.ExecuteReader
        Dim nombre As String = ""
        While resultado.Read
            nombre = resultado.Item(0)
        End While

        selectMateriaPrima.Connection.Close()

        Return nombre.Trim
    End Function


    Private _IdMP As Integer
    Private _NombreMP As String
    Private _DireccionMP As String

    Private _StockActual As Integer
    Private _StockMinimo As Integer
    Private _StockSeguridad As Integer
    Private _LoteEconomico As Integer
    Private _UnidadMedida As Integer

    Public varCancelar As Integer

    Private adaptadorTipoMateriaPrima As SqlClient.SqlDataAdapter

    Public Property IdMP() As Integer
        Get
            Return _IdMP
        End Get
        Set(ByVal Value As Integer)
            _IdMP = Value
        End Set
    End Property

    Private Property NombreMP() As String
        Get
            Return _NombreMP
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                _NombreMP = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property

    Private Property DireccionMP() As String
        Get
            Return _DireccionMP
        End Get
        Set(ByVal Value As String)
            _DireccionMP = Value
        End Set
    End Property

    Private Property StockActual() As Integer
        Get
            Return _StockActual
        End Get
        Set(ByVal Value As Integer)
            _StockActual = Value
        End Set
    End Property

    Private Property StockMinimo() As Integer
        Get
            Return _StockMinimo
        End Get
        Set(ByVal Value As Integer)
            _StockMinimo = Value
        End Set
    End Property

    Private Property StockSeguridad() As Integer
        Get
            Return _StockSeguridad
        End Get
        Set(ByVal Value As Integer)
            _StockSeguridad = Value
        End Set
    End Property

    Private Property LoteEconomico() As Integer
        Get
            Return _LoteEconomico
        End Get
        Set(ByVal Value As Integer)
            _LoteEconomico = Value
        End Set
    End Property

    Private Property UnidadMedida() As Integer 'es un puntero como lo represento
        Get
            Return _UnidadMedida
        End Get
        Set(ByVal Value As Integer)
            _UnidadMedida = Value
        End Set
    End Property
    
    Public Function cargarDSMateriaPrima(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet
        Try
            adaptadorTipoMateriaPrima = New SqlClient.SqlDataAdapter(consulta, conexion)
            Dim dsMateriaPrima As New DataSet("dsMateriaPrima")
            adaptadorTipoMateriaPrima.Fill(dsMateriaPrima, "tipomateriaprima")
            Return dsMateriaPrima
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'para los 3 siguientes metodos es posible usar el updatecommand directamente
    'lo optimo seria hacerlo al cerrar el formulario para que cumpla con ser off-line
    Public Sub nuevaMP(ByVal dscl As DataSet)
        Dim tbMateriaPrima As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbMateriaPrima.Select("idtipomateriaprima=max(idtipomateriaprima)")
        Dim nuevafila As DataRow
        nuevafila = tbMateriaPrima.NewRow()
        nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

        Try


            nuevafila(1) = ""
            nuevafila(2) = 1
            nuevafila(3) = ""
            nuevafila(4) = ""
            nuevafila(5) = ""
            nuevafila(6) = ""
            nuevafila(7) = 0
            nuevafila(8) = 1



            dscl.Tables(0).Rows.Add(nuevafila)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub registrarMP(ByVal dscl As DataSet)
        Try
            If varCancelar <> 1 Then
                Dim tbMP As DataTable = dscl.Tables.Item(0)

                Dim idmaximo() As DataRow
                idmaximo = tbMP.Select("idtipomateriaprima=max(idtipomateriaprima)")
                Dim nuevafila As DataRow
                nuevafila = tbMP.NewRow()
                If idmaximo.Length = 0 Then
                    nuevafila(0) = 1
                Else
                    nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1
                End If

                nuevafila(1) = NombreMP
                nuevafila(2) = DireccionMP
                nuevafila(3) = StockActual
                nuevafila(4) = StockMinimo
                nuevafila(5) = StockSeguridad
                nuevafila(6) = LoteEconomico
                nuevafila(7) = UnidadMedida


                tbMP.Rows.Add(nuevafila)



                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTipoMateriaPrima)
                adaptadorTipoMateriaPrima.InsertCommand = oCommandBuilder_OC.GetInsertCommand
                adaptadorTipoMateriaPrima.Update(dscl, "tipomateriaprima")
            Else
                MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub modificarMP(ByVal dscl As DataSet)
        Try
            If varCancelar <> 1 Then
                Dim tbMP As DataTable = dscl.Tables.Item(0)
                For Each updatefila As DataRow In tbMP.Rows
                    If updatefila(0) = IdMP Then
                        updatefila(1) = NombreMP
                        updatefila(2) = DireccionMP
                        updatefila(3) = StockActual
                        updatefila(4) = StockMinimo
                        updatefila(5) = StockSeguridad
                        updatefila(6) = LoteEconomico
                        updatefila(7) = UnidadMedida
                    End If
                Next
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTipoMateriaPrima)
                adaptadorTipoMateriaPrima.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
                adaptadorTipoMateriaPrima.Update(dscl, "tipomateriaprima")
            Else
                MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub eliminarMP(ByVal dscl As DataSet)
        Try
            Dim strValidar As String
            strValidar = ValidarEliminacion()
            If strValidar = "" Then
                If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Materia Prima") Then

                    Dim tbMP As DataTable = dscl.Tables.Item(0)
                    For i As Integer = 0 To tbMP.Rows.Count - 1
                        If tbMP.Rows(i)(0) = IdMP Then
                            tbMP.Rows(i).Delete()
                        End If
                    Next
                    Try
                        Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTipoMateriaPrima)
                        adaptadorTipoMateriaPrima.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                        adaptadorTipoMateriaPrima.Update(dscl, "tipomateriaprima")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If
            Else
                MessageBox.Show(strValidar, "Eliminacion no autorizada", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidarEliminacion() As String
        Try
            'FIJARSE QUE TABLAS DEBO CONTROLAR ANTES DE ELIMINAR UN TIPO DE MATERIA PRIMA
            Dim strValidacion As String = ""
            Dim ds1 As New DataSet
            Dim adaptador1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idtipomateriaprima from proveedorxtipomateriaprima", cnn)
            adaptador1.Fill(ds1, "proveedorxtipomateriaprima")
            Dim tb1 As DataTable = ds1.Tables.Item(0)
            Dim filabuscada1() As DataRow
            Dim criterio1 As String = "idtipomateriaprima=" & IdMP

            filabuscada1 = tb1.Select(criterio1)

            If (filabuscada1.GetUpperBound(0) <> -1) Then
                strValidacion += "Existen Proveedores vinculados a esta Materia Prima" & vbCrLf
            End If


            Dim ds2 As New DataSet
            Dim adaptador2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idtipomateriaprima from parte", cnn)
            adaptador2.Fill(ds2, "parte")
            Dim tb2 As DataTable = ds2.Tables.Item(0)
            Dim filabuscada2() As DataRow
            Dim criterio2 As String = "idtipomateriaprima=" & IdMP

            filabuscada2 = tb2.Select(criterio2)

            If (filabuscada2.GetUpperBound(0) <> -1) Then
                strValidacion += "Existen Partes registradas fabricadas con esta Materia Prima" & vbCrLf
            End If


            Dim ds3 As New DataSet
            Dim adaptador3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idmp from MPXTP", cnn)
            adaptador3.Fill(ds3, "MPXTP")
            Dim tb3 As DataTable = ds3.Tables.Item(0)
            Dim filabuscada3() As DataRow
            Dim criterio3 As String = "idmp=" & IdMP

            filabuscada3 = tb3.Select(criterio3)

            If (filabuscada3.GetUpperBound(0) <> -1) Then
                strValidacion += "Existen Tipo de Partes registrados fabricados con esta Materia Prima" & vbCrLf
            End If


            Dim ds4 As New DataSet
            Dim adaptador4 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idmprecibida from detallemprecibida", cnn)
            adaptador4.Fill(ds4, "detallemprecibida")
            Dim tb4 As DataTable = ds4.Tables.Item(0)
            Dim filabuscada4() As DataRow
            Dim criterio4 As String = "idmprecibida=" & IdMP

            filabuscada4 = tb4.Select(criterio4)

            If (filabuscada4.GetUpperBound(0) <> -1) Then
                strValidacion += "Existen registros de recepcion de esta Materia Prima" & vbCrLf
            End If

            Dim ds5 As New DataSet
            Dim adaptador5 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idtipomateriaprima from detalleordencompra", cnn)
            adaptador5.Fill(ds5, "detalleordencompra")
            Dim tb5 As DataTable = ds5.Tables.Item(0)
            Dim filabuscada5() As DataRow
            Dim criterio5 As String = "idtipomateriaprima=" & IdMP

            filabuscada5 = tb5.Select(criterio5)

            If (filabuscada5.GetUpperBound(0) <> -1) Then
                strValidacion += "Existen Ordenes de Compra de esta Materia Prima" & vbCrLf
            End If

            Return strValidacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub tomarDatos(ByVal idp As Integer, ByVal nombrep As String, ByVal direccionp As String, ByVal stockap As Integer, ByVal stockmp As Integer, _
        ByVal stocksp As Integer, ByVal lotep As Integer, ByVal unidadp As Integer)
        Try
            varCancelar = 0
            IdMP = idp
            NombreMP = nombrep
            DireccionMP = direccionp
            StockActual = stockap
            StockMinimo = stockmp
            StockSeguridad = stocksp
            LoteEconomico = lotep
            UnidadMedida  = unidadp
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mostrarDatos(ByRef txtId As String, ByRef txtNombre As String, ByRef txtDireccion As String, ByRef txtStockA As String, ByRef txtStockM As String, _
    ByRef txtStockS As String, ByRef txtLote As String, ByRef cboUnidad As Integer)
        Try
            txtId = IdMP
            txtNombre = NombreMP
            txtDireccion = DireccionMP
            txtStockA = StockActual
            txtStockM = StockMinimo
            txtStockS = StockSeguridad
            txtLote = LoteEconomico
            cboUnidad = UnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Function validarCliente(ByVal dscl As DataSet) As Boolean
    '    Try
    '        Dim tbcliente As DataTable = dscl.Tables.Item(0)
    '        Dim cfilas As DataRowCollection = tbcliente.Rows
    '        Dim filabuscada() As DataRow
    '        Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
    '        'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

    '        filabuscada = tbcliente.Select(criterio)

    '        If (filabuscada.GetUpperBound(0) = -1) Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function buscarCliente(ByVal dscl As DataSet) As DataRow()
    '    Try
    '        Dim tbcliente As DataTable = dscl.Tables.Item(0)
    '        Dim cfilas As DataRowCollection = tbcliente.Rows
    '        'Dim filavacia As DataRow
    '        Dim filabuscada() As DataRow
    '        Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
    '        'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

    '        filabuscada = tbcliente.Select(criterio)
    '        Return filabuscada
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
End Class
