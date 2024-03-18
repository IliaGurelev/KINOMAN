using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN.components
{
    internal class MovieCardClick
    {
        static public void MovieCardHandler_Click(object sender, EventArgs e, string[] movieDataInput, string[] dataTableUserInput)
        {
            MoviePage moviePage = new MoviePage(movieDataInput, dataTableUserInput);
            moviePage.Show();
        }
    }
}
