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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalidad))
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
        Me.txtNombre.Location = New System.Drawing.Point(107, 10)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Enabled = False
        Me.txtCodigoPostal.Location = New System.Drawing.Point(107, 36)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(212, 20)
        Me.txtCodigoPostal.TabIndex = 1
        '
        'txtDistancia
        '
        Me.txtDistancia.Enabled = False
        Me.txtDistancia.Location = New System.Drawing.Point(107, 88)
        Me.txtDistancia.Name = "txtDistancia"
        Me.txtDistancia.Size = New System.Drawing.Size(212, 20)
        Me.txtDistancia.TabIndex = 3
        '
        'txtZona
        '
        Me.txtZona.Enabled = False
        Me.txtZona.Location = New System.Drawing.Point(107, 62)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(212, 20)
        Me.txtZona.TabIndex = 2
        '
        'txtProvinciaAbrev
        '
        Me.txtProvinciaAbrev.Enabled = False
        Me.txtProvinciaAbrev.Location = New System.Drawing.Point(107, 114)
        Me.txtProvinciaAbrev.Name = "txtProvinciaAbrev"
        Me.txtProvinciaAbrev.Size = New System.Drawing.Size(212, 20)
        Me.txtProvinciaAbrev.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Codigo Postal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Zona:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Distancia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Provincia (Abrev):"
        '
        'cboProvincia
        '
        Me.cboProvincia.Enabled = False
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(107, 140)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(212, 21)
        Me.cboProvincia.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Provincia:"
        '
        'dgLocalidades
        '
        Me.dgLocalidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLocalidades.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgLocalidades.CaptionText = "Localidades"
        Me.dgLocalidades.DataMember = ""
        Me.dgLocalidades.FlatMode = True
        Me.dgLocalidades.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgLocalidades.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgLocalidades.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgLocalidades.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgLocalidades.Location = New System.Drawing.Point(17, 239)
        Me.dgLocalidades.Name = "dgLocalidades"
        Me.dgLocalidades.ReadOnly = True
        Me.dgLocalidades.Size = New System.Drawing.Size(482, 150)
        Me.dgLocalidades.TabIndex = 12
        '
        'btNuevo
        '
        Me.btNuevo.Image = CType(resources.GetObject("btNuevo.Image"), System.Drawing.Image)
        Me.btNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNuevo.Location = New System.Drawing.Point(18, 178)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(84, 26)
        Me.btNuevo.TabIndex = 13
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Image = CType(resources.GetObject("btModificar.Image"), System.Drawing.Image)
        Me.btModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btModificar.Location = New System.Drawing.Point(105, 178)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(85, 26)
        Me.btModificar.TabIndex = 14
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = CType(resources.GetObject("btEliminar.Image"), System.Drawing.Image)
        Me.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEliminar.Location = New System.Drawing.Point(18, 207)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(84, 25)
        Me.btEliminar.TabIndex = 15
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btGrabar
        '
        Me.btGrabar.Image = CType(resources.GetObject("btGrabar.Image"), System.Drawing.Image)
        Me.btGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGrabar.Location = New System.Drawing.Point(193, 207)
        Me.btGrabar.Name = "btGrabar"
        Me.btGrabar.Size = New System.Drawing.Size(85, 25)
        Me.btGrabar.TabIndex = 16
        Me.btGrabar.Text = "Grabar"
        Me.btGrabar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Image = CType(resources.GetObject("btCancelar.Image"), System.Drawing.Image)
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(105, 207)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(85, 25)
        Me.btCancelar.TabIndex = 17
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(414, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 26)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 433)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
