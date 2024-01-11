using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Threading;
using AppsLab_020_OOP;
using static System.Net.Mime.MediaTypeNames;

public static class Program
{
    static void Main(string[] args)
    {
        var save = File.ReadAllLines("NewFolder1/save.txt");

        string orksTeamName = save[0];
        string wizardsTeamName = save[6];


        List<Wizard> wizards = new List<Wizard>();
        List<Ork> orks = new List<Ork>();

        for (int i = 1; i <= 5; i++)
        {  
             string[] wizardData = save[i].Split(';');
             var wizard = new Wizard(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]));
             wizards.Add(wizard);
        }

        for (int i = 7; i <= 11; i++)
        {
            string[] orkData = save[i].Split(';');
            var ork = new Ork(orkData[0], Int32.Parse(orkData[1]), Int32.Parse(orkData[2]));
            orks.Add(ork);
        }

        //var battle = new Battle();

        //public void SimulateBattle(Wizard wizard, Ork ork, int maxRounds)

        Random r = new Random();
        int round = 0;
        while (orks.Count>0 && wizards.Count>0)
       
        {
            int wizardIndex = r.Next(wizards.Count - 1);
            int orkIndex = r.Next(orks.Count - 1);


            orks[orkIndex].Attack(wizards[wizardIndex]);
            wizards[wizardIndex].Attack(orks[orkIndex]);


            if (wizards[wizardIndex].Health < 0)
                wizards.RemoveAt(wizardIndex);
            if (orks[orkIndex].Health < 0)
                orks.RemoveAt(orkIndex);

        }
        if (wizards.Count>0)
        {
            Console.WriteLine("vyhral team s menom: " + wizardsTeamName);
        }
        if (orks.Count>0)
        {
            Console.WriteLine("vyhral team s menom: " + orksTeamName);
        }
        if (orks.Count ==0 && wizards.Count==0)
            Console.WriteLine("Tie.");
    }

}







