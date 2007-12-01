Imports System.Data.SqlClient

Public Class consultarOC
    Inherits System.Windows.Forms.Form

    Private DV As DataView
    'Private connect As New coneccion
    Private conn As SqlConnection
    Private DS As DataSet
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private NOrden As Integer


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
    Friend WithEvents grd1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ComboBox1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultarOC))
        Me.grd1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.ComboBox1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.TextBox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd1
        '
        Me.grd1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grd1.CaptionText = "Compras"
        Me.grd1.DataMember = ""
        Me.grd1.FlatMode = True
        Me.grd1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grd1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd1.Location = New System.Drawing.Point(15, 64)
        Me.grd1.Name = "grd1"
        Me.grd1.ReadOnly = True
        Me.grd1.Size = New System.Drawing.Size(560, 272)
        Me.grd1.TabIndex = 0
        Me.grd1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grd1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "dv.table.tablename"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "nroorden"
        Me.DataGridTextBoxColumn4.Width = 750
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filtrar por"
        '
        'DataGrid1
        '
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionText = "Detalle orden de compra"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 349)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(560, 168)
        Me.DataGrid1.TabIndex = 5
        '
        'UltraButton1
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButton1.Appearance = Appearance3
        Me.UltraButton1.Location = New System.Drawing.Point(496, 529)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 6
        Me.UltraButton1.Text = "Salir"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoSize = True
        Me.ComboBox1.Location = New System.Drawing.Point(64, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Location = New System.Drawing.Point(255, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 21)
        Me.TextBox1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(222, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'consultarOC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 565)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.grd1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "consultarOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar orden de compra"
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub consultarOC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)

        conn = cnn
        'conn = connect.conneccion
        conn.Open()

        Dim sql As String = "SELECT OC.nroorden, OC.fecharealizacion, OC.plazodeentrega, E.nombre 'Estado', P.nombre 'Proveedor' " & _
                "FROM ordencompramp OC, proveedor P, estado E " & _
                "WHERE(OC.idproveedor = P.idproveedor And OC.idestado = e.idestado)"

        Dim comm As New SqlCommand(sql, conn)
        Dim DA As New SqlDataAdapter(comm)

        DS = New DataSet
        DA.Fill(DS, "pedidos")

        comm.CommandText = "SELECT TMP.nombre, DOC.cantidad, DOC.precio, DOC.idordencompra " & _
               "FROM detalleordencompra DOC, tipomateriaprima TMP " & _
               "WHERE DOC.idtipomateriaprima = TMP.idtipomateriaprima"

        DA.Fill(DS, "detalle")

        conn.Close()

        DV = New DataView(DS.Tables.Item(0))
        grd1.DataSource = DV

        ComboBox1.Items.Add("Estado")
        ComboBox1.Items.Add("Proveedor")

        Dim nombres(DV.Table.Columns.Count - 1) As String
        Dim anchos(DV.Table.Columns.Count - 1) As Integer

        nombres(0) = "Nro"
        nombres(1) = "Fecha de realizacion"
        nombres(2) = "Plazo entrega"
        nombres(3) = "Estado"
        nombres(4) = "Proveedor"

        anchos(0) = 50
        anchos(1) = 120
        anchos(2) = 80
        anchos(3) = 100
        anchos(4) = 130

        cargarGrilla(grd1, DV.Table, nombres, anchos)

    End Sub


    Private Sub grd1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.Click

        Dim dv2 As New DataView(DS.Tables.Item("detalle"))
        dv2.RowFilter = "idordencompra = " & grd1.Item(grd1.CurrentRowIndex, 0)
        DataGrid1.DataSource = dv2

        DataGrid1.TableStyles.Clear()

        Dim nombres(DV.Table.Columns.Count - 1) As String
        Dim anchos(DV.Table.Columns.Count - 1) As Integer

        nombres(0) = "Nombre"
        nombres(1) = "Cantidad"
        nombres(2) = "Precio"

        anchos(0) = 150
        anchos(1) = 100
        anchos(2) = 100

        cargarGrilla(DataGrid1, dv2.Table, nombres, anchos)

        DataGrid1.CaptionText = "Detalle orden de compra   Nro: " & grd1.Item(grd1.CurrentRowIndex, 0)
    End Sub


    Private Sub grd1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.CurrentCellChanged
        grd1.Select(grd1.CurrentRowIndex())

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

   

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub



    Private Sub TextBox3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.ValueChanged

        If TextBox1.Text.Trim.Length = 0 Then
            DV.RowFilter = ""
        Else
            If Not ComboBox1.Text = "" Then
                DV.RowFilter = ComboBox1.SelectedItem().ToString() & " LIKE '" & TextBox1.Text.Trim & "*'"
            End If
        End If
    End Sub
End Class
