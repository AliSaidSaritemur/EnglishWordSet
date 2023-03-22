using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions.Equivalency;

namespace Util
{
    public static class SendingMail
    {
       public static void SendMail( string userMail, string mailSubject, string mailBody)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.EnableSsl = true;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(Settings.SettingsInfo.Default.MailAdress, Settings.SettingsInfo.Default.MailPassWord);
            sc.UseDefaultCredentials = false;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(Settings.SettingsInfo.Default.MailAdress, "EnglisWordSet");
            mail.To.Add(userMail);
            mail.Subject = mailSubject;
            mail.IsBodyHtml = true;
            mail.Body = mailBody;
            mail.IsBodyHtml = false;
            sc.Timeout = 10000;
            sc.Send(mail);

        }
       public static class WithTemplates
        {
            public static void SendCheckMail(string userMail, string verificationCode)
            {
                SendMail(userMail,"Mail Check ",$"Your Access Key to check your email {verificationCode}  ");
            }

        }
    }
}
