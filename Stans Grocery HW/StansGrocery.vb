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
        Try
            FileOpen(fileNumber, filepath, OpenMode.Input)
            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord) 'Read exactly one record
                If currentRecord <> "" Then 'This gets rid of unnecessary spacing
                    temp = Split(currentRecord, ",")
                    'ListBox1.Items.Add(currentRecord) 'Add the record into the list box
                    If temp.Length = 4 Then 'ignoring malformed records
                        '    ListBox1.Items.Add(temp(0))
                        'End If
                        temp(0) = Replace(temp(0), "$", "") 'dollar signs were replaced with blank space in the first name
                        DisplayListBox.Items.Add(temp(0)) 'display portion of the array. 0-4
                        'WriteToFile(temp(0)) 'first name
                        'WriteToFile(temp(1)) 'last name
                        'WriteToFile("") 'place holder for street
                        'WriteToFile(temp(2)) 'city
                        'WriteToFile(("ID")) 'state
                        'WriteToFile("") 'zip
                        'WriteToFile("") ' phone
                        'WriteToFile(temp(3)) ' email
                        'WriteToFile($"000631{currentID}", True) 'customer ID
                        currentID += 1
                    End If
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
    'Sub WriteToFile(newRecord As String, Optional insertLine As Boolean = False)
    '    Dim filepath As String = "..\..\..\CustomerDataBackup - Copy.txt"
    '    Dim filenumber As Integer = FreeFile()

    '    Try

    '        FileOpen(filenumber, filepath, OpenMode.Append)
    '        Write(filenumber, newRecord)
    '        If insertLine Then
    '            WriteLine(filenumber)
    '        End If

    '        FileClose(filenumber)
    '    Catch ex As Exception
    '        MsgBox($"Error writing to {filepath})")
    '    End Try

    'End Sub


End Class
