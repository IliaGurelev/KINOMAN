using KINOMAN.api;
using KINOMAN.utils;
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
        string _idMovie;
        string _nameFilm;
        string _description;
        string _imageUrl;

        string _idUser;
        public MoviePage(string[] filmDataTableInput, string[] dataUserTabel)
        {
            InitializeComponent();
            _idMovie = filmDataTableInput[0];
            _nameFilm = filmDataTableInput[1];
            _description = filmDataTableInput[2];
            _imageUrl = filmDataTableInput[3];

            if(dataUserTabel != null )
            {
                _idUser = dataUserTabel[0];
            }
        }

        private void MoviePage_Load(object sender, EventArgs e)
        {

            pictureBoxFilm.Image = ConverterImageFromURL.ConvertImageFromURL(_imageUrl);

            titleMovie.Text = _nameFilm;

            descriptionMovie.Text = _description;
        }

        private void addWatched_Click(object sender, EventArgs e)
        {
            if(_idUser != null)
            {
                FilmData.InsertWatchedMovie(IdGenerator.idGenerate(), _idUser, _idMovie);
            }
        }

        private void addFavorite_Click(object sender, EventArgs e)
        {
            if (_idUser != null)
            {
                FilmData.InsertFavoriteMovie(IdGenerator.idGenerate(), _idUser, _idMovie);
            }
        }
    }
}
