using System;
using Util;

namespace EnglishWordSet.Controllers
{
    internal class EmailCheckPageController
    {

        public string verificationCode { get; set; }
        public  string SendVerificationCodeWithEmailAndReturn(string userMail)
        {
            verificationCode = CodeCraete();

            SendingMail.WithTemplates.SendCheckMail(userMail, verificationCode);
            return verificationCode;
        }

        private string CodeCraete()
        {
            Random rnd = new();
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                code += rnd.Next(9).ToString();
            }

            return code;
        }
    }
}
