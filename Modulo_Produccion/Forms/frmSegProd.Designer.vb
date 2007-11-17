<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegProd
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSegProd))
        Me.barra = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.lblFresa = New System.Windows.Forms.Label
        Me.imagen = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbEmpleado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.LblOperacion = New System.Windows.Forms.Label
        Me.lblInicioPlan = New System.Windows.Forms.Label
        Me.lblFinPlan = New System.Windows.Forms.Label
        Me.lblDuracion = New System.Windows.Forms.Label
        Me.lblOperario = New System.Windows.Forms.Label
        Me.lblInicioReal = New System.Windows.Forms.Label
        Me.lblfinReal = New System.Windows.Forms.Label
        Me.lblMaquina = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnAceptar = New Infragistics.Win.Misc.UltraButton
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtIDHR = New System.Windows.Forms.TextBox
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.timerSeg = New System.Windows.Forms.Timer(Me.components)
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barra
        '
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.AppWorkspace
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.ItalicAsString = "False"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.UnderlineAsString = "False"
        Appearance7.ForeColor = System.Drawing.Color.Blue
        Me.barra.Appearance = Appearance7
        Me.barra.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        UltraExplorerBarGroup3.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem5, UltraExplorerBarItem6})
        Me.barra.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup3})
        Me.barra.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Appearance8.FontData.Name = "Arial"
        Appearance8.FontData.SizeInPoints = 7.8!
        Appearance8.ImageAlpha = Infragistics.Win.Alpha.Transparent
        Me.barra.ItemSettings.AppearancesSmall.Appearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance9.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance9.ForeColor = System.Drawing.Color.White
        Me.barra.ItemSettings.AppearancesSmall.HotTrackAppearance = Appearance9
        Me.barra.Location = New System.Drawing.Point(12, 13)
        Me.barra.Name = "barra"
        Me.barra.ShowDefaultContextMenu = False
        Me.barra.Size = New System.Drawing.Size(393, 347)
        Me.barra.StateButtonCheckStyle = Infragistics.Win.UltraWinExplorerBar.StateButtonCheckStyle.ExclusiveWithinGroup
        Me.barra.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Listbar
        Me.barra.TabIndex = 3
        Me.barra.UseLargeGroupHeaderImages = Infragistics.Win.DefaultableBoolean.[True]
        Me.barra.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.Office2003
        '
        'lblFresa
        '
        Me.lblFresa.AutoSize = True
        Me.lblFresa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFresa.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFresa.Location = New System.Drawing.Point(438, 13)
        Me.lblFresa.Name = "lblFresa"
        Me.lblFresa.Size = New System.Drawing.Size(0, 19)
        Me.lblFresa.TabIndex = 4
        '
        'imagen
        '
        Me.imagen.Location = New System.Drawing.Point(433, 54)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(497, 306)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 5
        Me.imagen.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEmpleado)
        Me.GroupBox1.Controls.Add(Me.LblOperacion)
        Me.GroupBox1.Controls.Add(Me.lblInicioPlan)
        Me.GroupBox1.Controls.Add(Me.lblFinPlan)
        Me.GroupBox1.Controls.Add(Me.lblDuracion)
        Me.GroupBox1.Controls.Add(Me.lblOperario)
        Me.GroupBox1.Controls.Add(Me.lblInicioReal)
        Me.GroupBox1.Controls.Add(Me.lblfinReal)
        Me.GroupBox1.Controls.Add(Me.lblMaquina)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 222)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Operacion Actual"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.AutoComplete = True
        Me.cmbEmpleado.AutoSize = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(688, 35)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(226, 27)
        Me.cmbEmpleado.TabIndex = 16
        '
        'LblOperacion
        '
        Me.LblOperacion.AutoSize = True
        Me.LblOperacion.Location = New System.Drawing.Point(260, 35)
        Me.LblOperacion.Name = "LblOperacion"
        Me.LblOperacion.Size = New System.Drawing.Size(0, 18)
        Me.LblOperacion.TabIndex = 15
        '
        'lblInicioPlan
        '
        Me.lblInicioPlan.AutoSize = True
        Me.lblInicioPlan.Location = New System.Drawing.Point(260, 75)
        Me.lblInicioPlan.Name = "lblInicioPlan"
        Me.lblInicioPlan.Size = New System.Drawing.Size(0, 18)
        Me.lblInicioPlan.TabIndex = 14
        '
        'lblFinPlan
        '
        Me.lblFinPlan.AutoSize = True
        Me.lblFinPlan.Location = New System.Drawing.Point(260, 115)
        Me.lblFinPlan.Name = "lblFinPlan"
        Me.lblFinPlan.Size = New System.Drawing.Size(0, 18)
        Me.lblFinPlan.TabIndex = 13
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(260, 155)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(0, 18)
        Me.lblDuracion.TabIndex = 12
        '
        'lblOperario
        '
        Me.lblOperario.AutoSize = True
        Me.lblOperario.Location = New System.Drawing.Point(685, 35)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(0, 18)
        Me.lblOperario.TabIndex = 11
        '
        'lblInicioReal
        '
        Me.lblInicioReal.AutoSize = True
        Me.lblInicioReal.Location = New System.Drawing.Point(685, 75)
        Me.lblInicioReal.Name = "lblInicioReal"
        Me.lblInicioReal.Size = New System.Drawing.Size(0, 18)
        Me.lblInicioReal.TabIndex = 10
        '
        'lblfinReal
        '
        Me.lblfinReal.AutoSize = True
        Me.lblfinReal.Location = New System.Drawing.Point(685, 115)
        Me.lblfinReal.Name = "lblfinReal"
        Me.lblfinReal.Size = New System.Drawing.Size(0, 18)
        Me.lblfinReal.TabIndex = 9
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(685, 155)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(0, 18)
        Me.lblMaquina.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(514, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Operario responsable"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Maquina de trabajo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Duracion promedio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fin real de operacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fin planificado de operacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inicio real de operacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicio planificado de operacion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operacion:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(735, 608)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 35)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(937, 590)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'txtIDHR
        '
        Me.txtIDHR.Location = New System.Drawing.Point(190, 623)
        Me.txtIDHR.Name = "txtIDHR"
        Me.txtIDHR.Size = New System.Drawing.Size(100, 20)
        Me.txtIDHR.TabIndex = 16
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(841, 608)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(85, 35)
        Me.UltraButton1.TabIndex = 17
        Me.UltraButton1.Text = "&Salir"
        '
        'timerSeg
        '
        Me.timerSeg.Enabled = True
        Me.timerSeg.Interval = 60000
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(634, 608)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(85, 35)
        Me.UltraButton2.TabIndex = 18
        Me.UltraButton2.Text = "&Cancelar"
        '
        'frmSegProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 655)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.txtIDHR)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.lblFresa)
        Me.Controls.Add(Me.barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(195, 200)
        Me.Name = "frmSegProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Seguimiento de produccion"
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barra As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents lblFresa As System.Windows.Forms.Label
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblOperacion As System.Windows.Forms.Label
    Friend WithEvents lblInicioPlan As System.Windows.Forms.Label
    Friend WithEvents lblFinPlan As System.Windows.Forms.Label
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents lblOperario As System.Windows.Forms.Label
    Friend WithEvents lblInicioReal As System.Windows.Forms.Label
    Friend WithEvents lblfinReal As System.Windows.Forms.Label
    Friend WithEvents lblMaquina As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents BtnAceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtIDHR As System.Windows.Forms.TextBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents timerSeg As System.Windows.Forms.Timer
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
End Class
