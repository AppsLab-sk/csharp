using System.Threading.Channels;

namespace cvicenie_gameshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = lootgenerator.GetRandomLoot();
            Item najdrahsia = items.OrderByDescending(item => item.Price).Skip(1).First();

            Console.WriteLine("Najdrahší item:" + najdrahsia);
            Item najlacnejsia = items.OrderBy(item => item.Price).First();
            Console.WriteLine("Najlacnejši item:" + najlacnejsia);
            List<Item> ItemsUnder1000 = items.Where(item => item.Price <=1000).ToList();
            Console.WriteLine("Tolko veci tstoji menej jak 1000:" + ItemsUnder1000.Count);
            List<Item> nad500pod1000 = items.Where(item => item.Price >= 500  && item.Price <= 1000).ToList();
            Console.WriteLine("Veci ktore stoja viac ako 500 a menej ako 1000:" + nad500pod1000.Count);
        }

    }

    
}

