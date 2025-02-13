namespace Knihy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kniha1> kniha1s = new List<Kniha1>()
            {
                new Kniha1() { Autor = "J.R.R. Tolkien - Pan Prstenov", RokVydania = 1936, JePreDospelych = false },
                new Kniha1() { Autor = "J.K. Rowling - Harry Potter", RokVydania = 1998, JePreDospelych = false },
                new Kniha1() { Autor = "D. Defoe - Robinson Crusoe", RokVydania = 1712, JePreDospelych = true },
                new Kniha1() { Autor = "K. May - Winnetou", RokVydania = 1898, JePreDospelych = false },
                new Kniha1() { Autor = "S. King - Osvietenie", RokVydania = 1978, JePreDospelych = true }
            };

           /* List<Kniha1> knihyPreMladez = kniha1s.Where(x => x.JePreDospelych == false).OrderBy(x => x.RokVydania).ToList();

            foreach (Kniha1 kniha in knihyPreMladez)
            {
                Console.WriteLine($"Kniha{kniha.Autor}, bola vydana {kniha.RokVydania} a je dostupna pre mladez");
            }

            List<Kniha1> knihyPreDospelych = kniha1s.Where(x => x.JePreDospelych == true).OrderBy(x => x.RokVydania).ToList();

            foreach (Kniha1 kniha in knihyPreDospelych)
            {
                Console.WriteLine($"Kniha{kniha.Autor}, bola vydana {kniha.RokVydania} a je dostupna pre dospelych");
            }*/

            var prvaKniha = kniha1s.First();
            Console.WriteLine(prvaKniha.Autor);
        

            var knihyByYear = kniha1s.GroupBy(u => u.RokVydania).Select(grp => grp.ToList()).ToList();

            foreach(List<Kniha1> skupinka in knihyByYear) 
            {
                Console.WriteLine($"Skupina:");
                foreach(Kniha1 kniha in skupinka)
                {
                    Console.WriteLine($"{kniha.Autor.ToUpper()}{kniha.RokVydania}");
                }
            }

            Console.WriteLine();
            var knihyByYear_IDictionary = kniha1s.GroupBy(o => o.RokVydania).ToDictionary(g => g.Key, g => g.ToList());
            foreach(var skupinka in knihyByYear_IDictionary)
            {
                Console.WriteLine($"Skupinka {skupinka.Key}:");
                foreach(Kniha1 kniha in skupinka.Value)
                {
                    Console.WriteLine($"{kniha.Autor.ToUpper()} {kniha.RokVydania}");
                   
                }
            }

        }
    }
}
