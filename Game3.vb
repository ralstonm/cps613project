Public Class Game3

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim SAPI


    Private startX As Integer = 0
    Private startY As Integer = 0
    Private endX As Integer = 0
    Private endY As Integer = 0

    Private gbitmap, gbitmap2 As Bitmap
    Private ismousedown As Boolean = False

    Dim status As Integer = 0



    Private Sub Game3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB + 10)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click

        gbitmap = New Bitmap(drawingBox.Width, drawingBox.Height)
        gbitmap2 = New Bitmap(drawingBox.Width, drawingBox.Height)

        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Hello! Can you write the letter E? Press the next button after your done")
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        parentFormRef.closeGame3()
    End Sub

    Public Sub New(ByRef parentForm As Main)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm



    End Sub

    Private Sub AlphaBetParrotButton_Click(sender As Object, e As EventArgs) Handles AlphaBetParrotButton.Click

        If status = 0 Then
            SAPI.Speak(" Can you write the letter E? Press the next button after your done")
        Else
            SAPI.Speak(" Can you write the letter A? Press the next button after your done")
        End If
    End Sub

    Private Sub drawingBox_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingBox.MouseMove
        If ismousedown = True Then
            
        End If
    End Sub

    Private Sub drawingBox_MouseDown(sender As Object, e As MouseEventArgs) Handles drawingBox.MouseDown
        ismousedown = True
        startX = e.X
        startY = e.Y
       
    End Sub

    Private Sub drawingBox_MouseUp(sender As Object, e As MouseEventArgs) Handles drawingBox.MouseUp
        ismousedown = False
        Dim g As Graphics = Graphics.FromImage(gbitmap)
        g.DrawLine(New Pen(Me.drawingBox.BackColor), startX, startY, endX, endY)
        drawingBox.Image = gbitmap
        g.DrawLine(Pens.Blue, startX, startY, e.X, e.Y)
        endX = e.X
        endY = e.Y
    End Sub

    Private Sub Nextbutton_Click(sender As Object, e As EventArgs) Handles Nextbutton.Click
        drawingBox.SendToBack()

        backbox.BringToFront()
        status = status + 1
        If status = 2 Then
            My.Computer.Audio.Play(My.Resources.applus, AudioPlayMode.Background)
            parentFormRef.closeGame3()
        Else
            SAPI.Speak(" Can you write the letter A? Press the next button after your done")
        End If

        
    End Sub

    Private Sub backbox_MouseDown(sender As Object, e As MouseEventArgs) Handles backbox.MouseDown
        ismousedown = True
        startX = e.X
        startY = e.Y

    End Sub

    Private Sub backbox_MouseMove(sender As Object, e As MouseEventArgs) Handles backbox.MouseMove
        If ismousedown = True Then

           
        End If
    End Sub

    Private Sub backbox_MouseUp(sender As Object, e As MouseEventArgs) Handles backbox.MouseUp
        ismousedown = False
        Dim g As Graphics = Graphics.FromImage(gbitmap2)
        g.DrawLine(New Pen(Me.backbox.BackColor), startX, startY, endX, endY)
        backbox.Image = gbitmap2
        g.DrawLine(Pens.Blue, startX, startY, e.X, e.Y)
        endX = e.X
        endY = e.Y
    End Sub
End Class
