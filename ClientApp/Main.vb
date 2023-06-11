Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlHelper.ApplyRoundedCorners(Panel1, 25)
        ControlHelper.ApplyRoundedCorners(chatPanel, 25)
        ControlHelper.ApplyRoundedCorners(filesharePanel, 25)
        DataGridView1.ClearSelection()
        ' Retrieve data from the database
        Dim dataTable As DataTable = GetDataFromDatabase()
        ' Configure the DataGridView
        DataGridView1.ClearSelection()
        ConfigureDataGridView()
        ' Bind the data to the DataGridView
        DataGridView1.DataSource = dataTable
        DataGridView1.ClearSelection()
    End Sub

    Private Function GetDataFromDatabase() As DataTable
        Dim dataTable As New DataTable()

        Using con As New MySqlConnection("server=localhost;username=root;password=091534;database=db_CSMS")
            Dim query As String = "SELECT CONCAT(firstname, ' ', lastname) AS Employees FROM tbl_employee"
            Using adapter As New MySqlDataAdapter(query, con)
                adapter.Fill(dataTable)
            End Using
        End Using

        Return dataTable
    End Function

    Private Sub ConfigureDataGridView()
        ' Hide the row header column

        DataGridView1.RowHeadersVisible = False
        ' Configure the DataGridView
        DataGridView1.ColumnHeadersVisible = False


        ' Disable column sorting
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub


    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click

    End Sub

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

    Private Sub filesharePanel_Paint(sender As Object, e As PaintEventArgs) Handles filesharePanel.Paint

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        everyone.Checked = False
        selected.Checked = False
        storage.Checked = False
        DataGridView1.ClearSelection()
        DataGridView1.Enabled = False
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
End Class