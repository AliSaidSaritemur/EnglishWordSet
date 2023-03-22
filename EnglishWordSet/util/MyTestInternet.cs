using System;
using System.Net;

namespace EnglishWordSet.util
{
    internal static class MyTestInternet
    {
        public static bool IsThereInternet()
        {
            string adress = "https://www.google.com";
            bool accsessResult;
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
