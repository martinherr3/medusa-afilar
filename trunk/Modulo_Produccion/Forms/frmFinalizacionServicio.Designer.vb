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
        Me.dgServicios = New System.Windows.Forms.DataGridView
        Me.btnFinalizarServicio = New System.Windows.Forms.Button
        Me.grpComandos = New System.Windows.Forms.GroupBox
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpComandos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgServicios
        '
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.Location = New System.Drawing.Point(25, 32)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgServicios.Size = New System.Drawing.Size(474, 165)
        Me.dgServicios.TabIndex = 0
        '
        'btnFinalizarServicio
        '
        Me.btnFinalizarServicio.Location = New System.Drawing.Point(6, 19)
        Me.btnFinalizarServicio.Name = "btnFinalizarServicio"
        Me.btnFinalizarServicio.Size = New System.Drawing.Size(115, 37)
        Me.btnFinalizarServicio.TabIndex = 1
        Me.btnFinalizarServicio.Text = "Finalizar Servicio"
        Me.btnFinalizarServicio.UseVisualStyleBackColor = True
        '
        'grpComandos
        '
        Me.grpComandos.Controls.Add(Me.btnSalir)
        Me.grpComandos.Controls.Add(Me.btnFinalizarServicio)
        Me.grpComandos.Location = New System.Drawing.Point(25, 221)
        Me.grpComandos.Name = "grpComandos"
        Me.grpComandos.Size = New System.Drawing.Size(474, 65)
        Me.grpComandos.TabIndex = 2
        Me.grpComandos.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(345, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 37)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmFinalizacionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 309)
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

    End Sub
    Friend WithEvents dgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents btnFinalizarServicio As System.Windows.Forms.Button
    Friend WithEvents grpComandos As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
