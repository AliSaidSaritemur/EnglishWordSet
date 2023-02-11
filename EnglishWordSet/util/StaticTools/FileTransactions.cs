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
        static string pathTextStart = Directory.GetCurrentDirectory() ;
        static string pathText;

        public static void WriteToText(string textPath, string textToAdd)
        {
            if (string.IsNullOrEmpty(pathText))
                pathText = pathTextStart + textPath;

            File.AppendAllText(pathText, "\n" + textToAdd + "\n");
            string newText = textToAdd + File.ReadAllText(pathText);
            StreamWriter writer = new StreamWriter(pathText);
            writer.Write(newText);
            writer.Close();

        }
        public static string ReadText(string textPath)
        {
            if (string.IsNullOrEmpty(pathText))
                pathText = pathTextStart + textPath;

            string text = File.ReadAllText(pathText);

            return text;
        }
    }
}
