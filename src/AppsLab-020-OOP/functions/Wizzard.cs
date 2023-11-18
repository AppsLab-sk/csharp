using System.Threading;

public interface IWizzard
{
    string Name { get; set; }
    int Health { get; set; }
    int AttackPower { get; set; }
    int HealAmount { get; set; }

    public void Attack(IWarrior warrior)
    {
        //warrior.Health -= AttackPower;
        warrior.Health = Math.Max(0, warrior.Health - AttackPower);
    }

    public void Heal(IWizzard wizzard)
    {
        wizzard.Health += 40;
    }
}

public class Wizzard : IWizzard
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Wizzard(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}

public class Wizzard2 : IWizzard
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Wizzard2(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}

public class Wizzard3 : IWizzard
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Wizzard3(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}

public class Wizzard4 : IWizzard
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Wizzard4(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}

public class Wizzard5 : IWizzard
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Wizzard5(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}