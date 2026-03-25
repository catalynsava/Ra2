using MySqlConnector;
using System.Diagnostics;

namespace Ra.Database
{
    internal static class Conectare
    {
        
        public static bool ConectareDB() {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
            connectionStringBuilder.Server = Program.server;
            connectionStringBuilder.Database = Program.bazadedate;
            connectionStringBuilder.UserID = Program.utilizator;
            connectionStringBuilder.Password = Base64Compress.Decode( Program.parola );
            connectionStringBuilder.Port = Program.port;
            connectionStringBuilder.Pooling = false;
            connectionStringBuilder.ConnectionTimeout = 5;

            try
            {
                Program.Conexiune = new MySqlConnection(connectionStringBuilder.ConnectionString);
                Program.Conexiune.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Number:" + ex.Number + "\r\nMessage: " + ex.Message + "\r\nStackTrace:\r\n" + ex.StackTrace );
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            
        }
        public static void DeconectareDB()
        {
            if (Program.Conexiune.State == System.Data.ConnectionState.Open)
            {
                Program.Conexiune.Close();
            }
        }
    }
}
