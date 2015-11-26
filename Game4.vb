Public Class Game4

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim resultsScreen As SharedResults
    Dim SAPI
    Dim counter As Integer


    Private Sub Game4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click

        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Hello! Can you say the sound that, A, makes? Press the microphone when you want to talk.")

        counter = 0
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        parentFormRef.closeGame4()
    End Sub

    Public Sub New(ByRef parentForm As Main)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm

    End Sub

    Private Sub MicrophoneButton_Click(sender As Object, e As EventArgs) Handles MicrophoneButton.Click
        'I have no idea why this doesn't work
        RecordingPictureBox.Visible = True
        System.Threading.Thread.Sleep(1000)
        SAPI.Speak("Good job!")
        'It should show a red circle when the microphone is "listening" but it doesn't
        RecordingPictureBox.Visible = False
        counter = counter + 1
        If (counter = 1) Then SAPI.Speak("Can you say the sound that, B, makes?")
        If (counter = 2) Then SAPI.Speak("Can you say the sound that, C, makes?")
        If (counter = 3) Then
            Me.PictureBoxA.Visible = False
            Me.PictureBoxB.Visible = False
            Me.PictureBoxC.Visible = False

            Me.PictureBoxD.Visible = True
            Me.PictureBoxE.Visible = True
            Me.PictureBoxF.Visible = True
            SAPI.Speak("Can you say the sound that, E, makes?")
        End If
        If (counter = 4) Then SAPI.Speak("Can you say the sound that, D, makes?")
        If (counter = 5) Then SAPI.Speak("Can you say the sound that, F, makes?")
        If (counter = 6) Then
            My.Computer.Audio.Play(My.Resources.applus, AudioPlayMode.Background)
            parentFormRef.closeGame4()
        End If
    End Sub
    Private Sub endGame()
        resultsScreen = New SharedResults()
        Me.Controls.Add(resultsScreen)
        resultsScreen.BringToFront()
        If (parentFormRef.soundVolume <> 0) Then
            My.Computer.Audio.Play(My.Resources.applus, AudioPlayMode.Background)
        End If
        AddHandler resultsScreen.Button1.Click, AddressOf Me.backButton_Click
    End Sub
End Class
