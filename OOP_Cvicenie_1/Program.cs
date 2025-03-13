namespace OOP_Cvicenie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kniha kniha1 = new Kniha();

            kniha1.Nazov = "How To Understand Women";
            kniha1.PocetStran = 100;

            Console.WriteLine("Kniha:");
            Console.WriteLine($"Nazov: {kniha1.Nazov}"); 
            Console.WriteLine($"Pocet stran: {kniha1.PocetStran}");

        }
    }
}