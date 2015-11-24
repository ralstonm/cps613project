<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game1
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
        Me.alphabetGamePanel = New System.Windows.Forms.Panel()
        Me.storyBookImage = New System.Windows.Forms.PictureBox()
        Me.buttonPlaces = New System.Windows.Forms.Panel()
        Me.pictureBook = New System.Windows.Forms.PictureBox()
        Me.AlphaBetParrotButton = New System.Windows.Forms.Button()
        Me.alphabetGamePanel.SuspendLayout()
        CType(Me.storyBookImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'alphabetGamePanel
        '
        Me.alphabetGamePanel.BackgroundImage = Global.Lab5Template.My.Resources.Resources.cps613bg
        Me.alphabetGamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.alphabetGamePanel.Controls.Add(Me.storyBookImage)
        Me.alphabetGamePanel.Controls.Add(Me.buttonPlaces)
        Me.alphabetGamePanel.Controls.Add(Me.pictureBook)
        Me.alphabetGamePanel.Controls.Add(Me.AlphaBetParrotButton)
        Me.alphabetGamePanel.Location = New System.Drawing.Point(0, 1)
        Me.alphabetGamePanel.Name = "alphabetGamePanel"
        Me.alphabetGamePanel.Size = New System.Drawing.Size(422, 622)
        Me.alphabetGamePanel.TabIndex = 10
        '
        'storyBookImage
        '
        Me.storyBookImage.BackColor = System.Drawing.Color.Transparent
        Me.storyBookImage.Location = New System.Drawing.Point(115, 52)
        Me.storyBookImage.Name = "storyBookImage"
        Me.storyBookImage.Size = New System.Drawing.Size(172, 202)
        Me.storyBookImage.TabIndex = 6
        Me.storyBookImage.TabStop = False
        '
        'buttonPlaces
        '
        Me.buttonPlaces.BackColor = System.Drawing.Color.Transparent
        Me.buttonPlaces.Location = New System.Drawing.Point(0, 319)
        Me.buttonPlaces.Name = "buttonPlaces"
        Me.buttonPlaces.Size = New System.Drawing.Size(419, 299)
        Me.buttonPlaces.TabIndex = 5
        '
        'pictureBook
        '
        Me.pictureBook.BackgroundImage = Global.Lab5Template.My.Resources.Resources.picturebook
        Me.pictureBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBook.Location = New System.Drawing.Point(89, 31)
        Me.pictureBook.Name = "pictureBook"
        Me.pictureBook.Size = New System.Drawing.Size(230, 241)
        Me.pictureBook.TabIndex = 4
        Me.pictureBook.TabStop = False
        '
        'AlphaBetParrotButton
        '
        Me.AlphaBetParrotButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.parrot
        Me.AlphaBetParrotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlphaBetParrotButton.Location = New System.Drawing.Point(3, 3)
        Me.AlphaBetParrotButton.Name = "AlphaBetParrotButton"
        Me.AlphaBetParrotButton.Size = New System.Drawing.Size(80, 78)
        Me.AlphaBetParrotButton.TabIndex = 3
        Me.AlphaBetParrotButton.Text = " "
        Me.AlphaBetParrotButton.UseVisualStyleBackColor = True
        '
        'Game1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.alphabetGamePanel)
        Me.Name = "Game1"
        Me.Size = New System.Drawing.Size(422, 622)
        Me.alphabetGamePanel.ResumeLayout(False)
        CType(Me.storyBookImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents alphabetGamePanel As System.Windows.Forms.Panel
    Friend WithEvents AlphaBetParrotButton As System.Windows.Forms.Button
    Friend WithEvents pictureBook As System.Windows.Forms.PictureBox
    Friend WithEvents buttonPlaces As System.Windows.Forms.Panel
    Friend WithEvents storyBookImage As System.Windows.Forms.PictureBox

End Class
