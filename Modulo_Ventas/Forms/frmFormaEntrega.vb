Public Class frmFormaEntrega
    Dim objformadeentrega As New formadeentrega
    Dim consultaformadeentrega As String = "select * from formadeentrega order by idformadeentrega"
    Dim dsformadeentrega As DataSet = objformadeentrega.cargarDSformadeentrega(consultaformadeentrega, cnn)

    Dim bandGrabar As Integer

    Private Sub frmFormaEntrega_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub
    Private Sub frmFormaEntrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            princ.barra.agregarBoton(Me)
            DataGrid1.DataSource = dsformadeentrega
            DataGrid1.DataMember = "formadeentrega"

            Dim nombrescol(3) As String
            nombrescol(0) = "ID formadeentrega"
            nombrescol(1) = "Nombre"
            nombrescol(2) = "Descripcion"

            Dim anchosgrid(3) As Integer
            anchosgrid(0) = 75
            anchosgrid(1) = 100
            anchosgrid(2) = 100

            ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
            cargarGrilla(DataGrid1, dsformadeentrega.Tables.Item(0), nombrescol, anchosgrid)

            'TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
            txtNombre.Text = CType(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), String)
            txtDescripcion.Text = CType(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), String)

            objformadeentrega.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2))

            'objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4), _
            '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5), _
            '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0))

            objformadeentrega.mostrarDatos(txtNombre.Text, txtDescripcion.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Try
            bandGrabar = 1
            UltraButton1.Enabled = False
            UltraButton2.Enabled = False
            UltraButton3.Enabled = False
            UltraButton4.Enabled = True
            UltraButton5.Enabled = True

            txtNombre.Enabled = True
            txtDescripcion.Enabled = True

            txtNombre.Focus()
            txtNombre.Text = ""
            txtDescripcion.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Try
            bandGrabar = 2
            UltraButton1.Enabled = False
            UltraButton2.Enabled = False
            UltraButton3.Enabled = False
            UltraButton4.Enabled = True
            UltraButton5.Enabled = True
            'TextBox1.Enabled = True
            'ComboBox1.Enabled = True
            txtNombre.Enabled = True
            txtDescripcion.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Try
            objformadeentrega.eliminarformadeentrega(dsformadeentrega)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Try
            objformadeentrega.tomarDatos(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), txtNombre.Text, txtDescripcion.Text)

            If bandGrabar = 1 Then
                objformadeentrega.registrarformadeentrega(dsformadeentrega)
            Else
                objformadeentrega.modificarformadeentrega(dsformadeentrega)
            End If
            If objformadeentrega.varCancelar = 0 Then
                UltraButton1.Enabled = True
                UltraButton2.Enabled = True
                UltraButton3.Enabled = True
                UltraButton4.Enabled = False
                UltraButton5.Enabled = False

                txtNombre.Enabled = False
                txtDescripcion.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False

        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        Try
            objformadeentrega.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2))

            objformadeentrega.mostrarDatos(txtNombre.Text, txtDescripcion.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

End Class