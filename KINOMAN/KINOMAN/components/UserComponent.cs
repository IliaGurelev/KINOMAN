using KINOMAN.api;
using KINOMAN.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN.components
{
    internal class UserComponent
    {
        static public Tuple<PictureBox, Label> CreateUserElement(string[] dataUserTableInput)
        {
            System.Windows.Forms.Label userLogin = new System.Windows.Forms.Label();
            userLogin.Text = dataUserTableInput[1];
            userLogin.ForeColor = Color.White;
            userLogin.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            //userLogin.Location = new Point(768, 3);
            userLogin.AutoEllipsis = true;
            //userLogin.Size = new Size(250, 25);

            PictureBox picturUser = new PictureBox();
            picturUser.Image = ConverterImageFromURL.ConvertImageFromURL(
                UserData.GetIconUrlUser(dataUserTableInput[3]));
            picturUser.SizeMode = PictureBoxSizeMode.Zoom;

            return Tuple.Create(picturUser, userLogin);
        }
    }
}
