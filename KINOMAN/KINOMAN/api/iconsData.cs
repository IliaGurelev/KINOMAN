using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN.api
{
    internal class iconsData
    {
        static public List<string> getIconsURL()
        {
            List<string> icons = new List<string>();

            string connString = ConnectStringDB.GetConnetctString();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT image_url FROM icons";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            icons.Add(reader.GetString(0));
                        }

                        return icons;
                    }
                }
            }
        }
    }
}
