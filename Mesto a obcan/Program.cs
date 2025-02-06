using System.Text.Json;

namespace Mesto_a_obcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvorenie mesta
            //Mesto Bratislava = new Mesto("Bratislava");

            //Obcania 



            /*while (Bratislava.obcania.Count < 31)
             {
                 Obcan o = GeneratorObcanov.GenerujObcana();
                 Bratislava.PridajObcanadomesta(o);
             }


             for (int i = 0; i < 31; i++)
             {
                 Obcan o = GeneratorObcanov.GenerujObcana();
                 Bratislava.PridajObcanadomesta(o);
             }*/

            Mesto Bratislava = Mesto.Nacitajzosuboru("mesto.json");
            if (Bratislava == null)
            {
                Bratislava = new Mesto("Bratislava");
                for (int i = 0; i < 31; i++)
                {
                    Obcan o = GeneratorObcanov.GenerujObcana();
                    Bratislava.PridajObcanadomesta(o);
                }
            }
            
            /*while (Bratislava.Obcania.Count < 31)
            {
                Elekrikari o = GeneratorObcanov.GenerujJayzk();
                Bratislava.PridajObcanadomesta(o);
            }*/

            
            //Blava.json
            string subor = "mesto.jsob";
            Bratislava.UlozDoSuboru(subor);

            //Vypis obcanov Bratislavy
            Bratislava.VypisObcanov();


            





        }

    }
}