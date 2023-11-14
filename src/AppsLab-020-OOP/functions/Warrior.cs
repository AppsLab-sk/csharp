using System.Xml.Linq;

public class Warrior
{
    private string? name;
    private int health;
    private int attackpower;
    private int healamount;
    private List<Warrior> warriorsList;

    public Warrior(List<Warrior> warriorsList)
    {
        this.warriorsList = warriorsList;
    }

    public Warrior(string name, int health, int attackpower, int healamount) 
    { 
        this.name = name;
        this.health = health;
        this.attackpower = attackpower;
        this.healamount = healamount;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Health 
    { 
        get { return health; }
        set { health = value; }
    }
    public int AttackPower 
    {
        get { return attackpower; }
        set { attackpower = value; }
    }
    public int HealAmount 
    {
        get { return healamount; }
        set { healamount = value; }
    }


    public void Attack(Wizzard wizzard)
    {
        //wizzard.Health -= AttackPower;
        wizzard.Health = Math.Max(0, wizzard.Health - AttackPower);
    }

    public void Heal(Warrior warrior)
    {
        warrior.health += 40;        
    }
}