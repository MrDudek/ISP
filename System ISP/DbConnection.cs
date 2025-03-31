using Microsoft.Data.SqlClient;

namespace System_ISP
{
    public class DBConnection
    {
        private static readonly string connectionString =
            "Server=194.92.64.24,12145;Database=IOpsk;User Id=mirek;Password=ZAQ!2wsx;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
