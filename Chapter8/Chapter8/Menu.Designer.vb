<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLotteryNumbers = New System.Windows.Forms.Button()
        Me.btnSeatingChart = New System.Windows.Forms.Button()
        Me.btnFriendsList = New System.Windows.Forms.Button()
        Me.btnFriendsList2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLotteryNumbers
        '
        Me.btnLotteryNumbers.Location = New System.Drawing.Point(95, 12)
        Me.btnLotteryNumbers.Name = "btnLotteryNumbers"
        Me.btnLotteryNumbers.Size = New System.Drawing.Size(75, 36)
        Me.btnLotteryNumbers.TabIndex = 0
        Me.btnLotteryNumbers.Text = "Lottery Numbers"
        Me.btnLotteryNumbers.UseVisualStyleBackColor = True
        '
        'btnSeatingChart
        '
        Me.btnSeatingChart.Location = New System.Drawing.Point(95, 69)
        Me.btnSeatingChart.Name = "btnSeatingChart"
        Me.btnSeatingChart.Size = New System.Drawing.Size(75, 37)
        Me.btnSeatingChart.TabIndex = 1
        Me.btnSeatingChart.Text = "Seating Chart"
        Me.btnSeatingChart.UseVisualStyleBackColor = True
        '
        'btnFriendsList
        '
        Me.btnFriendsList.Location = New System.Drawing.Point(95, 123)
        Me.btnFriendsList.Name = "btnFriendsList"
        Me.btnFriendsList.Size = New System.Drawing.Size(75, 39)
        Me.btnFriendsList.TabIndex = 2
        Me.btnFriendsList.Text = "Friend List"
        Me.btnFriendsList.UseVisualStyleBackColor = True
        '
        'btnFriendsList2
        '
        Me.btnFriendsList2.Location = New System.Drawing.Point(95, 178)
        Me.btnFriendsList2.Name = "btnFriendsList2"
        Me.btnFriendsList2.Size = New System.Drawing.Size(75, 43)
        Me.btnFriendsList2.TabIndex = 3
        Me.btnFriendsList2.Text = "Friend List 2"
        Me.btnFriendsList2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(95, 241)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 276)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFriendsList2)
        Me.Controls.Add(Me.btnFriendsList)
        Me.Controls.Add(Me.btnSeatingChart)
        Me.Controls.Add(Me.btnLotteryNumbers)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLotteryNumbers As System.Windows.Forms.Button
    Friend WithEvents btnSeatingChart As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList2 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
