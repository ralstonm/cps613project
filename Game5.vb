Public Class Game5

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim SAPI
    Const INFINITE = -1&
    Dim parrotHelpText

    Private Sub Game5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click
        'speak("Hello! Can you pick the letter that apple starts with?")
        parrotHelpText = "Hello! Can you pick the letter that apple starts with?"
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        parentFormRef.closeGame5()
    End Sub
    Private Sub AlphaBetParrotButton_Click(sender As Object, e As EventArgs) Handles AlphaBetParrotButton.Click
        speak(parrotHelpText)
    End Sub
    Private Sub speak(text As String)
        Debug.Print(text)
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(text)
        SAPI.WaitUntilDone(INFINITE)
    End Sub

    Public Sub New(ByRef parentForm As Main)
        'Custom constructor to keep a reference to the Main Form
        'Can call public methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm
    End Sub

    Private Sub CorrectAnswer()
        speak("Good job!")
        speak(parrotHelpText)
    End Sub
    Private Sub IncorrectAnswer()
        speak("Try again")
    End Sub

    Private Sub AButton_Click(sender As Object, e As EventArgs) Handles AButton.Click
<<<<<<< HEAD
        ' If ApplePage.Visible = True Then
        AppleLabel.Text = "Apple"
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Good job!")
        System.Threading.Thread.Sleep(1000)
        'ApplePage.Visible = False
        BeePage.Visible = True
        'End If
        parentFormRef.closeGame5()
=======
        If ApplePage.Visible = True Then
            AppleLabel.Text = "Apple"
        ElseIf ApplePage.Visible = False And CabPage.Visible = False Then
            IncorrectAnswer()
        End If
        If ApplePage.Visible = True And AppleLabel.Text = "Apple" Then
            parrotHelpText = "Can you spell Bee?"
            'CorrectAnswer()
            ApplePage.Visible = False
            BeePage.Visible = True
            BeePicture.Visible = True
            BeeLabel.Visible = True
        End If
>>>>>>> origin/master
    End Sub

    Private Sub BButton_Click(sender As Object, e As EventArgs) Handles BButton.Click
        If BeePage.Visible = True And BeeLabel.Text = "_ _ _" Then
            BeeLabel.Text = "B"
        End If
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        If CabPage.Visible = True And CabLabel.Text = "_ _ _" Then
            CabLabel.Text = "C"
        Else
            IncorrectAnswer()
        End If
    End Sub

    Private Sub DButton_Click(sender As Object, e As EventArgs) Handles DButton.Click

    End Sub

    Private Sub EButton_Click(sender As Object, e As EventArgs) Handles EButton.Click
        If BeePage.Visible = True And BeeLabel.Text = "B" Then
            BeeLabel.Text = "BE"
            Return
        End If
        If BeePage.Visible = True And BeeLabel.Text = "BE" Then
            BeeLabel.Text = "BEE"
            parrotHelpText = "Can you spell Cab?"
            'CorrectAnswer()
            ApplePage.Visible = False
            BeePage.Visible = False
            CabPage.Visible = True
            CabLabel.Visible = True
            CabPicture.Visible = True
        End If
    End Sub

    Private Sub F_Click(sender As Object, e As EventArgs) Handles FButton.Click

    End Sub
End Class
