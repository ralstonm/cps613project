Public Class Game1

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim mySettings_Advanced As Settings_Advanced
    Dim parrotHelpText
    Dim letterRange = 3

    Dim currentGameState

    Dim currentGameType

    Dim gamesToPlay()


    Dim letterList() As String = {"a", "b", "c"}
    Dim letterPicture() As String = {"apple", "bee", "cat"}
    Dim letterResourceList() As String = {"a1", "b1", "c"}
    Dim letterResourceName() As String = {"apple", "bee", "cat"}

    Dim picBoxArray()



    Public Sub New(ByRef parentForm As Main)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm

    End Sub

    Private Sub AlphaBetParrotButton_Click(sender As Object, e As EventArgs) Handles AlphaBetParrotButton.Click
        speak(parrotHelpText)
    End Sub
    Private Sub alphabetGamePanel_Paint(sender As Object, e As PaintEventArgs) Handles alphabetGamePanel.Paint

    End Sub

    Private Function randomNumber(n As Integer) As Integer
        Return CInt(Math.Ceiling(Rnd() * n)) - 1
    End Function

    Private Sub speak(text As String)
        Debug.Print(text)
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(text)
    End Sub

    Private Sub generateGames()

        Dim numOfGames As Integer

        If (parentFormRef.difficulty1 = 1) Then
            numOfGames = 5
        ElseIf (parentFormRef.difficulty2 = 1) Then
            numOfGames = 7
        Else
            numOfGames = 10
        End If

        Debug.Print("Generating games " & numOfGames)

        ReDim gamesToPlay(numOfGames)

        For counter As Integer = 0 To numOfGames
            gamesToPlay(counter) = randomNumber(letterRange)

            Debug.Print("Playing with " & gamesToPlay(counter))
        Next

        currentGameState = 0

        startGame()

    End Sub

    Private Sub startGame()

        Dim letter = letterList(gamesToPlay(currentGameState))

        If currentGameType = 0 Then
            parrotHelpText = "Can you find the letter, " + letter + "?"
        Else
            parrotHelpText = "Can you find the letter that " + letterResourceName(gamesToPlay(currentGameState)) + " starts with?"
        End If

        Dim numOfPics

        If (parentFormRef.difficulty1 = 1) Then
            numOfPics = 5

        ElseIf (parentFormRef.difficulty2 = 1) Then
            numOfPics = 7

        Else
            numOfPics = 10

        End If

        ReDim picBoxArray(numOfPics - 1)

        For counter = 0 To (numOfPics - 2)

            Dim randoLetter = 0

            Do While randoLetter = gamesToPlay(currentGameState)

                randoLetter = randomNumber(letterRange)

            Loop

            Dim tempPic As PictureBox = New PictureBox()

            tempPic.BorderStyle = Windows.Forms.BorderStyle.Fixed3D

            tempPic.Size = New Size(50, 75)

            tempPic.BackgroundImage = My.Resources.ResourceManager.GetObject(letterResourceList(randoLetter))

            tempPic.BackgroundImageLayout = ImageLayout.Stretch

            AddHandler tempPic.Click, AddressOf Me.wrongButton_Click

            picBoxArray(counter) = tempPic

        Next

        Dim tempPic2 As PictureBox = New PictureBox()

        tempPic2.BorderStyle = Windows.Forms.BorderStyle.Fixed3D

        tempPic2.Size = New Size(50, 75)

        tempPic2.BackgroundImage = My.Resources.ResourceManager.GetObject(letterResourceList(gamesToPlay(currentGameState)))

        tempPic2.BackgroundImageLayout = ImageLayout.Stretch

        AddHandler tempPic2.Click, AddressOf Me.rightButton_Click

        picBoxArray(numOfPics - 1) = tempPic2

        Debug.Print(picBoxArray(numOfPics - 1).Location.X)

        If (currentGameType = 1) Then
            pictureBook.Visible = True
            storyBookImage.Visible = True
            storyBookImage.BackgroundImage = My.Resources.ResourceManager.GetObject(letterResourceName(gamesToPlay(currentGameState)))
            storyBookImage.BackgroundImageLayout = ImageLayout.Stretch
            storyBookImage.BringToFront()

        Else

        End If

        placeButtons()


    End Sub

    Private Sub placeButtons()

        For counter = 0 To (picBoxArray.Length - 1)

            Dim goodPlacement = False



            While Not goodPlacement

                Dim x = randomNumber(buttonPlaces.Width)
                Dim y = randomNumber(buttonPlaces.Height)

                If counter = 0 Then
                    goodPlacement = True
                End If

                Debug.Print("Testing " & x)

                Me.buttonPlaces.Controls().Add(picBoxArray(counter))

                picBoxArray(counter).Location = New Point(x, y)

                For counter2 = 0 To (counter - 1)

                    If Not picBoxArray(counter2).bounds.intersectsWith(picBoxArray(counter).bounds) Then

                        Debug.Print("Found good placement")
                        goodPlacement = True
                    Else
                        Debug.Print("Found bad placement")

                    End If

                Next


            End While

            picBoxArray(counter).bringToFront()

        Next

        speak(parrotHelpText)
    End Sub

    Private Sub endCurrentGame()

        For counter = 0 To (picBoxArray.Length - 1)

            Dim content = picBoxArray(counter)
            Me.Controls.Remove(content)
            content.Dispose()

        Next

        pictureBook.Visible = False
        storyBookImage.Visible = False
        storyBookImage.Parent = pictureBook

        gameState()

    End Sub

    Private Sub gameState()
        If (currentGameState = gamesToPlay.Length - 1) Then
            endGame()
        Else
            currentGameState = currentGameState + 1

            If (currentGameState > (gamesToPlay.Length / 2)) Then
                currentGameType = 1

            Else
                currentGameType = 1
            End If
            startGame()
        End If

    End Sub

    Private Sub endGame()

        speak("Good Job!")

        parentFormRef.closeGame1()

    End Sub

    Private Sub Game1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click

        pictureBook.Visible = False

        speak("Hi! Let's see if you can recognize letters!")

        generateGames()





    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        parentFormRef.closeGame1()
    End Sub

    Private Sub rightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        speak("That's right!")

        If currentGameType = 0 Then
            speak("That's the letter ," + letterList(gamesToPlay(currentGameState)))
        Else
            speak(letterList(gamesToPlay(currentGameState)) + ", is for " + letterResourceName(gamesToPlay(currentGameState)))
        End If

        endCurrentGame()

    End Sub

    Private Sub wrongButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        speak("That's not the right letter!")
        sender.Visible = False
    End Sub

End Class
