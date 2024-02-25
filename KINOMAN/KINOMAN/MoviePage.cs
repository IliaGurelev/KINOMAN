using KINOMAN.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN
{
    public partial class MoviePage : Form
    {
        string _nameFilm;
        string _imageUrl;
        string _description;
        public MoviePage(string nameFilm, string imageURL, string description )
        {
            InitializeComponent();
            _nameFilm = nameFilm;
            _imageUrl = imageURL;
            _description = description;
        }

        private void MoviePage_Load(object sender, EventArgs e)
        {
            pictureBoxFilm.Image = FilmCardComponent.CreatePictureBoxFromUrl(_imageUrl);

            titleMovie.Text = _nameFilm;

            descriptionMovie.Text = _description;
        }
    }
}
