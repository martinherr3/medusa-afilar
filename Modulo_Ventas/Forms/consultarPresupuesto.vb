Public Class consultarPresupuesto

#Region "Declaraciones"
    Private presupuesto As New presupuesto
    Private detallePresupuesto As New detallePresupuesto
    Private ds As New DataSet
    Private tsPresupuesto As DataGridTableStyle
    Private tsDetallePresupuesto As DataGridTableStyle
    Private desdeFormPedido As Boolean = False
    Private idCliente As Integer
#End Region


#Region "Properties"
    'TODO
#End Region


#Region "Eventos y otros metodos"

    Private Sub consultarPresupuesto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub consultarPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        princ.barra.agregarBoton(Me)

        'periodo inicial (ultimo mes)
        Dim desde As Date
        If Now.Month = 1 Then
            desde = New Date(Now.Year - 1, 12, Now.Day)
        Else
            desde = New Date(Now.Year, Now.Month - 1, Now.Day)
        End If

        dateDesde.Value = desde
        dateHasta.Value = Now

        'seteo interfaz
        cmbFiltrar.Text = "Ninguno"
        setearGrilla(dataGridPresupuesto)

        'Presupuesto
        presupuesto.cargarAdaptador()
        presupuesto.cargarDatos(ds, "Presupuesto")

        'Detalle presupuesto
        detallePresupuesto.cargarAdaptador()
        detallePresupuesto.cargarDatos(ds, "detallePresupuesto")

        'Creo la relacion
        crearRelacion(ds, "Presupuesto", "detallePresupuesto", "idpresupuesto", "idpresupuesto", "Detalle de presupuesto")

        'muestro datos en la grilla
        Dim dv As New DataView(ds.Tables("Presupuesto"))
        dataGridPresupuesto.DataSource = dv

    End Sub



    Public Sub setearGrilla(ByVal dataGrid As DataGrid)
        'Presupuesto
        tsPresupuesto = New DataGridTableStyle
        tsPresupuesto.MappingName = "presupuesto"

        Dim c1 As New grdstyle.CGridTextBoxStyle("idpresupuesto", 100, HorizontalAlignment.Center, True, "ID Presupuesto", "", "")
        tsPresupuesto.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("fecha", 150, HorizontalAlignment.Center, True, "Fecha", "", "")
        tsPresupuesto.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("nombreCliente", 230, HorizontalAlignment.Center, True, "Cliente", "", "")
        tsPresupuesto.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("nombreEmpleado", 230, HorizontalAlignment.Center, True, "Empleado", "", "")
        tsPresupuesto.GridColumnStyles.Add(c4)

        dataGrid.TableStyles.Add(tsPresupuesto)

        'Detalle Presupuesto
        tsDetallePresupuesto = New DataGridTableStyle
        tsDetallePresupuesto.MappingName = "detallePresupuesto"

        Dim c5 As New grdstyle.CGridTextBoxStyle("idmodelo", 50, HorizontalAlignment.Center, True, "ID Modelo", "", "")
        tsDetallePresupuesto.GridColumnStyles.Add(c5)

        Dim c6 As New grdstyle.CGridTextBoxStyle("nombreModelo", 150, HorizontalAlignment.Center, True, "Modelo", "", "")
        tsDetallePresupuesto.GridColumnStyles.Add(c6)

        Dim c7 As New grdstyle.CGridTextBoxStyle("tipoProducto", 150, HorizontalAlignment.Center, True, "Tipo Producto", "", "")
        tsDetallePresupuesto.GridColumnStyles.Add(c7)

        Dim c8 As New grdstyle.CGridTextBoxStyle("nombreProducto", 150, HorizontalAlignment.Center, True, "Nombre Producto", "", "")
        tsDetallePresupuesto.GridColumnStyles.Add(c8)

        Dim c9 As New grdstyle.CGridTextBoxStyle("cantidad", 50, HorizontalAlignment.Center, True, "Cantidad", "", "")
        tsDetallePresupuesto.GridColumnStyles.Add(c9)

        Dim c10 As New grdstyle.CGridTextBoxStyle("precio", 50, HorizontalAlignment.Center, True, "Precio", "", "")
        tsDetallePresupuesto.GridColumnStyles.Add(c10)

        dataGrid.TableStyles.Add(tsDetallePresupuesto)


    End Sub


    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim consulta As String = ""

        If checkFecha.Checked = True Then
            ds = presupuesto.selectPorFecha(dateDesde.Value, dateHasta.Value)
            detallePresupuesto.cargarDatos(ds, "detallePresupuesto")
        Else
            ds = presupuesto.selectTodo()
            detallePresupuesto.cargarDatos(ds, "detallePresupuesto")
        End If

        'Creo la relacion
        crearRelacion(ds, "Presupuesto", "detallePresupuesto", "idpresupuesto", "idpresupuesto", "Detalle de presupuesto")

        Dim dataView As New DataView(ds.Tables("presupuesto"))
        Dim filtrar As Boolean
        Const FILTRO_NINGUNO As String = "ninguno"

        If (txtFiltrar.Text = "" And cmbFiltrar.SelectedItem.Tag <> FILTRO_NINGUNO) Then
            MsgBox("Debe ingresar condicion a filtrar", MsgBoxStyle.Information)
            filtrar = False
            txtFiltrar.Focus()
            Exit Sub
        End If

        Select Case cmbFiltrar.SelectedItem.Tag.ToString
            Case "idpresupuesto"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " = " & txtFiltrar.Text
            Case "nombreCliente"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " LIKE '%" & txtFiltrar.Text.Trim & "%'"
            Case FILTRO_NINGUNO
                'nothing to do
            Case Else
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " LIKE '%" & txtFiltrar.Text.Trim & "%'"
        End Select

        dataGridPresupuesto.DataSource = dataView

        dataGridPresupuesto.Refresh()

    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnRealizarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarPedido.Click
        Dim pedido As New frmpedidocliente

        Dim fechaPermitida As Date
        If Now.Month = 1 Then
            fechaPermitida = New Date(Now.Year - 1, 12, Now.Day)
        Else
            fechaPermitida = New Date(Now.Year, Now.Month - Constantes.PEDIDO_PRESUPUESTO_TIEMPO, Now.Day)
        End If

        Dim fechaEmision As New Date

        fechaEmision = (dataGridPresupuesto.Item(dataGridPresupuesto.CurrentRowIndex, 1))
        If fechaEmision.Date < fechaPermitida.Date Then
            If MsgBox("El presupuesto tiene mas de un mes, decea realizar el pedido?", MsgBoxStyle.YesNo, "Afilar") = MsgBoxResult.Yes Then
                Try
                    pedido.IdPesupuesto = dataGridPresupuesto.Item(dataGridPresupuesto.CurrentRowIndex, 0)
                    'MsgBox(pedido.IdPesupuesto)
                    pedido.Location = New System.Drawing.Point(196, 150)
                    pedido.Show(princ)
                Catch
                    'nada
                End Try
            End If
        Else
            Try
                pedido.IdPesupuesto = dataGridPresupuesto.Item(dataGridPresupuesto.CurrentRowIndex, 0)
                pedido.Location = New System.Drawing.Point(196, 150)
                pedido.Show(princ)
            Catch
                'nada
            End Try
        End If

    End Sub

#End Region


End Class