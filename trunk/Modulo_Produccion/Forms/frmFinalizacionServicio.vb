Public Class frmFinalizacionServicio
#Region "--[Propiedades]--"
    Private da As SqlClient.SqlDataAdapter
    Private ds As DataSet
#End Region

#Region "--[Eventos]--"
    Private Sub frmFinalizacionServicio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub
    Private Sub frmFinalizacionServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        CargarServicios()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnFinalizarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizarServicio.Click
        FinalizarServicio()
    End Sub
#End Region

#Region "--[Metodos]--"
    Private Sub CargarServicios()
        Try

            da = New SqlClient.SqlDataAdapter("select detalleordenservicio.idpedido, detalleordenservicio.idoperacion, detalleordenservicio.idobjetodelservicio, detalleordenservicio.preciodeservicio, detalleordenservicio.observacion, detalleordenservicio.idhojaderuta, detalleordenservicio.precio, detalleordenservicio.estado, estado.idestado, estado.nombre, operacion.nombre as operacion  from detalleordenservicio inner join estado on detalleordenservicio.estado=estado.idestado inner join operacion on detalleordenservicio.idoperacion=operacion.idoperacion where detalleordenservicio.estado<>" & Estado.ORDEN_DE_SERVICIO_FINALIZADO, cnn)
            ds = New DataSet()
            da.Fill(ds)

            dgServicios.DataSource = Nothing
            dgServicios.DataSource = ds.Tables(0)

            dgServicios.Columns(1).Visible = False
            dgServicios.Columns(2).Visible = False
            dgServicios.Columns(4).Visible = False
            dgServicios.Columns(5).Visible = False
            dgServicios.Columns(6).Visible = False
            dgServicios.Columns(7).Visible = False
            dgServicios.Columns(8).Visible = False

            dgServicios.Columns(0).Width = 80
            dgServicios.Columns(3).Width = 100
            dgServicios.Columns(9).Width = 150
            dgServicios.Columns(10).Width = 150

            dgServicios.Columns(0).HeaderText = "Pedido"
            dgServicios.Columns(3).HeaderText = "Precio del Servicio"
            dgServicios.Columns(9).HeaderText = "Estado"
            dgServicios.Columns(10).HeaderText = "Servicio"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FinalizarServicio()
        Try
            cnn.Open()
            If MessageBox.Show("Esta seguro seguro que desea seguir?", "Finalizar Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If dgServicios.SelectedRows.Count > 0 Then
                    Dim sqlC As New SqlClient.SqlCommand("Update detalleordenservicio set estado=" & Estado.ORDEN_DE_SERVICIO_FINALIZADO & " where idpedido=" & dgServicios.SelectedRows(0).Cells(0).Value & " and idoperacion=" & dgServicios.SelectedRows(0).Cells(1).Value & " and idobjetodelservicio=" & dgServicios.SelectedRows(0).Cells(2).Value, cnn)
                    sqlC.ExecuteNonQuery()
                    ActualizarEstadoPedido()
                    CargarServicios()
                Else
                    MessageBox.Show("Debe seleccionar un Servicio", "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub ActualizarEstadoPedido()
        Try
            'cnn.Open()
            Dim myda As SqlClient.SqlDataAdapter
            Dim mydsServicio As DataSet

            myda = New SqlClient.SqlDataAdapter("select * from detalleordenservicio where idpedido=" & dgServicios.SelectedRows(0).Cells(0).Value & " and estado<>" & Estado.ORDEN_DE_SERVICIO_FINALIZADO, cnn)
            mydsServicio = New DataSet
            myda.Fill(mydsServicio)
            'Validar que los servicios esten finalizados para finalizar el pedido
            If mydsServicio.Tables(0).Rows.Count = 0 Then
                Dim mydsFresa As DataSet
                mydsFresa = New DataSet
                myda.SelectCommand.CommandText = "select * from fresa where nropedido=" & dgServicios.SelectedRows(0).Cells(0).Value & " and estado<>" & Estado.FRESA_FINALIZADO & " and estado<>" & Estado.FRESA_RECHAZADA
                myda.Fill(mydsFresa)
                'Validar que las fresas esten finalizadas para finalizar el pedido
                If mydsFresa.Tables(0).Rows.Count = 0 Then
                    Dim sqlC As New SqlClient.SqlCommand("Update pedido set idestado=" & Estado.PEDIDO_FINALIZADO & " where idpedido=" & dgServicios.SelectedRows(0).Cells(0).Value, cnn)
                    sqlC.ExecuteNonQuery()
                    MessageBox.Show("Finalizo el ultimo detalle del pedido pendiente, se finalizo el pedido en forma completa", "Finalizacion de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'cnn.Close()
        End Try
    End Sub
#End Region

End Class