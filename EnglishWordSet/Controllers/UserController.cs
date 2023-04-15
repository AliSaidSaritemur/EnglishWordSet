using APIAccess.Concrete;
using DataAccess.Concrete;
using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.Sessions;
using EnglishWordSet.util;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Util;

namespace EnglishWordSet.Controllers
{
    class UserController
    {
        private LearnedWordImpl _learnedWordImpl = new();
        public WordImpl wordImpl = new();
        Translater translater;

        private ChildAdminNewWord childAdminAddWord;
        private ChildAdminNewUser childAdminAddAdmin;
        private ChildAdminNewLearnedWord newLearnedWord;

        public ChildAdminNewWord GetChildNewWordPage()
        {
            childAdminAddWord = PageTransactions.GetChildAdminNewWordPage();
            if (childAdminAddWord.FormBorderStyle != FormBorderStyle.None)
            {         
                childAdminAddWord.FormBorderStyle = FormBorderStyle.None;
                childAdminAddWord.MdiParent = UserPage.ActiveForm;
                childAdminAddWord.Location = new Point(180, 100);
            }
            return childAdminAddWord;
        }


        public ChildAdminNewUser GetChildNewAdminPage()
        {
            childAdminAddAdmin = PageTransactions.GetChildAdminNewUserPage();
            if (childAdminAddAdmin.FormBorderStyle!= FormBorderStyle.None)
            {
                childAdminAddAdmin.FormBorderStyle = FormBorderStyle.None;
                childAdminAddAdmin.MdiParent = UserPage.ActiveForm;
                childAdminAddAdmin.Location = new Point(230, 111);
            }
            return childAdminAddAdmin;
        }

        public ChildAdminNewLearnedWord GetChildNewLearnedWord()
        {
            newLearnedWord = PageTransactions.GetChildAdminNewLearnedWordPage();
            if (newLearnedWord.FormBorderStyle != FormBorderStyle.None)
            {
                newLearnedWord.FormBorderStyle = FormBorderStyle.None;
                newLearnedWord.MdiParent = UserPage.ActiveForm;
                newLearnedWord.Location = new Point(200, 111);
            }
            return newLearnedWord;
        }

        public void AddNewWords(string inputTExt)
        {
            translater ??= new Translater();
            StringReader stringReader = new(inputTExt);
            StringReader stringReaderTranslated = new(translater.Translate(inputTExt));

            LinkedList<string> translatedWords = new LinkedList<string>();
            string willTranslateLine;
            while (true)
            {
                willTranslateLine = stringReaderTranslated.ReadLine();

                if (willTranslateLine != null)
                {
                    translatedWords.AddLast(willTranslateLine);
                }
                else
                {
                    break;
                }
            }
            var currentWord = translatedWords.First;

            while (true)
            {
                willTranslateLine = stringReader.ReadLine();

                if (willTranslateLine != null)
                {
                    string translatedWord;
                    translatedWord = currentWord.Value;
                    wordImpl.Add(willTranslateLine, translatedWord, UserSession.username_Admin);
                }
                else
                {
                    break;
                }
                currentWord = (currentWord.Next != null) ? currentWord.Next : currentWord;
            }
        }
        public string getMeaningWithMark(string inputTExt)
        {
            string resultText="";
            translater ??= new Translater();
            StringReader stringReader = new(inputTExt);
            StringReader stringReaderTranslated = new(translater.Translate(inputTExt));

            LinkedList<string> translatedWords = new LinkedList<string>();
            string willTranslateLine;
            while (true)
            {
                willTranslateLine = stringReaderTranslated.ReadLine();

                if (willTranslateLine != null)
                {
                    translatedWords.AddLast(willTranslateLine);
                }
                else
                {
                    break;
                }
            }
            var currentWord = translatedWords.First;

            while (true)
            {
                willTranslateLine = stringReader.ReadLine();

                if (willTranslateLine!=null && RegexTransactions.CheckingValue.IsThereSpreatorMark(willTranslateLine))
                {
                    resultText += willTranslateLine + "\n";
                }            
               else if (willTranslateLine != null)
                {
                    string translatedWord;
                    translatedWord = currentWord.Value;
                    resultText +=willTranslateLine +" "+ Settings.SettingsInfo.Default.SeparatorMark + " "+translatedWord+"\n";
                }
                else
                {
                    break;
                }
                currentWord = (currentWord.Next != null) ? currentWord.Next : currentWord;
            }
            return resultText;
        }


        public void AddNewLearnedWord(string word,string sentence,string meaning)
        {

            translater ??= new Translater();
            word = word.ToLower();
            meaning =string.IsNullOrEmpty(meaning)? translater.Translate(word):meaning;                    

            string meaningOfSentence= translater.Translate(sentence); 

            _learnedWordImpl.Add(word,sentence,meaning, meaningOfSentence, UserSession.username_Admin);
           
        }

        public bool IsLEarnedWordAdded(string word)
        {
            return (_learnedWordImpl.IsThere(word, UserSession.username_Admin));
        }
    }

}
