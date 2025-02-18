namespace TimOPP
{
    private static void Main (string[] args)
    {
        
        Tim tim1 = new Tim("Tím 1");
        Tim tim2 = new Tim("Tím 2");
        Tim tim3 = new Tim("Tím 3");

       
        Console.WriteLine($"Celkový počet vytvorených tímov: {Tim.ZiskajPocetTimov()}");
    }
}