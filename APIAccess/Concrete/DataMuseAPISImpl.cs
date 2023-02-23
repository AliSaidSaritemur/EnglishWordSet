using APIAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace APIAccess.Concrete
{
    internal class DataMuseAPISImpl : IDataMuseAPIService
    {
        HttpClient client = new HttpClient();
        public async Task<float> GetFrequency(string word)
        {
            HttpResponseMessage response = await client.GetAsync("https://api.datamuse.com/words?sp="+word+"&md=f&max=1");

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var resultWords = JsonSerializer.Deserialize<List<DictionaryWords>>(body);

            if (resultWords== null|| resultWords.First()==null|| resultWords.First().tags== null)
                return 0;

            string frequencString = resultWords.First().tags.First();
            int pFrom = frequencString.IndexOf(":")+1;
            int pTo = frequencString.LastIndexOf(".");

            string resultString = frequencString.Substring(pFrom, pTo - pFrom);
            return int.Parse(resultString);

        }
    }
}
