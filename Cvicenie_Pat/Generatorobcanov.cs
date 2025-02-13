using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    static class Generatorobcanov
    {
        private static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína",
                                         "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika",
                                         "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola"};

        private static string[] programovacie = { "C#", "C", "C++", "Python", "Delphi", "Java", "Java script" };

        
        public static Obcan GenerujObcana() 
        { 
          Random rnd = new Random();
          int cisielko = rnd.Next(mena.Length);

         string meno = mena[cisielko];    

         int vek = rnd.Next(15, 116);
           

         Obcan obivatel = new Obcan(meno, vek) { };   
          
         return obivatel;
        
        }   
        public static Programator Generuprogramatora() 
        {
           Random rejndom = new Random();
            int number = rejndom.Next(mena.Length);
            int number1 = rejndom.Next(programovacie.Length);
            int vejk = rejndom.Next(15, 116);

            string mejno = mena[number];
            string jazyky = programovacie[number1];
            int veky = Convert.ToInt32(vejk); 

            Programator pro = new Programator(mejno, veky, jazyky) { };

            int dlzka = (Enum.GetValues<StavObcana>().Length);
            int nahodnyIndex = rejndom.Next(0, dlzka);
            pro.Stav = (StavObcana)nahodnyIndex;

            //pro.Stav = StavObcana.Cudzinci;

            return pro; 
        }
    }
}
