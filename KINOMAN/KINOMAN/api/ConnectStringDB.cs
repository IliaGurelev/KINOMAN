using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN.api
{
    internal class ConnectStringDB
    {
        public static string GetConnetctString()
        {
            return "Host=localhost;Username=postgres;Password=123123;Database=kinoman";
        }
    }
}
