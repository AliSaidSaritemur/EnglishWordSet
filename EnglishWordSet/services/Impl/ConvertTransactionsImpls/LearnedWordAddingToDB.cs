using DataAccess.Concrete;
using EnglishWordSet.Intefaces;

namespace EnglishWordSet.services.Impl.ConvertTransactionsImpls
{
    internal class LearnedWordAddingToDB : IConvertTransactions
    {
        private TrWordImpl _trWordImpl = new();
        public string EdditLine(string lineToSet)
        {
    
            if (!lineToSet.StartsWith("!!!") || !lineToSet.EndsWith("+"))
                return lineToSet;

                string lineToBeCut = lineToSet;

                lineToBeCut = lineToBeCut.Replace("!", "");
                lineToBeCut = lineToBeCut.Replace("+", "");

                string[] wordsToAddDB = lineToBeCut.Split(Settings.SettingsInfo.Default.SeparatorMark);
            if (string.IsNullOrEmpty(wordsToAddDB[0]) || string.IsNullOrEmpty(wordsToAddDB[1]))
                return lineToSet;
        
            _trWordImpl.AddWtithoutLevel(wordsToAddDB[1].Trim(), wordsToAddDB[0].Trim(), Sessions.UserSession.username_Admin);

            return "";
        }
    }
}
