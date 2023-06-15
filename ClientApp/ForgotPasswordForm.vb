Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ForgotPasswordForm

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = usernameTextBox.Text
        Dim email As String = emailTextBox.Text
        Dim newPassword As String = newPasswordTextBox.Text
        Dim confirmNewPassword As String = confirmNewPasswordTextBox.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(newPassword) OrElse String.IsNullOrEmpty(confirmNewPassword) Then
            MessageBox.Show("Please fill in all the fields.")
            Return
        End If

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim checkAccountQuery As String = "SELECT account_enabled FROM tbl_employees WHERE username = @username"
            Dim checkCmd As New MySqlCommand(checkAccountQuery, con)
            checkCmd.Parameters.AddWithValue("@username", username)
            Dim accountEnabled As Boolean = Convert.ToBoolean(checkCmd.ExecuteScalar())

            If Not accountEnabled Then
                MessageBox.Show("Your account is disabled. Please contact an administrator for assistance.")
                Return
            End If

            Dim updateQuery As String = "UPDATE tbl_employees SET password = @newPassword, last_password_change = CURRENT_TIMESTAMP() WHERE username = @username AND email = @email"
            Dim cmd As New MySqlCommand(updateQuery, con)
            cmd.Parameters.AddWithValue("@newPassword", newPassword)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                InsertNotification(username)
                MessageBox.Show("Your password has been reset successfully.")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Invalid username or email.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub InsertNotification(username As String)
        Dim notificationQuery As String = "INSERT INTO tbl_notifications (employee_id, issue) SELECT id, @issue FROM tbl_employees WHERE username = @username"
        Dim notificationCmd As New MySqlCommand(notificationQuery, con)
        notificationCmd.Parameters.AddWithValue("@issue", "Password Reset")
        notificationCmd.Parameters.AddWithValue("@username", username)
        notificationCmd.ExecuteNonQuery()
    End Sub

End Class
