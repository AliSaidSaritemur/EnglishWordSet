using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserGameScore
    {
        public int id { get; set; }
        public int LastLetterGameBestScore { get; set; }
        public string LastLetterGameScores { get; set; }
        public string UserName { get; set; }
    }
}
