Public Class GestorReportesForm
    Inherits System.Windows.Forms.Form

#Region "Declaraciones"
    Dim usuario As New Usuario
    Dim nombreEmpleado As String
#End Region

    Private Sub GestorReportesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim query As String
        nombreEmpleado = usuario.getCliente(seguridad.id)

        query = "select * from cliente"
        cargarComboTag(query, comboPedidoCliente, 0, 23)
        cargarComboTag(query, comboServicioCliente, 0, 23)

        query = "select * from estado where estado.idestado between 1 and 10"
        cargarComboTag(query, comboPedidoEstado, 0, 2)

        query = "select idmodelo, nombre from modelofresa"
        cargarComboTag(query, comboFresaModelo, 0, 2)

        query = "select * from estado where estado.idestado between 21 and 30"
        cargarComboTag(query, comboFresaEstado, 0, 2)

        query = "select idlocalidad, nombre from localidad"
        cargarComboTag(query, comboClienteLocalidad, 0, 2)

        query = "select idprovincia, nombre from provincia"
        cargarComboTag(query, comboClienteProvincia, 0, 2)

        query = "select idoperacion, nombre from operacion"
        cargarComboTag(query, comboServicioOperacion, 0, 2)

        query = "select * from estado where estado.idestado between 41 and 50"
        cargarComboTag(query, comboServicioEstado, 0, 2)


    End Sub


#Region "Reporte Pedido"
    Dim adaptadorPedido As New SqlClient.SqlDataAdapter
    Dim selectPedido As New SqlClient.SqlCommand
    Dim dataSetPedido As New DSPedido
    Dim queryPedido As String
    Dim reportePedido As RptPedidos

    Private Sub btnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedido.Click
        queryPedido = "SELECT cliente.nombre AS nombreCliente, cliente.apellido AS apellidoCliente, empleado.nombre AS nombreEmpleado, empleado.apellido AS apellidoEmpleado, " & _
                      " estado.nombre AS estado, Pedido.* " & _
                      " FROM Pedido INNER JOIN" & _
                      " cliente ON Pedido.idcliente = cliente.idcliente INNER JOIN" & _
                      " empleado ON Pedido.idvendedor = empleado.idlegajo INNER JOIN" & _
                      " estado ON Pedido.idestado = estado.idestado"

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
            criterioParaMostrar = criterioParaMostrar & " --- Cliente: " & comboPedidoCliente.SelectedItem.DataValue

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
            criterioParaMostrar = criterioParaMostrar & " --- Estado: " & comboPedidoEstado.SelectedItem.DataValue

        End If

        imageLoading.Visible = True
        selectPedido.CommandType = CommandType.Text
        selectPedido.CommandText = queryPedido
        selectPedido.Connection = cnn
        selectPedido.Connection.Open()

        adaptadorPedido.SelectCommand = selectPedido

        Try
            adaptadorPedido.Fill(dataSetPedido, "Pedido")

            reportePedido = New RptPedidos
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


#Region "Reporte Cliente"
    Dim adaptadorCliente As New SqlClient.SqlDataAdapter
    Dim selectCliente As New SqlClient.SqlCommand
    Dim dataSetCliente As New DataSet
    Dim queryCliente As String
    Dim reporteCliente As RptCliente

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click

        queryCliente = "SELECT cliente.idcliente, cliente.nombre, cliente.apellido, cliente.idtipodocumento, cliente.direccion, cliente.localidad, cliente.mail, cliente.telefono," & _
                       " cliente.documento, cliente.celular, localidad.nombre AS nombreLocalidad, provincia.nombre AS nombreProvincia, provincia.idprovincia" & _
                       " FROM cliente INNER JOIN" & _
                       " localidad ON cliente.localidad = localidad.idlocalidad INNER JOIN" & _
                       " provincia ON localidad.idprovincia = provincia.idprovincia"

        Dim criterioParaMostrar As String = "Criterio de seleccion: "
        Dim criterio As String = ""

        If checkClienteLocalidad.Checked Then

            If comboClienteLocalidad.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar localidad", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{cliente.localidad} = " & comboClienteLocalidad.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & "Localidad: " & comboClienteLocalidad.SelectedItem.DataValue

        End If

        If checkClienteProvincia.Checked Then

            If comboClienteProvincia.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar provincia", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{cliente.idprovincia} = " & comboClienteProvincia.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Provincia: " & comboClienteProvincia.SelectedItem.DataValue

        End If

        imageLoading.Visible = True
        selectCliente.CommandType = CommandType.Text
        selectCliente.CommandText = queryCliente
        selectCliente.Connection = cnn
        selectCliente.Connection.Open()

        adaptadorCliente.SelectCommand = selectCliente

        Try
            adaptadorCliente.Fill(dataSetCliente, "cliente")

            reporteCliente = New RptCliente
            reporteCliente.SetDataSource(dataSetCliente)
            reporteCliente.SummaryInfo.ReportComments = criterioParaMostrar
            reporteCliente.SummaryInfo.ReportAuthor = nombreEmpleado

            If criterio = "" Then
                crv.SelectionFormula = Nothing
            Else
                crv.SelectionFormula = criterio
            End If

            crv.ReportSource = reporteCliente

            selectCliente.Connection.Close()

        Catch ex As Exception
            selectCliente.Connection.Close()
        End Try

        imageLoading.Visible = False

    End Sub
#End Region


#Region "Reporte Fresas"
    Dim adaptadorFresas As New SqlClient.SqlDataAdapter
    Dim selectFresas As New SqlClient.SqlCommand
    Dim dataSetFresas As New DataSet
    Dim queryFresas As String
    Dim reporteFresas As RptFresa

    Private Sub btnFresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFresas.Click

        queryFresas = "SELECT fresa.nroserie, fresa.fechafinfabricacion, fresa.costofabricacion, fresa.estado, fresa.nropedido, fresa.controlcalidad, fresa.idhojaderuta, fresa.precio, " & _
                      " fresa.idtipo, fresa.idmodelo, tipofresa.nombre, estado.nombre AS nombreEstado" & _
                      " FROM fresa INNER JOIN" & _
                      " tipofresa ON fresa.idtipo = tipofresa.idtipo AND fresa.idmodelo = tipofresa.idmodelo INNER JOIN" & _
                      " estado ON fresa.estado = estado.idestado"

        Dim criterioParaMostrar As String = "Criterio de seleccion: "
        Dim criterio As String = ""

        If checkFechaFresa.Checked Then

            criterio = "{fresa.fechafinfabricacion} in Date(" & fresaDesde.Value.Year & ", " & _
            fresaDesde.Value.Month & ", " & fresaDesde.Value.Day & ") to Date (" & fresaHasta.Value.Year & ", " & _
            fresaHasta.Value.Month & ", " & fresaHasta.Value.Day & ")"

            criterioParaMostrar = criterioParaMostrar & "Fecha fin fabricacion: Desde: " & fresaDesde.Value & " Hasta: " & fresaHasta.Value

        End If

        If checkFresaEstado.Checked Then

            If comboFresaEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar estado", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{fresa.estado} = " & comboFresaEstado.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Estado: " & comboFresaEstado.SelectedItem.DataValue

        End If

        If checkFresaModelo.Checked Then

            If comboFresaModelo.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar modelo de fresa", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{fresa.idmodelo} = " & comboFresaModelo.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Modelo de Fresa: " & comboFresaModelo.SelectedItem.DataValue

        End If

        imageLoading.Visible = True
        selectFresas.CommandType = CommandType.Text
        selectFresas.CommandText = queryFresas
        selectFresas.Connection = cnn
        selectFresas.Connection.Open()

        adaptadorFresas.SelectCommand = selectFresas

        Try
            adaptadorFresas.Fill(dataSetFresas, "fresa")

            reporteFresas = New RptFresa
            reporteFresas.SetDataSource(dataSetFresas)
            reporteFresas.SummaryInfo.ReportComments = criterioParaMostrar
            reporteFresas.SummaryInfo.ReportAuthor = nombreEmpleado

            If criterio = "" Then
                crv.SelectionFormula = Nothing
            Else
                crv.SelectionFormula = criterio
            End If

            crv.ReportSource = reporteFresas

            selectFresas.Connection.Close()

        Catch ex As Exception
            selectFresas.Connection.Close()
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