Public Class frmCodigoBarra

    Private objCodigo As CodigoBarra

    Private Sub btnGenerarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCodigo.Click

        If txtIdArticulo.Text.Length = 5 And IsNumeric(txtIdArticulo.Text) Then
            Dim myGrafico As System.Drawing.Graphics
            myGrafico = ptbCodigo.CreateGraphics()

            myGrafico.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.SystemColors.Control), New Rectangle(0, 0, ptbCodigo.Width, ptbCodigo.Height))

            CreateImagenEan13()
            objCodigo.Scale = 1.0
            objCodigo.DrawEan13Barcode(myGrafico, New System.Drawing.Point(0, 0))

            myGrafico.Dispose()
        Else
            MessageBox.Show("El Id debe ser de 5 digitos y numerico")
        End If

    End Sub


    Private Sub CreateImagenEan13()
        'En el New de esta clase se setea valores fijos para Country Code y
        'Manufacturer Code, despues vemos la posibilidad de cambiarlos
        objCodigo = New CodigoBarra()
        objCodigo.ProductCode = txtIdArticulo.Text
    End Sub

    Private Sub btnImprimirCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirCodigo.Click
        Dim pd As New System.Drawing.Printing.PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As System.Drawing.Printing.PrintPageEventArgs)
        CreateImagenEan13()
        objCodigo.Scale = CSng(Convert.ToDecimal("1"))
        objCodigo.DrawEan13Barcode(ev.Graphics, New System.Drawing.Point(0, 0))
        'txtChecksumDigit.Text = objCodigo.ChecksumDigit
        ' Add Code here to print other information. 
        ev.Graphics.Dispose()
    End Sub

    Private Sub txtIdArticuloCapturado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdArticuloCapturado.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Dim codigo As String
            codigo = txtIdArticuloCapturado.Text.Substring(7, 5)
            txtIdArticuloCapturado.Text = codigo
            MessageBox.Show("El Id Capturado es " & codigo)
        End If
    End Sub

    Private Sub txtIdArticuloCapturado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdArticuloCapturado.TextChanged

    End Sub
End Class