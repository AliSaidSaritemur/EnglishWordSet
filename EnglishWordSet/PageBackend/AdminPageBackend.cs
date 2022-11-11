using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.Data.Contexts;
using EnglishWordSet.MyTools;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.ToolsBackend
{
    class AdminPageBackend
    {
        private WordContext context = MyDBTransactions.GetContext();

        Translater translater;

        private ChildAdminNewWord childAdminAddWord;
        private ChildAdminNewAdmin childAdminAddAdmin;
        private ChildAdminNewLearnedWord newLearnedWord;

        public ChildAdminNewWord GetChildNewWordPage()
        {

                childAdminAddWord = new ChildAdminNewWord();

                childAdminAddWord.FormBorderStyle = FormBorderStyle.None;
                childAdminAddWord.MdiParent = AdminPage.ActiveForm;

                childAdminAddWord.Location = new Point(230, 100);
            
            return childAdminAddWord;
        }


        public ChildAdminNewAdmin GetChildNewAdminPage()
        {
        
                childAdminAddAdmin = new ChildAdminNewAdmin();

                childAdminAddAdmin.FormBorderStyle = FormBorderStyle.None;
                childAdminAddAdmin.MdiParent = AdminPage.ActiveForm;

                childAdminAddAdmin.Location = new Point(230, 111);
            
            return childAdminAddAdmin;
        }

        public ChildAdminNewLearnedWord GetChildNewLearnedWord()
        {

            newLearnedWord = new ChildAdminNewLearnedWord();

            newLearnedWord.FormBorderStyle = FormBorderStyle.None;
            newLearnedWord.MdiParent = AdminPage.ActiveForm;

            newLearnedWord.Location = new Point(230, 111);

            return newLearnedWord;
        }

        public void AddNewWords(string inputTExt)
        {
            translater ??= new Translater();

            StringReader stringReader = new(inputTExt);

            string willTranslateLine;
            while (true)
            {
                willTranslateLine = stringReader.ReadLine();

                if (willTranslateLine != null)
                {
                    string translatedWord;
                    translatedWord = translater.Translate(willTranslateLine);
                    context.Words.Add(new Data.Entities.NWords { English = willTranslateLine, Turkish = translatedWord });
                }
                else
                {
                    break;
                }
            }
            context.SaveChanges();
        }
       

        public void AddNewLearnedWord(string word,string sentence,string meaning)
        {
            translater ??= new Translater();
            word = word.ToLower();
            meaning =meaning==""? translater.Translate(word):meaning;                    

            string meaningOfSentence= translater.Translate(sentence); ;

            context.LearnedWords.Add(new Data.Entities.LearnedWord { wordEnglish = word, wordSentence = sentence, wordTurkish = meaning,meaningWordSentence= meaningOfSentence });
            context.SaveChanges();
        }
    }

}
