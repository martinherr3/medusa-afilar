<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHojaDeRuta
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
        Me.dgHoja = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbCriterio = New System.Windows.Forms.ComboBox
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        CType(Me.dgHoja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHoja
        '
        Me.dgHoja.AllowUserToAddRows = False
        Me.dgHoja.AllowUserToDeleteRows = False
        Me.dgHoja.AllowUserToOrderColumns = True
        Me.dgHoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHoja.Location = New System.Drawing.Point(12, 40)
        Me.dgHoja.Name = "dgHoja"
        Me.dgHoja.ReadOnly = True
        Me.dgHoja.Size = New System.Drawing.Size(645, 164)
        Me.dgHoja.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ver Hoja de Ruta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbCriterio
        '
        Me.cmbCriterio.FormattingEnabled = True
        Me.cmbCriterio.Location = New System.Drawing.Point(12, 13)
        Me.cmbCriterio.Name = "cmbCriterio"
        Me.cmbCriterio.Size = New System.Drawing.Size(149, 21)
        Me.cmbCriterio.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(167, 14)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(196, 20)
        Me.txtBusqueda.TabIndex = 3
        '
        'frmHojaDeRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 294)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cmbCriterio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgHoja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmHojaDeRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Hojas de Ruta"
        CType(Me.dgHoja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgHoja As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
End Class
