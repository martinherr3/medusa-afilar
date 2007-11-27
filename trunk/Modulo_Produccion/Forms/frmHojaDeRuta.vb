Imports System.Data.SqlClient
Public Class frmHojaDeRuta
    Public ds As New DataSet
    Private Sub frmHojaDeRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim da As New SqlClient.SqlDataAdapter("select hojaderuta.idhojaderuta as 'Hoja de ruta', hojaderuta.fechainicioproduccion as 'Fecha de inicio de produccion', nroserie as 'Nro serie',  nropedido as Pedido, rtrim(estado.nombre) as Estado , tipofresa.nombre as NombreFresa  from Fresa inner join  hojaderuta on Fresa.idhojaderuta = hojaderuta.idhojaderuta inner join Estado on Fresa.estado = Estado.idestado inner join tipofresa on fresa.idtipo = tipofresa.idtipo and fresa.idmodelo = tipofresa.idmodelo", cnn)
        da.Fill(ds)
        dgHoja.DataSource = ds.Tables(0)
        cmbCriterio.Items.Add("Pedido")
        cmbCriterio.Items.Add("Estado")
        cmbCriterio.Items.Add("Tipo de fresa")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As Form1
        Dim i As Integer
        Dim ban As Boolean
        ban = False
        For i = 0 To dgHoja.SelectedRows.Count - 1
            frm = New Form1
            frm.pNrofresa = dgHoja.SelectedRows(i).Cells(2).Value
            frm.Show()
            If IsDBNull(dgHoja.SelectedRows(i).Cells(1).Value) Then
                registrarLanzamiento(dgHoja.SelectedRows(i).Cells(0).Value, dgHoja.SelectedRows(i).Cells(2).Value)
                ban = True
            End If
        Next
        If ban Then
            MsgBox("Generacion de hojas de ruta finalizada con exito", MsgBoxStyle.Information, "Impresor de Hojas de rutas")
        End If
    End Sub

    Private Sub registrarLanzamiento(ByVal idhojaderuta As Integer, ByVal nrofresa As Integer)
        Dim conn As SqlConnection
        conn = cnn
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If

        Dim sql As String
        Dim comm As SqlCommand
        sql = "update hojaderuta set fechainicioproduccion = getdate() where idhojaderuta = " & idhojaderuta
        comm = New SqlCommand(sql, conn)
        comm.ExecuteScalar()
        sql = "update fresa set estado = " & Estado.FRESA_HRASIGNADA & " where nroserie = " & nrofresa
        comm = New SqlCommand(sql, conn)
        comm.ExecuteScalar()
        conn.Close()
    End Sub
    Private Function buscar(ByVal DS As DataSet) As DataView

        Dim tbhojaruta As DataTable = DS.Tables.Item(0)
        Dim dv As DataView
        dv = tbhojaruta.DefaultView
        Select Case cmbCriterio.Text
            Case "Pedido"
                If txtBusqueda.Text <> "" Then
                    dv.RowFilter = "Pedido = '" & txtBusqueda.Text & "'"
                Else
                    dv.RowFilter = "Estado like '%'"
                End If
            Case "Estado"
                dv.RowFilter = "Estado like '" & txtBusqueda.Text & "%'"
            Case "Tipo de fresa"
                dv.RowFilter = "nombrefresa like '" & txtBusqueda.Text & "%'"
        End Select



        Return dv
    End Function

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        dgHoja.DataSource = buscar(ds)
    End Sub
End Class