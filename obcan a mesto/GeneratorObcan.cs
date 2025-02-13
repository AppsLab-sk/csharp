using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    public static class GeneratorObcan
    {
        private static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
        private static string[] programovacieJazyky = { "C", "C+", "C++", "Python", "C#", "Java", "JavaScript", "HTML", "Ruby", "F#", "CSS", "LuaU", "Brainfuck", "MOO" };
        public static Obcan GenerujObcana()
        {
            Random random = new Random();  

            int pozicia =random.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = random.Next(15, 115);
            Obcan obcan = new Obcan(meno, vek);
            int dlzkaEnum = (Enum.GetValues<StavObcana>().Length);
            int nahodnyIndex = random.Next(dlzkaEnum);
            obcan.Stav = (StavObcana)nahodnyIndex;
            return obcan;


        }
        public static Programator GenerujProgramatora()
        {
            Random random = new Random();

            int pozicia = random.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = random.Next(15, 115);

            Random r = new Random();
            int pozicia2 = r.Next(programovacieJazyky.Length);
            string jazyk = programovacieJazyky[pozicia2];

            Programator programator = new Programator(meno, vek, jazyk);
            return programator;


        }
    }
}
