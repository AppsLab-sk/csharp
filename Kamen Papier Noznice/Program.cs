class Program
{
    static void Main()
    {
        string[] moznosti = { "kamen", "papier", "noznice" };
        var rnd = new Random();
        Console.WriteLine("Vitaj v Hre Kamen/Papier/Noznice!");
        Console.WriteLine("Stlac Enter do hry");
        Console.ReadLine();
        Console.WriteLine(" Hra sa Zacala!");

        Console.Write("Vyber si (kamen-papier-noznice): ");
        string hrac = Console.ReadLine();
        string pc = moznosti[rnd.Next(3)];

        Console.WriteLine("PC: " + pc);

        if (hrac == pc) Console.WriteLine("Remiza");
        else if (hrac == "kamen" && pc == "noznice" ||
                 hrac == "papier" && pc == "kamen" ||
                 hrac == "noznice" && pc == "papier")
            Console.WriteLine("Vyhral si!");
        else
            Console.WriteLine("Prehral si!");
    }
}