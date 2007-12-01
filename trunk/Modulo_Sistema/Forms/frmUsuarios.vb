Public Class frmUsuarios

    Dim objUsuario As New Usuario
    Dim consultaUsuario As String = "select * from cuentausuario"
    Dim dsUsuario As DataSet = objUsuario.cargarDSusuario(consultaUsuario, cnn)

    Dim bandGrabar As Integer

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If Not objUsuario.tieneUsuario(objUsuario.Legajo) Then
            bandGrabar = 1
            UltraButton1.Enabled = False
            UltraButton2.Enabled = False
            UltraButton3.Enabled = False
            UltraButton4.Enabled = True
            UltraButton5.Enabled = True

            txtUsuario.Enabled = True
            txtContraseña.Enabled = True

            txtUsuario.Focus()
            txtUsuario.Text = ""
            txtContraseña.Text = ""
            txtContraseña2.Enabled = True
            txtContraseña3.Enabled = False
            txtContraseña2.Visible = True
            Label2.Visible = True
            txtContraseña3.Visible = False
            Lblvalidacion.Visible = False



        Else
            MsgBox("El empleado ya tiene una cuenta si desea puede modificarla", MsgBoxStyle.OkOnly, "Advertencia")
        End If
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bandGrabar = 2
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True
        txtContraseña2.Enabled = True
        txtContraseña3.Enabled = True
        txtContraseña2.Visible = True
        txtContraseña3.Visible = True
        Lblvalidacion.Visible = True
        Lblvalidacion.Text = "Ingrese contraseña"
        txtContraseña.Text = ""
        txtContraseña2.Text = ""
        txtContraseña3.Text = ""
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        objUsuario.eliminarUsuario(dsUsuario)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click


        objUsuario.tomarDatos(txtUsuario.Text, Criptologia.EncriptarTexto(txtContraseña.Text, txtUsuario.Text, True), Now, lblEmpleado.Tag)

        If bandGrabar = 1 Then
            objUsuario.registrarUsuario(dsUsuario)
        Else
            If seguridad.Validar(Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)), Criptologia.EncriptarTexto(txtContraseña3.Text, Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)), True)) Then
                objUsuario.modificarUsuario(dsUsuario)
            Else
                MsgBox("Ingrese la contraseña correct ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        End If
        If objUsuario.varCancelar = 0 Then
            UltraButton1.Enabled = True
            UltraButton2.Enabled = True
            UltraButton3.Enabled = True
            UltraButton4.Enabled = False
            UltraButton5.Enabled = False
            txtContraseña2.Enabled = True
            txtContraseña3.Enabled = False
            txtContraseña2.Visible = True
            txtContraseña3.Visible = False
            Lblvalidacion.Visible = False
            txtUsuario.Enabled = False
            txtContraseña.Enabled = False
        End If
    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False
        txtContraseña2.Enabled = True
        txtContraseña3.Enabled = False
        txtContraseña2.Visible = False
        txtContraseña3.Visible = False
        Lblvalidacion.Visible = False
        txtUsuario.Enabled = False
        txtContraseña.Enabled = False
        Label2.Visible = False
    End Sub

    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub frmUsuarios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'aca tengo que poner el verdadero id del formulario para que solo pueda ingresar el administrador
        'If Not seguridad.HasPrivilege(10) Then
        '    Me.Close()
        'End If
        princ.barra.agregarBoton(Me)

        DataGrid1.DataSource = dsUsuario
        DataGrid1.DataMember = "Usuario"

        Dim nombrescol(3) As String
        nombrescol(0) = "Usuario"
        nombrescol(1) = "Usuario"
        nombrescol(2) = "Creacion"
        nombrescol(3) = "Empleado"

        Dim anchosgrid(3) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 0
        anchosgrid(2) = 100
        anchosgrid(3) = 100

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsUsuario.Tables.Item(0), nombrescol, anchosgrid)

        'TextBox1.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
        txtUsuario.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)
        txtContraseña.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)

        objUsuario.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3))

        'objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0))

        objUsuario.mostrarDatos(txtUsuario.Text, txtContraseña.Text, Now)

        If Me.Tag <> 0 Then
            lblEmpleado.Text = objUsuario.getCliente(Me.Tag)
            lblEmpleado.Tag= me.tag
        End If
        'lblEmpleado.Tag = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)

        txtContraseña2.Enabled = True
        txtContraseña3.Enabled = False
        txtContraseña2.Visible = False
        txtContraseña3.Visible = False
        Label2.Visible = False
        Lblvalidacion.Visible = False
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        objUsuario.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3))
        objUsuario.mostrarDatos(txtUsuario.Text, txtContraseña.Text, Now)
        lblEmpleado.Text = objUsuario.getCliente(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3))
        lblEmpleado.Tag = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
    End Sub


    
End Class