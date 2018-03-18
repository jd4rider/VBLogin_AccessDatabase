Public Class LoginType
    Private Sub StudentLoginButton_Click(sender As Object, e As EventArgs) Handles StudentLoginButton.Click
        Me.Visible = False
        StudentLogin.ShowDialog()
    End Sub

    Private Sub TeacherLoginButton_Click(sender As Object, e As EventArgs) Handles TeacherLoginButton.Click
        Me.Visible = False
        TeacherLogin.ShowDialog()
    End Sub
End Class