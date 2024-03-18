using KINOMAN.api;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KINOMAN.form
{
    public partial class UserOptionPage : Form
    {
        string[] dataUserTable;

        string imageUserId;
        string loginUser;
        string passwordUser;

        public UserOptionPage(string[] dataUserTableInput)
        {
            InitializeComponent();

            dataUserTable = dataUserTableInput;
            imageUserId = dataUserTable[3];
            loginUser = dataUserTable[1];
            passwordUser = dataUserTable[2];
        }

        private void UserOptionPage_Load(object sender, EventArgs e)
        {
            userIconPictureBox.Image = ConverterImageFromURL.ConvertImageFromURL(
                UserData.GetIconUrlUser(imageUserId));
            userIconPictureBox.Select();

            RenderIcon(iconsTableLayout);

            loginUserTextBox.Text = loginUser;
            loginUserTextBox.ForeColor = Color.White;
        }

        private static void RenderIcon(TableLayoutPanel container)
        {
            List<string> icons = iconsData.getIconsURL().GetRange(0, 7);

            int position = 1;

            foreach (string icon in icons)
            {         
                int[] positionIcon = UserPageOption.INDEX_IMAGE_OPTION_TABLE_LAYOUT()[position];
                PictureBox iconPictureBox = new PictureBox();
                iconPictureBox.Image = ConverterImageFromURL.ConvertImageFromURL(icon);
                iconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                iconPictureBox.Size = new Size(100, 100);
                //filmCard.Item1.Click += (sender, e) => MovieCardClick.MovieCardHandler_Click(sender, e, movieData, dataUserTable);
                iconPictureBox.Cursor = Cursors.Hand;

                container.Controls.Add(iconPictureBox, positionIcon[0], positionIcon[1]);

                position++;
            }
        }

        private void editLoginButton_Click(object sender, EventArgs e)
        {
            editLoginButton.Visible = false;

            loginUserTextBox.ReadOnly = false;
            loginUserTextBox.Enabled = true;
            loginUserTextBox.BorderStyle = BorderStyle.FixedSingle;

            loginUserTextBox.KeyDown += (sender, e) => TextBoxHandler_KeyDown(sender, e, loginUserTextBox);
        }

        private void editPasswordButton_Click(object sender, EventArgs e)
        {
            UserPageOptionPasswordAunteficator passwordAunteficator = new UserPageOptionPasswordAunteficator(loginUser, this);
            passwordAunteficator.Show();
        }

        public void renderEditPasswordForm()
        {
            editPasswordButton.Visible = false;

            passwordUserTextBox.Text = passwordUser;
            passwordUserTextBox.Enabled = true;
            passwordUserTextBox.ReadOnly = false;
            passwordUserTextBox.BorderStyle = BorderStyle.FixedSingle;

            passwordUserTextBox.KeyDown += (sender, e) => TextBoxHandler_KeyDown(sender, e, passwordUserTextBox);

        }

        private void TextBoxHandler_KeyDown(object sender, KeyEventArgs e, System.Windows.Forms.TextBox textBox)
        {
            if(e.KeyCode == Keys.Enter)
            {
                editLoginButton.Visible = true;
                editPasswordButton.Visible = false;

                textBox.ReadOnly = true;
                textBox.Enabled = false;
                textBox.BorderStyle = BorderStyle.None;

                //textBox.KeyDown -= TextBoxHandler_KeyDown();
                MessageBox.Show("Enter");
            }
        }
    }
}
