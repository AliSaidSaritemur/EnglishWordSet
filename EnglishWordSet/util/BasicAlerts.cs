﻿using System.Windows.Forms;

namespace EnglishWordSet.util
{
    static class BasicAlerts
    {
        public static void ErrorAlert(string errorMessage, string problem)
        {
            DialogResult dialogResult = MessageBox.Show(errorMessage, problem,
       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
