using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Character
    {
        static void Main(string[] args)
        {




            string[] save = File.ReadAllLines(path: "save/saves.txt");
            string jednota = save[0];
            string lidl = save[6];

            List<Warrior> lidlWar = new List<Warrior>();
            List<Mage> jednotaMag = new List<Mage>();

            for (int i = 1; i <= 5; i++)
            {
                string[] mageData = save[i].Split(separator: ";");
                var jednotamag1 = new Mage(mageData[0], health: Int32.Parse(mageData[1]),
                   attackPower: Int32.Parse(mageData[2]), mana: Int32.Parse(mageData[3]));
                jednotaMag.Add(jednotamag1);
            }



            for (int i = 7; i <= 11; i++)
            {
                string[] wariorData = save[i].Split(separator: ';');
                var lidlwar1 = new Warrior(wariorData[0], health: Int32.Parse(wariorData[1]),
                attackPower: Int32.Parse(wariorData[2]));
                lidlWar.Add(lidlwar1);
            }
            Random r = new Random();
            int round = 0;
            while (jednotaMag.Count > 0 && lidlWar.Count > 0)
            {
                int jednotaindex = r.Next(jednotaMag.Count - 1);
                int lidlindex = r.Next(lidlWar.Count - 1);


                jednotaMag[jednotaindex].Attack(lidlWar[lidlindex]);
                lidlWar[lidlindex].Attack(jednotaMag[jednotaindex]);

                

                if (jednotaMag[jednotaindex].Health < 0)
                    jednotaMag.RemoveAt(jednotaindex);
                if (lidlWar[lidlindex].Health < 0)
                    lidlWar.RemoveAt(lidlindex);
              
            }
            if (lidlWar.Count > 0)
                Console.WriteLine("Lidl je tá správna voľba");
            if (jednotaMag.Count > 0)
                Console.WriteLine("V jednote je sila");
            if (lidlWar.Count == 0 && jednotaMag.Count == 0)
                Console.WriteLine("Kaufland on top");
        }
    }
}