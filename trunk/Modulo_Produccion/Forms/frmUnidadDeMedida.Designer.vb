<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnidadDeMedida
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.txtDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtAbreviacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGrid1.CaptionText = "Provincias"
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
        Me.DataGrid1.Location = New System.Drawing.Point(22, 215)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(257, 128)
        Me.DataGrid1.TabIndex = 52
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(106, 138)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(86, 25)
        Me.UltraButton2.TabIndex = 49
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(22, 138)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(78, 25)
        Me.UltraButton1.TabIndex = 48
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(162, 170)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(117, 25)
        Me.UltraButton5.TabIndex = 47
        Me.UltraButton5.Text = "&Cancelar"
        '
        'UltraButton4
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.UltraButton4.Appearance = Appearance6
        Me.UltraButton4.Location = New System.Drawing.Point(22, 170)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(121, 25)
        Me.UltraButton4.TabIndex = 46
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(198, 138)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(81, 25)
        Me.UltraButton3.TabIndex = 50
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton10
        '
        Me.UltraButton10.Location = New System.Drawing.Point(198, 349)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(81, 25)
        Me.UltraButton10.TabIndex = 51
        Me.UltraButton10.Text = "Salir"
        '
        'txtDescripcion
        '
        Appearance7.BackColorDisabled = System.Drawing.Color.White
        Appearance7.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtDescripcion.Appearance = Appearance7
        Me.txtDescripcion.AutoSize = True
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(69, 39)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(212, 21)
        Me.txtDescripcion.TabIndex = 43
        '
        'txtNombre
        '
        Appearance8.BackColorDisabled = System.Drawing.Color.White
        Appearance8.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance8
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(69, 15)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 21)
        Me.txtNombre.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(6, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Descripcion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(25, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Nombre"
        '
        'txtEscala
        '
        Appearance9.BackColorDisabled = System.Drawing.Color.White
        Appearance9.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtEscala.Appearance = Appearance9
        Me.txtEscala.AutoSize = True
        Me.txtEscala.Enabled = False
        Me.txtEscala.Location = New System.Drawing.Point(69, 87)
        Me.txtEscala.Name = "txtEscala"
        Me.txtEscala.Size = New System.Drawing.Size(212, 21)
        Me.txtEscala.TabIndex = 54
        '
        'txtAbreviacion
        '
        Appearance10.BackColorDisabled = System.Drawing.Color.White
        Appearance10.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtAbreviacion.Appearance = Appearance10
        Me.txtAbreviacion.AutoSize = True
        Me.txtAbreviacion.Enabled = False
        Me.txtAbreviacion.Location = New System.Drawing.Point(69, 63)
        Me.txtAbreviacion.Name = "txtAbreviacion"
        Me.txtAbreviacion.Size = New System.Drawing.Size(212, 21)
        Me.txtAbreviacion.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(27, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Escala"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Abreviacion"
        '
        'frmUnidadDeMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 380)
        Me.Controls.Add(Me.txtEscala)
        Me.Controls.Add(Me.txtAbreviacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraButton5)
        Me.Controls.Add(Me.UltraButton4)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.UltraButton10)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmUnidadDeMedida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmUnidadDeMedida"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtDescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtAbreviacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class