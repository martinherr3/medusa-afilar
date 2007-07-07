Public Class frmLocalidad
    Dim objLocalidad As New Localidad
    Dim consultaLocalidad As String = "select * from localidad order by idlocalidad"
    Dim dsLocalidad As DataSet = objLocalidad.cargarDSLocalidad(consultaLocalidad, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer

    Private Sub frmLocalidad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub
    Private Sub frmLocalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        dgLocalidades.DataSource = dsLocalidad
        dgLocalidades.DataMember = "Localidad"

        Dim nombrescol(6) As String
        nombrescol(0) = "ID Localidad"
        nombrescol(1) = "Codigo Postal"
        nombrescol(2) = "Zona"
        nombrescol(3) = "Provincia Abrev"
        nombrescol(4) = "Distancia"
        nombrescol(5) = "Nombre"
        nombrescol(6) = "IdProvincia"

        Dim anchosgrid(6) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(3) = 100
        anchosgrid(4) = 100
        anchosgrid(5) = 100
        anchosgrid(6) = 100

        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(dgLocalidades, dsLocalidad.Tables.Item(0), nombrescol, anchosgrid)

        cargarCombo("select idprovincia,nombre from provincia", cboProvincia, "nombre", "idprovincia")

        txtCodigoPostal.Text = dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 1)
        txtZona.Text = dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 2)
        txtProvinciaAbrev.Text = dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 3)
        txtDistancia.Text = dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 4)
        txtNombre.Text = dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 5)

        cboProvincia.SelectedValue = dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 6)


        objLocalidad.tomarDatos(dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 0), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 1), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 2), _
        dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 3), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 4), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 5), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 6))

        'objcliente.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5), _
        '                        dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2), dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0))

        objLocalidad.mostrarDatos(txtCodigoPostal.Text, txtZona.Text, txtProvinciaAbrev.Text, txtDistancia.Text, _
        txtNombre.Text, cboProvincia.SelectedValue)
    End Sub

    Private Sub dgLocalidades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLocalidades.CurrentCellChanged
        If IsDBNull(dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 0)) Then
            Exit Sub
        End If

        objLocalidad.tomarDatos(dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 0), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 1), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 2), _
        dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 3), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 4), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 5), dgLocalidades.Item(dgLocalidades.CurrentCell.RowNumber(), 6))

        objLocalidad.mostrarDatos(txtCodigoPostal.Text, txtZona.Text, txtProvinciaAbrev.Text, txtDistancia.Text, _
        txtNombre.Text, cboProvincia.SelectedValue)
    End Sub

    Private Sub dgLocalidades_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgLocalidades.Navigate

    End Sub

    Private Sub btNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevo.Click
        bandGrabar = 1
        btNuevo.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False
        btGrabar.Enabled = True
        btCancelar.Enabled = True

        txtNombre.Enabled = True
        txtCodigoPostal.Enabled = True
        txtZona.Enabled = True
        txtDistancia.Enabled = True
        txtProvinciaAbrev.Enabled = True
        cboProvincia.Enabled = True


        txtNombre.Text = ""
        txtCodigoPostal.Text = ""
        txtZona.Text = ""
        txtDistancia.Text = ""
        txtProvinciaAbrev.Text = ""

        txtNombre.Focus()

    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        bandGrabar = 2
        btNuevo.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False
        btGrabar.Enabled = True
        btCancelar.Enabled = True

        txtNombre.Enabled = True
        txtCodigoPostal.Enabled = True
        txtZona.Enabled = True
        txtDistancia.Enabled = True
        txtProvinciaAbrev.Enabled = True
        cboProvincia.Enabled = True
    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        objLocalidad.eliminarLocalidad(dsLocalidad)
    End Sub

    Private Sub btGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGrabar.Click
        objLocalidad.tomarDatos(dgLocalidades.Item(dgLocalidades.CurrentRowIndex, 0), txtCodigoPostal.Text, txtZona.Text, txtProvinciaAbrev.Text, txtDistancia.Text, _
        txtNombre.Text, cboProvincia.SelectedValue)

        If bandGrabar = 1 Then
            objLocalidad.registrarLocalidad(dsLocalidad)
        Else
            objLocalidad.modificarLocalidad(dsLocalidad)
        End If
        If objLocalidad.varCancelar = 0 Then
            btNuevo.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
            btGrabar.Enabled = False
            btCancelar.Enabled = False


            txtNombre.Enabled = False
            txtCodigoPostal.Enabled = False
            txtZona.Enabled = False
            txtDistancia.Enabled = False
            txtProvinciaAbrev.Enabled = False
            cboProvincia.Enabled = False
        End If

    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        btNuevo.Enabled = True
        btModificar.Enabled = True
        btEliminar.Enabled = True
        btGrabar.Enabled = False
        btCancelar.Enabled = False


        txtNombre.Enabled = False
        txtCodigoPostal.Enabled = False
        txtZona.Enabled = False
        txtDistancia.Enabled = False
        txtProvinciaAbrev.Enabled = False
        cboProvincia.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class