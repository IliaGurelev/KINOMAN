using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            string imageUrl = ImageUrlTextBox.Text.Trim();
            // Load image from URL
            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData(imageUrl);
            MemoryStream stream = new MemoryStream(imageData);
            Image image = Image.FromStream(stream);

            // Create PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 200;
            pictureBox.Height = 200;

            // Create Label
            Label label = new Label();
            label.Text = Path.GetFileName(imageUrl.Replace(".jpg", ""));
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Add PictureBox and Label to TableLayoutPanel
            tableLayoutPanel1.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(label, 0, 1);

           /* // Add TableLayoutPanel to the form
            Controls.Add(tableLayoutPanel1);*/
        }
    }
}
