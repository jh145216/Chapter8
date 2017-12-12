Public Class Menu

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLotteryNumbers_Click(sender As Object, e As EventArgs) Handles btnLotteryNumbers.Click
        Dim box = New Form1()
        box.Show()
    End Sub

    Private Sub btnFriendsList_Click(sender As Object, e As EventArgs) Handles btnFriendsList.Click
        Dim box = New Friends_List()
        box.Show()
    End Sub

    Private Sub btnFriendsList2_Click(sender As Object, e As EventArgs) Handles btnFriendsList2.Click
        Dim box = New Friends_List_2()
        box.Show()
    End Sub

    Private Sub btnSeatingChart_Click(sender As Object, e As EventArgs) Handles btnSeatingChart.Click
        Dim box = New Seating_Chart()
        box.Show()
    End Sub
End Class