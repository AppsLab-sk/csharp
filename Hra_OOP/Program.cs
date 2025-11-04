
// uvod
using Hra_OOP;

internal class Program
{    
    private static void Main(string[] args)
    { 
        Console.WriteLine("Vitaj v mojej novej hre!");
        Console.WriteLine("Budes hrat 'Hviezdne vojny' no v mojej LEPSEJ verzii.");
        Console.WriteLine("Budes bojovat proti vesmirnym lodiam a bude to priebiehat v kolach.");
        Console.WriteLine("V 1. kole ta bude cakat normalna lod ale v 2. kole to bude boss.");
        Console.WriteLine("Tvojou ulohou je porazit vsetky lode a dostat sa na koniec.");
        Console.WriteLine("Prajem vela stastia!");

        MojCharacter hrac = new MojCharacter();
        monster nepriatel = new monster();
        Boss boss = new Boss();
        //


        //zvolenie si svojho charaktera a nepriatela
        Console.WriteLine("Zadaj meno svojho charakteru (lode): ");
        string characterName = Console.ReadLine();
        Console.WriteLine($"Takze tvoj character (lod) sa vola {characterName}.");


        Console.WriteLine("Zadaj meno svojho nepriatela: ");
        string monsterName = Console.ReadLine();
        Console.WriteLine($"Takze tvoj neporiatel sa vola {monsterName}.");
        //


        //1 arena
        Console.WriteLine("Okay. Ideme na to!");
        Console.WriteLine("stlac enter pre spustenie utoku!");
        Console.ReadLine();

        while (nepriatel.GetCurrentHp() > 0 && hrac.GetCurrentHp() > 0)
        {
            nepriatel.DealDamage(hrac);
            Console.WriteLine($"{monsterName} zaútočil na {characterName}!");
            Console.WriteLine($"{characterName} má ešte {hrac.GetCurrentHp()} životov.");

            if (hrac.GetCurrentHp() <= 0)
            {
                Console.WriteLine($"Gratulujem! Porazil si {characterName}!");
                break;
            }

            hrac.DealDamage(nepriatel);
            Console.WriteLine($"{characterName} zaútočil na {monsterName}!");
            Console.WriteLine($"{monsterName} má ešte {nepriatel.GetCurrentHp()} životov.");
        }


        // zvolenie si bossa
        Console.WriteLine("Takze ideme do finale!");
        Console.WriteLine("Najskor zadaj meno svojho bossa: ");
        string bossName = Console.ReadLine();
        Console.WriteLine($"Takze tvoj boss sa vola {bossName}");
        //

        // utok boss
        Console.WriteLine("Ideme na to!");
        Console.WriteLine("Stalc enter pre spustenie utoku: ");
        Console.ReadLine();             

        while (boss.GetCurrentHp() > 0 && hrac.GetCurrentHp() > 0)
        {
            boss.DealDamage(hrac);
            Console.WriteLine($"{bossName} zaútočil na {characterName}!");
            Console.WriteLine($"{characterName} má ešte {hrac.GetCurrentHp()} životov.");

            if (hrac.GetCurrentHp() <= 0)
            {
                Console.WriteLine($"Porazil si bossa {characterName}! Vyhral si hru!");
                break;
            }
        }
        //
    }  
}
