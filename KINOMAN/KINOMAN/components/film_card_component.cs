using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN
{
    internal class film_card_component
    {
        //~Изменить тип данных film_info
        string _imageUrl;
        string _nameFilm;

        public film_card_component(string url, string name)
        { 
            _imageUrl = url;
            _nameFilm = name;
        }
        public PictureBox CreatePictureBoxFromUrl(string imageUrl)
        {
            PictureBox pictureBox = new PictureBox();

            using (WebClient client = new WebClient())
            {
                Stream stream = client.OpenRead(imageUrl);
                pictureBox.Image = Image.FromStream(stream);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 200;
                pictureBox.Height = 200;
            }

            return pictureBox;
        }

        public Tuple<PictureBox, Label> FilmCardCreateComponent() 
        {

            // Create PictureBox
            PictureBox filmCover = CreatePictureBoxFromUrl(_imageUrl);

            // Create Label
            Label label = new Label();
            label.Text = _nameFilm;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            return Tuple.Create(filmCover, label);
        }
    }
}
