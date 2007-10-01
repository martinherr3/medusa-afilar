Public Class Form1

    

    
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DSHojaRuta


        'adaptadorCompra2.Fill(DsHojaRuta1)
        'Dim p As New rptHojaRuta
        'p.SetDataSource(DsHojaRuta1)
        'CrystalReportViewer1.ReportSource = p
        'Dim SelectFormula As String


        'SelectFormula = "{hojaderuta.idhojaderuta} = " & "1"
        'CrystalReportViewer1.SelectionFormula = SelectFormula

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class