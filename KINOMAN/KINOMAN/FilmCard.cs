using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN
{
    internal class FilmCard
    {
        private Dictionary<string, string> filmInfo;
        public FilmCard(Dictionary<string, string> film) 
        {
            filmInfo = film;
        }

        static void FilmCardCreateComponent(Dictionary<string, string> filmInfo) 
        {
            foreach (var film in filmInfo)
            {
                string key = film.Key;
                string value = film.Value;
            }
        }
    }
}
