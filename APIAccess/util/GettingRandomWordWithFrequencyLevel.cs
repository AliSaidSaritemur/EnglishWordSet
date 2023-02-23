using APIAccess.Abstract;
using APIAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAccess.util
{
    public class GettingRandomWordWithFrequencyLevel
    {
        HerokuappRandomWordAPISImpl _randomAPI = new();
        DataMuseAPISImpl _frequencyAPI=new();
        public async Task<string> GetRandomWordMidFrequenc()
        {
            string randomWord = await _randomAPI.GetRandomWordAsync();

            if (await _frequencyAPI.GetFrequency(randomWord) > 0)
            {
                return randomWord;
            }
            else
            {
                return await GetRandomWordMidFrequenc();
            }

        }



    }
}
