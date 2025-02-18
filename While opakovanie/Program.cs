public class TestClass
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int vygenerovaneCislo = rnd.Next(maxValue: 100);

        Console.WriteLine("Ake je cislo?");

        while (true)
        {
            string text = Console.ReadLine();
            int attemps = 5;
            int cislo = int.Parse(text);

            if (cislo < vygenerovaneCislo)
            {
                Console.WriteLine("Cislo je vacsie");

            }
            if (cislo > vygenerovaneCislo)
            {
                Console.WriteLine("Cislo je mensie");
            }
            if (cislo == vygenerovaneCislo)
            {
                Console.WriteLine("Spravne");
            }
        }
    }
}