using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
   internal static class FileTransactions
    {

        public static void AddTextToFile(string textPath, string textToAdd)
        {
            File.AppendAllText(textPath, "\n" + textToAdd + "\n");
            string newText = textToAdd + File.ReadAllText(textPath);
        }
        public static string ReadText(string textPath)
        {
            string text;
            using (var f = new FileStream(textPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var s = new StreamReader(f))
            {
                text = s.ReadToEnd();
            }

            return text;
        }
        public static void WriteText(string textPath,string texttoWrite)
        {
            File.WriteAllTextAsync(textPath, texttoWrite);
        }
        public static void CleanTextWtihDeleteFile(string textPath)
        {
            var deletionTask = Task.Run(() => File.Delete(textPath));
            var creationTask = Task.Run(() => File.Create(textPath).Close());
        }

    }
}
