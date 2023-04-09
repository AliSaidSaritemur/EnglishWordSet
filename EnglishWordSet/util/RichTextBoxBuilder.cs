using DataAccess.Concrete;
using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.services.Impl.ConvertTransactionsImpls;
using EnglishWordSet.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace EnglishWordSet.util
{
   internal  class RichTextBoxBuilder
    {
       private RichTextBox _rTxtBox;

        public RichTextBoxBuilder(RichTextBox txtInput)
        {
            _rTxtBox=txtInput;
        }
        

        public void ChangeTxtInputWordsColor(string word, Color color)
        {
            string tempInputWords = _rTxtBox.Text.ToString();

            while (tempInputWords.IndexOf(word) >= 0)
            {
                int indexOfWord = tempInputWords.IndexOf(word);
                int lengthofWord = word.Length;
                _rTxtBox.Select(indexOfWord, lengthofWord);
                _rTxtBox.SelectionColor = color;

                tempInputWords = tempInputWords.Remove(indexOfWord, 1).Insert(indexOfWord, $"{(char)(word[0] + 1)}");
            }
        }

        
    }
}
