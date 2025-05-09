Option Explicit On
Option Strict On
Imports System.IO
Public Class StansGrocery
    Dim food$(,)
    Dim temp() As String


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
        '  Dim food$(,)  ' Global 2D array to store item data
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
        DisplayDataToComboBox()
    End Sub

    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadfromFile()
    End Sub

    'Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
    '    If FilterByAisleRadioButton.Checked = True Then
    '        DisplayListBox.Show()
    '    End If
    'End Sub

    Sub DisplayFilteredGroceryData()

        If food$ Is Nothing Then
            MsgBox("Grocery data not loaded.")
            Exit Sub
        End If

        FilterComboBox.Items.Clear()

        Dim searchText As String = SearchTextBox.Text.Trim().ToLower()

        For row = 0 To food$.GetUpperBound(0)
            ' Check if any column in the row contains the search text
            For col = 0 To 2
                If food$(row, col).ToLower().Contains(searchText) Then

                    Select Case True
                        'Case FilterByNameRadioButton.Checked
                        '    Dim displayItem As String = food$(row, 0) ' Name
                        '    If Not FilterComboBox.Items.Contains(displayItem) Then
                        '        FilterComboBox.Items.Add(displayItem)
                        '    End If

                        Case FilterByAisleRadioButton.Checked
                            Dim displayItem As String = food$(row, 1) ' Aisle
                            If Not FilterComboBox.Items.Contains(displayItem) Then
                                FilterComboBox.Items.Add(displayItem)
                            End If

                        Case FilterByCategoryRadioButton.Checked
                            Dim displayItem As String = food$(row, 2) ' Category
                            If Not FilterComboBox.Items.Contains(displayItem) Then
                                FilterComboBox.Items.Add(displayItem)
                            End If
                    End Select

                    Exit For ' No need to check other columns in this row once matched
                End If
            Next
        Next

        FilterComboBox.Sorted = True

        If FilterComboBox.Items.Count > 0 Then
            FilterComboBox.SelectedIndex = 0
        End If


    End Sub



    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        If FilterByAisleRadioButton.Checked Then
            DisplayFilteredGroceryData()
        End If
    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        If FilterByCategoryRadioButton.Checked Then
            DisplayFilteredGroceryData()
        End If
    End Sub
    Sub DisplayDataToComboBox()
        If food$ Is Nothing Then
            MsgBox("Grocery data not loaded. Please pick a file.")
            Exit Sub
        End If

        DisplayListBox.Items.Clear()

        For i = 0 To food$.GetUpperBound(0)
            DisplayListBox.Items.Add($"{food$(i, 1)}, {food$(i, 0)}") ' Aisle, Name format
        Next

        DisplayListBox.Sorted = True

        If DisplayListBox.Items.Count > 0 Then
            DisplayListBox.SelectedIndex = 0
        End If
    End Sub



End Class
