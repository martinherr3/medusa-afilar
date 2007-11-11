'TENGO QUE SACAR LA NABEGABILIDAD Y PONER EL PANE DE BUSQUEDA PRIMERO CUANDO HABRIS EL FORMULARIO 
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDesperfecto
    Inherits System.Windows.Forms.Form
    Dim objDesperfecto As New Desperfecto
    Dim consultaDesperfecto As String = "select * from desperfecto order by iddesperfecto"
    Dim dsDesperfecto As DataSet = objDesperfecto.cargarDSDesperfecto(consultaDesperfecto, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer



    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(dsDesperfecto, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label9.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label9.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub frmDesperfecto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'princ.barra.eliminarBoton()
    End Sub

    Private Sub frmDesperfecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'princ.barra.agregarBoton(Me)
        DataGrid1.DataSource = dsDesperfecto
        DataGrid1.DataMember = "Desperfecto"

        Dim nombrescol(9) As String
        nombrescol(0) = "ID Desperfecto"
        nombrescol(1) = "ID Tipo"
        nombrescol(2) = "Fecha Rotura"
        nombrescol(3) = "Causa"
        nombrescol(4) = "Fecha Reparacion"
        nombrescol(5) = "Costo"
        nombrescol(6) = "Nro Maquina"
        nombrescol(7) = "Reparado"

        Dim anchosgrid(9) As Integer
        anchosgrid(0) = 75
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(3) = 100
        anchosgrid(4) = 75
        anchosgrid(5) = 75
        anchosgrid(6) = 75
        anchosgrid(7) = 0
        txtNumDesperfecto.Text = 0
        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsDesperfecto.Tables.Item(0), nombrescol, anchosgrid)

        cargarCombo("select idtipodesperfecto, nombre from tipodesperfecto", cmbTipoDesperfecto, "nombre", "idtipodesperfecto")
        cargarCombo("select idmaquina, nombre from maquina", cmbMaquina, "nombre", "idmaquina")
        cargarCombo("select idmaquina, nombre from maquina", cmbMaquinaSearch, "nombre", "idmaquina")

        If dsDesperfecto.Tables.Item(0).Rows.Count <> 0 Then
            CalendarRotura.Value = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2)
            txtCausa.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3)
            CalendarReparacion.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4)
            txtCosto.Text = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5)
            cmbTipoDesperfecto.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1)
            cmbMaquina.SelectedValue = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6)


            objDesperfecto.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                            DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6))

        End If
        'objDesperfecto.mostrarDatos(cmbTipoDesperfecto.SelectedValue, CalendarRotura.Value, txtCausa.Text, CalendarReparacion.Value, Double.Parse(txtCosto.Text), cmbMaquina.SelectedValue, txtNumDesperfecto.Text)
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

        cmbMaquina.SelectedValue = 0
        cmbTipoDesperfecto.SelectedValue = 0
        txtCausa.Text = ""
        txtCosto.Text = "0"
        txtNumDesperfecto.Text = objDesperfecto.getNewID(dsDesperfecto)
        CalendarReparacion.Value = Now
        CalendarRotura.Value = Now

        cmbMaquina.Enabled = True
        cmbTipoDesperfecto.Enabled = True
        txtCausa.Enabled = True
        txtCosto.Enabled = True
        txtNumDesperfecto.Enabled = False
        CalendarReparacion.Visible = False
        CalendarRotura.Enabled = True
        
        
    End Sub


    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        bandGrabar = 2
        UltraButton1.Enabled = False
        UltraButton2.Enabled = False
        UltraButton3.Enabled = False
        UltraButton4.Enabled = True
        UltraButton5.Enabled = True

        cmbMaquina.Enabled = True
        cmbTipoDesperfecto.Enabled = True
        txtCausa.Enabled = True
        txtCosto.Enabled = True
        txtNumDesperfecto.Enabled = False
        CalendarReparacion.Enabled = True
        CalendarRotura.Enabled = True
        
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        'objDesperfecto.eliminarDesperfecto(dsDesperfecto)
        'Por ahora no se eliminan
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Try
            objDesperfecto.tomarDatos(txtNumDesperfecto.Text, cmbTipoDesperfecto.SelectedValue, CalendarRotura.Value, txtCausa.Text, CalendarReparacion.Text, txtCosto.Text, cmbMaquina.SelectedValue)

            If bandGrabar = 1 Then
                objDesperfecto.registrarDesperfecto(dsDesperfecto)
            ElseIf bandGrabar = 2 Then
                objDesperfecto.modificarDesperfecto(dsDesperfecto)
            ElseIf bandGrabar = 3 Then
                objDesperfecto.registrarReparacion(dsDesperfecto)
            End If
            If objDesperfecto.varCancelar = 0 Then
                UltraButton1.Enabled = True
                UltraButton2.Enabled = True
                UltraButton3.Enabled = True
                UltraButton4.Enabled = False
                UltraButton5.Enabled = False
                UltraButton6.Enabled = True
                UltraButton7.Enabled = True
                UltraButton8.Enabled = True
                UltraButton9.Enabled = True


                cmbMaquina.Enabled = False
                cmbTipoDesperfecto.Enabled = False
                txtCausa.Enabled = False
                txtCosto.Enabled = False
                txtNumDesperfecto.Enabled = False
                CalendarReparacion.Enabled = False
                CalendarRotura.Enabled = False

            End If
        Catch
            MsgBox("La operacion no puede continuar", MsgBoxStyle.Information, "Operacion cancelada")
        End Try
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
        Try
            CalendarReparacion.Visible = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)
            BtnReparacion.Enabled = Not (DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7))
        Catch
        End Try
        cmbMaquina.Enabled = False
        cmbTipoDesperfecto.Enabled = False
        txtCausa.Enabled = False
        txtCosto.Enabled = False
        txtNumDesperfecto.Enabled = False
        'CalendarReparacion.Enabled = False
        CalendarRotura.Enabled = False
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
        'If Len(txtNumDesperfecto.Text) > 0 Then
        '    'podria ser asi objcliente.validarCliente(dscliente, txtDocumento, cmbtipodoc)
        '    'pero prefiero usar el tomarDatos() ya creado 
        '    objDesperfecto.tomarDatos(txtNumDesperfecto.Text, cmbTipoDesperfecto.SelectedValue, CalendarRotura.Value, txtCausa.Text, CalendarReparacion.Value, Double.Parse(txtCosto.Text), cmbMaquina.SelectedValue)
        '    If Not objDesperfecto.validarDesperfecto(dsDesperfecto) Then
        '        'TextBox2.Focus()
        '        MsgBox("Documento existente, se recomienda comprobar los datos", MsgBoxStyle.OkOnly, "Control")
        '    End If
        'End If
    End Sub

    Private Sub frmCliente_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'princ.barra.eliminarBoton()
    End Sub

    

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(dsDesperfecto, "Desperfecto").Position = BindingContext(dsDesperfecto, "Desperfecto").Count - 1
        mostrarPosicion("Desperfecto")
    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        BindingContext(dsDesperfecto, "Desperfecto").Position = 0
        mostrarPosicion("Desperfecto")
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        BindingContext(dsDesperfecto, "Desperfecto").Position -= 1
        mostrarPosicion("Desperfecto")
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(dsDesperfecto, "Desperfecto").Position += 1
        mostrarPosicion("Desperfecto")
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        objDesperfecto.tomarDatos(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 1), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 2), _
                        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 3), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 4), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 5), DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 6))

        objDesperfecto.mostrarDatos(cmbTipoDesperfecto.SelectedValue, CalendarRotura.Value, txtCausa.Text, CalendarReparacion.Value, txtCosto.Text, cmbMaquina.SelectedValue, txtNumDesperfecto.Text)
        CalendarReparacion.Visible = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7)
        BtnReparacion.Enabled = Not (DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 7))
        Me.Refresh()
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

    Private Function buscarDesperfecto(ByVal DataSetDesperfecto As DataSet) As DataView

        Dim tbDesperfecto As DataTable = DataSetDesperfecto.Tables.Item(0)

        Dim dv As DataView = tbDesperfecto.DefaultView
        Dim query As String
        query = ""
        If opcNoReparado.Checked Then
            query = "causa like '" & UltraTextEditor1.Text & "%' and reparado = " & False
        ElseIf OpcReparado.Checked Then
            query = "causa like '" & UltraTextEditor1.Text & "%' and reparado = " & True
        ElseIf OpcTodo.Checked Then
            query = "causa like '" & UltraTextEditor1.Text & "%'"
        End If
        If checkMaqina.Checked Then
            query = query & " and idmaquina = " & cmbMaquinaSearch.SelectedValue
        End If
        dv.RowFilter = query
        Return dv
    End Function

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        'DataGrid1.DataSource = dsDesperfecto
        'DataGrid1.DataMember = "Desperfecto"

    End Sub
    Private Sub UltraTextEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraTextEditor1.ValueChanged
        DataGrid1.DataSource = buscarDesperfecto(dsDesperfecto)
    End Sub

   
    
    
    Private Sub OpcReparado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcReparado.CheckedChanged
        DataGrid1.DataSource = buscarDesperfecto(dsDesperfecto)
    End Sub

    Private Sub opcNoReparado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcNoReparado.CheckedChanged
        DataGrid1.DataSource = buscarDesperfecto(dsDesperfecto)
    End Sub

    Private Sub OpcTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcTodo.CheckedChanged
        DataGrid1.DataSource = buscarDesperfecto(dsDesperfecto)
    End Sub

    Private Sub BtnReparacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReparacion.Click
        If MsgBox("Seguro que desea registrar la reparacion de esta maquina", MsgBoxStyle.OkCancel, "Confirmacion") = MsgBoxResult.Ok Then
            CalendarReparacion.Visible = True
            CalendarReparacion.Enabled = True

            UltraButton1.Enabled = False
            UltraButton2.Enabled = False
            UltraButton3.Enabled = False
            UltraButton4.Enabled = True
            UltraButton5.Enabled = True
            BtnReparacion.Enabled = True
            bandGrabar = 3
        End If

    End Sub

    
    Private Sub cmbMaquinaSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaquinaSearch.SelectedIndexChanged
        DataGrid1.DataSource = buscarDesperfecto(dsDesperfecto)
    End Sub

    Private Sub UltraTabPageControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles UltraTabPageControl2.Paint
        'DataGrid1.DataSource = dsDesperfecto.Tables.Item(0).DefaultView
    End Sub

    Private Sub checkMaqina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkMaqina.CheckedChanged

        cmbMaquinaSearch.Enabled = checkMaqina.Checked
        DataGrid1.DataSource = buscarDesperfecto(dsDesperfecto)
    End Sub

End Class