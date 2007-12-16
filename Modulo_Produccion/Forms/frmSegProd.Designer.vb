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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.barra = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.lblFresa = New System.Windows.Forms.Label
        Me.imagen = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbTornero = New Infragistics.Win.UltraWinEditors.UltraComboEditor
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
        CType(Me.cmbTornero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barra
        '
        Appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance1.BackColor2 = System.Drawing.SystemColors.AppWorkspace
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.ItalicAsString = "False"
        Appearance1.FontData.Name = "Arial"
        Appearance1.FontData.UnderlineAsString = "False"
        Appearance1.ForeColor = System.Drawing.Color.Blue
        Me.barra.Appearance = Appearance1
        Me.barra.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.barra.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup2})
        Me.barra.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 7.8!
        Appearance2.ImageAlpha = Infragistics.Win.Alpha.Transparent
        Me.barra.ItemSettings.AppearancesSmall.Appearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance3.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.barra.ItemSettings.AppearancesSmall.HotTrackAppearance = Appearance3
        Me.barra.Location = New System.Drawing.Point(12, 13)
        Me.barra.Name = "barra"
        Me.barra.ShowDefaultContextMenu = False
        Me.barra.Size = New System.Drawing.Size(393, 513)
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
        Me.imagen.Size = New System.Drawing.Size(493, 235)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 5
        Me.imagen.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTornero)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(433, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 231)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Operacion Actual"
        '
        'cmbTornero
        '
        Me.cmbTornero.AutoComplete = True
        Me.cmbTornero.AutoSize = True
        Me.cmbTornero.Location = New System.Drawing.Point(239, 138)
        Me.cmbTornero.Name = "cmbTornero"
        Me.cmbTornero.Size = New System.Drawing.Size(191, 24)
        Me.cmbTornero.TabIndex = 17
        Me.cmbTornero.Visible = False
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.AutoComplete = True
        Me.cmbEmpleado.AutoSize = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(241, 138)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(189, 24)
        Me.cmbEmpleado.TabIndex = 16
        '
        'LblOperacion
        '
        Me.LblOperacion.AutoSize = True
        Me.LblOperacion.Location = New System.Drawing.Point(238, 26)
        Me.LblOperacion.Name = "LblOperacion"
        Me.LblOperacion.Size = New System.Drawing.Size(0, 16)
        Me.LblOperacion.TabIndex = 15
        '
        'lblInicioPlan
        '
        Me.lblInicioPlan.AutoSize = True
        Me.lblInicioPlan.Location = New System.Drawing.Point(237, 45)
        Me.lblInicioPlan.Name = "lblInicioPlan"
        Me.lblInicioPlan.Size = New System.Drawing.Size(0, 16)
        Me.lblInicioPlan.TabIndex = 14
        '
        'lblFinPlan
        '
        Me.lblFinPlan.AutoSize = True
        Me.lblFinPlan.Location = New System.Drawing.Point(240, 66)
        Me.lblFinPlan.Name = "lblFinPlan"
        Me.lblFinPlan.Size = New System.Drawing.Size(0, 16)
        Me.lblFinPlan.TabIndex = 13
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(240, 85)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(0, 16)
        Me.lblDuracion.TabIndex = 12
        '
        'lblOperario
        '
        Me.lblOperario.AutoSize = True
        Me.lblOperario.Location = New System.Drawing.Point(241, 145)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(0, 16)
        Me.lblOperario.TabIndex = 11
        '
        'lblInicioReal
        '
        Me.lblInicioReal.AutoSize = True
        Me.lblInicioReal.Location = New System.Drawing.Point(236, 167)
        Me.lblInicioReal.Name = "lblInicioReal"
        Me.lblInicioReal.Size = New System.Drawing.Size(0, 16)
        Me.lblInicioReal.TabIndex = 10
        '
        'lblfinReal
        '
        Me.lblfinReal.AutoSize = True
        Me.lblfinReal.Location = New System.Drawing.Point(236, 185)
        Me.lblfinReal.Name = "lblfinReal"
        Me.lblfinReal.Size = New System.Drawing.Size(0, 16)
        Me.lblfinReal.TabIndex = 9
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(236, 204)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(0, 16)
        Me.lblMaquina.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(81, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Operario responsable"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Maquina de trabajo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Duracion promedio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fin real de operacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fin planificado de operacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inicio real de operacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicio planificado de operacion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operacion:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(735, 534)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = Global.Afilar.My.Resources.Resources.ScreenSaver1
        Me.PictureBox3.Location = New System.Drawing.Point(6, -33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(930, 561)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'txtIDHR
        '
        Me.txtIDHR.Location = New System.Drawing.Point(190, 532)
        Me.txtIDHR.Name = "txtIDHR"
        Me.txtIDHR.Size = New System.Drawing.Size(100, 20)
        Me.txtIDHR.TabIndex = 16
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(841, 534)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(85, 24)
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
        Me.UltraButton2.Location = New System.Drawing.Point(634, 534)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(85, 24)
        Me.UltraButton2.TabIndex = 18
        Me.UltraButton2.Text = "&Cancelar"
        '
        'frmSegProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 563)
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
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmSegProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Seguimiento de produccion"
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbTornero, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbTornero As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
