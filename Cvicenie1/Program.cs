
namespace Cvicenie1
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            Class1 re = new Class1(x, y);
            int obsah = re.Obsah();
            Console.WriteLine("Obsah je" + obsah );   
            
            Class1 r = new Class1 (10*re.x, 10*re.y);
            int obsah1 = re.Obsah();
            Console.WriteLine("Obsah2 je" + obsah);
        }
    }
}

