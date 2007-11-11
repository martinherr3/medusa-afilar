<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultarModeloFresa
    Inherits Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultarModeloFresa))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dataGridMF = New System.Windows.Forms.DataGrid
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton
        Me.txtFiltrar = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnModificar = New Infragistics.Win.Misc.UltraButton
        Me.btnBaja = New Infragistics.Win.Misc.UltraButton
        Me.btnFiltrar = New Infragistics.Win.Misc.UltraButton
        Me.cmbFiltrar = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.radioAlta = New System.Windows.Forms.RadioButton
        Me.radioBaja = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.dataGridMF.Tag = ""
        '
        'btnSalir
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnSalir.Appearance = Appearance1
        Me.btnSalir.Location = New System.Drawing.Point(716, 414)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 29)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "&Salir"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.AutoSize = True
        Me.txtFiltrar.Location = New System.Drawing.Point(321, 31)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(236, 21)
        Me.txtFiltrar.TabIndex = 14
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
        'btnModificar
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnModificar.Appearance = Appearance2
        Me.btnModificar.Location = New System.Drawing.Point(220, 414)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(80, 29)
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.Text = "&Modificar"
        '
        'btnBaja
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnBaja.Appearance = Appearance3
        Me.btnBaja.Location = New System.Drawing.Point(134, 414)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(80, 29)
        Me.btnBaja.TabIndex = 18
        Me.btnBaja.Text = "&Baja"
        '
        'btnFiltrar
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btnFiltrar.Appearance = Appearance4
        Me.btnFiltrar.Location = New System.Drawing.Point(563, 23)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(80, 37)
        Me.btnFiltrar.TabIndex = 19
        Me.btnFiltrar.Text = "Filtrar"
        '
        'cmbFiltrar
        '
        Me.cmbFiltrar.AutoSize = True
        ValueListItem1.DataValue = "ValueListItem0"
        ValueListItem1.DisplayText = "Nombre"
        ValueListItem1.Tag = "nombre"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "ID"
        ValueListItem2.Tag = "idmodelo"
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "Grupo modelo"
        ValueListItem3.Tag = "grupomodelo"
        ValueListItem4.DataValue = "ValueListItem3"
        ValueListItem4.DisplayText = "Material a trabajar"
        ValueListItem4.Tag = "materialatrabajar"
        ValueListItem5.DataValue = "ValueListItem4"
        ValueListItem5.DisplayText = "Tipo acabado"
        ValueListItem5.Tag = "tipoacabado"
        ValueListItem6.DataValue = "ValueListItem5"
        ValueListItem6.DisplayText = "Tipo modelo"
        ValueListItem6.Tag = "tipomodelo"
        ValueListItem7.DataValue = "ValueListItem6"
        ValueListItem7.DisplayText = "Precio"
        ValueListItem7.Tag = "precio"
        Appearance5.FontData.BoldAsString = "True"
        ValueListItem8.Appearance = Appearance5
        ValueListItem8.DataValue = "ValueListItem7"
        ValueListItem8.DisplayText = "Ninguno"
        ValueListItem8.Tag = "ninguno"
        Me.cmbFiltrar.Items.Add(ValueListItem1)
        Me.cmbFiltrar.Items.Add(ValueListItem2)
        Me.cmbFiltrar.Items.Add(ValueListItem3)
        Me.cmbFiltrar.Items.Add(ValueListItem4)
        Me.cmbFiltrar.Items.Add(ValueListItem5)
        Me.cmbFiltrar.Items.Add(ValueListItem6)
        Me.cmbFiltrar.Items.Add(ValueListItem7)
        Me.cmbFiltrar.Items.Add(ValueListItem8)
        Me.cmbFiltrar.Location = New System.Drawing.Point(70, 31)
        Me.cmbFiltrar.Name = "cmbFiltrar"
        Me.cmbFiltrar.Size = New System.Drawing.Size(224, 21)
        Me.cmbFiltrar.TabIndex = 20
        '
        'radioAlta
        '
        Me.radioAlta.AutoSize = True
        Me.radioAlta.Checked = True
        Me.radioAlta.Location = New System.Drawing.Point(6, 23)
        Me.radioAlta.Name = "radioAlta"
        Me.radioAlta.Size = New System.Drawing.Size(43, 17)
        Me.radioAlta.TabIndex = 21
        Me.radioAlta.TabStop = True
        Me.radioAlta.Tag = "Alta"
        Me.radioAlta.Text = "Alta"
        Me.radioAlta.UseVisualStyleBackColor = True
        '
        'radioBaja
        '
        Me.radioBaja.AutoSize = True
        Me.radioBaja.Location = New System.Drawing.Point(55, 23)
        Me.radioBaja.Name = "radioBaja"
        Me.radioBaja.Size = New System.Drawing.Size(46, 17)
        Me.radioBaja.TabIndex = 22
        Me.radioBaja.Tag = "Baja"
        Me.radioBaja.Text = "Baja"
        Me.radioBaja.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioAlta)
        Me.GroupBox1.Controls.Add(Me.radioBaja)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 400)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 43)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'consultarModeloFresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbFiltrar)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dataGridMF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "consultarModeloFresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar Modelo Fresa"
        CType(Me.dataGridMF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGridMF As System.Windows.Forms.DataGrid
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtFiltrar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBaja As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnFiltrar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmbFiltrar As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents radioAlta As System.Windows.Forms.RadioButton
    Friend WithEvents radioBaja As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
