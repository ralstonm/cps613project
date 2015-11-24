<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game3
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
        Me.AlphaBetParrotButton = New System.Windows.Forms.Button()
        Me.drawingBox = New System.Windows.Forms.PictureBox()
        Me.backbox = New System.Windows.Forms.PictureBox()
        Me.Nextbutton = New System.Windows.Forms.Button()
        CType(Me.drawingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlphaBetParrotButton
        '
        Me.AlphaBetParrotButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.parrot
        Me.AlphaBetParrotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlphaBetParrotButton.Location = New System.Drawing.Point(138, 12)
        Me.AlphaBetParrotButton.Name = "AlphaBetParrotButton"
        Me.AlphaBetParrotButton.Size = New System.Drawing.Size(93, 72)
        Me.AlphaBetParrotButton.TabIndex = 4
        Me.AlphaBetParrotButton.Text = " "
        Me.AlphaBetParrotButton.UseVisualStyleBackColor = True
        '
        'drawingBox
        '
        Me.drawingBox.BackColor = System.Drawing.Color.Transparent
        Me.drawingBox.BackgroundImage = Global.Lab5Template.My.Resources.Resources.TracE
        Me.drawingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.drawingBox.Location = New System.Drawing.Point(12, 142)
        Me.drawingBox.Name = "drawingBox"
        Me.drawingBox.Size = New System.Drawing.Size(430, 412)
        Me.drawingBox.TabIndex = 5
        Me.drawingBox.TabStop = False
        '
        'backbox
        '
        Me.backbox.BackgroundImage = Global.Lab5Template.My.Resources.Resources.traceA
        Me.backbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backbox.Location = New System.Drawing.Point(12, 142)
        Me.backbox.Name = "backbox"
        Me.backbox.Size = New System.Drawing.Size(448, 412)
        Me.backbox.TabIndex = 6
        Me.backbox.TabStop = False
        '
        'Nextbutton
        '
        Me.Nextbutton.Location = New System.Drawing.Point(177, 90)
        Me.Nextbutton.Name = "Nextbutton"
        Me.Nextbutton.Size = New System.Drawing.Size(90, 41)
        Me.Nextbutton.TabIndex = 7
        Me.Nextbutton.Text = "Next"
        Me.Nextbutton.UseVisualStyleBackColor = True
        '
        'Game3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Nextbutton)
        Me.Controls.Add(Me.drawingBox)
        Me.Controls.Add(Me.AlphaBetParrotButton)
        Me.Controls.Add(Me.backbox)
        Me.Name = "Game3"
        Me.Size = New System.Drawing.Size(492, 574)
        CType(Me.drawingBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaBetParrotButton As System.Windows.Forms.Button
    Friend WithEvents drawingBox As System.Windows.Forms.PictureBox
    Friend WithEvents backbox As System.Windows.Forms.PictureBox
    Friend WithEvents Nextbutton As System.Windows.Forms.Button

End Class
