using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
   static class MyTestInternet
    {
        public static bool IsThereInternet()
        {
            string adress = "https://www.google.com";
            bool accsessResult = true;
            try
            {
                WebRequest webRequest = WebRequest.Create(adress);
                webRequest.GetResponse();
                accsessResult = true;

            }
            catch (Exception)
            {
                accsessResult = false;

            }
            return accsessResult;
        }
    }
}
