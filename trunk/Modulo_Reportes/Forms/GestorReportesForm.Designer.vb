<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestorReportesForm
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
        Me.btnActualizar = New Infragistics.Win.Misc.UltraButton
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pedidoDesde = New System.Windows.Forms.DateTimePicker
        Me.PedidoHasta = New System.Windows.Forms.DateTimePicker
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PedidoFechaCheck = New System.Windows.Forms.CheckBox
        Me.comboPedidoCliente = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.comboPedidoPrioridad = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.comboPedidoEstado = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(231, 31)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 21)
        Me.btnActualizar.TabIndex = 39
        Me.btnActualizar.Text = "Actualizar"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 218)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(790, 330)
        Me.CrystalReportViewer1.TabIndex = 40
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'pedidoDesde
        '
        Me.pedidoDesde.Location = New System.Drawing.Point(6, 20)
        Me.pedidoDesde.Name = "pedidoDesde"
        Me.pedidoDesde.Size = New System.Drawing.Size(203, 20)
        Me.pedidoDesde.TabIndex = 41
        '
        'PedidoHasta
        '
        Me.PedidoHasta.Location = New System.Drawing.Point(6, 42)
        Me.PedidoHasta.Name = "PedidoHasta"
        Me.PedidoHasta.Size = New System.Drawing.Size(203, 20)
        Me.PedidoHasta.TabIndex = 42
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.PedidoFechaCheck)
        Me.UltraGroupBox1.Controls.Add(Me.PedidoHasta)
        Me.UltraGroupBox1.Controls.Add(Me.pedidoDesde)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(54, 18)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(223, 95)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 43
        Me.UltraGroupBox1.Text = "Fecha entrega"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox1.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Seleccionar reporte"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.comboPedidoEstado)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.comboPedidoPrioridad)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.comboPedidoCliente)
        Me.Panel1.Controls.Add(Me.UltraGroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 154)
        Me.Panel1.TabIndex = 46
        '
        'PedidoFechaCheck
        '
        Me.PedidoFechaCheck.AutoSize = True
        Me.PedidoFechaCheck.Location = New System.Drawing.Point(6, 68)
        Me.PedidoFechaCheck.Name = "PedidoFechaCheck"
        Me.PedidoFechaCheck.Size = New System.Drawing.Size(59, 17)
        Me.PedidoFechaCheck.TabIndex = 43
        Me.PedidoFechaCheck.Text = "Activar"
        Me.PedidoFechaCheck.UseVisualStyleBackColor = True
        '
        'comboPedidoCliente
        '
        Me.comboPedidoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.comboPedidoCliente.DisplayMember = ""
        Me.comboPedidoCliente.Location = New System.Drawing.Point(418, 36)
        Me.comboPedidoCliente.Name = "comboPedidoCliente"
        Me.comboPedidoCliente.Size = New System.Drawing.Size(206, 21)
        Me.comboPedidoCliente.TabIndex = 44
        Me.comboPedidoCliente.ValueMember = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Cliente"
        '
        'comboPedidoPrioridad
        '
        Me.comboPedidoPrioridad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.comboPedidoPrioridad.DisplayMember = ""
        Me.comboPedidoPrioridad.Location = New System.Drawing.Point(418, 59)
        Me.comboPedidoPrioridad.Name = "comboPedidoPrioridad"
        Me.comboPedidoPrioridad.Size = New System.Drawing.Size(206, 21)
        Me.comboPedidoPrioridad.TabIndex = 46
        Me.comboPedidoPrioridad.ValueMember = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Prioridad"
        '
        'comboPedidoEstado
        '
        Me.comboPedidoEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.comboPedidoEstado.DisplayMember = ""
        Me.comboPedidoEstado.Location = New System.Drawing.Point(418, 81)
        Me.comboPedidoEstado.Name = "comboPedidoEstado"
        Me.comboPedidoEstado.Size = New System.Drawing.Size(206, 21)
        Me.comboPedidoEstado.TabIndex = 48
        Me.comboPedidoEstado.ValueMember = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(378, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Estado"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(643, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 50
        Me.CheckBox1.Text = "Activar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(643, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox2.TabIndex = 51
        Me.CheckBox2.Text = "Activar"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(643, 86)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox3.TabIndex = 52
        Me.CheckBox3.Text = "Activar"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GestorReportesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "GestorReportesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestor de Reportes"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnActualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pedidoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents PedidoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PedidoFechaCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboPedidoEstado As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboPedidoPrioridad As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboPedidoCliente As Infragistics.Win.UltraWinGrid.UltraCombo
End Class
