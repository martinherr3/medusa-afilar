Public Class Desperfecto
    Private intIdDesperfecto As Integer
    Private intIdTipoDesperfecto As Integer
    Private intIdMaquina As Integer
    Private dateFechaRotura As Date
    Private dateFechaReparacion As Date
    Private strCausa As String
    Private doubCosto As Double
    Public varCancelar As Integer
    Private adaptadorDesperfecto As SqlClient.SqlDataAdapter

    Public Property idDesperfecto() As Integer
        Get
            Return intIdDesperfecto
        End Get
        Set(ByVal Value As Integer)
            intIdDesperfecto = Value
        End Set
    End Property
    Public Property IdMaquina() As Integer
        Get
            Return intIdMaquina
        End Get
        Set(ByVal Value As Integer)
            intIdMaquina = Value
        End Set
    End Property
    Public Property IdTipoDesperfecto() As Integer
        Get
            Return intIdTipoDesperfecto
        End Get
        Set(ByVal Value As Integer)
            intIdTipoDesperfecto = Value
        End Set
    End Property
    Private Property FechaRotura() As Date
        Get
            Return dateFechaRotura
        End Get
        Set(ByVal Value As Date)
            If Len(Value) > 0 Then
                dateFechaRotura = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property

    Private Property FechaReparacion() As Date
        Get
            Return dateFechaReparacion
        End Get
        Set(ByVal Value As Date)
            If Len(Value) > 0 Then
                dateFechaReparacion = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property Causa() As String
        Get
            Return strCausa
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                strCausa = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property

    Private Property Costo() As Double
        Get
            Return doubCosto
        End Get
        Set(ByVal Value As Double)
            doubCosto = Value
        End Set
    End Property
    Public Function cargarDSDesperfecto(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorDesperfecto = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsDesperfecto As New DataSet("dsDesperfecto")
        adaptadorDesperfecto.Fill(dsDesperfecto, "Desperfecto")
        Return dsDesperfecto
    End Function

    
    Public Sub nuevoDesperfecto(ByVal dscl As DataSet)
        Dim tbDesperfecto As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbDesperfecto.Select("idDesperfecto=max(idDesperfecto)")
        Dim nuevafila As DataRow
        nuevafila = tbDesperfecto.NewRow()
        nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

        Try


            nuevafila(1) = 0
            nuevafila(2) = 1
            nuevafila(3) = ""
            nuevafila(4) = ""
            nuevafila(5) = ""
            nuevafila(6) = 0




            dscl.Tables(0).Rows.Add(nuevafila)


        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarDesperfecto(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbDesperfecto As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbDesperfecto.Select("idDesperfecto=max(idDesperfecto)")
            Dim nuevafila As DataRow
            nuevafila = tbDesperfecto.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = intIdTipoDesperfecto
            nuevafila(2) = dateFechaRotura
            nuevafila(3) = strCausa
            nuevafila(4) = dateFechaReparacion
            nuevafila(5) = doubCosto
            nuevafila(6) = intIdMaquina
            


            tbDesperfecto.Rows.Add(nuevafila)



            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorDesperfecto)
            adaptadorDesperfecto.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorDesperfecto.Update(dscl, "Desperfecto")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarDesperfecto(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbDesperfecto As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbDesperfecto.Rows
                If updatefila(0) = intIdDesperfecto Then
                    updatefila(1) = intIdTipoDesperfecto
                    updatefila(2) = dateFechaRotura
                    updatefila(3) = strCausa
                    updatefila(4) = dateFechaReparacion
                    updatefila(5) = doubCosto
                    updatefila(6) = intIdMaquina

                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorDesperfecto)
            adaptadorDesperfecto.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorDesperfecto.Update(dscl, "Desperfecto")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    'Public Sub eliminarDesperfecto(ByVal dscl As DataSet)
    '    If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Desperfecto") Then

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

    Public Sub tomarDatos(ByVal iddesperfectop As Integer, ByVal idtipodesperfectop As Integer, ByVal fecharoturap As Date, ByVal causap As String, ByVal fechareparacionp As Date, _
        ByVal costop As Double, ByVal idmaquinap As Integer)
        varCancelar = 0
        idDesperfecto = iddesperfectop
        IdTipoDesperfecto = idtipodesperfectop
        FechaRotura = fecharoturap
        Causa = causap
        FechaReparacion = fechareparacionp
        Costo = costop
        IdMaquina = idmaquinap
    End Sub

    Public Sub mostrarDatos(ByRef cmbtipodesperfecto As Integer, ByRef txtfecharotura As Date, ByRef txtcausa As String, ByRef txtfechareparacion As Date, _
    ByRef txtcosto As Double, ByRef cmbidmaquina As Integer, ByRef txtnumerodesperfectop As Integer)
        cmbtipodesperfecto = intIdTipoDesperfecto
        txtfecharotura = dateFechaRotura
        txtcausa = strCausa
        txtfechareparacion = dateFechaReparacion
        txtcosto = doubCosto
        cmbidmaquina = intIdMaquina
        txtnumerodesperfectop = intIdDesperfecto

    End Sub

    'Public Function validarDesperfecto(ByVal dscl As DataSet) As Boolean
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

    'Public Function buscarDesperfecto(ByVal dscl As DataSet) As DataRow()
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

        Dim tbDesperfecto As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbDesperfecto.Select("idDesperfecto=max(idDesperfecto)")
        Dim nuevafila As DataRow
        nuevafila = tbDesperfecto.NewRow()
        Return CType(idmaximo(0).Item(0), Integer) + 1
    End Function
End Class
