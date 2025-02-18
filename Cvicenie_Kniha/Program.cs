namespace Cvicenie_Kniha
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Kniha k = new Kniha("Nature", 250);

            Console.WriteLine($"Nazov: {k.Nazov}");
            Console.WriteLine($"Pocet stran: {k.PocetStran}");
        }
    }
}