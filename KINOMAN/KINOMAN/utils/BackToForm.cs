using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN.utils
{
    internal class BackToForm
    {
        static public void BackToPrevForm(Form preForm, Form currentForm)
        {
            preForm.Show();
            currentForm.Close();
        }
    }
}
