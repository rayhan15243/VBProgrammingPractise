Public Class Form1

    'Message Box
    'Private Sub btnShowMessage_Click(sender As Object, e As EventArgs) Handles btnShowMessage.Click
    '    MessageBox.Show("This is a bare mesasageBox")
    '    MessageBox.Show(" This message has a title", "Title")
    '    MessageBox.Show("This has an icon", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    MsgBox("Message")
    'End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click

        Select Case MessageBox.Show("Click something,", "title", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Abort
                MessageBox.Show("bye")
                Close()
            Case Windows.Forms.DialogResult.Retry
                MessageBox.Show("LOOOL")
            Case Windows.Forms.DialogResult.Ignore
                MessageBox.Show("Lool")
        End Select

    End Sub
End Class
