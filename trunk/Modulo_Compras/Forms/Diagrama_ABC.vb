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
    Friend WithEvents btnClasificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegistrarClase As System.Windows.Forms.Button
    Friend WithEvents grbParametros As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents chkParametros As System.Windows.Forms.CheckBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ShadowEffect2 As Infragistics.UltraChart.Resources.Appearance.ShadowEffect = New Infragistics.UltraChart.Resources.Appearance.ShadowEffect
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Diagrama_ABC))
        Me.UltraChart1 = New Infragistics.Win.UltraWinChart.UltraChart
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.btnClasificar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRegistrarClase = New System.Windows.Forms.Button
        Me.grbParametros = New System.Windows.Forms.GroupBox
        Me.chkParametros = New System.Windows.Forms.CheckBox
        Me.txtA = New System.Windows.Forms.TextBox
        Me.txtB = New System.Windows.Forms.TextBox
        Me.txtC = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grbParametros.SuspendLayout()
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
        ShadowEffect2.Angle = 45
        Me.UltraChart1.Effects.Effects.Add(ShadowEffect2)
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
        Me.UltraChart1.Transform3D.YRotation = 117.0!
        Me.UltraChart1.Transform3D.ZRotation = 10.0!
        '
        'UltraButton1
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.Location = New System.Drawing.Point(663, 442)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(81, 31)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Salir"
        '
        'btnClasificar
        '
        Me.btnClasificar.Location = New System.Drawing.Point(6, 20)
        Me.btnClasificar.Name = "btnClasificar"
        Me.btnClasificar.Size = New System.Drawing.Size(115, 31)
        Me.btnClasificar.TabIndex = 2
        Me.btnClasificar.Text = "Clasificar"
        Me.btnClasificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegistrarClase)
        Me.GroupBox1.Controls.Add(Me.btnClasificar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 59)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnRegistrarClase
        '
        Me.btnRegistrarClase.Enabled = False
        Me.btnRegistrarClase.Location = New System.Drawing.Point(146, 20)
        Me.btnRegistrarClase.Name = "btnRegistrarClase"
        Me.btnRegistrarClase.Size = New System.Drawing.Size(115, 31)
        Me.btnRegistrarClase.TabIndex = 3
        Me.btnRegistrarClase.Text = "Registrar Clase"
        Me.btnRegistrarClase.UseVisualStyleBackColor = True
        '
        'grbParametros
        '
        Me.grbParametros.Controls.Add(Me.Label3)
        Me.grbParametros.Controls.Add(Me.Label2)
        Me.grbParametros.Controls.Add(Me.Label1)
        Me.grbParametros.Controls.Add(Me.txtC)
        Me.grbParametros.Controls.Add(Me.txtB)
        Me.grbParametros.Controls.Add(Me.txtA)
        Me.grbParametros.Location = New System.Drawing.Point(421, 414)
        Me.grbParametros.Name = "grbParametros"
        Me.grbParametros.Size = New System.Drawing.Size(224, 59)
        Me.grbParametros.TabIndex = 4
        Me.grbParametros.TabStop = False
        Me.grbParametros.Visible = False
        '
        'chkParametros
        '
        Me.chkParametros.AutoSize = True
        Me.chkParametros.Location = New System.Drawing.Point(285, 428)
        Me.chkParametros.Name = "chkParametros"
        Me.chkParametros.Size = New System.Drawing.Size(118, 17)
        Me.chkParametros.TabIndex = 5
        Me.chkParametros.Text = "Parametrizar Clases"
        Me.chkParametros.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(16, 12)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(55, 20)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(89, 12)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(58, 20)
        Me.txtB.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(164, 12)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(54, 20)
        Me.txtC.TabIndex = 2
        Me.txtC.Text = "100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "% A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "% B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "% C"
        '
        'Diagrama_ABC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(754, 478)
        Me.Controls.Add(Me.chkParametros)
        Me.Controls.Add(Me.grbParametros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraChart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "Diagrama_ABC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diagrama ABC"
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.grbParametros.ResumeLayout(False)
        Me.grbParametros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "--[Propiedades]--"
    Private DS As New DataSet
#End Region

#Region "--[Eventos]--"
    Private Sub Diagrama_ABC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'princ.barra.eliminarBoton()
    End Sub

    Private Sub Diagrama_ABC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'princ.barra.agregarBoton(Me)
        GenerarABC()
        BindiarGrafico()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub

    Private Sub btnClasificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClasificar.Click
        ClasificarABC()
        btnRegistrarClase.Enabled = True
    End Sub

    Private Sub btnRegistrarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarClase.Click
        RegistrarClase()
    End Sub

    Private Sub chkParametros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkParametros.CheckedChanged
        If chkParametros.Checked Then
            grbParametros.Visible = True
        Else
            grbParametros.Visible = False
        End If
    End Sub
#End Region

#Region "--[Metodos]--"
    Private Sub GenerarABC()
        Try
            cnn.Open()

            Dim sql As String = "Select TMP.nombre, sum(DOC.cantidad * DOC.precio) total " & _
                "From detalleordencompra DOC, tipomateriaprima TMP " & _
                "Where(TMP.idtipomateriaprima = DOC.idtipomateriaprima) " & _
                "Group by TMP.nombre " & _
                "Order by total desc"
            Dim comm As New SqlCommand(sql, cnn)

            Dim DA As New SqlDataAdapter(comm)
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub ClasificarABC()
        Try
            Dim wUsarParametros As Boolean = False
            If chkParametros.Checked Then
                wUsarParametros = ValidarParametros()
                If Not wUsarParametros Then
                    Exit Sub
                End If
            End If

            DS.Clear()
            GenerarABC()

            Dim dr As DataRow

            For Each dr In DS.Tables("ABC").Rows
                dr.Item(0) = dr.Item(0) + " " + RetornarClase(dr, wUsarParametros)
            Next

            BindiarGrafico()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function RetornarClase(ByVal myDr As DataRow, ByVal pUsarParametros As Boolean) As String
        Try
            Dim wA As Integer
            Dim wB As Integer
            Dim wC As Integer

            If pUsarParametros Then
                wA = txtA.Text
                wB = txtB.Text
                wC = txtC.Text
            Else
                wA = 75
                wB = 90
                wC = 100
            End If

            Dim wClase As String
            If myDr.Item(1) <= wA Then
                wClase = "A"
            Else
                If myDr.Item(1) > wA And myDr.Item(1) < wB Then
                    wClase = "B"
                Else
                    wClase = "C"
                End If
            End If
            Return wClase
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return ""
        End Try
    End Function

    Private Sub BindiarGrafico()
        Try
            UltraChart1.DataSource = Nothing

            UltraChart1.DataSource = DS.Tables("ABC")

            UltraChart1.Axis.X.Labels.Visible = False

            'UltraChart1.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing

            UltraChart1.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RegistrarClase()
        Try
            Dim dr As DataRow
            DS.Clear()
            GenerarABC()
            Dim wUsarParametros As Boolean = False
            If chkParametros.Checked Then
                wUsarParametros = ValidarParametros()
                If Not wUsarParametros Then
                    Exit Sub
                End If
            End If
            cnn.Open()
            For Each dr In DS.Tables("ABC").Rows
                Dim myClase As String
                myClase = RetornarClase(dr, wUsarParametros)

                Dim cm As New SqlClient.SqlCommand("Update tipomateriaprima set clase='" + myClase + "' where nombre='" + dr.Item(0) + "'")

                cm.Connection = cnn
                cm.ExecuteNonQuery()

            Next
            cnn.Close()
            MessageBox.Show("Se registraron las clases con exito", "Diagrama ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Function ValidarParametros() As Boolean
        If IsNumeric(txtA.Text) And IsNumeric(txtB.Text) And IsNumeric(txtC.Text) Then
            If txtA.Text <= 100 Then
                If txtB.Text <= 100 And Convert.ToInt32(txtB.Text) > Convert.ToInt32(txtA.Text) Then
                    If txtC.Text <= 100 And Convert.ToInt32(txtC.Text) > Convert.ToInt32(txtB.Text) Then
                        Return True
                    End If
                End If
            End If
        End If
        MessageBox.Show("Parametros no validos", "Validacion de Parametros", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Return False
    End Function
#End Region

   
End Class
