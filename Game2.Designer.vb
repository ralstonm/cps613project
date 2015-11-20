<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game2))
        Me.AlphaBetParrotButton = New System.Windows.Forms.Button()
        Me.KeyboardPic = New System.Windows.Forms.PictureBox()
        Me.LetterBox = New System.Windows.Forms.PictureBox()
        CType(Me.KeyboardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LetterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlphaBetParrotButton
        '
        Me.AlphaBetParrotButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.parrot
        Me.AlphaBetParrotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlphaBetParrotButton.Location = New System.Drawing.Point(3, 12)
        Me.AlphaBetParrotButton.Name = "AlphaBetParrotButton"
        Me.AlphaBetParrotButton.Size = New System.Drawing.Size(80, 78)
        Me.AlphaBetParrotButton.TabIndex = 4
        Me.AlphaBetParrotButton.Text = " "
        Me.AlphaBetParrotButton.UseVisualStyleBackColor = True
        '
        'KeyboardPic
        '
        Me.KeyboardPic.Image = CType(resources.GetObject("KeyboardPic.Image"), System.Drawing.Image)
        Me.KeyboardPic.Location = New System.Drawing.Point(52, 180)
        Me.KeyboardPic.Name = "KeyboardPic"
        Me.KeyboardPic.Size = New System.Drawing.Size(329, 155)
        Me.KeyboardPic.TabIndex = 5
        Me.KeyboardPic.TabStop = False
        '
        'LetterBox
        '
        Me.LetterBox.Image = CType(resources.GetObject("LetterBox.Image"), System.Drawing.Image)
        Me.LetterBox.Location = New System.Drawing.Point(111, 6)
        Me.LetterBox.Name = "LetterBox"
        Me.LetterBox.Size = New System.Drawing.Size(196, 168)
        Me.LetterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LetterBox.TabIndex = 6
        Me.LetterBox.TabStop = False
        '
        'Game2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LetterBox)
        Me.Controls.Add(Me.KeyboardPic)
        Me.Controls.Add(Me.AlphaBetParrotButton)
        Me.Name = "Game2"
        Me.Size = New System.Drawing.Size(422, 622)
        CType(Me.KeyboardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LetterBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaBetParrotButton As System.Windows.Forms.Button
    Friend WithEvents KeyboardPic As System.Windows.Forms.PictureBox
    Friend WithEvents LetterBox As System.Windows.Forms.PictureBox

End Class
