using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WorkWithFiles
{
    internal class DaLogic
    {






        private const string FilePath = "\\\\fs1\\Data_studenti$\\2025\\mahutm25\\Desktop\\fafafela\\txt";

        public int ReadingTheFile()
        {
            string text = File.ReadAllText(FilePath);
            string[] words = text.Split(' ');


            return words.Length;

            
        }















    }
}
