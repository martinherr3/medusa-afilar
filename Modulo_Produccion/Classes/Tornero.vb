Public Class Tornero
    Private idTornero As Integer
    Private nombreTornero As String
    Private apellidoTornero As String
    Private direccionTornero As String
    Private telefonoTornero As String
    Private celularTornero As String
    Private cantidadTorneado As Integer
    Private efectividadTorneado As Double
    Private observacionesTorneado As String
    Public varCancelar As Integer
    Private adaptadorTornero As SqlClient.SqlDataAdapter

    Public Property id() As Integer
        Get
            Return idTornero
        End Get
        Set(ByVal Value As Integer)
            idTornero = Value
        End Set
    End Property
    Private Property nombre() As String
        Get
            Return nombreTornero
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                nombreTornero = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property apellido() As String
        Get
            Return apellidoTornero
        End Get
        Set(ByVal Value As String)
            If Len(Value) > 0 Then
                apellidoTornero = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Private Property direccion() As String
        Get
            Return direccionTornero
        End Get
        Set(ByVal Value As String)
            direccionTornero = Value
        End Set
    End Property
    Private Property telefono() As String
        Get
            Return telefonoTornero
        End Get
        Set(ByVal Value As String)
            telefonoTornero = Value
        End Set
    End Property
    Private Property celular() As String
        Get
            Return celularTornero
        End Get
        Set(ByVal Value As String)
            celularTornero = Value
        End Set
    End Property
    Private Property cantidad() As Integer
        Get
            Return cantidadTorneado
        End Get
        Set(ByVal Value As Integer)
            cantidadTorneado = Value
        End Set
    End Property
    Private Property efectividad() As Double
        Get
            Return efectividadTorneado
        End Get
        Set(ByVal Value As Double)
            efectividadTorneado = Value
        End Set
    End Property
    Private Property observaciones() As String
        Get
            Return observacionesTorneado
        End Get
        Set(ByVal Value As String)
            observacionesTorneado = Value
        End Set
    End Property

    Public Function cargarDSTornero(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorTornero = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsTornero As New DataSet("dsTornero")
        adaptadorTornero.Fill(dsTornero, "Tornero")
        Return dsTornero
    End Function

    'para los 3 siguientes metodos es posible usar el updatecommand directamente
    'lo optimo seria hacerlo al cerrar el formulario para que cumpla con ser off-line
    Public Sub nuevoTornero(ByVal dscl As DataSet)
        Dim tbTornero As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbTornero.Select("idtornero=max(idtornero)")
        Dim nuevafila As DataRow
        nuevafila = tbTornero.NewRow()
        nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

        Try


            nuevafila(1) = ""
            nuevafila(2) = ""
            nuevafila(3) = ""
            nuevafila(4) = ""
            nuevafila(5) = ""
            nuevafila(6) = 0
            nuevafila(7) = 0
            nuevafila(8) = ""



            dscl.Tables(0).Rows.Add(nuevafila)


        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarTornero(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbTornero As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbTornero.Select("idtornero=max(idtornero)")
            Dim nuevafila As DataRow
            nuevafila = tbTornero.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = nombreTornero
            nuevafila(2) = apellidoTornero
            nuevafila(3) = direccionTornero
            nuevafila(4) = telefonoTornero
            nuevafila(5) = celularTornero
            nuevafila(6) = cantidadTorneado
            nuevafila(7) = efectividadTorneado
            nuevafila(8) = observacionesTorneado


            tbTornero.Rows.Add(nuevafila)



            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTornero)
            adaptadorTornero.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorTornero.Update(dscl, "Tornero")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarTornero(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbTornero As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbTornero.Rows
                If updatefila(0) = idTornero Then
                    updatefila(1) = nombreTornero
                    updatefila(2) = apellidoTornero
                    updatefila(3) = direccionTornero
                    updatefila(4) = telefonoTornero
                    updatefila(5) = celularTornero
                    updatefila(6) = cantidadTorneado
                    updatefila(7) = efectividadTorneado
                    updatefila(8) = observacionesTorneado
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTornero)
            adaptadorTornero.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorTornero.Update(dscl, "Tornero")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarTornero(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Tornero") Then

            Dim dsTorneado As New DataSet
            Dim adaptadorTorneado As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select idtornero from torneado group by idtornero", cnn)
            adaptadorTorneado.Fill(dsTorneado, "Torneado")
            Dim tbTorneroTorneado As DataTable = dsTorneado.Tables.Item(0)
            Dim cfilas As DataRowCollection = tbTorneroTorneado.Rows
            Dim filabuscada() As DataRow
            Dim criterio As String = "idTornero=" & idTornero

            filabuscada = tbTorneroTorneado.Select(criterio)

            If (filabuscada.GetUpperBound(0) <> -1) Then
                MessageBox.Show("Existen trabajos de Torneado registrados a nombre de este Tornero", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbTornero As DataTable = dscl.Tables.Item(0)
            For i As Integer = 0 To tbTornero.Rows.Count - 1
                If tbTornero.Rows(i)(0) = idTornero Then
                    tbTornero.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTornero)
                adaptadorTornero.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorTornero.Update(dscl, "Tornero")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub tomarDatos(ByVal idp As Integer, ByVal nombrep As String, ByVal apellidop As String, ByVal direccionp As String, _
        ByVal telefonop As String, ByVal celularp As String, ByVal cantidadp As Integer, ByVal efectividadp As Double, ByVal observacionesp As String)
        varCancelar = 0
        id() = idp
        nombre() = nombrep
        apellido() = apellidop
        direccion() = direccionp
        telefono() = telefonop
        celular() = celularp
        cantidad() = cantidadp
        efectividad() = efectividadp
        observaciones() = observacionesp

    End Sub

    Public Sub mostrarDatos(ByRef txtnombre As String, ByRef txtapellido As String, ByRef txtdomicilio As String, ByRef txttelefono As String, ByRef txtcelular As String, _
    ByRef txtcantidad As String, ByRef txtefectividad As String, ByRef txtobservaciones As String)
        txtnombre = nombreTornero
        txtapellido = apellidoTornero
        txtdomicilio = direccionTornero
        txttelefono = telefonoTornero
        txtcelular = celularTornero
        txtcantidad = cantidadTorneado
        txtefectividad = efectividadTorneado
        txtobservaciones = observacionesTorneado

    End Sub

    Public Function validarTornero(ByVal dscl As DataSet) As Boolean
        Dim tbTornero As DataTable = dscl.Tables.Item(0)
        Dim cfilas As DataRowCollection = tbTornero.Rows
        Dim filabuscada() As DataRow
        Dim criterio As String = "nombre='" & Trim(nombreTornero) & "' and apellido='" & Trim(apellidoTornero) & "'"

        filabuscada = tbTornero.Select(criterio)

        If (filabuscada.GetUpperBound(0) = -1) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
