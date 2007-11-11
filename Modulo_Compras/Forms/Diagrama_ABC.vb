Imports System.Data.SqlClient

Public Class Diagrama_ABC
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents UltraChart1 As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ShadowEffect1 As Infragistics.UltraChart.Resources.Appearance.ShadowEffect = New Infragistics.UltraChart.Resources.Appearance.ShadowEffect
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Diagrama_ABC))
        Me.UltraChart1 = New Infragistics.Win.UltraWinChart.UltraChart
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraChart1
        '
        Me.UltraChart1.Axis.X.Labels.Flip = False
        Me.UltraChart1.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.UltraChart1.Axis.X.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X.ScrollScale.Height = 10
        Me.UltraChart1.Axis.X.ScrollScale.Visible = False
        Me.UltraChart1.Axis.X.ScrollScale.Width = 15
        Me.UltraChart1.Axis.X.TickmarkInterval = 0
        Me.UltraChart1.Axis.X2.Labels.Flip = False
        Me.UltraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.UltraChart1.Axis.X2.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X2.ScrollScale.Height = 10
        Me.UltraChart1.Axis.X2.ScrollScale.Visible = False
        Me.UltraChart1.Axis.X2.ScrollScale.Width = 15
        Me.UltraChart1.Axis.X2.TickmarkInterval = 0
        Me.UltraChart1.Axis.Y.Labels.Flip = False
        Me.UltraChart1.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.UltraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.00>"
        Me.UltraChart1.Axis.Y.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y.RangeMax = 100
        Me.UltraChart1.Axis.Y.RangeType = Infragistics.UltraChart.[Shared].Styles.AxisRangeType.Custom
        Me.UltraChart1.Axis.Y.ScrollScale.Height = 10
        Me.UltraChart1.Axis.Y.ScrollScale.Visible = False
        Me.UltraChart1.Axis.Y.ScrollScale.Width = 15
        Me.UltraChart1.Axis.Y.TickmarkInterval = 0
        Me.UltraChart1.Axis.Y2.Labels.Flip = False
        Me.UltraChart1.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.00>"
        Me.UltraChart1.Axis.Y2.Labels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.Flip = False
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.OrientationAngle = 0
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y2.ScrollScale.Height = 10
        Me.UltraChart1.Axis.Y2.ScrollScale.Visible = False
        Me.UltraChart1.Axis.Y2.ScrollScale.Width = 15
        Me.UltraChart1.Axis.Y2.TickmarkInterval = 0
        Me.UltraChart1.Axis.Z.Labels.Flip = False
        Me.UltraChart1.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z.Labels.ItemFormatString = "<DATA_VALUE:00.00>"
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
        Me.UltraChart1.Border.CornerRadius = 6
        Me.UltraChart1.ColorModel.AlphaLevel = CType(131, Byte)
        Me.UltraChart1.ColorModel.ColorBegin = System.Drawing.Color.LimeGreen
        Me.UltraChart1.ColorModel.ColorEnd = System.Drawing.Color.LightSkyBlue
        Me.UltraChart1.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.LinearRange
        Me.UltraChart1.Data.MaxValue = 0
        Me.UltraChart1.Data.MinValue = 100
        ShadowEffect1.Angle = 45
        Me.UltraChart1.Effects.Effects.Add(ShadowEffect1)
        Me.UltraChart1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraChart1.Location = New System.Drawing.Point(8, 16)
        Me.UltraChart1.Name = "UltraChart1"
        Me.UltraChart1.Size = New System.Drawing.Size(736, 392)
        Me.UltraChart1.TabIndex = 0
        Me.UltraChart1.TitleBottom.Text = ""
        Me.UltraChart1.TitleLeft.Text = ""
        Me.UltraChart1.TitleRight.Text = ""
        Me.UltraChart1.TitleTop.Text = ""
        Me.UltraChart1.Tooltips.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.UltraChart1.Tooltips.UseControl = False
        Me.UltraChart1.Transform3D.YRotation = 120.0!
        Me.UltraChart1.Transform3D.ZRotation = 10.0!
        '
        'UltraButton1
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButton1.Appearance = Appearance1
        Me.UltraButton1.Location = New System.Drawing.Point(663, 414)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(81, 31)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Salir"
        '
        'Diagrama_ABC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(754, 448)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraChart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "Diagrama_ABC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diagrama ABC"
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Diagrama_ABC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cnn.Open()

        Dim sql As String = "Select TMP.nombre, sum(DOC.cantidad * DOC.precio) total " & _
            "From detalleordencompra DOC, tipomateriaprima TMP " & _
            "Where(TMP.idtipomateriaprima = DOC.idtipomateriaprima) " & _
            "Group by TMP.nombre " & _
            "Order by total desc"
        Dim comm As New SqlCommand(sql, cnn)

        Dim DA As New SqlDataAdapter(comm)
        Dim DS As New DataSet
        DA.Fill(DS, "ABC")

        cnn.Close()

        Dim acum As Double = 0
        Dim dr As DataRow

        For Each dr In DS.Tables("ABC").Rows
            dr.Item(1) = dr.Item(1) + acum
            acum = dr.Item(1)
        Next

        For Each dr In DS.Tables("ABC").Rows
            dr.Item(1) = ((dr.Item(1) / acum) * 100)
        Next

        UltraChart1.DataSource = DS.Tables("ABC")

        UltraChart1.Axis.X.Labels.Visible = False

        'UltraChart1.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing

        UltraChart1.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing


    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub
End Class
