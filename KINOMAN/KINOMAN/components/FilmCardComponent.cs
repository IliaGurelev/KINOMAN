using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KINOMAN
{
    internal class FilmCardComponent
    {
        //~~~~Изменить тип данных film_info~~~~
        string _imageUrl;
        string _nameFilm;

        public FilmCardComponent(string url, string name)
        { 
            _imageUrl = url;
            _nameFilm = name;
        }

        // Create PictureBox
        static public System.Drawing.Image CreatePictureBoxFromUrl(string imageUrl)
        {
            using (WebClient client = new WebClient())
            {
                Stream stream = client.OpenRead(imageUrl);
                return System.Drawing.Image.FromStream(stream);
            }

        }

        public Tuple<PictureBox, System.Windows.Forms.Label> FilmCardCreateComponent() 
        {

            // Create PictureBox
            PictureBox filmCover = new PictureBox();
            filmCover.Image = CreatePictureBoxFromUrl(_imageUrl);
            filmCover.SizeMode = PictureBoxSizeMode.Zoom;
            filmCover.Width = 210;
            filmCover.Height = 250;
            filmCover.Anchor = AnchorStyles.None;

            // Create Label
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Text = _nameFilm;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label.AutoSize = false;
            label.AutoEllipsis = true;
            label.MaximumSize = new System.Drawing.Size(250, 0); 
            label.AutoSize = true;
           // label.Dock = DockStyle.Fill;
            label.Anchor = AnchorStyles.Top;

            return Tuple.Create(filmCover, label);
        }
    }
}
