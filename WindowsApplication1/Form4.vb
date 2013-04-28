Public Class Form4

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._MyDatabase_1DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me._MyDatabase_1DataSet.Customer)

    End Sub

    Private Sub CustomerBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.CustomerTableAdapter.FillBy(Me._MyDatabase_1DataSet.Customer, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked

    End Sub

    Private Sub BindingNavigator2_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator2.RefreshItems

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Activate()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub
End Class