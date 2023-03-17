using Entities.Concrete;


namespace DataAccess.Abstract
{
      interface IWordService
    {
        void Add(string word, string wordMeaning,string username);
        void Delete(string word, string username);
        void Update(string word, string wordMeaning, string username);
        string GetMeaning(string word, string username);
        bool IsThere(string word, string username);
        NWords GetRandomWord(string username);
    }
}
