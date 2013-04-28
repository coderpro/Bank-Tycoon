Public Class Form2

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.Items(0).Selected = True Then
            Form3.Show()
            Me.Hide()
        ElseIf ListView1.Items(1).Selected = True Then
            Form4.Show()
        ElseIf ListView1.Items(2).Selected = True Then
            Form9.Show()
        ElseIf ListView1.Items(3).Selected = True Then
            Form6.Show()
        ElseIf ListView1.Items(4).Selected = True Then
            Form1.Activate()
            Form1.TextBox1.Text = ""
            Form1.TextBox2.Text = ""
            Form1.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub ListView1_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged


    End Sub

    Private Sub ImageList1_Disposed(sender As Object, e As EventArgs) Handles ImageList1.Disposed

    End Sub

    
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Me.Activated
        If Form1.TextBox1.Text = "Mridul" Then
            Me.Label4.Text = Form1.TextBox1.Text
        ElseIf Form1.TextBox1.Text = "Keshav" Then
            Me.Label4.Text = Form1.TextBox1.Text
        ElseIf Form1.TextBox1.Text = "Lasya" Then
            Me.Label4.Text = Form1.TextBox1.Text
        ElseIf Form1.TextBox1.Text = "Prem" Then
            Me.Label4.Text = Form1.TextBox1.Text
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form8.Show()
    End Sub
End Class