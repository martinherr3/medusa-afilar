Public Class GestorReportesComForm

    Private Sub GestorReportesComForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String

        query = "select idproveedor, nombre from proveedor"
        cargarComboTag(query, comboCompraProveedor, 0, 2)

        query = "select * from estado where estado.idestado between 11 and 20"
        cargarComboTag(query, comboCompraEstado, 0, 2)

    End Sub

#Region "Reporte Compra"

    Private Sub btnCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompra.Click

        Dim adaptadorCompra As New SqlClient.SqlDataAdapter
        Dim selectCompra As New SqlClient.SqlCommand
        Dim dataSetCompra As New DSOrdenCompra
        Dim queryCompra As String
        Dim reporteCompra As RptOrdenCompra


        queryCompra = "SELECT ordencompramp.fecharealizacion, ordencompramp.plazodeentrega, ordencompramp.idordencompra, ordencompramp.nroorden," & _
                      " ordencompramp.condicionesdepago, ordencompramp.causa, ordencompramp.idestado, ordencompramp.idproveedor, Proveedor.nombre" & _
                      " FROM ordencompramp INNER JOIN" & _
                      " proveedor ON ordencompramp.idproveedor = proveedor.idproveedor"

        Dim criterio As String = ""

        If checkCompraFecha.Checked Then

            criterio = "{ordencompramp.plazodeentrega} in Date(" & compraDesde.Value.Year & ", " & _
            compraDesde.Value.Month & ", " & compraDesde.Value.Day & ") to Date (" & compraHasta.Value.Year & ", " & _
            compraHasta.Value.Month & ", " & compraHasta.Value.Day & ")"

        End If

        If checkCompraProveedor.Checked Then

            If comboCompraProveedor.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar proveedor", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{Pedido.idcliente} = " & comboCompraProveedor.SelectedItem.Tag

        End If

        If checkCompraEstado.Checked Then

            If comboCompraEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar estado", MsgBoxStyle.Information, "Afilar")
                Exit Sub
            End If

            If criterio <> "" Then
                criterio = criterio & " AND "
            End If

            criterio = criterio & "{Pedido.idestado} = " & comboCompraEstado.SelectedItem.Tag

        End If

        selectCompra.CommandType = CommandType.Text
        selectCompra.CommandText = queryCompra
        selectCompra.Connection = cnn
        selectCompra.Connection.Open()

        adaptadorCompra.SelectCommand = selectCompra

        Try
            adaptadorCompra.Fill(dataSetCompra, "Pedido")

            reporteCompra = New RptOrdenCompra
            reporteCompra.SetDataSource(dataSetCompra)

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

    End Sub

#End Region

End Class