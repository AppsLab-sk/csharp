using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                            Console.WriteLine(item) ;
                            


                        }
                        break;
                    case "2":
                        Console.WriteLine("Zadajte meno noveho predmetu");
                        var newItemName = Console.ReadLine();
                        Console.WriteLine("Zadajte kolko kusov noveho predmetu");
                        var newItemCount = Console.ReadLine();
                        AddItem(store,newItemName,Int32.Parse(newItemCount));
                        break;
                    case "3":
                        isEnd = true;
                        break;
               
               default: Console.WriteLine("Nespravna akcia");
                        break; 
                }
            
            
            
            } 

        }

        public static void AddItem(List<string> itemList,string itemName, int itemCount)
        {

            string foundedItem = null;
            foreach (var item in itemList)
            {

              if (item.Contains(itemName))
                {

                    foundedItem = item;
                }
            
            
            }

            if (foundedItem == null)
            {






                var newCreatedItem = $"{itemName}|| {itemCount}";
                itemList.Add(newCreatedItem);
                Console.WriteLine($"Predmet {itemName.ToUpper()} bol pridany do obchodu. ");

            }
        
           else
            {
            var splittedItem = foundedItem.Split("||");
            var foundedItemName = splittedItem[0];
            var foundedItemCount = Int32.Parse(splittedItem[1]);
            var newItemCount = foundedItemCount + itemCount;
            
            
            var indexOfItem = foundedItem.IndexOf(foundedItem);
            itemList[indexOfItem] = $" {itemName} || {newItemCount}";
                Console.WriteLine($"Predmet {foundedItemName.ToUpper()} bol zaktualizovany do obchodu");
            }
        
        
        }
            
            
            
            
            
            
            
            
            
            public static void PrintMenu()
        {

            
            Console.Clear();
            Console.WriteLine("1.Vypis poloziek");
            Console.WriteLine("2.Pridanie polozky");
            Console.WriteLine("3.Exit");
            Console.Write("Vyberte akciu");



        } 
    
    }
}






