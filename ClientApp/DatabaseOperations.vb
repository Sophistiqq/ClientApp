Imports MySql.Data.MySqlClient

Module DatabaseOperations
    Public Function ValidateCredentials(username As String, password As String) As Boolean
        Dim query As String = "SELECT * FROM tbl_employee WHERE username = @username AND password = @password"

        ' Create a new MySqlCommand object
        Using cmd As New MySqlCommand(query, con)
            ' Set the parameters for the query
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            ' Open the connection
            con.Open()

            ' Execute the query and check if any rows are returned
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                Return reader.HasRows
            End Using
            con.Close()
        End Using
    End Function

    Public Sub ResetLoginFailedAttempts(username As String)
        Dim query As String = $"UPDATE tbl_employee SET loginFailedAttempts = 0 WHERE username = @username"

        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", username)

            ' Open the connection
            con.Open()

            cmd.ExecuteNonQuery()

            ' Close the connection
            con.Close()
        End Using
    End Sub

    Public Sub IncreaseLoginFailedAttempts(username As String)
        Dim query As String = $"UPDATE tbl_employee SET loginFailedAttempts = loginFailedAttempts + 1 WHERE username = @username"

        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", username)

            ' Open the connection
            con.Open()

            cmd.ExecuteNonQuery()

            ' Close the connection
            con.Close()
        End Using
    End Sub

    Public Function IsAccountTemporarilyBanned(username As String) As Boolean
        Dim query As String = $"SELECT loginFailedAttempts FROM tbl_employee WHERE username = @username"

        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", username)

            ' Open the connection
            con.Open()

            Dim result As Object = cmd.ExecuteScalar()

            ' Close the connection
            con.Close()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Dim loginFailedAttempts As Integer = Convert.ToInt32(result)
                Return loginFailedAttempts >= 3
            End If

            ' If the result is null or DBNull.Value, return false
            Return False
        End Using
    End Function

    Public Sub UpdateLastSignedAttempt(username As String)
        Dim currentDate As DateTime = DateTime.Now
        Dim query As String = $"UPDATE tbl_employee SET lastSigned = @lastSigned WHERE username = @username"

        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@lastSigned", currentDate)
            cmd.Parameters.AddWithValue("@username", username)

            ' Open the connection
            con.Open()

            cmd.ExecuteNonQuery()

            ' Close the connection
            con.Close()
        End Using
    End Sub
End Module
