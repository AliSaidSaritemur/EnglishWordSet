using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.FileTransactions
{
    static class TextManagment
    {
        public static void WriteToText(string textPath, string textToAdd)
        {
            string pathText = Directory.GetCurrentDirectory() + "/Files/" + textPath;
            File.AppendAllText(pathText, "\n" + textToAdd + "\n");
            string newText = textToAdd + File.ReadAllText(pathText);
            StreamWriter writer = new StreamWriter(pathText);
            writer.Write(newText);
            writer.Close();
        }
    }
}
