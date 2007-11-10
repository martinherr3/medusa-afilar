Public Class GestorReportesForm
    Inherits System.Windows.Forms.Form

    Private Sub GestorReportesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String

        query = "select * from cliente"
        cargarComboTag(query, comboPedidoCliente, 0, 23)

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

        query = "select * from cliente"
        cargarComboTag(query, comboServicioCliente, 0, 23)


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

        Dim criterio As String = ""

        If checkPedidoFecha.Checked Then

            criterio = "{Pedido.fechaentrega} in Date(" & pedidoDesde.Value.Year & ", " & _
            pedidoDesde.Value.Month & ", " & pedidoDesde.Value.Day & ") to Date (" & pedidoHasta.Value.Year & ", " & _
            pedidoHasta.Value.Month & ", " & pedidoHasta.Value.Day & ")"

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

        End If

        selectPedido.CommandType = CommandType.Text
        selectPedido.CommandText = queryPedido
        selectPedido.Connection = cnn
        selectPedido.Connection.Open()

        adaptadorPedido.SelectCommand = selectPedido

        Try
            adaptadorPedido.Fill(dataSetPedido, "Pedido")

            reportePedido = New RptPedidos
            reportePedido.SetDataSource(dataSetPedido)

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

    End Sub
#End Region


#Region "Reporte Cliente"
    Dim adaptadorCliente As New SqlClient.SqlDataAdapter
    Dim selectCliente As New SqlClient.SqlCommand
    Dim dataSetCliente As New DataSet
    Dim queryCliente As String
    Dim reporteCliente As New RptCliente

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        queryCliente = "SELECT cliente.idcliente, cliente.nombre, cliente.apellido, cliente.idtipodocumento, cliente.direccion, cliente.localidad, cliente.mail, cliente.telefono, " & _
                       " cliente.documento, cliente.celular, localidad.nombre AS nombreLocalidad" & _
                       " FROM cliente INNER JOIN" & _
                       " localidad ON cliente.localidad = localidad.idlocalidad"

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

        End If

        selectCliente.CommandType = CommandType.Text
        selectCliente.CommandText = queryCliente
        selectCliente.Connection = cnn
        selectCliente.Connection.Open()

        adaptadorCliente.SelectCommand = selectCliente

        Try
            adaptadorCliente.Fill(dataSetCliente, "cliente")

            reporteCliente.SetDataSource(dataSetCliente)

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
    End Sub
#End Region


#Region "Reporte Fresas"
    Dim adaptadorFresas As New SqlClient.SqlDataAdapter
    Dim selectFresas As New SqlClient.SqlCommand
    Dim dataSetFresas As New DataSet
    Dim queryFresas As String
    Dim reporteFresas As New RptFresa

    Private Sub btnFresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFresas.Click
        queryFresas = "SELECT fresa.nroserie, fresa.fechafinfabricacion, fresa.costofabricacion, fresa.estado, fresa.nropedido, fresa.controlcalidad, fresa.idhojaderuta, fresa.precio, " & _
                     " Fresa.idtipo, Fresa.idmodelo, TipoFresa.nombre" & _
                     " FROM fresa INNER JOIN" & _
                     " tipofresa ON fresa.idtipo = tipofresa.idtipo AND fresa.idmodelo = tipofresa.idmodelo"

        Dim criterio As String = ""

        If checkPedidoFecha.Checked Then

            criterio = "{fresa.fechafinfabricacion} in Date(" & fresaDesde.Value.Year & ", " & _
            fresaDesde.Value.Month & ", " & fresaDesde.Value.Day & ") to Date (" & fresaHasta.Value.Year & ", " & _
            fresaHasta.Value.Month & ", " & fresaHasta.Value.Day & ")"

        End If

        If checkFresaEstado.Checked Then

            If comboPedidoEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar estado", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{fresa.estado} = " & comboFresaEstado.SelectedItem.Tag

        End If

        If checkFresaModelo.Checked Then

            If comboPedidoEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar modelo de fresa", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{fresa.idmodelo} = " & comboFresaModelo.SelectedItem.Tag

        End If

        selectFresas.CommandType = CommandType.Text
        selectFresas.CommandText = queryFresas
        selectFresas.Connection = cnn
        selectFresas.Connection.Open()

        adaptadorFresas.SelectCommand = selectFresas

        Try
            adaptadorFresas.Fill(dataSetFresas, "fresa")

            reporteFresas.SetDataSource(dataSetFresas)

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
    End Sub
#End Region


#Region "Reporte Servicio"
    Dim adaptadorServicio As New SqlClient.SqlDataAdapter
    Dim selectServicio As New SqlClient.SqlCommand
    Dim dataSetServicio As New DataSet
    Dim queryServicio As String
    Dim reporteServicio As New RptServicio

    Private Sub btnServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicio.Click
        queryServicio = "SELECT detalleordenservicio.idpedido, detalleordenservicio.idoperacion, detalleordenservicio.idobjetodelservicio, detalleordenservicio.preciodeservicio," & _
                      " detalleordenservicio.observacion, detalleordenservicio.idhojaderuta, detalleordenservicio.precio," & _
                      " objetodelservicio.nombre AS nombreObjetodelServicio, objetodelservicio.cantidad, operacion.nombre AS nombreOperacion, operacion.maquina," & _
                      " Pedido.idpedido AS Expr1, Pedido.idestado, Pedido.prioridad, Pedido.idcliente, cliente.nombre, cliente.apellido" & _
                      " FROM detalleordenservicio INNER JOIN" & _
                      " objetodelservicio ON detalleordenservicio.idobjetodelservicio = objetodelservicio.idobjetodelservicio INNER JOIN" & _
                      " operacion ON detalleordenservicio.idoperacion = operacion.idoperacion INNER JOIN" & _
                      " Pedido ON detalleordenservicio.idpedido = Pedido.idpedido INNER JOIN" & _
                      " cliente ON Pedido.idcliente = cliente.idcliente"

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

        End If

        selectServicio.CommandType = CommandType.Text
        selectServicio.CommandText = queryServicio
        selectServicio.Connection = cnn
        selectServicio.Connection.Open()

        adaptadorServicio.SelectCommand = selectServicio

        Try
            adaptadorServicio.Fill(dataSetServicio, "detalleordenservicio")

            reporteServicio.SetDataSource(dataSetServicio)

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

    End Sub

#End Region

End Class