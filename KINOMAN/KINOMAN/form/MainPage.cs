
using KINOMAN.api;
using KINOMAN.constant;
using KINOMAN.form;
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
            this.BackColor = Color.FromArgb(16, 14, 25);
            tableLayoutPanel1.BackColor = Color.FromArgb(16, 14, 25);

            filmData = new FilmData().GetMovie();
            filmCount = filmData.Count;

            Render_Page(filmData);
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

            //Пользователь
            if(dataTableUser != null)
            {
                Render_User(dataTableUser);
            }
        }

        private void Render_Film(List<FilmData.Item> films, TableLayoutPanel container)
        {
            int position = 1;
            foreach (var film in films)
            {
                int[] positionImage  = IndexTableLayout.INDEX_IMAGE_TABLE_LAYOUT()[position];
                int[] positionText = IndexTableLayout.INDEX_TEXT_TABLE_LAYOUT()[position];

                string nameFilm = film.Name;
                string ImageFilm = film.ImageUrl;
                string description = film.Description;

                Tuple<System.Windows.Forms.PictureBox, System.Windows.Forms.Label> filmCard =
                    new FilmCardComponent(ImageFilm, nameFilm).FilmCardCreateComponent();

                filmCard.Item1.Click += (sender, e) => PictureMovie_Click(sender, e, nameFilm, ImageFilm, description);

                container.Controls.Add(filmCard.Item1, positionImage[0], positionImage[1]);
                container.Controls.Add(filmCard.Item2, positionText[0], positionText[1]);

                position++;
            }
        }

        private void Render_User(string[] dataUserTableInput)
        {
            LogInButton.Dispose();
            SignUpButton.Dispose();

            System.Windows.Forms.Label userLogin = new System.Windows.Forms.Label();
            userLogin.Text = dataTableUser[1];
            userLogin.ForeColor = Color.White;
            userLogin.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            userLogin.Location = new Point(768, 3);
            userLogin.AutoEllipsis = true;
            userLogin.Size = new Size(250, 25);



            this.Controls.Add(userLogin);
        }

        private void PictureMovie_Click(object sender, EventArgs e, string nameFilm, string imageUrl, string description)
        {
            MoviePage moviePage = new MoviePage(nameFilm, imageUrl, description);
            moviePage.Show();
        }
        private void clearTableLayout(TableLayoutPanel tableLP)
        {
            while (tableLP.Controls.Count > 0)
            {
                Control control = tableLP.Controls[0];
                tableLP.Controls.Remove(control);
                control.Dispose(); // Освобождаем ресурсы, связанные с элементом
            }
        }

        private void paginationNextButton_Click(object sender, EventArgs e)
        {
            if (startPositionListFilms + MainPageOption.MOVE_PAGINTAION_STEP <= filmCount)
            {
                clearTableLayout(tableLayoutPanel1);

                startPositionListFilms += MainPageOption.MOVE_PAGINTAION_STEP;

                Render_Page(filmData);
            }
        }

        private void paginationBackButton_Click(object sender, EventArgs e)
        {
            if (startPositionListFilms != 0)
            {
                clearTableLayout(tableLayoutPanel1);

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
