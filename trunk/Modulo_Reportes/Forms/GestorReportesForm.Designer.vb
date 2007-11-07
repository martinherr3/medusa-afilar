<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestorReportesForm
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
        Me.btnPedido = New Infragistics.Win.Misc.UltraButton
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.checkPedidoEstado = New System.Windows.Forms.CheckBox
        Me.checkPedidoPrioridad = New System.Windows.Forms.CheckBox
        Me.checkPedidoCliente = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.comboPedidoCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboPedidoPrioridad = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboPedidoEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.tabReportes = New System.Windows.Forms.TabControl
        Me.tabPedidos = New System.Windows.Forms.TabPage
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.checkPedidoFecha = New System.Windows.Forms.CheckBox
        Me.pedidoHasta = New System.Windows.Forms.DateTimePicker
        Me.pedidoDesde = New System.Windows.Forms.DateTimePicker
        Me.tabFresas = New System.Windows.Forms.TabPage
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.btnFresas = New Infragistics.Win.Misc.UltraButton
        Me.tabCliente = New System.Windows.Forms.TabPage
        Me.btnCliente = New Infragistics.Win.Misc.UltraButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.UltraComboEditor1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.UltraComboEditor2 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.UltraComboEditor3 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.UltraComboEditor4 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tabServicios = New System.Windows.Forms.TabPage
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportes.SuspendLayout()
        Me.tabPedidos.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.tabFresas.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.tabCliente.SuspendLayout()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPedido
        '
        Me.btnPedido.Location = New System.Drawing.Point(424, 102)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(72, 21)
        Me.btnPedido.TabIndex = 39
        Me.btnPedido.Text = "Ejecutar"
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Location = New System.Drawing.Point(12, 175)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(790, 373)
        Me.crv.TabIndex = 40
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'checkPedidoEstado
        '
        Me.checkPedidoEstado.AutoSize = True
        Me.checkPedidoEstado.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoEstado.Location = New System.Drawing.Point(643, 78)
        Me.checkPedidoEstado.Name = "checkPedidoEstado"
        Me.checkPedidoEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoEstado.TabIndex = 52
        Me.checkPedidoEstado.Text = "Activar"
        Me.checkPedidoEstado.UseVisualStyleBackColor = False
        '
        'checkPedidoPrioridad
        '
        Me.checkPedidoPrioridad.AutoSize = True
        Me.checkPedidoPrioridad.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoPrioridad.Location = New System.Drawing.Point(643, 56)
        Me.checkPedidoPrioridad.Name = "checkPedidoPrioridad"
        Me.checkPedidoPrioridad.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoPrioridad.TabIndex = 51
        Me.checkPedidoPrioridad.Text = "Activar"
        Me.checkPedidoPrioridad.UseVisualStyleBackColor = False
        '
        'checkPedidoCliente
        '
        Me.checkPedidoCliente.AutoSize = True
        Me.checkPedidoCliente.BackColor = System.Drawing.SystemColors.Control
        Me.checkPedidoCliente.Location = New System.Drawing.Point(643, 34)
        Me.checkPedidoCliente.Name = "checkPedidoCliente"
        Me.checkPedidoCliente.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoCliente.TabIndex = 50
        Me.checkPedidoCliente.Text = "Activar"
        Me.checkPedidoCliente.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(378, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(370, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Prioridad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(379, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Cliente"
        '
        'comboPedidoCliente
        '
        Me.comboPedidoCliente.AutoSize = True
        Me.comboPedidoCliente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoCliente.Location = New System.Drawing.Point(424, 31)
        Me.comboPedidoCliente.Name = "comboPedidoCliente"
        Me.comboPedidoCliente.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoCliente.TabIndex = 53
        '
        'comboPedidoPrioridad
        '
        Me.comboPedidoPrioridad.AutoSize = True
        Me.comboPedidoPrioridad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoPrioridad.Location = New System.Drawing.Point(424, 53)
        Me.comboPedidoPrioridad.Name = "comboPedidoPrioridad"
        Me.comboPedidoPrioridad.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoPrioridad.TabIndex = 54
        '
        'comboPedidoEstado
        '
        Me.comboPedidoEstado.AutoSize = True
        Me.comboPedidoEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboPedidoEstado.Location = New System.Drawing.Point(424, 75)
        Me.comboPedidoEstado.Name = "comboPedidoEstado"
        Me.comboPedidoEstado.Size = New System.Drawing.Size(205, 21)
        Me.comboPedidoEstado.TabIndex = 55
        '
        'tabReportes
        '
        Me.tabReportes.Controls.Add(Me.tabPedidos)
        Me.tabReportes.Controls.Add(Me.tabFresas)
        Me.tabReportes.Controls.Add(Me.tabCliente)
        Me.tabReportes.Controls.Add(Me.tabServicios)
        Me.tabReportes.Location = New System.Drawing.Point(12, 12)
        Me.tabReportes.Name = "tabReportes"
        Me.tabReportes.SelectedIndex = 0
        Me.tabReportes.Size = New System.Drawing.Size(790, 157)
        Me.tabReportes.TabIndex = 56
        '
        'tabPedidos
        '
        Me.tabPedidos.Controls.Add(Me.comboPedidoEstado)
        Me.tabPedidos.Controls.Add(Me.UltraGroupBox1)
        Me.tabPedidos.Controls.Add(Me.comboPedidoPrioridad)
        Me.tabPedidos.Controls.Add(Me.Label2)
        Me.tabPedidos.Controls.Add(Me.comboPedidoCliente)
        Me.tabPedidos.Controls.Add(Me.Label3)
        Me.tabPedidos.Controls.Add(Me.checkPedidoEstado)
        Me.tabPedidos.Controls.Add(Me.btnPedido)
        Me.tabPedidos.Controls.Add(Me.checkPedidoPrioridad)
        Me.tabPedidos.Controls.Add(Me.Label4)
        Me.tabPedidos.Controls.Add(Me.checkPedidoCliente)
        Me.tabPedidos.Location = New System.Drawing.Point(4, 22)
        Me.tabPedidos.Name = "tabPedidos"
        Me.tabPedidos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPedidos.Size = New System.Drawing.Size(782, 131)
        Me.tabPedidos.TabIndex = 0
        Me.tabPedidos.Text = "Pedidos"
        Me.tabPedidos.UseVisualStyleBackColor = True
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.checkPedidoFecha)
        Me.UltraGroupBox1.Controls.Add(Me.pedidoHasta)
        Me.UltraGroupBox1.Controls.Add(Me.pedidoDesde)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(54, 9)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(223, 95)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 43
        Me.UltraGroupBox1.Text = "Fecha entrega"
        '
        'checkPedidoFecha
        '
        Me.checkPedidoFecha.AutoSize = True
        Me.checkPedidoFecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkPedidoFecha.Location = New System.Drawing.Point(6, 70)
        Me.checkPedidoFecha.Name = "checkPedidoFecha"
        Me.checkPedidoFecha.Size = New System.Drawing.Size(59, 17)
        Me.checkPedidoFecha.TabIndex = 43
        Me.checkPedidoFecha.Text = "Activar"
        Me.checkPedidoFecha.UseVisualStyleBackColor = False
        '
        'pedidoHasta
        '
        Me.pedidoHasta.Location = New System.Drawing.Point(6, 42)
        Me.pedidoHasta.Name = "pedidoHasta"
        Me.pedidoHasta.Size = New System.Drawing.Size(203, 20)
        Me.pedidoHasta.TabIndex = 42
        '
        'pedidoDesde
        '
        Me.pedidoDesde.Location = New System.Drawing.Point(6, 20)
        Me.pedidoDesde.Name = "pedidoDesde"
        Me.pedidoDesde.Size = New System.Drawing.Size(203, 20)
        Me.pedidoDesde.TabIndex = 41
        '
        'tabFresas
        '
        Me.tabFresas.Controls.Add(Me.Label5)
        Me.tabFresas.Controls.Add(Me.UltraComboEditor2)
        Me.tabFresas.Controls.Add(Me.CheckBox4)
        Me.tabFresas.Controls.Add(Me.UltraComboEditor1)
        Me.tabFresas.Controls.Add(Me.CheckBox3)
        Me.tabFresas.Controls.Add(Me.Label1)
        Me.tabFresas.Controls.Add(Me.UltraGroupBox2)
        Me.tabFresas.Controls.Add(Me.btnFresas)
        Me.tabFresas.Location = New System.Drawing.Point(4, 22)
        Me.tabFresas.Name = "tabFresas"
        Me.tabFresas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFresas.Size = New System.Drawing.Size(782, 131)
        Me.tabFresas.TabIndex = 1
        Me.tabFresas.Text = "Pedidos Fresa"
        Me.tabFresas.UseVisualStyleBackColor = True
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.CheckBox2)
        Me.UltraGroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.UltraGroupBox2.Controls.Add(Me.DateTimePicker4)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(53, 11)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(223, 95)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 44
        Me.UltraGroupBox2.Text = "Fecha fin fabricacion"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox2.Location = New System.Drawing.Point(6, 70)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox2.TabIndex = 43
        Me.CheckBox2.Text = "Activar"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(6, 42)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker3.TabIndex = 42
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(6, 20)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker4.TabIndex = 41
        '
        'btnFresas
        '
        Me.btnFresas.Location = New System.Drawing.Point(418, 85)
        Me.btnFresas.Name = "btnFresas"
        Me.btnFresas.Size = New System.Drawing.Size(72, 21)
        Me.btnFresas.TabIndex = 41
        Me.btnFresas.Text = "Ejecutar"
        '
        'tabCliente
        '
        Me.tabCliente.Controls.Add(Me.Label6)
        Me.tabCliente.Controls.Add(Me.UltraComboEditor3)
        Me.tabCliente.Controls.Add(Me.CheckBox5)
        Me.tabCliente.Controls.Add(Me.UltraComboEditor4)
        Me.tabCliente.Controls.Add(Me.CheckBox6)
        Me.tabCliente.Controls.Add(Me.Label7)
        Me.tabCliente.Controls.Add(Me.btnCliente)
        Me.tabCliente.Location = New System.Drawing.Point(4, 22)
        Me.tabCliente.Name = "tabCliente"
        Me.tabCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCliente.Size = New System.Drawing.Size(782, 131)
        Me.tabCliente.TabIndex = 2
        Me.tabCliente.Text = "Clientes"
        Me.tabCliente.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(77, 88)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(72, 21)
        Me.btnCliente.TabIndex = 40
        Me.btnCliente.Text = "Ejecutar"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(6, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Activar"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker1.TabIndex = 42
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 20)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'UltraComboEditor1
        '
        Me.UltraComboEditor1.AutoSize = True
        Me.UltraComboEditor1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.UltraComboEditor1.Location = New System.Drawing.Point(418, 39)
        Me.UltraComboEditor1.Name = "UltraComboEditor1"
        Me.UltraComboEditor1.Size = New System.Drawing.Size(205, 21)
        Me.UltraComboEditor1.TabIndex = 58
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox3.Location = New System.Drawing.Point(637, 39)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox3.TabIndex = 57
        Me.CheckBox3.Text = "Activar"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(373, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(373, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Modelo"
        '
        'UltraComboEditor2
        '
        Me.UltraComboEditor2.AutoSize = True
        Me.UltraComboEditor2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.UltraComboEditor2.Location = New System.Drawing.Point(418, 61)
        Me.UltraComboEditor2.Name = "UltraComboEditor2"
        Me.UltraComboEditor2.Size = New System.Drawing.Size(205, 21)
        Me.UltraComboEditor2.TabIndex = 61
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox4.Location = New System.Drawing.Point(637, 66)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox4.TabIndex = 60
        Me.CheckBox4.Text = "Activar"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(23, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Provincia"
        '
        'UltraComboEditor3
        '
        Me.UltraComboEditor3.AutoSize = True
        Me.UltraComboEditor3.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.UltraComboEditor3.Location = New System.Drawing.Point(77, 48)
        Me.UltraComboEditor3.Name = "UltraComboEditor3"
        Me.UltraComboEditor3.Size = New System.Drawing.Size(205, 21)
        Me.UltraComboEditor3.TabIndex = 67
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox5.Location = New System.Drawing.Point(296, 53)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox5.TabIndex = 66
        Me.CheckBox5.Text = "Activar"
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'UltraComboEditor4
        '
        Me.UltraComboEditor4.AutoSize = True
        Me.UltraComboEditor4.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.UltraComboEditor4.Location = New System.Drawing.Point(77, 26)
        Me.UltraComboEditor4.Name = "UltraComboEditor4"
        Me.UltraComboEditor4.Size = New System.Drawing.Size(205, 21)
        Me.UltraComboEditor4.TabIndex = 64
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox6.Location = New System.Drawing.Point(296, 26)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox6.TabIndex = 63
        Me.CheckBox6.Text = "Activar"
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(21, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Localidad"
        '
        'tabServicios
        '
        Me.tabServicios.Location = New System.Drawing.Point(4, 22)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServicios.Size = New System.Drawing.Size(782, 131)
        Me.tabServicios.TabIndex = 3
        Me.tabServicios.Text = "Servicios"
        Me.tabServicios.UseVisualStyleBackColor = True
        '
        'GestorReportesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 560)
        Me.Controls.Add(Me.tabReportes)
        Me.Controls.Add(Me.crv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "GestorReportesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestor de Reportes"
        CType(Me.comboPedidoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPedidoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportes.ResumeLayout(False)
        Me.tabPedidos.ResumeLayout(False)
        Me.tabPedidos.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.tabFresas.ResumeLayout(False)
        Me.tabFresas.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        Me.tabCliente.ResumeLayout(False)
        Me.tabCliente.PerformLayout()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPedido As Infragistics.Win.Misc.UltraButton
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents checkPedidoEstado As System.Windows.Forms.CheckBox
    Friend WithEvents checkPedidoPrioridad As System.Windows.Forms.CheckBox
    Friend WithEvents checkPedidoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboPedidoEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboPedidoPrioridad As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboPedidoCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents tabReportes As System.Windows.Forms.TabControl
    Friend WithEvents tabPedidos As System.Windows.Forms.TabPage
    Friend WithEvents tabFresas As System.Windows.Forms.TabPage
    Friend WithEvents tabCliente As System.Windows.Forms.TabPage
    Friend WithEvents btnCliente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnFresas As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents checkPedidoFecha As System.Windows.Forms.CheckBox
    Friend WithEvents pedidoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents pedidoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UltraComboEditor2 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents UltraComboEditor1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UltraComboEditor3 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents UltraComboEditor4 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabServicios As System.Windows.Forms.TabPage
End Class
