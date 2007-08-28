Public Class frmEmpleado
    Dim objEmpleado As New Empleado
    Dim consultaEmpleado As String = "select * from empleado order by idlegajo"
    Dim dsEmpleado As DataSet = objEmpleado.cargarDSEmpleado(consultaEmpleado, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer
    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged

    End Sub

    Private Sub frmEmpleado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsEmpleado
        DataGrid1.DataMember = "empleado"

        Dim nombrescol(10) As String
        nombrescol(0) = "ID Empleado"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Apellido"
        nombrescol(4) = "Direccion"
        nombrescol(5) = "Telefono"
        nombrescol(7) = "Titulo"
        nombrescol(8) = "Cargo"

        Dim anchosgrid(10) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(4) = 100
        anchosgrid(5) = 75
        anchosgrid(7) = 75
        anchosgrid(8) = 110

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsEmpleado.Tables.Item(0), nombrescol, anchosgrid)

        cargarCombo("select idcargo,nombre from cargo", cboCargo, "nombre", "idcargo")
        cargarCombo("select idlocalidad,nombre from localidad", cboLocalidad, "nombre", "idlocalidad")

        'TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        txtNombre.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        txtApellido.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
        txtDireccion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
        txtTelefono.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
        txtMail.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6)
        txtTitulo.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)
        txtTurno.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9)

        cboCargo.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5)

        cboLocalidad.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8)

        objEmpleado.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0))

        'objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0))

        objEmpleado.mostrarDatos(txtNombre.Text, cboCargo.SelectedValue, txtDireccion.Text, cboLocalidad.SelectedValue, txtMail.Text, _
        txtTelefono.Text, txtTitulo.Text, txtApellido.Text, txtTurno.Text)
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        objEmpleado.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0))

        objEmpleado.mostrarDatos(txtNombre.Text, cboCargo.SelectedValue, txtDireccion.Text, cboLocalidad.SelectedValue, txtMail.Text, _
        txtTelefono.Text, txtTitulo.Text, txtApellido.Text, txtTurno.Text)
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        bandGrabar = 1
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True

        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        txtMail.Enabled = True
        txtTitulo.Enabled = True
        txtTurno.Enabled = True

        cboCargo.Enabled = True
        cboLocalidad.Enabled = True

        txtNombre.Focus()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
        txtTitulo.Text = ""
        txtTurno.Text = ""
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
        txtApellido.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        txtMail.Enabled = True
        txtTitulo.Enabled = True
        txtTurno.Enabled = True
        cboCargo.Enabled = True
        cboLocalidad.Enabled = True
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objEmpleado.eliminarEmpleado(dsEmpleado)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click

        objEmpleado.tomarDatos(txtNombre.Text, cboCargo.SelectedValue, txtDireccion.Text, cboLocalidad.SelectedValue, txtMail.Text, _
                               txtTelefono.Text, txtTitulo.Text, txtTurno.Text, txtApellido.Text, DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))

        If bandGrabar = 1 Then
            objEmpleado.registrarEmpleado(dsEmpleado)
        Else
            objEmpleado.modificarEmpleado(dsEmpleado)
        End If
        If objEmpleado.varCancelar = 0 Then
            UltraButton1.Enabled = True
            UltraButton2.Enabled = True
            UltraButton3.Enabled = True
            UltraButton4.Enabled = False
            UltraButton5.Enabled = False

            txtNombre.Enabled = False
            txtApellido.Enabled = False
            txtDireccion.Enabled = False
            txtTelefono.Enabled = False
            txtMail.Enabled = False
            txtTitulo.Enabled = False
            txtTurno.Enabled = False
            cboCargo.Enabled = False
            cboLocalidad.Enabled = False
        End If

    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDireccion.Enabled = False
        txtTelefono.Enabled = False
        txtMail.Enabled = False
        txtTitulo.Enabled = False
        txtTurno.Enabled = False
        cboCargo.Enabled = False
        cboLocalidad.Enabled = False
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub





    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(dsEmpleado, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label9.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label9.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(dsEmpleado, "empleado").Position -= 1
        mostrarPosicion("empleado")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dsEmpleado, "empleado").Position = 0
        mostrarPosicion("empleado")
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dsEmpleado, "empleado").Position = BindingContext(dsEmpleado, "empleado").Count - 1
        mostrarPosicion("empleado")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dsEmpleado, "empleado").Position += 1
        mostrarPosicion("empleado")
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        'Por ahora, despues controlo su funcionamiento.

        'If Len(txtNombre.Text) > 0 Then
        '    objEmpleado.tomarDatos(txtNombre.Text, cboCargo.SelectedValue, txtDireccion.Text, cboLocalidad.SelectedValue, txtMail.Text, _
        '                            txtTelefono.Text, txtTitulo.Text, txtTurno.Text, txtApellido.Text, DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))

        '    If Not objEmpleado.validarEmpleado(dsEmpleado) Then
        '        txtNombre.Focus()
        '        MsgBox("Nombre existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
        '    End If
        'End If
    End Sub

    Private Sub txtNombreBuscar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.ValueChanged
        'dsEmpleado.Tables(0).DefaultView.RowFilter = "nombre like '" & txtNombreBuscar.Text & "%'"
        'DataGrid1.DataSource = dsEmpleado
        'DataGrid1.DataMember = "empleado"
        DataGrid1.DataSource = buscarEmpleados(dsEmpleado)
    End Sub

    Private Function buscarEmpleados(ByVal DataSetEmpleado As DataSet) As DataView

        Dim tbcliente As DataTable = DataSetEmpleado.Tables.Item(0)

        Dim dv As DataView = tbcliente.DefaultView

        dv.RowFilter = "nombre like '" & txtNombreBuscar.Text & "%'"
        Return dv
    End Function

    Private Sub UltraButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton11.Click
        Dim form As New frmUsuarios
        'form.MdiParent = Me
        form.Tag = objEmpleado.id
        form.Show()
    End Sub

End Class
