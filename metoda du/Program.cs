namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadaj text:");


            string vstup = Console.ReadLine();


            int pocetSamohlasok = PocetSamohlasok(vstup);


            Console.WriteLine("Text obsahuje " + pocetSamohlasok + " samohlásoky.");
        }


        static int PocetSamohlasok(string text)
        {

            char[] samohlasky = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int pocet = 0;


            foreach (char znak in text)
            {

                if (Array.Exists(samohlasky, element => element == znak))
                {
                    pocet++;
                }
            }


            return pocet;
        }
    }
}


























































