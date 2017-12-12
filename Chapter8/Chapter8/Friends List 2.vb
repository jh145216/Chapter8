Public Class Friends_List_2
    Private lstNames As New List(Of String)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstNames.Add(txtName.Text)

        txtName.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strNames As String

        lstFriends.Items.Clear()

        For Each strNames In lstNames
            lstFriends.Items.Add(strNames)  'Add to list box
        Next
    End Sub
End Class