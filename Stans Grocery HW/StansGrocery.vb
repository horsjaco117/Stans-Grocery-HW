Public Class StansGrocery


    'Private Sub GraphicExamplesForm_activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    Static isStartUp As Boolean = True
    '    Me.Hide()


    '    If isStartUp Then ' activates at startup
    '        SplashScreen.Show() 'See splashform for timer modifications of splashscreen
    '        isStartUp = False
    '    End If


    'End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub
End Class
