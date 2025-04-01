using System.Linq;

namespace LINQ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Kniha> knihy = new List<Kniha>()
            {
                new Kniha { Autor = "Martin Fric", RokVydania = 1954, JePreDeti = true },
            new Kniha { Autor = "Dominik Trebaticky", RokVydania = 2008, JePreDeti = false },
            new Kniha { Autor = "Fero Mrkvicka", RokVydania = 2018, JePreDeti = true },
            new Kniha { Autor = "Adrian Milo", RokVydania = 1986, JePreDeti = false },
            new Kniha { Autor = "Adrian Milo1", RokVydania = 1986, JePreDeti = false },
            new Kniha { Autor = "Adrian Milo2", RokVydania = 1986, JePreDeti = false },
        };
            Kniha prvaKnihaOld = knihy[0];
            Kniha prvaKniha = knihy.First();


            List<Kniha> knihaJePreDeti = knihy.Where(kniha => kniha.JePreDeti == true).ToList();
            List<Kniha> knihyOdNajstarsej = knihy.OrderBy(kniha => kniha.RokVydania).ToList();
            List<Kniha> knihyOdNajnovsej = knihy.OrderByDescending(kniha => kniha.RokVydania).ToList();
            List<Kniha> knihyPreDetiOdNajstarsej = knihy.Where(kniha => kniha.JePreDeti).ToList();
            List<Kniha> kinhyPreDetiOdNajnovsej = knihy.Where(kniha => kniha.JePreDeti).OrderBy(kniha => kniha.RokVydania).ToList(); // !kniha - znamena opak, True = False a naopak :)

            var KnihyPodlaRoku = knihy.GroupBy(u => u.RokVydania).Select(grp => grp.ToList()).ToList();



            foreach (List<Kniha> skupinka in KnihyPodlaRoku)
            {
                Console.WriteLine($"Skupinka:");

                foreach (Kniha kniha in skupinka)
                {
                    Console.WriteLine($"LINQ : Knihu napisal {kniha.Autor}, vydal ju v roku {kniha.RokVydania} a je pre deti.");
                }
            }


            Console.WriteLine();
            var knihyPodlaRoku_IDictionary = knihy.GroupBy(o => o.RokVydania).ToDictionary(g => g.Key, g => g.ToList());
            foreach (var skupinka in knihyPodlaRoku_IDictionary)
            {
                Console.WriteLine($"Skupinka {skupinka.Key}");
                foreach (Kniha kniha in skupinka.Value)
                {
                    Console.WriteLine($" {kniha.Autor} {kniha.RokVydania}");
                }
            }








            /* List<Student> students = new List<Student>()
              {
                   new Student { Name = "Anna Maria", Age = 20 },
                   new Student { Name = "Anna Hruskova", Age = 40 },
                   new Student { Name = "Bob", Age = 22 },
                   new Student { Name = "Charlie", Age = 18 }, 
              };

           
            List<Student> tinedzeriStudenti_StarySposob = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Age < 20)
                {
                    tinedzeriStudenti_StarySposob.Add(student);
                }
            }
            List<Student> tinedzeriStudenti = students.Where(student => student.Name.Contains ("Anna")).ToList();
            foreach (Student student in tinedzeriStudenti)
            {
                Console.WriteLine($"LINQ:Student {student.Name} ma {student.Age} rokov a je tinedzer.");
            }
            foreach (Student student in tinedzeriStudenti)
            {
                Console.WriteLine($"LINQ:Student {student.Name} ma {student.Age} rokov a je tinedzer.");*/

        }
    }
}
