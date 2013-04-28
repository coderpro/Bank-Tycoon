Public Class Form7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Activate()
        Form9.Show()
        Form6.Hide()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Activate()
        Form2.Show()
        Form6.Hide()
        Me.Hide()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class