<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseDatos))
        Me.btnBackup = New System.Windows.Forms.Button
        Me.btnRestore = New System.Windows.Forms.Button
        Me.txtInstancia = New System.Windows.Forms.TextBox
        Me.txtNombreBD = New System.Windows.Forms.TextBox
        Me.txtLoginSecure = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBackup = New System.Windows.Forms.TextBox
        Me.txtRestore = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(383, 24)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(171, 41)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "BackUp"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Image = CType(resources.GetObject("btnRestore.Image"), System.Drawing.Image)
        Me.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestore.Location = New System.Drawing.Point(383, 120)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(171, 41)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'txtInstancia
        '
        Me.txtInstancia.Enabled = False
        Me.txtInstancia.Location = New System.Drawing.Point(134, 24)
        Me.txtInstancia.Name = "txtInstancia"
        Me.txtInstancia.Size = New System.Drawing.Size(155, 20)
        Me.txtInstancia.TabIndex = 2
        '
        'txtNombreBD
        '
        Me.txtNombreBD.Enabled = False
        Me.txtNombreBD.Location = New System.Drawing.Point(134, 59)
        Me.txtNombreBD.Name = "txtNombreBD"
        Me.txtNombreBD.Size = New System.Drawing.Size(155, 20)
        Me.txtNombreBD.TabIndex = 3
        '
        'txtLoginSecure
        '
        Me.txtLoginSecure.Enabled = False
        Me.txtLoginSecure.Location = New System.Drawing.Point(134, 95)
        Me.txtLoginSecure.Name = "txtLoginSecure"
        Me.txtLoginSecure.Size = New System.Drawing.Size(155, 20)
        Me.txtLoginSecure.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(134, 166)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(155, 20)
        Me.txtPassword.TabIndex = 6
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(134, 131)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(155, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Instancia (Servidor):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Base de Datos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Login Secure:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Password:"
        '
        'txtBackup
        '
        Me.txtBackup.Location = New System.Drawing.Point(383, 71)
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.Size = New System.Drawing.Size(171, 20)
        Me.txtBackup.TabIndex = 12
        '
        'txtRestore
        '
        Me.txtRestore.Location = New System.Drawing.Point(383, 166)
        Me.txtRestore.Name = "txtRestore"
        Me.txtRestore.Size = New System.Drawing.Size(171, 20)
        Me.txtRestore.TabIndex = 13
        '
        'frmBaseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 209)
        Me.Controls.Add(Me.txtRestore)
        Me.Controls.Add(Me.txtBackup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtLoginSecure)
        Me.Controls.Add(Me.txtNombreBD)
        Me.Controls.Add(Me.txtInstancia)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBackup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmBaseDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Herramienta para Base de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents txtInstancia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreBD As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginSecure As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBackup As System.Windows.Forms.TextBox
    Friend WithEvents txtRestore As System.Windows.Forms.TextBox
End Class
