using Google.Cloud.Translation.V2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.RefactoredStaticFuncs
{
   static class MyTranslater
    {
       public static string TranslateEnglishToTurkish(string Engl) {


            WebBrowser webBrowser= new WebBrowser();

            webBrowser.Navigate("https://translate.google.com.tr/#en/tr");
            return Engl;

        }
      
    }
    }


