namespace OOP_Civicenie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tim tim1 = new Tim("Tim 1");
            Tim tim2 = new Tim("Tim 2");
            Tim tim3 = new Tim("Tim 3");
            Tim tim4 = new Tim("Tim 4");
            Tim tim5 = new Tim("Tim 5");

            Console.WriteLine($"Pocet timov: {Tim.ziskajPocetTimov()}");
        }
    }
}