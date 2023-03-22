using EnglishWordSet.Intefaces;

namespace EnglishWordSet.services.Impl.ConvertTransactionsImpls
{
    internal class RemovingMark : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            return lineToSet.Replace(Settings.SettingsInfo.Default.SeparatorMark, "");
        }
    }
}
