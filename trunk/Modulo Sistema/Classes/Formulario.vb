Public Class Formulario
    Private idformulario As Integer
    Private descripcionform As String
    Private idmodulo As Integer
    Private nombreform As String
    Private idmenu As Integer
    Private activo As Boolean
    Public varCancelar As Integer
    Private adaptadorform As SqlClient.SqlDataAdapter

    Private Property id() As Integer
        Get
            Return idformulario
        End Get
        Set(ByVal Value As Integer)
            idformulario = Value
        End Set
    End Property
    Private Property descripcion() As String
        Get
            Return descripcionform
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                descripcionform = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property modulo() As Integer
        Get
            Return idmodulo
        End Get
        Set(ByVal Value As Integer)
            idmodulo = Value
        End Set
    End Property
    Private Property nombre() As String
        Get
            Return nombreform
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                nombreform = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property menu() As Integer
        Get
            Return idmenu
        End Get
        Set(ByVal Value As Integer)
            idmenu = Value
        End Set
    End Property
    Private Property estado() As Boolean
        Get
            Return activo
        End Get
        Set(ByVal Value As Boolean)
            activo = Value
        End Set
    End Property
    Public Function cargarDSFormulario(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorform = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsformulario As New DataSet("dsformulario")
        adaptadorform.Fill(dsformulario, "formulario")
        Return dsformulario
    End Function

    Public Sub nuevoFormulario(ByVal dsfrm As DataSet)
        Dim tbformulario As DataTable = dsfrm.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbformulario.Select("idformulario=max(idformulario)")
        Dim nuevafila As DataRow
        nuevafila = tbformulario.NewRow()
        nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

        Try
            nuevafila(1) = ""
            nuevafila(2) = 0
            nuevafila(3) = ""
            nuevafila(4) = 0
            nuevafila(5) = True
            dsfrm.Tables(0).Rows.Add(nuevafila)
        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarFormulario(ByVal dsfrm As DataSet)
        If varCancelar <> 1 Then
            Dim tbformulario As DataTable = dsfrm.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbformulario.Select("idformulario=max(idformulario)")
            Dim nuevafila As DataRow
            nuevafila = tbformulario.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = descripcionform
            nuevafila(2) = idmodulo
            nuevafila(3) = nombreform
            nuevafila(4) = idmenu
            nuevafila(5) = activo

            tbformulario.Rows.Add(nuevafila)

            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorform)
            adaptadorform.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorform.Update(dsfrm, "formulario")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarFormulario(ByVal dsfrm As DataSet)
        If varCancelar <> 1 Then
            Dim tbformulario As DataTable = dsfrm.Tables.Item(0)
            For Each updatefila As DataRow In tbformulario.Rows
                If updatefila(0) = idformulario Then
                    updatefila(1) = descripcionform
                    updatefila(2) = idmodulo
                    updatefila(3) = nombreform
                    updatefila(4) = idmenu
                    updatefila(5) = activo
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorform)
            adaptadorform.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorform.Update(dsfrm, "formulario")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarformulario(ByVal dsfrm As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Formulario") Then

            Dim dsformulario As New DataSet
            Dim adaptadorfrm As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idformulario from formulario", cnn)
            adaptadorfrm.Fill(dsformulario, "formulario")
            Dim tbformulario As DataTable = dsfrm.Tables.Item(0)
            For i As Integer = 0 To tbformulario.Rows.Count - 1
                If tbformulario.Rows(i)(0) = idformulario Then
                    tbformulario.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorform)
                adaptadorform.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorform.Update(dsfrm, "formulario")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub tomarDatos(ByVal idform As Integer, ByVal descripcionf As String, ByVal idmodulo As Integer, _
    ByVal nombref As String, ByVal idmenu As Integer, ByVal activo As Boolean)
        varCancelar = 0
        id() = idform
        descripcion() = descripcionf
        modulo() = idmodulo
        nombre() = nombref
        menu() = idmenu
        estado() = activo
    End Sub

    Public Sub mostrarDatos(ByRef txtid As String, ByRef txtdescripcion As String, ByRef cmbidmodulo As Integer, _
    ByRef txtnombre As String, ByRef cmbidmenu As Integer, ByRef checkactivo As Boolean)
        txtid = id
        txtdescripcion = descripcionform
        cmbidmodulo = idmodulo
        txtnombre = nombreform
        cmbidmenu = idmenu
        checkactivo = activo
    End Sub

    Public Function validarFormulario(ByVal dsfrm As DataSet) As Boolean
        Dim tbformulario As DataTable = dsfrm.Tables.Item(0)
        Dim cfilas As DataRowCollection = tbformulario.Rows
        Dim filabuscada() As DataRow
        Dim criterio As String = "idformulario=" & idformulario

        filabuscada = tbformulario.Select(criterio)

        If (filabuscada.GetUpperBound(0) = -1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function buscarFormulario(ByVal dsfrm As DataSet) As DataRow()
        Dim tbformulario As DataTable = dsfrm.Tables.Item(0)
        Dim cfilas As DataRowCollection = tbformulario.Rows
        Dim filabuscada() As DataRow
        Dim criterio As String = "idformulario=" & idformulario
        filabuscada = tbformulario.Select(criterio)
        Return filabuscada
    End Function
    Public Function nuevoID() As Integer
        Dim comando As New SqlClient.SqlCommand("select idformulario=max(idformulario) from formulario", cnn)
        cnn.Open()
        Dim newId As Integer
        newId = 0
        newId = comando.ExecuteScalar()
        cnn.Close()


        Return newId + 1


    End Function
End Class
