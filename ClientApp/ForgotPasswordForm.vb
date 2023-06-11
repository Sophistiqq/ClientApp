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
        ' Retrieve the values from the textboxes
        Dim username As String = usernameTextBox.Text
        Dim email As String = emailTextBox.Text
        Dim newPassword As String = newPasswordTextBox.Text
        Dim confirmNewPassword As String = confirmNewPasswordTextBox.Text

        ' Perform validation on the input fields
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(newPassword) OrElse String.IsNullOrEmpty(confirmNewPassword) Then
            MessageBox.Show("Please fill in all the fields.")
            Return
        End If

        If newPassword <> confirmNewPassword Then
            MessageBox.Show("The new password and confirm new password do not match.")
            Return
        End If

        ' Update the password and last_password_change in the database
        Dim updateQuery As String = "UPDATE tbl_employees SET password = @newPassword, last_password_change = CURRENT_TIMESTAMP() WHERE username = @username AND email = @email"

        ' Create the command object with the update query and connection
        Dim cmd As New MySqlCommand(updateQuery, con)

        ' Set the parameter values for the update query
        cmd.Parameters.AddWithValue("@newPassword", newPassword)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@email", email)

        Try
            ' Open the connection
            con.Open()

            ' Execute the update query
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Check if any rows were affected by the update
            If rowsAffected > 0 Then
                ' Password update successful
                MessageBox.Show("Your password has been reset successfully.")

                ' Close the dialog with DialogResult.OK
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                ' Password update failed: Invalid username or email
                MessageBox.Show("Invalid username or email.")
            End If
        Catch ex As Exception
            ' Handle any errors that occurred during the password reset process
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Close the connection
            con.Close()
        End Try
    End Sub

End Class