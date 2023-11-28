using System;
using System.Collections.Generic;

namespace AppsLab_020_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ICharacter> orcs = new List<ICharacter>();
            List<ICharacter> wizards = new List<ICharacter>();

            for (int i = 0; i < 5; i++)
            {
                orcs.Add(new Orc());
                wizards.Add(new Wizard());
            }

            Battle.SimulateBattle(orcs, wizards);

            Console.ReadLine();
        }
    }
}