Public Class Maquina
    Private intIdMaquina As Integer
    Private strNombre As String
    Private strDescripcion As String
    Private strNumeroDeSerie As String
    Private strPotencia As String
    Private doubCostoDeCompra As Double
    Private strEstadoDeAdquisicion As String
    Private intIdEstado As Integer
    Private intHorasDeUso As Integer
    Private strTipoMaquina As String
    Public varCancelar As Integer
    Private adaptadorMaquina As SqlClient.SqlDataAdapter

    Public Property idMaquina() As Integer
        Get
            Return intIdMaquina
        End Get
        Set(ByVal Value As Integer)
            intIdMaquina = Value
        End Set
    End Property
    Private Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                strNombre = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property Descripcion() As String
        Get
            Return strDescripcion
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                strDescripcion = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property NumeroDeSerie() As String
        Get
            Return strNumeroDeSerie
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                strNumeroDeSerie = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property Potencia() As String
        Get
            Return strPotencia
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                strPotencia = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property CostoDeCompra() As Double
        Get
            Return doubCostoDeCompra
        End Get
        Set(ByVal Value As Double)
            doubCostoDeCompra = Value
        End Set
    End Property
    Private Property EstadoDeAdquisicion() As String
        Get
            Return strEstadoDeAdquisicion
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                strEstadoDeAdquisicion = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Public Property IdEstado() As Integer
        Get
            Return intIdEstado
        End Get
        Set(ByVal Value As Integer)
            intIdEstado = Value
        End Set
    End Property
    Public Property HorasDeUso() As Integer
        Get
            Return intHorasDeUso
        End Get
        Set(ByVal Value As Integer)
            intHorasDeUso = Value
        End Set
    End Property
    Private Property TipoMaquina() As String
        Get
            Return strTipoMaquina
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                strTipoMaquina = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property

    Public Function cargarDSMaquina(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorMaquina = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsMaquina As New DataSet("dsMaquina")
        adaptadorMaquina.Fill(dsMaquina, "Maquina")
        Return dsMaquina
    End Function


    Public Sub nuevoMaquina(ByVal dscl As DataSet)
        Dim tbMaquina As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbMaquina.Select("idMaquina=max(idMaquina)")
        Dim nuevafila As DataRow
        nuevafila = tbMaquina.NewRow()
        nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

        Try


            nuevafila(1) = ""
            nuevafila(2) = ""
            nuevafila(3) = ""
            nuevafila(4) = ""
            nuevafila(5) = 0
            nuevafila(6) = ""
            nuevafila(7) = 0
            nuevafila(8) = 0
            nuevafila(9) = 0



            dscl.Tables(0).Rows.Add(nuevafila)


        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarMaquina(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbMaquina As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbMaquina.Select("idMaquina=max(idMaquina)")
            Dim nuevafila As DataRow
            nuevafila = tbMaquina.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = strNombre
            nuevafila(2) = strDescripcion
            nuevafila(3) = strNumeroDeSerie
            nuevafila(4) = strPotencia
            nuevafila(5) = doubCostoDeCompra
            nuevafila(6) = strEstadoDeAdquisicion
            nuevafila(7) = intIdEstado
            nuevafila(8) = intHorasDeUso
            nuevafila(9) = strTipoMaquina

            tbMaquina.Rows.Add(nuevafila)



            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorMaquina)
            adaptadorMaquina.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorMaquina.Update(dscl, "Maquina")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarMaquina(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbMaquina As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbMaquina.Rows
                If updatefila(0) = intIdMaquina Then
                    updatefila(1) = strNombre
                    updatefila(2) = strDescripcion
                    updatefila(3) = strNumeroDeSerie
                    updatefila(4) = strPotencia
                    updatefila(5) = doubCostoDeCompra
                    updatefila(6) = strEstadoDeAdquisicion
                    updatefila(7) = intIdEstado
                    updatefila(8) = intHorasDeUso
                    updatefila(9) = strTipoMaquina


                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorMaquina)
            adaptadorMaquina.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorMaquina.Update(dscl, "Maquina")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    'Public Sub eliminarMaquina(ByVal dscl As DataSet)
    '    If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Maquina") Then

    '        Dim dsPedidos As New DataSet
    '        Dim adaptadorPe As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idcliente from pedido", cnn)
    '        adaptadorPe.Fill(dsPedidos, "Pedido")
    '        Dim tbcliepe As DataTable = dsPedidos.Tables.Item(0)
    '        Dim cfilas As DataRowCollection = tbcliepe.Rows
    '        Dim filabuscada() As DataRow
    '        Dim criterio As String = "idcliente=" & idcliente

    '        filabuscada = tbcliepe.Select(criterio)

    '        If (filabuscada.GetUpperBound(0) <> -1) Then
    '            MessageBox.Show("Existe Pedidos registrados a nombre de este cliente", "Eliminacion no autorizada", MessageBoxButtons.OK)
    '            Exit Sub
    '        End If

    '        Dim tbcliente As DataTable = dscl.Tables.Item(0)
    '        For i As Integer = 0 To tbcliente.Rows.Count - 1
    '            If tbcliente.Rows(i)(0) = idcliente Then
    '                tbcliente.Rows(i).Delete()
    '            End If
    '        Next
    '        Try
    '            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorcliente)
    '            adaptadorcliente.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
    '            adaptadorcliente.Update(dscl, "cliente")
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try

    '    End If
    'End Sub

    Public Sub tomarDatos(ByVal IdMaquinap As Integer, ByVal Nombrep As String, ByVal Descripcionp As String, ByVal NumeroDeSeriep As String, ByVal Potenciap As String, _
        ByVal CostoDeComprap As Double, ByVal EstadoDeAdquisicionp As String, ByVal IdEstadop As Integer, ByVal HorasDeUsop As Integer, ByVal TipoMaquinap As String)
        varCancelar = 0
        idMaquina = IdMaquinap
        Nombre = Nombrep
        Descripcion = Descripcionp
        NumeroDeSerie = NumeroDeSeriep
        Potencia = Potenciap
        CostoDeCompra = CostoDeComprap
        EstadoDeAdquisicion = EstadoDeAdquisicionp
        IdEstado = IdEstadop
        HorasDeUso = HorasDeUsop
        TipoMaquina = TipoMaquinap


    End Sub

    Public Sub mostrarDatos(ByRef txtNumMaquinap As String, ByRef txtNombrep As String, ByRef txtDescripcionp As String, ByRef txtNumeroDeSeriep As String, ByRef txtPotenciap As String, _
        ByRef txtCostoDeComprap As String, ByRef txtEstadoDeAdquisicionp As String, ByRef cmbIdEstadop As String, ByRef txtHorasDeUsop As String, ByRef cmbTipoMaquinap As String)
        txtNumMaquinap = intIdMaquina
        txtNombrep = strNombre
        txtDescripcionp = strDescripcion
        txtNumeroDeSeriep = strNumeroDeSerie
        txtPotenciap = strPotencia
        txtCostoDeComprap = doubCostoDeCompra
        txtEstadoDeAdquisicionp = strEstadoDeAdquisicion
        cmbIdEstadop = intIdEstado
        txtHorasDeUsop = intHorasDeUso
        cmbTipoMaquinap = strTipoMaquina

    End Sub

    'Public Function validarMaquina(ByVal dscl As DataSet) As Boolean
    '    Dim tbcliente As DataTable = dscl.Tables.Item(0)
    '    Dim cfilas As DataRowCollection = tbcliente.Rows
    '    Dim filabuscada() As DataRow
    '    Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
    '    'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

    '    filabuscada = tbcliente.Select(criterio)

    '    If (filabuscada.GetUpperBound(0) = -1) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    'Public Function buscarMaquina(ByVal dscl As DataSet) As DataRow()
    '    Dim tbcliente As DataTable = dscl.Tables.Item(0)
    '    Dim cfilas As DataRowCollection = tbcliente.Rows
    '    'Dim filavacia As DataRow
    '    Dim filabuscada() As DataRow
    '    Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
    '    'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

    '    filabuscada = tbcliente.Select(criterio)

    '    'If (filabuscada.GetUpperBound(0) = -1) Then
    '    'Return filavacia
    '    'Else
    '    'Return filabuscada
    '    'End If
    '    Return filabuscada
    'End Function
    Public Function getNewID(ByVal dscl As DataSet) As Integer

        Dim tbMaquina As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbMaquina.Select("idMaquina=max(idMaquina)")
        Dim nuevafila As DataRow
        nuevafila = tbMaquina.NewRow()
        Return CType(idmaximo(0).Item(0), Integer) + 1
    End Function
End Class
