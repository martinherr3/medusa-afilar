<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class treeview
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
        Dim Override2 As Infragistics.Win.UltraWinTree.Override = New Infragistics.Win.UltraWinTree.Override
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraComboEditor1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTree1
        '
        Me.UltraTree1.HideSelection = False
        Me.UltraTree1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraTree1.Location = New System.Drawing.Point(297, 12)
        Me.UltraTree1.Name = "UltraTree1"
        Override2.SelectionType = Infragistics.Win.UltraWinTree.SelectType.[Single]
        Me.UltraTree1.Override = Override2
        Me.UltraTree1.Size = New System.Drawing.Size(193, 217)
        Me.UltraTree1.TabIndex = 0
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(280, 257)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(102, 21)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "&Aceptar"
        '
        'UltraComboEditor1
        '
        Me.UltraComboEditor1.AutoSize = True
        Me.UltraComboEditor1.Location = New System.Drawing.Point(54, 32)
        Me.UltraComboEditor1.Name = "UltraComboEditor1"
        Me.UltraComboEditor1.Size = New System.Drawing.Size(195, 21)
        Me.UltraComboEditor1.TabIndex = 3
        Me.UltraComboEditor1.Text = "UltraComboEditor1"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label6)
        Me.UltraGroupBox1.Controls.Add(Me.Label7)
        Me.UltraGroupBox1.Controls.Add(Me.Label5)
        Me.UltraGroupBox1.Controls.Add(Me.Label4)
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraComboEditor1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(255, 198)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "Datos de usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Perfil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Perfil:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Empleado: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cargo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre completo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(388, 257)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(102, 21)
        Me.UltraButton2.TabIndex = 5
        Me.UltraButton2.Text = "&Cancelar"
        '
        'treeview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 290)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraTree1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "treeview"
        Me.Text = "treeview"
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraComboEditor1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
End Class
