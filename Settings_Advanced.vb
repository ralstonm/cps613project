Public Class Settings_Advanced

    Dim parentFormRef As SettingsScreen

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        parentFormRef.handleAdvanced()
        parentFormRef.closeSettingsAdvanced()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Public Sub New(ByRef parentForm As SettingsScreen)
        'Custom constructor to keep a reference to the Main Form
        'Can call puiblic methods and reference public variables
        InitializeComponent()
        parentFormRef = parentForm

        TrackBar6.Value = parentFormRef.parentFormRef.difficulty1
        TrackBar3.Value = parentFormRef.parentFormRef.difficulty2
        TrackBar8.Value = parentFormRef.parentFormRef.difficulty3
        TrackBar4.Value = parentFormRef.parentFormRef.difficulty4
        TrackBar5.Value = parentFormRef.parentFormRef.difficulty5


    End Sub

    Private Sub Settings_Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrackBar6_Scroll(sender As Object, e As EventArgs) Handles TrackBar6.Scroll
        parentFormRef.parentFormRef.difficulty1 = TrackBar6.Value
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        parentFormRef.parentFormRef.difficulty2 = TrackBar3.Value
    End Sub

    Private Sub TrackBar8_Scroll(sender As Object, e As EventArgs) Handles TrackBar8.Scroll
        parentFormRef.parentFormRef.difficulty3 = TrackBar8.Value
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        parentFormRef.parentFormRef.difficulty4 = TrackBar4.Value
    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        parentFormRef.parentFormRef.difficulty5 = TrackBar5.Value
    End Sub
End Class
