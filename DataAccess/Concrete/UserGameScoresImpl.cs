using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public  class UserGameScoresImpl : IUserGameScoresService
    {
        private WordContext context = MyDBTransactions.GetContext();
        public void AddNewLastLetterGameScore(string username, int score)
        {
            UserGameScore userGameScores = context._UserGameScores.FirstOrDefault(I => I.UserName == username);
            userGameScores.LastLetterGameScores = score + "\n" + userGameScores.LastLetterGameScores;
            context.SaveChanges();
        }

        public void AddNewScoreLastLetterGameIfBiggerThanBestScoreUpdateBestScore(string username, int score)
        {
            AddNewLastLetterGameScore( username,  score);
            int currentBestScore = GetLastLetterGameBestScore(username);
            if (score > currentBestScore)
                UpdateLastLetterGameBestScore(username, score); 
        }

        public void CleanUsersLastLetterGameScores(string username)
        {
            UserGameScore userGameScores = context._UserGameScores.FirstOrDefault(I => I.UserName == username);
            userGameScores.LastLetterGameScores = " ";
            context.SaveChanges();
        }

        public int GetLastLetterGameBestScore(string username)
        {
            UserGameScore userGameScores = context._UserGameScores.FirstOrDefault(I => I.UserName == username);
           return userGameScores.LastLetterGameBestScore;
        }

        public void UpdateLastLetterGameBestScore(string username, int score)
        {
            UserGameScore userGameScores = context._UserGameScores.FirstOrDefault(I => I.UserName == username);
            userGameScores.LastLetterGameBestScore = score;
            context.SaveChanges();
        }
    }
}
