Public Class GestorReportesProdForm

    Dim usuario As New Usuario
    Dim nombreEmpleado As String

    Private Sub GestorReportesProdForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        nombreEmpleado = usuario.getCliente(seguridad.id)

        query = "select * from cliente"
        cargarComboTag(query, comboPedidoCliente, 0, 23)
        cargarComboTag(query, comboServicioCliente, 0, 23)

        query = "select * from estado where estado.idestado between 1 and 10"
        cargarComboTag(query, comboPedidoEstado, 0, 2)

        query = "select idmodelo, nombre from modelofresa"
        cargarComboTag(query, comboPedidoModelo, 0, 2)

        query = "select idoperacion, nombre from operacion"
        cargarComboTag(query, comboServicioOperacion, 0, 2)

        query = "select * from estado where estado.idestado between 41 and 50"
        cargarComboTag(query, comboServicioEstado, 0, 2)

        query = "select idtornero, nombre from tornero"
        cargarComboTag(query, comboTornero, 0, 2)

        query = "select nroserie from fresa"
        cargarComboTag(query, comboTorneadoNroserie, 0, 1)

    End Sub


#Region "Reporte de detalle de pedido"

    Dim adaptadorPedido As New SqlClient.SqlDataAdapter
    Dim selectPedido As New SqlClient.SqlCommand
    Dim dataSetPedido As New DSDetallePedido
    Dim queryPedido As String
    Dim reportePedido As RptDetallePedido

    Private Sub btnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedido.Click

        queryPedido = "SELECT Pedido.idpedido, Pedido.fechaentrega, Pedido.fecharealizacion, Pedido.idestado, Pedido.prioridad, Pedido.idcliente, Pedido.idvendedor," & _
                      " Pedido.idformadeentrega, Pedido.idempresa, Pedido.idviajante, Pedido.fecharealentrega, estado_1.nombre AS estadoPedido," & _
                      " estado.nombre AS estadoFresa, fresa.nroserie, fresa.fechafinfabricacion, fresa.estado, fresa.precio, tipofresa.nombre AS nombreFresa," & _
                      " cliente.nombre AS nombreCliente, cliente.apellido AS apellidoCliente, fresa.idtipo, fresa.idmodelo" & _
                      " FROM Pedido INNER JOIN" & _
                      " fresa ON Pedido.idpedido = fresa.nropedido INNER JOIN" & _
                      " estado ON fresa.estado = estado.idestado INNER JOIN" & _
                      " cliente ON Pedido.idcliente = cliente.idcliente INNER JOIN" & _
                      " estado AS estado_1 ON Pedido.idestado = estado_1.idestado INNER JOIN" & _
                      " tipofresa ON fresa.idtipo = tipofresa.idtipo AND fresa.idmodelo = tipofresa.idmodelo"

        Dim criterioParaMostrar As String = "Criterio de seleccion: "
        Dim criterio As String = ""

        If checkPedidoFecha.Checked Then

            criterio = "{Pedido.fechaentrega} in Date(" & pedidoDesde.Value.Year & ", " & _
            pedidoDesde.Value.Month & ", " & pedidoDesde.Value.Day & ") to Date (" & pedidoHasta.Value.Year & ", " & _
            pedidoHasta.Value.Month & ", " & pedidoHasta.Value.Day & ")"

            criterioParaMostrar = criterioParaMostrar & "Fecha planificada entrega: Desde: " & pedidoDesde.Value & " Hasta: " & pedidoHasta.Value

        End If

        If checkPedidoCliente.Checked Then

            If comboPedidoCliente.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar cliente", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{Pedido.idcliente} = " & comboPedidoCliente.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Cliente: " & comboPedidoCliente.SelectedItem.DataValue.ToString.Trim

        End If

        If checkPedidoEstado.Checked Then

            If comboPedidoEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar estado", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{Pedido.idestado} = " & comboPedidoEstado.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Estado: " & comboPedidoEstado.SelectedItem.DataValue.ToString.Trim

        End If

        If checkPedidoModelo.Checked Then

            If comboPedidoModelo.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar modelo de fresa", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{Pedido.idmodelo} = " & comboPedidoModelo.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Modelo de fresa: " & comboPedidoModelo.SelectedItem.DataValue.ToString.Trim

        End If

        imageLoading.Visible = True
        selectPedido.CommandType = CommandType.Text
        selectPedido.CommandText = queryPedido
        selectPedido.Connection = cnn
        selectPedido.Connection.Open()

        adaptadorPedido.SelectCommand = selectPedido

        Try
            adaptadorPedido.Fill(dataSetPedido, "Pedido")

            reportePedido = New RptDetallePedido
            reportePedido.SetDataSource(dataSetPedido)
            reportePedido.SummaryInfo.ReportComments = criterioParaMostrar
            reportePedido.SummaryInfo.ReportAuthor = nombreEmpleado

            If criterio = "" Then
                crv.SelectionFormula = Nothing
            Else
                crv.SelectionFormula = criterio
            End If

            crv.ReportSource = reportePedido

            selectPedido.Connection.Close()

        Catch ex As Exception
            selectPedido.Connection.Close()
        End Try

        imageLoading.Visible = False

    End Sub
#End Region


#Region "Reporte torneados"

    Dim adaptadorTorneado As New SqlClient.SqlDataAdapter
    Dim selectTorneado As New SqlClient.SqlCommand
    Dim dataSetTorneado As New DSTorneado
    Dim queryTorneado As String
    Dim reporteTorneado As RptTorneado


    Private Sub btnTorneado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTorneado.Click

        queryTorneado = "SELECT torneado.idtorneado, torneado.fechasalidad, torneado.fecharecepcion, torneado.idtornero, torneado.costo, tornero.nombre, tornero.apellido," & _
                      " Tornero.telefono, Tornero.cantidadtorneados, Tornero.efectividad, Fresa.nroserie" & _
                      " FROM torneado INNER JOIN" & _
                      " tornero ON torneado.idtornero = tornero.idtornero INNER JOIN" & _
                      " detallehojaderuta ON torneado.idtorneado = detallehojaderuta.idtorneado INNER JOIN" & _
                      " hojaderuta ON detallehojaderuta.idhojaderuta = hojaderuta.idhojaderuta INNER JOIN" & _
                      " fresa ON hojaderuta.idhojaderuta = fresa.idhojaderuta"

        Dim criterioParaMostrar As String = "Criterio de seleccion: "
        Dim criterio As String = ""

        If checkFechaSalida.Checked Then

            criterio = "{torneado.fechasalidad} in Date(" & fechaSalidaDesde.Value.Year & ", " & _
            fechaSalidaDesde.Value.Month & ", " & fechaSalidaDesde.Value.Day & ") to Date (" & fechaSalidaHasta.Value.Year & ", " & _
            fechaSalidaHasta.Value.Month & ", " & fechaSalidaHasta.Value.Day & ")"

            criterioParaMostrar = criterioParaMostrar & "Fecha salida de fresa: Desde: " & fechaSalidaDesde.Value & " Hasta: " & fechaSalidaHasta.Value

        End If

        If checkFechaRecepcion.Checked Then

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = "{torneado.fecharecepcion} in Date(" & fechaRecepcionDesde.Value.Year & ", " & _
            fechaRecepcionDesde.Value.Month & ", " & fechaRecepcionDesde.Value.Day & ") to Date (" & fechaRecepcionHasta.Value.Year & ", " & _
            fechaRecepcionHasta.Value.Month & ", " & fechaRecepcionHasta.Value.Day & ")"

            criterioParaMostrar = criterioParaMostrar & "Fecha recepcion de fresa: Desde: " & fechaRecepcionDesde.Value & " Hasta: " & fechaRecepcionHasta.Value

        End If

        If checkTornero.Checked Then

            If comboTornero.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar tornero", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{torneado.idtornero} = " & comboTornero.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Tornero: " & comboTornero.SelectedItem.DataValue.ToString.Trim

        End If

        If checkTorneadoNroserie.Checked Then

            If comboTorneadoNroserie.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar Nro. serie de fresa", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{torneado.nroserie} = " & comboTorneadoNroserie.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Nro Serie fresa: " & comboTorneadoNroserie.SelectedItem.DataValue.ToString.Trim

        End If

        imageLoading.Visible = True
        selectTorneado.CommandType = CommandType.Text
        selectTorneado.CommandText = queryTorneado
        selectTorneado.Connection = cnn
        selectTorneado.Connection.Open()

        adaptadorTorneado.SelectCommand = selectTorneado

        Try
            adaptadorTorneado.Fill(dataSetTorneado, "torneado")

            reporteTorneado = New RptTorneado
            reporteTorneado.SetDataSource(dataSetTorneado)
            reporteTorneado.SummaryInfo.ReportComments = criterioParaMostrar
            reporteTorneado.SummaryInfo.ReportAuthor = nombreEmpleado

            If criterio = "" Then
                crv.SelectionFormula = Nothing
            Else
                crv.SelectionFormula = criterio
            End If

            crv.ReportSource = reporteTorneado

            selectTorneado.Connection.Close()

        Catch ex As Exception
            selectTorneado.Connection.Close()
        End Try

        imageLoading.Visible = False

    End Sub

#End Region


#Region "Reporte Servicio"
    Dim adaptadorServicio As New SqlClient.SqlDataAdapter
    Dim selectServicio As New SqlClient.SqlCommand
    Dim dataSetServicio As New DataSet
    Dim queryServicio As String
    Dim reporteServicio As RptServicio

    Private Sub btnServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicio.Click

        queryServicio = "SELECT detalleordenservicio.idpedido, detalleordenservicio.idoperacion, detalleordenservicio.idobjetodelservicio, detalleordenservicio.preciodeservicio," & _
                      " detalleordenservicio.observacion, detalleordenservicio.idhojaderuta, detalleordenservicio.precio," & _
                      " objetodelservicio.nombre AS nombreObjetodelServicio, objetodelservicio.cantidad, operacion.nombre AS nombreOperacion, operacion.maquina," & _
                      " Pedido.idestado, Pedido.prioridad, Pedido.idcliente, cliente.nombre, cliente.apellido, estado.nombre AS nombreEstado," & _
                      " Pedido.fecharealizacion, Pedido.fechaentrega, Pedido.fecharealentrega" & _
                      " FROM detalleordenservicio INNER JOIN" & _
                      " objetodelservicio ON detalleordenservicio.idobjetodelservicio = objetodelservicio.idobjetodelservicio INNER JOIN" & _
                      " operacion ON detalleordenservicio.idoperacion = operacion.idoperacion INNER JOIN" & _
                      " Pedido ON detalleordenservicio.idpedido = Pedido.idpedido INNER JOIN" & _
                      " cliente ON Pedido.idcliente = cliente.idcliente INNER JOIN" & _
                      " estado ON Pedido.idestado = estado.idestado"

        Dim criterioParaMostrar As String = "Criterio de seleccion: "
        Dim criterio As String = ""

        If checkFechaRealizacion.Checked Then

            criterio = "{torneado.fecharealizacion} in Date(" & fechaRealizacionDesde.Value.Year & ", " & _
            fechaRealizacionDesde.Value.Month & ", " & fechaRealizacionDesde.Value.Day & ") to Date (" & fechaRealizacionHasta.Value.Year & ", " & _
            fechaRealizacionHasta.Value.Month & ", " & fechaRealizacionHasta.Value.Day & ")"

            criterioParaMostrar = criterioParaMostrar & "Fecha realizacion de servicio: Desde: " & fechaRealizacionDesde.Value & " Hasta: " & fechaRealizacionHasta.Value

        End If

        If checkFechaRealizacion.Checked Then

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = "{torneado.fechaentrega} in Date(" & fechaEntregaDesde.Value.Year & ", " & _
            fechaEntregaDesde.Value.Month & ", " & fechaEntregaDesde.Value.Day & ") to Date (" & fechaEntregaHasta.Value.Year & ", " & _
            fechaEntregaHasta.Value.Month & ", " & fechaEntregaHasta.Value.Day & ")"

            criterioParaMostrar = criterioParaMostrar & "Fecha realizacion de servicio: Desde: " & fechaEntregaDesde.Value & " Hasta: " & fechaEntregaHasta.Value

        End If

        If checkServicioCliente.Checked Then

            If comboServicioCliente.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar cliente", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{detalleordenservicio.idcliente} = " & comboServicioCliente.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & "Cliente: " & comboServicioCliente.SelectedItem.DataValue

        End If

        If checkServicioOperacion.Checked Then

            If comboServicioOperacion.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar Operacion", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{detalleordenservicio.idoperacion} = " & comboServicioOperacion.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Operación: " & comboServicioOperacion.SelectedItem.DataValue

        End If

        If checkServicioEstado.Checked Then

            If comboServicioEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar Estado", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{detalleordenservicio.idestado} = " & comboServicioEstado.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Estado: " & comboServicioEstado.SelectedItem.DataValue

        End If

        imageLoading.Visible = True
        selectServicio.CommandType = CommandType.Text
        selectServicio.CommandText = queryServicio
        selectServicio.Connection = cnn
        selectServicio.Connection.Open()

        adaptadorServicio.SelectCommand = selectServicio

        Try
            adaptadorServicio.Fill(dataSetServicio, "detalleordenservicio")

            reporteServicio = New RptServicio
            reporteServicio.SetDataSource(dataSetServicio)
            reporteServicio.SummaryInfo.ReportComments = criterioParaMostrar
            reporteServicio.SummaryInfo.ReportAuthor = nombreEmpleado

            If criterio = "" Then
                crv.SelectionFormula = Nothing
            Else
                crv.SelectionFormula = criterio
            End If

            crv.ReportSource = reporteServicio

            selectServicio.Connection.Close()

        Catch ex As Exception
            selectServicio.Connection.Close()
        End Try

        imageLoading.Visible = False

    End Sub

#End Region
End Class