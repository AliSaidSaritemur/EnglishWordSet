using DataAccess.Concrete;


namespace DataAccess.util
{
   public static class MyDBTransactions
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
