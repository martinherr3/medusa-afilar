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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.barra = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.lblFresa = New System.Windows.Forms.Label
        Me.imagen = New System.Windows.Forms.PictureBox
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(382, 191)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(75, 23)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "UltraButton1"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(382, 243)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(75, 23)
        Me.UltraButton2.TabIndex = 2
        Me.UltraButton2.Text = "UltraButton2"
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
        UltraExplorerBarGroup1.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem1, UltraExplorerBarItem2})
        Me.barra.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1})
        Me.barra.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 7.8!
        Appearance2.ImageAlpha = Infragistics.Win.Alpha.Transparent
        Me.barra.ItemSettings.AppearancesSmall.Appearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance3.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.barra.ItemSettings.AppearancesSmall.HotTrackAppearance = Appearance3
        Me.barra.Location = New System.Drawing.Point(12, 76)
        Me.barra.Name = "barra"
        Me.barra.ShowDefaultContextMenu = False
        Me.barra.Size = New System.Drawing.Size(364, 511)
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
        Me.lblFresa.Location = New System.Drawing.Point(228, 9)
        Me.lblFresa.Name = "lblFresa"
        Me.lblFresa.Size = New System.Drawing.Size(0, 19)
        Me.lblFresa.TabIndex = 4
        '
        'imagen
        '
        Me.imagen.Location = New System.Drawing.Point(463, 93)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(367, 463)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 5
        Me.imagen.TabStop = False
        '
        'frmSegProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 655)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.lblFresa)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Name = "frmSegProd"
        Me.Text = "frmSegProd"
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents barra As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents lblFresa As System.Windows.Forms.Label
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
End Class
