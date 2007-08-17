Imports System.Data.SqlClient
Public Class Mensajeria

    Private intIdMensaje As Integer
    Private strAsunto As String
    Private intIdRemitente As Integer
    Private intIdDestinatario As Integer
    Private strMensaje As String
    Private intPrioridad As Integer
    Private boolLeido As Boolean
    Private dateFechaRecepion As Date
    Private dateFechaLectura As Date
    Public varCancelar As Integer
    Private adaptadorMensaje As SqlClient.SqlDataAdapter

    Public Property IdMensaje() As Integer
        Get
            Return intIdMensaje
        End Get
        Set(ByVal value As Integer)
            intIdMensaje = value
        End Set
    End Property

    Public Property Asunto() As String
        Get
            Return strAsunto
        End Get
        Set(ByVal value As String)
            strAsunto = value
        End Set
    End Property
    Public Property IdRemitente() As Integer
        Get
            Return intIdRemitente
        End Get
        Set(ByVal value As Integer)
            intIdRemitente = value
        End Set
    End Property
    Public Property IdDestinatario() As Integer
        Get
            Return intIdDestinatario
        End Get
        Set(ByVal value As Integer)
            intIdDestinatario = value
        End Set
    End Property
    Public Property Mensaje() As Integer
        Get
            Return strMensaje
        End Get
        Set(ByVal value As Integer)
            strMensaje = value
        End Set
    End Property
    Public Property Prioridad() As Integer
        Get
            Return intPrioridad
        End Get
        Set(ByVal value As Integer)
            intPrioridad = value
        End Set
    End Property
    Public Property Leido() As Boolean
        Get
            Return boolLeido
        End Get
        Set(ByVal value As Boolean)
            boolLeido = value
        End Set
    End Property
    Public Property FechaRecepion() As Date
        Get
            Return dateFechaRecepion
        End Get
        Set(ByVal Value As Date)
            If Len(Value) > 0 Then
                dateFechaRecepion = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property
    Public Property FechaLectura() As Date
        Get
            Return dateFechaLectura
        End Get
        Set(ByVal Value As Date)
            If Len(Value) > 0 Then
                dateFechaLectura = Value
            Else
                varCancelar = 1
            End If
        End Set
    End Property

    

    Public Shared Sub getMensajes(ByVal legajo As Integer, ByRef link As System.Windows.Forms.LinkLabel)
        Dim conn As SqlConnection
        conn = cnn

        conn.Open()

        Dim sql As String = "select count(*), max(prioridad) from mensaje where leido = 'false' and iddestinatario = " & legajo
        Dim comm As New SqlCommand(sql, conn)

        Dim DA As New SqlDataAdapter(comm)
        Dim DS As New DataSet
        DA.Fill(DS)
        If DS.Tables(0).Rows(0).Item(0) <> 0 Then
            link.Text = "Usted tiene " & DS.Tables(0).Rows(0).Item(0) & " mensajes sin leer"
        Else
            link.Text = "0 Mensajes Nuevos"
        End If

        conn.Close()
    End Sub

    '-------------------------------------------------------------------
    Public Function cargarDSMensajes(ByVal consulta As String, ByVal conexion As SqlClient.SqlConnection) As DataSet

        adaptadorMensaje = New SqlClient.SqlDataAdapter(consulta, conexion)
        Dim dsMensaje As New DataSet("dsMensaje")
        adaptadorMensaje.Fill(dsMensaje, "Mensaje")
        Return dsMensaje
    End Function


    Public Sub nuevoMensaje(ByVal dscl As DataSet)
        Dim tbMensaje As DataTable = dscl.Tables.Item(0)

        Dim idmaximo() As DataRow
        idmaximo = tbMensaje.Select("idMensaje=max(idMensaje)")
        Dim nuevafila As DataRow
        nuevafila = tbMensaje.NewRow()
        nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

        Try


            nuevafila(1) = ""
            nuevafila(2) = 0
            nuevafila(3) = 0
            nuevafila(4) = ""
            nuevafila(5) = 1
            nuevafila(6) = False
            nuevafila(7) = ""
            nuevafila(8) = ""

            dscl.Tables(0).Rows.Add(nuevafila)


        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarMensaje(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbMensaje As DataTable = dscl.Tables.Item(0)

            Dim idmaximo() As DataRow
            idmaximo = tbMensaje.Select("idMensaje=max(idMensaje)")
            Dim nuevafila As DataRow
            nuevafila = tbMensaje.NewRow()
            nuevafila(0) = CType(idmaximo(0).Item(0), Integer) + 1

            nuevafila(1) = strAsunto
            nuevafila(2) = intIdRemitente
            nuevafila(3) = intIdDestinatario
            nuevafila(4) = strMensaje
            nuevafila(5) = intPrioridad
            nuevafila(6) = False
            nuevafila(7) = dateFechaRecepion
            nuevafila(8) = dateFechaLectura


            tbMensaje.Rows.Add(nuevafila)



            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorMensaje)
            adaptadorMensaje.InsertCommand = oCommandBuilder_OC.GetInsertCommand
            adaptadorMensaje.Update(dscl, "Mensaje")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub modificarMensaje(ByVal dscl As DataSet)
        If varCancelar <> 1 Then
            Dim tbMensaje As DataTable = dscl.Tables.Item(0)
            For Each updatefila As DataRow In tbMensaje.Rows
                If updatefila(0) = intIdMensaje Then
                    updatefila(1) = strAsunto
                    updatefila(2) = intIdRemitente
                    updatefila(3) = intIdDestinatario
                    updatefila(4) = strMensaje
                    updatefila(5) = intPrioridad
                    updatefila(6) = boolLeido
                    updatefila(7) = dateFechaRecepion
                    updatefila(8) = dateFechaLectura


                End If
            Next
            Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorMensaje)
            adaptadorMensaje.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
            adaptadorMensaje.Update(dscl, "Mensaje")
        Else
            MsgBox("Datos incorrectos, verifiquelos", MsgBoxStyle.Critical, "Control de datos")
        End If
    End Sub

    Public Sub tomarDatos(ByVal idmensajep As Integer, ByVal asuntop As String, ByVal idremitentep As Integer, ByVal idDestinatario As Integer, ByVal mensajep As String, _
        ByVal prioridadp As Integer, ByVal leidop As Boolean, ByVal fechaReparacionp As Date, ByVal fechaRoturap As Date)
        varCancelar = 0
        intIdMensaje = idmensajep
        strAsunto = asuntop
        intIdRemitente = idremitentep
        intIdDestinatario = idDestinatario
        strMensaje = mensajep
        intPrioridad = prioridadp
        boolLeido = leidop
        dateFechaRecepion = fechaReparacionp
        dateFechaLectura = fechaRoturap

    End Sub

    'Public Sub mostrarDatos(ByRef txtAsunto As String, ByRef txtfecharotura As Date, ByRef txtcausa As String, ByRef txtfechareparacion As Date, _
    'ByRef txtcosto As String, ByRef cmbidmaquina As Integer, ByRef txtnumerodesperfectop As String)
    '    cmbtipodesperfecto = intIdTipoDesperfecto
    '    txtfecharotura = dateFechaRotura
    '    txtcausa = strCausa
    '    txtfechareparacion = dateFechaReparacion
    '    txtcosto = doubCosto
    '    cmbidmaquina = intIdMaquina
    '    txtnumerodesperfectop = intIdDesperfecto

    'End Sub

    ''Public Function validarDesperfecto(ByVal dscl As DataSet) As Boolean
    ''    Dim tbcliente As DataTable = dscl.Tables.Item(0)
    ''    Dim cfilas As DataRowCollection = tbcliente.Rows
    ''    Dim filabuscada() As DataRow
    ''    Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
    ''    'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

    ''    filabuscada = tbcliente.Select(criterio)

    ''    If (filabuscada.GetUpperBound(0) = -1) Then
    ''        Return True
    ''    Else
    ''        Return False
    ''    End If
    ''End Function

    ''Public Function buscarDesperfecto(ByVal dscl As DataSet) As DataRow()
    ''    Dim tbcliente As DataTable = dscl.Tables.Item(0)
    ''    Dim cfilas As DataRowCollection = tbcliente.Rows
    ''    'Dim filavacia As DataRow
    ''    Dim filabuscada() As DataRow
    ''    Dim criterio As String = "documento=" & documentocliente & " and idtipodocumento=" & idtipodoccliente
    ''    'Dim criterio As String = "documento like '*" & TextBox1.Text & "*'"

    ''    filabuscada = tbcliente.Select(criterio)

    ''    'If (filabuscada.GetUpperBound(0) = -1) Then
    ''    'Return filavacia
    ''    'Else
    ''    'Return filabuscada
    ''    'End If
    ''    Return filabuscada
    ''End Function
    'Public Function getNewID(ByVal dscl As DataSet) As Integer

    '    Dim tbDesperfecto As DataTable = dscl.Tables.Item(0)

    '    Dim idmaximo() As DataRow
    '    idmaximo = tbDesperfecto.Select("idDesperfecto=max(idDesperfecto)")
    '    Dim nuevafila As DataRow
    '    nuevafila = tbDesperfecto.NewRow()
    '    Return CType(idmaximo(0).Item(0), Integer) + 1
    'End Function
    'Public Sub registrarReparacion(ByVal dscl As DataSet)

    '    Dim tbDesperfecto As DataTable = dscl.Tables.Item(0)
    '    For Each updatefila As DataRow In tbDesperfecto.Rows
    '        If updatefila(0) = intIdDesperfecto Then
    '            updatefila(1) = intIdTipoDesperfecto
    '            updatefila(2) = dateFechaRotura
    '            updatefila(3) = strCausa
    '            updatefila(4) = dateFechaReparacion
    '            updatefila(5) = doubCosto
    '            updatefila(6) = intIdMaquina
    '            updatefila(7) = True

    '        End If
    '    Next
    '    Dim oCommandBuilder_OC As New SqlClient.SqlCommandBuilder(adaptadorDesperfecto)
    '    adaptadorDesperfecto.UpdateCommand = oCommandBuilder_OC.GetUpdateCommand
    '    adaptadorDesperfecto.Update(dscl, "Desperfecto")

    'End Sub

End Class
