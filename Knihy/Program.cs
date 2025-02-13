using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Knihy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Kniha> knihy = new List<Kniha>()
            {
    new Kniha { Autor = "JK Roling",Rokvydania = 2000,JePreDospelych = true},
            new Kniha { Autor = "Bob", Rokvydania = 1985, JePreDospelych = true },
            new Kniha { Autor = "Charlie", Rokvydania = 1999, JePreDospelych = false },
            new Kniha { Autor = "Anna Hruskova", Rokvydania = 2015, JePreDospelych = false },
            new Kniha { Autor = "Matus bielka", Rokvydania = 2025, JePreDospelych = true },
        };
            Kniha prvakniha = knihy[0];
            Kniha prvakniha = knihy.First();

          List<Kniha> KnihajePreDospelych = knihy.Where(kniha =>kniha.JePreDospelych == true).ToList();
          List<Kniha> knihyOdNajstarsej = knihy.OrderBy(kniha => kniha.Rokvydania).ToList();
          List<Kniha> knihyOdNajnovsej = knihy.OrderByDescending(kniha => kniha.Rokvydania).ToList();
          List<Kniha> knihyJePreDospelychOdNajstarsej = knihy.Where(kniha => !kniha.JePreDospelych).OrderBy(kniha => kniha.Rokvydania).ToList();
            
            var KnihyPodlaRoku = knihy.GroupBy(u => u.Rokvydania).Select(grp => grp.ToList()).ToList();
            

            foreach (List<Kniha> skupina in KnihyPodlaRoku)
            {
                Console.WriteLine($"Skupinka:");
                foreach (Kniha kniha in skupina) 
            }
            {
                Console.WriteLine($"LINQ : Knihu napisal {Kniha.Autor}, vydal ju v roku {kniha.RokVydania} a je pre deti.");
            }



            foreach (Kniha kniha  in knihyJePreDospelychOdNajstarsej)
            {

                Console.WriteLine($"Kniha od,{kniha.Autor} je dostupna pre {kniha.JePreDospelych} dospelych.");
            }

}
    }
    } 