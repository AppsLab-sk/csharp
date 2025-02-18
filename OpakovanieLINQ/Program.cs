namespace OpakovanieLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kniha> knihas = new List<Kniha>()
           
            {
                new Kniha() { Autor = "Joanne K. Rowling", rokVydania = 2019, PreDospelych = false },
                new Kniha() { Autor = "Jack Carr", rokVydania = 2022, PreDospelych = true },
                new Kniha() { Autor = "Collen Hooverova", rokVydania = 2023, PreDospelych = true },
           
             };

            List<Kniha> predeti = knihas.Where(kniha => kniha.PreDospelych == false).ToList();
            List<Kniha> knihyOdNajstarsej = knihas.OrderBy(kniha => kniha.rokVydania).ToList();
            List<Kniha> knihyOdNajnovsej = knihas.OrderByDescending(kniha => kniha.rokVydania).ToList();
            List<Kniha> knihyPreMladezOdNajstarsej = knihas.Where(kniha => !kniha.PreDospelych).OrderBy(kniha => kniha.ReleaseYear).ToList();

            var vysledok = knihas.GroupBy(p => p.rokVydania).Select(grp => grp.Key).ToList();

            foreach (List<Kniha> skupina in knihaByYear)
            {
                Console.WriteLine($"Skupina:");

                foreach (Kniha kniha in skupina)
                {
                    Console.WriteLine($"{kniha.Autor.ToUpper()} {kniha.rokVydania}");
                }
                Console.WriteLine();
                var knihaByYear_IDictionary = Kniha.GroupBy( o => o.rokVydania ).ToDiction(g => g.Key , g => g.ToList());
                foreach (var skupina in knihaByYear_IDictionary) 
                {
                    Console.WriteLine($"Skupina{skupina.Key}:");
                    foreach(var kniha in skupina)
                    
                    {
                        Console.WriteLine($"{kniha.Autor.ToUpper()} {kniha.rokVydania}");
                    }
                }
            }
        }
    }
}
