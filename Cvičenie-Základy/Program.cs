namespace Cvičenie_Základy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetSamohlasok = 0;

            Console.WriteLine("Napis text:");
            string text = Console.ReadLine();

            int lenght = SpocitajPismena(text);

            Char[] samohlasky = text.ToCharArray();

            foreach (char c in samohlasky)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                pocetSamohlasok++;
            }



            Console.WriteLine("Text je dlhy: " + text.Length + " písmen");
            Console.WriteLine("text obsahuje " + pocetSamohlasok + "samohlasok");
        }


        public static int SpocitajPismena(string text)
        {
            return text.Length;
        }
    }
}