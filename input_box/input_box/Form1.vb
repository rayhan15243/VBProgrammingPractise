Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userName As String = Nothing
        userName = InputBox("What is your name")
        lblHello.ForeColor = Color.Green
        lblHello.Text = "Hello, " & userName

    End Sub
End Class
