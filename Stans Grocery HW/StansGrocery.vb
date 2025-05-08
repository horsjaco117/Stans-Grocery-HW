Option Explicit On
Option Strict On
Imports System.IO
Public Class StansGrocery
    Dim food$(,)

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

    Sub ReadfromFile()
        Dim filepath As String = "..\..\Grocery(1).txt" 'Emails for VB.txt
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        '  Dim temp() As String ' use for splitting customer data
        Dim currentID As Integer = 699
        Dim rawLines() As String = System.IO.File.ReadAllLines("..\..\Grocery(1).txt")
        Dim food$(,)  ' Global 2D array to store item data
        Dim fileName As String = "path_to_input_file.txt"

        Try

            Dim temp() As String = System.IO.File.ReadAllLines("..\..\Grocery(1).txt")
            Dim n As Integer = temp.Length - 1

            ReDim food$(n, 2) ' 3 columns: 0 = name, 1 = aisle, 2 = category

            DisplayListBox.Items.Clear()

            For i As Integer = 0 To n
                Dim parts() As String = temp(i).Split(","c)

                If parts.Length = 3 Then
                    food$(i, 0) = parts(0).Replace("""", "").Replace("$$ITM", "").Trim()
                    food$(i, 1) = parts(1).Replace("""", "").Replace("##LOC", "").Trim()
                    food$(i, 2) = parts(2).Replace("""", "").Replace("%%CAT", "").Trim()

                    FilterComboBox.Items.Add(
                        String.Format(food$(i, 0), food$(i, 1), food$(i, 2)))
                    'Add at beginning of paranthesis
                End If
            Next
        Catch bob As FileNotFoundException

            MsgBox("Bob is sad...")

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)

        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' ReadfromFile()
    End Sub

    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadfromFile()
    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        If FilterByAisleRadioButton.Checked = True Then
            DisplayListBox.Show()
        End If
    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        If FilterByCategoryRadioButton.Checked = True Then

        End If
    End Sub
End Class
