using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KINOMAN.utils
{
    internal class clearTable
    {
        static public void clearTableLayout(TableLayoutPanel tableLP)
        {
            while (tableLP.Controls.Count > 0)
            {
                Control control = tableLP.Controls[0];
                tableLP.Controls.Remove(control);
                control.Dispose(); // Освобождаем ресурсы, связанные с элементом
            }
        }

        static public void clearFlowLayoutPanel(FlowLayoutPanel tableLP)
        {
            while (tableLP.Controls.Count > 0)
            {
                Control control = tableLP.Controls[0];
                tableLP.Controls.Remove(control);
                control.Dispose(); // Освобождаем ресурсы, связанные с элементом
            }
        }
    }
}
