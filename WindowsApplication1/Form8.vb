Public Class Form8

   

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox1.TextAlign = HorizontalAlignment.Center
        TextBox1.Text = vbCrLf & "MRIDUL" & vbCrLf & " https://github.com/coderpro/Bank-Tycoon  "

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class