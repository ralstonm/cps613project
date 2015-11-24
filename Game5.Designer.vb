<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game5
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
        Me.EmptyPage = New System.Windows.Forms.Panel()
        Me.ApplePage = New System.Windows.Forms.Panel()
        Me.BeePage = New System.Windows.Forms.Panel()
        Me.BeeLabel = New System.Windows.Forms.Label()
        Me.BeePicture = New System.Windows.Forms.Panel()
        Me.AppleLabel = New System.Windows.Forms.Label()
        Me.ApplePicture = New System.Windows.Forms.Panel()
        Me.F = New System.Windows.Forms.Button()
        Me.EButton = New System.Windows.Forms.Button()
        Me.DButton = New System.Windows.Forms.Button()
        Me.CButton = New System.Windows.Forms.Button()
        Me.BButton = New System.Windows.Forms.Button()
        Me.AButton = New System.Windows.Forms.Button()
        Me.AlphaBetParrotButton = New System.Windows.Forms.Button()
        Me.ApplePage.SuspendLayout()
        Me.BeePage.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmptyPage
        '
        Me.EmptyPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmptyPage.Location = New System.Drawing.Point(28, 118)
        Me.EmptyPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmptyPage.Name = "EmptyPage"
        Me.EmptyPage.Size = New System.Drawing.Size(213, 248)
        Me.EmptyPage.TabIndex = 5
        '
        'ApplePage
        '
        Me.ApplePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApplePage.Controls.Add(Me.BeePage)
        Me.ApplePage.Controls.Add(Me.AppleLabel)
        Me.ApplePage.Controls.Add(Me.ApplePicture)
        Me.ApplePage.Location = New System.Drawing.Point(245, 118)
        Me.ApplePage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ApplePage.Name = "ApplePage"
        Me.ApplePage.Size = New System.Drawing.Size(213, 248)
        Me.ApplePage.TabIndex = 6
        '
        'BeePage
        '
        Me.BeePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BeePage.Controls.Add(Me.BeeLabel)
        Me.BeePage.Controls.Add(Me.BeePicture)
        Me.BeePage.Location = New System.Drawing.Point(2, 2)
        Me.BeePage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BeePage.Name = "BeePage"
        Me.BeePage.Size = New System.Drawing.Size(213, 248)
        Me.BeePage.TabIndex = 7
        Me.BeePage.Visible = False
        '
        'BeeLabel
        '
        Me.BeeLabel.AutoSize = True
        Me.BeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeeLabel.Location = New System.Drawing.Point(44, 163)
        Me.BeeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BeeLabel.Name = "BeeLabel"
        Me.BeeLabel.Size = New System.Drawing.Size(103, 44)
        Me.BeeLabel.TabIndex = 1
        Me.BeeLabel.Text = "_ _ _"
        Me.BeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BeeLabel.Visible = False
        '
        'BeePicture
        '
        Me.BeePicture.BackgroundImage = Global.Lab5Template.My.Resources.Resources.bee
        Me.BeePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BeePicture.Location = New System.Drawing.Point(2, 2)
        Me.BeePicture.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BeePicture.Name = "BeePicture"
        Me.BeePicture.Size = New System.Drawing.Size(209, 124)
        Me.BeePicture.TabIndex = 0
        Me.BeePicture.Visible = False
        '
        'AppleLabel
        '
        Me.AppleLabel.AutoSize = True
        Me.AppleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppleLabel.Location = New System.Drawing.Point(38, 160)
        Me.AppleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AppleLabel.Name = "AppleLabel"
        Me.AppleLabel.Size = New System.Drawing.Size(113, 44)
        Me.AppleLabel.TabIndex = 1
        Me.AppleLabel.Text = "_pple"
        Me.AppleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ApplePicture
        '
        Me.ApplePicture.BackgroundImage = Global.Lab5Template.My.Resources.Resources.apple
        Me.ApplePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ApplePicture.Location = New System.Drawing.Point(-1, 2)
        Me.ApplePicture.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ApplePicture.Name = "ApplePicture"
        Me.ApplePicture.Size = New System.Drawing.Size(209, 124)
        Me.ApplePicture.TabIndex = 0
        '
        'F
        '
        Me.F.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.F.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetf
        Me.F.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.F.Location = New System.Drawing.Point(340, 476)
        Me.F.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(117, 86)
        Me.F.TabIndex = 12
        Me.F.UseVisualStyleBackColor = False
        '
        'EButton
        '
        Me.EButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnete
        Me.EButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EButton.Location = New System.Drawing.Point(184, 476)
        Me.EButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EButton.Name = "EButton"
        Me.EButton.Size = New System.Drawing.Size(117, 86)
        Me.EButton.TabIndex = 11
        Me.EButton.UseVisualStyleBackColor = False
        '
        'DButton
        '
        Me.DButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetd
        Me.DButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DButton.Location = New System.Drawing.Point(28, 476)
        Me.DButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DButton.Name = "DButton"
        Me.DButton.Size = New System.Drawing.Size(117, 86)
        Me.DButton.TabIndex = 10
        Me.DButton.UseVisualStyleBackColor = False
        '
        'CButton
        '
        Me.CButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetc
        Me.CButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CButton.Location = New System.Drawing.Point(340, 380)
        Me.CButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(117, 86)
        Me.CButton.TabIndex = 9
        Me.CButton.UseVisualStyleBackColor = False
        '
        'BButton
        '
        Me.BButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetb
        Me.BButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BButton.Location = New System.Drawing.Point(184, 380)
        Me.BButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BButton.Name = "BButton"
        Me.BButton.Size = New System.Drawing.Size(117, 86)
        Me.BButton.TabIndex = 8
        Me.BButton.UseVisualStyleBackColor = False
        '
        'AButton
        '
        Me.AButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magneta
        Me.AButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AButton.Location = New System.Drawing.Point(28, 380)
        Me.AButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AButton.Name = "AButton"
        Me.AButton.Size = New System.Drawing.Size(117, 86)
        Me.AButton.TabIndex = 7
        Me.AButton.UseVisualStyleBackColor = False
        '
        'AlphaBetParrotButton
        '
        Me.AlphaBetParrotButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.parrot
        Me.AlphaBetParrotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlphaBetParrotButton.Location = New System.Drawing.Point(3, 3)
        Me.AlphaBetParrotButton.Name = "AlphaBetParrotButton"
        Me.AlphaBetParrotButton.Size = New System.Drawing.Size(96, 100)
        Me.AlphaBetParrotButton.TabIndex = 4
        Me.AlphaBetParrotButton.Text = " "
        Me.AlphaBetParrotButton.UseVisualStyleBackColor = True
        '
        'Game5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.EButton)
        Me.Controls.Add(Me.DButton)
        Me.Controls.Add(Me.CButton)
        Me.Controls.Add(Me.BButton)
        Me.Controls.Add(Me.AButton)
        Me.Controls.Add(Me.ApplePage)
        Me.Controls.Add(Me.EmptyPage)
        Me.Controls.Add(Me.AlphaBetParrotButton)
        Me.Name = "Game5"
        Me.Size = New System.Drawing.Size(492, 574)
        Me.ApplePage.ResumeLayout(False)
        Me.ApplePage.PerformLayout()
        Me.BeePage.ResumeLayout(False)
        Me.BeePage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaBetParrotButton As System.Windows.Forms.Button
    Friend WithEvents EmptyPage As System.Windows.Forms.Panel
    Friend WithEvents ApplePage As System.Windows.Forms.Panel
    Friend WithEvents AppleLabel As System.Windows.Forms.Label
    Friend WithEvents ApplePicture As System.Windows.Forms.Panel
    Friend WithEvents BeePage As System.Windows.Forms.Panel
    Friend WithEvents BeeLabel As System.Windows.Forms.Label
    Friend WithEvents BeePicture As System.Windows.Forms.Panel
    Friend WithEvents AButton As System.Windows.Forms.Button
    Friend WithEvents BButton As System.Windows.Forms.Button
    Friend WithEvents CButton As System.Windows.Forms.Button
    Friend WithEvents F As System.Windows.Forms.Button
    Friend WithEvents EButton As System.Windows.Forms.Button
    Friend WithEvents DButton As System.Windows.Forms.Button

End Class
