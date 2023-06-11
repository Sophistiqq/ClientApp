Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Sub connection()
        con.ConnectionString = "server = localhost; username = root; password = 091534; database = db_CSMS"
    End Sub

End Module