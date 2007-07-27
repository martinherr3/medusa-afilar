Public Class tipoMaquina
    Private intId As Integer
    Private strNombre As String
    Private strDescripcion As String
    Public varCancelar As Integer
    Private adaptadorTMaquina As SqlClient.SqlDataAdapter

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

    Public Function cargarDSTMaquina(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet
        adaptadorTMaquina = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsTMaquina As New DataSet("dsTMaquina")
        adaptadorTMaquina.Fill(dsTMaquina, "TMaquina")
        Return dsTMaquina
    End Function

    Public Sub registrarTMaquina(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            '
            Dim dsTM As New DataSet
            Dim adaptadorTM As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select nombre as cant from tipomaquina where nombre = '" & strNombre & "'", cnn)
            adaptadorTM.Fill(dsTM, "TM")
            Dim tbTM As DataTable = dsTM.Tables.Item(0)

            If (tbTM.Rows.Count <> 0) Then
                MessageBox.Show("Existen Maquinas relacionadas con este tipo", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If
            '
            Dim tbTMaquina As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbTMaquina.Select("idtipo=max(idtipo)")
            Dim nuevafila As DataRow
            nuevafila = tbTMaquina.NewRow()
            nuevafila(2) = CType(idmaximo(0).Item(2), Integer) + 1

            nuevafila(0) = Nombre
            nuevafila(1) = Descripcion

            tbTMaquina.Rows.Add(nuevafila)

            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTMaquina)
            adaptadorTMaquina.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorTMaquina.Update(dscl, "TMaquina")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarTMaquina(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim dsTM As New DataSet
            Dim adaptadorTM As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select nombre as cant from tipomaquina where nombre = '" & strNombre & "'", cnn)
            adaptadorTM.Fill(dsTM, "TM")
            Dim tbTM As DataTable = dsTM.Tables.Item(0)

            If (tbTM.Rows.Count <> 0) Then
                MessageBox.Show("Existen Maquinas relacionadas con este tipo", "Modificacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbTMaquina As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbTMaquina.Rows
                If updatefila(2) = Id Then
                    updatefila(0) = Nombre
                    updatefila(1) = Descripcion
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTMaquina)
            adaptadorTMaquina.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorTMaquina.Update(dscl, "TMaquina")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarTMaquina(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Cargo") Then

            Dim dsMaquina As New DataSet
            Dim adaptadorMaquina As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select distinct idmaquina from maquina", cnn)
            adaptadorMaquina.Fill(dsMaquina, "Maquina")
            Dim tbTMaquinaPedido As DataTable = dsMaquina.Tables.Item(0)
            Dim filabuscada() As DataRow
            Dim criterio As String = "idmaquina=" & Id

            filabuscada = tbTMaquinaPedido.Select(criterio)

            If (filabuscada.GetUpperBound(0) <> -1) Then
                MessageBox.Show("Existen Maquinas relacionadas con este tipo", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbTMaquina As DataTable = dscl.Tables.Item(0)
            For i As Integer = 0 To tbTMaquina.Rows.Count - 1
                If tbTMaquina.Rows(i)(2) = Id Then
                    tbTMaquina.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTMaquina)
                adaptadorTMaquina.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorTMaquina.Update(dscl, "TMaquina")
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
