namespace Cvicenie_Tim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tim tim1 = new Tim("Draci");
            Tim tim2 = new Tim("Sokoli");
            Tim tim3 = new Tim("Orli");

            Console.WriteLine("Celkovy pocet timov: " + Tim.ZiskajPocetTimov());
        }
    }
}