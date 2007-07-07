Public Class Cargo
    Private intId As Integer
    Private strNombre As String
    Private strDescripcion As String
    Public varCancelar As Integer
    Private adaptadorCargo As SqlClient.SqlDataAdapter

    Public Property Id() As Integer
        Get
            Return intId
        End Get
        Set(ByVal value As Integer)
            intId = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return strDescripcion
        End Get
        Set(ByVal value As String)
            strDescripcion = value
        End Set
    End Property

    Public Function cargarDSCargo(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet
        'Prueba SourceSafe
        adaptadorCargo = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsCargo As New DataSet("dsCargo")
        adaptadorCargo.Fill(dsCargo, "Cargo")
        Return dsCargo
    End Function

    'para los 3 siguientes metodos es posible usar el updatecommand directamente
    'lo optimo seria hacerlo al cerrar el formulario para que cumpla con ser off-line
    'Public Sub nuevoProvincia(ByVal dscl As DataSet)
    '    Dim tbProvincia As DataTable = dscl.Tables.Item(0)

    '    Dim idmaximo() As DataRow
    '    idmaximo = tbProvincia.Select("idprovincia=max(idprovincia)")
    '    Dim nuevafila As DataRow
    '    nuevafila = tbProvincia.NewRow()
    '    nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

    '    Try


    '        nuevafila(1) = ""
    '        nuevafila(2) = ""

    '        dscl.Tables(0).Rows.Add(nuevafila)

    '    Catch ex As System.Data.ConstraintException
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub registrarCargo(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbCargo As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbCargo.Select("idcargo=max(idcargo)")
            Dim nuevafila As DataRow
            nuevafila = tbCargo.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = Nombre
            nuevafila(2) = Descripcion

            tbCargo.Rows.Add(nuevafila)

            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorCargo)
            adaptadorCargo.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorCargo.Update(dscl, "Cargo")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarCargo(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbCargo As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbCargo.Rows
                If updatefila(0) = Id Then
                    updatefila(1) = Nombre
                    updatefila(2) = Descripcion
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorCargo)
            adaptadorCargo.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorCargo.Update(dscl, "Cargo")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    'COMPROBAR LA ELIMINACION

    Public Sub eliminarCargo(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Cargo") Then

            Dim dsEmpleados As New DataSet
            Dim adaptadorEmpleado As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select distinct idcargo from empleado", cnn)
            adaptadorEmpleado.Fill(dsEmpleados, "Empleado")
            Dim tbCargoPedido As DataTable = dsEmpleados.Tables.Item(0)
            'Dim cfilas As DataRowCollection = tbProvinciaPedido.Rows
            Dim filabuscada() As DataRow
            Dim criterio As String = "idcargo=" & Id

            filabuscada = tbCargoPedido.Select(criterio)

            If (filabuscada.GetUpperBound(0) <> -1) Then
                MessageBox.Show("Existe Empleados registrados a nombre de este Cargo", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbCargo As DataTable = dscl.Tables.Item(0)
            For i As Integer = 0 To tbCargo.Rows.Count - 1
                If tbCargo.Rows(i)(0) = Id Then
                    tbCargo.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorCargo)
                adaptadorCargo.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorCargo.Update(dscl, "Cargo")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub tomarDatos(ByVal idp As Integer, ByVal nombrep As String, ByVal descripcionp As String)
        varCancelar = 0
        Id() = idp
        Nombre() = nombrep
        Descripcion() = descripcionp
    End Sub

    Public Sub mostrarDatos(ByRef txtnombre As String, ByRef txtDescripcion As String)
        txtnombre = Nombre
        txtDescripcion = Descripcion
    End Sub
End Class
