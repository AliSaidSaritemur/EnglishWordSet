using EnglishWordSet.Data.Contexts;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.Check.Word
{
    internal class IsLearned : ICheckWord
    {
        public WordContext context = MyDBTransactions.GetContext();
        public bool IsCheck(string word)
        {
            return 0<context.LearnedWords.Count(I => I.wordEnglish == word);
        }
    }
}
