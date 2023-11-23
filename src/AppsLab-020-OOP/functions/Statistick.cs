using System.Security.Cryptography.X509Certificates;

public class Statistick
{
    //var intro = new Intro();

    public void Stats(IWarrior warrior, IWizzard wizzard)
    {
        Console.WriteLine(warrior.Name + " " + warrior.Health + " : " + wizzard.Name + " " + wizzard.Health);
    }

    public void NewRound(Intro intro)
    {
        Console.WriteLine("Nové kolo za:");
        Thread.Sleep(1000);
        Console.Clear();

        intro.Print();
        Console.WriteLine("Nové kolo za:");
        Console.WriteLine(@"

██████╗          
╚════██╗         
 █████╔╝         
 ╚═══██╗         
██████╔╝██╗██╗██╗
╚═════╝ ╚═╝╚═╝╚═╝
                 

");
        Thread.Sleep(1000);
        Console.Clear();

        intro.Print();
        Console.WriteLine("Nové kolo za:");
        Console.WriteLine(@"

██████╗          
╚════██╗         
 █████╔╝         
██╔═══╝          
███████╗██╗██╗██╗
╚══════╝╚═╝╚═╝╚═╝
                 

");
        Thread.Sleep(1000);
        Console.Clear();

        intro.Print();
        Console.WriteLine("Nové kolo za:");
        Console.WriteLine(@"

 ██╗         
███║         
╚██║         
 ██║         
 ██║██╗██╗██╗
 ╚═╝╚═╝╚═╝╚═╝
             

");
        Thread.Sleep(1000);
        Console.Clear();

        intro.Print();
        Console.WriteLine(@"

███████╗████████╗ █████╗ ██████╗ ████████╗
██╔════╝╚══██╔══╝██╔══██╗██╔══██╗╚══██╔══╝
███████╗   ██║   ███████║██████╔╝   ██║   
╚════██║   ██║   ██╔══██║██╔══██╗   ██║   
███████║   ██║   ██║  ██║██║  ██║   ██║   
╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   
                                          

");
        Thread.Sleep(1000);
        Console.Clear();
    }

    public IWarrior ChooseWarrior(List<IWarrior> warriors)
    {
        if (HasAlliveWarrior(warriors) == true)
        {
            Random random = new Random();
            int randomIndex;
            IWarrior chosenWarrior;
            do
            {
                randomIndex = random.Next(warriors.Count);
                chosenWarrior = warriors[randomIndex];
            }
            while (chosenWarrior.Health == 0);
            return chosenWarrior;
        } 
        else{ return null; }      
    }

    public bool HasAlliveWarrior(List<IWarrior> warriors)
    {
        return warriors.Any(warrior => warrior.Health > 0);
    }

    public void WarriorAttack(IWarrior warrior, IWizzard wizzard) 
    {
        Console.WriteLine(warrior.Name + " ubral: " + warrior.AttackPower + " životov " + wizzard.Name);
    }

    public IWizzard ChooseWizzard(List<IWizzard> wizzards)
    {
        if (HasAlliveWizzard(wizzards) == true) 
        { 
            Random random = new Random();
            int randomIndex;
            IWizzard chosenWizzard;
            do
            {
                randomIndex = random.Next(wizzards.Count);
                chosenWizzard = wizzards[randomIndex];
            }
            while (chosenWizzard.Health == 0);
            return chosenWizzard;
        }
        else { return null; }
    }

    public bool HasAlliveWizzard(List<IWizzard> wizzards)
    {
        return wizzards.Any(wizzard => wizzard.Health > 0);
    }

    public void WizzardAttack(IWarrior warrior, IWizzard wizzard)
    {
        Console.WriteLine(wizzard.Name + " ubral: " + wizzard.AttackPower + " životov " + warrior.Name);
    }
}