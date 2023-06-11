Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = usernameBox.Text
        Dim password As String = passwordBox.Text

        ' Query to check if the username and password match an employee in the database
        Dim query As String = "SELECT id, loginFailedAttempts FROM tbl_employees WHERE username = @username AND password = @password"

        ' Create the command object with the query and connection
        Dim cmd As New MySqlCommand(query, con)

        ' Set the parameter values for username and password
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        Try
            ' Open the connection
            con.Open()

            ' Execute the query and retrieve the results
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if any rows are returned
            If reader.Read() Then
                ' Retrieve the employee information from the reader
                Dim employeeId As Integer = reader.GetInt32("id")
                Dim loginAttempts As Integer = reader.GetInt32("loginFailedAttempts")

                ' Close the reader before executing subsequent queries
                reader.Close()

                ' Reset login failed attempts
                loginAttempts = 0

                ' Update the last signed timestamp
                Dim updateQuery As String = "UPDATE tbl_employees SET lastSigned = CURRENT_TIMESTAMP(), loginFailedAttempts = @loginAttempts WHERE id = @employeeId"

                ' Create another command object for the update query
                Dim updateCmd As New MySqlCommand(updateQuery, con)

                ' Set the parameter values for the update query
                updateCmd.Parameters.AddWithValue("@loginAttempts", loginAttempts)
                updateCmd.Parameters.AddWithValue("@employeeId", employeeId)

                ' Execute the update query
                updateCmd.ExecuteNonQuery()

                ' Retrieve the first name from the database
                Dim firstName As String = RetrieveFirstName(username)

                ' Open the Main form and pass the first name
                Dim mainForm As New Main
                mainForm.SetDisplayName(firstName)

                ' Login successful
                MessageBox.Show("Login successful!")
                mainForm.Show()
                Me.Hide()
            Else
                ' Close the reader before executing subsequent queries
                reader.Close()

                ' Login failed: Invalid username or password
                MessageBox.Show("Invalid username or password.")

                ' Increase login failed attempts
                Dim updateQuery As String = "UPDATE tbl_employees SET loginFailedAttempts = loginFailedAttempts + 1 WHERE username = @username"

                ' Create another command object for the update query
                Dim updateCmd As New MySqlCommand(updateQuery, con)

                ' Set the parameter values for the update query
                updateCmd.Parameters.AddWithValue("@username", username)

                ' Execute the update query
                updateCmd.ExecuteNonQuery()
            End If

        Catch ex As Exception
            ' Handle any errors that occurred during the login process
            MessageBox.Show("An error occurred: " & ex.Message)

        Finally
            ' Close the connection
            con.Close()
        End Try
    End Sub

    Private Function RetrieveFirstName(username As String) As String
        ' Create and execute an SQL query to retrieve the first name based on the username
        Dim query As String = "SELECT firstname FROM tbl_employees WHERE username = @username"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", username)

        Dim firstName As String = ""

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                firstName = result.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Return firstName
    End Function


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub forgotPassword_Click(sender As Object, e As EventArgs) Handles forgotPassword.Click
        Dim forgotPasswordForm As New ForgotPasswordForm()
        Dim result As DialogResult = forgotPasswordForm.ShowDialog()

        ' Check the result when the dialog is closed
        If result = DialogResult.OK Then
            ' Password reset successful
            MessageBox.Show("Your password has been reset successfully.")
        ElseIf result = DialogResult.Cancel Then
            ' Forgot password operation cancelled
            MessageBox.Show("Forgot password operation cancelled.")
        End If
    End Sub
End Class
