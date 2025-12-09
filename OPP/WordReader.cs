using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class WordReader
    {
        private const string _fileName = "\\\\fs1\\Data_studenti$\\2025\\cvengrosm25\\Desktop\\._\\";
        public int CountWords()
        {
            string text = File.ReadAllText(_fileName);
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
