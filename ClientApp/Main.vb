Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlHelper.ApplyRoundedCorners(Panel1, 25)
        ControlHelper.ApplyRoundedCorners(chatPanel, 25)
        ControlHelper.ApplyRoundedCorners(filesharePanel, 25)

        LoadEmployeeData()
    End Sub




    Private Sub LoadEmployeeData()

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




    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click

    End Sub

    'File Selection Section ========================================================================
    Private Sub selectfileBtn_Click(sender As Object, e As EventArgs) Handles selectfileBtn.Click, fileTextBox.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the properties of the OpenFileDialog as per your requirements
        openFileDialog.Title = "Select a File"
        openFileDialog.Filter = "Document Files (*.doc;*.docx;*.pdf)|*.doc;*.docx;*.pdf|Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file name without the directory path
            Dim selectedFile As String = Path.GetFileName(openFileDialog.FileName)

            ' Display the selected file name in the TextBox
            fileTextBox.Text = selectedFile
        End If
    End Sub
    'End of Selection Section ========================================================================


    'This section handles the selection buttons ========================================================================
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        DataGridView1.ClearSelection()
        everyone.Checked = False
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

    Private Sub everyone_CheckedChanged(sender As Object, e As EventArgs) Handles everyone.CheckedChanged
        DataGridView1.ClearSelection()
    End Sub

    Private Sub storage_CheckedChanged(sender As Object, e As EventArgs) Handles storage.CheckedChanged
        DataGridView1.ClearSelection()
    End Sub

    Public Sub SetDisplayName(firstName As String)
        displayName.Text = firstName
    End Sub

    'End of selection buttons ====================================================================================
End Class