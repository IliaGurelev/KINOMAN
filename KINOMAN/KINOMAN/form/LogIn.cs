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
    public partial class LogIn : Form
    {
        MainPage PrevMainPageForm;
        string[] dataUserTable;
        public LogIn(MainPage PrevMainPageForm)
        {
            InitializeComponent();
            this.PrevMainPageForm = PrevMainPageForm;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (UserData.CheckUser(loginTextBox.Text, passwordTextBox.Text))
            {
                CredentialStorage.SaveCredentials(loginTextBox.Text, passwordTextBox.Text);

                dataUserTable = UserData.GetUser(loginTextBox.Text);

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
            this.Close();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrevMainPageForm.RecreateForm(dataUserTable);
        }
    }
}
