using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    internal interface IUserTextsService
    {

        void AddToConvertedWords(string convertedWords,string UserName);
        void AddToTrashbox(string wrongWord, string UserName);
        void UpdateToTrashBox(string updatedVersion, string UserName);
        string GetLastConvertedWords(string UserName);
        string GetConvertedWords(string UserName);
    }
}
