Public Class Greetings
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        'Take value from name textbox and print in messagebox
        'MessageBox.Show(txtName.Text)

        'Take value from name textbox and to print to txtOut
        txtOut.Text = "Good Evening " & txtName.Text & ControlChars.CrLf
        txtOut.Text = txtOut.Text & " How are you?"

        'Clear txtName value
        txtName.Clear()


    End Sub
End Class

