Public Class Cliente
    Private idcliente As Integer
    Private nombrecliente As String
    Private apellidocliente As String
    Private idtipodoccliente As Integer
    Private direccioncliente As String
    Private idloccliente As Integer
    Private mailcliente As String
    Private telefonocliente As String
    Private documentocliente As Decimal
    Private celularcliente As String
    Public varCancelar As Integer

    Private adaptadorcliente As SqlClient.SqlDataAdapter

    Public Property id() As Integer
        Get
            Return idcliente
        End Get
        Set(ByVal Value As Integer)
            idcliente = Value
        End Set
    End Property
    Private Property nombre() As String
        Get
            Return nombrecliente
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                nombrecliente = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property apellido() As String
        Get
            Return apellidocliente
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                apellidocliente = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property

    Private Property idtipodocumento() As Integer
        Get
            Return idtipodoccliente
        End Get
        Set(ByVal Value As Integer)
            idtipodoccliente = Value
        End Set
    End Property
    Private Property direccion() As String
        Get
            Return direccioncliente
        End Get
        Set(ByVal Value As String)
            direccioncliente = Value
        End Set
    End Property
    Private Property localidad() As Integer 'es un puntero como lo represento
        Get
            Return idloccliente
        End Get
        Set(ByVal Value As Integer)
            idloccliente = Value
        End Set
    End Property
    Private Property mail() As String
        Get
            Return mailcliente
        End Get
        Set(ByVal Value As String)
            mailcliente = Value
        End Set
    End Property
    Private Property telefono() As String
        Get
            Return telefonocliente
        End Get
        Set(ByVal Value As String)
            telefonocliente = Value
        End Set
    End Property
    Private Property documento() As Decimal
        Get
            Return documentocliente
        End Get
        Set(ByVal Value As Decimal)
            If IsNumeric(Value) Then
                documentocliente = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property celular() As String
        Get
            Return celularcliente
        End Get
        Set(ByVal Value As String)
            celularcliente = Value
        End Set
    End Property

    'Public Sub New(ByVal id As Integer)
    '   idcliente = id
    'End Sub

    Public Function cargarDSCliente(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet
        Try
            adaptadorcliente = New SqlClient.SqlDataAdapter(consulta, conexion)
            Dim dscliente As New DataSet("dscliente")
            adaptadorcliente.Fill(dscliente, "cliente")
            Return dscliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'para los 3 siguientes metodos es posible usar el updatecommand directamente
    'lo optimo seria hacerlo al cerrar el formulario para que cumpla con ser off-line
    Public Sub nuevoCliente(ByVal dscl As DataSet)
        Dim tbcliente As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbcliente.Select("idcliente=max(idcliente)")
        Dim nuevafila As DataRow
        nuevafila = tbcliente.NewRow()
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

    Public Sub registrarCliente(ByVal dscl As DataSet)
        Try
            If varCancelar <> 1 Then
                Dim tbcliente As DataTable = dscl.Tables.Item(0)

                Dim idmaximo() As DataRow
                idmaximo = tbcliente.Select("idcliente=max(idcliente)")
                Dim nuevafila As DataRow
                nuevafila = tbcliente.NewRow()
                nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

                nuevafila(1) = nombrecliente
                nuevafila(2) = apellidocliente
                nuevafila(3) = idloccliente
                nuevafila(4) = direccioncliente
                nuevafila(5) = telefonocliente
                nuevafila(6) = mailcliente
                nuevafila(7) = celularcliente
                nuevafila(8) = documentocliente
                nuevafila(9) = idtipodoccliente


                tbcliente.Rows.Add(nuevafila)



                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorcliente)
                adaptadorcliente.InsertCommand = oCommandBuilder_OC.GetInsertCommand
                adaptadorcliente.Update(dscl, "cliente")
            Else
                MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Public Sub modificarCliente(ByVal dscl As DataSet)
        Try
            If varCancelar <> 1 Then
                Dim tbcliente As DataTable = dscl.Tables.Item(0)
                For Each updatefila As DataRow In tbcliente.Rows
                    If updatefila(0) = idcliente Then
                        updatefila(1) = nombrecliente
                        updatefila(2) = apellidocliente
                        updatefila(3) = idloccliente
                        updatefila(4) = direccioncliente
                        updatefila(5) = telefonocliente
                        updatefila(6) = mailcliente
                        updatefila(7) = celularcliente
                        updatefila(8) = documentocliente
                        updatefila(9) = idtipodoccliente
                    End If
                Next
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorcliente)
                adaptadorcliente.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
                adaptadorcliente.Update(dscl, "cliente")
            Else
                MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    Public Sub eliminarCliente(ByVal dscl As DataSet)
        Try
            Dim strValidar As String
            strValidar = ValidarEliminacion()
            If strValidar = "" Then
                If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Cliente") Then

                    Dim tbcliente As DataTable = dscl.Tables.Item(0)
                    For i As Integer = 0 To tbcliente.Rows.Count - 1
                        If tbcliente.Rows(i)(0) = idcliente Then
                            tbcliente.Rows(i).Delete()
                        End If
                    Next
                    Try
                        Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorcliente)
                        adaptadorcliente.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                        adaptadorcliente.Update(dscl, "cliente")
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
            Dim strValidacion As String = ""
            Dim ds1 As New DataSet
            Dim adaptador1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idcliente from pedido", cnn)
            adaptador1.Fill(ds1, "Pedido")
            Dim tb1 As DataTable = ds1.Tables.Item(0)
            Dim filabuscada1() As DataRow
            Dim criterio1 As String = "idcliente=" & idcliente

            filabuscada1 = tb1.Select(criterio1)

            If (filabuscada1.GetUpperBound(0) <> -1) Then
                strValidacion += "Existe Pedidos registrados a nombre de este cliente" & vbCrLf
            End If

            Dim ds2 As New DataSet
            Dim adaptador2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idcliente from presupuesto", cnn)
            adaptador2.Fill(ds2, "Presupuesto")
            Dim tb2 As DataTable = ds2.Tables.Item(0)
            Dim filabuscada2() As DataRow
            Dim criterio2 As String = "idcliente=" & idcliente

            filabuscada2 = tb2.Select(criterio2)

            If (filabuscada2.GetUpperBound(0) <> -1) Then
                strValidacion += "Existe Presupuestos registrados a nombre de este cliente"
            End If

            Return strValidacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub tomarDatos(ByVal nombrep As String, ByVal idtipodocp As Integer, ByVal direccionp As String, ByVal idlocp As Integer, _
        ByVal mailp As String, ByVal telefonop As String, ByVal documentop As Decimal, ByVal celularp As String, ByVal apellidop As String, ByVal idp As Integer)
        Try
            varCancelar = 0
            id() = idp
            nombre() = nombrep
            apellido() = apellidop
            idtipodocumento() = idtipodocp
            direccion() = direccionp
            localidad() = idlocp
            mail() = mailp
            telefono() = telefonop
            celular() = celularp
            documento() = documentop
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mostrarDatos(ByRef txtnombre As String, ByRef cmbidtipodoc As Integer, ByRef txtdireccion As String, ByRef cmbidloc As Integer, _
    ByRef txtmail As String, ByRef txttelefono As String, ByRef txtcelular As String, ByRef txtapellido As String, ByRef txtdoc As String)
        Try
            txtnombre = nombrecliente
            txtapellido = apellidocliente
            cmbidtipodoc = idtipodoccliente
            txtdireccion = direccioncliente
            cmbidloc = idloccliente
            txtmail = mailcliente
            txttelefono = telefonocliente
            txtcelular = celularcliente
            txtdoc = documentocliente
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function validarCliente(ByVal dscl As DataSet) As Boolean
        Try
            Dim tbcliente As DataTable = dscl.Tables.Item(0)
            Dim cfilas As DataRowCollection = tbcliente.Rows
            Dim filabuscada() As DataRow
            Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
            'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

            filabuscada = tbcliente.Select(criterio)

            If (filabuscada.GetUpperBound(0) = -1) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function buscarCliente(ByVal dscl As DataSet) As DataRow()
        Try
            Dim tbcliente As DataTable = dscl.Tables.Item(0)
            Dim cfilas As DataRowCollection = tbcliente.Rows
            'Dim filavacia As DataRow
            Dim filabuscada() As DataRow
            Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
            'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

            filabuscada = tbcliente.Select(criterio)
            Return filabuscada
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
