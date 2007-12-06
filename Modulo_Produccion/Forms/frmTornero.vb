Public Class frmTornero
    Dim objTornero As New Tornero
    Dim consultaTornero As String = "select * from tornero order by idtornero"
    Dim dsTornero As DataSet = objtornero.cargarDSTornero(consultaTornero, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer
    
    'descomentar cuando termine
    Private Sub frmTornero_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmTornero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsTornero
        DataGrid1.DataMember = "Tornero"

        Dim nombrescol(10) As String
        nombrescol(0) = "ID Tornero"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Apellido"
        nombrescol(3) = "Direccion"
        nombrescol(4) = "Telefono"
        nombrescol(5) = "Celular"
        nombrescol(6) = "Cantidad tornedos"
        nombrescol(7) = "Efectividad"
        nombrescol(8) = "Observaciones"

        Dim anchosgrid(10) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(3) = 100
        anchosgrid(4) = 75
        anchosgrid(5) = 75
        anchosgrid(6) = 25
        anchosgrid(7) = 50
        anchosgrid(8) = 200

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsTornero.Tables.Item(0), nombrescol, anchosgrid)
        If dsTornero.Tables.Item(0).Rows.Count <> 0 Then
            txtNombre.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
            txtApellido.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
            txtDireccion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
            txtTelefono.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
            txtCelular.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5)
            txtCantidad.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6)
            txtEfectividad.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)
            txtObservaciones.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8)





            objTornero.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                            DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), _
                            DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8))

            objTornero.mostrarDatos(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, _
            txtCantidad.Text, txtEfectividad.Text, txtObservaciones.Text)
        End If
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDireccion.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        txtCantidad.Enabled = False
        txtEfectividad.Enabled = False
        txtObservaciones.Enabled = False
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        objTornero.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8))

        objTornero.mostrarDatos(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, _
        txtCantidad.Text, txtEfectividad.Text, txtObservaciones.Text)

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
        txtCelular.Enabled = True
        txtCantidad.Enabled = True
        txtEfectividad.Enabled = True
        txtObservaciones.Enabled = True

        txtNombre.Focus()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtCantidad.Text = ""
        txtEfectividad.Text = ""
        txtObservaciones.Text = ""
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bandGrabar = 2
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
       
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        txtCantidad.Enabled = True
        txtEfectividad.Enabled = True
        txtObservaciones.Enabled = True
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objTornero.eliminarTornero(dsTornero)
        txtApellido.Text = ""
        txtCantidad.Text = ""
        txtCelular.Text = ""
        txtDireccion.Text = ""
        txtEfectividad.Text = ""
        txtNombre.Text = ""
        txtObservaciones.Text = ""
        txtTelefono.Text = ""

    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click


        Try
            If bandGrabar = 1 Then

                objTornero.tomarDatos(1, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, _
           txtCantidad.Text, txtEfectividad.Text, txtObservaciones.Text)
                objTornero.registrarTornero(dsTornero)
            Else

                objTornero.tomarDatos(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, _
           txtCantidad.Text, txtEfectividad.Text, txtObservaciones.Text)
                objTornero.modificarTornero(dsTornero)
            End If
        
            If objTornero.varCancelar = 0 Then
                UltraButton1.Enabled = True
                UltraButton2.Enabled = True
                UltraButton3.Enabled = True
                UltraButton4.Enabled = False
                UltraButton5.Enabled = False


                txtNombre.Enabled = False
                txtApellido.Enabled = False
                txtDireccion.Enabled = False
                txtTelefono.Enabled = False
                txtCelular.Enabled = False
                txtCantidad.Enabled = False
                txtEfectividad.Enabled = False
                txtObservaciones.Enabled = False
            End If
        Catch
            MsgBox("El sistema no puede continuar con la operacion, por favor verifique los datos ingresados", MsgBoxStyle.Information, "Error de carga de datos")
        End Try
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
        txtCelular.Enabled = False
        txtCantidad.Enabled = False
        txtEfectividad.Enabled = False
        txtObservaciones.Enabled = False
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub





    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(dsTornero, tabla)
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
        BindingContext(dsTornero, "Tornero").Position -= 1
        mostrarPosicion("Tornero")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dsTornero, "Tornero").Position = 0
        mostrarPosicion("Tornero")
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dsTornero, "Tornero").Position = BindingContext(dsTornero, "Tornero").Count - 1
        mostrarPosicion("Tornero")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dsTornero, "Tornero").Position += 1
        mostrarPosicion("Tornero")
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
        DataGrid1.DataSource = buscarTornero(dsTornero)
    End Sub

    Private Function buscarTornero(ByVal DataSetTornero As DataSet) As DataView

        Dim tbTornero As DataTable = DataSetTornero.Tables.Item(0)

        Dim dv As DataView = tbTornero.DefaultView

        dv.RowFilter = "nombre like '" & txtNombreBuscar.Text & "%'"
        Return dv
    End Function

    Private Sub UltraButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim form As New frmUsuarios
        'form.MdiParent = Me
        form.Tag = objTornero.id
        form.Show()
    End Sub
End Class