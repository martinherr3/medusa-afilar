Public Class consultarModeloFresa

#Region "Declaraciones"
    Dim ds As New DataSet
    Dim fresa As New TipoFresa
    Dim parteAdicional As New ParteAdicional
    Dim modelo As New ModeloFresa
    Dim filtrar As Boolean
    Const FILTRO_NINGUNO As String = "ninguno"
#End Region


#Region "Evento load formulario"
    Private Sub consultarModeloFresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' seteo el estilo del datagrid 
        modelo.setearGrilla(dataGridMF)
        fresa.setearGrilla(dataGridMF)
        parteAdicional.setearGrilla(dataGridMF)

        ' cargo los datos en el dataset (de las tablas modelofresa, tipofresa, parteadicional)
        modelo.cargarAdaptador()
        modelo.cargarDatos(ds, "modelofresa")
        fresa.cargarAdaptador()
        fresa.cargarDatos(ds, "tipofresa")
        parteAdicional.cargarAdaptador()
        parteAdicional.cargarDatos(ds, "parteadicional")

        ' agrego la columna check los datatables de cada clase
        modelo.agregarCheck(ds)
        'fresa.agregarCheck(ds)
        'parteAdicional.agregarCheck(ds)

        ' pongo la columna check de todas las filas de la tabla en falso para que no me aparezcan seleccionadas 
        Dim i As Integer
        For i = 0 To ds.Tables("modelofresa").Rows.Count - 1
            ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False
        Next

        ' creo las relaciones entre las tablas
        crearRelacion(ds, "modelofresa", "tipofresa", "idmodelo", "idmodelo", "Fresas individuales")
        crearRelacion(ds, "modelofresa", "parteadicional", "idmodelo", "idmodelo", "Partes adicionales")

        ' vinculo el datagrid con el origen de datos
        Dim dataView As New DataView(ds.Tables("modelofresa"))
        dataView.RowFilter = "estado = '" & Constantes.MODELO_FRESA_ESTADO_ALTA & "'"
        dataGridMF.DataSource = dataView

        cmbFiltrar.SelectedIndex = 7

    End Sub
#End Region


#Region "Demas eventos"
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Dim dataView As New DataView(ds.Tables("modelofresa"))

        If (txtFiltrar.Text = "" And cmbFiltrar.SelectedItem.Tag <> FILTRO_NINGUNO) Then
            MsgBox("Debe ingresar condicion a filtrar", MsgBoxStyle.Information)
            filtrar = False
            txtFiltrar.Focus()
            Exit Sub
        End If

        Dim estado As String
        If radioAlta.Checked Then
            estado = Constantes.MODELO_FRESA_ESTADO_ALTA
        Else
            estado = Constantes.MODELO_FRESA_ESTADO_BAJA
        End If


        Select Case cmbFiltrar.SelectedItem.Tag.ToString
            Case "idmodelo"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " = " & txtFiltrar.Text & " And estado = '" & estado & "'"
            Case "precio"
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " = " & txtFiltrar.Text & " And estado = '" & estado & "'"
            Case FILTRO_NINGUNO
                'nothing to do
            Case Else
                dataView.RowFilter = cmbFiltrar.SelectedItem.Tag.ToString & " LIKE '%" & txtFiltrar.Text.Trim & "%'" & " And estado = '" & estado & "'"
        End Select

        dataGridMF.DataSource = dataView


    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click

        Dim fila As DataRow

        If radioAlta.Checked Then
            For Each fila In ds.Tables("modelofresa").Rows

                If fila("seleccionarMF") = True Then
                    modelo.cambiarEstado(fila("idmodelo"), Constantes.MODELO_FRESA_ESTADO_BAJA)

                End If

            Next
        End If

        If radioBaja.Checked Then
            For Each fila In ds.Tables("modelofresa").Rows

                If fila("seleccionarMF") = True Then
                    modelo.cambiarEstado(fila("idmodelo"), Constantes.MODELO_FRESA_ESTADO_ALTA)
                End If

            Next
        End If

        ds.Reset()
        modelo.cargarDatos(ds, "modelofresa")
        fresa.cargarDatos(ds, "tipofresa")
        parteAdicional.cargarDatos(ds, "parteadicional")

        modelo.agregarCheck(ds)

        Dim i As Integer
        For i = 0 To ds.Tables("modelofresa").Rows.Count - 1
            ds.Tables("modelofresa").Rows(i).Item("seleccionarMF") = False
        Next

        crearRelacion(ds, "modelofresa", "tipofresa", "idmodelo", "idmodelo", "Fresas individuales")
        crearRelacion(ds, "modelofresa", "parteadicional", "idmodelo", "idmodelo", "Partes adicionales")

        'dataGridMF.SetDataBinding(ds, "modelofresa")
        Dim dataView As New DataView(ds.Tables("modelofresa"))
        If radioAlta.Checked Then
            dataView.RowFilter = "estado = '" & Constantes.MODELO_FRESA_ESTADO_ALTA & "'"
        Else
            dataView.RowFilter = "estado = '" & Constantes.MODELO_FRESA_ESTADO_BAJA & "'"
        End If

        dataGridMF.DataSource = dataView

    End Sub


    Private Sub radioBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioBaja.CheckedChanged
        btnBaja.Text = "Alta"
        txtFiltrar.Text = ""
        Dim dataView As New DataView(ds.Tables("modelofresa"))
        dataView.RowFilter = "estado = '" & Constantes.MODELO_FRESA_ESTADO_BAJA & "'"

        dataGridMF.DataSource = dataView
    End Sub


    Private Sub radioAlta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioAlta.CheckedChanged
        btnBaja.Text = "Baja"
        txtFiltrar.Text = ""
        Dim dataView As New DataView(ds.Tables("modelofresa"))
        dataView.RowFilter = "estado = '" & Constantes.MODELO_FRESA_ESTADO_ALTA & "'"

        dataGridMF.DataSource = dataView
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim formModificar As New registrarModeloFresa
        With dataGridMF
            formModificar.IdModeloFresa = .Item(.CurrentRowIndex, 1)
        End With

        formModificar.Show()
    End Sub

#End Region


End Class