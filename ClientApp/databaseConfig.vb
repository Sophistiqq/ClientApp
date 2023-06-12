Imports MySql.Data.MySqlClient

Module databaseConfig
    Public connectionString As String = "server=localhost;username=root;password=091534;database=db_CSMS"

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Sub connection()
        con.ConnectionString = "server = localhost; username = root; password = 091534; database = db_CSMS"
    End Sub

End Module
