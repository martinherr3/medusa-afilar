Public Class LoginForm
    Private NoCerrar As Boolean

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text <> "" Or PasswordTextBox.Text <> "" Then
            If PasswordTextBox.Text = "Default" Then
                If seguridad.Validar(Me.UsernameTextBox.Text, PasswordTextBox.Text) Then
                    NoCerrar = False
                    Exit Sub
                Else
                    LblError.Text = "Nombre de usuario o contraseña incorrectos"
                End If
            Else
                If seguridad.Validar(Me.UsernameTextBox.Text, Criptologia.EncriptarTexto(PasswordTextBox.Text, UsernameTextBox.Text, True)) Then
                    NoCerrar = False
                    Exit Sub
                Else
                    LblError.Text = "Nombre de usuario o contraseña incorrectos"
                End If
            End If
            
        Else
            LblError.Text = "Debe ingresar nombre de usuario y contraseña "
        End If
        NoCerrar = True

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        princ.Close()
    End Sub

    
    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = NoCerrar
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PasswordTextBox.Text = "test"
        'UsernameTextBox.Text = "jperez"
        'OK.PerformClick()
    End Sub
End Class
