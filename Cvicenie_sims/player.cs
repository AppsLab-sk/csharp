using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_sims
{
    public class player

    {
        string name { get; set; }
        public int money { get; set; } = 50;
        public int hunger { get; set; } = 100; 
        public int thirst { get; set; } = 100;
        public int helth { get; set; }  = 100;
        public int food { get; set; } = 0;
        public int water { get; set; } = 0;
        public void starving()
        {
            hunger -= 5;
            if (hunger <= 0)
            {
                hunger = 0;
                helth -= 10;
            }
        }

        public void thirsting()
        {
            thirst -= 20;
            if (thirst <= 0)
            {
                thirst = 0;
                helth -= 10;
            }
        }

        // ==================== HRÁČSKE AKCIE ====================

        public string Work()
        {
            money += 20;
            return $"Pracoval si a zarobil 20$. Máš {money}$";
        }

        public string BuyFood()
        {
            if (money >= 10)
            {
                money -= 10;
                food++;
                return $"Kúpil si jedlo. Jedlá: {food}";
            }
            return "Nemáš dosť peňazí!";
        }

        public string BuyWater()
        {
            if (money >= 5)
            {
                money -= 5;
                water++;
                return $"Kúpil si vodu. Vody: {water}";
            }
            return "Nemáš dosť peňazí!";
        }

        public string Eat()
        {
            if (food > 0)
            {
                food--;
                hunger += 25;
                if (hunger > 100) hunger = 100;
                return $"Zjedol si jedlo. Hunger: {hunger}";
            }
            return "Nemáš jedlo!";
        }

        public string Drink()
        {
            if (water > 0)
            {
                water--;
                thirst += 30;
                if (thirst > 100) thirst = 100;
                return $"Napil si sa. Thirst: {thirst}";
            }
            return "Nemáš vodu!";
        }
            public string Status()
            {
            return
                $"Health: {helth}\n" +
                $"Hunger: {hunger}\n" +
                $"Thirst: {thirst}\n" +
                $"Jedlo: {food}\n" +
                $"Voda: {water}\n" +
                $"Peniaze: {money}$";


            
        }
    }
}
