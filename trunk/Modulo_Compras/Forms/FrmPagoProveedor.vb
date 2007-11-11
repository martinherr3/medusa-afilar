Imports System.Data.SqlClient
Public Class FrmPagoProveedor
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Cmbproveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Grdocp As System.Windows.Forms.DataGrid
    Friend WithEvents btnAceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gpboxFormapago As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optionPago As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagoProveedor))
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Cmbproveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Grdocp = New System.Windows.Forms.DataGrid
        Me.btnAceptar = New Infragistics.Win.Misc.UltraButton
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton
        Me.gpboxFormapago = New Infragistics.Win.Misc.UltraGroupBox
        Me.optionPago = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Cmbproveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grdocp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpboxFormapago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpboxFormapago.SuspendLayout()
        CType(Me.optionPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmbproveedor
        '
        Me.Cmbproveedor.AutoSize = True
        Me.Cmbproveedor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.Cmbproveedor.Location = New System.Drawing.Point(96, 12)
        Me.Cmbproveedor.Name = "Cmbproveedor"
        Me.Cmbproveedor.Size = New System.Drawing.Size(160, 21)
        Me.Cmbproveedor.TabIndex = 1
        '
        'Grdocp
        '
        Me.Grdocp.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.Grdocp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Grdocp.BackgroundColor = System.Drawing.Color.LightGray
        Me.Grdocp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grdocp.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Grdocp.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Grdocp.DataMember = ""
        Me.Grdocp.FlatMode = True
        Me.Grdocp.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Grdocp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Grdocp.GridLineColor = System.Drawing.Color.Gainsboro
        Me.Grdocp.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Grdocp.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Grdocp.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Grdocp.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grdocp.LinkColor = System.Drawing.Color.Teal
        Me.Grdocp.Location = New System.Drawing.Point(24, 56)
        Me.Grdocp.Name = "Grdocp"
        Me.Grdocp.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.Grdocp.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.Grdocp.ReadOnly = True
        Me.Grdocp.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Grdocp.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grdocp.Size = New System.Drawing.Size(360, 152)
        Me.Grdocp.TabIndex = 2
        '
        'btnAceptar
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.btnAceptar.Appearance = Appearance5
        Me.btnAceptar.Location = New System.Drawing.Point(296, 224)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 24)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnSalir
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.btnSalir.Appearance = Appearance6
        Me.btnSalir.Location = New System.Drawing.Point(296, 256)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 24)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        '
        'gpboxFormapago
        '
        Me.gpboxFormapago.Controls.Add(Me.optionPago)
        Me.gpboxFormapago.Location = New System.Drawing.Point(24, 232)
        Me.gpboxFormapago.Name = "gpboxFormapago"
        Me.gpboxFormapago.Size = New System.Drawing.Size(168, 48)
        Me.gpboxFormapago.SupportThemes = False
        Me.gpboxFormapago.TabIndex = 5
        Me.gpboxFormapago.Text = "Forma de pago"
        Me.gpboxFormapago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'optionPago
        '
        Me.optionPago.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optionPago.CheckedIndex = 0
        Me.optionPago.ItemAppearance = Appearance7
        ValueListItem3.DataValue = False
        ValueListItem3.DisplayText = "Efectivo"
        ValueListItem3.Tag = False
        ValueListItem4.DataValue = False
        ValueListItem4.DisplayText = "Cheque"
        ValueListItem4.Tag = False
        Me.optionPago.Items.Add(ValueListItem3)
        Me.optionPago.Items.Add(ValueListItem4)
        Me.optionPago.Location = New System.Drawing.Point(24, 24)
        Me.optionPago.Name = "optionPago"
        Me.optionPago.Size = New System.Drawing.Size(128, 16)
        Me.optionPago.TabIndex = 0
        Me.optionPago.Text = "Efectivo"
        '
        'UltraButton1
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.UltraButton1.Appearance = Appearance8
        Me.UltraButton1.Location = New System.Drawing.Point(296, 12)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(88, 38)
        Me.UltraButton1.TabIndex = 6
        Me.UltraButton1.Text = "&Busqueda"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Proveedor:"
        '
        'FrmPagoProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(410, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.gpboxFormapago)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Grdocp)
        Me.Controls.Add(Me.Cmbproveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "FrmPagoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pago Proveedores"
        CType(Me.Cmbproveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grdocp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpboxFormapago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpboxFormapago.ResumeLayout(False)
        CType(Me.optionPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim DS As New DataSet
    Dim dvOCP As New DataView
    Dim SQLdataadapter1 As New SqlDataAdapter("select ordencompramp.idordencompra, max(fecharealizacion) as fecharealizacion, sum (detalleordencompra.precio)as total, max(idproveedor)as idproveedor from ordencompramp join detalleordencompra on ordencompramp.idordencompra=detalleordencompra.idordencompra and ordencompramp.idestado= " & Estado.ORDEN_DE_COMPRA_RECIBIDO & " group by ordencompramp.idordencompra", cnn)

    Private Sub FrmPagoProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        cargarComboTag("select idproveedor, nombre from proveedor", Me.Cmbproveedor, 0, 2)
        cnn.Open()
        SQLdataadapter1.Fill(DS, "OC")
        cnn.Close()
        dvOCP = DS.Tables("oc").DefaultView
        cargar_OCP()


    End Sub

    Private Sub cargar_OCP()

        Grdocp.DataSource = dvOCP
        Dim nom(4) As String
        Dim tam(4) As Integer
        nom(0) = "Id ordencompra"
        nom(1) = "Fecha de realizacion"
        nom(2) = "Total"
        tam(0) = 100
        tam(1) = 100
        tam(2) = 100
        cargarGrilla(Grdocp, dvOCP, nom, tam)
        
    End Sub


    Private Sub Cmbproveedor_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbproveedor.SelectionChangeCommitted
        dvOCP.RowFilter = "idproveedor = " & Cmbproveedor.SelectedItem.Tag

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If MsgBox("Confirma registro de lago", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            Dim formadepago As String
            If optionPago.CheckedIndex = 0 Then
                formadepago = "Efectivo"
            Else
                formadepago = "Cheque"

            End If
            Dim sqlcommandP As New SqlCommand
            Dim sqlcommandoc As New SqlCommand
            sqlcommandoc.CommandType = CommandType.Text
            sqlcommandoc.Connection = cnn
            sqlcommandP.CommandType = CommandType.Text
            sqlcommandP.Connection = cnn
            Try
                cnn.Open()
                sqlcommandP.CommandText = "insert into pago values (" _
                                            & Replace(Grdocp.Item(Grdocp.CurrentCell.RowNumber, 2), ",", ".") _
                                            & ",'" & Today & "' ,'" & formadepago _
                                            & "'," & Grdocp.Item(Grdocp.CurrentCell.RowNumber, 0) & ")"
                'id Estado =7 PAGADO
                sqlcommandoc.CommandText = "update ordencompramp set idestado = " & Estado.ORDEN_DE_COMPRA_PAGADO & " where idordencompra = " & Grdocp.Item(Grdocp.CurrentCell.RowNumber, 0)
                sqlcommandP.ExecuteNonQuery()
                sqlcommandoc.ExecuteNonQuery()
                cnn.Close()
                Me.Close()
            Catch exp As Exception
                MsgBox(exp.Message, MsgBoxStyle.Critical, Me.Text)
                cnn.Close()

        End Try


        End If
    End Sub

    Private Sub FrmPagoProveedor_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim frm As New consultarOC
        frm.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
