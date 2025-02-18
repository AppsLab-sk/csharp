using System.ComponentModel;
using System.Diagnostics.Metrics;
class TestClass
{
    static void Main(string[] args)
    {
        SpocitajteSamohlasky();

        Console.WriteLine(args.Length);
    }
    public static void SpocitajteSamohlasky()
    {
        Console.WriteLine("Write text");
        string text = Console.ReadLine();
        int length = text.Length;
        int vowelCount = 0;

        char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O','U' };
        {
            {
                vowelCount++;
            }
            Console.WriteLine($"Počet samohlások: {vowelCount}");
        }
    }
    
}
