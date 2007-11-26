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


End Class