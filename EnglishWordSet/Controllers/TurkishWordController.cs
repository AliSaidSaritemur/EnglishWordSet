using EnglishWordSet.Pages;
using EnglishWordSet.Pages.ChildFormPages.TurkishWordPage;
using EnglishWordSet.util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.Controllers
{
    public  class TurkishWordController
    {
        private RemovingTurkishWordPage _removingTurkishWordPage;

        public RemovingTurkishWordPage GetChildRemovingTurkishWordPage()
        {
            _removingTurkishWordPage = PageTransactions.GetRemovingTurkishWordPage();
            if (_removingTurkishWordPage.FormBorderStyle != FormBorderStyle.None)
            {
                _removingTurkishWordPage.FormBorderStyle = FormBorderStyle.None;
                _removingTurkishWordPage.MdiParent = TurkishWordPage.ActiveForm;
                _removingTurkishWordPage.Location = new Point(844, 25);
            }
            return _removingTurkishWordPage;
        }
    }
}
