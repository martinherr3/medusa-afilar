Imports Infragistics.UltraChart.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic


Public Class ProdNuevo
    Inherits System.Windows.Forms.Form

    Const ESTADO_PENDIENTE As Integer = 8

    Dim conn As New SqlConnection("workstation id=athlon;packet size=4096;integrated security=SSPI;initial catalog=Afilar;persist security info=False")
    Dim DS As DataSet
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents GanttChart1 As Afilar.GanttChart
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
  Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
  Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
  Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProdNuevo))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Button1 = New System.Windows.Forms.Button
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.grd2 = New System.Windows.Forms.DataGrid
        Me.grd1 = New System.Windows.Forms.DataGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GanttChart1 = New Afilar.GanttChart
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Button1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.grd2)
        Me.UltraTabPageControl1.Controls.Add(Me.grd1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(756, 542)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.UltraTabPageControl2.Controls.Add(Me.GanttChart1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(756, 542)
        '
        'GanttChart1
        '
        Me.GanttChart1.BackColor = System.Drawing.Color.White
        Me.GanttChart1.DateFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart1.FromDate = New Date(CType(0, Long))
        Me.GanttChart1.Location = New System.Drawing.Point(12, 71)
        Me.GanttChart1.Name = "GanttChart1"
        Me.GanttChart1.RowFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart1.Size = New System.Drawing.Size(724, 352)
        Me.GanttChart1.TabIndex = 7
        Me.GanttChart1.Text = "GanttChart1"
        Me.GanttChart1.TimeFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart1.ToDate = New Date(CType(0, Long))
        Me.GanttChart1.ToolTipText = CType(resources.GetObject("GanttChart1.ToolTipText"), System.Collections.Generic.List(Of String))
        Me.GanttChart1.ToolTipTextTitle = ""
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
        'UltraTabControl1
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance1.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance2
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 3)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance3.BackColor = System.Drawing.Color.Silver
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UltraTabControl1.SelectedTabAppearance = Appearance3
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
        'ProdNuevo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 563)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "ProdNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Programar produccion"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '    princ.barra.agregarBoton(Me)

    conn.Open()

        Dim sql As String = "select P.idpedido, P.fechaRealizacion, E.nombre, P.prioridad, C.nombre " & _
            "from pedido P, estado E, cliente C " & _
            "where P.idestado=E.idestado AND P.idcliente = C.idcliente and P.idestado = " & Estado.PEDIDO_PENDIENTE

    Dim comm As New SqlCommand(sql, conn)
    Dim DA As New SqlDataAdapter(comm)

    DS = New DataSet
    DA.Fill(DS, "pedidos")

    grd1.DataSource = DS.Tables.Item("pedidos")

    'comm.CommandText = "select F.nropedido, F.nroserie, F.fechafinfabricacion, TF.nombre, E.nombre from fresa F, " & _
    '    "estado E, tipofresa TF where F.estado = E.idestado AND F.idtipofresa=TF.idtipo"

        comm.CommandText = "select F.nropedido, F.nroserie, F.fechafinfabricacion, TF.nombre, E.nombre from fresa F, " & _
            "estado E, tipofresa TF where F.estado = E.idestado AND F.idtipo = TF.idtipo And F.idmodelo = TF.idmodelo And F.Estado = " & 1 'Estado.FRESA_PENDIENTE




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

  Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click

    Dim i As Integer
    Dim tarea As New tareasProd
    Dim maquina As New MaquinaProd
    Dim tareasCollection As New Collection
    Dim maquinaCollection As New Collection
    Dim programador As New programador
    Dim fresasCollection As New Collection

    ''colores para el grafico
    Dim colores(14) As Color
    colores(0) = Color.Blue
    colores(1) = Color.Green
    colores(2) = Color.Gold
    colores(3) = Color.Brown
    colores(4) = Color.Navy
    colores(5) = Color.Honeydew
    colores(6) = Color.Crimson
    colores(7) = Color.Yellow
    colores(8) = Color.Sienna
    colores(9) = Color.OldLace
    colores(10) = Color.PeachPuff
    colores(11) = Color.DeepPink
    colores(12) = Color.DarkMagenta
    colores(13) = Color.Cornsilk


    Dim DS As New DataSet

    If grd2.DataSource.count > 0 Then
      For i = 0 To grd2.DataSource.count - 1
        tarea.idFresa = grd2.Item(i, 1) ' nroserie
        DS.Merge(tarea.getDSByIdfresa())
        ''negrada --> cambiar''
        Dim fresa As New fresaProd
        fresa.id_fresa = grd2.Item(i, 1)
        fresa.lastOperacion = 0
        ''
        fresa.colorGrafico = colores(i)
        ''
        fresasCollection.Add(fresa)
      Next
    Else
      MsgBox("Debe programar al menos una tarea")
      Exit Sub
    End If

    For Each row As DataRow In DS.Tables.Item(0).Rows
      tareasCollection.Add(New tareasProd(row.Item("nroserie"), row.Item("idetapafabricacion"), row.Item("nombre"), row.Item("maquina"), row.Item("duracionpromedio"), row.Item("orden"), "fresa")) 'Por ahora son todos del tipo fresa

      Debug.WriteLine("--> TAREAS <-- nroserie: " & row.Item("nroserie") & " - orden: " & row.Item("orden") & " - maquina " & row.Item("maquina") & " - duracion: " & row.Item("duracionpromedio"))


    Next

    ''grd3.DataSource = DS.Tables.Item(0)

    maquinaCollection = maquina.getCustom("SELECT * FROM maquina")

    ''----< debug >----
    For Each maqu As MaquinaProd In maquinaCollection
      Debug.WriteLine("--> MAQUINAS <-- id " & maqu.idMaquina & " - tipo " & maqu.tipo & " - nombre " & maqu.nombre)
    Next

    programador.maquinas = maquinaCollection
    programador.tareas = tareasCollection
    programador.fresas = fresasCollection

    ''''''programador.horaInicioGeneral 


    programador.Programar()


    Dim colProgramados As New Collection
    Dim minimo As DateTime
    Dim maximo As DateTime
    Dim b As Boolean = False

    Dim maqIndice As Integer = 0


    Dim colorFresa As Color

    For Each maq As MaquinaProd In programador.maquinas
      For Each tar As tareasProd In maq.tareas

        If Not b Then
          b = True
          minimo = tar.inicio
          maximo = tar.inicio.AddMinutes(tar.duracion)
        ElseIf tar.inicio < minimo Then
          minimo = tar.inicio
        ElseIf tar.inicio.AddMinutes(tar.duracion) > maximo Then
          maximo = tar.inicio.AddMinutes(tar.duracion)
        End If


        'get color
        For Each fre As fresaProd In programador.fresas
          If tar.idFresa = -1 Then
            colorFresa = Color.Black
          ElseIf fre.id_fresa = tar.idFresa Then
            colorFresa = fre.colorGrafico
          End If
        Next

        colProgramados.Add(New BarInformation(maq.nombre, tar.inicio, tar.fin, colorFresa, Color.Bisque, maqIndice,tar.idFresa))

      Next
      maqIndice += 1
    Next

    GanttChart1.FromDate = minimo
    GanttChart1.ToDate = maximo

    For Each bar As BarInformation In colProgramados
      GanttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index)
    Next

    'System.Diagnostics.Debug.WriteLine("Duracion: " & tar.duracion)

  End Sub

  Private Sub GanttChart1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GanttChart1.MouseMove
    With GanttChart1
      Dim toolTipText As New List(Of String)

      If .MouseOverRowText.Length > 0 Then
        Dim val As BarInformation = CType(.MouseOverRowValue, BarInformation)
        toolTipText.Add("[b]Date:")
        toolTipText.Add("From ")
        toolTipText.Add(val.FromTime.ToLongDateString & " - " & val.FromTime.ToString("HH:mm"))
        toolTipText.Add("To ")
        toolTipText.Add(val.ToTime.ToLongDateString & " - " & val.ToTime.ToString("HH:mm"))
        toolTipText.Add("[b]Fresa Nro:" & val.nroFresa)
      Else
        toolTipText.Add("")
      End If

      .ToolTipTextTitle = .MouseOverRowText
      .ToolTipText = toolTipText

    End With
  End Sub




    End Class

