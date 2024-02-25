using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace KINOMAN.api
{
    internal class FilmData
    {
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
        }
        public List<Item> GetMovie()
        {
            string connString = ConnectStringDB.GetConnetctString();
            List<Item> itemList = new List<Item>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT id, name, description, image_url FROM movie";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string description = reader.GetString(2);
                            string imageUrl = reader.GetString(3);

                            // Создаем новый объект Item и добавляем его в список
                            Item item = new Item
                            {
                                Id = id,
                                Name = name,
                                Description = description,
                                ImageUrl = imageUrl
                            };
                            itemList.Add(item);
                        }
                    }
                }
            }

            return itemList;
        }
    }
}
