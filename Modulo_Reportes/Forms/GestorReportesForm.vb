Public Class GestorReportesForm
    Inherits System.Windows.Forms.Form

    Private Sub GestorReportesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String

        cargarComboTag("select * from cliente", comboPedidoCliente, 0, 23)
        query = "select * from estado where estado.idestado between 1 and 10"
        cargarComboTag(query, comboPedidoEstado, 0, 2)

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

        selectPedido.CommandType = CommandType.Text
        selectPedido.CommandText = queryPedido
        selectPedido.Connection = cnn
        selectPedido.Connection.Open()

        adaptadorPedido.SelectCommand = selectPedido

        If checkPedidoFecha.Checked Then

            criterio = "{Pedido.fechaentrega} in Date(" & pedidoDesde.Value.Year & ", " & _
            pedidoDesde.Value.Month & ", " & pedidoDesde.Value.Day & ") to Date (" & pedidoHasta.Value.Year & ", " & _
            pedidoHasta.Value.Month & ", " & pedidoHasta.Value.Day & ")"

        End If

        If checkPedidoCliente.Checked Then

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{Pedido.idcliente} = " & comboPedidoCliente.SelectedItem.Tag

        End If

        If checkPedidoEstado.Checked Then
            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{Pedido.idestado} = " & comboPedidoEstado.SelectedItem.Tag

        End If


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

        selectCliente.CommandType = CommandType.Text
        selectCliente.CommandText = queryCliente
        selectCliente.Connection = cnn
        selectCliente.Connection.Open()

        adaptadorCliente.SelectCommand = selectCliente

        Try
            adaptadorCliente.Fill(dataSetCliente, "cliente")

            reporteCliente.SetDataSource(dataSetCliente)

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

        selectFresas.CommandType = CommandType.Text
        selectFresas.CommandText = queryFresas
        selectFresas.Connection = cnn
        selectFresas.Connection.Open()

        adaptadorFresas.SelectCommand = selectFresas

        Try
            adaptadorFresas.Fill(dataSetFresas, "fresa")

            reporteFresas.SetDataSource(dataSetFresas)

            crv.ReportSource = reporteFresas

            selectFresas.Connection.Close()

        Catch ex As Exception
            selectFresas.Connection.Close()
        End Try
    End Sub
#End Region


End Class