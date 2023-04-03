using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Concrete;
using PostSharp.Aspects.Advices;
using Microsoft.Extensions.Configuration;
using EnglishWordSet.util;

namespace EnglishWordSet
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            DbConnetcion();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(PageTransactions.GetLoginPage());
        }

        private static async void DbConnetcion()
        {
            UserImpl userImpl = new();
            userImpl.IsThereUserName(" ");
        }
    }
}
