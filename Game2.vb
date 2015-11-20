Public Class Game2
    Dim SAPI
    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim counter As Integer = CInt(Int((4 * Rnd()) + 1))

    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click


        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Hello! Welcome to the Keyboard game? look at the selected letter and press it on your keyboard.")
        SAPI.Speak("Press the Keyboard to begin")
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        parentFormRef.closeGame2()
    End Sub

    Public Sub New(ByRef parentForm As Main)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm

    End Sub

    Private Sub KeyboardPic_Click(sender As Object, e As EventArgs) Handles KeyboardPic.Click
        counter = CInt(Int((4 * Rnd()) + 1))

        If (counter = 1) Then
            LetterBox.Image = My.Resources.ablock
            SAPI.Speak("Can you find the letter A on the keyboard?")
        End If
        If (counter = 2) Then
            LetterBox.Image = My.Resources.c
            SAPI.Speak("Can you find the letter C on the keyboard?")
        End If
        If (counter = 3) Then
            LetterBox.Image = My.Resources.e
            SAPI.Speak("Can you find the letter E on the keyboard?")
        End If
        If (counter = 4) Then
            LetterBox.Image = My.Resources.f
            SAPI.Speak("Can you find the letter F on the keyboard?")
        End If

    End Sub
End Class
