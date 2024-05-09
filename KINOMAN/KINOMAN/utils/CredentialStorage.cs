using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace KINOMAN.utils
{
    class CredentialStorage
    {
        private static string filePath = "credentials.dat";

        // Метод для сохранения файла с учетными данными
        public static void SaveCredentials(string username, string password)
        {
            var userData = $"{username}:{password}";
            var encryptedData = ProtectedData.Protect(Encoding.UTF8.GetBytes(userData), null, DataProtectionScope.CurrentUser);
            File.WriteAllBytes(filePath, encryptedData);
        }

        // Метод для получения данных с файла с учетными данными
        public static (string Username, string Password) LoadCredentials()
        {
            try
            {
                var encryptedData = File.ReadAllBytes(filePath);
                var decryptedData = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
                var userData = Encoding.UTF8.GetString(decryptedData).Split(':');
                return (userData[0], userData[1]);
            }
            catch
            {
                return (null, null);
            }
        }

        // Метод для удаления файла с учетными данными
        public static void ClearCredentials()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
