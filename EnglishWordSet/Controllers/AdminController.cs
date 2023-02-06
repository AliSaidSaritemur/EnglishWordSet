using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.Data.Contexts;
using EnglishWordSet.MyTools;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.services.Impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.ToolsBackend
{
    class AdminController
    {
        private LearnedWordImpl _learnedWordImpl = new();
        private WordContext context = MyDBTransactions.GetContext();
        public WordImpl wordImpl =new();
        Translater translater;

        private ChildAdminNewWord childAdminAddWord;
        private ChildAdminNewAdmin childAdminAddAdmin;
        private ChildAdminNewLearnedWord newLearnedWord;

        public ChildAdminNewWord GetChildNewWordPage()
        {
            if (childAdminAddWord == null)
            {
                childAdminAddWord = new ChildAdminNewWord();
                childAdminAddWord.FormBorderStyle = FormBorderStyle.None;
                childAdminAddWord.MdiParent = AdminPage.ActiveForm;
                childAdminAddWord.Location = new Point(230, 100);
            }    
            return childAdminAddWord;
        }


        public ChildAdminNewAdmin GetChildNewAdminPage()
        {
            if (childAdminAddAdmin == null)
            {
                childAdminAddAdmin = new ChildAdminNewAdmin();
                childAdminAddAdmin.FormBorderStyle = FormBorderStyle.None;
                childAdminAddAdmin.MdiParent = AdminPage.ActiveForm;
                childAdminAddAdmin.Location = new Point(230, 111);
            }                     
            return childAdminAddAdmin;
        }

        public ChildAdminNewLearnedWord GetChildNewLearnedWord()
        {
            if(newLearnedWord == null)
            {
                newLearnedWord = new ChildAdminNewLearnedWord();
                newLearnedWord.FormBorderStyle = FormBorderStyle.None;
                newLearnedWord.MdiParent = AdminPage.ActiveForm;
                newLearnedWord.Location = new Point(230, 111);
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
                    ((services.IWordService)wordImpl).Add(willTranslateLine, translatedWord);                
                }
                else
                {
                    break;
                }

                currentWord = (currentWord.Next != null) ? currentWord.Next: currentWord;
            }
            context.SaveChanges();
        }
       

        public void AddNewLearnedWord(string word,string sentence,string meaning)
        {

            translater ??= new Translater();
            word = word.ToLower();
            meaning =meaning==""? translater.Translate(word):meaning;                    

            string meaningOfSentence= translater.Translate(sentence); 

            _learnedWordImpl.Add(word,sentence,meaning, meaningOfSentence);
           
        }

        public bool IsLEarnedWordAdded(string word)
        {
            return (_learnedWordImpl.IsThere(word));
        }
    }

}
