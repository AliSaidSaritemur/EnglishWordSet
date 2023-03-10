using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAccess.Abstract
{
    internal interface GoogleCLoudTranslateService
    {
        public string Translate(string inputTxt);
        public void SetFromLanguageCode(string code);
        public void SetToLanguageCode(string code);
    }
}
