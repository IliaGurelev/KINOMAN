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
            public string Id { get; set; }
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
                            string id = reader.GetString(0);
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

        static public void InsertFavoriteMovie(string id,string idUser, string idMovie)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    // Открытие подключения
                    conn.Open();

                    // Создание SQL-запроса INSERT
                    string sql = "INSERT INTO favorite_movie (id, id_movie, id_user) VALUES (@param1, @param2, @param3)";

                    // Создание команды с использованием SQL-запроса и подключения
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Добавление параметров к команде
                        cmd.Parameters.AddWithValue("param1", id);
                        cmd.Parameters.AddWithValue("param2", idMovie);
                        cmd.Parameters.AddWithValue("param3", idUser);

                        // Выполнение команды (вставка данных)
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка связи при добавлении в избранное: " + ex);
                }
            }
        }

        static public void InsertWatchedMovie(string id, string idUser, string idMovie)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    // Открытие подключения
                    conn.Open();

                    // Создание SQL-запроса INSERT
                    string sql = "INSERT INTO watched_movie (id, id_movie, id_user) VALUES (@param1, @param2, @param3)";

                    // Создание команды с использованием SQL-запроса и подключения
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Добавление параметров к команде
                        cmd.Parameters.AddWithValue("param1", id);
                        cmd.Parameters.AddWithValue("param2", idMovie);
                        cmd.Parameters.AddWithValue("param3", idUser);

                        // Выполнение команды (вставка данных)
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка связи при добавлении в просмотренное: " + ex);
                }
            }
        }

        static public void DeleteMovieByID(string id)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    // Открытие подключения
                    conn.Open();

                    // Создание SQL-запроса INSERT
                    string sql = "DELETE FROM movie WHERE id = @param1";

                    // Создание команды с использованием SQL-запроса и подключения
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Добавление параметров к команде
                        cmd.Parameters.AddWithValue("param1", id);

                        // Выполнение команды (вставка данных)
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка связи при добавлении в просмотренное: " + ex);
                }
            }
        }
    }
}
