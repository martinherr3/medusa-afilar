Public Class abmMatTrab
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim adaptador As New SqlClient.SqlDataAdapter
    Dim SqlDeleteCommand1 As New SqlClient.SqlCommand
    Dim SqlInsertCommand1 As New SqlClient.SqlCommand
    Dim SqlSelectCommand1 As New SqlClient.SqlCommand
    Dim SqlUpdateCommand1 As New SqlClient.SqlCommand
    Dim tabla As String


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
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmMatTrab))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraButton1
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButton1.Appearance = Appearance1
        Me.UltraButton1.Location = New System.Drawing.Point(299, 240)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(78, 26)
        Me.UltraButton1.TabIndex = 7
        Me.UltraButton1.Text = "&Salir"
        '
        'UltraButton3
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButton3.Appearance = Appearance2
        Me.UltraButton3.Location = New System.Drawing.Point(101, 213)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(78, 26)
        Me.UltraButton3.TabIndex = 6
        Me.UltraButton3.Text = "&Guardar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripción"
        '
        'UltraTextEditor2
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Me.UltraTextEditor2.Appearance = Appearance3
        Me.UltraTextEditor2.AutoSize = True
        Me.UltraTextEditor2.Location = New System.Drawing.Point(80, 48)
        Me.UltraTextEditor2.Multiline = True
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.ReadOnly = True
        Me.UltraTextEditor2.Size = New System.Drawing.Size(296, 88)
        Me.UltraTextEditor2.TabIndex = 1
        '
        'UltraButton4
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton4.Appearance = Appearance4
        Me.UltraButton4.Location = New System.Drawing.Point(48, 24)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton4.TabIndex = 1
        '
        'UltraButton5
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton5.Appearance = Appearance5
        Me.UltraButton5.Location = New System.Drawing.Point(8, 24)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton5.TabIndex = 0
        '
        'UltraButton6
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton6.Appearance = Appearance6
        Me.UltraButton6.Location = New System.Drawing.Point(136, 24)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton6.TabIndex = 2
        '
        'UltraButton7
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton7.Appearance = Appearance7
        Me.UltraButton7.Location = New System.Drawing.Point(176, 24)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton7.TabIndex = 3
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton5)
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(80, 142)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(224, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(93, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 2
        '
        'UltraButton8
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.UltraButton8.Appearance = Appearance8
        Me.UltraButton8.Location = New System.Drawing.Point(101, 240)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(78, 26)
        Me.UltraButton8.TabIndex = 5
        Me.UltraButton8.Text = "&Modificar"
        '
        'UltraTextEditor1
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Me.UltraTextEditor1.Appearance = Appearance9
        Me.UltraTextEditor1.AutoSize = True
        Me.UltraTextEditor1.Location = New System.Drawing.Point(80, 16)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.ReadOnly = True
        Me.UltraTextEditor1.Size = New System.Drawing.Size(296, 21)
        Me.UltraTextEditor1.TabIndex = 0
        '
        'UltraButton9
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.UltraButton9.Appearance = Appearance10
        Me.UltraButton9.Location = New System.Drawing.Point(19, 213)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(80, 26)
        Me.UltraButton9.TabIndex = 4
        Me.UltraButton9.Text = "&Nuevo"
        '
        'UltraButton2
        '
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        Me.UltraButton2.Appearance = Appearance11
        Me.UltraButton2.Location = New System.Drawing.Point(19, 240)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(80, 26)
        Me.UltraButton2.TabIndex = 3
        Me.UltraButton2.Text = "&Eliminar"
        '
        'abmMatTrab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(389, 278)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton9)
        Me.Controls.Add(Me.UltraTextEditor1)
        Me.Controls.Add(Me.UltraButton8)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraTextEditor2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.UltraButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(200, 106)
        Me.MaximizeBox = False
        Me.Name = "abmMatTrab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Material a trabajar"
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub mostrarPosicion(ByVal tabla As String)
        Dim bmbase As BindingManagerBase = BindingContext.Item(ds, tabla)
        Dim iTotal As Integer = bmbase.Count
        Dim iPos As Integer

        If iTotal = 0 Then
            Label3.Text = "0"

        Else
            iPos = bmbase.Position + 1
            Label3.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub abmMatTrab_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub




    Private Sub abmMatTrab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '
        'adaptador1
        '
        Me.adaptador.DeleteCommand = Me.SqlDeleteCommand1
        Me.adaptador.InsertCommand = Me.SqlInsertCommand1
        Me.adaptador.SelectCommand = Me.SqlSelectCommand1
        Me.adaptador.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materialatrabajar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.adaptador.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[NewSelectMatTra]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "[NewInsertMatTra]"
        Me.SqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlInsertCommand1.Connection = cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "[NewUpdateMatTra]"
        Me.SqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlUpdateCommand1.Connection = cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 2147483647, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "[NewDeleteMatTra]"
        Me.SqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlDeleteCommand1.Connection = cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))


        adaptador.Fill(ds)
        Me.UltraTextEditor1.DataBindings.Add("Text", ds, "materialatrabajar.nombre")
        Me.UltraTextEditor2.DataBindings.Add("Text", ds, "materialatrabajar.descripcion")

        tabla = "materialatrabajar"
        Me.mostrarPosicion(tabla)

        princ.barra.agregarBoton(Me)


    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub


    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(ds, tabla).Position += 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(ds, tabla).Position = BindingContext(ds, tabla).Count - 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        BindingContext(ds, tabla).Position = 0
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        BindingContext(ds, tabla).Position -= 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click

        'Dim nuevo As DataRow
        Dim miTabla As DataTable = ds.Tables(0)
        Dim cfilas As DataRowCollection = miTabla.Rows
        Dim nuevaFila As DataRow

        Try
            'nuevo = Ds11.Tables(0).NewRow

            nuevaFila = miTabla.NewRow
            nuevaFila(0) = ""
            nuevaFila(1) = ""

            cfilas.Add(nuevaFila)

            'adaptador.Update(Ds11)
            'nuevo("nombre") = "nombre"
            'nuevo("descripcion") = "desc"
            'Ds11.Tables(0).Rows.Add(nuevo)

            UltraButton6.PerformClick()
            mostrarPosicion(tabla)
            UltraTextEditor1.Focus()

        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message)
        End Try

        UltraTextEditor1.ReadOnly = False
        UltraTextEditor2.ReadOnly = False

        UltraTextEditor1.BackColor = System.Drawing.Color.LightCyan
        UltraTextEditor2.BackColor = System.Drawing.Color.LightCyan

        'adaptador.Update(Ds11)





    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        

        UltraButton5.PerformClick()
        UltraButton7.PerformClick()
        adaptador.Update(ds, "materialatrabajar")
        UltraTextEditor1.ReadOnly = True
        UltraTextEditor2.ReadOnly = True
        
        UltraTextEditor1.BackColor() = System.Drawing.Color.White
        UltraTextEditor2.BackColor() = System.Drawing.Color.White

    End Sub

    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        UltraTextEditor1.ReadOnly = False
        UltraTextEditor2.ReadOnly = False
        UltraTextEditor1.Focus()

        UltraTextEditor1.BackColor() = System.Drawing.Color.LightCyan
        UltraTextEditor2.BackColor() = System.Drawing.Color.LightCyan

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim bmbase As BindingManagerBase = BindingContext(ds, tabla)
        Dim vistaFilaActual As DataRowView
        Dim NL As String = Environment.NewLine

        If (MessageBox.Show("¿Desea borrar este registro?" & NL, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            vistaFilaActual = bmbase.Current
            vistaFilaActual.Row.Delete()
            mostrarPosicion(tabla)
            adaptador.Update(ds)
        End If


    End Sub


    
End Class
