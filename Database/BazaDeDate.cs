using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ra.Database
{
    static internal class BazaDeDate
    {
        static internal MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = Program.server,
            Database = Program.bazadedate,
            UserID = Program.utilizator,
            Password = Base64Compress.Decode(Program.parola),
            Port = Program.port,
            Pooling = false,
            ConnectionTimeout = 10
        };
        public static void ExecutaQuery(string sql, List<MySqlParameter> parametri, Action<MySqlDataReader> actiune)
        {
            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (parametri != null)
                        cmd.Parameters.AddRange(parametri.ToArray());
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            actiune(reader);
                        }
                    
                    }
                }
            }
        }
        public static int ExecutaNonQuery(string sql, List<MySqlParameter> parametri)
        {
            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (parametri != null)
                    {
                        cmd.Parameters.AddRange(parametri.ToArray());
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
