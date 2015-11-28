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
        Me.AppleLabel = New System.Windows.Forms.Label()
        Me.ApplePicture = New System.Windows.Forms.Panel()
        Me.FButton = New System.Windows.Forms.Button()
        Me.EButton = New System.Windows.Forms.Button()
        Me.DButton = New System.Windows.Forms.Button()
        Me.CButton = New System.Windows.Forms.Button()
        Me.BButton = New System.Windows.Forms.Button()
        Me.AButton = New System.Windows.Forms.Button()
        Me.AlphaBetParrotButton = New System.Windows.Forms.Button()
        Me.BeePage = New System.Windows.Forms.Panel()
        Me.BeeLabel = New System.Windows.Forms.Label()
        Me.BeePicture = New System.Windows.Forms.Panel()
        Me.CabLabel = New System.Windows.Forms.Label()
        Me.CabPicture = New System.Windows.Forms.Panel()
        Me.CabPage = New System.Windows.Forms.Panel()
        Me.ApplePage.SuspendLayout()
        Me.BeePage.SuspendLayout()
        Me.CabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmptyPage
        '
        Me.EmptyPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmptyPage.Location = New System.Drawing.Point(24, 128)
        Me.EmptyPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmptyPage.Name = "EmptyPage"
        Me.EmptyPage.Size = New System.Drawing.Size(183, 268)
        Me.EmptyPage.TabIndex = 5
        '
        'ApplePage
        '
        Me.ApplePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApplePage.Controls.Add(Me.AppleLabel)
        Me.ApplePage.Controls.Add(Me.ApplePicture)
        Me.ApplePage.Location = New System.Drawing.Point(210, 128)
        Me.ApplePage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ApplePage.Name = "ApplePage"
        Me.ApplePage.Size = New System.Drawing.Size(183, 268)
        Me.ApplePage.TabIndex = 6
        '
        'AppleLabel
        '
        Me.AppleLabel.AutoSize = True
        Me.AppleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppleLabel.Location = New System.Drawing.Point(33, 174)
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
        Me.ApplePicture.Size = New System.Drawing.Size(179, 135)
        Me.ApplePicture.TabIndex = 0
        '
        'FButton
        '
        Me.FButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FButton.Image = Global.Lab5Template.My.Resources.Resources.magnetf
        Me.FButton.Location = New System.Drawing.Point(291, 515)
        Me.FButton.Name = "FButton"
        Me.FButton.Size = New System.Drawing.Size(100, 93)
        Me.FButton.TabIndex = 12
        Me.FButton.UseVisualStyleBackColor = False
        '
        'EButton
        '
        Me.EButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnete
        Me.EButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EButton.Location = New System.Drawing.Point(158, 515)
        Me.EButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EButton.Name = "EButton"
        Me.EButton.Size = New System.Drawing.Size(100, 93)
        Me.EButton.TabIndex = 11
        Me.EButton.UseVisualStyleBackColor = False
        '
        'DButton
        '
        Me.DButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetd
        Me.DButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DButton.Location = New System.Drawing.Point(24, 515)
        Me.DButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DButton.Name = "DButton"
        Me.DButton.Size = New System.Drawing.Size(100, 93)
        Me.DButton.TabIndex = 10
        Me.DButton.UseVisualStyleBackColor = False
        '
        'CButton
        '
        Me.CButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetc
        Me.CButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CButton.Location = New System.Drawing.Point(291, 411)
        Me.CButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(100, 93)
        Me.CButton.TabIndex = 9
        Me.CButton.UseVisualStyleBackColor = False
        '
        'BButton
        '
        Me.BButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magnetb
        Me.BButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BButton.Location = New System.Drawing.Point(158, 411)
        Me.BButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BButton.Name = "BButton"
        Me.BButton.Size = New System.Drawing.Size(100, 93)
        Me.BButton.TabIndex = 8
        Me.BButton.UseVisualStyleBackColor = False
        '
        'AButton
        '
        Me.AButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.magneta
        Me.AButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AButton.Location = New System.Drawing.Point(24, 411)
        Me.AButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AButton.Name = "AButton"
        Me.AButton.Size = New System.Drawing.Size(100, 93)
        Me.AButton.TabIndex = 7
        Me.AButton.UseVisualStyleBackColor = False
        '
        'AlphaBetParrotButton
        '
        Me.AlphaBetParrotButton.BackgroundImage = Global.Lab5Template.My.Resources.Resources.parrot
        Me.AlphaBetParrotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlphaBetParrotButton.Location = New System.Drawing.Point(337, 3)
        Me.AlphaBetParrotButton.Name = "AlphaBetParrotButton"
        Me.AlphaBetParrotButton.Size = New System.Drawing.Size(82, 83)
        Me.AlphaBetParrotButton.TabIndex = 4
        Me.AlphaBetParrotButton.Text = " "
        Me.AlphaBetParrotButton.UseVisualStyleBackColor = True
        '
        'BeePage
        '
        Me.BeePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BeePage.Controls.Add(Me.BeeLabel)
        Me.BeePage.Controls.Add(Me.BeePicture)
        Me.BeePage.Location = New System.Drawing.Point(210, 128)
        Me.BeePage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BeePage.Name = "BeePage"
        Me.BeePage.Size = New System.Drawing.Size(183, 268)
        Me.BeePage.TabIndex = 7
        Me.BeePage.Visible = False
        '
        'BeeLabel
        '
        Me.BeeLabel.AutoSize = True
        Me.BeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeeLabel.Location = New System.Drawing.Point(33, 174)
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
        Me.BeePicture.Location = New System.Drawing.Point(3, 3)
        Me.BeePicture.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BeePicture.Name = "BeePicture"
        Me.BeePicture.Size = New System.Drawing.Size(179, 135)
        Me.BeePicture.TabIndex = 0
        Me.BeePicture.Visible = False
        '
        'CabLabel
        '
        Me.CabLabel.AutoSize = True
        Me.CabLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CabLabel.Location = New System.Drawing.Point(33, 174)
        Me.CabLabel.Name = "CabLabel"
        Me.CabLabel.Size = New System.Drawing.Size(103, 44)
        Me.CabLabel.TabIndex = 1
        Me.CabLabel.Text = "_ _ _"
        Me.CabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CabLabel.Visible = False
        '
        'CabPicture
        '
        Me.CabPicture.BackgroundImage = Global.Lab5Template.My.Resources.Resources.cab
        Me.CabPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CabPicture.Location = New System.Drawing.Point(3, 3)
        Me.CabPicture.Name = "CabPicture"
        Me.CabPicture.Size = New System.Drawing.Size(179, 135)
        Me.CabPicture.TabIndex = 0
        Me.CabPicture.Visible = False
        '
        'CabPage
        '
        Me.CabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CabPage.Controls.Add(Me.CabLabel)
        Me.CabPage.Controls.Add(Me.CabPicture)
        Me.CabPage.Location = New System.Drawing.Point(210, 128)
        Me.CabPage.Name = "CabPage"
        Me.CabPage.Size = New System.Drawing.Size(183, 268)
        Me.CabPage.TabIndex = 8
        Me.CabPage.Visible = False
        '
        'Game5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CabPage)
        Me.Controls.Add(Me.BeePage)
        Me.Controls.Add(Me.FButton)
        Me.Controls.Add(Me.EButton)
        Me.Controls.Add(Me.DButton)
        Me.Controls.Add(Me.CButton)
        Me.Controls.Add(Me.BButton)
        Me.Controls.Add(Me.AButton)
        Me.Controls.Add(Me.ApplePage)
        Me.Controls.Add(Me.EmptyPage)
        Me.Controls.Add(Me.AlphaBetParrotButton)
        Me.Name = "Game5"
        Me.Size = New System.Drawing.Size(422, 622)
        Me.ApplePage.ResumeLayout(False)
        Me.ApplePage.PerformLayout()
        Me.BeePage.ResumeLayout(False)
        Me.BeePage.PerformLayout()
        Me.CabPage.ResumeLayout(False)
        Me.CabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaBetParrotButton As System.Windows.Forms.Button
    Friend WithEvents EmptyPage As System.Windows.Forms.Panel
    Friend WithEvents ApplePage As System.Windows.Forms.Panel
    Friend WithEvents AppleLabel As System.Windows.Forms.Label
    Friend WithEvents ApplePicture As System.Windows.Forms.Panel
    Friend WithEvents AButton As System.Windows.Forms.Button
    Friend WithEvents BButton As System.Windows.Forms.Button
    Friend WithEvents CButton As System.Windows.Forms.Button
    Friend WithEvents FButton As System.Windows.Forms.Button
    Friend WithEvents EButton As System.Windows.Forms.Button
    Friend WithEvents DButton As System.Windows.Forms.Button
    Friend WithEvents BeePage As System.Windows.Forms.Panel
    Friend WithEvents BeeLabel As System.Windows.Forms.Label
    Friend WithEvents BeePicture As System.Windows.Forms.Panel
    Friend WithEvents CabLabel As System.Windows.Forms.Label
    Friend WithEvents CabPicture As System.Windows.Forms.Panel
    Friend WithEvents CabPage As System.Windows.Forms.Panel

End Class
