using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class TextManagment
    {
        static string pathTextStart = Directory.GetCurrentDirectory() + "/Files/";
        static string pathText;

        public static void WriteToText(string textPath, string textToAdd)
        {
            if (pathText == string.Empty || pathText == null)
                pathText = pathTextStart + textPath;

            File.AppendAllText(pathText, "\n" + textToAdd + "\n");
            string newText = textToAdd + File.ReadAllText(pathText);
            StreamWriter writer = new StreamWriter(pathText);
            writer.Write(newText);
            writer.Close();

        }
        public static string ReadText(string textPath)
        {
            if (pathText == string.Empty || pathText == null)
                pathText = pathTextStart + textPath;

            string text = File.ReadAllText(pathText);
            return text;
        }
    }
}
