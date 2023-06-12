Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadEmployeeData()
            DisplayStorageFiles()
            DisplayReceivedFiles()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadEmployeeData()
        Using con As New MySqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT CONCAT(firstname, ' ', lastname) AS full_name FROM tbl_employees"
            Dim adapter As New MySqlDataAdapter(query, con)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
            DataGridView1.ColumnHeadersVisible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
    End Sub


    Private Sub DisplayStorageFiles()
        storageFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        storageFiles.Columns.Clear()

        Using con As New MySqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT filename FROM tbl_files WHERE sent_to = 'Storage'"
            Dim adapter As New MySqlDataAdapter(query, con)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            storageFiles.DataSource = dataTable
            storageFiles.Columns("filename").HeaderText = "Storage Files"
            storageFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            storageFiles.ColumnHeadersVisible = False
        End Using
    End Sub

    Private Sub DisplayReceivedFiles()
        receivedFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        receivedFiles.Columns.Clear()

        Using con As New MySqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT filename FROM tbl_files WHERE sent_to = @employeeId"
            Dim adapter As New MySqlDataAdapter(query, con)
            adapter.SelectCommand.Parameters.AddWithValue("@employeeId", LoginForm.loggedInEmployeeId)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            receivedFiles.DataSource = dataTable
            receivedFiles.Columns("filename").HeaderText = "Received Files"
            receivedFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            receivedFiles.ColumnHeadersVisible = False
        End Using
    End Sub


    Private Sub selectfileBtn_Click(sender As Object, e As EventArgs) Handles selectfileBtn.Click, fileTextBox.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Title = "Select a File"
        openFileDialog.Filter = "Document Files (*.doc;*.docx;*.pdf)|*.doc;*.docx;*.pdf|Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            fileTextBox.Text = openFileDialog.FileName
        End If
    End Sub


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
        Try
            Dim selectedEmployees As New List(Of String)()

            For Each rowIndex As Integer In DataGridView1.SelectedCells.Cast(Of DataGridViewCell)().Select(Function(cell) cell.RowIndex).Distinct()
                Dim fullName As String = DataGridView1.Rows(rowIndex).Cells("full_name").Value.ToString()
                selectedEmployees.Add(fullName)
            Next


            If selectedEmployees.Count > 0 AndAlso fileTextBox.Text <> "" Then
                Dim fileName As String = Path.GetFileName(fileTextBox.Text)
                Dim successCount As Integer = 0

                For Each fullName As String In selectedEmployees
                    Dim employeeId As String = GetEmployeeId(fullName)

                    If employeeId <> "" Then
                        StoreFileInDatabase(fileName, employeeId)
                        successCount += 1
                    End If
                Next

                If successCount > 0 Then
                    MessageBox.Show($"File sent successfully to {successCount} employee(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error: Failed to send file to any employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                ' Clear the form after sending the file
                clearBtn.PerformClick()
                DisplayReceivedFiles()
            Else
                MessageBox.Show("Please select at least one employee and choose a file to send.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while sending the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetEmployeeId(fullName As String) As String
        Dim employeeId As String = ""

        Using con As New MySqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT id FROM tbl_employees WHERE CONCAT(firstname, ' ', lastname) = @fullName"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fullName", fullName)
            cmd.ExecuteNonQuery()

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                employeeId = result.ToString()
                MessageBox.Show($"Employee ID for {fullName}: {employeeId}", "Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error: Failed to retrieve employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

        Return employeeId
    End Function
    Private Sub StoreFileInDatabase(fileName As String, employeeId As String)
        Dim fileBytes As Byte() = File.ReadAllBytes(fileTextBox.Text)

        Using con As New MySqlConnection(connectionString)
            con.Open()
            Dim query As String = "INSERT INTO tbl_files (filename, file_data, sent_to) VALUES (@filename, @file_data, @employeeId)"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@filename", fileName)
            cmd.Parameters.AddWithValue("@file_data", fileBytes)
            cmd.Parameters.AddWithValue("@employeeId", employeeId)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayStorageFiles()
        DisplayReceivedFiles()
    End Sub

    Private Sub downloadBtn_Click(sender As Object, e As EventArgs) Handles downloadBtn.Click
        If storageFiles.SelectedCells.Count > 0 Then
            Dim filenameColumnIndex As Integer = storageFiles.Columns("filename").Index
            Dim selectedFilename As String = storageFiles.SelectedCells(filenameColumnIndex).Value.ToString()
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.FileName = selectedFilename
            Dim result As DialogResult = saveFileDialog.ShowDialog()
            If result = DialogResult.OK Then
                Dim fileData As Byte() = GetFileDataFromDatabase(selectedFilename)
                File.WriteAllBytes(saveFileDialog.FileName, fileData)
                MessageBox.Show("File downloaded successfully.")
            End If
        Else
            MessageBox.Show("Please select a file to download.")
        End If
    End Sub

    Private Function GetFileDataFromDatabase(filename As String) As Byte()
        Dim fileData As Byte() = Nothing
        Using con As New MySqlConnection(connectionString)
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
        End Using
    End Function

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log out?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

End Class