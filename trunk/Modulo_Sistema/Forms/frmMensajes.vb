Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMensajes



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
        'princ.barra.eliminarBoton()
    End Sub

    Private Sub frmDesperfecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarMails()
        'princ.barra.agregarBoton(Me)
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
        ilImages.Images.Add(Bitmap.FromFile("C:\Documents and Settings\Agu699\Mis documentos\Mis imágenes\untitled.bmp"))
        ListView1.SmallImageList = ilImages
        '
        ListView1.Columns.Add("", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("ID", 0, HorizontalAlignment.Left)
        ListView1.Columns.Add("De:", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Asunto", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Fecha", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Prioridad", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("leido ", 0, HorizontalAlignment.Left)
        '
        Dim fila As DataRow
        Dim itm As ListViewItem
        For Each fila In dsMensaje.Tables(0).Rows
            itm = New ListViewItem("", 0)
            itm.SubItems.Add(fila.Item("asunto").ToString)
            itm.SubItems.Add(fila.Item("idmensaje").ToString)
            itm.SubItems.Add(fila.Item("remitente").ToString)
            itm.SubItems.Add(fila.Item("asunto").ToString)
            itm.SubItems.Add(fila.Item("fecharecepion").ToString)
            itm.SubItems.Add(fila.Item("prioridad").ToString)
            itm.SubItems.Add(fila.Item("leido").ToString)
            ListView1.Items.Add(itm)
        Next

        Dim str(5) As String

        'str(0) = "0"
        'str(1) = "pepe"
        'str(2) = "Business Manager"
        'str(3) = "12/10/1982"
        'str(4) = "alta baja"
        'str(5) = "true"






    End Sub

   

    
End Class
