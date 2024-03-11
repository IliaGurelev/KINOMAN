
using KINOMAN.api;
using KINOMAN.components;
using KINOMAN.constant;
using KINOMAN.form;
using KINOMAN.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KINOMAN
{
    public partial class MainPage : Form
    {
        public string[] dataTableUser = [];
        public MainPage(string[] dataUserInput = null)
        {
            InitializeComponent();
            dataTableUser = dataUserInput;
            
        }

        int startPositionListFilms = 0;
        int filmCount = 0;

        List<FilmData.Item> filmData;
        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(16, 14, 25);

            filmData = new FilmData().GetMovie();
            filmCount = filmData.Count;

            Render_Page(filmData);

            //Пользователь
            if (dataTableUser != null)
            {
                Render_User(dataTableUser);
            }
        }

        private void Render_Page(List<FilmData.Item> filmData)
        {
            //Фильмы
            List<FilmData.Item> films;
            if (filmData.Count >= startPositionListFilms + MainPageOption.MOVE_PAGINTAION_STEP)
            {
                films = filmData.GetRange(startPositionListFilms, MainPageOption.MOVE_PAGINTAION_STEP);
            }
            else
            {
                films = filmData.GetRange(startPositionListFilms, filmData.Count - startPositionListFilms);
            }

            Render_Film(films, tableLayoutPanel1);
        }

        private void Render_Film(List<FilmData.Item> films, TableLayoutPanel container)
        {
            int position = 1;
            foreach (var film in films)
            {
                int[] positionImage  = MainPageOption.INDEX_IMAGE_TABLE_LAYOUT()[position];
                int[] positionText = MainPageOption.INDEX_TEXT_TABLE_LAYOUT()[position];

                string nameFilm = film.Name;
                string ImageFilm = film.ImageUrl;
                string description = film.Description;

                Tuple<System.Windows.Forms.PictureBox, System.Windows.Forms.Label> filmCard =
                    new FilmCardComponent(ImageFilm, nameFilm).FilmCardCreateComponent();

                string[] movieData = [film.Id.ToString(), film.Name, film.Description, film.ImageUrl];

                filmCard.Item1.Click += (sender, e) => MovieCardClick.MovieCardHandler_Click(sender, e, movieData, dataTableUser);
                filmCard.Item1.Cursor = Cursors.Hand;

                container.Controls.Add(filmCard.Item1, positionImage[0], positionImage[1]);
                container.Controls.Add(filmCard.Item2, positionText[0], positionText[1]);

                position++;
            }
        }

        private void Render_User(string[] dataUserTableInput)
        {
            LogInButton.Dispose();
            SignUpButton.Dispose();

            var (iconUser, loginUser) = UserComponent.CreateUserElement(dataUserTableInput);
            loginUser.AutoSize = false;
            loginUser.Size = new Size(250, 25);
            loginUser.Location = new Point(744, 6);
            loginUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            iconUser.Size = new Size(31, 29);
            iconUser.Location = new Point(998, 3);

            loginUser.Click += (sender, e) => UserElement_Click(sender, e, dataUserTableInput);
            iconUser.Click += (sender, e) => UserElement_Click(sender, e, dataUserTableInput);

            loginUser.Cursor = Cursors.Hand;
            iconUser.Cursor = Cursors.Hand;

            this.Controls.Add(iconUser);
            this.Controls.Add(loginUser);
        }

        private void UserElement_Click(object sender, EventArgs e, string[] dataUserTableInput)
        {
            UserPage userPage = new UserPage(dataUserTableInput);
            userPage.Show();

            this.Hide();
        }

        private void paginationNextButton_Click(object sender, EventArgs e)
        {
            if (startPositionListFilms + MainPageOption.MOVE_PAGINTAION_STEP <= filmCount)
            {
                clearTable.clearTableLayout(tableLayoutPanel1);

                startPositionListFilms += MainPageOption.MOVE_PAGINTAION_STEP;

                Render_Page(filmData);
            }
        }

        private void paginationBackButton_Click(object sender, EventArgs e)
        {
            if (startPositionListFilms != 0)
            {
                clearTable.clearTableLayout(tableLayoutPanel1);

                startPositionListFilms -= MainPageOption.MOVE_PAGINTAION_STEP;

                Render_Page(filmData);
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}
