namespace obcan_a_mesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto Bratislava = new Mesto("Bratislava");
            Mesto Kosice = new Mesto("Kosice");

            string subor = Bratislava.NazovMesta + "mesto.json;";
           
            while (Bratislava.obcaniaList.Count < 31) 
            {
                Obcan o = GeneratorObcan.GenerujObcana();
                Bratislava.obcaniaList.Add(o);
            }

            for (int i = 0; i < 31; i++)
            {
                Obcan o = GeneratorObcan.GenerujObcana();
                Bratislava.PridajObcana(o);
            }
            for (int i = 0;i < 10; i++)
            {
                Programator p = GeneratorObcan.GenerujProgramatora();
                Bratislava.PridajObcana(p);
            }
            for (int i = 0; i < 10; i++)
            {
                Programator p = GeneratorObcan.GenerujProgramatora();
                Kosice.PridajObcana(p);
            }
            Bratislava.UlozDoSuboru(subor);


            Console.WriteLine("Obcania BL:");
            Bratislava.VypisObcanov();
            Console.WriteLine("Obcania KE:");
            Kosice.VypisObcanov();
        }
    }
}