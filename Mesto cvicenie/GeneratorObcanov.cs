using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{
    public static class GeneratorObcanov
    {

        public static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika",
            "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
        public static string[] programovacieJazyky = { "Charp", "Python", "C++", "C", "java" };
        public static Obcan GenerujObcana()
        {
            Random random = new Random();
            int pozicia = random.Next(mena.Length);

            string meno = mena[pozicia];
            int vek = random.Next(15, 116);
            Obcan obcan = new Obcan(meno, vek);
            return obcan; 
        }
        public static Lekar 
    }
}
