Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmAsignar
    Inherits System.Windows.Forms.Form
    Dim dsAsignar As New DataSet("dsAsignar")
    '"select idpedido, fecharealizacion, fechaentrega, prioridad,nombre from cliente,estado where pedido.idestado=estado.idestado"
    Dim adaptadorAsig As SqlDataAdapter
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignar))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.CaptionText = "Listado de Entregadores"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid1.Location = New System.Drawing.Point(16, 48)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(320, 152)
        Me.DataGrid1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 1
        '
        'DataGrid2
        '
        Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid2.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid2.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.CaptionText = "Destinos Permitidos"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.FlatMode = True
        Me.DataGrid2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid2.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid2.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid2.Location = New System.Drawing.Point(376, 48)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid2.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid2.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.Size = New System.Drawing.Size(192, 152)
        Me.DataGrid2.TabIndex = 2
        '
        'UltraButton2
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButton2.Appearance = Appearance1
        Me.UltraButton2.Location = New System.Drawing.Point(488, 206)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 34)
        Me.UltraButton2.TabIndex = 6
        Me.UltraButton2.Text = "&Cancelar"
        '
        'UltraButton1
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.Location = New System.Drawing.Point(376, 206)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 34)
        Me.UltraButton1.TabIndex = 5
        Me.UltraButton1.Text = "&Confirmar"
        '
        'frmAsignar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 246)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 106)
        Me.Name = "frmAsignar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Asignacion para Entrega"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAsignar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim consulta As String
        Dim nombrescol(4) As String
        If bandasignar = 1 Then
            DataGrid1.CaptionText = "Vendedores-Viajantes"
            consulta = "select idlegajo, nombre, apellido, telefono from empleado where idcargo=2"
            nombrescol(0) = "ID Legajo"
            nombrescol(1) = "Nombre"
            nombrescol(2) = "Apellido"
            nombrescol(3) = "Telefono"
        Else
            DataGrid1.CaptionText = "Empresas de Transporte"
            consulta = "select idempresa, nombre, direccion, telefono from empresatransporte"
            nombrescol(0) = "ID Empresa"
            nombrescol(1) = "Nombre"
            nombrescol(2) = "Direccion"
            nombrescol(3) = "Telefono"
        End If
        adaptadorAsig = New SqlDataAdapter(consulta, cnn)
        adaptadorAsig.Fill(dsAsignar)
        DataGrid1.ReadOnly = True
        DataGrid1.DataSource = dsAsignar.Tables.Item(0)

        Dim anchosgrid() As Integer = {50, 100, 100, 50}
        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsAsignar.Tables.Item(0), nombrescol, anchosgrid)

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        Dim identregador As Integer
        identregador = dsAsignar.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0)
        Dim adaptadorDestinos As SqlDataAdapter
        Dim dsDestinos As New DataSet
        Dim consulta As String
        If bandasignar = 1 Then
            consulta = "select localidad.idlocalidad, localidad.nombre from viajantexlocalidad, localidad where localidad.idlocalidad=viajantexlocalidad.idlocalidad and idviajante=" & identregador
        Else
            consulta = "select localidad.idlocalidad, localidad.nombre from empresaxlocalidad, localidad where localidad.idlocalidad=empresaxlocalidad.idlocalidad and idempresa=" & identregador
        End If
        adaptadorDestinos = New SqlDataAdapter(consulta, cnn)
        adaptadorDestinos.Fill(dsDestinos)
        DataGrid2.ReadOnly = True
        DataGrid2.DataSource = dsDestinos.Tables.Item(0)
        Dim bandCont As Integer
        Dim bandCoincidencia As Boolean
        bandCoincidencia = True
        For i As Integer = 0 To bandd - 1
            For Each updatefila As DataRow In dsDestinos.Tables(0).Rows

                If idlocalidades(i) <> updatefila(0) Then
                    bandCont = bandCont + 1
                End If

            Next
            If bandCont = dsDestinos.Tables(0).Rows.Count Then
                bandCoincidencia = False
            End If
            bandCont = 0
        Next
        If bandCoincidencia = False Then
            MsgBox("No coincide los destinos del pedido con el mensajero", MsgBoxStyle.Information, "Destinos")
        End If

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        idViajOEmp = 0
        Me.Close()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If dsAsignar.Tables(0).Rows.Count > 0 Then
            idViajOEmp = dsAsignar.Tables.Item(0).Rows(DataGrid1.CurrentCell.RowNumber()).Item(0)
            Me.Close()
        Else
            MessageBox.Show("No hay eleccion", "Eleccion de Entrega", MessageBoxButtons.OK)
        End If
    End Sub
End Class
