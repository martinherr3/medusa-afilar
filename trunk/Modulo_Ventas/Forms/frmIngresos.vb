Public Class frmIngresos
    Dim objcliente As New Cliente
    Dim consultacliente As String = "select idcliente, nombre, apellido, Localidad, Direccion, Telefono, Mail, Celular, documento, idtipodocumento from cliente order by idcliente"
    Dim dscliente As DataSet = objcliente.cargarDSCliente(consultacliente, cnn)
    Dim dsPedidos As DataSet
    Dim dsIngresos As DataSet
    Dim objPedidos As pedido

    Private Sub frmIngresos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'princ.barra.eliminarBoton()
    End Sub
    Private Sub frmIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'princ.barra.agregarBoton(Me)
        cargarCombo("select idtipodocumento,nombre from tipodocumento", cboTipoDoc, "nombre", "idtipodocumento")
        cargarCombo("select idtipodocumento,nombre from tipodocumento", cboTipoDoc2, "nombre", "idtipodocumento")
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If Not IsNumeric(txtNumero.Text) Then
            MessageBox.Show("Debe un numero valido")
            Exit Sub
        End If

        objcliente.tomarDatos("", cboTipoDoc.SelectedValue, "", 0, "", "", CType(txtNumero.Text, Decimal), "", "", 0)

        Dim Cliente As DataRow()
        Cliente = objcliente.buscarCliente(dscliente)

        If (Cliente.GetUpperBound(0) = -1) Then
            MsgBox("No existe el cliente")
            txtNumero.Focus()
            Exit Sub
        Else
            txtNombre.Text = Cliente(0).Item(1)
            txtApellido.Text = Cliente(0).Item(2)
        End If

        objPedidos = New pedido
        dsPedidos = objPedidos.buscarPedidos(CType(Cliente(0).Item(0), Integer), 8)

        grd1.DataSource = dsPedidos.Tables(0)

        formatoGrilla(dsPedidos)
    End Sub

    Private Sub formatoGrilla(ByRef DS As DataSet)
        DS.Tables("pedidos").Columns.Add("seleccionar", Type.GetType("System.Boolean"))
        'End If

        Dim ts As New DataGridTableStyle
        ts.MappingName = "pedidos"

        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionar", 30, HorizontalAlignment.Center, False, "", "", False, True, False, Nothing)
        ts.GridColumnStyles.Add(c0)

        Dim c1 As New grdstyle.CGridTextBoxStyle("idpedido", 70, HorizontalAlignment.Center, True, "Pedido Nro.", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("fechaRealizacion", 130, HorizontalAlignment.Center, True, "Fecha Realizacion", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("nombre", 130, HorizontalAlignment.Center, True, "Estado", "", "")
        ts.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("total", 100, HorizontalAlignment.Center, True, "total", "", "")
        ts.GridColumnStyles.Add(c4)

        Dim c5 As New grdstyle.CGridTextBoxStyle("nombre1", 120, HorizontalAlignment.Center, True, "Cliente", "", "")
        ts.GridColumnStyles.Add(c5)

        grd1.TableStyles.Add(ts)

        Dim i As Integer
        For i = 0 To DS.Tables("pedidos").Rows.Count - 1
            DS.Tables("pedidos").Rows(i).Item("seleccionar") = False
        Next
    End Sub

    Private Sub grd1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.Click
        If grd1.CurrentRowIndex() = -1 Then
            Exit Sub
        End If
        grd1.Select(grd1.CurrentRowIndex())

        If grd1.Item(grd1.CurrentRowIndex(), 0) = True Then
            grd1.Item(grd1.CurrentRowIndex(), 0) = False

        Else
            grd1.Item(grd1.CurrentRowIndex(), 0) = True

        End If

        txtTotalPagar.Text = calcularTotal(dsPedidos)
    End Sub

    Private Function calcularTotal(ByVal DS As DataSet) As Double
        Dim j As DataRow
        Dim k As Double
        For Each j In DS.Tables("Pedidos").Rows
            If j("seleccionar") = True Then
                k = k + CType(j("total"), Double)
            End If
        Next

        Return k
    End Function

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        If CType(txtTotalPagar.Text, Double) = 0 Then
            MessageBox.Show("Debe selecionar un pedido")
            Exit Sub
        End If

        If txtMonto.Text = "" Then
            MessageBox.Show("Debe ingresar un Monto")
            Exit Sub
        End If
        If CType(txtMonto.Text, Double) < CType(txtTotalPagar.Text, Double) Then
            MessageBox.Show("Monto insuficiente, ingreso un nuevo monto o seleccione otro conjunto de pedidos")
            Exit Sub
        End If

        txtDevolucion.Text = CType(txtMonto.Text, Double) - CType(txtTotalPagar.Text, Double)


        Dim j As DataRow
        For Each j In dsPedidos.Tables("Pedidos").Rows
            If j("seleccionar") = True Then
                objPedidos.ActualizarPedido(j("idpedido"), 9)
            End If
        Next

        MessageBox.Show("La Transaccion se registro con exito")

        Me.Close()
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        If txtNumero2.Text = "" Then
            MessageBox.Show("Debe Ingresar el numero")
            Exit Sub
        End If

        Dim objCliente2 As New Cliente
        objCliente2.tomarDatos("", cboTipoDoc2.SelectedValue, "", 0, "", "", CType(txtNumero2.Text, Decimal), "", "", 0)

        Dim Cliente As DataRow()
        Cliente = objCliente2.buscarCliente(dscliente)

        If (Cliente.GetUpperBound(0) = -1) Then
            MsgBox("No existe el cliente")
            txtNumero.Focus()
            Exit Sub
        End If
        Dim objIngresos As pedido
        objIngresos = New pedido
        dsIngresos = objIngresos.buscarPedidos(CType(Cliente(0).Item(0), Integer), 9)

        grd2.DataSource = dsIngresos.Tables(0)
    End Sub
End Class