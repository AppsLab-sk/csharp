namespace OOP_Kniznica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kniha kniha = new Kniha();

            kniha.Nazov = "Lebo";
            kniha.PocetStran = 100;

            Console.Clear();
            Console.WriteLine("Kniha: ");
            Console.WriteLine($"Nazov: {kniha.Nazov}");
            Console.WriteLine($"toto {kniha.PocetStran}");
        }
    }
}