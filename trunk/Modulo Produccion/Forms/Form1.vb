Imports Infragistics.UltraChart.Data
Imports System.Data.SqlClient

Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim conn As New SqlConnection("workstation id=athlon;packet size=4096;integrated security=SSPI;initial catalog=Afilar;persist security info=False")
    Dim DS As DataSet
    Dim tabla As New DataTable
    ' Dim resultado As New maquinasColeccion
    'Dim colMaquinas As New maquinasColeccion



#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grd2 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grd1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraChart1 As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grd3 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraComboEditor1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ShadowEffect1 As Infragistics.UltraChart.Resources.Appearance.ShadowEffect = New Infragistics.UltraChart.Resources.Appearance.ShadowEffect
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement
        Dim PaintElement2 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.grd2 = New System.Windows.Forms.DataGrid
        Me.grd1 = New System.Windows.Forms.DataGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraComboEditor1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.grd3 = New System.Windows.Forms.DataGrid
        Me.UltraChart1 = New Infragistics.Win.UltraWinChart.UltraChart
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.grd2)
        Me.UltraTabPageControl1.Controls.Add(Me.grd1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(756, 542)
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(648, 504)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton3.TabIndex = 3
        Me.UltraButton3.Text = "Salir"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(544, 504)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton1.TabIndex = 2
        Me.UltraButton1.Text = "Programar"
        '
        'grd2
        '
        Me.grd2.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.grd2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grd2.BackgroundColor = System.Drawing.Color.LightGray
        Me.grd2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd2.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grd2.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.grd2.CaptionText = "Items a programar"
        Me.grd2.DataMember = ""
        Me.grd2.FlatMode = True
        Me.grd2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.grd2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grd2.GridLineColor = System.Drawing.Color.Gainsboro
        Me.grd2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grd2.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.grd2.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grd2.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.grd2.LinkColor = System.Drawing.Color.Teal
        Me.grd2.Location = New System.Drawing.Point(16, 272)
        Me.grd2.Name = "grd2"
        Me.grd2.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.grd2.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.grd2.ReadOnly = True
        Me.grd2.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.grd2.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.grd2.Size = New System.Drawing.Size(720, 216)
        Me.grd2.TabIndex = 1
        '
        'grd1
        '
        Me.grd1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.grd1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grd1.BackgroundColor = System.Drawing.Color.LightGray
        Me.grd1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grd1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.grd1.CaptionText = "Pedidos"
        Me.grd1.DataMember = ""
        Me.grd1.FlatMode = True
        Me.grd1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.grd1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grd1.GridLineColor = System.Drawing.Color.Gainsboro
        Me.grd1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grd1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.grd1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grd1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.grd1.LinkColor = System.Drawing.Color.Teal
        Me.grd1.Location = New System.Drawing.Point(16, 24)
        Me.grd1.Name = "grd1"
        Me.grd1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.grd1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.grd1.ReadOnly = True
        Me.grd1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.grd1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.grd1.Size = New System.Drawing.Size(720, 233)
        Me.grd1.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraChart1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(756, 542)
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(480, 504)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(136, 24)
        Me.UltraButton5.TabIndex = 6
        Me.UltraButton5.Text = "Guardar programacion"
        '
        'UltraButton4
        '
        Me.UltraButton4.Location = New System.Drawing.Point(632, 504)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(104, 24)
        Me.UltraButton4.TabIndex = 5
        Me.UltraButton4.Text = "Salir"
        '
        'UltraGroupBox1
        '
        Appearance1.BackColor = System.Drawing.Color.LightGray
        Appearance1.BackColor2 = System.Drawing.Color.LightGray
        Me.UltraGroupBox1.Appearance = Appearance1
        Me.UltraGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Appearance2.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance2.BackColor2 = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance2
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraComboEditor1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton2)
        Me.UltraGroupBox1.Controls.Add(Me.grd3)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(720, 160)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "Actividades a programar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(512, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ver Producto Nro:"
        '
        'UltraComboEditor1
        '
        Me.UltraComboEditor1.AutoSize = True
        Me.UltraComboEditor1.Enabled = False
        Me.UltraComboEditor1.Location = New System.Drawing.Point(512, 128)
        Me.UltraComboEditor1.Name = "UltraComboEditor1"
        Me.UltraComboEditor1.Size = New System.Drawing.Size(144, 21)
        Me.UltraComboEditor1.SortStyle = Infragistics.Win.ValueListSortStyle.AscendingByValue
        Me.UltraComboEditor1.TabIndex = 6
        '
        'UltraButton2
        '
        Me.UltraButton2.Enabled = False
        Me.UltraButton2.Location = New System.Drawing.Point(512, 56)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(144, 24)
        Me.UltraButton2.TabIndex = 5
        Me.UltraButton2.Text = "Ver Programacion"
        '
        'grd3
        '
        Me.grd3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd3.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grd3.CaptionText = "Actividades a programar"
        Me.grd3.CaptionVisible = False
        Me.grd3.DataMember = ""
        Me.grd3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd3.Location = New System.Drawing.Point(16, 24)
        Me.grd3.Name = "grd3"
        Me.grd3.Size = New System.Drawing.Size(456, 128)
        Me.grd3.TabIndex = 4
        '
        ''UltraChart' properties's serialization: Since 'ChartType' changes the way axes look,
        ''ChartType' must be persisted ahead of any Axes change made in design time.
        '
        Me.UltraChart1.ChartType = Infragistics.UltraChart.[Shared].Styles.ChartType.GanttChart
        '
        'UltraChart1
        '
        Me.UltraChart1.Axis.X.Labels.Flip = False
        Me.UltraChart1.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL:dd-MM>"
        Me.UltraChart1.Axis.X.Labels.OrientationAngle = 47
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.FormatString = ""
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X.ScrollScale.Height = 10
        Me.UltraChart1.Axis.X.ScrollScale.Visible = False
        Me.UltraChart1.Axis.X.ScrollScale.Width = 15
        Me.UltraChart1.Axis.X.TickmarkInterval = 0
        Me.UltraChart1.Axis.X2.Labels.Flip = False
        Me.UltraChart1.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL:MM-dd-yy>"
        Me.UltraChart1.Axis.X2.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.FormatString = ""
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X2.ScrollScale.Height = 10
        Me.UltraChart1.Axis.X2.ScrollScale.Visible = False
        Me.UltraChart1.Axis.X2.ScrollScale.Width = 15
        Me.UltraChart1.Axis.X2.TickmarkInterval = 0
        Me.UltraChart1.Axis.Y.Labels.Flip = False
        Me.UltraChart1.Axis.Y.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.UltraChart1.Axis.Y.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y.ScrollScale.Height = 10
        Me.UltraChart1.Axis.Y.ScrollScale.Visible = False
        Me.UltraChart1.Axis.Y.ScrollScale.Width = 15
        Me.UltraChart1.Axis.Y.TickmarkInterval = 0
        Me.UltraChart1.Axis.Y2.Labels.Flip = False
        Me.UltraChart1.Axis.Y2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.UltraChart1.Axis.Y2.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y2.ScrollScale.Height = 10
        Me.UltraChart1.Axis.Y2.ScrollScale.Visible = False
        Me.UltraChart1.Axis.Y2.ScrollScale.Width = 15
        Me.UltraChart1.Axis.Y2.TickmarkInterval = 0
        Me.UltraChart1.Axis.Z.Labels.Flip = False
        Me.UltraChart1.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z.ScrollScale.Height = 10
        Me.UltraChart1.Axis.Z.ScrollScale.Visible = False
        Me.UltraChart1.Axis.Z.ScrollScale.Width = 15
        Me.UltraChart1.Axis.Z.TickmarkInterval = 0
        Me.UltraChart1.Axis.Z2.Labels.Flip = False
        Me.UltraChart1.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Z2.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z2.ScrollScale.Height = 10
        Me.UltraChart1.Axis.Z2.ScrollScale.Visible = False
        Me.UltraChart1.Axis.Z2.ScrollScale.Width = 15
        Me.UltraChart1.Axis.Z2.TickmarkInterval = 0
        Me.UltraChart1.ColorModel.Scaling = Infragistics.UltraChart.[Shared].Styles.ColorScaling.Decreasing
        ShadowEffect1.Angle = 45
        ShadowEffect1.Color = System.Drawing.Color.Gray
        ShadowEffect1.Depth = 3
        Me.UltraChart1.Effects.Effects.Add(ShadowEffect1)
        Me.UltraChart1.ForeColor = System.Drawing.SystemColors.ControlText
        PaintElement1.Fill = System.Drawing.Color.Yellow
        Me.UltraChart1.GanttChart.CompletePercentagesPE = PaintElement1
        PaintElement2.Fill = System.Drawing.Color.White
        Me.UltraChart1.GanttChart.EmptyPercentagesPE = PaintElement2
        Me.UltraChart1.GanttChart.LinkLineStyle.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Solid
        Me.UltraChart1.GanttChart.LinkLineStyle.EndStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.ArrowAnchor
        Me.UltraChart1.GanttChart.LinkLineStyle.MidPointAnchors = False
        Me.UltraChart1.GanttChart.LinkLineStyle.StartStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.NoAnchor
        Me.UltraChart1.GanttChart.OwnersLabelStyle.ClipText = True
        Me.UltraChart1.GanttChart.OwnersLabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.UltraChart1.GanttChart.OwnersLabelStyle.WrapText = True
        Me.UltraChart1.GanttChart.ShowOwners = True
        Me.UltraChart1.Location = New System.Drawing.Point(16, 176)
        Me.UltraChart1.Name = "UltraChart1"
        Me.UltraChart1.Size = New System.Drawing.Size(720, 310)
        Me.UltraChart1.TabIndex = 2
        Me.UltraChart1.TitleBottom.Text = ""
        Me.UltraChart1.TitleBottom.Visible = False
        Me.UltraChart1.TitleTop.Text = ""
        Me.UltraChart1.TitleTop.Visible = False
        Me.UltraChart1.Tooltips.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.UltraChart1.Tooltips.UseControl = False
        Me.UltraChart1.Visible = False
        '
        'UltraTabControl1
        '
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance3.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance3
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance4
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 3)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance5.BackColor = System.Drawing.Color.Silver
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance5
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(760, 565)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Pedidos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Programacion"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(756, 542)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 563)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Programar produccion"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        princ.barra.agregarBoton(Me)

        conn.Open()

        Dim sql As String = "select P.idpedido, P.fechaRealizacion, E.nombre, P.prioridad, C.nombre " & _
            "from pedido P, estado E, cliente C " & _
            "where P.idestado=E.idestado AND P.idcliente = C.idcliente and P.idestado = 8 "

        Dim comm As New SqlCommand(sql, conn)
        Dim DA As New SqlDataAdapter(comm)

        DS = New DataSet
        DA.Fill(DS, "pedidos")

        grd1.DataSource = DS.Tables.Item("pedidos")

        'comm.CommandText = "select F.nropedido, F.nroserie, F.fechafinfabricacion, TF.nombre, E.nombre from fresa F, " & _
        '    "estado E, tipofresa TF where F.estado = E.idestado AND F.idtipofresa=TF.idtipo"

        comm.CommandText = "select F.nropedido, F.nroserie, F.fechafinfabricacion, TF.nombre, E.nombre from fresa F, " & _
            "estado E, tipofresa TF where F.estado = E.idestado AND F.idtipo = TF.idtipo And F.idmodelo = TF.idmodelo And F.Estado = 8 "




        DA.Fill(DS, "Fresas")
        conn.Close()

        ' If Not dv2.Table.Columns.Contains("seleccionar") Then
        DS.Tables("pedidos").Columns.Add("seleccionar", Type.GetType("System.Boolean"))
        'End If

        Dim ts As New DataGridTableStyle
        ts.MappingName = "pedidos"

        Dim c0 As New grdstyle.CGridCheckBoxStyle("seleccionar", 30, HorizontalAlignment.Center, False, "", "", False, True, False, Nothing)
        ts.GridColumnStyles.Add(c0)

        Dim c1 As New grdstyle.CGridTextBoxStyle("idpedido", 70, HorizontalAlignment.Center, True, "Pedido Nro.", "", "")
        ts.GridColumnStyles.Add(c1)

        Dim c2 As New grdstyle.CGridTextBoxStyle("fechaRealizacion", 130, HorizontalAlignment.Center, True, "Fecha Realizacion", "", "")
        ts.GridColumnStyles.Add(c2)

        Dim c3 As New grdstyle.CGridTextBoxStyle("nombre", 130, HorizontalAlignment.Center, True, "Estado", "", "")
        ts.GridColumnStyles.Add(c3)

        Dim c4 As New grdstyle.CGridTextBoxStyle("Prioridad", 100, HorizontalAlignment.Center, True, "Prioridad", "", "")
        ts.GridColumnStyles.Add(c4)

        Dim c5 As New grdstyle.CGridTextBoxStyle("nombre1", 120, HorizontalAlignment.Center, True, "Cliente", "", "")
        ts.GridColumnStyles.Add(c5)

        grd1.TableStyles.Add(ts)

        Dim i As Integer
        For i = 0 To DS.Tables("pedidos").Rows.Count - 1
            DS.Tables("pedidos").Rows(i).Item("seleccionar") = False
        Next



    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click

        Dim i As Integer
        Dim kk As String = ""
        'MsgBox(DS.Tables("Fresas").Rows.Count)
        'For i = 0 To DS.Tables("Fresas").Rows.Count - 1

        For i = 0 To grd2.DataSource.count - 1
            kk = kk & " ," & grd2.Item(i, 1)
        Next

        If kk.Length > 0 Then
            UltraButton2.Enabled = True
            kk = kk.Substring(2)
            UltraTabControl1.SelectedTab = UltraTabControl1.Tabs(1)
        Else
            MsgBox("Debe programar al menos una actividad")
            Exit Sub
        End If

        Dim sql = "SELECT F.nroserie, EF.orden, O.nombre, O.duracionpromedio + EF.tiempoadicional Tiempo_Estimado, O.maquina " & _
                "FROM etapadefabricacion EF, operacion O, fresa F, tipofresa TF " & _
                "WHERE EF.idoperacion = O.idoperacion And EF.idtipofresa = TF.idtipo " & _
                "AND EF.idmodelo = TF.idmodelo AND F.idtipo = TF.idtipo AND F.idmodelo=TF.idmodelo AND F.nroserie IN(" & kk & ")" & _
                "ORDER BY F.nroserie"


        Dim comm As New SqlCommand(sql, conn)
        Dim DA As New SqlDataAdapter(comm)

        Try
            DS.Tables.Item("etapas").Clear()
        Catch ex As Exception
        End Try

        DA.Fill(DS, "etapas")
        grd3.DataSource = DS.Tables.Item("etapas")

        sql = "SELECT idtipo, nombre FROM tipomaquina"
        comm.CommandText = sql
        DA.Fill(DS, "maquinas")

    End Sub


    Private Sub grd1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.Click

        grd1.Select(grd1.CurrentRowIndex())

        If grd1.Item(grd1.CurrentRowIndex(), 0) = True Then
            grd1.Item(grd1.CurrentRowIndex(), 0) = False

        Else
            grd1.Item(grd1.CurrentRowIndex(), 0) = True

        End If

        Dim i As Integer
        Dim k As String = ""
        Dim j As DataRow

        For Each j In DS.Tables("Pedidos").Rows
            If j("seleccionar") = True Then
                k = k & " ," & j("idpedido")
            End If
        Next

        Dim dv2 As New DataView(DS.Tables.Item("Fresas"))

        If k.Length > 1 Then
            k = k.Substring(2)
            dv2.RowFilter = "nropedido IN( " & k & " )"
        Else
            dv2.RowFilter = "1=2"
        End If

        grd2.DataSource = dv2
        grd2.TableStyles.Clear()

        Dim nombres(DS.Tables.Item(0).Columns.Count - 1) As String
        Dim anchos(DS.Tables.Item(0).Columns.Count - 1) As Integer

        nombres(0) = "Nro Pedido"
        nombres(1) = "Nro Serie"
        nombres(2) = "Fecha Fin Fabric."
        nombres(3) = "Fresa"
        nombres(4) = "Estado"

        anchos(0) = 70
        anchos(1) = 80
        anchos(2) = 130
        anchos(3) = 110
        anchos(4) = 120

        cargarGrilla(grd2, dv2.Table, nombres, anchos)
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click

        Dim colTareas As New TareasCollection

        Dim tarea As tareas
        Dim maquina As maquinas
        Dim colmaquinas As New maquinasColeccion

        Dim roow() As DataRow = DS.Tables.Item("etapas").Select
        Dim mRow As DataRow

        Dim dv As New DataView(DS.Tables.Item("maquinas"))

        For Each mRow In roow
            tarea = New tareas

            dv.RowFilter = "nombre = '" & mRow.Item(4).trim & "'"

            tarea.id_maquina = dv.Item(0).Item(0)

            tarea.id_producto = mRow.Item(0)
            tarea.id_tarea = 1
            tarea.orden = mRow.Item(1)
            tarea.tiempo = mRow.Item(3)

            colTareas.add(tarea)
        Next

        dv.RowFilter = ""
        Dim maqRow() As DataRow = dv.Table.Select
        For Each mRow In maqRow
            maquina = New maquinas

            maquina.id_maquina = mRow.Item("idtipo")
            maquina.id_tipo = mRow.Item("idtipo")
            maquina.nombre = mRow.Item("nombre")
            maquina.nombre = maquina.nombre.Trim

            colMaquinas.add(maquina)
        Next


        Dim PRG As New programacionProduccion(colTareas, colMaquinas)

        Dim resultado As maquinasColeccion

        resultado = PRG.programar()



        tabla = New DataTable("datos")

        Dim row As DataRow
        Dim k As tareas
        Dim j As Integer

        tabla.Columns.Add("series", Type.GetType("System.String"))
        tabla.Columns.Add("task", Type.GetType("System.String"))
        tabla.Columns.Add("start") ', Type.GetType("system.DateTime"))
        tabla.Columns.Item(2).DataType = Type.GetType("System.DateTime")
        tabla.Columns.Add("end", Type.GetType("System.DateTime"))
        tabla.Columns.Add("owner") ', Type.GetType("System.integer"))
        tabla.Columns.Item(4).DataType = Type.GetType("System.String")
        tabla.Columns.Add("ID", Type.GetType("System.String"))

        UltraComboEditor1.Items.Clear()

        For j = 0 To resultado.Count - 1
            While resultado.Item(j).tareas.Count > 0
                row = tabla.NewRow()
                k = resultado.Item(j).tareas.Pop()


                Dim en As System.Collections.IEnumerator = colMaquinas.GetEnumerator
                While en.MoveNext
                    If en.Current.id_maquina = k.id_maquina Then
                        row("series") = en.Current.nombre
                    End If

                End While

                row("task") = "" '"Prod. " & 
                row("start") = Now.AddHours(k.inicio)
                row("end") = Now.AddHours(k.inicio + k.tiempo)
                row("owner") = k.id_producto '& "ord " & k.orden
                row("ID") = k.orden
                tabla.Rows.Add(row)

                Dim l As Infragistics.Win.ValueListItem
                Dim b As Boolean = True
                For Each l In UltraComboEditor1.Items
                    If l.DataValue = k.id_producto Then
                        b = False
                    End If
                Next

                If b Then
                    UltraComboEditor1.Items.Add(k.id_producto)
                End If


            End While
        Next
        UltraComboEditor1.Items.Add("Todos")

        Dim grafico As New Gantt(tabla, UltraChart1)

        UltraChart1.Visible = True

        Label1.Enabled = True
        UltraComboEditor1.Enabled = True

    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub


    'Private Sub UltraChart1_ChartDataClicked(ByVal sender As System.Object, ByVal e As Infragistics.UltraChart.Shared.Events.ChartDataEventArgs) Handles UltraChart1.ChartDataClicked
    '    MsgBox(e.LayerID)
    'End Sub


    Private Sub UltraComboEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboEditor1.ValueChanged

        Dim Programacion As New DataTable

        Programacion = tabla.Copy

        Dim i As Integer
        Dim j As Integer = 0
        If Not UltraComboEditor1.Value.ToString = "Todos" Then

            For i = 0 To Programacion.Rows.Count - 1

                If Not Programacion.Rows(j).Item(4) = UltraComboEditor1.Value Then
                    Programacion.Rows(j).Delete()
                    j -= 1
                End If

                j += 1
            Next

        End If

        Dim grafico As New Gantt(Programacion, UltraChart1)

    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Me.Close()
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Me.Close()
    End Sub


    Private Sub grd2_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grd2.Navigate

    End Sub

    Private Sub grd1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grd1.Navigate

    End Sub
End Class

Public Class Gantt
    Public Sub New(ByVal tabla As DataTable, ByVal chart As Infragistics.Win.UltraWinChart.UltraChart)

        chart.GanttChart.Columns.SeriesLabelsColumnIndex = 0
        chart.GanttChart.Columns.ItemLabelsColumnIndex = 1
        chart.GanttChart.Columns.StartTimeColumnIndex = 2
        chart.GanttChart.Columns.EndTimeColumnIndex = 3
        chart.GanttChart.Columns.OwnerColumnIndex = 4
        chart.GanttChart.Columns.IDColumnIndex = 5

        chart.Data.DataSource = tabla
        chart.DataBind()
    End Sub
End Class

Class guardar
    Private cMaq As maquinasColeccion

    Public Sub New(ByVal cm As maquinasColeccion) 'falta info para saber que pedidos las fresas programadas las se por el nro serie
        cMaq = cm

        '*****************************************************
        '* ACA ACTUALIZAR LAS TABLAS HOJA RUTA - DETALLE HR  *
        '* CAMBIAR EL ESTADO DE FRESA Y PEDIDO A PLANIFICADO *
        '*****************************************************


    End Sub
End Class
