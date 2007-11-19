<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class referenciaProgramacion
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
    Me.TreeProgramacion = New System.Windows.Forms.TreeView
    Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
    Me.SuspendLayout()
    '
    'TreeProgramacion
    '
    Me.TreeProgramacion.Location = New System.Drawing.Point(9, 12)
    Me.TreeProgramacion.Name = "TreeProgramacion"
    Me.TreeProgramacion.Size = New System.Drawing.Size(393, 284)
    Me.TreeProgramacion.TabIndex = 10
    '
    'UltraButton1
    '
    Me.UltraButton1.Location = New System.Drawing.Point(304, 301)
    Me.UltraButton1.Name = "UltraButton1"
    Me.UltraButton1.Size = New System.Drawing.Size(96, 19)
    Me.UltraButton1.TabIndex = 11
    Me.UltraButton1.Text = "Cerrar"
    '
    'referenciaProgramacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(409, 325)
    Me.Controls.Add(Me.UltraButton1)
    Me.Controls.Add(Me.TreeProgramacion)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "referenciaProgramacion"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.Text = "Referencias"
    Me.TopMost = True
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TreeProgramacion As System.Windows.Forms.TreeView
  Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
End Class
