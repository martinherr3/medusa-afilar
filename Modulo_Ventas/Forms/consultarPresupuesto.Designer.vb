<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultarPresupuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultarPresupuesto))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dataGridPresupuesto = New System.Windows.Forms.DataGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dateHasta = New System.Windows.Forms.DateTimePicker
        Me.dateDesde = New System.Windows.Forms.DateTimePicker
        Me.cmbFiltrar = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnFiltrar = New Infragistics.Win.Misc.UltraButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFiltrar = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.checkFecha = New System.Windows.Forms.CheckBox
        Me.btnRealizarPedido = New Infragistics.Win.Misc.UltraButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.dataGridPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridPresupuesto
        '
        Me.dataGridPresupuesto.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dataGridPresupuesto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridPresupuesto.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataGridPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridPresupuesto.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dataGridPresupuesto.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridPresupuesto.CaptionText = "Presupuestos"
        Me.dataGridPresupuesto.DataMember = ""
        Me.dataGridPresupuesto.FlatMode = True
        Me.dataGridPresupuesto.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dataGridPresupuesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridPresupuesto.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dataGridPresupuesto.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dataGridPresupuesto.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dataGridPresupuesto.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dataGridPresupuesto.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridPresupuesto.LinkColor = System.Drawing.Color.Teal
        Me.dataGridPresupuesto.Location = New System.Drawing.Point(15, 93)
        Me.dataGridPresupuesto.Name = "dataGridPresupuesto"
        Me.dataGridPresupuesto.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dataGridPresupuesto.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridPresupuesto.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dataGridPresupuesto.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridPresupuesto.Size = New System.Drawing.Size(784, 293)
        Me.dataGridPresupuesto.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(414, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Desde"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(416, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Hasta"
        '
        'dateHasta
        '
        Me.dateHasta.Location = New System.Drawing.Point(453, 56)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.Size = New System.Drawing.Size(201, 20)
        Me.dateHasta.TabIndex = 35
        '
        'dateDesde
        '
        Me.dateDesde.Location = New System.Drawing.Point(453, 30)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.Size = New System.Drawing.Size(201, 20)
        Me.dateDesde.TabIndex = 34
        '
        'cmbFiltrar
        '
        Me.cmbFiltrar.AutoSize = True
        ValueListItem1.DataValue = "ValueListItem0"
        ValueListItem1.DisplayText = "Nombre cliente"
        ValueListItem1.Tag = "nombreCliente"
        ValueListItem2.DataValue = "ValueListItem3"
        ValueListItem2.DisplayText = "Nombre empleado"
        ValueListItem2.Tag = "nombreEmpleado"
        ValueListItem3.DataValue = "ValueListItem1"
        ValueListItem3.DisplayText = "Nro. presupuesto"
        ValueListItem3.Tag = "idpresupuesto"
        Appearance1.FontData.BoldAsString = "True"
        ValueListItem4.Appearance = Appearance1
        ValueListItem4.DataValue = "ValueListItem7"
        ValueListItem4.DisplayText = "Ninguno"
        ValueListItem4.Tag = "ninguno"
        Me.cmbFiltrar.Items.Add(ValueListItem1)
        Me.cmbFiltrar.Items.Add(ValueListItem2)
        Me.cmbFiltrar.Items.Add(ValueListItem3)
        Me.cmbFiltrar.Items.Add(ValueListItem4)
        Me.cmbFiltrar.Location = New System.Drawing.Point(69, 29)
        Me.cmbFiltrar.Name = "cmbFiltrar"
        Me.cmbFiltrar.Size = New System.Drawing.Size(224, 21)
        Me.cmbFiltrar.TabIndex = 33
        '
        'btnFiltrar
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnFiltrar.Appearance = Appearance2
        Me.btnFiltrar.Location = New System.Drawing.Point(299, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(80, 48)
        Me.btnFiltrar.TabIndex = 32
        Me.btnFiltrar.Text = "Filtrar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(15, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Filtrar por:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.AutoSize = True
        Me.txtFiltrar.Location = New System.Drawing.Point(69, 56)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(224, 21)
        Me.txtFiltrar.TabIndex = 30
        '
        'btnSalir
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnSalir.Appearance = Appearance3
        Me.btnSalir.Location = New System.Drawing.Point(711, 392)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 28)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.checkFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(682, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 52)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha:"
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.Checked = True
        Me.checkFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkFecha.Location = New System.Drawing.Point(7, 22)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(89, 17)
        Me.checkFecha.TabIndex = 0
        Me.checkFecha.Text = "Activar fecha"
        Me.checkFecha.UseVisualStyleBackColor = True
        '
        'btnRealizarPedido
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btnRealizarPedido.Appearance = Appearance4
        Me.btnRealizarPedido.Location = New System.Drawing.Point(15, 392)
        Me.btnRealizarPedido.Name = "btnRealizarPedido"
        Me.btnRealizarPedido.Size = New System.Drawing.Size(113, 28)
        Me.btnRealizarPedido.TabIndex = 41
        Me.btnRealizarPedido.Text = "Realizar pedido"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(656, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(656, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'consultarPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 428)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRealizarPedido)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dateHasta)
        Me.Controls.Add(Me.dateDesde)
        Me.Controls.Add(Me.cmbFiltrar)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.dataGridPresupuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "consultarPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar Presupuestos"
        CType(Me.dataGridPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGridPresupuesto As System.Windows.Forms.DataGrid
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFiltrar As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnFiltrar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFiltrar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents btnRealizarPedido As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
