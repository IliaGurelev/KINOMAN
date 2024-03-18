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
    public partial class UserPageOptionPasswordAunteficator : Form
    {
        string userLogin;
        UserOptionPage userOptionPage;
        public UserPageOptionPasswordAunteficator(string userLoginInput, UserOptionPage userOptionPageInput)
        {
            InitializeComponent();
            userLogin = userLoginInput;
            userOptionPage = userOptionPageInput;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (UserData.CheckUser(userLogin, passwordTextBox.Text))
            {
                MessageBox.Show("Всё верно!");
                userOptionPage.renderEditPasswordForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}
