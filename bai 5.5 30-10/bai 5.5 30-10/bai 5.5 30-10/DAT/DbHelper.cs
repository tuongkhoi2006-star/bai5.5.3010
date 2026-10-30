using System.Data.SqlClient;

namespace InventoryApp.DAL
{
    public class DbHelper
    {
        // Chuỗi kết nối chuẩn LocalDB mặc định của Visual Studio
        public static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}