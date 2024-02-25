
using KINOMAN.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Dictionary<int, int[]> INDEX_IMAGE_TABLE_LAYOUT = new Dictionary<int, int[]>()
        {
            {1, new int[] {0, 0}},
            {2, new int[] {1, 0}},
            {3, new int[] {2, 0}},
            {4, new int[] {3, 0}},
            {5, new int[] {4, 0}},
            {6, new int[] {0, 2}},
            {7, new int[] {1, 2}},
            {8, new int[] {2, 2}},
            {9, new int[] {3, 2}},
            {10, new int[]{4, 2}},
        };

        Dictionary<int, int[]> INDEX_TEXT_TABLE_LAYOUT = new Dictionary<int, int[]>()
        {
            {1, new int[] {0, 1}},
            {2, new int[] {1, 1}},
            {3, new int[] {2, 1}},
            {4, new int[] {3, 1}},
            {5, new int[] {4, 1}},
            {6, new int[] {0, 3}},
            {7, new int[] {1, 3}},
            {8, new int[] {2, 3}},
            {9, new int[] {3, 3}},
            {10, new int[]{4, 3}},
        };

        int startPositionListFilms = 0;
        int filmCount = 0;

        int MOVE_PAGINTAION_STEP = 10;

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
            if (filmData.Count >= startPositionListFilms + MOVE_PAGINTAION_STEP)
            {
                films = filmData.GetRange(startPositionListFilms, MOVE_PAGINTAION_STEP);
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
                int[] positionImage  = INDEX_IMAGE_TABLE_LAYOUT[position];
                int[] positionText = INDEX_TEXT_TABLE_LAYOUT[position];

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
            if (startPositionListFilms + MOVE_PAGINTAION_STEP <= filmCount)
            {
                clearTableLayout(tableLayoutPanel1);

                startPositionListFilms += MOVE_PAGINTAION_STEP;

                Render_Page(filmData);
            }
        }

        private void paginationBackButton_Click(object sender, EventArgs e)
        {
            if (startPositionListFilms != 0)
            {
                clearTableLayout(tableLayoutPanel1);

                startPositionListFilms -= MOVE_PAGINTAION_STEP;

                Render_Page(filmData);
            }
        }
    }
}
