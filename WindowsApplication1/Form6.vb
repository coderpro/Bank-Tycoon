Public Class Form6

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim acc As Integer = TextBox1.Text
        Dim amt As Integer = TextBox2.Text
        Me.CustomerTableAdapter.UpdateQuery(amt, acc)
        MsgBox("Amount Deposited To Account No: " & acc)

    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._MyDatabase_1DataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me._MyDatabase_1DataSet.Customer)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Activate()
        Form7.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim ac As Integer = TextBox1.Text
        Dim am As Integer = TextBox2.Text
        Me.CustomerTableAdapter.UpdateQuery1(am, ac)
        MsgBox("Amount Withdrawn From Account No: " & ac)
    End Sub
End Class
