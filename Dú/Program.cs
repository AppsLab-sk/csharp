using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Inicializácia prázdneho zoznamu
        List<string> mena = new List<string>();

        // Nekonečný cyklus pre zadávanie mien
        while (true)
        {
            Console.Write("Zadajte meno (alebo napíšte 'stop' pre ukončenie): ");
            string meno = Console.ReadLine();

            // Ak užívateľ zadá 'stop', ukončíme cyklus
            if (meno.ToLower() == "stop")
            {
                break;
            }

            // Pridanie mena do zoznamu
            mena.Add(meno);
            Console.WriteLine($"{meno} bolo pridané do zoznamu.");
        }

        // Vypísanie všetkých zadaných mien
        Console.WriteLine("\nZoznam všetkých zadaných mien:");
        foreach (string meno in mena)
        {
            Console.WriteLine(meno);
        }
    }
}