Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ForgotPasswordForm

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlHelper.ApplyRoundedCorners(Button1, 15)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = usernameTextBox.Text
        Dim email As String = emailTextBox.Text

        ' Create the SQL query to retrieve the password for the given username and email
        Dim query As String = "SELECT password FROM tbl_employee WHERE username = @username AND email = @email"

        ' Create a MySqlCommand object and assign the query and connection
        cmd = New MySqlCommand(query, con)

        ' Set the parameters for the query
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@email", email)

        Try
            ' Open the database connection
            con.Open()

            ' Execute the query and retrieve the result
            Dim password As Object = cmd.ExecuteScalar()

            If password IsNot Nothing Then
                ' Password found, display it to the user
                MessageBox.Show("Your password is: " & password.ToString())
            Else
                ' No password found, display an error message
                MessageBox.Show("Invalid username or email!")
            End If

            ' Close the database connection
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
