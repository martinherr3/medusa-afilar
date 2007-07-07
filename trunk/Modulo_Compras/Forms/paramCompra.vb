Imports System.Data.SqlClient

Public Class paramCompra
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
    Friend WithEvents grd1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textbox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textbox3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textbox2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grd1 = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.textbox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textbox3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textbox2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.textbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd1
        '
        Me.grd1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grd1.CaptionText = "Seleccione  materia prima"
        Me.grd1.DataMember = ""
        Me.grd1.FlatMode = True
        Me.grd1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd1.Location = New System.Drawing.Point(16, 16)
        Me.grd1.Name = "grd1"
        Me.grd1.ReadOnly = True
        Me.grd1.Size = New System.Drawing.Size(360, 176)
        Me.grd1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tamaño del lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tiempo entre pedidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Proximo pedido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(400, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 88)
        Me.GroupBox1.SupportThemes = False
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.Text = "Parametros de compra"
        Me.GroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(168, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(168, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tiempo promedio de entrega:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Demanda del ultimo año:"
        '
        'textbox1
        '
        Me.textbox1.Location = New System.Drawing.Point(144, 208)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(80, 21)
        Me.textbox1.TabIndex = 14
        '
        'textbox3
        '
        Me.textbox3.Location = New System.Drawing.Point(144, 256)
        Me.textbox3.Name = "textbox3"
        Me.textbox3.Size = New System.Drawing.Size(80, 21)
        Me.textbox3.TabIndex = 15
        '
        'textbox2
        '
        Me.textbox2.Location = New System.Drawing.Point(144, 232)
        Me.textbox2.Name = "textbox2"
        Me.textbox2.Size = New System.Drawing.Size(80, 21)
        Me.textbox2.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Unidades"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Años"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Dias"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(400, 64)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(136, 24)
        Me.UltraButton1.TabIndex = 20
        Me.UltraButton1.Text = "Calcular parámetros"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(448, 248)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton2.TabIndex = 21
        Me.UltraButton2.Text = "Grabar datos"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(544, 248)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton3.TabIndex = 22
        Me.UltraButton3.Text = "Salir"
        '
        'paramCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 288)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textbox2)
        Me.Controls.Add(Me.textbox3)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "paramCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calcular parametros de compra"
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.textbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textbox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim connect As New coneccion

        princ.barra.agregarBoton(Me)

        Dim conn As SqlConnection
        conn = cnn

        'conn = connect.conneccion
        conn.Open()

        Dim sql As String = "SELECT idtipomateriaprima, nombre, stockactual, loteeconomico FROM tipomateriaprima"
        Dim comm As New SqlCommand(sql, conn)

        Dim DA As New SqlDataAdapter(comm)
        Dim DS As New DataSet
        DA.Fill(DS)

        grd1.DataSource = DS.Tables.Item(0)
        conn.Close()

    End Sub

    Private Sub grd1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.CurrentCellChanged
        grd1.Select(grd1.CurrentRowIndex())
    End Sub



    Private Sub paramCompra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()

    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Me.Close()
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        'Dim connect As New coneccion

        Dim conn As SqlConnection
        conn = cnn

        'conn = connect.conneccion
        conn.Open()

        Dim sql As New SqlClient.SqlCommand
        sql.CommandType = CommandType.Text
        sql.CommandText = "UPDATE tipomateriaprima SET loteeconomico = " & Val(textbox1.Text) & _
            "WHERE idtipomateriaprima = " & grd1.Item(grd1.CurrentRowIndex, 0)

        sql.Connection = conn
        sql.ExecuteNonQuery()

        Dim sql2 As String = "SELECT idtipomateriaprima, nombre, stockactual, loteeconomico FROM tipomateriaprima"
        Dim comm As New SqlCommand(sql2, conn)

        Dim DA As New SqlDataAdapter(comm)
        Dim DS As New DataSet
        DA.Fill(DS)

        grd1.DataSource = DS.Tables.Item(0)
        conn.Close()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click


        'Dim connect As New coneccion
        Dim conn As SqlConnection
        conn = cnn
        Dim sql1 As String
        Dim sql2 As String

        sql1 = " select count(*) " & _
            "from fresa F, tipoFresa T, tipoparte P, parte PxT, tipomateriaprima TMP, MPxTP MxT " & _
            "where F.nroserie = T.idtipo and T.idtipo=PxT.idtipofresa and T.idmodelo = PxT.idmodelo and PxT.nombre =P.nombre and " & _
            "MxT.idmp = TMP.idtipomateriaprima And MxT.nombre = P.nombre and F.fechafinfabricacion " & _
            "between DateAdd(Year, -1, getdate()) And getdate() And TMP.idtipomateriaprima = " & grd1.Item(grd1.CurrentRowIndex, 0) & _
            "group by TMP.idtipomateriaprima "

        sql2 = "SELECT sum(datediff(day, OC.fecharealizacion, MPR.fecharecepcion))/ count(datediff(day, OC.fecharealizacion, MPR.fecharecepcion)) " & _
            "FROM ordencompramp OC, mprecibida MPR " & _
            "WHERE OC.idordencompra = MPR.idordencompramp"

        'conn = connect.conneccion
        conn.Open()

        Dim Comm As New SqlCommand(sql1, conn)
        Dim DReader As SqlDataReader = Comm.ExecuteReader()

        While DReader.Read()
            If DReader.Item(0) = 1 Then
                Label7.Text = DReader.Item(0) & " unidad"
            Else
                Label7.Text = DReader.Item(0) & " unidades"
            End If
        End While
        DReader.Close()

        Comm = New SqlCommand(sql2, conn)
        Dim DReader2 As SqlDataReader = Comm.ExecuteReader(CommandBehavior.CloseConnection)

        While DReader2.Read()
            Label8.Text = DReader2.Item(0) & " dias"
        End While
        DReader2.Close()

        GroupBox1.Text = "Parametros de: " & grd1.Item(grd1.CurrentRowIndex, 1)

        ' conn.Close()

        Dim q As Decimal  'tamaño del lote
        Dim cp As Decimal 'costo por pedido
        Dim cs As Decimal 'costo de stock
        Dim t As Decimal  'periodo de analisis
        Dim n As Decimal  'demanda en el periodo

        cp = 10
        cs = 3
        t = 1
        n = CInt(Val(Label7.Text))
        q = Math.Round(Math.Sqrt((2 * cp * n) / (cs * t)), 2)
        textbox1.Text = q
        If Not n = 0 Then
            textbox2.Text = (t * q) / n
        End If

        If Not Val(Label7.Text) = 0 Then
            textbox3.Text = (grd1.Item(grd1.CurrentRowIndex, 2) / (Val(Label7.Text) / 360))
        End If
    End Sub
End Class


