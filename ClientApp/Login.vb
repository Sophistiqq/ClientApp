Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public loggedInEmployeeId As Integer?

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = usernameBox.Text
        Dim password As String = passwordBox.Text

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query As String = "SELECT id, loginFailedAttempts FROM tbl_employees WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                loggedInEmployeeId = If(reader.IsDBNull(reader.GetOrdinal("id")), Nothing, reader.GetInt32("id"))
                Dim employeeId As Integer = If(reader.IsDBNull(reader.GetOrdinal("id")), Nothing, reader.GetInt32("id"))
                Dim loginAttempts As Integer = If(reader.IsDBNull(reader.GetOrdinal("loginFailedAttempts")), Nothing, reader.GetInt32("loginFailedAttempts"))

                reader.Close()

                loginAttempts = 0

                Dim updateQuery As String = "UPDATE tbl_employees SET lastSigned = CURRENT_TIMESTAMP(), loginFailedAttempts = @loginAttempts WHERE id = @employeeId"
                Dim updateCmd As New MySqlCommand(updateQuery, con)
                updateCmd.Parameters.AddWithValue("@loginAttempts", loginAttempts)
                updateCmd.Parameters.AddWithValue("@employeeId", employeeId)
                updateCmd.ExecuteNonQuery()

                Dim firstName As String = RetrieveFirstName(username)

                Dim mainForm As New Main
                mainForm.SetDisplayName(firstName)

                MessageBox.Show("Login successful!")
                mainForm.Show()
                Me.Hide()
            Else
                reader.Close()

                MessageBox.Show("Invalid username or password.")

                Dim updateQuery As String = "UPDATE tbl_employees SET loginFailedAttempts = loginFailedAttempts + 1 WHERE username = @username"
                Dim updateCmd As New MySqlCommand(updateQuery, con)
                updateCmd.Parameters.AddWithValue("@username", username)
                updateCmd.ExecuteNonQuery()
                passwordBox.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Function RetrieveFirstName(username As String) As String
        Dim query As String = "SELECT firstname FROM tbl_employees WHERE username = @username"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", username)

        Dim firstName As String = ""

        Try
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                firstName = result.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return firstName
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection()
        Catch ex As Exception
            MessageBox.Show("An error occurred while establishing the database connection: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub forgotPassword_Click(sender As Object, e As EventArgs) Handles forgotPassword.Click
        Dim forgotPasswordForm As New ForgotPasswordForm()
        Dim result As DialogResult = forgotPasswordForm.ShowDialog()

        If result = DialogResult.OK Then
            MessageBox.Show("Your password has been reset successfully.")
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Forgot password operation cancelled.")
        End If
    End Sub
End Class
