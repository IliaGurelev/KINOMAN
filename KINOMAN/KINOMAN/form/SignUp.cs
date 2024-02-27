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

namespace KINOMAN.form
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text != "")
            {
                if(passwordRepeatTextBox.Text == passwordTextBox.Text) 
                { 
                    string id = Guid.NewGuid().ToString();
                    string login = loginTextBox.Text;
                    string password = passwordTextBox.Text;

                    UserData.InsertUser(id, login, password);

                    MainPage mainPage = new MainPage(UserData.GetUser(loginTextBox.Text));
                    mainPage.Show();

                    this.Close();

                    MessageBox.Show("Успешная регистрация!");
                }
                else
                {
                    MessageBox.Show("Пароли в полях разные");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле [Логин]");
            }
        }
    }
}
