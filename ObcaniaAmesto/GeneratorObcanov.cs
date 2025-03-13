using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public static class GeneratorObcanov 
    {
        private static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
        private static string[] jazyky = {"C", "C++", "C#", "Java", "JavaScript", "HTML", "LuaU", "Ruby", "Assembler", "Python", "Machine Code", "F#", "CSS", "MOO", "Brainfuck", "BETAR Language" }; 
        
        
        
        public static Citizen GenerujObcana()
        {
            Random random = new Random();
            int pozicia = random.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = random.Next(15, 155);
            Citizen obcan = new Citizen(meno, vek);
            int dlzkaEnumu = (Enum.GetValues<StavObcana>().Length);
            int nahodnyIndex = random.Next(0, dlzkaEnumu);
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
            int pozicia2 = r.Next(jazyky.Length);                       
            string jazyk = jazyky[pozicia2];                                            
                                                                        
            Programator programator = new Programator(meno, vek, jazyk);

            return programator;                                         
            
        }
    }
}
