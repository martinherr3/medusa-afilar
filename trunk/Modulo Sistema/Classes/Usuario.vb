Public Class Usuario
    'Private strUsuario As String
    'Private strContraseña As String
    Private dateCreacion As Date
    Public idLegajo As Integer
    Public varCancelar As Integer
    Private adaptadorUsuario As SqlClient.SqlDataAdapter

    Public Property Usuario() As String
        Get
            Return strUsuario
        End Get
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
    Public Property Contraseña() As String
        Get
            Return strContraseña
        End Get
        Set(ByVal value As String)
            strContraseña = value
        End Set
    End Property

    Public Property Creacion() As Date
        Get
            Return dateCreacion
        End Get
        Set(ByVal value As Date)
            dateCreacion = value
        End Set
    End Property
    Public Property Legajo() As Integer
        Get
            Return idLegajo
        End Get
        Set(ByVal value As Integer)
            idLegajo = value
        End Set
    End Property
    

    Public Function cargarDSusuario(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet
        adaptadorUsuario = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsUsuario As New DataSet("dsUsuario")
        adaptadorUsuario.Fill(dsUsuario, "Usuario")
        Return dsUsuario
    End Function


    Public Sub registrarUsuario(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            If Not tieneUsuario(idLegajo) Then
                Dim tbUsuario As DataTable = dscl.Tables.Item(0)
                Dim nuevafila As DataRow
                nuevafila = tbUsuario.NewRow()
                nuevafila(0) = strUsuario

                nuevafila(1) = strContraseña
                nuevafila(2) = dateCreacion
                nuevafila(3) = idLegajo

                tbUsuario.Rows.Add(nuevafila)

                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorUsuario)
                adaptadorUsuario.InsertCommand = oCommandBuilder_OC.GetInsertCommand
                adaptadorUsuario.Update(dscl, "Usuario")
            Else
                MsgBox("El cliente ya tiene una cuenta asociada", MsgBoxStyle.Critical, "Control de datos")
            End If
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarUsuario(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbUsuario As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbUsuario.Rows
                If updatefila(3) = idLegajo Then
                    updatefila(0) = strUsuario
                    updatefila(1) = strContraseña
                    updatefila(2) = dateCreacion
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorUsuario)
            adaptadorUsuario.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorUsuario.Update(dscl, "Usuario")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarUsuario(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Usuario") Then
            Dim tbUsuario As DataTable = dscl.Tables.Item(0)
            Dim fila As DataRow
            For Each fila In tbUsuario.Rows
                If fila(3) = idLegajo Then
                    fila.Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorUsuario)
                adaptadorUsuario.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorUsuario.Update(dscl, "Usuario")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub tomarDatos(ByVal usu As String, ByVal contra As String, ByVal creac As Date, ByVal leg As Integer)
        varCancelar = 0
        Usuario() = usu
        Contraseña() = contra
        Creacion() = creac
        Legajo() = leg
    End Sub

    Public Sub mostrarDatos(ByRef txtUsuario As String, ByRef txtContraseña As String, ByRef txtCreacion As Date)
        txtUsuario = Usuario
        txtContraseña = Contraseña
        txtCreacion = Creacion
    End Sub
    Public Function tieneUsuario(ByVal idlegajo As Integer) As Boolean
        Dim comando As New SqlClient.SqlCommand("select idlegajo from cuentausuario where idlegajo = " & idlegajo, cnn)
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim ban As Integer
        ban = 0
        ban = comando.ExecuteScalar()
        cnn.Close()
        If ban = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function getCliente(ByVal idlegajo As Integer) As String
        Dim comando As New SqlClient.SqlCommand("select  rtrim(apellido) + ', ' + rtrim(nombre) as nombre  from empleado where idlegajo = " & idlegajo, cnn)
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Return comando.ExecuteScalar()
        cnn.Close()
    End Function
End Class
