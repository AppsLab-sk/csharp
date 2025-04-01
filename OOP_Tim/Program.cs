using OOP_Tim;

public class Program
{
    public static void Main(string[] args)
    {
        Tim tim1 = new Tim("Draci");
        Tim tim2 = new Tim("Sokolo");
        Tim tim3 = new Tim("Orli");

        Console.WriteLine("Celkovy pocet timov : " + Tim.ZiskajPocetTimov());
    }
}

