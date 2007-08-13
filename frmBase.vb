Public Class frmBase

    'Private MyBar As New BarraDeEstado(principal.UltraStatusBar1)
    Private MyPrincipal As New principal
    Private Sub frmBase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'MyBar.eliminarBoton()
        MyPrincipal.barra.eliminarBoton()
    End Sub

    Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MyBar.agregarBoton(Me)
        MyPrincipal.barra.agregarBoton(Me)
    End Sub
End Class