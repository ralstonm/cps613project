Public Class Game1

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim mySettings_Advanced As Settings_Advanced

    Public Sub New(ByRef parentForm As Main)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm

    End Sub




    Private Sub bButton_Click(sender As Object, e As EventArgs) Handles bButton.Click

        Me.bButton.Visible = False
        Me.cButton.Visible = False
        Me.fButton.Visible = False


        Me.aButton.Visible = True
        Me.eButton.Visible = True
        Me.oButton.Visible = True

        My.Computer.Audio.Play(My.Resources.a, AudioPlayMode.Background)

    End Sub

    Private Sub aButton_Click(sender As Object, e As EventArgs) Handles aButton.Click
        Me.aButton.Visible = False
        Me.eButton.Visible = False
        Me.oButton.Visible = False


        Me.pButton.Visible = True
        Me.jButton.Visible = True
        Me.xButton.Visible = True

        My.Computer.Audio.Play(My.Resources.j, AudioPlayMode.Background)
    End Sub

    Private Sub jButton_Click(sender As Object, e As EventArgs) Handles jButton.Click

        My.Computer.Audio.Play(My.Resources.applus, AudioPlayMode.Background)
        parentFormRef.closeGame1()

    End Sub

    Private Sub AlphaBetParrotButton_Click(sender As Object, e As EventArgs) Handles AlphaBetParrotButton.Click
        If bButton.Visible = True Then
            My.Computer.Audio.Play(My.Resources.b, AudioPlayMode.Background)
        ElseIf (eButton.Visible = True) Then
            My.Computer.Audio.Play(My.Resources.a, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Play(My.Resources.j, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub alphabetGamePanel_Paint(sender As Object, e As PaintEventArgs) Handles alphabetGamePanel.Paint

    End Sub



    Private Sub Game1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click

        My.Computer.Audio.Play(My.Resources.b, AudioPlayMode.Background)

        'So many buttons!

        Me.aButton.Visible = False
        Me.eButton.Visible = False
        Me.oButton.Visible = False

        Me.pButton.Visible = False
        Me.xButton.Visible = False
        Me.jButton.Visible = False

        Me.bButton.Visible = True
        Me.cButton.Visible = True
        Me.fButton.Visible = True
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        parentFormRef.closeGame1()
    End Sub


End Class
