Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Public Class frmMensajes

    'Private WithEvents taskbarNotifier3 As TaskBarNotifier
    

    'Sub CargarGrdMensajes()


    '    Me.GrdMensajes.CaptionText = ""
    '    Me.grdMensajes.DataSource = dsMensaje
    '    Me.grdMensajes.DataMember = dsMensaje.Tables.Item(0).TableName
    '    Me.GrdMensajes.ReadOnly = True




    '    GrdMensajes.TableStyles.Clear()

    '    Dim grdTableStyle1 As New DataGridTableStyle
    '    grdTableStyle1.MappingName = dsMensaje.Tables.Item(0).TableName
    '    'DS.Tables("tipomateriaprima").TableName
    '    grdTableStyle1.GridLineStyle = DataGridLineStyle.None
    '    grdTableStyle1.SelectionBackColor = Color.Aqua

    '    grdTableStyle1.HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)

    '    'Dim grdColStyle1 As New DataGridTextBoxColumn
    '    Dim grdColStyle1 As New CustomDataGridTextBoxColumn
    '    With grdColStyle1
    '        .MappingName = "remitente"
    '        .HeaderText = "remitente"
    '        .Width = 150
    '    End With

    '    'Dim grdColStyle2 As New DataGridTextBoxColumn
    '    Dim grdColStyle2 As New CustomDataGridTextBoxColumn
    '    With grdColStyle2
    '        .MappingName = "fecharecepion"
    '        .HeaderText = "fecharecepion"
    '        .Width = 80
    '    End With

    '    ''Dim grdColStyle3 As New DataGridTextBoxColumn
    '    'Dim grdColStyle3 As New CustomDataGridTextBoxColumn
    '    'With grdColStyle3
    '    '    .MappingName = "stockminimo"
    '    '    .HeaderText = "Stock minimo"
    '    '    .Width = 80
    '    'End With
    '    '
    '    AddHandler grdColStyle1.PaintRow, AddressOf EstablecerColores
    '    AddHandler grdColStyle2.PaintRow, AddressOf EstablecerColores
    '    'AddHandler grdColStyle3.PaintRow, AddressOf EstablecerColores

    '    '
    '    grdTableStyle1.GridColumnStyles.AddRange(New DataGridColumnStyle() {grdColStyle1, grdColStyle2})
    '    GrdMensajes.TableStyles.Add(grdTableStyle1)

    '    '*********************************************************
    '    'NO SE COMO PONER LAS FILAS QUE YO QUIERA EL OTRO COLOR
    '    'Marcar_MP_Critica()

    'End Sub
    Private Sub EstablecerColores(ByVal args As PaintRowEventArgs)
        'If Me.GrdMensajes.Item(args.RowNumber, 1) < Me.GrdMP.Item(args.RowNumber, 2) Then
        '    args.ForeColor = Brushes.Red
        '    args.BackColor = Brushes.Yellow
        'End If


    End Sub



    Dim objMensaje As New Mensajeria
    Dim consultaMensaje As String = "select mensaje.*, rtrim(remitente.Apellido) +', '+ rtrim(remitente.nombre) as remitente from mensaje join (select * from empleado) remitente on remitente.idlegajo = mensaje.idremitente where iddestinatario = " & seguridad.id & " order by mensaje.fecharecepion"
    Dim dsMensaje As DataSet = objMensaje.cargarDSMensajes(consultaMensaje, cnn)


    Dim bandcombo As Integer
    Dim bandGrabar As Integer



    'Private Sub mostrarPosicion(ByVal tabla As String)
    '    Dim bmbase As BindingManagerBase = BindingContext.Item(dsDesperfecto, tabla)
    '    Dim iTotal As Integer = bmbase.Count
    '    Dim iPos As Integer

    '    If iTotal = 0 Then
    '        Label9.Text = "0"

    '    Else
    '        iPos = bmbase.Position + 1
    '        Label9.Text = iPos.ToString & " de " & iTotal.ToString
    '    End If
    'End Sub

    Private Sub frmDesperfecto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub frmDesperfecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarMails()
        cargarCombo("select rtrim(apellido) + ', ' + rtrim(nombre) as nombre , idlegajo from empleado", cmbEmpleado, "nombre", "idlegajo")
        cmbPrioridad.Items.Add("ALTA")
        cmbPrioridad.Items.Add("MEDIA")
        cmbPrioridad.Items.Add("BAJA")
        cmbPrioridad.SelectedIndex = 2
        cmbempleado.Enabled = False
        txtAsunto.Enabled = False
        cmbPrioridad.Enabled = False
        TextBox1.ReadOnly = True
        btnEnviar.Enabled = False
        btnCancelar.Enabled = False




        princ.barra.agregarBoton(Me)
        'GrdMensajes.DataSource = dsMensaje
        'GrdMensajes.DataMember = "Mensaje"
        'CargarGrdMensajes()
        'Dim ilImages As New ImageList
        'ilImages.Images.Add(Bitmap.FromFile("C:\Documents and Settings\Agu699\Mis documentos\Mis imágenes\untitled.bmp"))

        'ListView1.SmallImageList = ilImages


        'ListView1.Columns.Add(" ID", 150, HorizontalAlignment.Left)
        'ListView1.Columns.Add("De:", 150, HorizontalAlignment.Left)
        'ListView1.Columns.Add("Asunto", 60, HorizontalAlignment.Left)
        'ListView1.Columns.Add("Fecha", 50, HorizontalAlignment.Left)
        'ListView1.Columns.Add("Prioridad", 60, HorizontalAlignment.Left)
        'ListView1.Columns.Add("leido ", 0, HorizontalAlignment.Left)
        'Dim str(5) As String
        'Dim itm As ListViewItem
        ''str(0) = "0"
        ''str(1) = "pepe"
        ''str(2) = "Business Manager"
        ''str(3) = "12/10/1982"
        ''str(4) = "alta baja"
        ''str(5) = "true"
        'itm = New ListViewItem("pepe", 0)
        'itm.SubItems.Add("das")
        'ListView1.Items.Add(itm)
        ListView1.FullRowSelect = True

    End Sub
    Private Sub cargarMails()
        'para las imagenes
        Dim ilImages As New ImageList
        Dim projectPath As String
        projectPath = getAppPath()

        ilImages.Images.Add(Bitmap.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\mail.jpg"))
        ilImages.Images.Add(Bitmap.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\mailNew.jpg"))
        ListView1.SmallImageList = ilImages
        '
        ListView1.Columns.Add("", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("ID", 0, HorizontalAlignment.Left)
        ListView1.Columns.Add("De:", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Asunto", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Fecha", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Prioridad", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("leido ", 0, HorizontalAlignment.Left)
        '
        Dim fila As DataRow
        Dim itm As ListViewItem
        For Each fila In dsMensaje.Tables(0).Rows
            If fila.Item("leido").ToString Then
                itm = New ListViewItem("", 0)
            Else
                itm = New ListViewItem("", 1)
            End If
            itm.SubItems.Add(fila.Item("idmensaje").ToString)
            itm.SubItems.Add(fila.Item("remitente").ToString)
            itm.SubItems.Add(fila.Item("asunto").ToString)
            itm.SubItems.Add(fila.Item("fecharecepion").ToString)
            Dim Font As New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            Select Case fila.Item("prioridad").ToString
                Case 1
                    itm.SubItems.Add("ALTA", Color.Red, Color.DarkRed, Font)
                Case 2
                    itm.SubItems.Add("MEDIA", Color.Black, Color.YellowGreen, Font)
                Case 3
                    itm.SubItems.Add("BAJA", Color.Black, Color.LightSkyBlue, Font)
            End Select


            itm.SubItems.Add(fila.Item("leido").ToString)

            ListView1.Items.Add(itm)
        Next






    End Sub

    
    




    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        

        For Each seleccionado As ListViewItem In CType(sender, ListView).SelectedItems

            TextBox1.Text = objMensaje.obtenerMensaje(seleccionado.SubItems(1).Text)
            objMensaje.marcarLeido(seleccionado.SubItems(1).Text)
            seleccionado.ImageIndex = 0

           
        Next


        
    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As System.Object, _
ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        If Me.ListView1.Sorting = SortOrder.Ascending Then
            Me.ListView1.Sorting = SortOrder.Descending
        Else
            Me.ListView1.Sorting = SortOrder.Ascending
        End If
        Me.ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, Me.ListView1.Sorting)
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click

        objMensaje.enviarMensaje(txtAsunto.Text, seguridad.id, cmbempleado.SelectedValue, TextBox1.Text, cmbPrioridad.SelectedIndex + 1, False, Now, Now)
        cmbempleado.Enabled = False
        txtAsunto.Enabled = False
        cmbPrioridad.Enabled = False
        TextBox1.ReadOnly = True
        btnEnviar.Enabled = False
        btnEliminar.Enabled = True
        btnCancelar.Enabled = False
        TextBox1.Text = ""
        MsgBox("El mensaje se a enviado con exito", MsgBoxStyle.Information, "Envio de mensajes")
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'objMensaje.nuevoMensaje(dsMensaje)
        cmbempleado.Enabled = True
        txtAsunto.Enabled = True
        cmbPrioridad.Enabled = True
        TextBox1.ReadOnly = False
        btnEnviar.Enabled = True
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        TextBox1.Text = ""
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("Seguro desea eliminar este mensaje", MsgBoxStyle.OkCancel, "Eliminacion de mensaje") = MsgBoxResult.Ok Then
            For Each seleccionado As ListViewItem In CType(ListView1, ListView).SelectedItems

                TextBox1.Text = objMensaje.obtenerMensaje(seleccionado.SubItems(1).Text)
                objMensaje.borarMensaje(seleccionado.SubItems(1).Text)
                seleccionado.Remove()

            Next
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        cmbempleado.Enabled = False
        txtAsunto.Enabled = False
        cmbPrioridad.Enabled = False
        TextBox1.ReadOnly = True
        btnEnviar.Enabled = False
        btnEliminar.Enabled = True
        btnCancelar.Enabled = False
    End Sub

    
End Class

Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private sortOrder As SortOrder

    Public Sub New()
        col = 0
        sortOrder = Windows.Forms.SortOrder.Ascending
    End Sub

    Public Sub New(ByVal column As Integer)
        col = column
        sortOrder = Windows.Forms.SortOrder.Ascending
    End Sub

    Public Sub New(ByVal column As Integer, ByVal s As SortOrder)
        col = column
        sortOrder = s
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        If sortOrder = Windows.Forms.SortOrder.Ascending Then
            Return String.Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        Else
            Return String.Compare(CType(y, ListViewItem).SubItems(col).Text, CType(x, ListViewItem).SubItems(col).Text)
        End If

    End Function

End Class
