Public Class frmTipoAcabado

    Dim objTipoAcabado As New TipoAcabado
    Dim consultaTipoAcabado As String = "select * from tipoacabado order by nombre"
    Dim dsTipoAcabado As DataSet = objTipoAcabado.cargarDSTAcabado(consultaTipoAcabado, cnn)

    Dim bandGrabar As Integer

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
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
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objTipoAcabado.eliminarTAcabado(dsTipoAcabado)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        objTipoAcabado.tomarDatos(txtNombre.Text, txtDescripcion.Text)

        If bandGrabar = 1 Then
            objTipoAcabado.registrarTAcabado(dsTipoAcabado)
        Else
            objTipoAcabado.modificarTAcabado(dsTipoAcabado)
        End If
        If objTipoAcabado.varCancelar = 0 Then
            UltraButton1.Enabled = True
            UltraButton2.Enabled = True
            UltraButton3.Enabled = True
            UltraButton4.Enabled = False
            UltraButton5.Enabled = False

            txtNombre.Enabled = False
            txtDescripcion.Enabled = False
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
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub frmTipoAcabado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmTipoAcabado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsTipoAcabado
        DataGrid1.DataMember = "TAcabado"

        Dim nombrescol(3) As String
        nombrescol(0) = "ID TipoAcabado"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Descripcion"

        Dim anchosgrid(3) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsTipoAcabado.Tables.Item(0), nombrescol, anchosgrid)

        'TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        txtNombre.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)
        txtDescripcion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)

        objTipoAcabado.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1))

        'objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0))

        objTipoAcabado.mostrarDatos(txtNombre.Text, txtDescripcion.Text)
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        objTipoAcabado.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1))

        objTipoAcabado.mostrarDatos(txtNombre.Text, txtDescripcion.Text)
    End Sub

End Class