Public Class CalculationForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Decimal = Convert.ToDecimal(txtBreadth.Text) * Convert.ToDecimal(txtHeight.Text) * Convert.ToDecimal(txtWidth.Text)
        MessageBox.Show("Total : " + Convert.ToString(i))
    End Sub
End Class