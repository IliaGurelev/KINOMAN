using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN.utils
{
    internal class IdGenerator
    {
        static public string idGenerate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
