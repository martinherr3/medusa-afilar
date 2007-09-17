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
        Dim CircularGauge1 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer1 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange1 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale1 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim InputValue1 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim CircularGauge2 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer2 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange2 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale2 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim InputValue2 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim CircularGauge3 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer3 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange3 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale3 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim InputValue3 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series3 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim ChartArea3 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend3 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series4 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Me.GaugeContainer1 = New Dundas.Gauges.WinControl.GaugeContainer
        Me.gfxProdBarras = New Dundas.Charting.WinControl.Chart
        Me.dateDesde = New System.Windows.Forms.DateTimePicker
        Me.dateHasta = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnActualizar = New Infragistics.Win.Misc.UltraButton
        Me.GaugeContainer2 = New Dundas.Gauges.WinControl.GaugeContainer
        Me.GaugeContainer3 = New Dundas.Gauges.WinControl.GaugeContainer
        Me.Chart1 = New Dundas.Charting.WinControl.Chart
        Me.Chart2 = New Dundas.Charting.WinControl.Chart
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.GaugeContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gfxProdBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaugeContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaugeContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GaugeContainer1.Location = New System.Drawing.Point(636, 387)
        Me.GaugeContainer1.Name = "GaugeContainer1"
        Me.GaugeContainer1.Size = New System.Drawing.Size(168, 173)
        Me.GaugeContainer1.TabIndex = 1
        InputValue1.Name = "Default"
        Me.GaugeContainer1.Values.Add(InputValue1)
        '
        'gfxProdBarras
        '
        Me.gfxProdBarras.BackColor = System.Drawing.Color.Azure
        Me.gfxProdBarras.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.gfxProdBarras.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.gfxProdBarras.BorderLineColor = System.Drawing.Color.LightGray
        Me.gfxProdBarras.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.gfxProdBarras.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
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
        Me.gfxProdBarras.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.BorderColor = System.Drawing.Color.Transparent
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Top
        Legend1.Name = "Default"
        Me.gfxProdBarras.Legends.Add(Legend1)
        Me.gfxProdBarras.Location = New System.Drawing.Point(12, 193)
        Me.gfxProdBarras.Name = "gfxProdBarras"
        Me.gfxProdBarras.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series1.Name = "fresas"
        Series2.Name = "servicios"
        Me.gfxProdBarras.Series.Add(Series1)
        Me.gfxProdBarras.Series.Add(Series2)
        Me.gfxProdBarras.Size = New System.Drawing.Size(792, 188)
        Me.gfxProdBarras.TabIndex = 2
        Me.gfxProdBarras.Text = "Chart1"
        Title1.Docking = Dundas.Charting.WinControl.Docking.Right
        Title1.Name = "Title1"
        Me.gfxProdBarras.Titles.Add(Title1)
        '
        'dateDesde
        '
        Me.dateDesde.Location = New System.Drawing.Point(330, 25)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.Size = New System.Drawing.Size(197, 20)
        Me.dateDesde.TabIndex = 3
        '
        'dateHasta
        '
        Me.dateHasta.Location = New System.Drawing.Point(330, 51)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.Size = New System.Drawing.Size(197, 20)
        Me.dateHasta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hasta"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(330, 77)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 24)
        Me.btnActualizar.TabIndex = 38
        Me.btnActualizar.Text = "Actualizar"
        '
        'GaugeContainer2
        '
        Me.GaugeContainer2.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.GaugeContainer2.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        CircularGauge2.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge2.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge2.Location.X = 0.0!
        CircularGauge2.Location.Y = 0.0!
        CircularGauge2.Name = "Default"
        CircularGauge2.PivotPoint.X = 50.0!
        CircularGauge2.PivotPoint.Y = 50.0!
        CircularPointer2.Name = "Default"
        CircularGauge2.Pointers.Add(CircularPointer2)
        CircularRange2.Name = "Range1"
        CircularGauge2.Ranges.Add(CircularRange2)
        CircularScale2.Name = "Default"
        CircularGauge2.Scales.Add(CircularScale2)
        CircularGauge2.Size.Height = 100.0!
        CircularGauge2.Size.Width = 100.0!
        Me.GaugeContainer2.CircularGauges.Add(CircularGauge2)
        Me.GaugeContainer2.InternalBackgroundPaint = False
        Me.GaugeContainer2.Location = New System.Drawing.Point(326, 387)
        Me.GaugeContainer2.Name = "GaugeContainer2"
        Me.GaugeContainer2.Size = New System.Drawing.Size(168, 173)
        Me.GaugeContainer2.TabIndex = 39
        InputValue2.Name = "Default"
        Me.GaugeContainer2.Values.Add(InputValue2)
        '
        'GaugeContainer3
        '
        Me.GaugeContainer3.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.GaugeContainer3.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        CircularGauge3.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge3.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge3.Location.X = 0.0!
        CircularGauge3.Location.Y = 0.0!
        CircularGauge3.Name = "Default"
        CircularGauge3.PivotPoint.X = 50.0!
        CircularGauge3.PivotPoint.Y = 50.0!
        CircularPointer3.Name = "Default"
        CircularGauge3.Pointers.Add(CircularPointer3)
        CircularRange3.Name = "Range1"
        CircularGauge3.Ranges.Add(CircularRange3)
        CircularScale3.Name = "Default"
        CircularGauge3.Scales.Add(CircularScale3)
        CircularGauge3.Size.Height = 100.0!
        CircularGauge3.Size.Width = 100.0!
        Me.GaugeContainer3.CircularGauges.Add(CircularGauge3)
        Me.GaugeContainer3.InternalBackgroundPaint = False
        Me.GaugeContainer3.Location = New System.Drawing.Point(12, 387)
        Me.GaugeContainer3.Name = "GaugeContainer3"
        Me.GaugeContainer3.Size = New System.Drawing.Size(168, 173)
        Me.GaugeContainer3.TabIndex = 40
        InputValue3.Name = "Default"
        Me.GaugeContainer3.Values.Add(InputValue3)
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Azure
        Me.Chart1.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.Chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.Chart1.BorderLineColor = System.Drawing.Color.LightGray
        Me.Chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.Chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        ChartArea2.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.Margin = False
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.DimGray
        ChartArea2.Name = "Default"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.BorderColor = System.Drawing.Color.Transparent
        Legend2.Name = "Default"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series3.ChartType = "SplineArea"
        Series3.Name = "Default"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(271, 156)
        Me.Chart1.TabIndex = 41
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.Azure
        Me.Chart2.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.Chart2.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.Chart2.BorderLineColor = System.Drawing.Color.LightGray
        Me.Chart2.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.Chart2.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        ChartArea3.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea3.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea3.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea3.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea3.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea3.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.BorderColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "Default"
        Me.Chart2.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.BorderColor = System.Drawing.Color.Transparent
        Legend3.Name = "Default"
        Me.Chart2.Legends.Add(Legend3)
        Me.Chart2.Location = New System.Drawing.Point(533, 12)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series4.ChartType = "Pie"
        Series4.Name = "Default"
        Me.Chart2.Series.Add(Series4)
        Me.Chart2.Size = New System.Drawing.Size(271, 156)
        Me.Chart2.TabIndex = 42
        Me.Chart2.Text = "Chart2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Produccion por mes ($)"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 566)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.GaugeContainer3)
        Me.Controls.Add(Me.GaugeContainer2)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateHasta)
        Me.Controls.Add(Me.dateDesde)
        Me.Controls.Add(Me.gfxProdBarras)
        Me.Controls.Add(Me.GaugeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tablero de Comando"
        CType(Me.GaugeContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gfxProdBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaugeContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaugeContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GaugeContainer1 As Dundas.Gauges.WinControl.GaugeContainer
    Friend WithEvents gfxProdBarras As Dundas.Charting.WinControl.Chart
    Friend WithEvents dateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GaugeContainer2 As Dundas.Gauges.WinControl.GaugeContainer
    Friend WithEvents GaugeContainer3 As Dundas.Gauges.WinControl.GaugeContainer
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart
    Friend WithEvents Chart2 As Dundas.Charting.WinControl.Chart
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
