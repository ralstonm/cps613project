Public Class StickerScreen

    Public parentFormRef As Main2
    Dim backButton As SharedBackButton

    Private Sub StickerScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        backButton = New SharedBackButton()
        Me.Controls.Add(backButton)
        backButton.BringToFront()
        backButton.Location = New Point(parentFormRef.xOffsetB, parentFormRef.yOffsetB)

        'Add a clickhandler to the actual button on the backbutton
        AddHandler backButton.Button1.Click, AddressOf Me.backButton_Click

        ScorePanel1.Visible = True
        ScorePanel2.Visible = False

    End Sub


    Public Sub New(ByRef parentForm As Main2)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm
        '  PageCorner.Visible = False


    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Calls Parent Form to Close Settings and delete Object


        parentFormRef.closeStickers()
    End Sub

    Private Sub PageCorner_Click(sender As Object, e As EventArgs) Handles PageCorner.Click

        If ScorePanel1.Visible Then
            ScorePanel1.Visible = False
            ScorePanel2.Visible = True
        Else
            ScorePanel1.Visible = True
            ScorePanel2.Visible = False

        End If

    End Sub


    Private Sub PageCorner_MouseEnter(sender As Object, e As EventArgs) Handles PageCorner.MouseEnter

        Dim newImage As Bitmap = My.Resources.pagecorner

        PageCorner.Image = newImage

    End Sub


    Private Sub PageCorner_MouseLeave(sender As Object, e As EventArgs) Handles PageCorner.MouseLeave
        Dim newImage As Bitmap = My.Resources.cornerdown


        PageCorner.Image = newImage
    End Sub
   
End Class
