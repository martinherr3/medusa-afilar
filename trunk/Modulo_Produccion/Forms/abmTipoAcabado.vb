Public Class abmTipoAcabado
    Inherits System.Windows.Forms.Form
    Dim tabla As String
    Dim ds As New DataSet
    Dim adaptador As New SqlClient.SqlDataAdapter
    Dim SqlDeleteCommand1 As New SqlClient.SqlCommand
    Dim SqlInsertCommand1 As New SqlClient.SqlCommand
    Dim SqlSelectCommand1 As New SqlClient.SqlCommand
    Dim SqlUpdateCommand1 As New SqlClient.SqlCommand

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmTipoAcabado))
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
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraButton2
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButton2.Appearance = Appearance1
        Me.UltraButton2.Location = New System.Drawing.Point(19, 239)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(79, 27)
        Me.UltraButton2.TabIndex = 21
        Me.UltraButton2.Text = "&Eliminar"
        '
        'UltraButton9
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButton9.Appearance = Appearance2
        Me.UltraButton9.Location = New System.Drawing.Point(19, 210)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(79, 27)
        Me.UltraButton9.TabIndex = 22
        Me.UltraButton9.Text = "&Nuevo"
        '
        'UltraTextEditor1
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Me.UltraTextEditor1.Appearance = Appearance3
        Me.UltraTextEditor1.AutoSize = True
        Me.UltraTextEditor1.Location = New System.Drawing.Point(80, 16)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.ReadOnly = True
        Me.UltraTextEditor1.Size = New System.Drawing.Size(296, 21)
        Me.UltraTextEditor1.TabIndex = 18
        '
        'UltraButton8
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButton8.Appearance = Appearance4
        Me.UltraButton8.Location = New System.Drawing.Point(100, 210)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(79, 27)
        Me.UltraButton8.TabIndex = 24
        Me.UltraButton8.Text = "&Modificar"
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
        Me.UltraGroupBox1.TabIndex = 20
        Me.UltraGroupBox1.Text = "Navegabilidad"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraButton7
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton7.Appearance = Appearance5
        Me.UltraButton7.Location = New System.Drawing.Point(176, 24)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton7.TabIndex = 3
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
        'UltraButton4
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton4.Appearance = Appearance7
        Me.UltraButton4.Location = New System.Drawing.Point(48, 24)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton4.TabIndex = 1
        '
        'UltraButton5
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton5.Appearance = Appearance8
        Me.UltraButton5.Location = New System.Drawing.Point(8, 24)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(40, 24)
        Me.UltraButton5.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(95, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 2
        '
        'UltraTextEditor2
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Me.UltraTextEditor2.Appearance = Appearance9
        Me.UltraTextEditor2.AutoSize = True
        Me.UltraTextEditor2.Location = New System.Drawing.Point(80, 48)
        Me.UltraTextEditor2.Multiline = True
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.ReadOnly = True
        Me.UltraTextEditor2.Size = New System.Drawing.Size(296, 88)
        Me.UltraTextEditor2.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Descripci�n"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nombre"
        '
        'UltraButton3
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.UltraButton3.Appearance = Appearance10
        Me.UltraButton3.Location = New System.Drawing.Point(100, 239)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(79, 27)
        Me.UltraButton3.TabIndex = 25
        Me.UltraButton3.Text = "&Guardar"
        '
        'UltraButton1
        '
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        Me.UltraButton1.Appearance = Appearance11
        Me.UltraButton1.Location = New System.Drawing.Point(297, 239)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(79, 27)
        Me.UltraButton1.TabIndex = 27
        Me.UltraButton1.Text = "&Salir"
        '
        'abmTipoAcabado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(391, 278)
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
        Me.Location = New System.Drawing.Point(200, 106)
        Me.Name = "abmTipoAcabado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tipo de acabado"
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        BindingContext(ds, tabla).Position -= 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        BindingContext(ds, tabla).Position = 0
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton6.Click
        BindingContext(ds, tabla).Position = BindingContext(ds, tabla).Count - 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        BindingContext(ds, tabla).Position += 1
        mostrarPosicion(tabla)
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click

        UltraButton5.PerformClick()
        UltraButton7.PerformClick()
        adaptador.Update(ds, "tipoacabado")
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

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        Dim nuevo As DataRow
        
        Try
            nuevo = ds.Tables(0).NewRow



            adaptador.Update(ds)
            nuevo("nombre") = ""
            nuevo("descripcion") = ""
            ds.Tables(0).Rows.Add(nuevo)

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


    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim bmbase As BindingManagerBase = BindingContext(ds, tabla)
        Dim vistaFilaActual As DataRowView
        Dim NL As String = Environment.NewLine

        If (MessageBox.Show("�Desea borrar este registro?" & NL, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            vistaFilaActual = bmbase.Current
            vistaFilaActual.Row.Delete()
            mostrarPosicion(tabla)
            adaptador.Update(ds)
        End If
    End Sub

    Private Sub abmTipoAcabado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        'adaptador
        '
        Me.adaptador.DeleteCommand = Me.SqlDeleteCommand1
        Me.adaptador.InsertCommand = Me.SqlInsertCommand1
        Me.adaptador.SelectCommand = Me.SqlSelectCommand1
        Me.adaptador.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tipoacabado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.adaptador.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM tipoacabado WHERE (nombre = @Original_nombre) AND (descripcion = @Ori" & _
        "ginal_descripcion OR @Original_descripcion IS NULL AND descripcion IS NULL)"
        Me.SqlDeleteCommand1.Connection = cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO tipoacabado(nombre, descripcion) VALUES (@nombre, @descripcion); SELE" & _
        "CT nombre, descripcion FROM tipoacabado WHERE (nombre = @nombre)"
        Me.SqlInsertCommand1.Connection = cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 10, "descripcion"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT nombre, descripcion FROM tipoacabado"
        Me.SqlSelectCommand1.Connection = cnn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE tipoacabado SET nombre = @nombre, descripcion = @descripcion WHERE (nombre" & _
        " = @Original_nombre) AND (descripcion = @Original_descripcion OR @Original_descr" & _
        "ipcion IS NULL AND descripcion IS NULL); SELECT nombre, descripcion FROM tipoaca" & _
        "bado WHERE (nombre = @nombre)"
        Me.SqlUpdateCommand1.Connection = cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 40, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 10, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))



        adaptador.Fill(ds, "tipoacabado")
        Me.UltraTextEditor1.DataBindings.Add("Text", ds, "tipoacabado.nombre")
        Me.UltraTextEditor2.DataBindings.Add("Text", ds, "tipoacabado.descripcion")

        tabla = "tipoacabado"
        Me.mostrarPosicion(tabla)

        princ.barra.agregarBoton(Me)

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub

    Private Sub abmTipoAcabado_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub
End Class
