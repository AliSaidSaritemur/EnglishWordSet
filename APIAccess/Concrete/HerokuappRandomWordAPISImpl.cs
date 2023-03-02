using APIAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace APIAccess.Concrete
{
    public class HerokuappRandomWordAPISImpl : IHerokuappRandomWordAPIService
    {
        HttpClient client = new HttpClient();
        public async Task<string> GetRandomWordAsync()
        {     
            HttpResponseMessage response = await client.GetAsync("https://random-word-api.herokuapp.com/word");
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var resultWords = JsonSerializer.Deserialize<List<string>>(body);
            return resultWords[0];
        }
        public async Task<List<string>> GetRandomWordsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("https://random-word-api.herokuapp.com/all");
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var resultWords = JsonSerializer.Deserialize<List<string>>(body);
            return resultWords;
        }

    }
}
