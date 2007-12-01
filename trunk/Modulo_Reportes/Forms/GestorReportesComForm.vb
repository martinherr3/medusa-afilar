Public Class GestorReportesComForm

    Dim nombreEmpleado As String
    Dim empleado As New Usuario

    Private Sub GestorReportesComForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub GestorReportesComForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        nombreEmpleado = empleado.getCliente(seguridad.id)

        Dim query As String

        query = "select idproveedor, nombre from proveedor"
        cargarComboTag(query, comboCompraProveedor, 0, 2)
        cargarComboTag(query, comboDetalleOCProveedor, 0, 2)

        query = "select * from estado where estado.idestado between 11 and 20"
        cargarComboTag(query, comboCompraEstado, 0, 2)
        cargarComboTag(query, comboDetalleOCEstado, 0, 2)

        query = "select idtipomateriaprima, nombre from tipomateriaprima"
        cargarComboTag(query, comboDetalleOCMP, 0, 2)

    End Sub


#Region "Reporte Orden de Compra"

    Dim adaptadorCompra As New SqlClient.SqlDataAdapter
    Dim selectCompra As New SqlClient.SqlCommand
    Dim dataSetCompra As New DSOrdenCompra
    Dim queryCompra As String
    Dim reporteCompra As RptOrdenCompra

    Private Sub btnCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompra.Click

        queryCompra = "SELECT ordencompramp.fecharealizacion, ordencompramp.plazodeentrega, ordencompramp.idordencompra, ordencompramp.nroorden," & _
                      " ordencompramp.condicionesdepago, ordencompramp.causa, ordencompramp.idestado, ordencompramp.idproveedor, proveedor.nombre," & _
                      " estado.nombre AS nombreEstado" & _
                      " FROM ordencompramp INNER JOIN" & _
                      " proveedor ON ordencompramp.idproveedor = proveedor.idproveedor INNER JOIN" & _
                      " estado ON ordencompramp.idestado = estado.idestado"

        Dim criterioParaMostrar As String = "Criterio de seleccion: "
        Dim criterio As String = ""

        If checkCompraFecha.Checked Then

            criterio = "{ordencompramp.plazodeentrega} in Date(" & compraDesde.Value.Year & ", " & _
            compraDesde.Value.Month & ", " & compraDesde.Value.Day & ") to Date (" & compraHasta.Value.Year & ", " & _
            compraHasta.Value.Month & ", " & compraHasta.Value.Day & ")"
            criterioParaMostrar = criterioParaMostrar & " Fecha estimada de entrega: Desde " & compraDesde.Value & " - Hasta " & compraHasta.Value

        End If

        If checkCompraProveedor.Checked Then

            If comboCompraProveedor.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar proveedor", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{ordencompramp.idproveedor} = " & comboCompraProveedor.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Proveedor: " & comboCompraProveedor.SelectedItem.DataValue.ToString.Trim

        End If

        If checkCompraEstado.Checked Then

            If comboCompraEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar estado", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{ordencompramp.idestado} = " & comboCompraEstado.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Estado Orden de Compra: " & comboCompraEstado.SelectedItem.DataValue.ToString.Trim

        End If

        imageLoading.Visible = True
        selectCompra.CommandType = CommandType.Text
        selectCompra.CommandText = queryCompra
        selectCompra.Connection = cnn
        selectCompra.Connection.Open()

        adaptadorCompra.SelectCommand = selectCompra

        Try
            adaptadorCompra.Fill(dataSetCompra, "ordencompramp")

            reporteCompra = New RptOrdenCompra
            reporteCompra.SetDataSource(dataSetCompra)
            reporteCompra.SummaryInfo.ReportComments = criterioParaMostrar
            reporteCompra.SummaryInfo.ReportAuthor = nombreEmpleado

            If criterio = "" Then
                crv.SelectionFormula = Nothing
            Else
                crv.SelectionFormula = criterio
            End If

            crv.ReportSource = reporteCompra

            selectCompra.Connection.Close()

        Catch ex As Exception
            selectCompra.Connection.Close()
        End Try

        imageLoading.Visible = False

    End Sub

#End Region


#Region "Reporte Detalle Orden de Compra"

    Dim adaptadorDOCompra As New SqlClient.SqlDataAdapter
    Dim selectDOCompra As New SqlClient.SqlCommand
    Dim dataSetDOCompra As New DSDetalleOC
    Dim queryDOCompra As String
    Dim reporteDOCompra As RptDetalleOC

    Private Sub btnDetalleOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleOC.Click

        queryDOCompra = "SELECT ordencompramp.fecharealizacion, ordencompramp.plazodeentrega, ordencompramp.idordencompra, ordencompramp.nroorden," & _
                        " ordencompramp.idestado, ordencompramp.idproveedor, estado.nombre AS estadoDetalle, proveedor.nombre AS nombreProveedor," & _
                        " tipomateriaprima.nombre AS nombreMP, detalleordencompra.cantidad, detalleordencompra.precio, detalleordencompra.idestado AS idestadoDetalle," & _
                        " unidaddemedida.nombre AS unidadDeMedida, detalleordencompra.idtipomateriaprima" & _
                        " FROM ordencompramp INNER JOIN" & _
                        " detalleordencompra ON ordencompramp.idordencompra = detalleordencompra.idordencompra INNER JOIN" & _
                        " proveedor ON ordencompramp.idproveedor = proveedor.idproveedor INNER JOIN" & _
                        " estado ON detalleordencompra.idestado = estado.idestado INNER JOIN" & _
                        " tipomateriaprima ON detalleordencompra.idtipomateriaprima = tipomateriaprima.idtipomateriaprima INNER JOIN" & _
                        " unidaddemedida ON tipomateriaprima.idunidadmedida = unidaddemedida.idunidadmedida"

        Dim criterioParaMostrar As String = "Criterio de seleccion: "
        Dim criterio As String = ""

        If checkFechaDetalleOC.Checked Then

            criterio = "{ordencompramp.plazodeentrega} in Date(" & compraDesde.Value.Year & ", " & _
            detalleOCDesde.Value.Month & ", " & detalleOCDesde.Value.Day & ") to Date (" & compraHasta.Value.Year & ", " & _
            detalleOCHasta.Value.Month & ", " & detalleOCHasta.Value.Day & ")"
            criterioParaMostrar = criterioParaMostrar & " Fecha estimada de entrega: Desde " & compraDesde.Value & " - Hasta " & compraHasta.Value

        End If

        If checkDetalleOCProveedor.Checked Then

            If comboDetalleOCProveedor.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar proveedor", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{ordencompramp.idproveedor} = " & comboDetalleOCProveedor.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Proveedor: " & comboDetalleOCProveedor.SelectedItem.DataValue.ToString.Trim

        End If

        If checkDetalleOCEstado.Checked Then

            If comboDetalleOCEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar estado", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{ordencompramp.idestado} = " & comboDetalleOCEstado.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Estado Orden de Compra: " & comboDetalleOCEstado.SelectedItem.DataValue.ToString.Trim

        End If

        If checkDetalleOCMP.Checked Then

            If comboDetalleOCMP.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar materia prima", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{ordencompramp.idtipomateriaprima} = " & comboDetalleOCMP.SelectedItem.Tag
            criterioParaMostrar = criterioParaMostrar & " --- Tipo materia prima: " & comboDetalleOCMP.SelectedItem.DataValue.ToString.Trim

        End If

        imageLoading.Visible = True
        selectDOCompra.CommandType = CommandType.Text
        selectDOCompra.CommandText = queryDOCompra
        selectDOCompra.Connection = cnn
        selectDOCompra.Connection.Open()

        adaptadorDOCompra.SelectCommand = selectDOCompra

        Try
            adaptadorDOCompra.Fill(dataSetDOCompra, "ordencompramp")

            reporteDOCompra = New RptDetalleOC
            reporteDOCompra.SetDataSource(dataSetDOCompra)
            reporteDOCompra.SummaryInfo.ReportComments = criterioParaMostrar
            reporteDOCompra.SummaryInfo.ReportAuthor = nombreEmpleado

            If criterio = "" Then
                crv.SelectionFormula = Nothing
            Else
                crv.SelectionFormula = criterio
            End If

            crv.ReportSource = reporteDOCompra

            selectDOCompra.Connection.Close()

        Catch ex As Exception
            selectDOCompra.Connection.Close()
        End Try

        imageLoading.Visible = False

    End Sub
#End Region


#Region "Reporte Materia Prima"
    Private Sub btnMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMP.Click

    End Sub
#End Region


End Class