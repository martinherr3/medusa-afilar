Public Class TipoAcabado

    Private strNombre As String
    Private strDescripcion As String
    Public varCancelar As Integer
    Private adaptadorTAcabado As SqlClient.SqlDataAdapter

    

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

    Public Function cargarDSTAcabado(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet
        'Prueba SourceSafe
        adaptadorTAcabado = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsTAcabado As New DataSet("dsTAcabado")
        adaptadorTAcabado.Fill(dsTAcabado, "TAcabado")
        Return dsTAcabado
    End Function

    Public Sub registrarTAcabado(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            '
            Dim dsTA As New DataSet
            Dim adaptadorTA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select nombre from tipoacabado where nombre = '" & strNombre & "'", cnn)
            adaptadorTA.Fill(dsTA, "TA")
            Dim tbTA As DataTable = dsTA.Tables.Item(0)

            If (tbTA.Rows.Count <> 0) Then
                MessageBox.Show("Existen modelos de fresa relacionadas con este tipo", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If
            '

            Dim tbTAcabado As DataTable = dscl.Tables.Item(0)

            Dim nuevafila As DataRow
            nuevafila = tbTAcabado.NewRow()
            nuevafila(0) = Nombre
            nuevafila(1) = Descripcion

            tbTAcabado.Rows.Add(nuevafila)

            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTAcabado)
            adaptadorTAcabado.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorTAcabado.Update(dscl, "TAcabado")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarTAcabado(ByVal dscl As DataSet)
        'If varCancelar <> 1 Then
        '    Dim tbTAcabado As DataTable = dscl.Tables.Item(0)
        '    For Each updatefila As DataRow In tbTAcabado.Rows
        '        If updatefila(0) = Nombre Then
        '            updatefila(1) = Descripcion
        '        End If
        '    Next
        '    Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTAcabado)
        '    adaptadorTAcabado.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
        '    adaptadorTAcabado.Update(dscl, "TAcabado")
        'Else
        MsgBox("Modificacion no autorizada", MsgBoxStyle.Critical, "Control de datos")
        'End If
    End Sub

    'COMPROBAR LA ELIMINACION

    Public Sub eliminarTAcabado(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar Tipo de Acabado") Then

            Dim dsModeloFresa As New DataSet
            Dim adaptadorModeloFresa As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select tipoacabado from modelofresa where tipoacabado = '" & strNombre & "'", cnn)
            adaptadorModeloFresa.Fill(dsModeloFresa, "ModeloFresa")
            Dim tbTA As DataTable = dsModeloFresa.Tables.Item(0)
            If (tbTA.Rows.Count <> 0) Then
                MessageBox.Show("Existe modelos de fresa relacionados con este tipo de acabado", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbTAcabado As DataTable = dscl.Tables.Item(0)
            For i As Integer = 0 To tbTAcabado.Rows.Count - 1
                If tbTAcabado.Rows(i)(0) = strNombre Then
                    tbTAcabado.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorTAcabado)
                adaptadorTAcabado.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorTAcabado.Update(dscl, "TAcabado")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub tomarDatos(ByVal nombrep As String, ByVal descripcionp As String)
        varCancelar = 0
        Nombre() = nombrep
        Descripcion() = descripcionp
    End Sub

    Public Sub mostrarDatos(ByRef txtnombre As String, ByRef txtDescripcion As String)
        txtnombre = Nombre
        txtDescripcion = Descripcion
    End Sub
End Class
