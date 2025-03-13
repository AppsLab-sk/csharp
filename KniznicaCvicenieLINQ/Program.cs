namespace KniznicaCvicenieLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kniha> knihy = new List<Kniha>()
            {
                new Kniha() { Autor = "J.R.R. Tolkien - Hobbit", RokVydania = 1936, JePreDospelych = false },
                new Kniha() { Autor = "J.K. Rowling - Harry Potter", RokVydania = 1998, JePreDospelych = false},
                new Kniha() { Autor = "K. May - Winnetou", RokVydania = 1898, JePreDospelych = false},
                new Kniha() { Autor = "D. Defoe - Robinson Crusoe", RokVydania = 1712, JePreDospelych = false},
                new Kniha() { Autor = "S. King - Osvietenie", RokVydania = 1978, JePreDospelych = true},
                new Kniha() { Autor = "M. Beke - 1001 vyuziti inkognito modu", RokVydania = 1998, JePreDospelych = true}
            };

            /*    List<Kniha> knihyPreMladez = knihy.Where(x => x.JePreDospelych == false).OrderBy(x => x.RokVydania).ToList();

                foreach(Kniha kniha in knihyPreMladez)
                {
                    Console.WriteLine($"Kniha {kniha.Autor}, vydana v roku {kniha.RokVydania}, je dostupna aj pre mladez.");
                }

                List<Kniha> knihyPreDospelych = knihy.Where(x => x.JePreDospelych == true).OrderBy(x => x.RokVydania).ToList();

                foreach (Kniha kniha in knihyPreDospelych)
                {
                    Console.WriteLine($"Kniha {kniha.Autor}, vydana v roku {kniha.RokVydania}, je dostupna iba pre dospelych.");
                }*/
            var PrvaKniha = knihy.First();
            Console.WriteLine(PrvaKniha.Autor);


            var knihyByYear = knihy.GroupBy(u => u.RokVydania).Select(grp => grp.ToList()).ToList();

            foreach (List<Kniha> skupinka in knihyByYear)
            {
                Console.WriteLine($"Skupinka:");
                foreach(Kniha kniha in skupinka)
                {
                    Console.WriteLine($"{ kniha.Autor.ToUpper()} {kniha.RokVydania}");

                }
            }
            Console.WriteLine();

            var knihyByYear_IDictionary = knihy.GroupBy(o => o.RokVydania).ToDictionary(g => g.Key, g => g.ToList());
            foreach(var skupinka in knihyByYear_IDictionary)
            {
                Console.WriteLine($"Skupinka {skupinka.Key}:");
                foreach (Kniha kniha in skupinka.Value)
                {
                    Console.WriteLine($"{kniha.Autor.ToUpper()} {kniha.RokVydania}");
                
                }

            }
        }
    }
}