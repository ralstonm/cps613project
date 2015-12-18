Public Class Game5

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim SAPI
    Const INFINITE = -1&
    Dim parrotHelpText

    Dim tmepd

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
        If (parentFormRef.soundVolume = 0) Then
            Return
        End If
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
        Threading.Thread.Sleep(500)
        My.Computer.Audio.Play(My.Resources.applus, AudioPlayMode.Background)
        parentFormRef.closeGame5()
    End Sub

    Sub Pause(ByVal milliseconds As Long)
        If milliseconds <= 0 Then Return
        Dim sw As New Stopwatch()
        sw.Start()
        Dim i As Long = 0
        Do
            If i Mod 50000 = 0 Then ' Check the timer every 50,000th iteration
                sw.Stop()
                If sw.ElapsedMilliseconds >= milliseconds Then
                    Exit Do
                Else
                    sw.Start()
                End If
            End If
            i += 1
        Loop
    End Sub

    Private Sub AButton_Click(sender As Object, e As EventArgs) Handles AButton.Click
        If ApplePage.Visible = False And CabPage.Visible = False Then
            IncorrectAnswer()
        End If
        If ApplePage.Visible = True Then



            AppleLabel.Text = "apple"

            AppleCorrect()


        End If
        If CabPage.Visible = True Then
            If CabLabel.Text = "_ _ _" Then
                CabLabel.Text = "_ s _"
                Return
            End If
            If CabLabel.Text = "c _ _" Then
                CabLabel.Text = "c a _"
                Return
            End If
            If CabLabel.Text = "_ a _" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "_ _ b" Then
                CabLabel.Text = "_ a b"
                Return
            End If
            If CabLabel.Text = "c a _" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "_ a b" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "c _ b" Then
                CabLabel.Text = "c a b"
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
                BeeLabel.Text = "b _ _"
                Return
            End If
            If BeeLabel.Text = "b _ _" Then
                IncorrectAnswer()
            End If
            If BeeLabel.Text = "b e _" Then
                IncorrectAnswer()
            End If
            If BeeLabel.Text = "_ e _" Then
                BeeLabel.Text = "b e _"
            End If
            If BeeLabel.Text = "_ e e" Then
                BeeLabel.Text = "b e e"
                BeeCorrect()
            End If
        End If
        If CabPage.Visible = True Then
            If CabLabel.Text = "_ _ _" Then
                CabLabel.Text = "_ _ b"
                Return
            End If
            If CabLabel.Text = "c _ _" Then
                CabLabel.Text = "c _ b"
                Return
            End If
            If CabLabel.Text = "_ a _" Then
                CabLabel.Text = "_ a b"
                Return
            End If
            If CabLabel.Text = "_ _ b" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "c a _" Then
                CabLabel.Text = "c a b"
                CabCorrect()
            End If
            If CabLabel.Text = "_ a b" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "c _ b" Then
                IncorrectAnswer()
            End If
        End If
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        If CabPage.Visible = True Then
            If CabLabel.Text = "_ _ _" Then
                CabLabel.Text = "c _ _"
                Return
            End If
            If CabLabel.Text = "c _ _" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "_ a _" Then
                CabLabel.Text = "c a _"
                Return
            End If
            If CabLabel.Text = "_ _ b" Then
                CabLabel.Text = "c _ b"
                Return
            End If
            If CabLabel.Text = "c a _" Then
                IncorrectAnswer()
            End If
            If CabLabel.Text = "_ a b" Then
                CabLabel.Text = "c a b"
                CabCorrect()
            End If
            If CabLabel.Text = "c _ b" Then
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
            BeeLabel.Text = "_ e _"
            Return
        End If
        If BeePage.Visible = True And BeeLabel.Text = "b _ _" Then
            BeeLabel.Text = "b e _"
            Return
        End If
        If BeePage.Visible = True And BeeLabel.Text = "_ e _" Then
            BeeLabel.Text = "_ e e"
            Return
        End If
        If BeePage.Visible = True And BeeLabel.Text = "b e _" Then
            BeeLabel.Text = "b e e"
            BeeCorrect()
        End If
    End Sub

    Private Sub FButton_Click(sender As Object, e As EventArgs) Handles FButton.Click
        IncorrectAnswer()
    End Sub
End Class
