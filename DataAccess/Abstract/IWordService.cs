using Entities.Concrete;


namespace DataAccess.Abstract
{
      interface IWordService
    {
        void Add(string word, string wordMeaning);
        void Delete(string word);
        void Update(string word, string wordMeaning);
        string GetMeaning(string word);
        bool IsThere(string word);
        NWords GetRandomWord();
    }
}
