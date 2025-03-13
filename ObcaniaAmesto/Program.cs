namespace ObcaniaAmesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City Kosice = new City("Kosice");
            City Bratislava = new City("Bratislava");

            string subor = Bratislava.NazovMiestecka + "mesto.json";

            while (Bratislava.obcaniaList.Count < 31)
            {
                Citizen o = GeneratorObcanov.GenerujObcana();
                Bratislava.PridajObcanov(o);
            }

            for (int i = 0; i < 31; i++)
            {
                Citizen o = GeneratorObcanov.GenerujObcana();
                Kosice.PridajObcanov(o);
            }
            
            for (int i =0; i < 10; i++)
            {
                Programator p = GeneratorObcanov.GenerujProgramatora();
                Bratislava.PridajObcanov(p);
            }

            for (int i = 0; i < 10; i++)
            {
                Programator p = GeneratorObcanov.GenerujProgramatora();
                Kosice.PridajObcanov(p);
            }
            Bratislava.UlozDoSuboru(subor);

            Bratislava.VypisObcanov();    
            Kosice.VypisObcanov();
            
        }
    }
}