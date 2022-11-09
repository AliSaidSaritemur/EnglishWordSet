using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.Data.Entities
{
     class LearnedWord
    {
        public int Id { get; set; }
        public string wordEnglish { get; set; }
        public string wordTurkish{ get; set; }
        public string wordSentence { get; set; }
    }
}
