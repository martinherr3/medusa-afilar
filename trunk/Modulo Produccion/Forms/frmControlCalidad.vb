Public Class frmControlCalidad
    Inherits System.Windows.Forms.Form
    Dim consulta As String = "select fresa.nroserie,tipofresa.nombre,estado.nombre from fresa,estado,tipofresa where fresa.estado=estado.idestado and fresa.idtipo=tipofresa.idtipo and fresa.idmodelo=tipofresa.idmodelo and estado.nombre='EnControl'"
    Dim adaptadorFresas As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(consulta, cnn)
    Dim dsFresa As New DataSet
    Dim dsCont As New DataSet
    Dim consultaC As String = "select controlcalidad.idcontrol, controlcalidad.medidas, controlcalidad.pintura, controlcalidad.soldadura, controlcalidad.torneado, controlcalidad.idfresa, tipofresa.nombre, estado.nombre,fechahoracontrol from controlcalidad,fresa,estado,tipofresa where controlcalidad.idfresa=fresa.nroserie and fresa.idtipo=tipofresa.idtipo and fresa.idmodelo=tipofresa.idmodelo and fresa.estado=estado.idestado"
    Dim adaptadorCont As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(consultaC, cnn)
    Dim consultaCC As String = "select * from controlcalidad"
    Dim adaptadorCC As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(consultaCC, cnn)

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboTorneado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents comboSoldadura As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboPintura As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboMedidas As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboTorneado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.comboSoldadura = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboPintura = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboMedidas = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboTorneado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboSoldadura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPintura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboMedidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.DataGrid1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(700, 321)
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(592, 288)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton1.TabIndex = 23
        Me.UltraButton1.Text = "&Registrar"
        '
        'UltraGroupBox2
        '
        Appearance1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance1
        Me.UltraGroupBox2.Controls.Add(Me.Label1)
        Me.UltraGroupBox2.Controls.Add(Me.UltraTextEditor1)
        Me.UltraGroupBox2.Controls.Add(Me.Label9)
        Me.UltraGroupBox2.Controls.Add(Me.ComboTorneado)
        Me.UltraGroupBox2.Controls.Add(Me.Label8)
        Me.UltraGroupBox2.Controls.Add(Me.Label7)
        Me.UltraGroupBox2.Controls.Add(Me.Label6)
        Me.UltraGroupBox2.Controls.Add(Me.comboSoldadura)
        Me.UltraGroupBox2.Controls.Add(Me.comboPintura)
        Me.UltraGroupBox2.Controls.Add(Me.comboMedidas)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(384, 40)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(296, 240)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 22
        Me.UltraGroupBox2.Text = "Puntos de Control"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(56, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Observaciones:"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.Location = New System.Drawing.Point(64, 144)
        Me.UltraTextEditor1.MaxLength = 240
        Me.UltraTextEditor1.Multiline = True
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(224, 88)
        Me.UltraTextEditor1.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(56, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Torneado:"
        '
        'ComboTorneado
        '
        ValueListItem1.DataValue = "Aprobado"
        ValueListItem2.DataValue = "Reprobado"
        Me.ComboTorneado.Items.Add(ValueListItem1)
        Me.ComboTorneado.Items.Add(ValueListItem2)
        Me.ComboTorneado.Location = New System.Drawing.Point(120, 104)
        Me.ComboTorneado.Name = "ComboTorneado"
        Me.ComboTorneado.Size = New System.Drawing.Size(168, 21)
        Me.ComboTorneado.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(56, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Soldadura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(72, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Pintura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(64, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Medidas:"
        '
        'comboSoldadura
        '
        Me.comboSoldadura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem3.DataValue = "Aprobado"
        ValueListItem4.DataValue = "Reprobado"
        Me.comboSoldadura.Items.Add(ValueListItem3)
        Me.comboSoldadura.Items.Add(ValueListItem4)
        Me.comboSoldadura.Location = New System.Drawing.Point(120, 80)
        Me.comboSoldadura.Name = "comboSoldadura"
        Me.comboSoldadura.Size = New System.Drawing.Size(168, 21)
        Me.comboSoldadura.TabIndex = 4
        '
        'comboPintura
        '
        Me.comboPintura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem5.DataValue = "Aprobado"
        ValueListItem6.DataValue = "Reprobado"
        Me.comboPintura.Items.Add(ValueListItem5)
        Me.comboPintura.Items.Add(ValueListItem6)
        Me.comboPintura.Location = New System.Drawing.Point(120, 56)
        Me.comboPintura.Name = "comboPintura"
        Me.comboPintura.Size = New System.Drawing.Size(168, 21)
        Me.comboPintura.TabIndex = 3
        '
        'comboMedidas
        '
        Me.comboMedidas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem7.DataValue = "Aprobado"
        ValueListItem8.DataValue = "Reprobado"
        Me.comboMedidas.Items.Add(ValueListItem7)
        Me.comboMedidas.Items.Add(ValueListItem8)
        Me.comboMedidas.Location = New System.Drawing.Point(120, 32)
        Me.comboMedidas.Name = "comboMedidas"
        Me.comboMedidas.Size = New System.Drawing.Size(168, 21)
        Me.comboMedidas.TabIndex = 2
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Fresas en Control"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 40)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(320, 240)
        Me.DataGrid1.TabIndex = 21
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.DataGrid2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(700, 321)
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "Controles Registrados"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(16, 16)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.PreferredColumnWidth = 100
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(672, 240)
        Me.DataGrid2.TabIndex = 22
        '
        'UltraTabControl1
        '
        Appearance2.BackColor = System.Drawing.Color.Silver
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UltraTabControl1.ActiveTabAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.Silver
        Me.UltraTabControl1.Appearance = Appearance3
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UltraTabControl1.ClientAreaAppearance = Appearance4
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(704, 344)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Calidad en Fresas"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Controles Realizados"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(700, 321)
        '
        'frmControlCalidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 352)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(200, 105)
        Me.Name = "frmControlCalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar Control de Calidad"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboTorneado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboSoldadura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPintura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboMedidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmControlCalidad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub


    Private Sub frmControlCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        adaptadorFresas.Fill(dsFresa, "Fresa")
        DataGrid1.DataSource = dsFresa
        DataGrid1.DataMember = "Fresa"

        Dim nombrescol(3) As String
        nombrescol(0) = "Numero Serie"
        nombrescol(1) = "Tipo de Fresa"
        nombrescol(2) = "Estado"

        Dim anchosgrid(3) As Integer
        anchosgrid(0) = 80
        anchosgrid(1) = 100
        anchosgrid(2) = 100
        ' esta funcion da solo formato a la grilla no la carga, de eso se encarga el datasource
        cargarGrilla(DataGrid1, dsFresa.Tables.Item(0), nombrescol, anchosgrid)

        adaptadorCont.Fill(dsCont)
        DataGrid2.DataSource = dsCont.Tables.Item(0)

        Dim nombrescolum(9) As String

        nombrescolum(0) = "Nro de Control"
        nombrescolum(1) = "Medidas"
        nombrescolum(2) = "Pintura"
        nombrescolum(3) = "Soldadura"
        nombrescolum(4) = "Torneado"
        nombrescolum(5) = "Nro de fresa"
        nombrescolum(6) = "Nombre de Fresa"
        nombrescolum(7) = "Estado Actual"
        nombrescolum(8) = "Fecha/Hora"

        Dim anchosgrilla(9) As Integer
        anchosgrilla(0) = 80
        anchosgrilla(1) = 70
        anchosgrilla(2) = 70
        anchosgrilla(3) = 70
        anchosgrilla(4) = 70
        anchosgrilla(5) = 60
        anchosgrilla(6) = 80
        anchosgrilla(7) = 80
        anchosgrilla(8) = 120
        cargarGrilla(DataGrid2, dsCont.Tables.Item(0), nombrescolum, anchosgrilla)

    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If comboMedidas.SelectedIndex = -1 Or comboPintura.SelectedIndex = -1 Or _
        comboSoldadura.SelectedIndex = -1 Or ComboTorneado.SelectedIndex = -1 Then
            MessageBox.Show("Falta seleccionar parametros de control", "Control", MessageBoxButtons.OK)
            Exit Sub
        End If
        'Dim dsCC As New DataSet
        'adaptadorCC.Fill(dsCont, "controlcalidad")
        Dim tbCC As DataTable = dsCont.Tables.Item(0)
        Dim maximoreg() As DataRow
        Dim maximo As Integer
        maximoreg = tbCC.Select("idcontrol=max(idcontrol)")
        maximo = CType(maximoreg(0).Item(0), Integer) + 1

        Dim nuevafila As DataRow
        Try
            nuevafila = tbCC.NewRow()
            nuevafila(0) = maximo
            nuevafila(1) = comboMedidas.Text
            nuevafila(2) = comboPintura.Text
            nuevafila(3) = comboSoldadura.Text
            nuevafila(4) = ComboTorneado.Text
            nuevafila(5) = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
            nuevafila(6) = DataGrid1.Item(DataGrid1.CurrentRowIndex, 1)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Open()
        adaptadorCC.InsertCommand = New SqlClient.SqlCommand("INSERT INTO controlcalidad VALUES(" & maximo & ",'" & UltraTextEditor1.Text & "','" & comboMedidas.Text & "','" & comboPintura.Text & "','" & comboSoldadura.Text & "','" & ComboTorneado.Text & "'," & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & ",'" & Now & "')", cnn)
        adaptadorCC.InsertCommand.ExecuteNonQuery()


        If comboMedidas.Text = "Aprobado" And comboPintura.Text = "Aprobado" And _
        comboSoldadura.Text = "Aprobado" And ComboTorneado.Text = "Aprobado" Then
            adaptadorFresas.UpdateCommand = New SqlClient.SqlCommand("UPDATE fresa SET estado=2 WHERE nroserie=" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), cnn)
            nuevafila(7) = "Finalizado"
        Else
            adaptadorFresas.UpdateCommand = New SqlClient.SqlCommand("UPDATE fresa SET estado=6 WHERE nroserie=" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), cnn)
            nuevafila(7) = "Rechazado"
        End If
        nuevafila(8) = Now
        tbCC.Rows.Add(nuevafila)
        'dsCont.Tables.Item(0).Rows.Add(nuevafila)
        adaptadorFresas.UpdateCommand.ExecuteNonQuery()
        DataGrid2.Refresh()
        DataGrid1.Refresh()
        cnn.Close()
        MessageBox.Show("Registro y cambio de Estado realizado", "Registro de Control", MessageBoxButtons.OK)
        Dim tbf As DataTable = dsFresa.Tables.Item(0)
        For i As Integer = 0 To tbf.Rows.Count - 1
            If tbf.Rows(i)(0) = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) Then
                tbf.Rows(i).Delete()

                comboMedidas.SelectedIndex = -1
                comboPintura.SelectedIndex = -1
                comboSoldadura.SelectedIndex = -1
                ComboTorneado.SelectedIndex = -1
                UltraTextEditor1.Text = ""
                Me.Close()    ' si no uso el Me.Close() en el proximo control a 
                Exit Sub      ' registrar me tira error, bien no se porque
            End If
        Next
    End Sub
End Class
