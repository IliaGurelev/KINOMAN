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

namespace KINOMAN.form
{
    public partial class SignUp : Form
    {
        Form PrevForm;
        public SignUp(Form PrevForm)
        {
            InitializeComponent();

            this.PrevForm = PrevForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text != "")
            {
                if(passwordRepeatTextBox.Text == passwordTextBox.Text) 
                { 
                    string id = IdGenerator.idGenerate();
                    string login = loginTextBox.Text;
                    string password = passwordTextBox.Text;

                    if (!UserData.CheckLoginUniqueUser(login))
                    {
                        MessageBox.Show($"Логин {login} уже занят");
                    }
                    else
                    {
                        UserData.InsertUser(id, login, password);

                        MainPage mainPage = new MainPage(UserData.GetUser(loginTextBox.Text));
                        mainPage.Show();

                        this.Close();

                        MessageBox.Show("Успешная регистрация!");
                    }                  
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackToForm.BackToPrevForm(PrevForm, this);
        }
    }
}
