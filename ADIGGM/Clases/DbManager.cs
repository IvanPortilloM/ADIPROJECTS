using System.Data.SqlClient;

namespace ADIGGM.Clases
{
    public static class DbManager
    {
        private static string connectionString = @"Data Source=ADIGGM;Initial Catalog=TransporteAdiggm;Persist Security Info=True;User ID=SA;Password=ADIGGM*2016+";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
