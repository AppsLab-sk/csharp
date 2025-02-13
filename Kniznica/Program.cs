namespace Kniznica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kniha> knizky = new List<Kniha>()
            {
            new Kniha { NazovKnihy = "Harry Potter", RokVydania = 2022, JePreDospelych = false },
            new Kniha { NazovKnihy = "Pan Prstenov",RokVydania = 1978, JePreDospelych = false},
            new Kniha { NazovKnihy = "Rod Draka", RokVydania = 2022, JePreDospelych = true},
            new Kniha { NazovKnihy = "Grazlik Gabko", RokVydania = 1975, JePreDospelych = false},
            new Kniha { NazovKnihy = "Twailight", RokVydania = 1975, JePreDospelych = true},
            new Kniha { NazovKnihy = "Cervena ciapocka", RokVydania = 2020, JePreDospelych = false},
            new Kniha { NazovKnihy = "Male zeny", RokVydania = 1978, JePreDospelych = true},
            new Kniha { NazovKnihy = "Zlodejka knih", RokVydania = 2020, JePreDospelych = false},
            new Kniha { NazovKnihy = "Vrazda v orient exprese", RokVydania = 2020, JePreDospelych = true},
            };

            Kniha Prvaknihaold = knizky[0];
            Kniha prvahniha = knizky.FirstOrDefault();

            /*List<Kniha> losknihosombreros = knizky.Where(knicha => knicha.JePreDospelych == false).ToList();
            List<Kniha> losknihosombrerosi = knizky.OrderBy(knicha => knicha.RokVydania).ToList();
            List<Kniha> losknihoso = knizky.OrderByDescending(knicha => knicha.RokVydania).ToList();
            List<Kniha> los = knizky.Where(knicha => knicha.JePreDospelych == false).OrderBy(knicha => knicha.RokVydania).ToList();*/


            var knihyrokov = knizky.GroupBy(u => u.RokVydania).Select(grb => grb.ToList()).ToList();
            
            foreach (List<Kniha> skupinka in knihyrokov)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine($"Skupina: ");
                

                foreach (Kniha knicha in skupinka ) 
                { 
                 Console.WriteLine($"Kniha s nazvom {knicha.NazovKnihy} bola vydana v roku {knicha.RokVydania} a je pre deti ");
                }
               
            }
            Console.WriteLine("-----------------------------------------------------------------------------");


            var knihyPodlaRoku_IDctionary = knizky.GroupBy(o => o.RokVydania).ToDictionary(g =>g.Key, g => g.ToList());
            Console.WriteLine();


            foreach (var skupinka in knihyPodlaRoku_IDctionary) 
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Skupinka {skupinka.Key}");

                foreach (Kniha kniha in skupinka.Value) 
                {
                    Console.WriteLine($" Nazov knihy: {kniha.NazovKnihy},{kniha.RokVydania} je pre deti");         
                }  
                



                    

            }
        }
    }
}