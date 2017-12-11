Public Class Menu

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLotteryNumbers_Click(sender As Object, e As EventArgs) Handles btnLotteryNumbers.Click
        Dim box = New Form1()
        box.Show()
    End Sub
End Class