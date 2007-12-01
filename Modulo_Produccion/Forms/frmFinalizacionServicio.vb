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
#End Region

#Region "--[Metodos]--"
    Private Sub CargarServicios()
        Try

            da = New SqlClient.SqlDataAdapter("select * from detalleordenservicio inner join estado on detalleordenservicio.estado=estado.idestado where detalleordenservicio.estado=" & Estado.ORDEN_DE_SERVICIO_PENDIENTE, cnn)
            ds = New DataSet()
            da.Fill(ds)

            dgServicios.DataSource = ds.Tables(0)

            dgServicios.Columns(1).Visible = False
            dgServicios.Columns(2).Visible = False
            dgServicios.Columns(4).Visible = False
            dgServicios.Columns(5).Visible = False
            dgServicios.Columns(6).Visible = False
            dgServicios.Columns(7).Visible = False
            dgServicios.Columns(8).Visible = False
            dgServicios.Columns(10).Visible = False

            dgServicios.Columns(0).Width = 100
            dgServicios.Columns(3).Width = 150
            dgServicios.Columns(9).Width = 200

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    
    
End Class