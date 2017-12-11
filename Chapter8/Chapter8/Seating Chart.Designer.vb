<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seating_Chart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seating_Chart))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDisplayPrice = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.txtCol = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 382)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnDisplayPrice
        '
        Me.btnDisplayPrice.Location = New System.Drawing.Point(72, 400)
        Me.btnDisplayPrice.Name = "btnDisplayPrice"
        Me.btnDisplayPrice.Size = New System.Drawing.Size(75, 34)
        Me.btnDisplayPrice.TabIndex = 1
        Me.btnDisplayPrice.Text = "Display Price"
        Me.btnDisplayPrice.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter a Row"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter a Column"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Seat Price"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(272, 34)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(39, 33)
        Me.lblPrice.TabIndex = 6
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(97, 34)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(50, 20)
        Me.txtRow.TabIndex = 7
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(97, 87)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(50, 20)
        Me.txtCol.TabIndex = 8
        '
        'Seating_Chart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 446)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayPrice)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Seating_Chart"
        Me.Text = "Seating_Chart"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDisplayPrice As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
End Class
