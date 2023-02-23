using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAccess.Abstract
{
   public interface IRapidAPIService
    {

         Task<List<string>> GetExammples(string queryWord);
        Task<DictionaryWords> GetDictionaryWords(string RequestUri);
    }
}
