using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN.utils
{
    internal class ConverterImageFromURL
    {
        static public System.Drawing.Image ConvertImageFromURL(string imageUrl)
        {
            using (WebClient client = new WebClient())
            {
                Stream stream = client.OpenRead(imageUrl);
                return System.Drawing.Image.FromStream(stream);
            }

        }
    }
}
