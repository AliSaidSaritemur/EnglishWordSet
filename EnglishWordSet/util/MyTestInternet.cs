using System;
using System.Net;
using System.Net.NetworkInformation;

namespace EnglishWordSet.util
{
    internal static class MyTestInternet
    {
        public static bool IsThereInternet()
        {

            bool accsessResult;
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                accsessResult =(reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                accsessResult= false;
            }
            return accsessResult;
        }
    }
}
