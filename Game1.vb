Public Class Game1

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim mySettings_Advanced As Settings_Advanced
    Dim resultsScreen As SharedResults
    Dim parrotHelpText
    'How many letters do we actually have?
    Dim letterRange = 26

    'What game are we on?
    Dim currentGameState
    'Type of game? 1 for picture, 2 for just sounding out
    Dim currentGameType
    'Array of all games that will be played
    Dim gamesToPlay()

    Dim point As New Point()

    Private m_MouseIsDown As Boolean = False


    Dim letterList() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Dim letterPicture() As String = {"apple", "boy", "cat", "dog", "egg", "fish", "girl", "hippo", "igloo", "jet", "kitten", "lion", "monkey", "nail", "orange", "pirate", "queen", "rocket", "snake", "tiger", "unicorn", "violin", "walrus", "xylophone", "yak", "zebra"}
    Dim letterResourceList() As String = {"ablock", "bblock", "cblock", "dblock", "eblock", "fblock", "gblock", "hblock", "iblock", "jblock", "kblock", "lblock", "mblock", "nblock", "oblock", "pblock", "qblock", "rblock", "sblock", "tblock", "ublock", "vblock", "wblock", "xblock", "yblock", "zblock"}
    Dim letterResourceName() As String = {"apple", "boy", "cat", "dog", "egg", "fish", "girl", "hippo", "igloo", "jet", "kitten", "lion", "monkey", "nail", "orange", "pirate", "queen", "rocket", "snake", "tiger", "unicorn", "violin", "walrus", "xylophone", "yak", "zebra"}

    'Reusable array for the letter tiles
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
        'Return a random number (n - 1)
        Randomize()
        Return CInt(Math.Ceiling(Rnd() * n)) - 1
    End Function

    Private Sub speak(text As String)

        If (parentFormRef.soundVolume = 0) Then
            Return

        End If

        Debug.Print(text)
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(text)

    End Sub

    Private Sub generateGames()

        Dim numOfGames As Integer
        'Set a different number of games for each difficulty
        If (parentFormRef.difficulty1 = 1) Then
            numOfGames = 6
        ElseIf (parentFormRef.difficulty2 = 1) Then
            numOfGames = 8
        Else
            numOfGames = 12
        End If

        Debug.Print("Generating games " & numOfGames)

        'Resize the array based on the number of games
        ReDim gamesToPlay(numOfGames)

        'Set the correct letter for each game randomly
        For counter As Integer = 0 To numOfGames
            gamesToPlay(counter) = randomNumber(letterRange)

            Debug.Print("Playing with " & gamesToPlay(counter))
        Next

        'Start at game 0
        currentGameState = 0

        startGame()

    End Sub

    Private Sub startGame()

        'What is the letter we are looking for?
        Dim letter = letterList(gamesToPlay(currentGameState))

        'Define strings for the parrot to say
        If currentGameType = 0 Then
            parrotHelpText = "Can you find the letter, " + letter + "?"
        Else
            parrotHelpText = "Can you find the letter that " + letterResourceName(gamesToPlay(currentGameState)) + " starts with?"
        End If

        'How many letter tiles?  Defined by difficulty
        Dim numOfPics

        If (parentFormRef.difficulty1 = 1) Then
            numOfPics = 7

        ElseIf (parentFormRef.difficulty2 = 1) Then
            numOfPics = 10

        Else
            numOfPics = 13

        End If

        'Resize the array
        ReDim picBoxArray(numOfPics - 1)

        'Loop through the array of pics up until the second to last one and assign randomly.  The last one will be the correct answer
        For counter = 0 To (numOfPics - 2)

            Dim randoLetter = gamesToPlay(currentGameState)

            'Pick a random letter.  If it's the same as the correct answer, pick another one
            Do While randoLetter = gamesToPlay(currentGameState)

                randoLetter = randomNumber(letterRange)

            Loop

            'Define a picture box and style it
            Dim tempPic As PictureBox = New PictureBox()

            tempPic.BorderStyle = Windows.Forms.BorderStyle.Fixed3D

            tempPic.Size = New Size(75, 75)

            'Assign an image to it based on the array of resource names
            tempPic.Image = My.Resources.ResourceManager.GetObject(letterResourceList(randoLetter))

            tempPic.SizeMode = PictureBoxSizeMode.StretchImage

            'Assign the same clickhandler to all wrong answers
            AddHandler tempPic.Click, AddressOf Me.wrongButton_Click

            'Add to the array
            picBoxArray(counter + 1) = tempPic

        Next
        'Now, we can set up the correct answer
        Dim tempPic2 As PictureBox = New PictureBox()

        tempPic2.BorderStyle = Windows.Forms.BorderStyle.Fixed3D

        tempPic2.Size = New Size(75, 75)

        tempPic2.Image = My.Resources.ResourceManager.GetObject(letterResourceList(gamesToPlay(currentGameState)))

        tempPic2.SizeMode = PictureBoxSizeMode.StretchImage



        'Gets the clickhandler for the right answer
        AddHandler tempPic2.Click, AddressOf Me.rightButton_Click

        picBoxArray(0) = tempPic2

        Debug.Print(picBoxArray(numOfPics - 1).Location.X)

        'If the game is story book mode, show the story book and overlay the story book image

        If currentGameType = 0 And parentFormRef.soundVolume = 0 Then

            pictureBook.Visible = True
            storyBookImage.Visible = True
            storyBookImage.Location = New Point(15, 15)
            storyBookImage.BackgroundImage = My.Resources.ResourceManager.GetObject(letterResourceList(gamesToPlay(currentGameState)))
            storyBookImage.BackgroundImageLayout = ImageLayout.Stretch
            storyBookImage.BringToFront()

        ElseIf (currentGameType = 1) Then
            pictureBook.Visible = True
            storyBookImage.Visible = True
            storyBookImage.Location = New Point(15, 15)
            storyBookImage.BackgroundImage = My.Resources.ResourceManager.GetObject(letterResourceName(gamesToPlay(currentGameState)))
            storyBookImage.BackgroundImageLayout = ImageLayout.Stretch
            storyBookImage.BringToFront()

        Else

        End If

        'Place the buttons
        placeButtons()


    End Sub

    Private Sub placeButtons()

        'Loop through all of the pictureboxes and assign a position
        For counter = 0 To (picBoxArray.Length - 1)

            Dim goodPlacement = False


            'Keep trying to find a good placement
            While Not goodPlacement

                Debug.Print("ButtonPlaces Width" & buttonPlaces.Width)
                Debug.Print("ButtonPlaces Height" & buttonPlaces.Height)

                'Assign a position randomly within the buttonplaces panel
                Dim x = randomNumber((buttonPlaces.Width - 75))
                Dim y = randomNumber((buttonPlaces.Height - 75))

                'First one placed is always good
                If counter = 0 Then
                    goodPlacement = True
                End If

                Debug.Print("Testing X " & x)
                Debug.Print("Testing Y " & y)

                'Set the control
                Me.buttonPlaces.Controls().Add(picBoxArray(counter))

                picBoxArray(counter).Parent = buttonPlaces

                picBoxArray(counter).Location = New Point(x, y)

                'Compare to all previously placed picture boxes.  If the bounds intersect with any, try again
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
            addDragDrop(picBoxArray(counter))

        Next

        'Give the cue to continue
        speak(parrotHelpText)
    End Sub

    Private Sub endCurrentGame()

        'Dispose of the pictureboxes for reassignment
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
            'Have we run through all of the games?  If so, end
            endGame()
        Else
            'Otherwise, move to the next game
            currentGameState = currentGameState + 1

            If (currentGameState > (gamesToPlay.Length / 2)) Then
                'Half of the games will be type 1 (show picture)
                currentGameType = 1
            Else
                'Other half will be type 0 (say letter)
                currentGameType = 0
            End If
            startGame()
        End If

    End Sub

    Private Sub endGame()

        'Manually add the back button
        resultsScreen = New SharedResults()
        Me.Controls.Add(resultsScreen)
        resultsScreen.BringToFront()
        If (parentFormRef.soundVolume <> 0) Then
            My.Computer.Audio.Play(My.Resources.applus, AudioPlayMode.Background)
        End If
        ' resultsScreen.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)
        AddHandler resultsScreen.Button1.Click, AddressOf Me.backButton_Click


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

        speak("Hi! Let's see if you can recognize letters! Tap the right letter! If you don't see it, drag other letters out of the way!")

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
            speak("That's the letter, " + letterList(gamesToPlay(currentGameState)))
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

    Private Sub addDragDrop(ByRef sender As PictureBox)

        ' sender.AllowDrop = True
        buttonPlaces.AllowDrop = True



        AddHandler sender.MouseDown, AddressOf Me.DragDrop_MouseDown
        AddHandler sender.MouseMove, AddressOf Me.DragDrop_MouseMove
        AddHandler sender.MouseUp, AddressOf Me.DragDrop_MouseUp
        '  AddHandler sender.DragEnter, AddressOf Me.DragDrop_DragEnter


        ' sender.MouseDown()
        'sender.MouseMove()
        'ender.DragEnter()

    End Sub

    Private Sub DragDrop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'sender.CaptureMouse()

        'control = CType(sender, Control)
        '/control.CaptureMouse()
        ' control.Capture = True
        '  If (control.Capture) Then
        'Debug.Print("Captured Mouse")
        'End If

        Dim control As Control = CType(sender, Control)

        control.Capture = True

        point = New Point(e.X, e.Y)
        'sender.Loc()

    End Sub

    Private Sub DragDrop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            ' Initiate dragging and allow either copy or move.
            'sender.DoDragDrop(sender.BackGroundImage, DragDropEffects.Move)
            'Debug.Print(MousePosition.X)
        'Debug.Print(MousePosition.Y)

        Dim control As Control = CType(sender, Control)

        If control.Capture = True Then

            Dim newPoint = New Point(e.X, e.Y)

            Dim diffX = point.X - newPoint.X
            Dim diffY = point.Y - newPoint.Y

            Dim currentX = sender.Location.X
            Dim currentY = sender.Location.Y

            sender.Location = New Point(currentX - diffX, currentY - diffY)

            sender.BringToFront()

            point = newPoint

        End If


    End Sub


    Private Sub DragDrop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim control As Control = CType(sender, Control)

        control.Capture = False

    End Sub


    Private Sub buttonPlaces_Paint(sender As Object, e As PaintEventArgs) Handles buttonPlaces.Paint

    End Sub

    Private Sub pictureBook_Click(sender As Object, e As EventArgs) Handles pictureBook.Click

    End Sub
End Class
