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
    public partial class UserPage : Form
    {
        string[] dataUserTable;
        public UserPage(string[] dataUserTableInput)
        {
            InitializeComponent();

            dataUserTable = dataUserTableInput;

            this.BackColor = Color.FromArgb(16, 14, 25);
            tableLayoutPanelMovie.BackColor = Color.FromArgb(16, 14, 25);
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            userLoginElement.Text = dataUserTable[1];
            userIconElement.Image = ConverterImageFromURL.ConvertImageFromURL(
                UserData.GetIconUrlUser(dataUserTable[3]));
        }

        private void openWatchedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
