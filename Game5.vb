Public Class Game5

    Public parentFormRef As Main
    Dim backButton As SharedBackButton
    Dim SAPI
    Dim counter As Integer

    Private Sub Game5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Manually add the back button
        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click

        'SAPI = CreateObject("SAPI.spvoice")
        'SAPI.Speak("Hello! Can you pick the letter that apple starts with?.")
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object
        parentFormRef.closeGame5()
    End Sub

    Public Sub New(ByRef parentForm As Main)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm

    End Sub
    Private Sub AButton_Click(sender As Object, e As EventArgs) Handles AButton.Click
        ' If ApplePage.Visible = True Then
        AppleLabel.Text = "Apple"
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Good job!")
        System.Threading.Thread.Sleep(1000)
        'ApplePage.Visible = False
        BeePage.Visible = True
        'End If
    End Sub

    Private Sub BButton_Click(sender As Object, e As EventArgs) Handles BButton.Click

    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click

    End Sub

    Private Sub DButton_Click(sender As Object, e As EventArgs) Handles DButton.Click

    End Sub

    Private Sub EButton_Click(sender As Object, e As EventArgs) Handles EButton.Click

    End Sub

    Private Sub F_Click(sender As Object, e As EventArgs) Handles F.Click

    End Sub
End Class
