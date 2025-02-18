using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihaUloha
{
    public class Kniha
    {
        private string name;
        private int pages;

        public Kniha()
        {
        }

        public Kniha (string name, int pages)
        {
            this.name = name;
            this.pages = pages;
        }
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public int Pages
        { 
            get { return pages; }
            set {
                if (value > 0)
                    pages = value;
                else 
                   pages = 0;
                }

        }
    }
}
