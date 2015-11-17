Public Class SettingsScreen

    Public parentFormRef As Main2
    Dim backButton As SharedBackButton
    Dim mySettings_Advanced As Settings_Advanced


    Dim times = New String() {"No Limit", "10 min", "20 min", "30 min", "45 min", "60 min"}

    Dim sessionIndex As Integer
    Dim dayIndex As Integer

    Private Sub SettingsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click

        'Set the value of the trackbar to the parent's sound volume
        TrackBar1.Value = parentFormRef.soundVolume

        customLabel.Hide()
        customClear.Hide()

        If parentFormRef.difficulty1 = parentFormRef.difficulty2 And
        parentFormRef.difficulty2 = parentFormRef.difficulty3 And
            parentFormRef.difficulty3 = parentFormRef.difficulty4 And
            parentFormRef.difficulty4 = parentFormRef.difficulty5 Then

            difficultySlider.Value = parentFormRef.difficulty1

        Else

            handleAdvanced()


        End If



        sessionIndex = 0
        dayIndex = 0

        sessionLimit.Text = times(sessionIndex)
        dayLimit.Text = times(dayIndex)

        


    End Sub

    Public Sub New(ByRef parentForm As Main2)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm

    End Sub

    Public Sub handleAdvanced()

        easyLabel.Hide()
        mediumLabel.Hide()
        hardLabel.Hide()
        difficultySlider.Hide()
        customLabel.Show()
        customClear.Show()

    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        closeSettingsAdvanced()
        parentFormRef.closeSettings()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        'Set the parent's sound volume to the trackbar
        parentFormRef.soundVolume = TrackBar1.Value
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles sessionLimit.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sessionMinus.Click
        sessionIndex = sessionIndex - 1
        If sessionIndex < 0 Then
            sessionIndex = 0
        End If
        sessionLimit.Text = times(sessionIndex)

    End Sub

    Private Sub sessionPlus_Click(sender As Object, e As EventArgs) Handles sessionPlus.Click
        sessionIndex = sessionIndex + 1
        If sessionIndex >= times.Length Then
            sessionIndex = times.Length - 1
        End If
        sessionLimit.Text = times(sessionIndex)

    End Sub

    Private Sub dayMinus_Click(sender As Object, e As EventArgs) Handles dayMinus.Click
        dayIndex = dayIndex - 1
        If dayIndex < 0 Then
            dayIndex = 0
        End If
        dayLimit.Text = times(dayIndex)

    End Sub

    Private Sub dayPlus_Click(sender As Object, e As EventArgs) Handles dayPlus.Click
        dayIndex = dayIndex + 1
        If dayIndex >= times.Length Then
            dayIndex = times.Length - 1
        End If
        dayLimit.Text = times(dayIndex)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles customLabel.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        mySettings_Advanced = New Settings_Advanced(Me)
        Me.Controls.Add(mySettings_Advanced)
        mySettings_Advanced.Location = New Point(0, parentFormRef.yOffset - 20)
        mySettings_Advanced.BringToFront()
    End Sub

    Public Sub closeSettingsAdvanced()

        If (Not (mySettings_Advanced Is Nothing)) Then

            Me.Controls.Remove(mySettings_Advanced)

            'Dispose of the object

            mySettings_Advanced.Dispose()
            'Dereference the object
            mySettings_Advanced = Nothing
        End If
    End Sub

    Private Sub customClear_Click(sender As Object, e As EventArgs) Handles customClear.Click
        easyLabel.Show()
        mediumLabel.Show()
        hardLabel.Show()
        difficultySlider.Show()
        customLabel.Hide()
        customClear.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub difficultySlider_Scroll(sender As Object, e As EventArgs) Handles difficultySlider.Scroll

        parentFormRef.difficulty1 = difficultySlider.Value
        parentFormRef.difficulty2 = difficultySlider.Value
        parentFormRef.difficulty3 = difficultySlider.Value
        parentFormRef.difficulty4 = difficultySlider.Value
        parentFormRef.difficulty5 = difficultySlider.Value

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
