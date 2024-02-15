Module Connection
    Dim constr As String = "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Logins;Integrated Security=True"
    Public conn As New SqlClient.SqlConnection(constr)
End Module
