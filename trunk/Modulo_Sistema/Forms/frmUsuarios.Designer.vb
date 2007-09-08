<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.txtUsuario = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblEmpleado = New System.Windows.Forms.Label
        Me.txtContraseña = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtContraseña2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtContraseña3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Lblvalidacion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContraseña2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContraseña3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGrid1.Location = New System.Drawing.Point(9, 245)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(312, 128)
        Me.DataGrid1.TabIndex = 63
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(142, 170)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(86, 25)
        Me.UltraButton2.TabIndex = 60
        Me.UltraButton2.Text = "&Modificar"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(58, 170)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(78, 25)
        Me.UltraButton1.TabIndex = 59
        Me.UltraButton1.Text = "&Nuevo"
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(198, 202)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(117, 25)
        Me.UltraButton5.TabIndex = 58
        Me.UltraButton5.Text = "&Cancelar"
        '
        'UltraButton4
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.UltraButton4.Appearance = Appearance1
        Me.UltraButton4.Location = New System.Drawing.Point(58, 202)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(116, 25)
        Me.UltraButton4.TabIndex = 57
        Me.UltraButton4.Text = "&Grabar"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(234, 170)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(81, 25)
        Me.UltraButton3.TabIndex = 61
        Me.UltraButton3.Text = "&Eliminar"
        '
        'UltraButton10
        '
        Me.UltraButton10.Location = New System.Drawing.Point(240, 379)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(81, 25)
        Me.UltraButton10.TabIndex = 62
        Me.UltraButton10.Text = "Salir"
        '
        'txtUsuario
        '
        Appearance2.BackColorDisabled = System.Drawing.Color.White
        Appearance2.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtUsuario.Appearance = Appearance2
        Me.txtUsuario.AutoSize = True
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(109, 31)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(212, 21)
        Me.txtUsuario.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(43, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Contraseña:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(61, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Empleado: "
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(104, 9)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(124, 13)
        Me.lblEmpleado.TabIndex = 66
        Me.lblEmpleado.Text = "Seleccione un empleado"
        '
        'txtContraseña
        '
        Appearance3.BackColorDisabled = System.Drawing.Color.White
        Appearance3.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtContraseña.Appearance = Appearance3
        Me.txtContraseña.AutoSize = True
        Me.txtContraseña.Enabled = False
        Me.txtContraseña.Location = New System.Drawing.Point(109, 83)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(212, 21)
        Me.txtContraseña.TabIndex = 69
        '
        'txtContraseña2
        '
        Appearance4.BackColorDisabled = System.Drawing.Color.White
        Appearance4.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtContraseña2.Appearance = Appearance4
        Me.txtContraseña2.AutoSize = True
        Me.txtContraseña2.Enabled = False
        Me.txtContraseña2.Location = New System.Drawing.Point(109, 110)
        Me.txtContraseña2.Name = "txtContraseña2"
        Me.txtContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña2.Size = New System.Drawing.Size(212, 21)
        Me.txtContraseña2.TabIndex = 70
        '
        'txtContraseña3
        '
        Appearance5.BackColorDisabled = System.Drawing.Color.White
        Appearance5.BackColorDisabled2 = System.Drawing.Color.White
        Me.txtContraseña3.Appearance = Appearance5
        Me.txtContraseña3.AutoSize = True
        Me.txtContraseña3.Enabled = False
        Me.txtContraseña3.Location = New System.Drawing.Point(109, 56)
        Me.txtContraseña3.Name = "txtContraseña3"
        Me.txtContraseña3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña3.Size = New System.Drawing.Size(212, 21)
        Me.txtContraseña3.TabIndex = 71
        '
        'Lblvalidacion
        '
        Me.Lblvalidacion.AutoSize = True
        Me.Lblvalidacion.BackColor = System.Drawing.Color.Transparent
        Me.Lblvalidacion.Location = New System.Drawing.Point(6, 61)
        Me.Lblvalidacion.Name = "Lblvalidacion"
        Me.Lblvalidacion.Size = New System.Drawing.Size(101, 13)
        Me.Lblvalidacion.TabIndex = 72
        Me.Lblvalidacion.Text = "Ingrese contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Repita contraseña:"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 409)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lblvalidacion)
        Me.Controls.Add(Me.txtContraseña3)
        Me.Controls.Add(Me.txtContraseña2)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraButton5)
        Me.Controls.Add(Me.UltraButton4)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.UltraButton10)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Usuarios"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContraseña2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContraseña3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtUsuario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtContraseña2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtContraseña3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Lblvalidacion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
