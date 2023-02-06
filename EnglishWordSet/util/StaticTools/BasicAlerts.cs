using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.util.StaticTools
{
    static class BasicAlerts
    {
        public static void ErrorAlert(string errorMessage,string problem)
        {
            DialogResult dialogResult = MessageBox.Show(errorMessage, problem,
       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
