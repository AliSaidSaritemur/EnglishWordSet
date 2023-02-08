using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
      interface IWordService
    {
        void Add(string word, string wordMeaning);
        void Delete(string word);
        void Update(string word, string wordMeaning);
        string GetMeaning(string word);
        bool IsThere(string word);
        NWords GetRandomWord();
    }
}
