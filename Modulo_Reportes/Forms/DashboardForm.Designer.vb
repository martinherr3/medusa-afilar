<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim CircularGauge1 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer1 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange1 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale1 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim InputValue1 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Me.Chart1 = New Dundas.Charting.WinControl.Chart
        Me.GaugeContainer1 = New Dundas.Gauges.WinControl.GaugeContainer
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaugeContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Azure
        Me.Chart1.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.Chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.Chart1.BorderLineColor = System.Drawing.Color.LightGray
        Me.Chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.Chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        Me.Chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control
        Me.Chart1.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss
        ChartArea1.AxisX.LabelStyle.Format = "Y"
        ChartArea1.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.DimGray
        ChartArea1.Name = "Default"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.BorderColor = System.Drawing.Color.Transparent
        Legend1.DockToChartArea = "Default"
        Legend1.Name = "Default"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(46, 146)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series1.Name = "Default"
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.DateTime
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(717, 200)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "gfxProdBarras"
        Title1.Name = "Title1"
        Me.Chart1.Titles.Add(Title1)
        '
        'GaugeContainer1
        '
        Me.GaugeContainer1.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.GaugeContainer1.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        CircularGauge1.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge1.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge1.Location.X = 0.0!
        CircularGauge1.Location.Y = 0.0!
        CircularGauge1.Name = "Default"
        CircularGauge1.PivotPoint.X = 50.0!
        CircularGauge1.PivotPoint.Y = 50.0!
        CircularPointer1.Name = "Default"
        CircularGauge1.Pointers.Add(CircularPointer1)
        CircularRange1.Name = "Range1"
        CircularGauge1.Ranges.Add(CircularRange1)
        CircularScale1.Name = "Default"
        CircularGauge1.Scales.Add(CircularScale1)
        CircularGauge1.Size.Height = 100.0!
        CircularGauge1.Size.Width = 100.0!
        Me.GaugeContainer1.CircularGauges.Add(CircularGauge1)
        Me.GaugeContainer1.InternalBackgroundPaint = False
        Me.GaugeContainer1.Location = New System.Drawing.Point(595, 364)
        Me.GaugeContainer1.Name = "GaugeContainer1"
        Me.GaugeContainer1.Size = New System.Drawing.Size(168, 173)
        Me.GaugeContainer1.TabIndex = 1
        InputValue1.Name = "Default"
        Me.GaugeContainer1.Values.Add(InputValue1)
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 599)
        Me.Controls.Add(Me.GaugeContainer1)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DashboardForm"
        Me.Text = "Tablero de Comando"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaugeContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart
    Friend WithEvents GaugeContainer1 As Dundas.Gauges.WinControl.GaugeContainer
End Class
