using System;
using System.Net.Mail;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<string> store = new List<string>();

            bool isEnd = false; 
            while (!isEnd)
            {
            PrintMenu();
            var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        foreach (var item in store)
                        {
                            Console.WriteLine(item);    
                        }
                        Console.WriteLine("Zadaj hociaky znak a ENTER pre vymazanie konzoly!");
                        Console.ReadLine();
                        break;


                    case "2":
                        Console.WriteLine("Zadajte meno noveho predmetu: ");
                        var newItemName = Console.ReadLine() ?? "0";
                        Console.WriteLine("Zadajte kolko kusov noveho predmetu");
                        var newItemCount = Console.ReadLine() ?? "0";
                        AddItem(store, newItemName,Int32.Parse(newItemCount));
                        break;

                    case "3":
                        isEnd = true;
                        break;
        
                    default:
                        Console.WriteLine("Nespravna akcia!");
                        break;
                }
            }
        }

        public static void AddItem(List<string> itemlist, string itemName, int itemCount)
        {
            string foundItem = null;
            foreach (var item in itemlist)
            {
                if (item.Contains(itemName))
                {
                    foundItem = item;
                }
            }

            if (foundItem == null)
            {
                var newCreatedItem = $"{itemName}||{itemCount}";
                itemlist.Add(newCreatedItem);
                Console.WriteLine($"Predmet {itemName.ToUpper()} bol pridany do obchodu");
            }
            else
            {
                var splittedItem = foundItem.Split("||");
                var foundItemName = splittedItem[0];
                var foundItemCount = Int32.Parse(splittedItem[1]);
                var newItemCount = foundItemCount + itemCount;

                var indexOfItem = foundItem.IndexOf(foundItem);
                itemlist[indexOfItem] = $"{itemName}||{newItemCount}";
                Console.WriteLine($"Predmet {itemName.ToUpper()} bol zaktualizovany do obchodu");
            }
        }

        public static void PrintMenu()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("1.Vypis poloziek");
            Console.WriteLine("2.Pridane polozky");
            Console.WriteLine("4.Exit");
            Console.Write("Vyberte akciu:");
        }
    }
}
