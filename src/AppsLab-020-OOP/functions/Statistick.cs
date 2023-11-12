public class Statistick
{
    //var intro = new Intro();

    public void Stats(Warrior warrior, Wizzard wizzard)
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

    public void WarriorAttack(Warrior warrior, Wizzard wizzard) 
    {
        Console.WriteLine(warrior.Name + " ubral: " + warrior.AttackPower + " životov " + wizzard.Name);
    }

    public void WizzardAttack(Warrior warrior, Wizzard wizzard)
    {
        Console.WriteLine(wizzard.Name + " ubral: " + wizzard.AttackPower + " životov " + warrior.Name);
    }
}