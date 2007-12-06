Public Class frmUnidadDeMedida
    Dim objUnidadDeMedida As New UnidadDeMedida
    Dim consultaUnidadDeMedida As String = "select * from UnidadDeMedida order by idUnidadMedida"
    Dim dsUnidadDeMedida As DataSet = objUnidadDeMedida.cargarDSUnidadDeMedida(consultaUnidadDeMedida, cnn)

    Dim bandGrabar As Integer

    Private Sub frmUnidadDeMedida_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub


    Private Sub frmUnidadDeMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsUnidadDeMedida
        DataGrid1.DataMember = "UnidadDeMedida"

        Dim nombrescol(5) As String
        nombrescol(0) = "ID UnidadDeMedida"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Descripcion"
        nombrescol(3) = "Abreviacion"
        nombrescol(4) = "Escala"

        Dim anchosgrid(5) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 80
        anchosgrid(2) = 80
        anchosgrid(3) = 80
        anchosgrid(4) = 50

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsUnidadDeMedida.Tables.Item(0), nombrescol, anchosgrid)

        Try
            'TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
            txtNombre.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
            txtDescripcion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
            txtAbreviacion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
            txtEscala.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)

            objUnidadDeMedida.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4))

            'objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4), _
            '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5), _
            '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0))

            objUnidadDeMedida.mostrarDatos(txtNombre.Text, txtDescripcion.Text, txtAbreviacion.Text, txtEscala.Text)
        Catch

        End Try
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        bandGrabar = 1
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True

        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
        txtAbreviacion.Enabled = True
        txtEscala.Enabled = True

        txtNombre.Focus()
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtAbreviacion.Text = ""
        txtEscala.Text = ""
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
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
        txtAbreviacion.Enabled = True
        txtEscala.Enabled = True
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objUnidadDeMedida.eliminarUnidadDeMedida(dsUnidadDeMedida)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Try
            objUnidadDeMedida.tomarDatos(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), txtNombre.Text, txtDescripcion.Text, txtAbreviacion.Text, txtEscala.Text)
        Catch
            'NADA   
        End Try

        If bandGrabar = 1 Then
            objUnidadDeMedida.registrarUnidadDeMedida(dsUnidadDeMedida)
        Else
            objUnidadDeMedida.modificarUnidadDeMedida(dsUnidadDeMedida)
        End If
        If objUnidadDeMedida.varCancelar = 0 Then
            UltraButton1.Enabled = True
            UltraButton2.Enabled = True
            UltraButton3.Enabled = True
            UltraButton4.Enabled = False
            UltraButton5.Enabled = False

            txtNombre.Enabled = False
            txtDescripcion.Enabled = False
            txtAbreviacion.Enabled = False
            txtEscala.Enabled = False
        End If
    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False

        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
        txtAbreviacion.Enabled = False
        txtEscala.Enabled = False
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        Try
            objUnidadDeMedida.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4))

            objUnidadDeMedida.mostrarDatos(txtNombre.Text, txtDescripcion.Text, txtAbreviacion.Text, txtEscala.Text)
        Catch
            'NADA
        End Try
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub
End Class