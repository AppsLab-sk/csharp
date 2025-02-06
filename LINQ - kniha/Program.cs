using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace LINQ___kniha
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Kniha> Knihy = new List<Kniha>()
            {
            new Kniha { Autor = "Anna Maria", RokVydania = 2011, JePreDeti = true },
            new Kniha { Autor = "Anna Hruskova",RokVydania = 2009, JePreDeti = false },
            new Kniha { Autor = "Bob", RokVydania = 2022, JePreDeti = true },
            new Kniha { Autor = "Charlie", RokVydania = 2018, JePreDeti = true },
            new Kniha { Autor = "Imrich", RokVydania = 2020 , JePreDeti = false},
            new Kniha { Autor = "Imrich 2", RokVydania = 2020 , JePreDeti = false},
            new Kniha { Autor = "Imrich 3", RokVydania = 2020 , JePreDeti = false},
            };


            List<Kniha> knihaJePreDeti = Knihy.Where(kniha => kniha.JePreDeti == true).ToList();
            List<Kniha> knihyOdNajstarsej = Knihy.OrderBy(kniha => kniha.RokVydania).ToList();
            List<Kniha> kinhyOdNajmladsej = Knihy.OrderByDescending(kniha => kniha.RokVydania).ToList();
            List<Kniha> knihyPreDetiOdNajstarsej = Knihy.Where(kniha => kniha.JePreDeti).OrderBy(kniha => kniha.RokVydania).ToList(); //!kniha = negacia cize False = True a naopak

            var knihyPodlaRoku = Knihy.GroupBy(u => u.RokVydania).Select(grp => grp.ToList()).ToList();

            Kniha Prvaknizaold = Knihy[0];
            Kniha prvakniha = Knihy.Last();

            foreach (List<Kniha> skupinka in knihyPodlaRoku)
            {
                Console.WriteLine($"Skupinka:");

                foreach (Kniha kniha in skupinka)
                {
                    Console.WriteLine($" Autor: {kniha.Autor},{kniha.RokVydania}, {kniha.JePreDeti} je pre deti ");
                }

            }
            Console.WriteLine();
            var knihyPodlaRoku_IDictionary = Knihy.GroupBy(o => o.RokVydania).ToDictionary(g => g.Key, g => g.ToList());
            foreach (var skupinka in knihyPodlaRoku_IDictionary)
            {
                Console.WriteLine($"Skupinka {skupinka.Key}");
                foreach (Kniha kniha in skupinka.Value)
                {
                    Console.WriteLine($" Autor: {kniha.Autor},{kniha.RokVydania}, {kniha.JePreDeti} je pre deti ");
                }
            }
        }
    }
}