Public Class Phonebook
	'Angie's Phonebook
	'02/02/2016
	'Author: Benjamin J. C. Reeve

	Const FILE_NAME = "contacts.txt"
	Const MAX_CONTACTS = 200
	Dim nameList(MAX_CONTACTS - 1) As String
	Dim addressList(MAX_CONTACTS - 1) As String
	Dim homeList(MAX_CONTACTS - 1) As String
	Dim mobileList(MAX_CONTACTS - 1) As String
	Dim notesList(MAX_CONTACTS - 1) As String

	Private Sub Phonebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Import()
	End Sub

	Private Sub Import()
		ContactList.Items.Clear()
		Using MyReader As New FileIO.TextFieldParser(FILE_NAME)
			MyReader.TextFieldType = FileIO.FieldType.Delimited
			MyReader.SetDelimiters(",")
			Dim currentRow As String()
			Dim rowCounter = 0
			While Not MyReader.EndOfData
				Try
					currentRow = MyReader.ReadFields()
					Dim counter = 0
					Dim currentField As String
					For Each currentField In currentRow
						Select Case counter
							Case 0
								nameList(rowCounter) = currentField
								ContactList.Items.Add(currentField)
							Case 1
								addressList(rowCounter) = currentField
							Case 2
								homeList(rowCounter) = currentField
							Case 3
								mobileList(rowCounter) = currentField
							Case 4
								notesList(rowCounter) = currentField
						End Select
						counter += 1
					Next
					rowCounter += 1
				Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
					MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
				End Try
			End While
		End Using
	End Sub

	Private Sub ContactList_DoubleClick(sender As Object, e As EventArgs) Handles ContactList.DoubleClick
		Dim lIndex As Integer
		lIndex = ContactList.SelectedIndex
		NameBox.Text = nameList(lIndex)
		AddressBox.Text = addressList(lIndex)
		HomeBox.Text = homeList(lIndex)
		MobileBox.Text = mobileList(lIndex)
		NotesBox.Text = notesList(lIndex)
	End Sub

	Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
		Export(NameBox.Text, AddressBox.Text, HomeBox.Text, MobileBox.Text, NotesBox.Text)
	End Sub

	Private Sub Export(ByVal name, ByVal address, ByVal home, ByVal mobile, ByVal notes)
		Dim textCache As String
		textCache = vbCrLf & name & ", " & address & ", " & home & ", " & mobile & ", " & notes
		My.Computer.FileSystem.WriteAllText(FILE_NAME, textCache, True)
		Import()
	End Sub

	Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
		OpenFD.InitialDirectory = FileIO.FileSystem.CurrentDirectory
		OpenFD.ShowDialog()
	End Sub
End Class
