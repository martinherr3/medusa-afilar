<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultarModeloFresa
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
        Me.dataGridMF = New System.Windows.Forms.DataGrid
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.textFecha = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridMF
        '
        Me.dataGridMF.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dataGridMF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridMF.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataGridMF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridMF.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dataGridMF.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.CaptionText = "Modelos de fresas"
        Me.dataGridMF.DataMember = ""
        Me.dataGridMF.FlatMode = True
        Me.dataGridMF.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dataGridMF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dataGridMF.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dataGridMF.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dataGridMF.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridMF.LinkColor = System.Drawing.Color.Teal
        Me.dataGridMF.Location = New System.Drawing.Point(12, 66)
        Me.dataGridMF.Name = "dataGridMF"
        Me.dataGridMF.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dataGridMF.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGridMF.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dataGridMF.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridMF.Size = New System.Drawing.Size(784, 328)
        Me.dataGridMF.TabIndex = 4
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(716, 419)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton3.TabIndex = 13
        Me.UltraButton3.Text = "Salir"
        '
        'textFecha
        '
        Me.textFecha.AutoSize = True
        Me.textFecha.Location = New System.Drawing.Point(321, 31)
        Me.textFecha.Name = "textFecha"
        Me.textFecha.Size = New System.Drawing.Size(280, 21)
        Me.textFecha.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Filtrar por:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ID", "Nombre", "Grupo modelo", "Material a trabajar", "Modo de avance", "Tipo acabado", "Precio ", "Estado"})
        Me.ComboBox1.Location = New System.Drawing.Point(68, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(614, 419)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 17
        Me.UltraButton1.Text = "Modificar"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(509, 419)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton2.TabIndex = 18
        Me.UltraButton2.Text = "Baja"
        '
        'consultarModeloFresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 455)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textFecha)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.dataGridMF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "consultarModeloFresa"
        Me.Text = "Consultar Modelo Fresa"
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGridMF As System.Windows.Forms.DataGrid
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents textFecha As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
End Class
