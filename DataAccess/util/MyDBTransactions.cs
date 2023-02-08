using DataAccess.Concrete;


namespace DataAccess.util
{
   internal static class MyDBTransactions
    {
        static WordContext wordContext;

        static MyDBTransactions()
        {
            wordContext = new WordContext();
        }

        public static WordContext GetContext()
        {
            return wordContext;
        }
    }
}
