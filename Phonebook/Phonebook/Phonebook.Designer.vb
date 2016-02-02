<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Phonebook
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.ContactList = New System.Windows.Forms.ListBox()
		Me.NameBox = New System.Windows.Forms.TextBox()
		Me.AddressBox = New System.Windows.Forms.TextBox()
		Me.HomeBox = New System.Windows.Forms.TextBox()
		Me.MobileBox = New System.Windows.Forms.TextBox()
		Me.NotesBox = New System.Windows.Forms.TextBox()
		Me.NameLabel = New System.Windows.Forms.Label()
		Me.HomeLabel = New System.Windows.Forms.Label()
		Me.AddLabel = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.NotesLabel = New System.Windows.Forms.Label()
		Me.SubmitButton = New System.Windows.Forms.Button()
		Me.RefreshButton = New System.Windows.Forms.Button()
		Me.OpenButton = New System.Windows.Forms.Button()
		Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
		Me.SuspendLayout()
		'
		'ContactList
		'
		Me.ContactList.FormattingEnabled = True
		Me.ContactList.Location = New System.Drawing.Point(304, 16)
		Me.ContactList.Name = "ContactList"
		Me.ContactList.Size = New System.Drawing.Size(226, 251)
		Me.ContactList.TabIndex = 0
		'
		'NameBox
		'
		Me.NameBox.Location = New System.Drawing.Point(63, 16)
		Me.NameBox.Name = "NameBox"
		Me.NameBox.Size = New System.Drawing.Size(235, 20)
		Me.NameBox.TabIndex = 1
		'
		'AddressBox
		'
		Me.AddressBox.Location = New System.Drawing.Point(63, 42)
		Me.AddressBox.Name = "AddressBox"
		Me.AddressBox.Size = New System.Drawing.Size(235, 20)
		Me.AddressBox.TabIndex = 3
		'
		'HomeBox
		'
		Me.HomeBox.Location = New System.Drawing.Point(63, 68)
		Me.HomeBox.Name = "HomeBox"
		Me.HomeBox.Size = New System.Drawing.Size(235, 20)
		Me.HomeBox.TabIndex = 5
		'
		'MobileBox
		'
		Me.MobileBox.Location = New System.Drawing.Point(63, 94)
		Me.MobileBox.Name = "MobileBox"
		Me.MobileBox.Size = New System.Drawing.Size(235, 20)
		Me.MobileBox.TabIndex = 8
		'
		'NotesBox
		'
		Me.NotesBox.Location = New System.Drawing.Point(63, 120)
		Me.NotesBox.Multiline = True
		Me.NotesBox.Name = "NotesBox"
		Me.NotesBox.Size = New System.Drawing.Size(235, 66)
		Me.NotesBox.TabIndex = 9
		'
		'NameLabel
		'
		Me.NameLabel.AutoSize = True
		Me.NameLabel.Location = New System.Drawing.Point(12, 19)
		Me.NameLabel.Name = "NameLabel"
		Me.NameLabel.Size = New System.Drawing.Size(35, 13)
		Me.NameLabel.TabIndex = 2
		Me.NameLabel.Text = "Name"
		'
		'HomeLabel
		'
		Me.HomeLabel.AutoSize = True
		Me.HomeLabel.Location = New System.Drawing.Point(12, 71)
		Me.HomeLabel.Name = "HomeLabel"
		Me.HomeLabel.Size = New System.Drawing.Size(35, 13)
		Me.HomeLabel.TabIndex = 4
		Me.HomeLabel.Text = "Home"
		'
		'AddLabel
		'
		Me.AddLabel.AutoSize = True
		Me.AddLabel.Location = New System.Drawing.Point(12, 45)
		Me.AddLabel.Name = "AddLabel"
		Me.AddLabel.Size = New System.Drawing.Size(45, 13)
		Me.AddLabel.TabIndex = 6
		Me.AddLabel.Text = "Address"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 97)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(38, 13)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Mobile"
		'
		'NotesLabel
		'
		Me.NotesLabel.AutoSize = True
		Me.NotesLabel.Location = New System.Drawing.Point(12, 148)
		Me.NotesLabel.Name = "NotesLabel"
		Me.NotesLabel.Size = New System.Drawing.Size(35, 13)
		Me.NotesLabel.TabIndex = 10
		Me.NotesLabel.Text = "Notes"
		'
		'SubmitButton
		'
		Me.SubmitButton.Location = New System.Drawing.Point(101, 192)
		Me.SubmitButton.Name = "SubmitButton"
		Me.SubmitButton.Size = New System.Drawing.Size(197, 37)
		Me.SubmitButton.TabIndex = 11
		Me.SubmitButton.Text = "Submit"
		Me.SubmitButton.UseVisualStyleBackColor = True
		'
		'RefreshButton
		'
		Me.RefreshButton.Location = New System.Drawing.Point(12, 192)
		Me.RefreshButton.Name = "RefreshButton"
		Me.RefreshButton.Size = New System.Drawing.Size(83, 73)
		Me.RefreshButton.TabIndex = 13
		Me.RefreshButton.Text = "Refresh"
		Me.RefreshButton.UseVisualStyleBackColor = True
		'
		'OpenButton
		'
		Me.OpenButton.Location = New System.Drawing.Point(101, 230)
		Me.OpenButton.Name = "OpenButton"
		Me.OpenButton.Size = New System.Drawing.Size(197, 37)
		Me.OpenButton.TabIndex = 14
		Me.OpenButton.Text = "Open"
		Me.OpenButton.UseVisualStyleBackColor = True
		'
		'OpenFD
		'
		Me.OpenFD.FileName = "OpenFD"
		'
		'Phonebook
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(542, 277)
		Me.Controls.Add(Me.OpenButton)
		Me.Controls.Add(Me.RefreshButton)
		Me.Controls.Add(Me.SubmitButton)
		Me.Controls.Add(Me.NotesLabel)
		Me.Controls.Add(Me.NotesBox)
		Me.Controls.Add(Me.MobileBox)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.AddLabel)
		Me.Controls.Add(Me.HomeBox)
		Me.Controls.Add(Me.HomeLabel)
		Me.Controls.Add(Me.AddressBox)
		Me.Controls.Add(Me.NameLabel)
		Me.Controls.Add(Me.NameBox)
		Me.Controls.Add(Me.ContactList)
		Me.Name = "Phonebook"
		Me.Text = "PhoneBook"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ContactList As ListBox
	Friend WithEvents NameBox As TextBox
	Friend WithEvents AddressBox As TextBox
	Friend WithEvents HomeBox As TextBox
	Friend WithEvents MobileBox As TextBox
	Friend WithEvents NotesBox As TextBox
	Friend WithEvents NameLabel As Label
	Friend WithEvents HomeLabel As Label
	Friend WithEvents AddLabel As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents NotesLabel As Label
	Friend WithEvents SubmitButton As Button
	Friend WithEvents RefreshButton As Button
	Friend WithEvents OpenButton As Button
	Friend WithEvents OpenFD As OpenFileDialog
End Class
