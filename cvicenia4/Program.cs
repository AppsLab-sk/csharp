namespace cvicenia4
{
    internal class Program
    {
        static void Main(string[] args)
        {                                                                               
            Console.WriteLine("Zadaj vysku obdlznika");
            int sirka = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj sirku obdlznika");
            int vyska = Int32.Parse(Console.ReadLine());
           Rectangle re = new Rectangle(sirka,vyska);
           int obsah = re.Obsah();
            Console.WriteLine("obsah je " + obsah);

            int krat = 10;
            int sirka2 = re.sirka;
            int vyska2 = re.vyska;
            Rectangle ra = new Rectangle(vyska2 * 10, sirka2 * 10);
            int obsah2 = ra.Obsah();
            Console.WriteLine("Obsah druheho obdlznika je " + obsah2);
          
        
        
        
        }
    }
} 
