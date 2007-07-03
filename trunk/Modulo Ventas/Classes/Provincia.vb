Public Class Provincia
    Private intId As Integer
    Private strNombre As String
    Private strDescripcion As String
    Public varCancelar As Integer
    Private adaptadorProvincia As SqlClient.SqlDataAdapter

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

    Public Function cargarDSProvincia(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorProvincia = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsProvincia As New DataSet("dsProvincia")
        adaptadorProvincia.Fill(dsProvincia, "Provincia")
        Return dsProvincia
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

    Public Sub registrarProvincia(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbProvincia As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbProvincia.Select("idprovincia=max(idprovincia)")
            Dim nuevafila As DataRow
            nuevafila = tbProvincia.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = Nombre
            nuevafila(2) = Descripcion

            tbProvincia.Rows.Add(nuevafila)

            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorProvincia)
            adaptadorProvincia.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorProvincia.Update(dscl, "Provincia")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarProvincia(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbProvincia As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbProvincia.Rows
                If updatefila(0) = Id Then
                    updatefila(1) = Nombre
                    updatefila(2) = Descripcion
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorProvincia)
            adaptadorProvincia.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorProvincia.Update(dscl, "Provincia")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarProvincia(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Provincia") Then

            Dim dsLocalidades As New DataSet
            Dim adaptadorLocalidad As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select distinct idprovincia from localidad", cnn)
            adaptadorLocalidad.Fill(dsLocalidades, "Localidad")
            Dim tbProvinciaPedido As DataTable = dsLocalidades.Tables.Item(0)
            'Dim cfilas As DataRowCollection = tbProvinciaPedido.Rows
            Dim filabuscada() As DataRow
            Dim criterio As String = "idprovincia=" & Id

            filabuscada = tbProvinciaPedido.Select(criterio)

            If (filabuscada.GetUpperBound(0) <> -1) Then
                MessageBox.Show("Existe Localidades registradas a nombre de esta Provincia", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbProvincia As DataTable = dscl.Tables.Item(0)
            For i As Integer = 0 To tbProvincia.Rows.Count - 1
                If tbProvincia.Rows(i)(0) = Id Then
                    tbProvincia.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorProvincia)
                adaptadorProvincia.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorProvincia.Update(dscl, "Provincia")
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
