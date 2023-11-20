using System.Reflection.Metadata;
using System.Xml.Linq;

public interface IWarrior
{
    string Name { get; set; }
    int Health { get; set; }
    int AttackPower { get; set; }
    int HealAmount { get; set; }

    public void Attack(IWizzard wizzard)
    {
        //wizzard.Health -= AttackPower;
        wizzard.Health = Math.Max(0, wizzard.Health - AttackPower);
    }

    public void Heal(IWarrior warrior)
    {
        warrior.Health += 40;
    }
}

public class Warrior : IWarrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Warrior(string name, int health, int attackpower, int healamount) 
    { 
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }

    public void Attack(IWizzard wizzard)
    {
        //wizzard.Health -= AttackPower;
        wizzard.Health = Math.Max(0, wizzard.Health - AttackPower);
    }

    public void Heal(IWarrior warrior)
    {
        warrior.Health += 40;
    }
}

public class Warrior2 : IWarrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Warrior2(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}

public class Warrior3 : IWarrior 
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Warrior3(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}

public class Warrior4 : IWarrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Warrior4(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}

public class Warrior5 : IWarrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public Warrior5(string name, int health, int attackpower, int healamount)
    {
        Name = name;
        Health = health;
        AttackPower = attackpower;
        HealAmount = healamount;
    }
}