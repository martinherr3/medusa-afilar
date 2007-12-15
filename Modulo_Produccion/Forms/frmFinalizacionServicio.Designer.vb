<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalizacionServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinalizacionServicio))
        Me.dgServicios = New System.Windows.Forms.DataGridView
        Me.grpComandos = New System.Windows.Forms.GroupBox
        Me.btnFinServicio = New Infragistics.Win.Misc.UltraButton
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpComandos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgServicios
        '
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.Location = New System.Drawing.Point(12, 37)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgServicios.Size = New System.Drawing.Size(507, 189)
        Me.dgServicios.TabIndex = 0
        '
        'grpComandos
        '
        Me.grpComandos.Controls.Add(Me.btnSalir)
        Me.grpComandos.Controls.Add(Me.btnFinServicio)
        Me.grpComandos.Location = New System.Drawing.Point(277, 232)
        Me.grpComandos.Name = "grpComandos"
        Me.grpComandos.Size = New System.Drawing.Size(242, 65)
        Me.grpComandos.TabIndex = 2
        Me.grpComandos.TabStop = False
        '
        'btnFinServicio
        '
        Me.btnFinServicio.AcceptsFocus = False
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnFinServicio.Appearance = Appearance2
        Me.btnFinServicio.Location = New System.Drawing.Point(6, 19)
        Me.btnFinServicio.Name = "btnFinServicio"
        Me.btnFinServicio.Size = New System.Drawing.Size(112, 37)
        Me.btnFinServicio.TabIndex = 5
        Me.btnFinServicio.Text = "Finalizar Servicio"
        '
        'btnSalir
        '
        Me.btnSalir.AcceptsFocus = False
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnSalir.Appearance = Appearance1
        Me.btnSalir.Location = New System.Drawing.Point(124, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 37)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Servicios pendientes de finalizar"
        '
        'frmFinalizacionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 309)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpComandos)
        Me.Controls.Add(Me.dgServicios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmFinalizacionServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Finalizacion de Servicios"
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpComandos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents grpComandos As System.Windows.Forms.GroupBox
    Friend WithEvents btnFinServicio As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
