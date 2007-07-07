Public Class frmBaseDatos
    Dim oBase As BaseDatos

    Private Sub frmBaseDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oBase = New BaseDatos()
        txtInstancia.Text = oBase.Instancia
        txtLoginSecure.Text = oBase.LoginSecure
        txtNombreBD.Text = oBase.NombreBD
        txtUsuario.Text = oBase.Usuario
        txtPassword.Text = oBase.Password

    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        oBase.doBackup(txtBackup.Text)
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        oBase.doRestore(txtRestore.Text)
    End Sub
End Class