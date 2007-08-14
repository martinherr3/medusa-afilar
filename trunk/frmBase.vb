Public Class frmBase

    Private Sub frmBase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not Me.DesignMode Then
            princ.barra.eliminarBoton()
        End If
    End Sub

    Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            princ.barra.agregarBoton(Me)
        End If
    End Sub
End Class