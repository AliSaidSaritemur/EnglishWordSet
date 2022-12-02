using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    public static class MyKeyDownValueCheck
    {

       public static Boolean IsItUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && e.KeyCode != Keys.Shift && e.KeyCode != Keys.CapsLock && e.KeyCode != Keys.ShiftKey)
                return true;    

                return false;   
        }
        public static Boolean IsItEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return true;

            return false;
        }
        public static Boolean IsItDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                return true;

            return false;
        }
        public static Boolean IsItRight(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Right)
                    return true;

                return false;
            }


        public static Boolean IsItLeft(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                return true;

            return false;
        }
    }
}
