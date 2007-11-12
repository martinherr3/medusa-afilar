<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProvincia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProvincia))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Appearance1.BackColorDisabled = System.Drawing.Color.White
        Appearance1.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtDescripcion.Appearance = Appearance1
        Me.txtDescripcion.AutoSize = True
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(70, 39)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(224, 43)
        Me.txtDescripcion.TabIndex = 32
        '
        'txtNombre
        '
        Appearance2.BackColorDisabled = System.Drawing.Color.White
        Appearance2.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance2
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(70, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 21)
        Me.txtNombre.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(7, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Descripcion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(26, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Nombre"
        '
        'UltraButton2
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButton2.Appearance = Appearance3
        Me.UltraButton2.Location = New System.Drawing.Point(88, 95)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(76, 29)
        Me.UltraButton2.TabIndex = 38
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton1
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButton1.Appearance = Appearance4
        Me.UltraButton1.Location = New System.Drawing.Point(10, 95)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(76, 29)
        Me.UltraButton1.TabIndex = 37
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton5
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButton5.Appearance = Appearance5
        Me.UltraButton5.Location = New System.Drawing.Point(166, 126)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(76, 29)
        Me.UltraButton5.TabIndex = 36
        Me.UltraButton5.Text = "&Cancelar"
        '
        'UltraButton4
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.ForeColor = System.Drawing.Color.Black
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.UltraButton4.Appearance = Appearance6
        Me.UltraButton4.Location = New System.Drawing.Point(88, 126)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(76, 29)
        Me.UltraButton4.TabIndex = 35
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton3
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.UltraButton3.Appearance = Appearance7
        Me.UltraButton3.Location = New System.Drawing.Point(10, 126)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(76, 29)
        Me.UltraButton3.TabIndex = 39
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton10
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.UltraButton10.Appearance = Appearance8
        Me.UltraButton10.Location = New System.Drawing.Point(218, 322)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(76, 29)
        Me.UltraButton10.TabIndex = 40
        Me.UltraButton10.Text = "Salir"
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
        Me.DataGrid1.Location = New System.Drawing.Point(10, 161)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(284, 155)
        Me.DataGrid1.TabIndex = 41
        '
        'frmProvincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 355)
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
        Me.Name = "frmProvincia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestion de Provincias"
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
End Class
