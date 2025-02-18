using System.Globalization;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kniha> knihy = new List<Kniha>()
            {
                new Kniha { Autor = "J.R.R.Talkien - Pan Prstenov", RokVydania = 1987, JePreDospelych = false },
                new Kniha { Autor = "Stephen King - To", RokVydania = 1993, JePreDospelych = true },
                new Kniha { Autor = "Joanne Rowling - Harry Potter", RokVydania = 1990, JePreDospelych = false},
                new Kniha { Autor = "Joanne Rowling - Harry Potter 2", RokVydania = 1990, JePreDospelych = false},
                new Kniha { Autor = "Joanne Rowling - Harry Potter 3", RokVydania = 1990, JePreDospelych = false},
                new Kniha { Autor = "Dan Brown - Pociatok", RokVydania = 1998, JePreDospelych = true },
                new Kniha { Autor = "Lars Kepler - Pavuk", RokVydania = 2008, JePreDospelych = false }
            };

            Kniha prvaKniha = knihy.First();

            List<Kniha> knihyPreDeti = knihy.Where(kniha => !kniha.JePreDospelych == false).ToList();

            var knihyByYear = knihy.GroupBy(u => u.RokVydania).Select(grp => grp.ToList()).ToList();

            foreach (List<Kniha> skupinka in knihyByYear)
            {
                foreach(Kniha kniha in skupinka)
                    Console.WriteLine($" {kniha.Autor.ToUpper()}, {kniha.RokVydania}");
            }

            var knihyByYear_IDictionary = knihy.GroupBy(o => o.RokVydania).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var skupinka in knihyByYear_IDictionary)
            {
                Console.WriteLine($"Skupinka {skupinka.Key}");
                foreach(Kniha kniha in skupinka.Value)
                {
                    Console.WriteLine($" {kniha.Autor.ToUpper()}, {kniha.RokVydania}");
                }
            }
        }
    }
}