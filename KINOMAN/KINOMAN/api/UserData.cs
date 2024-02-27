using KINOMAN.api;
using Npgsql;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN.api
{
    internal class UserData
    {
        static public string[] GetUser(string loginInput)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT id, logins, passwords, icon FROM users WHERE logins = '"+ loginInput + "'";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string id = reader.GetString(0);
                            string login = reader.GetString(1);
                            string password = reader.GetString(2);
                            string icon = reader.GetString(3);

                            string[] userData = { id, login, password };

                            return userData;
                        }
                        else
                        {
                            string[] userData = new string[0];
                            return userData;
                        }
                    }
                }
            }
        }

        static public bool CheckUser(string loginInput, string passwordInput)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT logins, passwords FROM users WHERE logins = '" + loginInput + "'";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string login = reader.GetString(0);
                            string password = reader.GetString(1);

                            if(password == passwordInput)
                            {
                                return true;
                            }

                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        static public void InsertUser(string idInput, string loginInput, string passwordInput)
        {
            string connString = ConnectStringDB.GetConnetctString();

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    // Открытие подключения
                    conn.Open();

                    // Создание SQL-запроса INSERT
                    string sql = "INSERT INTO users (id, logins, passwords, icon) VALUES (@param1, @param2, @param3)";

                    // Создание команды с использованием SQL-запроса и подключения
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Добавление параметров к команде
                        cmd.Parameters.AddWithValue("param1", idInput);
                        cmd.Parameters.AddWithValue("param2", loginInput);
                        cmd.Parameters.AddWithValue("param3", passwordInput);

                        // Выполнение команды (вставка данных)
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка регестрации, возможно ваш логин уже занят");
                }
            }
        }
    }
}
