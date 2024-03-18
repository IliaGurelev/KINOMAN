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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (UserData.CheckUser(loginTextBox.Text, passwordTextBox.Text))
            {
                MainPage mainPage = new MainPage(UserData.GetUser(loginTextBox.Text));
                mainPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль не верный");
                passwordTextBox.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
