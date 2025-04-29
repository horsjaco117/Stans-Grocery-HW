Public Class SplashScreen
    Private Sub Splashscreen_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Form1.SendToBack()
        SplashTimer.Enabled() = True
        Form1.Hide()
    End Sub

    Private Sub SplashTimer1_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashTimer.Enabled = False
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class