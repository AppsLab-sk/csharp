namespace Cvicenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Zadaj sirku obdlzika ! : ");
            int sirka = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj vysku obdlznika ! : ");
            int vyska = Int32.Parse(Console.ReadLine());
            Rectangle re = new Rectangle(vyska ,sirka);
            int obsah = re.ObsahObdlznika();
            Console.WriteLine(" Obsah je " + obsah);

            int sirka2 = re.sirka;
            int vyska2 = re.vyska;
            Rectangle ra = new Rectangle(vyska2 * 10,sirka2 * 10);
            int obsah2 = ra.ObsahObdlznika();
            Console.WriteLine("Obsah druheho obdlznika je " + obsah2);
            
        }
    }
}



