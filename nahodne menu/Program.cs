using System;
using System.Collections.Generic;

namespace nahodne_mena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var femaleFirstNames = new List<string>
            {
              "Anna","Mária","Katarína","Zuzana","Lucia","Kristína","Monika","Veronika","Lenka","Petra",
              "Michaela","Eva","Jana","Jarmila","Martina","Barbora","Adriana","Alexandra","Alžbeta","Alica",
              "Daniela","Diana","Dominika","Natália","Nikola","Nikoleta","Silvia","Simona","Ivana","Iveta",
              "Ingrid","Renáta","Gabriela","Miriam","Pavlína","Laura","Karolína","Klára","Tatiana","Tereza",
              "Beáta","Bianka","Rebeka","Nela","Ema","Ela","Tamara","Viktória","Zora","Žaneta"
            };

            var maleFirstNames = new List<string>
            {
              "Peter","Martin","Jozef","Tomáš","Lukáš","Jakub","Michal","Marek","Andrej","Anton",
              "Samuel","Dominik","Richard","Róbert","Roman","Patrik","Filip","Juraj","Karol","Daniel",
              "Dávid","Adam","Erik","Igor","Ivan","Ľubomír","Pavol","Stanislav","Štefan","Matej",
              "Matúš","Vladimír","Viliam","Radovan","Rastislav","Šimon","Sebastián","Eduard","Marián","Gabriel",
              "Tobiáš","Boris","Alan","Oliver","Oskar","Leonard","Viktor","Alex","Benjamin","Tadeáš"
            };

            var femaleSurnamesSk = new List<string>
            {
              "Nováková","Horváthová","Kováčová","Vargová","Tóthová","Nagyová","Molnárová","Szabóová","Lukáčová","Kučerová",
              "Poláková","Kráľová","Urbanová","Krajčíová","Kováčiková","Kubišová","Holubová","Benková","Blašková","Mareková",
              "Tomášová","Balážová","Farkašová","Bartošová","Šimková","Pavlíková","Michalíková","Černáková","Švecová","Ševčíková",
              "Juríková","Hrušková","Chovancová","Rácová","Hudáková","Ondrušová","Sokolová","Pospíšilová","Gašparová","Gregorová",
              "Valentová","Ďuricová","Ďurišová","Vavrová","Žáková","Koreňová","Červeňová","Šramková","Mrázová","Mrvová"
            };

            var maleSurnamesSk = new List<string>
            {
              "Novák","Horváth","Kováč","Varga","Tóth","Nagy","Molnár","Szabó","Lukáč","Kučera",
              "Polák","Kráľ","Urban","Krajčí","Kováčik","Kubiš","Holub","Benko","Blaško","Marek",
              "Tomáš","Baláž","Farkaš","Bartoš","Šimko","Pavlík","Michalík","Černák","Švec","Ševčík",
              "Jurík","Hruška","Chovanec","Rác","Hudák","Ondruš","Sokol","Pospíšil","Gašpar","Gregor",
              "Valent","Ďurica","Ďuriš","Vavro","Žák","Koreň","Červeň","Šramko","Mráz","Mrva"
            };

            Random r = new Random();

            Console.WriteLine("Ženské mená");
            for (int i = 0; i < 10; i++) // napr. 5 náhodných mien
            {
                string fullName = GetRandomString(femaleFirstNames, r) + " " + GetRandomString(femaleSurnamesSk, r);
                Console.WriteLine(fullName);
            }

            Console.WriteLine(" Mužské mená ");
            for (int i = 0; i <5; i++)
            {
                string fullName = GetRandomString(maleFirstNames, r) + " " + GetRandomString(maleSurnamesSk, r);
                Console.WriteLine(fullName);
            }

            Console.ReadLine(); // nech sa konzola nezavrie
        }

        public static string GetRandomString(List<string> strings, Random r)
        {
            int count = strings.Count;
            int index = r.Next(count);
            return strings[index];
        }
    }
}
