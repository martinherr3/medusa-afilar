Public Class Empleado
    Private idEmpleado As Integer
    Private nombreEmpleado As String
    Private apellidoEmpleado As String
    Private idCargoEmpleado As Integer
    Private direccionEmpleado As String
    Private idlocEmpleado As Integer
    Private mailEmpleado As String
    Private telefonoEmpleado As String
    Private tituloEmpleado As String
    Private turnoEmpleado As String
    Public varCancelar As Integer
    Private adaptadorEmpleado As SqlClient.SqlDataAdapter


    Public Property id() As Integer
        Get
            Return idEmpleado
        End Get
        Set(ByVal Value As Integer)
            idEmpleado = Value
        End Set
    End Property
    Private Property nombre() As String
        Get
            Return nombreEmpleado
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                nombreEmpleado = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property apellido() As String
        Get
            Return apellidoEmpleado
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                apellidoEmpleado = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property

    Private Property idCargo() As Integer
        Get
            Return idCargoEmpleado
        End Get
        Set(ByVal Value As Integer)
            idCargoEmpleado = Value
        End Set
    End Property
    Private Property direccion() As String
        Get
            Return direccionEmpleado
        End Get
        Set(ByVal Value As String)
            direccionEmpleado = Value
        End Set
    End Property
    Private Property localidad() As Integer 'es un puntero como lo represento
        Get
            Return idlocEmpleado
        End Get
        Set(ByVal Value As Integer)
            idlocEmpleado = Value
        End Set
    End Property
    Private Property mail() As String
        Get
            Return mailEmpleado
        End Get
        Set(ByVal Value As String)
            mailEmpleado = Value
        End Set
    End Property
    Private Property telefono() As String
        Get
            Return telefonoEmpleado
        End Get
        Set(ByVal Value As String)
            telefonoEmpleado = Value
        End Set
    End Property
    Private Property titulo() As String
        Get
            Return tituloEmpleado
        End Get
        Set(ByVal Value As String)
            tituloEmpleado = Value
        End Set
    End Property
    Private Property turno() As String
        Get
            Return turnoEmpleado
        End Get
        Set(ByVal Value As String)
            turnoEmpleado = Value
        End Set
    End Property

    'Public Sub New(ByVal id As Integer)
    '   idEmpleado = id
    'End Sub

    Public Function cargarDSEmpleado(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorEmpleado = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsEmpleado As New DataSet("dsEmpleado")
        adaptadorEmpleado.Fill(dsEmpleado, "Empleado")
        Return dsEmpleado
    End Function

    'para los 3 siguientes metodos es posible usar el updatecommand directamente
    'lo optimo seria hacerlo al cerrar el formulario para que cumpla con ser off-line
    Public Sub nuevoEmpleado(ByVal dscl As DataSet)
        Dim tbEmpleado As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbEmpleado.Select("idlegajo=max(idlegajo)")
        Dim nuevafila As DataRow
        nuevafila = tbEmpleado.NewRow()
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

            'UltraButton6.PerformClick()  'voy al ultimo registro
            'mostrarPosicion(tabla)
            'text1.Focus()

        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarEmpleado(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbEmpleado As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbEmpleado.Select("idlegajo=max(idlegajo)")
            Dim nuevafila As DataRow
            nuevafila = tbEmpleado.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = nombreEmpleado
            nuevafila(2) = apellidoEmpleado
            nuevafila(3) = direccionEmpleado
            nuevafila(4) = telefonoEmpleado
            nuevafila(5) = idCargoEmpleado
            nuevafila(6) = mailEmpleado
            nuevafila(7) = tituloEmpleado
            nuevafila(8) = idlocEmpleado
            nuevafila(9) = turnoEmpleado

            tbEmpleado.Rows.Add(nuevafila)



            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorEmpleado)
            adaptadorEmpleado.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorEmpleado.Update(dscl, "Empleado")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarEmpleado(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbEmpleado As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbEmpleado.Rows
                If updatefila(0) = idEmpleado Then
                    updatefila(1) = nombreEmpleado
                    updatefila(2) = apellidoEmpleado
                    updatefila(3) = direccionEmpleado
                    updatefila(4) = telefonoEmpleado
                    updatefila(5) = idCargoEmpleado
                    updatefila(6) = mailEmpleado
                    updatefila(7) = tituloEmpleado
                    updatefila(8) = idlocEmpleado
                    updatefila(9) = turnoEmpleado
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorEmpleado)
            adaptadorEmpleado.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorEmpleado.Update(dscl, "Empleado")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarEmpleado(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Empleado") Then

            Dim dsPedidos As New DataSet
            Dim adaptadorPe As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idvendedor,idviajante from pedido", cnn)
            adaptadorPe.Fill(dsPedidos, "Pedido")
            Dim tbEmpleadoPedido As DataTable = dsPedidos.Tables.Item(0)
            Dim cfilas As DataRowCollection = tbEmpleadoPedido.Rows
            Dim filabuscada() As DataRow
            Dim criterio As String = "idvendedor=" & idEmpleado & " or idviajante=" & idEmpleado

            filabuscada = tbEmpleadoPedido.Select(criterio)

            If (filabuscada.GetUpperBound(0) <> -1) Then
                MessageBox.Show("Existe Pedidos registrados a nombre de este Empleado", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbEmpleado As DataTable = dscl.Tables.Item(0)
            For i As Integer = 0 To tbEmpleado.Rows.Count - 1
                If tbEmpleado.Rows(i)(0) = idEmpleado Then
                    tbEmpleado.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorEmpleado)
                adaptadorEmpleado.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorEmpleado.Update(dscl, "Empleado")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub tomarDatos(ByVal nombrep As String, ByVal idcargop As Integer, ByVal direccionp As String, ByVal idlocp As Integer, _
        ByVal mailp As String, ByVal telefonop As String, ByVal titulop As String, ByVal turnop As String, ByVal apellidop As String, ByVal idp As Integer)
        'nombreEmpleado = ""
        'direccionEmpleado = ""
        'mailEmpleado = ""
        'telefonoEmpleado = ""
        'celularEmpleado = ""
        'documentoEmpleado = 0
        varCancelar = 0
        id() = idp
        nombre() = nombrep
        apellido() = apellidop
        idCargo() = idcargop
        direccion() = direccionp
        localidad() = idlocp
        mail() = mailp
        telefono() = telefonop
        titulo() = titulop
        turno() = turnop
    End Sub

    Public Sub mostrarDatos(ByRef txtnombre As String, ByRef cbocargo As Integer, ByRef txtdireccion As String, ByRef cbolocalidad As Integer, _
    ByRef txtmail As String, ByRef txttelefono As String, ByRef txttitulo As String, ByRef txtapellido As String, ByRef txtturno As String)
        txtnombre = nombreEmpleado
        txtapellido = apellidoEmpleado
        cbocargo = idCargoEmpleado
        txtdireccion = direccionEmpleado
        cbolocalidad = idlocEmpleado
        txtmail = mailEmpleado
        txttelefono = telefonoEmpleado
        txttitulo = tituloEmpleado
        txtturno = turnoEmpleado
    End Sub

    Public Function validarEmpleado(ByVal dscl As DataSet) As Boolean
        Dim tbEmpleado As DataTable = dscl.Tables.Item(0)
        Dim cfilas As DataRowCollection = tbEmpleado.Rows
        Dim filabuscada() As DataRow
        Dim criterio As String = "nombre='" & Trim(nombreEmpleado) & "' and apellido='" & Trim(apellidoEmpleado) & "'"
        'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

        filabuscada = tbEmpleado.Select(criterio)

        If (filabuscada.GetUpperBound(0) = -1) Then
            Return True
        Else
            Return False
        End If
    End Function
    
End Class
