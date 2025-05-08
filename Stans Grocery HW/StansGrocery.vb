Option Explicit On
Option Strict On
Imports System.IO
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

    Sub ReadfromFile()
        Dim filepath As String = "..\..\Grocery(1).txt" 'Emails for VB.txt
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        Dim temp() As String ' use for splitting customer data
        Dim currentID As Integer = 699
        Dim rawLines() As String = System.IO.File.ReadAllLines("..\..\Grocery(1).txt")

        For Each line In rawLines
            Dim parts() As String = line.Split(","c)

            If parts.Length = 3 Then
                Dim item As String = parts(0).Replace("""", "").Replace("$$ITM", "").Trim()
                Dim location As String = parts(1).Replace("""", "").Replace("##LOC", "").Trim()
                Dim category As String = parts(2).Replace("""", "").Replace("%%CAT", "").Trim()

                ' Add to ListBox instead of console
                DisplayListBox.Items.Add(String.Format(item, location, category))
            End If
        Next

        Try
            FileOpen(fileNumber, filepath, OpenMode.Input)
            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord) 'Read exactly one record
                If currentRecord <> "" Then 'This gets rid of unnecessary spacing
                    temp = Split(currentRecord, ",")
                    temp(0) = Replace(temp(0), "$", "") 'dollar signs were replaced with blank space in the first name
                    DisplayListBox.Items.Add(currentRecord) 'display portion of the array. 0-4
                    currentID += 1
                End If
            Loop
            FileClose(fileNumber)
        Catch bob As FileNotFoundException

            MsgBox("Bob is sad...")

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)

        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ReadfromFile()
    End Sub


End Class
