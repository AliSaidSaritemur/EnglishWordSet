using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAccess.Abstract
{
    internal interface UnsplashAPIService
    {
        Task<string> getImageWithWord(String searchedWord);
    }
}
