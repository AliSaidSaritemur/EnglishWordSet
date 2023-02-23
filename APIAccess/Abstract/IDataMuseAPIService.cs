using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAccess.Abstract
{
   interface  IDataMuseAPIService
    {
        Task<float> GetFrequency(string word);
    }
}
