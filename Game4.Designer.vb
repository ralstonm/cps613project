<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game4
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
        Me.MagnetBoard = New System.Windows.Forms.Panel()
        Me.RecordingPictureBox = New System.Windows.Forms.PictureBox()
        Me.MicrophoneButton = New System.Windows.Forms.Button()
        Me.PictureBoxF = New System.Windows.Forms.PictureBox()
        Me.PictureBoxE = New System.Windows.Forms.PictureBox()
        Me.PictureBoxD = New System.Windows.Forms.PictureBox()
        Me.PictureBoxC = New System.Windows.Forms.PictureBox()
        Me.PictureBoxB = New System.Windows.Forms.PictureBox()
        Me.PictureBoxA = New System.Windows.Forms.PictureBox()
        Me.AlphaBetParrotButton = New System.Windows.Forms.Button()
        Me.MagnetBoard.SuspendLayout()
        CType(Me.RecordingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MagnetBoard
        '
        Me.MagnetBoard.BackColor = System.Drawing.Color.Black
        Me.MagnetBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MagnetBoard.Controls.Add(Me.PictureBoxF)
        Me.MagnetBoard.Controls.Add(Me.PictureBoxE)
        Me.MagnetBoard.Controls.Add(Me.PictureBoxD)
        Me.MagnetBoard.Controls.Add(Me.PictureBoxC)
        Me.MagnetBoard.Controls.Add(Me.PictureBoxB)
        Me.MagnetBoard.Controls.Add(Me.PictureBoxA)
        Me.MagnetBoard.Location = New System.Drawing.Point(15, 185)
        Me.MagnetBoard.Name = "MagnetBoard"
        Me.MagnetBoard.Size = New System.Drawing.Size(581, 380)
        Me.MagnetBoard.TabIndex = 10
        '
        'RecordingPictureBox
        '
        Me.RecordingPictureBox.BackgroundImage = Global.Lab5Template.My.Resources.Resources.recording1
        Me.RecordingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RecordingPictureBox.Location = New System.Drawing.Point(496, 572)
        Me.RecordingPictureBox.Name = "RecordingPictureBox"
        Me.RecordingPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.RecordingPictureBox.TabIndex = 12
        Me.RecordingPictureBox.TabStop = False
        Me.RecordingPictureBox.Visible = False
        '
        'MicrophoneButton
        '
        Me.MicrophoneButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.microphone
        Me.MicrophoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MicrophoneButton.Location = New System.Drawing.Point(15, 572)
        Me.MicrophoneButton.Name = "MicrophoneButton"
        Me.MicrophoneButton.Size = New System.Drawing.Size(450, 373)
        Me.MicrophoneButton.TabIndex = 11
        Me.MicrophoneButton.UseVisualStyleBackColor = True
        '
        'PictureBoxF
        '
        Me.PictureBoxF.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetf
        Me.PictureBoxF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxF.Location = New System.Drawing.Point(375, 142)
        Me.PictureBoxF.Name = "PictureBoxF"
        Me.PictureBoxF.Size = New System.Drawing.Size(168, 237)
        Me.PictureBoxF.TabIndex = 6
        Me.PictureBoxF.TabStop = False
        Me.PictureBoxF.Visible = False
        '
        'PictureBoxE
        '
        Me.PictureBoxE.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnete
        Me.PictureBoxE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxE.Location = New System.Drawing.Point(41, 193)
        Me.PictureBoxE.Name = "PictureBoxE"
        Me.PictureBoxE.Size = New System.Drawing.Size(139, 162)
        Me.PictureBoxE.TabIndex = 5
        Me.PictureBoxE.TabStop = False
        Me.PictureBoxE.Visible = False
        '
        'PictureBoxD
        '
        Me.PictureBoxD.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetd
        Me.PictureBoxD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxD.Location = New System.Drawing.Point(186, 43)
        Me.PictureBoxD.Name = "PictureBoxD"
        Me.PictureBoxD.Size = New System.Drawing.Size(168, 237)
        Me.PictureBoxD.TabIndex = 4
        Me.PictureBoxD.TabStop = False
        Me.PictureBoxD.Visible = False
        '
        'PictureBoxC
        '
        Me.PictureBoxC.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetc
        Me.PictureBoxC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxC.Location = New System.Drawing.Point(405, 28)
        Me.PictureBoxC.Name = "PictureBoxC"
        Me.PictureBoxC.Size = New System.Drawing.Size(139, 162)
        Me.PictureBoxC.TabIndex = 2
        Me.PictureBoxC.TabStop = False
        '
        'PictureBoxB
        '
        Me.PictureBoxB.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetb
        Me.PictureBoxB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxB.Location = New System.Drawing.Point(231, 43)
        Me.PictureBoxB.Name = "PictureBoxB"
        Me.PictureBoxB.Size = New System.Drawing.Size(168, 237)
        Me.PictureBoxB.TabIndex = 1
        Me.PictureBoxB.TabStop = False
        '
        'PictureBoxA
        '
        Me.PictureBoxA.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magneta
        Me.PictureBoxA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxA.Location = New System.Drawing.Point(19, 43)
        Me.PictureBoxA.Name = "PictureBoxA"
        Me.PictureBoxA.Size = New System.Drawing.Size(177, 173)
        Me.PictureBoxA.TabIndex = 0
        Me.PictureBoxA.TabStop = False
        '
        'AlphaBetParrotButton
        '
        Me.AlphaBetParrotButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.parrot
        Me.AlphaBetParrotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlphaBetParrotButton.Location = New System.Drawing.Point(15, 12)
        Me.AlphaBetParrotButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlphaBetParrotButton.Name = "AlphaBetParrotButton"
        Me.AlphaBetParrotButton.Size = New System.Drawing.Size(123, 167)
        Me.AlphaBetParrotButton.TabIndex = 8
        Me.AlphaBetParrotButton.Text = " "
        Me.AlphaBetParrotButton.UseVisualStyleBackColor = True
        '
        'Game4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.RecordingPictureBox)
        Me.Controls.Add(Me.MicrophoneButton)
        Me.Controls.Add(Me.MagnetBoard)
        Me.Controls.Add(Me.AlphaBetParrotButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Game4"
        Me.Size = New System.Drawing.Size(633, 957)
        Me.MagnetBoard.ResumeLayout(False)
        CType(Me.RecordingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MicrophoneButton As System.Windows.Forms.Button
    Friend WithEvents MagnetBoard As System.Windows.Forms.Panel
    Friend WithEvents AlphaBetParrotButton As System.Windows.Forms.Button
    Friend WithEvents PictureBoxA As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxC As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxB As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxF As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxE As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxD As System.Windows.Forms.PictureBox
    Friend WithEvents RecordingPictureBox As System.Windows.Forms.PictureBox

End Class
