﻿using KINOMAN.api;
using KINOMAN.components;
using KINOMAN.constant;
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
using System.Xml.Linq;

namespace KINOMAN.form
{
    public partial class UserPage : Form
    {
        string[] dataUserTable;

        string idUser;
        string loginUser;
        string imageUserId;

        List<FilmData.Item> watchedMovieData;
        List<FilmData.Item> favoriteMovieData;


        int startPositionListFilms = 0;
        int filmCount = 0;

        public UserPage(string[] dataUserTableInput)
        {
            InitializeComponent();

            dataUserTable = dataUserTableInput;
            idUser = dataUserTable[0];
            loginUser = dataUserTable[1];
            imageUserId = dataUserTable[3];

            tableLayoutPanelMovie.BackColor = Color.FromArgb(16, 14, 25);
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            userLoginElement.Text = loginUser;
            userIconElement.Image = ConverterImageFromURL.ConvertImageFromURL(
                UserData.GetIconUrlUser(imageUserId));

            watchedMovieData = UserMovieData.getWatchedMovie(idUser);
            favoriteMovieData = UserMovieData.getFavoriteMovie(idUser);

            favoriteCountLabel.Text = favoriteMovieData.Count.ToString();
            watchedCountLabel.Text = watchedMovieData.Count.ToString();

            RenderMovieList(watchedMovieData, tableLayoutPanelMovie);
        }

        private void openWatchedButton_Click(object sender, EventArgs e)
        {
            clearTable.clearTableLayout(tableLayoutPanelMovie);

            RenderMovieList(UserMovieData.getWatchedMovie(idUser), tableLayoutPanelMovie);

            labelNameList.Text = "Просмотренно";
        }

        private void openFavoriteButton_Click(object sender, EventArgs e)
        {
            clearTable.clearTableLayout(tableLayoutPanelMovie);

            RenderMovieList(favoriteMovieData, tableLayoutPanelMovie);

            labelNameList.Text = "Избранное";
        }

        private void optionUserButton_Click(object sender, EventArgs e)
        {
            UserOptionPage userOption = new UserOptionPage(dataUserTable);
            userOption.Show();
            this.Close();
        }

        private void RenderMovieList(List<FilmData.Item> filmData, TableLayoutPanel container)
        {
            List<FilmData.Item> films;
            if (filmData.Count >= startPositionListFilms + UserPageOption.MOVE_PAGINTAION_STEP)
            {
                films = filmData.GetRange(startPositionListFilms, UserPageOption.MOVE_PAGINTAION_STEP);
            }
            else
            {
                films = filmData.GetRange(startPositionListFilms, filmData.Count - startPositionListFilms);
            }

            int position = 1;
            foreach (var film in films)
            {
                int[] positionImage = UserPageOption.INDEX_IMAGE_TABLE_LAYOUT()[position];
                int[] positionText = UserPageOption.INDEX_TEXT_TABLE_LAYOUT()[position];

                string nameFilm = film.Name;
                string ImageFilm = film.ImageUrl;
                string description = film.Description;

                Tuple<System.Windows.Forms.PictureBox, System.Windows.Forms.Label> filmCard =
                    new FilmCardComponent(ImageFilm, nameFilm).FilmCardCreateComponent();

                string[] movieData = [film.Id.ToString(), film.Name, film.Description, film.ImageUrl];

                filmCard.Item1.Click += (sender, e) => MovieCardClick.MovieCardHandler_Click(sender, e, movieData, dataUserTable);
                filmCard.Item1.Cursor = Cursors.Hand;

                container.Controls.Add(filmCard.Item1, positionImage[0], positionImage[1]);
                container.Controls.Add(filmCard.Item2, positionText[0], positionText[1]);

                position++;
            }
        }
    }
}
