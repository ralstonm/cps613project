Public Class Game2
    Dim SAPI
    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim counter As Integer = CInt(Int((4 * Rnd()) + 1))
    Dim keyToFind

    'temp change
    Dim end2 As Integer = 0
    Dim score As Integer = 0



    Public Sub checkKey(keyCode As Object)
        If keyCode = keyToFind Then
            SAPI.Speak("That's the correct key!")
            score = score + 1

            If (score = 7) Then
                SAPI.Speak("Congratulations! You are a keyboard master")
                parentFormRef.closeGame2()
            Else
                InitializeGame()
            End If

        Else
                SAPI.Speak("That's not the correct key!")
        End If

    End Sub

    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB + 45, parentFormRef.yOffsetB)



        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click


        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Hello! Welcome to the Keyboard game? look at the selected letter and press it on your keyboard.")
        InitializeGame()

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

    Private Sub InitializeGame()
        If end2 = 3 Then
            parentFormRef.closeGame2()
        End If
        Randomize()
        counter = CInt(Int((15 * Rnd()) + 1))

        If (counter = 1) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.ablock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter A on the keyboard?")
            keyToFind = Keys.A
            end2 = end2 + 1
        End If
        If (counter = 2) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.cblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter C on the keyboard?")
            keyToFind = Keys.C
            end2 = end2 + 1
        End If
        If (counter = 3) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.eblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter E on the keyboard?")
            keyToFind = Keys.E
            end2 = end2 + 1
        End If
        If (counter = 4) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.fblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter F on the keyboard?")
            keyToFind = Keys.F
            end2 = end2 + 1
        End If
        If (counter = 5) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.hblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter H on the keyboard?")
            keyToFind = Keys.H
            end2 = end2 + 1
        End If
        If (counter = 6) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.hblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter I on the keyboard?")
            keyToFind = Keys.I
            end2 = end2 + 1
        End If
        If (counter = 7) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.jblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter J on the keyboard?")
            keyToFind = Keys.J
            end2 = end2 + 1
        End If
        If (counter = 8) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.kblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter k on the keyboard?")
            keyToFind = Keys.K
            end2 = end2 + 1
        End If
        If (counter = 9) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.lblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter L on the keyboard?")
            keyToFind = Keys.L
            end2 = end2 + 1
        End If
        If (counter = 10) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.mblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter M on the keyboard?")
            keyToFind = Keys.M
            end2 = end2 + 1
        End If
        If (counter = 11) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.nblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter N on the keyboard?")
            keyToFind = Keys.N
            end2 = end2 + 1
        End If
        If (counter = 12) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.oblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter O on the keyboard?")
            keyToFind = Keys.O
            end2 = end2 + 1
        End If
        If (counter = 13) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.pblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter P on the keyboard?")
            keyToFind = Keys.P
            end2 = end2 + 1
        End If
        If (counter = 14) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.qblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter Q on the keyboard?")
            keyToFind = Keys.Q
            end2 = end2 + 1
        End If
        If (counter = 15) And (Not end2 = 3) Then
            LetterBox.Image = My.Resources.rblock
            LetterBox.SizeMode = PictureBoxSizeMode.StretchImage
            SAPI.Speak("Can you find the letter R on the keyboard?")
            keyToFind = Keys.R
            end2 = end2 + 1
        End If




    End Sub

    Private Sub KeyboardPic_Click(sender As Object, e As EventArgs) Handles KeyboardPic.Click
        InitializeGame()

    End Sub


    
End Class
