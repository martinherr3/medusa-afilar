Imports System.Data.SqlClient
Public Class frmEntrega
    Inherits System.Windows.Forms.Form
    Dim dspedido As New DataSet("dspedido")
    'Dim dspedidosel As New DataSet
    Dim tbps As New DataTable
    Dim consulta As String = "select idpedido, fecharealizacion, fechaentrega, prioridad,nombre 'estado', pedido.idestado,pedido.idcliente,idformadeentrega from pedido,estado where pedido.idestado=estado.idestado and estado.nombre='PendienteEntrega' order by prioridad desc"
    '"select idpedido, fecharealizacion, fechaentrega, prioridad,nombre from cliente,estado where pedido.idestado=estado.idestado"
    Dim adaptador As SqlDataAdapter = New SqlDataAdapter(consulta, cnn)
    Dim bandCmb2 As Integer = 0
    Dim dvpedidos As New DataView
    Dim dttpedidos As New DataTable



#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntrega))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Pedidos Pendientes de Entrega"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(10, 40)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(392, 144)
        Me.DataGrid1.TabIndex = 0
        '
        'UltraButton1
        '
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.UltraButton1.Appearance = Appearance1
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.UltraButton1.HotTrackAppearance = Appearance2
        Me.UltraButton1.Location = New System.Drawing.Point(408, 72)
        Me.UltraButton1.Name = "UltraButton1"
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.UltraButton1.PressedAppearance = Appearance3
        Me.UltraButton1.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "&Agregar"
        '
        'UltraButton2
        '
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.UltraButton2.Appearance = Appearance4
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButton2.HotTrackAppearance = Appearance5
        Me.UltraButton2.Location = New System.Drawing.Point(408, 112)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton2.TabIndex = 2
        Me.UltraButton2.Text = "&Quitar"
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "Pedidos a Entregar"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(488, 40)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(288, 144)
        Me.DataGrid2.TabIndex = 3
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(696, 200)
        Me.UltraButton3.Name = "UltraButton3"
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraButton3.PressedAppearance = Appearance6
        Me.UltraButton3.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton3.TabIndex = 10
        Me.UltraButton3.Text = "&Limpiar "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraDateTimeEditor1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 88)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.DateTime = New Date(2005, 10, 1, 0, 0, 0, 0)
        Me.UltraDateTimeEditor1.Enabled = False
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(136, 48)
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(144, 21)
        Me.UltraDateTimeEditor1.TabIndex = 16
        Me.UltraDateTimeEditor1.Value = New Date(2005, 10, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Fecha Real de Entrega"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(105, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Forma de Envio"
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(320, 239)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(88, 25)
        Me.UltraButton5.TabIndex = 18
        Me.UltraButton5.Text = "&Salir"
        '
        'UltraButton4
        '
        Me.UltraButton4.Enabled = False
        Me.UltraButton4.Location = New System.Drawing.Point(320, 208)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(88, 26)
        Me.UltraButton4.TabIndex = 17
        Me.UltraButton4.Text = "&Confirmar"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(104, 8)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Filtrar por forma de entrega"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmEntrega
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(786, 280)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.UltraButton5)
        Me.Controls.Add(Me.UltraButton4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestionar Entrega"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEntrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        'adaptador.Fill(dttpedidos)
        adaptador.Fill(dspedido)
        adaptador.FillSchema(tbps, SchemaType.Mapped)
        DataGrid1.ReadOnly = True
        dvpedidos = dspedido.Tables.Item(0).DefaultView
        'dvpedidos = dttpedidos.DefaultView
        DataGrid1.DataSource = dvpedidos

        Dim nombrescol(7) As String
        nombrescol(0) = "ID Pedido"
        nombrescol(1) = "Fecha Realizacion"
        nombrescol(2) = "Fecha Entrega(Prometida)"
        nombrescol(3) = "Prioridad"
        nombrescol(4) = "Estado"

        Dim anchosgrid(7) As Integer
        anchosgrid(0) = 60
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        anchosgrid(3) = 50
        anchosgrid(4) = 75
        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        'cargarGrilla(DataGrid1, dspedido.Tables.Item(0), nombrescol, anchosgrid)
        cargarGrilla(DataGrid1, dspedido.Tables(0), nombrescol, anchosgrid)
        cargarGrilla(DataGrid2, tbps, nombrescol, anchosgrid)
        'tbps = dspedidosel.Tables.Item(0)
        cargarCombo("select idformadeentrega,nombre from formadeentrega", ComboBox1, "nombre", "idformadeentrega")
        'ComboBox2.Items.Add("Todos")
        cargarCombo("select idformadeentrega,nombre from formadeentrega", ComboBox2, "nombre", "idformadeentrega")

        bandCmb2 = 1
        UltraDateTimeEditor1.Value = Today
    End Sub


    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        Me.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim idclientes(10) As Integer
        Dim tbloc As New DataTable
        'Dim tbid As DataTable = dspedido.Tables.Item(0)
        Dim i As Integer
        For Each updatefila As DataRow In tbps.Rows
            idclientes(i) = updatefila(6)
            i = i + 1
        Next
        Dim adaptadorID As SqlDataAdapter = New SqlDataAdapter("select idcliente,localidad from cliente", cnn)
        adaptadorID.Fill(tbloc)
        Dim j As Integer
        For Each updatefila As DataRow In tbloc.Rows
            For n As Integer = 0 To i
                If updatefila(0) = idclientes(n) Then
                    idlocalidades(j) = updatefila(1)
                    j = j + 1
                End If
            Next
        Next
        bandd = j
        'VERRRRRRRRR
        'idclientes(i) = updatefila(6)
        If ComboBox1.Text <> "Retiro Personal     " And ComboBox1.Text <> "System.Data.DataRowView" Then
            If ComboBox1.Text = "Envio por Viajante  " Then
                bandasignar = 1
            Else
                bandasignar = 0
            End If
            Dim frmE As New frmAsignar
            frmE.Show()
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim tbpedido As DataTable = dspedido.Tables.Item(0)
        If tbpedido.Rows.Count > 0 Then
            Dim fila() As DataRow
            fila = tbps.Select("idpedido=" & DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0))
            If (fila.GetUpperBound(0) = -1) Then
                Dim nuevafila As DataRow
                fila = tbpedido.Select("idpedido=" & DataGrid1.Item(DataGrid1.CurrentCell.RowNumber(), 0))
                nuevafila = tbps.NewRow

                nuevafila(0) = fila(0).Item(0)
                nuevafila(1) = fila(0).Item(1)
                nuevafila(2) = fila(0).Item(2)
                nuevafila(3) = fila(0).Item(3)
                nuevafila(4) = fila(0).Item(4)
                nuevafila(5) = fila(0).Item(5)
                nuevafila(6) = fila(0).Item(6)
                tbps.Rows.Add(nuevafila)
                DataGrid2.DataSource = tbps
            Else
                MsgBox("Pedido ya seleccionado", MsgBoxStyle.Information, "Pedidos")
            End If
            UltraButton4.Enabled = True
            ComboBox1.Enabled = True
        UltraDateTimeEditor1.Enabled = True
        End If
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        If tbps.Rows.Count > 0 Then
            Dim fila() As DataRow
            fila = tbps.Select("idpedido=" & tbps.Rows(DataGrid2.CurrentCell.RowNumber()).Item(0))
            fila(0).Delete()
        End If
        If tbps.Rows.Count = 0 Then
            UltraButton4.Enabled = False
        End If

        'For i As Integer = 0 To tbps.Rows.Count - 1
        '    'If tbps.Rows(i)(0) = dspedidosel.Tables.Item(0).Rows(DataGrid2.CurrentCell.RowNumber()).Item(0) Then
        '    If tbps.Rows(i)(0) = tbps.Rows(DataGrid2.CurrentCell.RowNumber()).Item(0) Then
        '        tbps.Rows(i).Delete()
        '    End If
        'Next

    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        For i As Integer = 0 To tbps.Rows.Count - 1
            tbps.Rows(0).Delete()
        Next
        UltraButton4.Enabled = False
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        If idViajOEmp = 0 Then
            If vbNo = MessageBox.Show("Al no seleccionar una empresa o viajante para la entrega se registrara como Retiro Personal" & vbCrLf & "¿Desea Continuar?", "Registro de Entrega", MessageBoxButtons.YesNo) Then
                Exit Sub
            End If
            ComboBox1.SelectedIndex = 0
        End If
        cnn.Open()
        For Each updatefila As DataRow In tbps.Rows
            For i As Integer = 0 To dspedido.Tables(0).Rows.Count - 1

                If dspedido.Tables.Item(0).Rows(i).Item(0) = updatefila(0) Then
                    dspedido.Tables.Item(0).Rows(i).Item(5) = 3
                    dspedido.Tables.Item(0).Rows(i).Item(5) = ComboBox1.SelectedValue
                    dspedido.Tables.Item(0).Rows(i).Item(4) = "Entregado"
                    updatefila(4) = "Entregado"

                    If ComboBox1.SelectedValue = 2 Then
                        adaptador.UpdateCommand = New SqlCommand("UPDATE Pedido SET idestado =3, idformadeentrega=" & ComboBox1.SelectedValue & ",fecharealentrega='" & UltraDateTimeEditor1.Value & "',idviajante=" & idViajOEmp & " WHERE (idpedido =" & updatefila(0) & ")", cnn)
                    Else
                        If ComboBox1.SelectedValue = 3 Then
                            adaptador.UpdateCommand = New SqlCommand("UPDATE Pedido SET idestado =3, idformadeentrega=" & ComboBox1.SelectedValue & ",fecharealentrega='" & UltraDateTimeEditor1.Value & "',idempresa=" & idViajOEmp & " WHERE (idpedido =" & updatefila(0) & ")", cnn)
                        Else
                            adaptador.UpdateCommand = New SqlCommand("UPDATE Pedido SET idestado =3, idformadeentrega=" & ComboBox1.SelectedValue & ",fecharealentrega='" & UltraDateTimeEditor1.Value & "' WHERE (idpedido =" & updatefila(0) & ")", cnn)
                        End If
                    End If
                    adaptador.UpdateCommand.ExecuteNonQuery()
                End If
            Next
        Next
        ' para finalizar, podemos sacar estos enabled y gestionar de otra forma

        DataGrid2.Enabled = False
        UltraButton1.Enabled = False
        cnn.Close()
        'Dim ocommandbuilder_oc As New SqlClient.SqlCommandBuilder(adaptador)
        'adaptador.UpdateCommand = ocommandbuilder_oc.GetUpdateCommand
        'adaptador.Update(dspedido, "cliente")
        Me.Close()
    End Sub

    Private Sub frmEntrega_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        'If bandCmb2 = 1 Then
        Dim consulta As String
        If ComboBox2.Text = "Retiro Personal     " Then
            dvpedidos.RowFilter = "idformadeentrega=" & 1
        End If
        If ComboBox2.Text = "Envio por Viajante  " Then
            dvpedidos.RowFilter = "idformadeentrega=" & 2
        End If
        If ComboBox2.Text = "Envio por Emp Transp" Then
            dvpedidos.RowFilter = "idformadeentrega=" & 3
        End If
        'End If

    End Sub
End Class
