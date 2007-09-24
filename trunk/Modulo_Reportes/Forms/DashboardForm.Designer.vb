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
        Dim CircularGauge19 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer19 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange19 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale19 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim InputValue19 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim ChartArea19 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend19 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series25 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Series26 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title7 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim CircularGauge20 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer20 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange20 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale20 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim NumericIndicator13 As Dundas.Gauges.WinControl.NumericIndicator = New Dundas.Gauges.WinControl.NumericIndicator
        Dim InputValue20 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim CircularGauge21 As Dundas.Gauges.WinControl.CircularGauge = New Dundas.Gauges.WinControl.CircularGauge
        Dim CircularPointer21 As Dundas.Gauges.WinControl.CircularPointer = New Dundas.Gauges.WinControl.CircularPointer
        Dim CircularRange21 As Dundas.Gauges.WinControl.CircularRange = New Dundas.Gauges.WinControl.CircularRange
        Dim CircularScale21 As Dundas.Gauges.WinControl.CircularScale = New Dundas.Gauges.WinControl.CircularScale
        Dim NumericIndicator14 As Dundas.Gauges.WinControl.NumericIndicator = New Dundas.Gauges.WinControl.NumericIndicator
        Dim InputValue21 As Dundas.Gauges.WinControl.InputValue = New Dundas.Gauges.WinControl.InputValue
        Dim ChartArea20 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend20 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series27 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim ChartArea21 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend21 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series28 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
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
        CircularGauge19.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge19.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge19.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge19.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge19.BackFrame.FrameWidth = 5.0!
        CircularGauge19.Location.X = 0.0!
        CircularGauge19.Location.Y = 0.0!
        CircularGauge19.Name = "Default"
        CircularGauge19.PivotPoint.X = 50.0!
        CircularGauge19.PivotPoint.Y = 50.0!
        CircularPointer19.CapWidth = 30.0!
        CircularPointer19.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer19.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer19.Name = "Default"
        CircularPointer19.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge19.Pointers.Add(CircularPointer19)
        CircularRange19.BorderWidth = 0
        CircularRange19.EndValue = 80
        CircularRange19.FillColor = System.Drawing.Color.Yellow
        CircularRange19.Name = "Range1"
        CircularRange19.StartValue = 50
        CircularGauge19.Ranges.Add(CircularRange19)
        CircularScale19.BorderColor = System.Drawing.Color.White
        CircularScale19.BorderWidth = 1
        CircularScale19.FillColor = System.Drawing.Color.White
        CircularScale19.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale19.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale19.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale19.MajorTickMark.Width = 4.0!
        CircularScale19.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale19.MinorTickMark.Width = 2.0!
        CircularScale19.Name = "Default"
        CircularGauge19.Scales.Add(CircularScale19)
        CircularGauge19.Size.Height = 100.0!
        CircularGauge19.Size.Width = 100.0!
        Me.gaugeCosto.CircularGauges.Add(CircularGauge19)
        Me.gaugeCosto.InternalBackgroundPaint = False
        Me.gaugeCosto.Location = New System.Drawing.Point(626, 397)
        Me.gaugeCosto.Name = "gaugeCosto"
        Me.gaugeCosto.Size = New System.Drawing.Size(168, 173)
        Me.gaugeCosto.TabIndex = 1
        InputValue19.Name = "Default"
        Me.gaugeCosto.Values.Add(InputValue19)
        '
        'gfxProdBarras
        '
        Me.gfxProdBarras.BackColor = System.Drawing.Color.Azure
        Me.gfxProdBarras.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.gfxProdBarras.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.gfxProdBarras.BorderLineColor = System.Drawing.Color.LightGray
        Me.gfxProdBarras.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.gfxProdBarras.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        ChartArea19.AxisX.LabelStyle.Format = "Y"
        ChartArea19.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea19.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea19.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea19.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea19.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea19.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea19.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea19.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea19.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea19.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea19.BackColor = System.Drawing.Color.Transparent
        ChartArea19.BorderColor = System.Drawing.Color.DimGray
        ChartArea19.Name = "Default"
        Me.gfxProdBarras.ChartAreas.Add(ChartArea19)
        Legend19.BackColor = System.Drawing.Color.Transparent
        Legend19.BorderColor = System.Drawing.Color.Transparent
        Legend19.Docking = Dundas.Charting.WinControl.LegendDocking.Top
        Legend19.Name = "Default"
        Me.gfxProdBarras.Legends.Add(Legend19)
        Me.gfxProdBarras.Location = New System.Drawing.Point(12, 193)
        Me.gfxProdBarras.Name = "gfxProdBarras"
        Me.gfxProdBarras.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series25.Name = "fresas"
        Series26.Name = "servicios"
        Me.gfxProdBarras.Series.Add(Series25)
        Me.gfxProdBarras.Series.Add(Series26)
        Me.gfxProdBarras.Size = New System.Drawing.Size(792, 188)
        Me.gfxProdBarras.TabIndex = 2
        Me.gfxProdBarras.Text = "Chart1"
        Title7.Docking = Dundas.Charting.WinControl.Docking.Right
        Title7.Name = "Title1"
        Me.gfxProdBarras.Titles.Add(Title7)
        '
        'dateDesde
        '
        Me.dateDesde.Location = New System.Drawing.Point(39, 36)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.Size = New System.Drawing.Size(196, 20)
        Me.dateDesde.TabIndex = 3
        '
        'dateHasta
        '
        Me.dateHasta.Location = New System.Drawing.Point(39, 62)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.Size = New System.Drawing.Size(196, 20)
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
        Me.btnActualizar.Location = New System.Drawing.Point(41, 88)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 24)
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
        CircularGauge20.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge20.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge20.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge20.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge20.BackFrame.FrameWidth = 5.0!
        CircularGauge20.Location.X = 0.0!
        CircularGauge20.Location.Y = 0.0!
        CircularGauge20.Name = "Default"
        CircularGauge20.PivotPoint.X = 50.0!
        CircularGauge20.PivotPoint.Y = 50.0!
        CircularPointer20.CapWidth = 30.0!
        CircularPointer20.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer20.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer20.Name = "Default"
        CircularPointer20.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge20.Pointers.Add(CircularPointer20)
        CircularRange20.BorderWidth = 0
        CircularRange20.EndValue = 30
        CircularRange20.EndWidth = 10.0!
        CircularRange20.FillColor = System.Drawing.Color.SpringGreen
        CircularRange20.FillGradientType = Dundas.Gauges.WinControl.RangeGradientType.TopBottom
        CircularRange20.Name = "MaxLimit"
        CircularRange20.StartValue = -30
        CircularRange20.StartWidth = 10.0!
        CircularGauge20.Ranges.Add(CircularRange20)
        CircularScale20.BorderColor = System.Drawing.Color.White
        CircularScale20.BorderWidth = 1
        CircularScale20.FillColor = System.Drawing.Color.White
        CircularScale20.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale20.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale20.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale20.MajorTickMark.Width = 4.0!
        CircularScale20.Maximum = 50
        CircularScale20.Minimum = -50
        CircularScale20.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale20.MinorTickMark.Width = 2.0!
        CircularScale20.Name = "Default"
        CircularScale20.Radius = 36.0!
        CircularScale20.StartAngle = 60.0!
        CircularScale20.SweepAngle = 240.0!
        CircularGauge20.Scales.Add(CircularScale20)
        CircularGauge20.Size.Height = 100.0!
        CircularGauge20.Size.Width = 100.0!
        Me.gaugePlanificacionFin.CircularGauges.Add(CircularGauge20)
        Me.gaugePlanificacionFin.InternalBackgroundPaint = False
        Me.gaugePlanificacionFin.Location = New System.Drawing.Point(397, 397)
        Me.gaugePlanificacionFin.Name = "gaugePlanificacionFin"
        NumericIndicator13.BackColor = System.Drawing.Color.Silver
        NumericIndicator13.BackGradientEndColor = System.Drawing.Color.Gainsboro
        NumericIndicator13.BorderColor = System.Drawing.Color.Black
        NumericIndicator13.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator13.Decimals = 0
        NumericIndicator13.DigitColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator13.Digits = 3
        NumericIndicator13.IndicatorStyle = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator13.LedDimColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        NumericIndicator13.Location.X = 30.0!
        NumericIndicator13.Location.Y = 72.0!
        NumericIndicator13.Name = "NumericIndicator1"
        NumericIndicator13.Parent = "CircularGauges.Default"
        NumericIndicator13.ShadowOffset = 2.0!
        NumericIndicator13.ShowDecimalPoint = True
        NumericIndicator13.Size.Height = 10.0!
        NumericIndicator13.Size.Width = 40.0!
        NumericIndicator13.Style = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator13.Value = 46.28
        Me.gaugePlanificacionFin.NumericIndicators.Add(NumericIndicator13)
        Me.gaugePlanificacionFin.Size = New System.Drawing.Size(168, 173)
        Me.gaugePlanificacionFin.TabIndex = 39
        InputValue20.Name = "Default"
        Me.gaugePlanificacionFin.Values.Add(InputValue20)
        '
        'gaugePlanificacionInicio
        '
        Me.gaugePlanificacionInicio.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gaugePlanificacionInicio.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.gaugePlanificacionInicio.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.Rectangular
        Me.gaugePlanificacionInicio.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.None
        Me.gaugePlanificacionInicio.BackFrame.FrameWidth = 5.0!
        CircularGauge21.BackFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(146, Byte), Integer))
        CircularGauge21.BackFrame.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularGauge21.BackFrame.FrameShape = Dundas.Gauges.WinControl.BackFrameShape.CustomCircular3
        CircularGauge21.BackFrame.FrameStyle = Dundas.Gauges.WinControl.BackFrameStyle.Edged
        CircularGauge21.BackFrame.FrameWidth = 5.0!
        CircularGauge21.Location.X = 0.0!
        CircularGauge21.Location.Y = 0.0!
        CircularGauge21.Name = "Default"
        CircularGauge21.PivotPoint.X = 50.0!
        CircularGauge21.PivotPoint.Y = 50.0!
        CircularPointer21.CapWidth = 30.0!
        CircularPointer21.FillGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        CircularPointer21.FillGradientType = Dundas.Gauges.WinControl.GradientType.None
        CircularPointer21.Name = "Default"
        CircularPointer21.NeedleStyle = Dundas.Gauges.WinControl.NeedleStyle.NeedleStyle4
        CircularGauge21.Pointers.Add(CircularPointer21)
        CircularRange21.BorderWidth = 0
        CircularRange21.EndValue = 30
        CircularRange21.EndWidth = 10.0!
        CircularRange21.FillColor = System.Drawing.Color.SpringGreen
        CircularRange21.FillGradientType = Dundas.Gauges.WinControl.RangeGradientType.TopBottom
        CircularRange21.Name = "MaxLimit"
        CircularRange21.StartValue = -30
        CircularRange21.StartWidth = 10.0!
        CircularGauge21.Ranges.Add(CircularRange21)
        CircularScale21.BorderColor = System.Drawing.Color.White
        CircularScale21.BorderWidth = 1
        CircularScale21.FillColor = System.Drawing.Color.White
        CircularScale21.LabelStyle.TextColor = System.Drawing.Color.White
        CircularScale21.MajorTickMark.FillColor = System.Drawing.Color.White
        CircularScale21.MajorTickMark.Shape = Dundas.Gauges.WinControl.MarkerStyle.Rectangle
        CircularScale21.MajorTickMark.Width = 4.0!
        CircularScale21.Maximum = 50
        CircularScale21.Minimum = -50
        CircularScale21.MinorTickMark.FillColor = System.Drawing.Color.White
        CircularScale21.MinorTickMark.Width = 2.0!
        CircularScale21.Name = "Default"
        CircularScale21.Radius = 36.0!
        CircularScale21.StartAngle = 60.0!
        CircularScale21.SweepAngle = 240.0!
        CircularGauge21.Scales.Add(CircularScale21)
        CircularGauge21.Size.Height = 100.0!
        CircularGauge21.Size.Width = 100.0!
        Me.gaugePlanificacionInicio.CircularGauges.Add(CircularGauge21)
        Me.gaugePlanificacionInicio.InternalBackgroundPaint = False
        Me.gaugePlanificacionInicio.Location = New System.Drawing.Point(223, 397)
        Me.gaugePlanificacionInicio.Name = "gaugePlanificacionInicio"
        NumericIndicator14.BackColor = System.Drawing.Color.Silver
        NumericIndicator14.BackGradientEndColor = System.Drawing.Color.Gainsboro
        NumericIndicator14.BorderColor = System.Drawing.Color.Black
        NumericIndicator14.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator14.Decimals = 0
        NumericIndicator14.DigitColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        NumericIndicator14.Digits = 3
        NumericIndicator14.IndicatorStyle = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator14.LedDimColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        NumericIndicator14.Location.X = 30.0!
        NumericIndicator14.Location.Y = 72.0!
        NumericIndicator14.Name = "NumericIndicator1"
        NumericIndicator14.Parent = "CircularGauges.Default"
        NumericIndicator14.ShadowOffset = 2.0!
        NumericIndicator14.ShowDecimalPoint = True
        NumericIndicator14.Size.Height = 10.0!
        NumericIndicator14.Size.Width = 40.0!
        NumericIndicator14.Style = Dundas.Gauges.WinControl.NumericIndicatorStyle.Digital7Segment
        NumericIndicator14.Value = 46.28
        Me.gaugePlanificacionInicio.NumericIndicators.Add(NumericIndicator14)
        Me.gaugePlanificacionInicio.Size = New System.Drawing.Size(168, 173)
        Me.gaugePlanificacionInicio.TabIndex = 40
        InputValue21.Name = "Default"
        Me.gaugePlanificacionInicio.Values.Add(InputValue21)
        '
        'gfxServicios
        '
        Me.gfxServicios.BackColor = System.Drawing.Color.Azure
        Me.gfxServicios.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.gfxServicios.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.gfxServicios.BorderLineColor = System.Drawing.Color.LightGray
        Me.gfxServicios.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.gfxServicios.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        ChartArea20.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea20.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea20.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea20.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea20.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea20.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea20.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea20.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea20.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea20.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea20.BackColor = System.Drawing.Color.Transparent
        ChartArea20.BorderColor = System.Drawing.Color.Empty
        ChartArea20.Name = "Default"
        Me.gfxServicios.ChartAreas.Add(ChartArea20)
        Legend20.BackColor = System.Drawing.Color.Transparent
        Legend20.BorderColor = System.Drawing.Color.Transparent
        Legend20.Name = "Default"
        Me.gfxServicios.Legends.Add(Legend20)
        Me.gfxServicios.Location = New System.Drawing.Point(12, 25)
        Me.gfxServicios.Name = "gfxServicios"
        Me.gfxServicios.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series27.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series27.ChartType = "Pie"
        Series27.Name = "Servicios"
        Series27.ShadowOffset = 1
        Me.gfxServicios.Series.Add(Series27)
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
        ChartArea21.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea21.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea21.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea21.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea21.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea21.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea21.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea21.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea21.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea21.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea21.BackColor = System.Drawing.Color.Transparent
        ChartArea21.BorderColor = System.Drawing.Color.Transparent
        ChartArea21.Name = "Default"
        Me.gfxFresas.ChartAreas.Add(ChartArea21)
        Legend21.BackColor = System.Drawing.Color.Transparent
        Legend21.BorderColor = System.Drawing.Color.Transparent
        Legend21.Name = "Default"
        Me.gfxFresas.Legends.Add(Legend21)
        Me.gfxFresas.Location = New System.Drawing.Point(533, 25)
        Me.gfxFresas.Name = "gfxFresas"
        Me.gfxFresas.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series28.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series28.ChartType = "Pie"
        Series28.Name = "Fresas"
        Me.gfxFresas.Series.Add(Series28)
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
