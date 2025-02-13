namespace OOP_T9m
{
    internal class Program
    {
        static void Main(string[] args)
        {
            team tim1 = new team("Team 1");
            team tim2 = new team("Team 2");
            team tim3 = new team("Team 3");
            team tim4 = new team("Team 4");
            team tim5 = new team("Team 5");

            Console.WriteLine($"Pocet timov: { team.ziskajPocetTimov()}");
        }
    }
}