<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodigoBarra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodigoBarra))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnImprimirCodigo = New System.Windows.Forms.Button
        Me.btnGenerarCodigo = New System.Windows.Forms.Button
        Me.ptbCodigo = New System.Windows.Forms.PictureBox
        Me.txtIdArticulo = New System.Windows.Forms.TextBox
        Me.lblIdArticulo = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblComentario = New System.Windows.Forms.Label
        Me.txtIdArticuloCapturado = New System.Windows.Forms.TextBox
        Me.lblIdArticuloCapturado = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimirCodigo)
        Me.GroupBox1.Controls.Add(Me.btnGenerarCodigo)
        Me.GroupBox1.Controls.Add(Me.ptbCodigo)
        Me.GroupBox1.Controls.Add(Me.txtIdArticulo)
        Me.GroupBox1.Controls.Add(Me.lblIdArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 242)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Codigo"
        '
        'btnImprimirCodigo
        '
        Me.btnImprimirCodigo.Location = New System.Drawing.Point(128, 214)
        Me.btnImprimirCodigo.Name = "btnImprimirCodigo"
        Me.btnImprimirCodigo.Size = New System.Drawing.Size(103, 22)
        Me.btnImprimirCodigo.TabIndex = 8
        Me.btnImprimirCodigo.Text = "Imprimir Codigo"
        Me.btnImprimirCodigo.UseVisualStyleBackColor = True
        '
        'btnGenerarCodigo
        '
        Me.btnGenerarCodigo.Location = New System.Drawing.Point(25, 214)
        Me.btnGenerarCodigo.Name = "btnGenerarCodigo"
        Me.btnGenerarCodigo.Size = New System.Drawing.Size(97, 22)
        Me.btnGenerarCodigo.TabIndex = 7
        Me.btnGenerarCodigo.Text = "Generar Codigo"
        Me.btnGenerarCodigo.UseVisualStyleBackColor = True
        '
        'ptbCodigo
        '
        Me.ptbCodigo.Location = New System.Drawing.Point(25, 59)
        Me.ptbCodigo.Name = "ptbCodigo"
        Me.ptbCodigo.Size = New System.Drawing.Size(206, 149)
        Me.ptbCodigo.TabIndex = 6
        Me.ptbCodigo.TabStop = False
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(82, 33)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(137, 20)
        Me.txtIdArticulo.TabIndex = 5
        '
        'lblIdArticulo
        '
        Me.lblIdArticulo.AutoSize = True
        Me.lblIdArticulo.Location = New System.Drawing.Point(22, 36)
        Me.lblIdArticulo.Name = "lblIdArticulo"
        Me.lblIdArticulo.Size = New System.Drawing.Size(54, 13)
        Me.lblIdArticulo.TabIndex = 4
        Me.lblIdArticulo.Text = "Id Articulo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblComentario)
        Me.GroupBox2.Controls.Add(Me.txtIdArticuloCapturado)
        Me.GroupBox2.Controls.Add(Me.lblIdArticuloCapturado)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 241)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Capturar Codigo"
        '
        'lblComentario
        '
        Me.lblComentario.Location = New System.Drawing.Point(39, 114)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(169, 122)
        Me.lblComentario.TabIndex = 2
        Me.lblComentario.Text = resources.GetString("lblComentario.Text")
        '
        'txtIdArticuloCapturado
        '
        Me.txtIdArticuloCapturado.Location = New System.Drawing.Point(42, 64)
        Me.txtIdArticuloCapturado.Name = "txtIdArticuloCapturado"
        Me.txtIdArticuloCapturado.Size = New System.Drawing.Size(165, 20)
        Me.txtIdArticuloCapturado.TabIndex = 1
        '
        'lblIdArticuloCapturado
        '
        Me.lblIdArticuloCapturado.AutoSize = True
        Me.lblIdArticuloCapturado.Location = New System.Drawing.Point(46, 34)
        Me.lblIdArticuloCapturado.Name = "lblIdArticuloCapturado"
        Me.lblIdArticuloCapturado.Size = New System.Drawing.Size(162, 13)
        Me.lblIdArticuloCapturado.TabIndex = 0
        Me.lblIdArticuloCapturado.Text = "Id de Articulo (codigo) Capturado"
        '
        'frmCodigoBarra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 586)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmCodigoBarra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ejemplo de Uso de Codigo Barra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimirCodigo As System.Windows.Forms.Button
    Friend WithEvents btnGenerarCodigo As System.Windows.Forms.Button
    Friend WithEvents ptbCodigo As System.Windows.Forms.PictureBox
    Friend WithEvents txtIdArticulo As System.Windows.Forms.TextBox
    Friend WithEvents lblIdArticulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdArticuloCapturado As System.Windows.Forms.Label
    Friend WithEvents txtIdArticuloCapturado As System.Windows.Forms.TextBox
    Friend WithEvents lblComentario As System.Windows.Forms.Label
End Class
