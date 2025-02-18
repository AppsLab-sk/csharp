namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sirka = Int32.Parse(Console.ReadLine());
            int vyska = Int32.Parse(Console.ReadLine());
            Rectangle re = new Rectangle(sirka, vyska);
            int obsah = re.Obsah();
            Console.WriteLine("Obsah je " + obsah);

            Rectangle rec = new Rectangle(re.sirka * 10, re.vyska * 10);
            int vysledok = rec.Obsah();
            Console.WriteLine(vysledok);
        }

    }
}