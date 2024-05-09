using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Npgsql;
using KINOMAN.utils;

namespace KINOMAN.api
{
    internal class MovieAppendApi
    {
        static public async void MovieAppendInDB(string nameMovie, string descriptionMovie, string imagePath, string watchUrl)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    // Открытие подключения
                    conn.Open();

                    // Создание SQL-запроса INSERT
                    string sql = "INSERT INTO movie (id, name, description, image_url, watch_url) VALUES (@param1, @param2, @param3, @param4, @param5)";

                    //Загурзка изображения на сервер
                    string imageUrl = await ImageMovieAppend(imagePath);

                    //Генерация id записи
                    string idMovie = IdGenerator.idGenerate();

                    // Создание команды с использованием SQL-запроса и подключения
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Добавление параметров к команде
                        cmd.Parameters.AddWithValue("param1", idMovie);
                        cmd.Parameters.AddWithValue("param2", nameMovie);
                        cmd.Parameters.AddWithValue("param3", descriptionMovie);
                        cmd.Parameters.AddWithValue("param4", imageUrl);
                        cmd.Parameters.AddWithValue("param5", watchUrl);

                        // Выполнение команды (вставка данных)
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Фильм {nameMovie} успешно был добавлен");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка связи при добавлении в избранное: " + ex);
                }
            }
        }

        static public async Task<string> ImageMovieAppend(string imagePath)
        {
            //Imgbb
            string imageUrl = "";
            string apiKey = "dde87674464a0294ce5c6c7abb9c655d";
            string url = $"https://api.imgbb.com/1/upload?key={apiKey}";

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var form = new MultipartFormDataContent())
                    {
                        using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            using (var streamContent = new StreamContent(fileStream))
                            {
                                using (var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync()))
                                {
                                    fileContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data");
                                    form.Add(fileContent, "image", Path.GetFileName(imagePath));
                                    HttpResponseMessage response = await httpClient.PostAsync(url, form);

                                    string responseContent = await response.Content.ReadAsStringAsync();
                                    JObject jsonResponse = JObject.Parse(responseContent); // Парсинг ответа как JSON

                                    imageUrl = (string)jsonResponse["data"]["url"]; // Извлечение URL изображения
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            return imageUrl;
        }
    }
}
