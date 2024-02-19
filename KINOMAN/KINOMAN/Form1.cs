using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 36, 34, 45);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int positionColumn = 0;
            int positionRow = 0;
            film_info filmInfo = new film_info();
            foreach(var film in filmInfo.GetMockItems())
            {
                string nameFilm = film.Name;
                string ImageFilm = film.ImageUrl;
                Tuple<System.Windows.Forms.PictureBox, System.Windows.Forms.Label> filmCard = 
                    new film_card_component(ImageFilm, nameFilm).FilmCardCreateComponent();

                tableLayoutPanel1.Controls.Add(filmCard.Item1, positionColumn, positionRow);
                tableLayoutPanel1.Controls.Add(filmCard.Item2, positionColumn, positionRow + 1);

                positionColumn++;
            }
   
        }
    }
}
