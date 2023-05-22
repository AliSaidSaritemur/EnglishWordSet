using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EnglishWordSet.util
{
    internal class ButtonTransactions
    {
        private System.Timers.Timer buttonTimer;
        Button button;
        Color lastColor;  
        public ButtonTransactions(Button _button)
        {
            button = _button;
            lastColor = button.BackColor;
        }
        
        public async void ChangeButtonColor(Color color,int second)
        {
            button.BackColor = color;
            SetTimer(second);
        }
        private void SetTimer(int second)
        {
            buttonTimer = new System.Timers.Timer(second*1000);
            buttonTimer.Elapsed += OnTimedEvent;
            buttonTimer.AutoReset = true;
            buttonTimer.Enabled = true;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            button.BackColor = lastColor;
            buttonTimer.Enabled = false;
        }
    }
}
