Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "user" Then
            If TextBox2.Text = "bank" Then
                Form2.Activate()
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Enter Correct Password")
            End If
        Else
            MessageBox.Show("Enter Correct User And Password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
