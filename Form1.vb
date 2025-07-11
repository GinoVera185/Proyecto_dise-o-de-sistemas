Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Numero1.Click

    End Sub

    Private Sub Numero2_Click(sender As Object, e As EventArgs) Handles Numero2.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Resultado.Click

    End Sub

    Private Sub txtNumero1_TextChanged(sender As Object, e As EventArgs) Handles txtNumero1.TextChanged

    End Sub

    Private Sub txtNumero2_TextChanged(sender As Object, e As EventArgs) Handles txtNumero2.TextChanged

    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click

    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click

    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        Try
        Dim num1 As Double = Convert.ToDouble(txtNumero1.Text)
        Dim num2 As Double = Convert.ToDouble(txtNumero2.Text)
        Dim result As Double = num1 * num2
        lblResultado.Text = result.ToString()
    Catch ex As Exception
        MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    End Sub

End Class
