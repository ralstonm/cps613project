Public Class Main

    Dim temp As Uri

    'Reference to the Settings Screen
    Dim mySettingsScreen
    'Reference to the Sticker Screen
    Dim myStickerScreen

    'Reference to each game
    Dim myGame1
    Dim myGame2
    Dim myGame3
    Dim myGame4
    Dim myGame5

    'Public variables - can be accessed from other screens
    Public soundVolume As Integer

    Public difficulty1 As Integer
    Public difficulty2 As Integer
    Public difficulty3 As Integer
    Public difficulty4 As Integer
    Public difficulty5 As Integer

    'Offset to place a panel in the centre
    Public xOffset = 75
    Public yOffset = 121

    'Offset to place back button in the same place
    Public xOffsetB = 324
    Public yOffsetB = 4


    'Clickhander for the settings button
    'Instantiates the settings screen and displays it
    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles settingsButton.Click
        mySettingsScreen = New SettingsScreen(Me)
        genericPanel.Visible = True
        genericPanel.BringToFront()
        Me.genericPanel.Controls.Add(mySettingsScreen)
        mySettingsScreen.BringToFront()
    End Sub

    'Clickhander for the progress button
    'Instantiates the progress screen and displays it
    Private Sub childViewPorgressButton_Click(sender As Object, e As EventArgs) Handles childViewPorgressButton.Click
        myStickerScreen = New StickerScreen(Me)
        genericPanel.Visible = True
        genericPanel.BringToFront()
        Me.genericPanel.Controls.Add(myStickerScreen)
        myStickerScreen.BringToFront()
    End Sub

    'Clickhander for the game 1 button
    'Instantiates the progress screen and displays it
    Private Sub alphabetGameButton_Click(sender As Object, e As EventArgs) Handles alphabetGameButton.Click
        myGame1 = New Game1(Me)
        genericPanel.Visible = True
        genericPanel.BringToFront()
        Me.genericPanel.Controls.Add(myGame1)
        myGame1.BringToFront()
    End Sub

    'Clickhander for the game 2 button
    'Instantiates the progress screen and displays it
    Private Sub typingGame_Click(sender As Object, e As EventArgs) Handles typingGame.Click
        myGame2 = New Game2(Me)
        genericPanel.Visible = True
        genericPanel.BringToFront()
        Me.genericPanel.Controls.Add(myGame2)
        myGame2.BringToFront()
    End Sub

    'Clickhander for the game 3 button
    'Instantiates the progress screen and displays it
    Private Sub drawingLetterGame_Click(sender As Object, e As EventArgs) Handles drawingLetterGame.Click
        myGame3 = New Game3(Me)
        genericPanel.Visible = True
        genericPanel.BringToFront()
        Me.genericPanel.Controls.Add(myGame3)
        myGame3.BringToFront()
    End Sub

    'Clickhander for the game 4 button
    'Instantiates the progress screen and displays it
    Private Sub soundLetterGame_Click(sender As Object, e As EventArgs) Handles soundLetterGame.Click
        myGame4 = New Game4(Me)
        genericPanel.Visible = True
        genericPanel.BringToFront()
        Me.genericPanel.Controls.Add(myGame4)
        myGame4.BringToFront()
    End Sub

    'Clickhander for the game 5 button
    'Instantiates the progress screen and displays it
    Private Sub storyBookGame_Click(sender As Object, e As EventArgs) Handles storyBookGame.Click
        myGame5 = New Game5(Me)
        genericPanel.Visible = True
        genericPanel.BringToFront()
        Me.genericPanel.Controls.Add(myGame5)
        myGame5.BringToFront()
    End Sub


    'Method to handle closing the settings screen
    'Does nothing if the settings screen is not open
    'Called from the settings screen's back button
    'Also called from the home button
    Public Sub closeSettings()

        If (Not (mySettingsScreen Is Nothing)) Then

            Me.genericPanel.Controls.Remove(mySettingsScreen)

            'Dispose of the object

            mySettingsScreen.Dispose()
            'Dereference the object
            mySettingsScreen = Nothing
        End If

        genericPanel.Visible = False
        genericPanel.SendToBack()
    End Sub

    Public Sub closeStickers()
        If (Not (myStickerScreen Is Nothing)) Then
            Me.genericPanel.Controls.Remove(myStickerScreen)
            'Dispose of the object

            myStickerScreen.Dispose()
            'Dereference the object
            myStickerScreen = Nothing
        End If

        genericPanel.Visible = False
        genericPanel.SendToBack()
    End Sub

    Public Sub closeGame1()
        If (Not (myGame1 Is Nothing)) Then
            Me.genericPanel.Controls.Remove(myGame1)
            'Dispose of the object

            myGame1.Dispose()
            'Dereference the object
            myGame1 = Nothing
        End If

        genericPanel.Visible = False
        genericPanel.SendToBack()
    End Sub

    Public Sub closeGame2()
        If (Not (myGame2 Is Nothing)) Then
            Me.genericPanel.Controls.Remove(myGame2)
            'Dispose of the object

            myGame2.Dispose()
            'Dereference the object
            myGame2 = Nothing
        End If

        genericPanel.Visible = False
        genericPanel.SendToBack()

    End Sub

    Public Sub closeGame3()
        If (Not (myGame3 Is Nothing)) Then
            Me.genericPanel.Controls.Remove(myGame3)
            'Dispose of the object

            myGame3.Dispose()
            'Dereference the object
            myGame3 = Nothing
        End If

        genericPanel.Visible = False
        genericPanel.SendToBack()

    End Sub

    Public Sub closeGame4()
        If (Not (myGame4 Is Nothing)) Then
            Me.genericPanel.Controls.Remove(myGame4)
            'Dispose of the object

            myGame4.Dispose()
            'Dereference the object
            myGame4 = Nothing
        End If

        genericPanel.Visible = False
        genericPanel.SendToBack()

    End Sub

    Public Sub closeGame5()
        If (Not (myGame5 Is Nothing)) Then
            Me.genericPanel.Controls.Remove(myGame5)
            'Dispose of the object

            myGame5.Dispose()
            'Dereference the object
            myGame5 = Nothing
        End If
        genericPanel.Visible = False
        genericPanel.SendToBack()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles youtubeButton.Click
        myBrowser.Visible = True
        temp = New Uri("https://www.youtube.com")
        myBrowser.Url = temp
        myBrowser.BringToFront()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles homeButton.Click

        'Remove any visible panels
        closeSettings()
        closeStickers()

        soundVolume = 0

        myBrowser.Visible = False
        myBrowser.SendToBack()

        toyPanel.Visible = False
        toyPanel.SendToBack()

        genericPanel.Visible = False
        genericPanel.SendToBack()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles SfariButton.Click
        myBrowser.Visible = True
        temp = New Uri("https://www.google.com")
        myBrowser.Url = temp
        myBrowser.BringToFront()
    End Sub

    Private Sub toyBoxButton_Click(sender As Object, e As EventArgs) Handles toyBoxButton.Click
        toyPanel.Visible = True
        toyPanel.BringToFront()

        startButton.Visible = True
        startButton.BringToFront()
        startButton.Dock = DockStyle.Fill
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        startButton.Visible = False
        startButton.SendToBack()

    End Sub

    Private Sub parrotButton_Click(sender As Object, e As EventArgs) Handles parrotButton.Click
        My.Computer.Audio.Play(My.Resources.speech, AudioPlayMode.Background)
    End Sub





    Private Sub homeButton1_Click(sender As Object, e As EventArgs)



        genericPanel.Visible = False
        genericPanel.SendToBack()
    End Sub


    Private Sub Main2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = FormBorderStyle.FixedSingle

        difficulty1 = 1
        difficulty2 = 1
        difficulty3 = 1
        difficulty4 = 1
        difficulty5 = 1
        soundVolume = 10

    End Sub

    Private Sub alphabetGamePanel_Paint(sender As Object, e As PaintEventArgs) Handles genericPanel.Paint

    End Sub




End Class