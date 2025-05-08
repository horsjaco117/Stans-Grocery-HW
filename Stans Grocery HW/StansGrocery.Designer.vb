<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGrocery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FilterGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(32, 77)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SearchTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.SearchTextBox, "Search for any of your grocery desires")
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(32, 109)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(112, 75)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.SearchButton, "Click this button once a desired item is typed into the search bar")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(32, 200)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(121, 28)
        Me.FilterComboBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.FilterComboBox, "A list of filters that allow you to narrow your results")
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(267, 44)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(502, 364)
        Me.DisplayListBox.TabIndex = 4
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(263, 9)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(60, 20)
        Me.DisplayLabel.TabIndex = 5
        Me.DisplayLabel.Text = "Display"
        Me.ToolTip1.SetToolTip(Me.DisplayLabel, "Displays desired information")
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(32, 248)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(200, 154)
        Me.FilterGroupBox.TabIndex = 6
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter"
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(19, 81)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(157, 24)
        Me.FilterByCategoryRadioButton.TabIndex = 1
        Me.FilterByCategoryRadioButton.Text = "Filter by Category"
        Me.ToolTip1.SetToolTip(Me.FilterByCategoryRadioButton, "Filter Stans goods by category")
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Checked = True
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(19, 39)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(125, 24)
        Me.FilterByAisleRadioButton.TabIndex = 0
        Me.FilterByAisleRadioButton.TabStop = True
        Me.FilterByAisleRadioButton.Text = "Filter by aisle"
        Me.ToolTip1.SetToolTip(Me.FilterByAisleRadioButton, "Filter Stans good by aisle")
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(28, 44)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(60, 20)
        Me.SearchLabel.TabIndex = 7
        Me.SearchLabel.Text = "Search"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(166, 34)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StansGrocery"
        Me.Text = "Stans Grocery"
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents SearchLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
