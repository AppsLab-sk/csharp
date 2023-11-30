// See https://aka.ms/new-console-template for more information
using AppsLab_020_OOP;

using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var save = File.ReadAllLines("Save/Saves.txt");
            string wariorsTeamName = save[0];
            string wizardsTeamName = save[6];

            List<Warior> wariors = new List<Warior>();
            List<Wizard> wizards = new List<Wizard>();

            for (int i = 1; i <= 5; i++)
            {
                string[] wizardData = save[i].Split(";");
                var wizard = new Warior(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]));
                wariors.Add(wizard);
            }

            for (int i = 7; i <= 11; i++)
            {
                string[] warriorData = save[i].Split(';');
                var wizard  = new Wizard(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]), Int32.Parse(warriorData[3]));
                wizards.Add(wizard);
            }
            Random r = new Random();
            int round = 0;
            while (wizards.Count > 0 && wariors.Count > 0)
            {
                int wizardIndex = r.Next(wizards.Count - 1);
                int wariorIndex = r.Next(wariors.Count - 1);


                wizards[wizardIndex].Attack(wariors[wariorIndex]);
                wariors[wariorIndex].Attack(wizards[wizardIndex]);

                if (wizards[wizardIndex].Health < 0)
                {
                    wizards.RemoveAt(wizardIndex);
                    Console.WriteLine("Team " + wizardsTeamName + " na: " + wizards.Count);
                    Console.WriteLine("Team " + wariorsTeamName + " na: " + wariors.Count);
                }   
                   
                if (wariors[wariorIndex].Health < 0)
                {
                    wariors.RemoveAt(wariorIndex);
                    Console.WriteLine("Team " + wizardsTeamName + " na: " + wizards.Count);
                    Console.WriteLine("Team " + wariorsTeamName + " na: " + wariors.Count);
                }
                        

            } 
       
            if (wariors.Count > 0)
            {
                Console.WriteLine("vyhral team s menom  " + wariorsTeamName);
            }
            if (wizards.Count > 0)
            {
                Console.WriteLine("vyhral team s menom  " + wizardsTeamName);
            }
            if (wizards.Count==0 && wariors.Count==0)
            {
                Console.WriteLine("remizka");
            }
            Console.ReadLine();

            
        }
    }
}
