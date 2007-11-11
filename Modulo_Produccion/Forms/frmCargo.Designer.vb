<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargo
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargo))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGrid1.CaptionText = "Cargos"
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
        Me.DataGrid1.Location = New System.Drawing.Point(13, 110)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(305, 151)
        Me.DataGrid1.TabIndex = 52
        '
        'UltraButton2
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButton2.Appearance = Appearance1
        Me.UltraButton2.Location = New System.Drawing.Point(13, 286)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(79, 31)
        Me.UltraButton2.TabIndex = 49
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton1
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.Location = New System.Drawing.Point(13, 318)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(79, 31)
        Me.UltraButton1.TabIndex = 48
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton5
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButton5.Appearance = Appearance3
        Me.UltraButton5.Location = New System.Drawing.Point(237, 286)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(81, 31)
        Me.UltraButton5.TabIndex = 47
        Me.UltraButton5.Text = "&Cancelar"
        '
        'UltraButton4
        '
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButton4.Appearance = Appearance4
        Me.UltraButton4.Location = New System.Drawing.Point(93, 318)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(81, 31)
        Me.UltraButton4.TabIndex = 46
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton3
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButton3.Appearance = Appearance5
        Me.UltraButton3.Location = New System.Drawing.Point(93, 286)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(81, 31)
        Me.UltraButton3.TabIndex = 50
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton10
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.UltraButton10.Appearance = Appearance6
        Me.UltraButton10.Location = New System.Drawing.Point(237, 318)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(81, 31)
        Me.UltraButton10.TabIndex = 51
        Me.UltraButton10.Text = "&Salir"
        '
        'txtDescripcion
        '
        Appearance7.BackColorDisabled = System.Drawing.Color.White
        Appearance7.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtDescripcion.Appearance = Appearance7
        Me.txtDescripcion.AutoSize = True
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 66)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(306, 38)
        Me.txtDescripcion.TabIndex = 43
        '
        'txtNombre
        '
        Appearance8.BackColorDisabled = System.Drawing.Color.White
        Appearance8.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance8
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(12, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(306, 21)
        Me.txtNombre.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(12, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Descripcion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Nombre"
        '
        'frmCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 361)
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
        Me.Name = "frmCargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestion de Cargos"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
