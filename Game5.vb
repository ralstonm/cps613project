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
        parrotHelpText = "Hello! Can you pick the letter that apple starts with?"
        speak(parrotHelpText)
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
    Private Sub AppleCorrect()
        parrotHelpText = "Can you spell Bee?"
        CorrectAnswer()
        ApplePage.Visible = False
        BeePage.Visible = True
        BeePicture.Visible = True
        BeeLabel.Visible = True
    End Sub
    Private Sub BeeCorrect()
        parrotHelpText = "Can you spell Cab?"
        CorrectAnswer()
        ApplePage.Visible = False
        BeePage.Visible = False
        CabPage.Visible = True
        CabLabel.Visible = True
        CabPicture.Visible = True
    End Sub
    Private Sub CabCorrect()
        My.Computer.Audio.Play(My.Resources.applus, AudioPlayMode.Background)
        parentFormRef.closeGame5()
    End Sub

    Private Sub AButton_Click(sender As Object, e As EventArgs) Handles AButton.Click

        If ApplePage.Visible = False And CabPage.Visible = False Then
            IncorrectAnswer()
        End If
        If ApplePage.Visible = True Then
            AppleLabel.Text = "Apple"
            AppleCorrect()
        End If
        If CabPage.Visible = True Then
            If CabLabel.Text = "_ _ _" Then
                CabLabel.Text = "_ A _"
                Return
            End If
            If CabLabel.Text = "C _ _" Then
                CabLabel.Text = "C A _"
                Return
            End If
            If CabLabel.Text = "_ A _" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "_ _ B" Then
                CabLabel.Text = "_ A B"
                Return
            End If
            If CabLabel.Text = "C A _" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "_ A B" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "C _ B" Then
                CabLabel.Text = "C A B"
                CabCorrect()
            End If
        End If
    End Sub

    Private Sub BButton_Click(sender As Object, e As EventArgs) Handles BButton.Click
        If BeePage.Visible = False And CabPage.Visible = False Then
            IncorrectAnswer()
        End If
        If BeePage.Visible = True Then
            If BeeLabel.Text = "_ _ _" Then
                BeeLabel.Text = "B _ _"
                Return
            End If
            If BeeLabel.Text = "B _ _" Then
                IncorrectAnswer()
            End If
            If BeeLabel.Text = "B E _" Then
                IncorrectAnswer()
            End If
            If BeeLabel.Text = "_ E _" Then
                BeeLabel.Text = "B E _"
            End If
            If BeeLabel.Text = "_ E E" Then
                BeeLabel.Text = "B E E"
                BeeCorrect()
            End If
        End If
        If CabPage.Visible = True Then
            If CabLabel.Text = "_ _ _" Then
                CabLabel.Text = "_ _ B"
                Return
            End If
            If CabLabel.Text = "C _ _" Then
                CabLabel.Text = "C _ B"
                Return
            End If
            If CabLabel.Text = "_ A _" Then
                CabLabel.Text = "_ A B"
                Return
            End If
            If CabLabel.Text = "_ _ B" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "C A _" Then
                CabLabel.Text = "C A B"
                CabCorrect()
            End If
            If CabLabel.Text = "_ A B" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "C _ B" Then
                IncorrectAnswer()
            End If
        End If
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        If CabPage.Visible = True Then
            If CabLabel.Text = "_ _ _" Then
                CabLabel.Text = "C _ _"
                Return
            End If
            If CabLabel.Text = "C _ _" Then
                CabLabel.Text = "C _ B"
                Return
            End If
            If CabLabel.Text = "_ A _" Then
                CabLabel.Text = "_ A B"
                Return
            End If
            If CabLabel.Text = "_ _ B" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "C A _" Then
                CabLabel.Text = "C A B"
                CabCorrect()
            End If
            If CabLabel.Text = "_ A B" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "C _ B" Then
                IncorrectAnswer()
            End If
        Else
            IncorrectAnswer()
        End If
    End Sub

    Private Sub DButton_Click(sender As Object, e As EventArgs) Handles DButton.Click
        IncorrectAnswer()
    End Sub

    Private Sub EButton_Click(sender As Object, e As EventArgs) Handles EButton.Click
        If BeePage.Visible = False Then
            IncorrectAnswer()
        End If
        If BeePage.Visible = True And BeeLabel.Text = "_ _ _" Then
            BeeLabel.Text = "_ E _"
            Return
        End If
        If BeePage.Visible = True And BeeLabel.Text = "B _ _" Then
            BeeLabel.Text = "B E _"
            Return
        End If
        If BeePage.Visible = True And BeeLabel.Text = "_ E _" Then
            BeeLabel.Text = "_ E E"
            Return
        End If
        If BeePage.Visible = True And BeeLabel.Text = "B E _" Then
            BeeLabel.Text = "B E E"
            BeeCorrect()
        End If
    End Sub

    Private Sub F_Click(sender As Object, e As EventArgs) Handles FButton.Click
        IncorrectAnswer()
    End Sub
End Class
