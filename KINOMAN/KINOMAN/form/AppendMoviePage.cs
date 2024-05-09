using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KINOMAN.api;

namespace KINOMAN.form
{
    public partial class AppendMoviePage : Form
    {
        string ImagePath = "";
        MainPage mainPageForm;
        public AppendMoviePage(MainPage mainPageForm)
        {
            InitializeComponent();

            FileDialogAddImageMovie.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png";
            FileDialogAddImageMovie.FilterIndex = 1;
            this.mainPageForm = mainPageForm;
        }

        private void AddPictureMovieBox_Click(object sender, EventArgs e)
        {
            if (FileDialogAddImageMovie.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                ImagePath = FileDialogAddImageMovie.FileName;

                // Здесь можно добавить код для работы с выбранным изображением, например, отобразить его в элементе PictureBox
                try
                {
                    AddPictureMovieBox.Image = Image.FromFile(ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            string nameMovie = NameMovieTextBox.Text;
            string descriptionMovie = DescriptionMovieTextBox.Text;
            string watchUrl = watchUrlTextBox.Text;

            if (!string.IsNullOrEmpty(nameMovie) && !string.IsNullOrEmpty(descriptionMovie) && !string.IsNullOrEmpty(ImagePath))
            {
<<<<<<< HEAD
                MovieAppendApi.MovieAppendInDB(nameMovie, descriptionMovie, ImagePath, watchUrl);

                NameMovieTextBox.Text = "";
                DescriptionMovieTextBox.Text = "";
                watchUrlTextBox.Text = "";
                AddPictureMovieBox.Image = null;
=======
                MovieAppendApi.MovieAppendInDB(nameMovie, descriptionMovie, ImagePath);
<<<<<<< HEAD
<<<<<<< HEAD
                this.Close();
=======
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
=======
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
>>>>>>> e268e2396e27078ba6dba8bdad76a3fb747774b9
            }
            else
            {
                MessageBox.Show("Заполните все поля и добавьте обложку фильма");
            }
        }
    }
}
