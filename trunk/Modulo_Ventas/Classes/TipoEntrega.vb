Public Class formadeentrega
    Private intId As Integer
    Private strNombre As String
    Private strDescripcion As String
    Public varCancelar As Integer
    Private adaptadorformadeentrega As SqlClient.SqlDataAdapter

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

    Public Function cargarDSformadeentrega(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet
        Try
            adaptadorformadeentrega = New SqlClient.SqlDataAdapter(consulta, conexion)
            Dim dsformadeentrega As New DataSet("dsformadeentrega")
            adaptadorformadeentrega.Fill(dsformadeentrega, "formadeentrega")
            Return dsformadeentrega
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub registrarformadeentrega(ByVal dscl As DataSet)
        Try
            If varCancelar <> 1 Then
                Dim tbformadeentrega As DataTable = dscl.Tables.Item(0)

                Dim idmaximo() As DataRow
                idmaximo = tbformadeentrega.Select("idformadeentrega=max(idformadeentrega)")
                Dim nuevafila As DataRow
                nuevafila = tbformadeentrega.NewRow()
                nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

                nuevafila(1) = Nombre
                nuevafila(2) = Descripcion

                tbformadeentrega.Rows.Add(nuevafila)

                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorformadeentrega)
                adaptadorformadeentrega.InsertCommand = oCommandBuilder_OC.GetInsertCommand
                adaptadorformadeentrega.Update(dscl, "formadeentrega")
            Else
                MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificarformadeentrega(ByVal dscl As DataSet)
        Try
            If varCancelar <> 1 Then
                Dim tbformadeentrega As DataTable = dscl.Tables.Item(0)
                For Each updatefila As DataRow In tbformadeentrega.Rows
                    If updatefila(0) = Id Then
                        updatefila(1) = Nombre
                        updatefila(2) = Descripcion
                    End If
                Next
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorformadeentrega)
                adaptadorformadeentrega.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
                adaptadorformadeentrega.Update(dscl, "formadeentrega")
            Else
                MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub eliminarformadeentrega(ByVal dscl As DataSet)
        Try
            If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar forma de entrega") Then

                Dim dsPedidos As New DataSet
                Dim adaptadorPedido As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select distinct idformadeentrega from pedido", cnn)
                adaptadorPedido.Fill(dsPedidos, "Pedido")
                Dim tbformadeentregaPedido As DataTable = dsPedidos.Tables.Item(0)
                'Dim cfilas As DataRowCollection = tbformadeentregaPedido.Rows
                Dim filabuscada() As DataRow
                Dim criterio As String = "idformadeentrega=" & Id

                filabuscada = tbformadeentregaPedido.Select(criterio)

                If (filabuscada.GetUpperBound(0) <> -1) Then
                    MessageBox.Show("Existe Pedidos registradas a nombre de esta forma de entrega", "Eliminacion no autorizada", MessageBoxButtons.OK)
                    Exit Sub
                End If

                Dim tbformadeentrega As DataTable = dscl.Tables.Item(0)
                For i As Integer = 0 To tbformadeentrega.Rows.Count - 1
                    If tbformadeentrega.Rows(i)(0) = Id Then
                        tbformadeentrega.Rows(i).Delete()
                    End If
                Next
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorformadeentrega)
                adaptadorformadeentrega.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorformadeentrega.Update(dscl, "formadeentrega")
            End If
        Catch ex As Exception
            Throw ex
        End Try
        
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
