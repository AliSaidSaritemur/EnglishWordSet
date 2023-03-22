using System;
using System.Windows.Forms;

namespace EnglishWordSet.util
{
    public static class MyKeyDownValueCheck
    {

        public static bool IsItUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && e.KeyCode != Keys.Shift && e.KeyCode != Keys.CapsLock && e.KeyCode != Keys.ShiftKey)
                return true;

            return false;
        }
        public static bool IsItEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return true;

            return false;
        }
        public static bool IsItDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                return true;

            return false;
        }
        public static bool IsItRight(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                return true;

            return false;
        }
        public static bool IsItLeft(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                return true;

            return false;
        }
    }
}
