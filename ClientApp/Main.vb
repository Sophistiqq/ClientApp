Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
        DisplayReceivedFiles()
        ' Clear the DataGridView
        filesReceived.Rows.Clear()
        filesReceived.Columns.Clear()

        ' Set the SelectionMode property of the filesReceived DataGridView to FullRowSelect
        filesReceived.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub LoadEmployeeData()
        'The connection string is on a module
        con.Open()
        Dim query As String = "SELECT CONCAT(firstname, ' ', lastname) AS full_name FROM tbl_employees"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        ' Bind the DataTable to the DataGridView1
        DataGridView1.DataSource = dataTable
        DataGridView1.ColumnHeadersVisible = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub DisplayReceivedFiles()
        'The connection string is on a module
        con.Open()
        Dim query As String = "SELECT filename FROM tbl_files WHERE sent_to = 'Storage'"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        ' Bind the DataTable to the filesReceived DataGridView
        filesReceived.DataSource = dataTable
        filesReceived.Columns("filename").HeaderText = "Received Files"
        filesReceived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        filesReceived.ColumnHeadersVisible = False
        con.Close()
    End Sub





    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click

    End Sub

    'File Selection Section ========================================================================
    Private Sub selectfileBtn_Click(sender As Object, e As EventArgs) Handles selectfileBtn.Click, fileTextBox.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the properties of the OpenFileDialog as per your requirements
        openFileDialog.Title = "Select a File"
        openFileDialog.Filter = "Document Files (*.doc;*.docx;*.pdf)|*.doc;*.docx;*.pdf|Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim selectedFilePath As String = openFileDialog.FileName

            ' Display the selected file path in the TextBox
            fileTextBox.Text = selectedFilePath
        End If
    End Sub



    'End of Selection Section ========================================================================


    'This section handles the selection buttons ========================================================================
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        DataGridView1.ClearSelection()
        selected.Checked = False
        storage.Checked = False
        DataGridView1.Enabled = False
        fileTextBox.Text = ""
    End Sub

    Private Sub selected_CheckedChanged(sender As Object, e As EventArgs) Handles selected.CheckedChanged
        If selected.Checked = True Then
            DataGridView1.Enabled = True
        Else
            DataGridView1.Enabled = False
        End If
    End Sub

    Private Sub everyone_CheckedChanged(sender As Object, e As EventArgs)
        DataGridView1.ClearSelection()
    End Sub

    Private Sub storage_CheckedChanged(sender As Object, e As EventArgs) Handles storage.CheckedChanged
        DataGridView1.ClearSelection()
    End Sub

    Public Sub SetDisplayName(firstName As String)
        displayName.Text = firstName
    End Sub

    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        ' Get the selected employee(s) from the DataGridView1
        Dim selectedEmployees As New List(Of String)()

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim fullName As String = row.Cells("full_name").Value.ToString()
            selectedEmployees.Add(fullName)
        Next

        ' Get the file details
        Dim filePath As String = fileTextBox.Text ' Use the full file path instead of just the file name
        Dim fileName As String = Path.GetFileName(filePath) ' Extract the file name from the full path
        Dim sentTo As String = ""

        If selected.Checked Then
            sentTo = "Selected Employee(s)"
        ElseIf storage.Checked Then
            sentTo = "Storage"
        End If

        ' Perform the file sharing action based on the sentTo value
        If sentTo = "Selected Employee(s)" Then
            ' Send the file to the selected employee(s) - implement your logic here
        ElseIf sentTo = "Storage" Then
            ' Store the file in the database
            StoreFileInDatabase(filePath, fileName) ' Pass the full file path and file name
        End If

        ' Display the file in the receiver's table layout panel
        'DisplayReceivedFile(selectedEmployees, fileName)
    End Sub

    Private Sub StoreFileInDatabase(filePath As String, fileName As String)
        Dim fileData As Byte() = File.ReadAllBytes(filePath)

        con.Open()

        Dim query As String = "INSERT INTO tbl_files (filename, file_data, sender_id, sent_to, sent_date) VALUES (@filename, @fileData, @senderId, @sentTo, @sentDate)"

        Using command As New MySqlCommand(query, con)
            command.Parameters.AddWithValue("@filename", fileName)
            command.Parameters.AddWithValue("@fileData", fileData)
            command.Parameters.AddWithValue("@senderId", LoginForm.loggedInEmployeeId)
            command.Parameters.AddWithValue("@sentTo", "Storage")
            command.Parameters.AddWithValue("@sentDate", DateTime.Now)

            command.ExecuteNonQuery()
        End Using

        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayReceivedFiles()
    End Sub

    Private Sub downloadBtn_Click(sender As Object, e As EventArgs) Handles downloadBtn.Click
        ' Check if any row is selected in the filesReceived DataGridView
        If filesReceived.SelectedCells.Count > 0 Then
            ' Get the index of the filename column
            Dim filenameColumnIndex As Integer = filesReceived.Columns("filename").Index

            ' Get the filename from the selected cell
            Dim selectedFilename As String = filesReceived.SelectedCells(filenameColumnIndex).Value.ToString()

            ' Create a SaveFileDialog to prompt the user for the download location
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.FileName = selectedFilename

            ' Display the SaveFileDialog and get the result
            Dim result As DialogResult = saveFileDialog.ShowDialog()

            ' If the user clicked the Save button in the SaveFileDialog, proceed with the file download
            If result = DialogResult.OK Then
                ' Get the file data from the database based on the selected filename
                Dim fileData As Byte() = GetFileDataFromDatabase(selectedFilename)

                ' Save the file to the selected location
                File.WriteAllBytes(saveFileDialog.FileName, fileData)

                ' Show a success message to the user
                MessageBox.Show("File downloaded successfully.")
            End If
        Else
            ' No cell is selected, display an error message
            MessageBox.Show("Please select a file to download.")
        End If
    End Sub

    Private Function GetFileDataFromDatabase(filename As String) As Byte()
        Dim fileData As Byte() = Nothing

        con.Open()

        Dim query As String = "SELECT file_data FROM tbl_files WHERE filename = @filename"
        Using command As New MySqlCommand(query, con)
            command.Parameters.AddWithValue("@filename", filename)

            Dim result As Object = command.ExecuteScalar()
            If result IsNot Nothing Then
                fileData = DirectCast(result, Byte())
            End If
        End Using

        con.Close()

        Return fileData
    End Function






    'End of selection buttons ====================================================================================
End Class