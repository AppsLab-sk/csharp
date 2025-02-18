using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public static class GeneratorObcanov
    {
        public static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
        public static string[] programovacieJazyky = { "C#", "Pythone", "C++", "Java", "Net." };
        public static Obcan GenerujObcana()
        {
            Random random = new Random();
            int pozicia = random.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = random.Next(15, 116);
            Obcan obcan = new Obcan(meno, vek);
            int dlzkaEnum = Enum.GetValues<StavObcana>().Length;
            int nahodnyIndex = random.Next(dlzkaEnum);
            obcan.Stav = (StavObcana)nahodnyIndex;
            //obcan.Stav = StavObcana.Cudzinci
            return obcan;
        }

        public static Programator GenerujProgramatora()
        {
            Random random = new Random();
            int pozicia = random.Next(mena.Length);  
            string meno = mena[pozicia];
            int vek = random.Next(15, 116);
            int poziciaJ = random.Next(programovacieJazyky.Length);
            string jazyk = programovacieJazyky[poziciaJ];
            Programator obcan = new Programator(meno, vek, jazyk);
            return obcan;
        }
    }
}