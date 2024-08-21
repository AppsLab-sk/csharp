public class Program
{
    static void Main()
    {
        var warrior = new Warrior();
        warrior.Name = "Bojovník";
        warrior.AttackPower = 50;
        warrior.Health = 100;

        var wizzard = new Wizzard();
        wizzard.Name = "Čarodej";
        wizzard.AttackPower = 60;
        wizzard.Health = 100;

        while (warrior.Health > 0 && wizzard.Health > 0)
        {
            warrior.Attack(wizzard);
            wizzard.Attack(warrior);

            Console.WriteLine(warrior.Name + warrior.Health + " : " +  wizzard.Name + wizzard.Health);
        }
        if (warrior.Health <= 0 && wizzard.Health <= 0) 
        {
            Console.WriteLine("Remíza.");
        }
        if (warrior.Health <= 0 && wizzard.Health > 0) 
        {
            Console.WriteLine(wizzard.Name + " vyhral.");
        }
        if (wizzard.Health <= 0 && warrior.Health > 0)
        {
            Console.WriteLine(warrior.Name + " vyhral.");
        }
    }
}








public class Warrior
{ 
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack(Wizzard wizzard) 
    {
        wizzard.Health -= AttackPower;
    }

    public int Defend() 
    {
        int EAttackPower = 0;
        return EAttackPower;
    }

    public int Heal() 
    {
        return Health + 50;
    }
}

public class Wizzard //: Warrior
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    
    public void Attack(Warrior warrior)
    {
        warrior.Health -= AttackPower;
    }

    public int Defend()
    {
        int AttackPower = 0;
        return AttackPower;
    }

    public int Heal()
    {
        return Health + 50;
    }
}

public class Battle
{ 

}
