Public Class Localidad
    Private idLocalidad As Integer
    Private nombreLocalidad As String
    Private codigoLocalidad As String
    Private zonaLocalidad As String
    Private distanciaLocalidad As Integer
    Private provinciaAbrevLocalidad As String
    Private provinciaIdLocalidad As Integer
    Public varCancelar As Integer
    Private adaptadorLocalidad As SqlClient.SqlDataAdapter

    Private Property id() As Integer
        Get
            Return idLocalidad
        End Get
        Set(ByVal Value As Integer)
            idLocalidad = Value
        End Set
    End Property
    Private Property nombre() As String
        Get
            Return nombreLocalidad
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                nombreLocalidad = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property codigo() As String
        Get
            Return codigoLocalidad
        End Get
        Set(ByVal Value As String)
            codigoLocalidad = Value
        End Set
    End Property

    Private Property zona() As String
        Get
            Return zonaLocalidad
        End Get
        Set(ByVal Value As String)
            zonaLocalidad = Value
        End Set
    End Property
    Private Property distancia() As String
        Get
            Return distanciaLocalidad
        End Get
        Set(ByVal Value As String)
            distanciaLocalidad = Value
        End Set
    End Property
    Private Property provinciaAbrev() As String
        Get
            Return provinciaAbrevLocalidad
        End Get
        Set(ByVal Value As String)
            provinciaAbrevLocalidad = Value
        End Set
    End Property

    Private Property provinciaId() As Integer
        Get
            Return provinciaIdLocalidad
        End Get
        Set(ByVal Value As Integer)
            provinciaIdLocalidad = Value
        End Set
    End Property

    'Public Sub New(ByVal id As Integer)
    '   idLocalidad = id
    'End Sub

    Public Function cargarDSLocalidad(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorLocalidad = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsLocalidad As New DataSet("dsLocalidad")
        adaptadorLocalidad.Fill(dsLocalidad, "Localidad")
        Return dsLocalidad
    End Function

    'para los 3 siguientes metodos es posible usar el updatecommand directamente
    'lo optimo seria hacerlo al cerrar el formulario para que cumpla con ser off-line
    Public Sub nuevoLocalidad(ByVal dscl As DataSet)
        Dim tbLocalidad As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbLocalidad.Select("idLocalidad=max(idLocalidad)")
        Dim nuevafila As DataRow
        nuevafila = tbLocalidad.NewRow()
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

    Public Sub registrarLocalidad(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbLocalidad As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbLocalidad.Select("idLocalidad=max(idLocalidad)")
            Dim nuevafila As DataRow
            nuevafila = tbLocalidad.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = codigo
            nuevafila(2) = zona
            nuevafila(3) = provinciaAbrev
            nuevafila(4) = distancia
            nuevafila(5) = nombre
            nuevafila(6) = provinciaId

            tbLocalidad.Rows.Add(nuevafila)



            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorLocalidad)
            adaptadorLocalidad.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorLocalidad.Update(dscl, "Localidad")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarLocalidad(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbLocalidad As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbLocalidad.Rows
                If updatefila(0) = idLocalidad Then
                    updatefila(1) = codigo
                    updatefila(2) = zona
                    updatefila(3) = provinciaAbrev
                    updatefila(4) = distancia
                    updatefila(5) = nombre
                    updatefila(6) = provinciaId
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorLocalidad)
            adaptadorLocalidad.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorLocalidad.Update(dscl, "Localidad")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarLocalidad(ByVal dscl As DataSet)
        Dim strValidar As String
        strValidar = ValidarEliminacion()
        If strValidar = "" Then
            If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Localidad") Then

                Dim tbLocalidad As DataTable = dscl.Tables.Item(0)
                For i As Integer = 0 To tbLocalidad.Rows.Count - 1
                    If tbLocalidad.Rows(i)(0) = idLocalidad Then
                        tbLocalidad.Rows(i).Delete()
                    End If
                Next
                Try
                    Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorLocalidad)
                    adaptadorLocalidad.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                    adaptadorLocalidad.Update(dscl, "Localidad")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MessageBox.Show(strValidar, "Eliminacion no autorizada", MessageBoxButtons.OK)
        End If
    End Sub

    Private Function ValidarEliminacion() As String
        Dim strValidacion As String = ""
        Dim ds1 As New DataSet
        Dim adaptador1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select Localidad from cliente", cnn)
        adaptador1.Fill(ds1, "cliente")
        Dim tb1 As DataTable = ds1.Tables.Item(0)
        Dim filabuscada1() As DataRow
        Dim criterio1 As String = "Localidad=" & idLocalidad

        filabuscada1 = tb1.Select(criterio1)

        If (filabuscada1.GetUpperBound(0) <> -1) Then
            strValidacion += "Existe Clientes registrados a nombre de esta Localidad" & vbCrLf
        End If



        Dim ds2 As New DataSet
        Dim adaptador2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idlocalidad from empleado", cnn)
        adaptador2.Fill(ds2, "empleado")
        Dim tb2 As DataTable = ds2.Tables.Item(0)
        Dim filabuscada2() As DataRow
        Dim criterio2 As String = "idlocalidad=" & idLocalidad

        filabuscada2 = tb2.Select(criterio2)

        If (filabuscada2.GetUpperBound(0) <> -1) Then
            strValidacion += "Existe Empleados registrados a nombre de esta Localidad" & vbCrLf
        End If


        Dim ds3 As New DataSet
        Dim adaptador3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idlocalidad from empresaxlocalidad", cnn)
        adaptador3.Fill(ds3, "empresaxlocalidad")
        Dim tb3 As DataTable = ds3.Tables.Item(0)
        Dim filabuscada3() As DataRow
        Dim criterio3 As String = "idlocalidad=" & idLocalidad

        filabuscada3 = tb3.Select(criterio3)

        If (filabuscada3.GetUpperBound(0) <> -1) Then
            strValidacion += "Existe Asociaciones con Empresas registradas a nombre de esta Localidad" & vbCrLf
        End If


        Dim ds4 As New DataSet
        Dim adaptador4 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idlocalidad from proveedor", cnn)
        adaptador4.Fill(ds4, "proveedor")
        Dim tb4 As DataTable = ds4.Tables.Item(0)
        Dim filabuscada4() As DataRow
        Dim criterio4 As String = "idlocalidad=" & idLocalidad

        filabuscada4 = tb4.Select(criterio4)

        If (filabuscada4.GetUpperBound(0) <> -1) Then
            strValidacion += "Existe Proveedores registrados a nombre de esta Localidad" & vbCrLf
        End If

        Dim ds5 As New DataSet
        Dim adaptador5 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idlocalidad from viajantexlocalidad", cnn)
        adaptador5.Fill(ds5, "viajantexlocalidad")
        Dim tb5 As DataTable = ds5.Tables.Item(0)
        Dim filabuscada5() As DataRow
        Dim criterio5 As String = "idlocalidad=" & idLocalidad

        filabuscada5 = tb5.Select(criterio5)

        If (filabuscada5.GetUpperBound(0) <> -1) Then
            strValidacion += "Existe asociaciones con viajantes registradas a nombre de esta Localidad"
        End If

        return strValidacion

    End Function

    Public Sub tomarDatos(ByVal idp As Integer, ByVal codigop As String, ByVal zonap As String, ByVal provinciap As String, _
        ByVal distanciap As String, ByVal nombrep As String, ByVal idprovinciap As Integer)

        varCancelar = 0
        id() = idp
        codigo() = codigop
        zona() = zonap
        provinciaAbrev() = provinciap
        distancia() = distanciap
        nombre() = nombrep
        provinciaId() = idprovinciap
    End Sub

    Public Sub mostrarDatos(ByRef txtcodigo As String, ByRef txtzona As String, ByRef txtprovincia As String, ByRef txtdistancia As String, _
    ByRef txtnombre As String, ByRef cboprovincia As Integer)
        txtcodigo = codigoLocalidad
        txtzona = zonaLocalidad
        txtprovincia = provinciaAbrev
        txtdistancia = distanciaLocalidad
        txtnombre = nombreLocalidad
        cboprovincia = provinciaId
    End Sub

    'Public Function validarLocalidad(ByVal dscl As DataSet) As Boolean
    '    Dim tbLocalidad As DataTable = dscl.Tables.Item(0)
    '    Dim cfilas As DataRowCollection = tbLocalidad.Rows
    '    Dim filabuscada() As DataRow
    '    Dim criterio As String = "documento=" & documentoLocalidad & " and idtipodocumento=" & idtipodocLocalidad
    '    'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

    '    filabuscada = tbLocalidad.Select(criterio)

    '    If (filabuscada.GetUpperBound(0) = -1) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
End Class
