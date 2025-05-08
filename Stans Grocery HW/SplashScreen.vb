Public Class SplashScreen
    Private Sub Splashscreen_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        StansGrocery.SendToBack()
        SplashTimer.Enabled() = True
        StansGrocery.Hide()
    End Sub

    Private Sub SplashTimer1_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashTimer.Enabled = False
        StansGrocery.Show()
        Me.Close()
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class