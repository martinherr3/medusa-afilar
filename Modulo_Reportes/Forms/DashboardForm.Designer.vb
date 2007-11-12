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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Dim CircularGauge2 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer2 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange2 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale2 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim NumericIndicator1 As Dundas.Gauges.WinControl.NumericIndicator = New Dundas.Gauges.WinControl.NumericIndicator
        Dim InputValue2 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim CircularGauge3 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer3 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange3 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale3 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim NumericIndicator2 As Dundas.Gauges.WinControl.NumericIndicator = New Dundas.Gauges.WinControl.NumericIndicator
        Dim InputValue3 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series3 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim ChartArea3 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend3 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series4 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Me.gaugeCosto = New Dundas.Gauges.WinControl.GaugeContainer
        Me.gfxProdBarras = New Dundas.Charting.WinControl.Chart
        Me.dateDesde = New System.Windows.Forms.DateTimePicker
        Me.dateHasta = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnActualizar = New Infragistics.Win.Misc.UltraButton
        Me.gaugePlanificacionFin = New Dundas.Gauges.WinControl.GaugeContainer
        Me.gaugePlanificacionInicio = New Dundas.Gauges.WinControl.GaugeContainer
        Me.gfxServicios = New Dundas.Charting.WinControl.Chart
        Me.gfxFresas = New Dundas.Charting.WinControl.Chart
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.gaugeCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gfxProdBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gaugePlanificacionFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gaugePlanificacionInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gfxServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gfxFresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gaugeCosto
        '
        Me.gaugeCosto.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gaugeCosto.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.gaugeCosto.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.gaugeCosto.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        Me.gaugeCosto.BackFrame.FrameWidth = 5.0!
        CircularGauge1.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge1.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge1.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge1.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge1.BackFrame.FrameWidth = 5.0!
        CircularGauge1.Location.X = 0.0!
        CircularGauge1.Location.Y = 0.0!
        CircularGauge1.Name = "Default"
        CircularGauge1.PivotPoint.X = 50.0!
        CircularGauge1.PivotPoint.Y = 50.0!
        CircularPointer1.CapWidth = 30.0!
        CircularPointer1.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer1.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer1.Name = "Default"
        CircularPointer1.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge1.Pointers.Add(CircularPointer1)
        CircularRange1.BorderWidth = 0
        CircularRange1.EndValue = 80
        CircularRange1.FillColor = System.Drawing.Color.Yellow
        CircularRange1.Name = "Range1"
        CircularRange1.StartValue = 50
        CircularGauge1.Ranges.Add(CircularRange1)
        CircularScale1.BorderColor = System.Drawing.Color.White
        CircularScale1.BorderWidth = 1
        CircularScale1.FillColor = System.Drawing.Color.White
        CircularScale1.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale1.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale1.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale1.MajorTickMark.Width = 4.0!
        CircularScale1.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale1.MinorTickMark.Width = 2.0!
        CircularScale1.Name = "Default"
        CircularGauge1.Scales.Add(CircularScale1)
        CircularGauge1.Size.Height = 100.0!
        CircularGauge1.Size.Width = 100.0!
        Me.gaugeCosto.CircularGauges.Add(CircularGauge1)
        Me.gaugeCosto.InternalBackgroundPaint = False
        Me.gaugeCosto.Location = New System.Drawing.Point(626, 397)
        Me.gaugeCosto.Name = "gaugeCosto"
        Me.gaugeCosto.Size = New System.Drawing.Size(168, 173)
        Me.gaugeCosto.TabIndex = 1
        InputValue1.Name = "Default"
        Me.gaugeCosto.Values.Add(InputValue1)
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
        Me.dateDesde.Location = New System.Drawing.Point(39, 36)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.Size = New System.Drawing.Size(192, 20)
        Me.dateDesde.TabIndex = 3
        '
        'dateHasta
        '
        Me.dateHasta.Location = New System.Drawing.Point(39, 62)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.Size = New System.Drawing.Size(192, 20)
        Me.dateHasta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hasta"
        '
        'btnActualizar
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnActualizar.Appearance = Appearance1
        Me.btnActualizar.Location = New System.Drawing.Point(39, 88)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(98, 38)
        Me.btnActualizar.TabIndex = 38
        Me.btnActualizar.Text = "Actualizar"
        '
        'gaugePlanificacionFin
        '
        Me.gaugePlanificacionFin.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gaugePlanificacionFin.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.gaugePlanificacionFin.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.gaugePlanificacionFin.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        Me.gaugePlanificacionFin.BackFrame.FrameWidth = 5.0!
        CircularGauge2.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge2.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge2.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge2.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge2.BackFrame.FrameWidth = 5.0!
        CircularGauge2.Location.X = 0.0!
        CircularGauge2.Location.Y = 0.0!
        CircularGauge2.Name = "Default"
        CircularGauge2.PivotPoint.X = 50.0!
        CircularGauge2.PivotPoint.Y = 50.0!
        CircularPointer2.CapWidth = 30.0!
        CircularPointer2.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer2.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer2.Name = "Default"
        CircularPointer2.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge2.Pointers.Add(CircularPointer2)
        CircularRange2.BorderWidth = 0
        CircularRange2.EndValue = 30
        CircularRange2.EndWidth = 10.0!
        CircularRange2.FillColor = System.Drawing.Color.SpringGreen
        CircularRange2.FillGradientType = Dundas.Gauges.WinControl.RangeGradientType.TopBottom
        CircularRange2.Name = "MaxLimit"
        CircularRange2.StartValue = -30
        CircularRange2.StartWidth = 10.0!
        CircularGauge2.Ranges.Add(CircularRange2)
        CircularScale2.BorderColor = System.Drawing.Color.White
        CircularScale2.BorderWidth = 1
        CircularScale2.FillColor = System.Drawing.Color.White
        CircularScale2.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale2.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale2.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale2.MajorTickMark.Width = 4.0!
        CircularScale2.Maximum = 50
        CircularScale2.Minimum = -50
        CircularScale2.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale2.MinorTickMark.Width = 2.0!
        CircularScale2.Name = "Default"
        CircularScale2.Radius = 36.0!
        CircularScale2.StartAngle = 60.0!
        CircularScale2.SweepAngle = 240.0!
        CircularGauge2.Scales.Add(CircularScale2)
        CircularGauge2.Size.Height = 100.0!
        CircularGauge2.Size.Width = 100.0!
        Me.gaugePlanificacionFin.CircularGauges.Add(CircularGauge2)
        Me.gaugePlanificacionFin.InternalBackgroundPaint = False
        Me.gaugePlanificacionFin.Location = New System.Drawing.Point(397, 397)
        Me.gaugePlanificacionFin.Name = "gaugePlanificacionFin"
        NumericIndicator1.BackColor = System.Drawing.Color.Silver
        NumericIndicator1.BackGradientEndColor = System.Drawing.Color.Gainsboro
        NumericIndicator1.BorderColor = System.Drawing.Color.Black
        NumericIndicator1.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator1.Decimals = 0
        NumericIndicator1.DigitColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator1.Digits = 3
        NumericIndicator1.IndicatorStyle = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator1.LedDimColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        NumericIndicator1.Location.X = 30.0!
        NumericIndicator1.Location.Y = 72.0!
        NumericIndicator1.Name = "NumericIndicator1"
        NumericIndicator1.Parent = "CircularGauges.Default"
        NumericIndicator1.ShadowOffset = 2.0!
        NumericIndicator1.ShowDecimalPoint = True
        NumericIndicator1.Size.Height = 10.0!
        NumericIndicator1.Size.Width = 40.0!
        NumericIndicator1.Style = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator1.Value = 46.28
        Me.gaugePlanificacionFin.NumericIndicators.Add(NumericIndicator1)
        Me.gaugePlanificacionFin.Size = New System.Drawing.Size(168, 173)
        Me.gaugePlanificacionFin.TabIndex = 39
        InputValue2.Name = "Default"
        Me.gaugePlanificacionFin.Values.Add(InputValue2)
        '
        'gaugePlanificacionInicio
        '
        Me.gaugePlanificacionInicio.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gaugePlanificacionInicio.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.gaugePlanificacionInicio.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.gaugePlanificacionInicio.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        Me.gaugePlanificacionInicio.BackFrame.FrameWidth = 5.0!
        CircularGauge3.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge3.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge3.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge3.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge3.BackFrame.FrameWidth = 5.0!
        CircularGauge3.Location.X = 0.0!
        CircularGauge3.Location.Y = 0.0!
        CircularGauge3.Name = "Default"
        CircularGauge3.PivotPoint.X = 50.0!
        CircularGauge3.PivotPoint.Y = 50.0!
        CircularPointer3.CapWidth = 30.0!
        CircularPointer3.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer3.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer3.Name = "Default"
        CircularPointer3.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge3.Pointers.Add(CircularPointer3)
        CircularRange3.BorderWidth = 0
        CircularRange3.EndValue = 30
        CircularRange3.EndWidth = 10.0!
        CircularRange3.FillColor = System.Drawing.Color.SpringGreen
        CircularRange3.FillGradientType = Dundas.Gauges.WinControl.RangeGradientType.TopBottom
        CircularRange3.Name = "MaxLimit"
        CircularRange3.StartValue = -30
        CircularRange3.StartWidth = 10.0!
        CircularGauge3.Ranges.Add(CircularRange3)
        CircularScale3.BorderColor = System.Drawing.Color.White
        CircularScale3.BorderWidth = 1
        CircularScale3.FillColor = System.Drawing.Color.White
        CircularScale3.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale3.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale3.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale3.MajorTickMark.Width = 4.0!
        CircularScale3.Maximum = 50
        CircularScale3.Minimum = -50
        CircularScale3.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale3.MinorTickMark.Width = 2.0!
        CircularScale3.Name = "Default"
        CircularScale3.Radius = 36.0!
        CircularScale3.StartAngle = 60.0!
        CircularScale3.SweepAngle = 240.0!
        CircularGauge3.Scales.Add(CircularScale3)
        CircularGauge3.Size.Height = 100.0!
        CircularGauge3.Size.Width = 100.0!
        Me.gaugePlanificacionInicio.CircularGauges.Add(CircularGauge3)
        Me.gaugePlanificacionInicio.InternalBackgroundPaint = False
        Me.gaugePlanificacionInicio.Location = New System.Drawing.Point(223, 397)
        Me.gaugePlanificacionInicio.Name = "gaugePlanificacionInicio"
        NumericIndicator2.BackColor = System.Drawing.Color.Silver
        NumericIndicator2.BackGradientEndColor = System.Drawing.Color.Gainsboro
        NumericIndicator2.BorderColor = System.Drawing.Color.Black
        NumericIndicator2.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator2.Decimals = 0
        NumericIndicator2.DigitColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator2.Digits = 3
        NumericIndicator2.IndicatorStyle = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator2.LedDimColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        NumericIndicator2.Location.X = 30.0!
        NumericIndicator2.Location.Y = 72.0!
        NumericIndicator2.Name = "NumericIndicator1"
        NumericIndicator2.Parent = "CircularGauges.Default"
        NumericIndicator2.ShadowOffset = 2.0!
        NumericIndicator2.ShowDecimalPoint = True
        NumericIndicator2.Size.Height = 10.0!
        NumericIndicator2.Size.Width = 40.0!
        NumericIndicator2.Style = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator2.Value = 46.28
        Me.gaugePlanificacionInicio.NumericIndicators.Add(NumericIndicator2)
        Me.gaugePlanificacionInicio.Size = New System.Drawing.Size(168, 173)
        Me.gaugePlanificacionInicio.TabIndex = 40
        InputValue3.Name = "Default"
        Me.gaugePlanificacionInicio.Values.Add(InputValue3)
        '
        'gfxServicios
        '
        Me.gfxServicios.BackColor = System.Drawing.Color.Azure
        Me.gfxServicios.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.gfxServicios.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.gfxServicios.BorderLineColor = System.Drawing.Color.LightGray
        Me.gfxServicios.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.gfxServicios.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        ChartArea2.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.Name = "Default"
        Me.gfxServicios.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.BorderColor = System.Drawing.Color.Transparent
        Legend2.Name = "Default"
        Me.gfxServicios.Legends.Add(Legend2)
        Me.gfxServicios.Location = New System.Drawing.Point(12, 25)
        Me.gfxServicios.Name = "gfxServicios"
        Me.gfxServicios.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series3.ChartType = "Pie"
        Series3.Name = "Servicios"
        Series3.ShadowOffset = 1
        Me.gfxServicios.Series.Add(Series3)
        Me.gfxServicios.Size = New System.Drawing.Size(271, 143)
        Me.gfxServicios.TabIndex = 41
        Me.gfxServicios.Text = "porcentajeServicios"
        '
        'gfxFresas
        '
        Me.gfxFresas.BackColor = System.Drawing.Color.Azure
        Me.gfxFresas.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.gfxFresas.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.gfxFresas.BorderLineColor = System.Drawing.Color.LightGray
        Me.gfxFresas.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.gfxFresas.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
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
        Me.gfxFresas.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.BorderColor = System.Drawing.Color.Transparent
        Legend3.Name = "Default"
        Me.gfxFresas.Legends.Add(Legend3)
        Me.gfxFresas.Location = New System.Drawing.Point(533, 25)
        Me.gfxFresas.Name = "gfxFresas"
        Me.gfxFresas.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series4.ChartType = "Pie"
        Series4.Name = "Fresas"
        Me.gfxFresas.Series.Add(Series4)
        Me.gfxFresas.Size = New System.Drawing.Size(271, 143)
        Me.gfxFresas.TabIndex = 42
        Me.gfxFresas.Text = "Chart2"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(634, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Costo Produccion (%)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(530, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Modelos Producidos (%)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Servicios (%)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(433, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Fin Actividad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(248, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Inicio Actividad "
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 136)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Exactitud de Planificacion (en horas): Representa la desviacion entre lo planific" & _
            "ado (fecha planificada) y lo ejecutado (fecha real) tanto de inicio como de fin " & _
            "de cada actividad."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 186)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desviacion de planificacion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.dateHasta)
        Me.GroupBox2.Controls.Add(Me.dateDesde)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(289, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 143)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo a analizar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(614, 384)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 186)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 566)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gfxFresas)
        Me.Controls.Add(Me.gfxServicios)
        Me.Controls.Add(Me.gaugePlanificacionInicio)
        Me.Controls.Add(Me.gaugePlanificacionFin)
        Me.Controls.Add(Me.gfxProdBarras)
        Me.Controls.Add(Me.gaugeCosto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tablero de Comando"
        CType(Me.gaugeCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gfxProdBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gaugePlanificacionFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gaugePlanificacionInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gfxServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gfxFresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gaugeCosto As Dundas.Gauges.WinControl.GaugeContainer
    Friend WithEvents gfxProdBarras As Dundas.Charting.WinControl.Chart
    Friend WithEvents dateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gaugePlanificacionFin As Dundas.Gauges.WinControl.GaugeContainer
    Friend WithEvents gaugePlanificacionInicio As Dundas.Gauges.WinControl.GaugeContainer
    Friend WithEvents gfxServicios As Dundas.Charting.WinControl.Chart
    Friend WithEvents gfxFresas As Dundas.Charting.WinControl.Chart
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
