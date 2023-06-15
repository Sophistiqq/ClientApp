Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm
    Public loggedInEmployeeId As Integer?
    Private Const MaxLoginAttempts As Integer = 3

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = usernameBox.Text
        Dim password As String = passwordBox.Text

        Try
            con.Open()

            Dim employeeId As Integer? = GetEmployeeId(username, password)
            If employeeId.HasValue Then
                loggedInEmployeeId = employeeId.Value
                UpdateEmployeeLastSigned(employeeId.Value)
                Dim firstName As String = GetFirstName(username)

                Dim mainForm As New Main
                mainForm.SetDisplayName(firstName)

                MessageBox.Show("Login successful!")
                mainForm.Show()
                Me.Hide()
            Else
                UpdateFailedLoginAttempts(username)

                Dim loginAttempts As Integer = GetLoginAttempts(username)
                If loginAttempts >= MaxLoginAttempts Then
                    DisableAccount(username)
                    MessageBox.Show("Invalid username or password. Your account has been disabled. Please Contact the Admin to assist your situation")
                Else
                    MessageBox.Show("Invalid username or password.")
                End If

                passwordBox.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function GetEmployeeId(username As String, password As String) As Integer?
        Dim query As String = "SELECT id FROM tbl_employees WHERE username = @username AND password = @password"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        Dim employeeId As Integer? = Nothing

        Using reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                employeeId = If(reader.IsDBNull(reader.GetOrdinal("id")), Nothing, reader.GetInt32("id"))
            End If
        End Using

        Return employeeId
    End Function

    Private Function GetLoginAttempts(username As String) As Integer
        Dim query As String = "SELECT loginFailedAttempts FROM tbl_employees WHERE username = @username"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", username)

        Dim loginAttempts As Integer = 0

        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso Not result Is DBNull.Value Then
            loginAttempts = Convert.ToInt32(result)
        End If

        Return loginAttempts
    End Function

    Private Sub DisableAccount(username As String)
        Dim randomPassword As String = GenerateRandomText(10) ' Change the length as needed

        Dim query As String = "UPDATE tbl_employees SET account_enabled = False, password = @password WHERE username = @username"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@password", randomPassword)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.ExecuteNonQuery()

        ' Check if a notification already exists for the employee and issue
        Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_notifications WHERE employee_id = (SELECT id FROM tbl_employees WHERE username = @username) AND issue = @issue"
        Dim checkCmd As New MySqlCommand(checkQuery, con)
        checkCmd.Parameters.AddWithValue("@username", username)
        checkCmd.Parameters.AddWithValue("@issue", "Login Failed Attempt")
        Dim notificationCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

        ' Insert a notification if it doesn't already exist
        If notificationCount = 0 Then
            Dim notificationQuery As String = "INSERT INTO tbl_notifications (employee_id, issue) SELECT id, @issue FROM tbl_employees WHERE username = @username"
            Dim notificationCmd As New MySqlCommand(notificationQuery, con)
            notificationCmd.Parameters.AddWithValue("@issue", "Login Failed Attempt")
            notificationCmd.Parameters.AddWithValue("@username", username)
            notificationCmd.ExecuteNonQuery()
        End If
    End Sub




    Private Function GenerateRandomText(length As Integer) As String
        Const validChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim rng As New RNGCryptoServiceProvider()
        Dim randomBytes(length - 1) As Byte
        rng.GetBytes(randomBytes)
        Dim result As New StringBuilder(length)

        For Each b As Byte In randomBytes
            result.Append(validChars(b Mod validChars.Length))
        Next

        Return result.ToString()
    End Function


    Private Sub UpdateEmployeeLastSigned(employeeId As Integer)
        Dim updateQuery As String = "UPDATE tbl_employees SET loginFailedAttempts = 0 WHERE id = @employeeId"
        Dim updateCmd As New MySqlCommand(updateQuery, con)
        updateCmd.Parameters.AddWithValue("@employeeId", employeeId)
        updateCmd.ExecuteNonQuery()
    End Sub

    Private Function GetFirstName(username As String) As String
        Dim query As String = "SELECT firstname FROM tbl_employees WHERE username = @username"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", username)

        Dim firstName As String = ""

        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing Then
            firstName = result.ToString()
        End If

        Return firstName
    End Function

    Private Sub UpdateFailedLoginAttempts(username As String)
        Dim updateQuery As String = "UPDATE tbl_employees SET loginFailedAttempts = loginFailedAttempts + 1 WHERE username = @username"
        Dim updateCmd As New MySqlCommand(updateQuery, con)
        updateCmd.Parameters.AddWithValue("@username", username)
        updateCmd.ExecuteNonQuery()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.EnableFormMovement(Me, moveBtn)

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
