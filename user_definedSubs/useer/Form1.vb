Public Class Form1

    Private Sub btnRunSub_Click(sender As Object, e As EventArgs) Handles btnRunSub.Click
        addnumber()
    End Sub

    Private Sub addnumber()

        Dim num1 As Integer = 2341
        Dim num2 As Integer = 5233
        MessageBox.Show(num1 + num2)
    End Sub
End Class
