using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN.api
{
    internal class UserMovieData
    {
        static public bool CheckFavoriteMovieInUser(string loginInput)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT movie.id FROM favorite_movie WHERE logins = '" + loginInput + "'";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }
        static public List<FilmData.Item> getFavoriteMovie(string idUser)
        {
            string connString = ConnectStringDB.GetConnetctString();
            List<FilmData.Item> itemList = new List<FilmData.Item>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = $"SELECT movie.id, movie.name, movie.description, movie.image_url, movie.watch_url FROM favorite_movie " +
                    "INNER JOIN movie ON movie.id = favorite_movie.id_movie " +
                    $"WHERE id_user = '{idUser}' ";

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
                            string watchUrl = reader.GetString(4);

                            // Создаем новый объект Item и добавляем его в список
                            FilmData.Item item = new FilmData.Item
                            {
                                Id = id,
                                Name = name,
                                Description = description,
                                ImageUrl = imageUrl,
                                WatchUrl = watchUrl,
                            };
                            itemList.Add(item);
                        }
                    }
                }
            }

            return itemList;
        }

        static public List<FilmData.Item> getWatchedMovie(string idUser)
        {
            string connString = ConnectStringDB.GetConnetctString();
            List<FilmData.Item> itemList = new List<FilmData.Item>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = $"SELECT movie.id, movie.name, movie.description, movie.image_url, movie.watch_url FROM watched_movie " +
                    "INNER JOIN movie ON movie.id = watched_movie.id_movie " +
                    $"WHERE id_user = '{idUser}' ";

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
                            string watchUrl = reader.GetString(4);

                            // Создаем новый объект Item и добавляем его в список
                            FilmData.Item item = new FilmData.Item
                            {
                                Id = id,
                                Name = name,
                                Description = description,
                                ImageUrl = imageUrl,
                                WatchUrl = watchUrl,
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
