namespace KnihaUloha
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kniha mojakniha = new Kniha();

            mojakniha.Name = "Pocitanie prikladov";
            mojakniha.Pages = (160);

            Console.WriteLine("Nazov knihy:" + mojakniha.Name);
            Console.WriteLine("Nazov knihy:" + mojakniha.Pages);
        }
    }
}