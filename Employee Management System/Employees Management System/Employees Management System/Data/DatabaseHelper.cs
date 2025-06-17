using System.Data.SqlClient;

public class DatabaseHelper
{
    private static string connectionString = "Data Source=DESKTOP-X-97\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public static bool ValidateAdminLogin(string username, string password)
    {
        using (SqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(1) FROM Admins WHERE Username = @Username AND Password = @Password";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = (int)cmd.ExecuteScalar();
                return count == 1;
            }
        }
    }
}