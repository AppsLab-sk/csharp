using System.Security.Cryptography.X509Certificates;

public class Statistick
{
    //var intro = new Intro();

    public int WarriorsWins { get; set; }
    public int WizzardsWins { get; set; }
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

    public IWarrior ChooseWarrior(List<IWarrior> bWarriors)
    {
        if (HasAlliveWarrior(bWarriors) == true)
        {
            Random random = new Random();
            int randomIndex;
            IWarrior chosenWarrior;
            
            randomIndex = random.Next(bWarriors.Count);
            chosenWarrior = bWarriors[randomIndex];
  
            return chosenWarrior;
        } 
        else{ return null; }      
    }

    public bool HasAlliveWarrior(List<IWarrior> bWarriors)
    {
        if (bWarriors.Count() > 0)
        {
            return true;
        }else { return false; }
    }

    public void AddWinWarriors() 
    {
        WarriorsWins += 1;
    }

    public void WarriorAttack(IWarrior warrior, IWizzard wizzard) 
    {
        Console.WriteLine(warrior.Name + " ubral: " + warrior.AttackPower + " životov " + wizzard.Name);
    }

    public IWizzard ChooseWizzard(List<IWizzard> bWizzards)
    {
        if (HasAlliveWizzard(bWizzards) == true) 
        { 
            Random random = new Random();
            int randomIndex;
            IWizzard chosenWizzard;
            
            randomIndex = random.Next(bWizzards.Count);
            chosenWizzard = bWizzards[randomIndex];
                
            return chosenWizzard;
        }
        else { return null; }
    }

    public bool HasAlliveWizzard(List<IWizzard> bWizzards)
    {
        if (bWizzards.Count() > 0)
        {
            return true;
        }else { return false; }
    }
    public void AddWinWizzards()
    {
        WizzardsWins += 1;
    }

    public void WizzardAttack(IWarrior warrior, IWizzard wizzard)
    {
        Console.WriteLine(wizzard.Name + " ubral: " + wizzard.AttackPower + " životov " + warrior.Name);
    }
}