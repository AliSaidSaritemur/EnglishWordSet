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

        private ChildAdminNewWord childAdmin;
        public ChildAdminNewWord getChildNewWordPage()
        {
            if (childAdmin == null)
            {
                childAdmin = new ChildAdminNewWord();

                childAdmin.FormBorderStyle = FormBorderStyle.None;
                childAdmin.MdiParent = AdminPage.ActiveForm;

                childAdmin.Location = new Point(230, 111);
            }
            return childAdmin;
        }

        public void AddNewWords(string inputTExt)
        {
            if (translater == null)
                translater = new Translater();

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
       
    }
}
