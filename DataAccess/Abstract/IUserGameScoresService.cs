using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    internal interface IUserGameScoresService
    {
         void AddNewLastLetterGameScore(string username, int score);
         void UpdateLastLetterGameBestScore(string username, int score);
        void CleanUsersLastLetterGameScores(string username);
        void AddNewScoreLastLetterGameIfBiggerThanBestScoreUpdateBestScore(string username, int score);
        int GetLastLetterGameBestScore(string username);
    }
}
