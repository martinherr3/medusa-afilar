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
        Dim CircularGauge7 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer7 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange7 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale7 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim InputValue7 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim ChartArea7 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend7 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series9 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Series10 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title3 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Dim CircularGauge8 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer8 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange8 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale8 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim NumericIndicator5 As Dundas.Gauges.WinControl.NumericIndicator = New Dundas.Gauges.WinControl.NumericIndicator
        Dim InputValue8 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim CircularGauge9 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer9 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange9 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale9 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim NumericIndicator6 As Dundas.Gauges.WinControl.NumericIndicator = New Dundas.Gauges.WinControl.NumericIndicator
        Dim InputValue9 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim ChartArea8 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend8 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series11 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim ChartArea9 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend9 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series12 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
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
        CircularGauge7.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge7.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge7.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge7.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge7.BackFrame.FrameWidth = 5.0!
        CircularGauge7.Location.X = 0.0!
        CircularGauge7.Location.Y = 0.0!
        CircularGauge7.Name = "Default"
        CircularGauge7.PivotPoint.X = 50.0!
        CircularGauge7.PivotPoint.Y = 50.0!
        CircularPointer7.CapWidth = 30.0!
        CircularPointer7.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer7.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer7.Name = "Default"
        CircularPointer7.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge7.Pointers.Add(CircularPointer7)
        CircularRange7.BorderWidth = 0
        CircularRange7.EndValue = 80
        CircularRange7.FillColor = System.Drawing.Color.Yellow
        CircularRange7.Name = "Range1"
        CircularRange7.StartValue = 50
        CircularGauge7.Ranges.Add(CircularRange7)
        CircularScale7.BorderColor = System.Drawing.Color.White
        CircularScale7.BorderWidth = 1
        CircularScale7.FillColor = System.Drawing.Color.White
        CircularScale7.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale7.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale7.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale7.MajorTickMark.Width = 4.0!
        CircularScale7.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale7.MinorTickMark.Width = 2.0!
        CircularScale7.Name = "Default"
        CircularGauge7.Scales.Add(CircularScale7)
        CircularGauge7.Size.Height = 100.0!
        CircularGauge7.Size.Width = 100.0!
        Me.gaugeCosto.CircularGauges.Add(CircularGauge7)
        Me.gaugeCosto.InternalBackgroundPaint = False
        Me.gaugeCosto.Location = New System.Drawing.Point(626, 397)
        Me.gaugeCosto.Name = "gaugeCosto"
        Me.gaugeCosto.Size = New System.Drawing.Size(168, 173)
        Me.gaugeCosto.TabIndex = 1
        InputValue7.Name = "Default"
        Me.gaugeCosto.Values.Add(InputValue7)
        '
        'gfxProdBarras
        '
        Me.gfxProdBarras.BackColor = System.Drawing.Color.Azure
        Me.gfxProdBarras.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.gfxProdBarras.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.gfxProdBarras.BorderLineColor = System.Drawing.Color.LightGray
        Me.gfxProdBarras.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.gfxProdBarras.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        ChartArea7.AxisX.LabelStyle.Format = "Y"
        ChartArea7.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea7.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea7.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea7.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea7.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea7.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea7.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea7.BackColor = System.Drawing.Color.Transparent
        ChartArea7.BorderColor = System.Drawing.Color.DimGray
        ChartArea7.Name = "Default"
        Me.gfxProdBarras.ChartAreas.Add(ChartArea7)
        Legend7.BackColor = System.Drawing.Color.Transparent
        Legend7.BorderColor = System.Drawing.Color.Transparent
        Legend7.Docking = Dundas.Charting.WinControl.LegendDocking.Top
        Legend7.Name = "Default"
        Me.gfxProdBarras.Legends.Add(Legend7)
        Me.gfxProdBarras.Location = New System.Drawing.Point(12, 193)
        Me.gfxProdBarras.Name = "gfxProdBarras"
        Me.gfxProdBarras.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series9.Name = "fresas"
        Series10.Name = "servicios"
        Me.gfxProdBarras.Series.Add(Series9)
        Me.gfxProdBarras.Series.Add(Series10)
        Me.gfxProdBarras.Size = New System.Drawing.Size(792, 188)
        Me.gfxProdBarras.TabIndex = 2
        Me.gfxProdBarras.Text = "Chart1"
        Title3.Docking = Dundas.Charting.WinControl.Docking.Right
        Title3.Name = "Title1"
        Me.gfxProdBarras.Titles.Add(Title3)
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
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnActualizar.Appearance = Appearance3
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
        CircularGauge8.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge8.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge8.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge8.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge8.BackFrame.FrameWidth = 5.0!
        CircularGauge8.Location.X = 0.0!
        CircularGauge8.Location.Y = 0.0!
        CircularGauge8.Name = "Default"
        CircularGauge8.PivotPoint.X = 50.0!
        CircularGauge8.PivotPoint.Y = 50.0!
        CircularPointer8.CapWidth = 30.0!
        CircularPointer8.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer8.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer8.Name = "Default"
        CircularPointer8.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge8.Pointers.Add(CircularPointer8)
        CircularRange8.BorderWidth = 0
        CircularRange8.EndValue = 30
        CircularRange8.EndWidth = 10.0!
        CircularRange8.FillColor = System.Drawing.Color.SpringGreen
        CircularRange8.FillGradientType = Dundas.Gauges.WinControl.RangeGradientType.TopBottom
        CircularRange8.Name = "MaxLimit"
        CircularRange8.StartValue = -30
        CircularRange8.StartWidth = 10.0!
        CircularGauge8.Ranges.Add(CircularRange8)
        CircularScale8.BorderColor = System.Drawing.Color.White
        CircularScale8.BorderWidth = 1
        CircularScale8.FillColor = System.Drawing.Color.White
        CircularScale8.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale8.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale8.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale8.MajorTickMark.Width = 4.0!
        CircularScale8.Maximum = 50
        CircularScale8.Minimum = -50
        CircularScale8.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale8.MinorTickMark.Width = 2.0!
        CircularScale8.Name = "Default"
        CircularScale8.Radius = 36.0!
        CircularScale8.StartAngle = 60.0!
        CircularScale8.SweepAngle = 240.0!
        CircularGauge8.Scales.Add(CircularScale8)
        CircularGauge8.Size.Height = 100.0!
        CircularGauge8.Size.Width = 100.0!
        Me.gaugePlanificacionFin.CircularGauges.Add(CircularGauge8)
        Me.gaugePlanificacionFin.InternalBackgroundPaint = False
        Me.gaugePlanificacionFin.Location = New System.Drawing.Point(397, 397)
        Me.gaugePlanificacionFin.Name = "gaugePlanificacionFin"
        NumericIndicator5.BackColor = System.Drawing.Color.Silver
        NumericIndicator5.BackGradientEndColor = System.Drawing.Color.Gainsboro
        NumericIndicator5.BorderColor = System.Drawing.Color.Black
        NumericIndicator5.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator5.Decimals = 0
        NumericIndicator5.DigitColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator5.Digits = 3
        NumericIndicator5.IndicatorStyle = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator5.LedDimColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        NumericIndicator5.Location.X = 30.0!
        NumericIndicator5.Location.Y = 72.0!
        NumericIndicator5.Name = "NumericIndicator1"
        NumericIndicator5.Parent = "CircularGauges.Default"
        NumericIndicator5.ShadowOffset = 2.0!
        NumericIndicator5.ShowDecimalPoint = True
        NumericIndicator5.Size.Height = 10.0!
        NumericIndicator5.Size.Width = 40.0!
        NumericIndicator5.Style = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator5.Value = 46.28
        Me.gaugePlanificacionFin.NumericIndicators.Add(NumericIndicator5)
        Me.gaugePlanificacionFin.Size = New System.Drawing.Size(168, 173)
        Me.gaugePlanificacionFin.TabIndex = 39
        InputValue8.Name = "Default"
        Me.gaugePlanificacionFin.Values.Add(InputValue8)
        '
        'gaugePlanificacionInicio
        '
        Me.gaugePlanificacionInicio.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gaugePlanificacionInicio.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.gaugePlanificacionInicio.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.gaugePlanificacionInicio.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        Me.gaugePlanificacionInicio.BackFrame.FrameWidth = 5.0!
        CircularGauge9.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge9.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge9.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge9.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge9.BackFrame.FrameWidth = 5.0!
        CircularGauge9.Location.X = 0.0!
        CircularGauge9.Location.Y = 0.0!
        CircularGauge9.Name = "Default"
        CircularGauge9.PivotPoint.X = 50.0!
        CircularGauge9.PivotPoint.Y = 50.0!
        CircularPointer9.CapWidth = 30.0!
        CircularPointer9.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer9.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer9.Name = "Default"
        CircularPointer9.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge9.Pointers.Add(CircularPointer9)
        CircularRange9.BorderWidth = 0
        CircularRange9.EndValue = 30
        CircularRange9.EndWidth = 10.0!
        CircularRange9.FillColor = System.Drawing.Color.SpringGreen
        CircularRange9.FillGradientType = Dundas.Gauges.WinControl.RangeGradientType.TopBottom
        CircularRange9.Name = "MaxLimit"
        CircularRange9.StartValue = -30
        CircularRange9.StartWidth = 10.0!
        CircularGauge9.Ranges.Add(CircularRange9)
        CircularScale9.BorderColor = System.Drawing.Color.White
        CircularScale9.BorderWidth = 1
        CircularScale9.FillColor = System.Drawing.Color.White
        CircularScale9.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale9.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale9.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale9.MajorTickMark.Width = 4.0!
        CircularScale9.Maximum = 50
        CircularScale9.Minimum = -50
        CircularScale9.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale9.MinorTickMark.Width = 2.0!
        CircularScale9.Name = "Default"
        CircularScale9.Radius = 36.0!
        CircularScale9.StartAngle = 60.0!
        CircularScale9.SweepAngle = 240.0!
        CircularGauge9.Scales.Add(CircularScale9)
        CircularGauge9.Size.Height = 100.0!
        CircularGauge9.Size.Width = 100.0!
        Me.gaugePlanificacionInicio.CircularGauges.Add(CircularGauge9)
        Me.gaugePlanificacionInicio.InternalBackgroundPaint = False
        Me.gaugePlanificacionInicio.Location = New System.Drawing.Point(223, 397)
        Me.gaugePlanificacionInicio.Name = "gaugePlanificacionInicio"
        NumericIndicator6.BackColor = System.Drawing.Color.Silver
        NumericIndicator6.BackGradientEndColor = System.Drawing.Color.Gainsboro
        NumericIndicator6.BorderColor = System.Drawing.Color.Black
        NumericIndicator6.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator6.Decimals = 0
        NumericIndicator6.DigitColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator6.Digits = 3
        NumericIndicator6.IndicatorStyle = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator6.LedDimColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        NumericIndicator6.Location.X = 30.0!
        NumericIndicator6.Location.Y = 72.0!
        NumericIndicator6.Name = "NumericIndicator1"
        NumericIndicator6.Parent = "CircularGauges.Default"
        NumericIndicator6.ShadowOffset = 2.0!
        NumericIndicator6.ShowDecimalPoint = True
        NumericIndicator6.Size.Height = 10.0!
        NumericIndicator6.Size.Width = 40.0!
        NumericIndicator6.Style = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator6.Value = 46.28
        Me.gaugePlanificacionInicio.NumericIndicators.Add(NumericIndicator6)
        Me.gaugePlanificacionInicio.Size = New System.Drawing.Size(168, 173)
        Me.gaugePlanificacionInicio.TabIndex = 40
        InputValue9.Name = "Default"
        Me.gaugePlanificacionInicio.Values.Add(InputValue9)
        '
        'gfxServicios
        '
        Me.gfxServicios.BackColor = System.Drawing.Color.Azure
        Me.gfxServicios.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.gfxServicios.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.gfxServicios.BorderLineColor = System.Drawing.Color.LightGray
        Me.gfxServicios.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.gfxServicios.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        ChartArea8.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea8.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea8.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea8.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea8.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea8.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea8.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea8.BackColor = System.Drawing.Color.Transparent
        ChartArea8.BorderColor = System.Drawing.Color.Empty
        ChartArea8.Name = "Default"
        Me.gfxServicios.ChartAreas.Add(ChartArea8)
        Legend8.BackColor = System.Drawing.Color.Transparent
        Legend8.BorderColor = System.Drawing.Color.Transparent
        Legend8.Name = "Default"
        Me.gfxServicios.Legends.Add(Legend8)
        Me.gfxServicios.Location = New System.Drawing.Point(12, 25)
        Me.gfxServicios.Name = "gfxServicios"
        Me.gfxServicios.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series11.ChartType = "Pie"
        Series11.Name = "Servicios"
        Series11.ShadowOffset = 1
        Me.gfxServicios.Series.Add(Series11)
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
        ChartArea9.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea9.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea9.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea9.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea9.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea9.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea9.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea9.BackColor = System.Drawing.Color.Transparent
        ChartArea9.BorderColor = System.Drawing.Color.Transparent
        ChartArea9.Name = "Default"
        Me.gfxFresas.ChartAreas.Add(ChartArea9)
        Legend9.BackColor = System.Drawing.Color.Transparent
        Legend9.BorderColor = System.Drawing.Color.Transparent
        Legend9.Name = "Default"
        Me.gfxFresas.Legends.Add(Legend9)
        Me.gfxFresas.Location = New System.Drawing.Point(533, 25)
        Me.gfxFresas.Name = "gfxFresas"
        Me.gfxFresas.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series12.ChartType = "Pie"
        Series12.Name = "Fresas"
        Me.gfxFresas.Series.Add(Series12)
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
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(289, 170)
        Me.ProgressBar.Maximum = 80
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(237, 23)
        Me.ProgressBar.TabIndex = 53
        Me.ProgressBar.Visible = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 566)
        Me.Controls.Add(Me.ProgressBar)
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
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
End Class
