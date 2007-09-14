Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMaquina

    Inherits System.Windows.Forms.Form
    Dim objMaquina As New Maquina
    Dim consultaMaquina As String = "select * from maquina order by idmaquina"
    Dim dsMaquina As DataSet = objMaquina.cargarDSMaquina(consultaMaquina, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer



    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(dsMaquina, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label9.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label9.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub frmMaquina_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'princ.barra.eliminarBoton()
    End Sub

    Private Sub frmMaquina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsMaquina
        DataGrid1.DataMember = "Maquina"

        Dim nombrescol(9) As String
        nombrescol(0) = "ID Maquina"
        nombrescol(1) = "Nombre"
        nombrescol(2) = "Descripcion"
        nombrescol(3) = "Numero de serie"
        nombrescol(4) = "Potencia"
        nombrescol(5) = "Costo de compra"
        nombrescol(6) = "Estado de adquisicion"
        nombrescol(7) = "Estado"
        nombrescol(8) = "Horas de uso"
        nombrescol(9) = "Tipo de maquina"


        Dim anchosgrid(9) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(3) = 100
        anchosgrid(4) = 75
        anchosgrid(5) = 75
        anchosgrid(6) = 75
        anchosgrid(7) = 75
        anchosgrid(8) = 75
        anchosgrid(9) = 75

        txtNumMaquina.Text = 0
        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource

        cargarCombo("select * from estado", cmbEstado, "nombre", "idestado")
        cargarCombo("select * from tipomaquina", cmbTipoMAquina, "nombre", "idtipo")

        cargarGrilla(DataGrid1, dsMaquina.Tables.Item(0), nombrescol, anchosgrid)
        If dsMaquina.Tables.Item(0).Rows.Count > 0 Then


            txtNumMaquina.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0)
            txtNombre.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
            txtDescripcion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
            txtNumeroSerie.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
            txtPotencia.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
            txtCostoCompra.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5)
            txtEstadoAdquisicion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6)
            cmbEstado.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)
            txtHorasUso.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8)
            cmbTipoMAquina.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9)
            'arreglar


            objMaquina.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                            DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), _
                            DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9))

        Else
            UltraButton2.Enabled = False
            UltraButton3.Enabled = False

        End If
        'objMaquina.mostrarDatos(cmbTipoMaquina.SelectedValue, CalendarRotura.Value, txtCausa.Text, CalendarReparacion.Value, Double.Parse(txtCosto.Text), cmbMaquina.SelectedValue, txtNumMaquina.Text)
    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click

        bandGrabar = 1
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True
        UltraButton6.Enabled = False
        UltraButton7.Enabled = False
        UltraButton8.Enabled = False
        UltraButton9.Enabled = False

        txtNumMaquina.Text = objMaquina.getNewID(dsMaquina)
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtNumeroSerie.Text = "0"
        txtPotencia.Text = "0"
        txtCostoCompra.Text = "0"
        txtEstadoAdquisicion.Text = ""
        cmbEstado.SelectedValue = 0
        txtHorasUso.Text = "0"
        Try
            cmbTipoMAquina.SelectedIndex = 0
        Catch
            MsgBox("La operacion no puede continuar ya que no existe ningun tipo de maquina disponible", MsgBoxStyle.OkOnly, "Error de Carga")
            UltraButton5.PerformClick()
            Exit Sub
        End Try
        txtNumMaquina.Enabled = False
        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
        txtNumeroSerie.Enabled = True
        txtPotencia.Enabled = True
        txtCostoCompra.Enabled = True
        txtEstadoAdquisicion.Enabled = True
        cmbEstado.Enabled = True
        txtHorasUso.Enabled = True
        cmbTipoMAquina.Enabled = True


    End Sub


    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bandGrabar = 2
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True

        txtNumMaquina.Enabled = False
        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
        txtNumeroSerie.Enabled = True
        txtPotencia.Enabled = True
        txtCostoCompra.Enabled = True
        txtEstadoAdquisicion.Enabled = True
        cmbEstado.Enabled = True
        txtHorasUso.Enabled = True
        cmbTipoMAquina.Enabled = True

    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        'objMaquina.eliminarMaquina(dsMaquina)
        'Por ahora no se eliminan
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Try
            objMaquina.tomarDatos(txtNumMaquina.Text, txtNombre.Text, txtDescripcion.Text, txtNumeroSerie.Text, txtPotencia.Text, _
            Double.Parse(txtCostoCompra.Text), txtEstadoAdquisicion.Text, cmbEstado.SelectedValue, Integer.Parse(txtHorasUso.Text), _
            cmbTipoMAquina.Text)
        Catch
            MsgBox("Verifique que los datos ingresados sean correctos", MsgBoxStyle.Information, "Error de carga")
            Exit Sub
        End Try
        If bandGrabar = 1 Then
            objMaquina.registrarMaquina(dsMaquina)
        Else
            objMaquina.modificarMaquina(dsMaquina)
        End If
        If objMaquina.varCancelar = 0 Then
            UltraButton1.Enabled = True
            UltraButton2.Enabled = True
            UltraButton3.Enabled = True
            UltraButton4.Enabled = False
            UltraButton5.Enabled = False
            UltraButton6.Enabled = True
            UltraButton7.Enabled = True
            UltraButton8.Enabled = True
            UltraButton9.Enabled = True



            txtNombre.Enabled = False
            txtDescripcion.Enabled = False
            txtNumeroSerie.Enabled = False
            txtPotencia.Enabled = False
            txtCostoCompra.Enabled = False
            txtEstadoAdquisicion.Enabled = False
            cmbEstado.Enabled = False
            txtHorasUso.Enabled = False
            cmbTipoMAquina.Enabled = False

        End If

    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        UltraButton1.Enabled = True
        UltraButton2.Enabled = True
        UltraButton3.Enabled = True
        UltraButton4.Enabled = False
        UltraButton5.Enabled = False
        UltraButton6.Enabled = True
        UltraButton7.Enabled = True
        UltraButton8.Enabled = True
        UltraButton9.Enabled = True

        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
        txtNumeroSerie.Enabled = False
        txtPotencia.Enabled = False
        txtCostoCompra.Enabled = False
        txtEstadoAdquisicion.Enabled = False
        cmbEstado.Enabled = False
        txtHorasUso.Enabled = False
        cmbTipoMAquina.Enabled = False
    End Sub


    'Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If Len(TextBox1.Text) > 0 Then
    '        TextBox2.Enabled = True
    '        TextBox3.Enabled = True
    '        TextBox4.Enabled = True
    '        TextBox5.Enabled = True
    '        TextBox6.Enabled = True
    '        TextBox7.Enabled = True
    '        ComboBox2.Enabled = True
    '    Else
    '        TextBox2.Enabled = False
    '        TextBox3.Enabled = False
    '        TextBox4.Enabled = False
    '        TextBox5.Enabled = False
    '        TextBox6.Enabled = False
    '        TextBox7.Enabled = False
    '        ComboBox2.Enabled = False
    '    End If
    'End Sub


    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Len(txtNumMaquina.Text) > 0 Then
        '    'podria ser asi objcliente.validarCliente(dscliente, txtDocumento, cmbtipodoc)
        '    'pero prefiero usar el tomarDatos() ya creado 
        '    objMaquina.tomarDatos(txtNumMaquina.Text, cmbTipoMaquina.SelectedValue, CalendarRotura.Value, txtCausa.Text, CalendarReparacion.Value, Double.Parse(txtCosto.Text), cmbMaquina.SelectedValue)
        '    If Not objMaquina.validarMaquina(dsMaquina) Then
        '        'TextBox2.Focus()
        '        MsgBox("Documento existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
        '    End If
        'End If
    End Sub

    Private Sub frmCliente_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'princ.barra.eliminarBoton()
    End Sub



    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dsMaquina, "Maquina").Position = BindingContext(dsMaquina, "Maquina").Count - 1
        mostrarPosicion("Maquina")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dsMaquina, "Maquina").Position = 0
        mostrarPosicion("Maquina")
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(dsMaquina, "Maquina").Position -= 1
        mostrarPosicion("Maquina")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dsMaquina, "Maquina").Position += 1
        mostrarPosicion("Maquina")
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        objMaquina.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 8), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 9))

        objMaquina.mostrarDatos(txtNumMaquina.Text, txtNombre.Text, txtDescripcion.Text, txtNumeroSerie.Text, txtPotencia.Text, txtCostoCompra.Text, txtEstadoAdquisicion.Text, cmbEstado.SelectedValue, txtHorasUso.Text, cmbTipoMAquina.Text)


        'TextBox2.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(1)
        'TextBox3.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(3)
        'TextBox4.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(4)
        'TextBox5.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(5)
        'TextBox6.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(6)
        'TextBox1.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(7)
        'TextBox7.Text = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(9)
        'ComboBox1.SelectedValue = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(8)
        'ComboBox2.SelectedValue = dscliente.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(2)
        'DataGrid1.CurrentCell.RowNumber()
        'dscliente.Tables.Item(0).Rows(BindingContext(dscliente, "cliente").Position).Item(1)
    End Sub

    'Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub






    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        Me.Close()
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged

    End Sub

    'Private Sub TextBox1_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
    '    'If Len(TextBox1.Text) > 0 Then
    '    '    'podria ser asi objcliente.validarCliente(dscliente, txtDocumento, cmbtipodoc)
    '    '    'pero prefiero usar el tomarDatos() ya creado 
    '    '    objcliente.tomarDatos(TextBox2.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.SelectedValue, TextBox5.Text, _
    '    '    TextBox4.Text, CType(TextBox1.Text, Decimal), textBox6.Text, TextBox7.Text, DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
    '    '    If Not objcliente.validarCliente(dscliente) Then
    '    '        TextBox2.Focus()
    '    '        MsgBox("Documento existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
    '    '    End If
    '    'End If
    'End Sub



    Private Sub UltraButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim form As New frmUsuarios
        '' form.MdiParent = Me
        'form.Tag = objcliente.id
        'form.Show()
    End Sub

    Private Function buscarMaquina(ByVal DataSetMaquina As DataSet) As DataView

        Dim tbMaquina As DataTable = DataSetMaquina.Tables.Item(0)

        Dim dv As DataView = tbMaquina.DefaultView

        dv.RowFilter = "nombre like '" & UltraTextEditor1.Text & "%'"
        Return dv
    End Function

    Private Sub UltraTextEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraTextEditor1.ValueChanged
        DataGrid1.DataSource = buscarMaquina(dsMaquina)
    End Sub
End Class