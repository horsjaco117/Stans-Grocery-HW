Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GraphicExamplesForm_activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static isStartUp As Boolean = True
        Me.Hide()


        If isStartUp Then ' activates at startup
            SplashScreen.Show() 'See splashform for timer modifications of splashscreen
            isStartUp = False
        End If


    End Sub
End Class
