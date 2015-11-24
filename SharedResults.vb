Public Class SharedResults

    Private Sub SharedResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        
    End Sub



    Private Sub Panel1_Click(sender As Object, e As PaintEventArgs) Handles Panel1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Good Work")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
