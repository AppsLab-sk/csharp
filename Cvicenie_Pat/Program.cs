using System.Diagnostics.CodeAnalysis;

namespace Cvicenie_Pat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto bratislava = Mesto.Nacitajzosuboru("mesto.json");
            if (bratislava == null) 
            {
               
                bratislava = new Mesto("Bratislava");
                for (int i = 0; i < 32; i++)
                {
                    Obcan ob = Generatorobcanov.Generuprogramatora();
                    bratislava.PridajObcanadomesta(ob);

                }
                string subor = "mesto.json";
                bratislava.UlozdoSuboru(subor);
                
            }
            bratislava.VypisObcanov();

            // definovanie mesta

            /* Mesto kosice = new Mesto("Kosice");            

             // Definovanie obcanov
             Obcan  obcan = new Obcan("Peter",45) {Meno = "Peter",Vek = 45};
             Obcan obcan1 = new Obcan("Igor",35) { Meno = "Igor", Vek = 35 };

             Obcan obcan2 = new Obcan("Jan",16) { Meno = "Jan", Vek = 16 };
             Obcan obcan3 = new Obcan("Martina", 45) { Meno = "Martina", Vek = 45 };

             Lekar lekar = new Lekar("Filo", 36);
             Predavac predavac = new Predavac() {Meno = "Dalibor", Vek = 25 };

             Lekar lekar1 = new Lekar("Vanasa", 16) ;
             Programator programator = new Programator("Rado",36, "Csharp") {Meno = "Rado", Vek = 36 };

             //zaludnenie miest
             bratislava.PridajObcanadomesta(lekar1);
             bratislava.PridajObcanadomesta(lekar);
             bratislava.PridajObcanadomesta(obcan);


             kosice.PridajPredavaca(predavac);
             kosice.PridajObcanadomesta(programator);
             kosice.PridajObcanadomesta(obcan3);

             // oznamenie
             bratislava.VypisObcanov();
             kosice.VypisObcanov();

            Lekar lekar = new Lekar("Filo", 36);
            Programator programator = new Programator("Rado", 36, "Csharp");
            Seniorprogramator programator1 = new Seniorprogramator("Rado", 36, "Csharp",75);
            
            /*while (bratislava.Obcania.Count < 31)
            {
                Obcan ob = Generatorobcanov.GenerujObcana();
                bratislava.PridajObcanadomesta(ob);
                
            }*/
            /*for (int i = 0; i < 31; i++)
            {
                Obcan ob = Generatorobcanov.GenerujObcana();
                bratislava.PridajObcanadomesta(ob);

            }*/
            /*while (bratislava.Obcania.Count < 31)
            {
                Obcan ob = Generatorobcanov.Generuprogramatora();
                bratislava.PridajObcanadomesta(ob);

            }
            string subor = "mesto.json";
            bratislava.UlozdoSuboru(subor);
           

            /* bratislava.PridajObcanadomesta(programator);
             bratislava.PridajObcanadomesta(lekar);
             bratislava.PridajObcanadomesta(programator1);*

            bratislava.VypisObcanov();*/
        }
    }
}