namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto mesto1 = new Mesto("Bratislava");
            Mesto mesto2 = new Mesto("Zilina");

            Obcan obcan1 = new Obcan("Jozef", 20);
            mesto1.PridajObcana(obcan1);
            mesto1.PridajObcana(new Obcan("Peter", 30));
            mesto1.PridajObcana(new Obcan("Igor", 40));

            mesto2.PridajObcana(new Obcan("Michal", 10));
            mesto2.PridajObcana(new Obcan("Marek", 15));
            mesto2.PridajObcana(new Obcan("Lucia", 16));

            mesto1.VypisObcanov();
            mesto2.VypisObcanov();
          
        }

    }
}