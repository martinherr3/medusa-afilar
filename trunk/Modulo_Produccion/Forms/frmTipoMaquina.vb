Public Class frmTipoMaquina
    Dim objTMaquina As New tipoMaquina
    Dim consultaTMaquina As String = "select * from tipomaquina order by idtipo"
    Dim dsTMaquina As DataSet = objTMaquina.cargarDSTMaquina(consultaTMaquina, cnn)

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
        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objTMaquina.eliminarTMaquina(dsTMaquina)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        objTMaquina.tomarDatos(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2), txtNombre.Text, txtDescripcion.Text)

        If bandGrabar = 1 Then
            objTMaquina.registrarTMaquina(dsTMaquina)
        Else
            objTMaquina.modificarTMaquina(dsTMaquina)
        End If
        If objTMaquina.varCancelar = 0 Then
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

    Private Sub frmTipoMaquina_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'princ.barra.eliminarBoton()
    End Sub

    Private Sub frmCargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsTMaquina
        DataGrid1.DataMember = "TMaquina"

        Dim nombrescol(3) As String
        nombrescol(2) = "ID tipo maquina"
        nombrescol(0) = "Nombre"
        nombrescol(1) = "Descripcion"

        Dim anchosgrid(3) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100

        cargarGrilla(DataGrid1, dsTMaquina.Tables.Item(0), nombrescol, anchosgrid)


        txtNombre.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        txtDescripcion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)

        objTMaquina.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1))

        objTMaquina.mostrarDatos(txtNombre.Text, txtDescripcion.Text)
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        objTMaquina.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1))

        objTMaquina.mostrarDatos(txtNombre.Text, txtDescripcion.Text)
    End Sub
End Class