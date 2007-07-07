Public Class UnidadDeMedida
    Private intId As Integer
    Private strNombre As String
    Private strDescripcion As String
    Private strAbreviacion As String
    Private strEscala As String
    Public varCancelar As Integer
    Private adaptadorUnidadDeMedida As SqlClient.SqlDataAdapter

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

    Public Property Abreviacion() As String
        Get
            Return strAbreviacion
        End Get
        Set(ByVal value As String)
            strAbreviacion = value
        End Set
    End Property

    Public Property Escala() As String
        Get
            Return strEscala
        End Get
        Set(ByVal value As String)
            strEscala = value
        End Set
    End Property

    Public Function cargarDSUnidadDeMedida(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorUnidadDeMedida = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsUnidadDeMedida As New DataSet("dsUnidadDeMedida")
        adaptadorUnidadDeMedida.Fill(dsUnidadDeMedida, "UnidadDeMedida")
        Return dsUnidadDeMedida
    End Function

    'para los 3 siguientes metodos es posible usar el updatecommand directamente
    'lo optimo seria hacerlo al cerrar el formulario para que cumpla con ser off-line
    'Public Sub nuevoUnidadDeMedida(ByVal dscl As DataSet)
    '    Dim tbUnidadDeMedida As DataTable = dscl.Tables.Item(0)

    '    Dim idmaximo() As DataRow
    '    idmaximo = tbUnidadDeMedida.Select("idUnidadDeMedida=max(idUnidadDeMedida)")
    '    Dim nuevafila As DataRow
    '    nuevafila = tbUnidadDeMedida.NewRow()
    '    nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

    '    Try


    '        nuevafila(1) = ""
    '        nuevafila(2) = ""

    '        dscl.Tables(0).Rows.Add(nuevafila)

    '    Catch ex As System.Data.ConstraintException
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub registrarUnidadDeMedida(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbUnidadDeMedida As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbUnidadDeMedida.Select("idUnidadMedida=max(idUnidadMedida)")
            Dim nuevafila As DataRow
            nuevafila = tbUnidadDeMedida.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = Nombre
            nuevafila(2) = Descripcion
            nuevafila(3) = Abreviacion
            nuevafila(4) = Escala

            tbUnidadDeMedida.Rows.Add(nuevafila)

            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorUnidadDeMedida)
            adaptadorUnidadDeMedida.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorUnidadDeMedida.Update(dscl, "UnidadDeMedida")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarUnidadDeMedida(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbUnidadDeMedida As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbUnidadDeMedida.Rows
                If updatefila(0) = Id Then
                    updatefila(1) = Nombre
                    updatefila(2) = Descripcion
                    updatefila(3) = Abreviacion
                    updatefila(4) = Escala
                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorUnidadDeMedida)
            adaptadorUnidadDeMedida.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorUnidadDeMedida.Update(dscl, "UnidadDeMedida")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub eliminarUnidadDeMedida(ByVal dscl As DataSet)
        If 6 = MsgBox("Esta seguro que desea eliminarlo", MsgBoxStyle.YesNo, "Eliminar UnidadDeMedida") Then

            Dim dsTiposdeMateriaPrima As New DataSet
            Dim adaptadorLocalidad As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select distinct idUnidadMedida from tipomateriaprima", cnn)
            adaptadorLocalidad.Fill(dsTiposdeMateriaPrima, "tipomateriaprima")
            Dim tbUnidadDeMedidaPedido As DataTable = dsTiposdeMateriaPrima.Tables.Item(0)
            'Dim cfilas As DataRowCollection = tbUnidadDeMedidaPedido.Rows
            Dim filabuscada() As DataRow
            Dim criterio As String = "idUnidadMedida=" & Id

            filabuscada = tbUnidadDeMedidaPedido.Select(criterio)

            If (filabuscada.GetUpperBound(0) <> -1) Then
                MessageBox.Show("Existe Tipos de Materias Primas registradas a nombre de esta Unidad De Medida", "Eliminacion no autorizada", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim tbUnidadDeMedida As DataTable = dscl.Tables.Item(0)
            For i As Integer = 0 To tbUnidadDeMedida.Rows.Count - 1
                If tbUnidadDeMedida.Rows(i)(0) = Id Then
                    tbUnidadDeMedida.Rows(i).Delete()
                End If
            Next
            Try
                Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorUnidadDeMedida)
                adaptadorUnidadDeMedida.DeleteCommand = oCommandBuilder_OC.GetDeleteCommand
                adaptadorUnidadDeMedida.Update(dscl, "UnidadDeMedida")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub tomarDatos(ByVal idp As Integer, ByVal nombrep As String, ByVal descripcionp As String, ByVal abreviacionp As String, ByVal escalap As String)
        varCancelar = 0
        Id() = idp
        Nombre() = nombrep
        Descripcion() = descripcionp
        Abreviacion() = abreviacionp
        Escala() = escalap
    End Sub

    Public Sub mostrarDatos(ByRef txtnombre As String, ByRef txtDescripcion As String, ByRef txtAbreviacion As String, ByRef txtEscala As String)
        txtnombre = Nombre
        txtDescripcion = Descripcion
        txtAbreviacion = Abreviacion
        txtEscala = Escala
    End Sub
End Class
