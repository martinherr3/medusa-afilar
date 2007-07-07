<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidad
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
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox
        Me.txtDistancia = New System.Windows.Forms.TextBox
        Me.txtZona = New System.Windows.Forms.TextBox
        Me.txtProvinciaAbrev = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboProvincia = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgLocalidades = New System.Windows.Forms.DataGrid
        Me.btNuevo = New System.Windows.Forms.Button
        Me.btModificar = New System.Windows.Forms.Button
        Me.btEliminar = New System.Windows.Forms.Button
        Me.btGrabar = New System.Windows.Forms.Button
        Me.btCancelar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(129, 9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Enabled = False
        Me.txtCodigoPostal.Location = New System.Drawing.Point(129, 37)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(212, 20)
        Me.txtCodigoPostal.TabIndex = 1
        '
        'txtDistancia
        '
        Me.txtDistancia.Enabled = False
        Me.txtDistancia.Location = New System.Drawing.Point(129, 89)
        Me.txtDistancia.Name = "txtDistancia"
        Me.txtDistancia.Size = New System.Drawing.Size(209, 20)
        Me.txtDistancia.TabIndex = 3
        '
        'txtZona
        '
        Me.txtZona.Enabled = False
        Me.txtZona.Location = New System.Drawing.Point(129, 63)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(212, 20)
        Me.txtZona.TabIndex = 2
        '
        'txtProvinciaAbrev
        '
        Me.txtProvinciaAbrev.Enabled = False
        Me.txtProvinciaAbrev.Location = New System.Drawing.Point(129, 115)
        Me.txtProvinciaAbrev.Name = "txtProvinciaAbrev"
        Me.txtProvinciaAbrev.Size = New System.Drawing.Size(209, 20)
        Me.txtProvinciaAbrev.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Codigo Postal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Zona:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Distancia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Provincia (Abrev):"
        '
        'cboProvincia
        '
        Me.cboProvincia.Enabled = False
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(129, 141)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(209, 21)
        Me.cboProvincia.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Provincia:"
        '
        'dgLocalidades
        '
        Me.dgLocalidades.CaptionText = "Localidades"
        Me.dgLocalidades.DataMember = ""
        Me.dgLocalidades.FlatMode = True
        Me.dgLocalidades.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgLocalidades.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgLocalidades.Location = New System.Drawing.Point(34, 239)
        Me.dgLocalidades.Name = "dgLocalidades"
        Me.dgLocalidades.ReadOnly = True
        Me.dgLocalidades.Size = New System.Drawing.Size(304, 127)
        Me.dgLocalidades.TabIndex = 12
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(34, 180)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(88, 24)
        Me.btNuevo.TabIndex = 13
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Location = New System.Drawing.Point(142, 180)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(91, 24)
        Me.btModificar.TabIndex = 14
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(254, 180)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(84, 24)
        Me.btEliminar.TabIndex = 15
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btGrabar
        '
        Me.btGrabar.Location = New System.Drawing.Point(34, 210)
        Me.btGrabar.Name = "btGrabar"
        Me.btGrabar.Size = New System.Drawing.Size(145, 25)
        Me.btGrabar.TabIndex = 16
        Me.btGrabar.Text = "Grabar"
        Me.btGrabar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(198, 210)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(140, 25)
        Me.btCancelar.TabIndex = 17
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 22)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 397)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btGrabar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btNuevo)
        Me.Controls.Add(Me.dgLocalidades)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProvinciaAbrev)
        Me.Controls.Add(Me.txtDistancia)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.txtNombre)
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestion de Localidades"
        CType(Me.dgLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtDistancia As System.Windows.Forms.TextBox
    Friend WithEvents txtZona As System.Windows.Forms.TextBox
    Friend WithEvents txtProvinciaAbrev As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgLocalidades As System.Windows.Forms.DataGrid
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents btGrabar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
