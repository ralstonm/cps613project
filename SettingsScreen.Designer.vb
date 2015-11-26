<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsScreen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.customLabel = New System.Windows.Forms.Label()
        Me.customClear = New System.Windows.Forms.Button()
        Me.hardLabel = New System.Windows.Forms.Label()
        Me.mediumLabel = New System.Windows.Forms.Label()
        Me.easyLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.difficultySlider = New System.Windows.Forms.TrackBar()
        Me.dayPlus = New System.Windows.Forms.Button()
        Me.dayMinus = New System.Windows.Forms.Button()
        Me.sessionPlus = New System.Windows.Forms.Button()
        Me.sessionMinus = New System.Windows.Forms.Button()
        Me.dayLimit = New System.Windows.Forms.Label()
        Me.sessionLimit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.difficultySlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.customLabel)
        Me.Panel1.Controls.Add(Me.customClear)
        Me.Panel1.Controls.Add(Me.hardLabel)
        Me.Panel1.Controls.Add(Me.mediumLabel)
        Me.Panel1.Controls.Add(Me.easyLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.difficultySlider)
        Me.Panel1.Controls.Add(Me.dayPlus)
        Me.Panel1.Controls.Add(Me.dayMinus)
        Me.Panel1.Controls.Add(Me.sessionPlus)
        Me.Panel1.Controls.Add(Me.sessionMinus)
        Me.Panel1.Controls.Add(Me.dayLimit)
        Me.Panel1.Controls.Add(Me.sessionLimit)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 957)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(116, 20)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 60)
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 37)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Player 1"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(20, 20)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 88)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'customLabel
        '
        Me.customLabel.AutoSize = True
        Me.customLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customLabel.Location = New System.Drawing.Point(104, 297)
        Me.customLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.customLabel.Name = "customLabel"
        Me.customLabel.Size = New System.Drawing.Size(244, 33)
        Me.customLabel.TabIndex = 23
        Me.customLabel.Text = "Custom Settings"
        '
        'customClear
        '
        Me.customClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customClear.Location = New System.Drawing.Point(400, 289)
        Me.customClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.customClear.Name = "customClear"
        Me.customClear.Size = New System.Drawing.Size(112, 52)
        Me.customClear.TabIndex = 22
        Me.customClear.Text = "Clear"
        Me.customClear.UseVisualStyleBackColor = True
        '
        'hardLabel
        '
        Me.hardLabel.AutoSize = True
        Me.hardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardLabel.Location = New System.Drawing.Point(450, 334)
        Me.hardLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hardLabel.Name = "hardLabel"
        Me.hardLabel.Size = New System.Drawing.Size(91, 37)
        Me.hardLabel.TabIndex = 21
        Me.hardLabel.Text = "Hard"
        '
        'mediumLabel
        '
        Me.mediumLabel.AutoSize = True
        Me.mediumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumLabel.Location = New System.Drawing.Point(250, 334)
        Me.mediumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mediumLabel.Name = "mediumLabel"
        Me.mediumLabel.Size = New System.Drawing.Size(136, 37)
        Me.mediumLabel.TabIndex = 20
        Me.mediumLabel.Text = "Medium"
        '
        'easyLabel
        '
        Me.easyLabel.AutoSize = True
        Me.easyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.easyLabel.Location = New System.Drawing.Point(74, 334)
        Me.easyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.easyLabel.Name = "easyLabel"
        Me.easyLabel.Size = New System.Drawing.Size(91, 37)
        Me.easyLabel.TabIndex = 19
        Me.easyLabel.Text = "Easy"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(88, 398)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(426, 97)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Change Difficulty By Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'difficultySlider
        '
        Me.difficultySlider.BackColor = System.Drawing.SystemColors.ControlLight
        Me.difficultySlider.LargeChange = 1
        Me.difficultySlider.Location = New System.Drawing.Point(110, 260)
        Me.difficultySlider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.difficultySlider.Maximum = 3
        Me.difficultySlider.Minimum = 1
        Me.difficultySlider.Name = "difficultySlider"
        Me.difficultySlider.Size = New System.Drawing.Size(404, 69)
        Me.difficultySlider.TabIndex = 17
        Me.difficultySlider.Value = 1
        '
        'dayPlus
        '
        Me.dayPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.dayPlus.Location = New System.Drawing.Point(550, 666)
        Me.dayPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dayPlus.Name = "dayPlus"
        Me.dayPlus.Size = New System.Drawing.Size(63, 68)
        Me.dayPlus.TabIndex = 16
        Me.dayPlus.Text = "+"
        Me.dayPlus.UseVisualStyleBackColor = True
        '
        'dayMinus
        '
        Me.dayMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.dayMinus.Location = New System.Drawing.Point(357, 668)
        Me.dayMinus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dayMinus.Name = "dayMinus"
        Me.dayMinus.Size = New System.Drawing.Size(54, 68)
        Me.dayMinus.TabIndex = 15
        Me.dayMinus.Text = "-"
        Me.dayMinus.UseVisualStyleBackColor = True
        '
        'sessionPlus
        '
        Me.sessionPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.sessionPlus.Location = New System.Drawing.Point(220, 668)
        Me.sessionPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sessionPlus.Name = "sessionPlus"
        Me.sessionPlus.Size = New System.Drawing.Size(56, 68)
        Me.sessionPlus.TabIndex = 14
        Me.sessionPlus.Text = "+"
        Me.sessionPlus.UseVisualStyleBackColor = True
        '
        'sessionMinus
        '
        Me.sessionMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.sessionMinus.Location = New System.Drawing.Point(20, 668)
        Me.sessionMinus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sessionMinus.Name = "sessionMinus"
        Me.sessionMinus.Size = New System.Drawing.Size(54, 68)
        Me.sessionMinus.TabIndex = 13
        Me.sessionMinus.Text = "-"
        Me.sessionMinus.UseVisualStyleBackColor = True
        '
        'dayLimit
        '
        Me.dayLimit.AutoSize = True
        Me.dayLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayLimit.Location = New System.Drawing.Point(420, 691)
        Me.dayLimit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dayLimit.Name = "dayLimit"
        Me.dayLimit.Size = New System.Drawing.Size(87, 32)
        Me.dayLimit.TabIndex = 12
        Me.dayLimit.Text = "None"
        '
        'sessionLimit
        '
        Me.sessionLimit.AutoSize = True
        Me.sessionLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessionLimit.Location = New System.Drawing.Point(82, 689)
        Me.sessionLimit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sessionLimit.Name = "sessionLimit"
        Me.sessionLimit.Size = New System.Drawing.Size(87, 32)
        Me.sessionLimit.TabIndex = 11
        Me.sessionLimit.Text = "None"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 617)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 33)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Per Session"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(429, 617)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 33)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Per Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(461, 82)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DIFFICULTY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 517)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(469, 82)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TIME LIMITS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 766)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 82)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "VOLUME"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(156, 1137)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 26)
        Me.TextBox2.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Lab5Template.My.Resources.Resources.fullaudio
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Location = New System.Drawing.Point(537, 826)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 106)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Lab5Template.My.Resources.Resources.muteicon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(0, 826)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 100)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.White
        Me.TrackBar1.Location = New System.Drawing.Point(124, 857)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(404, 69)
        Me.TrackBar1.TabIndex = 0
        '
        'SettingsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SettingsScreen"
        Me.Size = New System.Drawing.Size(633, 957)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.difficultySlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dayPlus As System.Windows.Forms.Button
    Friend WithEvents dayMinus As System.Windows.Forms.Button
    Friend WithEvents sessionPlus As System.Windows.Forms.Button
    Friend WithEvents sessionMinus As System.Windows.Forms.Button
    Friend WithEvents dayLimit As System.Windows.Forms.Label
    Friend WithEvents sessionLimit As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents hardLabel As System.Windows.Forms.Label
    Friend WithEvents mediumLabel As System.Windows.Forms.Label
    Friend WithEvents easyLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents difficultySlider As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents customLabel As System.Windows.Forms.Label
    Friend WithEvents customClear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
