Option Explicit On
Option Strict On
Imports System.IO
Public Class StansGrocery
    'Global Variables
    Dim food$(,)
    Dim temp() As String
    'Important Subs
    Sub ReadfromFile() 'All the formatting to read the assigned grocery file
        Dim filepath As String = "..\..\Grocery(1).txt" 'File path
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        Dim currentID As Integer = 699
        Dim rawLines() As String = System.IO.File.ReadAllLines("..\..\Grocery(1).txt")
        Dim fileName As String = "path_to_input_file.txt"
        Try
            Dim temp() As String = System.IO.File.ReadAllLines("..\..\Grocery(1).txt")
            Dim n As Integer = temp.Length - 1
            ReDim food$(n, 2) ' Array contains name of item, aisle, and category
            DisplayListBox.Items.Clear()
            For i As Integer = 0 To n
                Dim parts() As String = temp(i).Split(","c)
                If parts.Length = 3 Then 'All the special characters from the notepad are excluded
                    food$(i, 0) = parts(0).Replace("""", "").Replace("$$ITM", "").Trim()
                    food$(i, 1) = parts(1).Replace("""", "").Replace("##LOC", "").Trim()
                    food$(i, 2) = parts(2).Replace("""", "").Replace("%%CAT", "").Trim()
                    FilterComboBox.Items.Add(
    String.Format(food$(i, 0), food$(i, 1), food$(i, 2)))
                End If
            Next
        Catch bob As FileNotFoundException
            MsgBox("Ensure a file is selected") 'Just in case file is not found
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)
        End Try
    End Sub
    Sub DisplayFilteredGroceryData()
        Dim searchText As String = SearchTextBox.Text.Trim().ToLower()
        If food$ Is Nothing Then 'Could be fixed with a set defaults sub
            MsgBox("Ensure to select radio button then hit the search button.")
            Exit Sub
        End If
        FilterComboBox.Items.Clear()
        For row = 0 To food$.GetUpperBound(0)
            ' Check if any column in the row contains the search text
            For col = 0 To 2
                If food$(row, col).ToLower().Contains(searchText) Then
                    Select Case True
                        Case FilterByAisleRadioButton.Checked 'My attempt at getting the buttons to filter.
                            Dim displayItem As String = food$(row, 1) ' Aisle
                            Dim displayProduct As String = food$(row, 0)
                            If Not FilterComboBox.Items.Contains(displayItem) Then
                                FilterComboBox.Items.Add(displayItem)
                            End If
                            If Not DisplayListBox.Items.Contains(displayProduct) Then
                                DisplayListBox.Items.Add(displayProduct)
                            End If
                        Case FilterByCategoryRadioButton.Checked
                            Dim displayItem As String = food$(row, 2) ' Category
                            Dim displayProduct As String = food$(2, 0)
                            If Not FilterComboBox.Items.Contains(displayItem) Then
                                FilterComboBox.Items.Add(displayItem)
                            End If
                            If Not DisplayListBox.Items.Contains(displayProduct) Then
                                DisplayListBox.Items.Add(displayProduct)
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
    Sub DisplayDataToComboBox() 'This is in charge of showing stuff from the array into the listbox
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
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() 'Closes the program
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show() 'Opens the about menu
        Me.Hide()
    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DisplayDataToComboBox() 'For now updates the combobox
    End Sub
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadfromFile() 'Upon bootup the file is read
    End Sub
    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        If FilterByAisleRadioButton.Checked Then
            DisplayFilteredGroceryData() 'Shows displayed data
        End If
    End Sub
    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        If FilterByCategoryRadioButton.Checked Then
            DisplayFilteredGroceryData() 'Shows the other displayed data
        End If
    End Sub
    'A splash screen was attempted, but it crashed the form every time about button was clicked. 
    'Private Sub GraphicExamplesForm_activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    Static isStartUp As Boolean = True
    '    Me.Hide()
    '    If isStartUp Then ' activates at startup
    '        SplashScreen.Show() 'See splashform for timer modifications of splashscreen
    '        isStartUp = False
    '    End If
    'End Sub
End Class