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
    public class DataMuseAPISImpl : IDataMuseAPIService
    {
        HttpClient client = new HttpClient();
        public async Task<float> GetFrequency(string word)
        {
            HttpResponseMessage response = await client.GetAsync("https://api.datamuse.com/words?sp="+word+"&md=f&max=1");

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var resultWords = JsonSerializer.Deserialize<List<DictionaryWords>>(body);

            try
            {
                string frequencString = resultWords.First().tags.First();
                float frequencyFloat = float.Parse(frequencString.Remove(0, 2));

                return frequencyFloat;
            }
            catch
            {
                return 0;
            }

        }
    }
}
