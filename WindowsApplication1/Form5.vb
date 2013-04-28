Public Class Form5

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._MyDatabase_1DataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me._MyDatabase_1DataSet.Customer)
    End Sub
    

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Me.Activated
        Label4.Text = Form1.TextBox1.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Activate()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CustomerBindingNavigator.RefreshItems

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class