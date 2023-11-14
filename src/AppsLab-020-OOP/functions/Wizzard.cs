using System.Threading;

public class Wizzard //: Warrior
{
    private string? name;
    private int health;
    private int attackpower;
    private int healamount;
    private List<Wizzard> wizzardList;

    public Wizzard(List<Wizzard> wizzardList)
    {
        this.wizzardList = wizzardList;
    }

    public Wizzard(string name, int health, int attackpower, int healamount)
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

    public void Attack(Warrior warrior)
    {
        //warrior.Health -= AttackPower;
        warrior.Health = Math.Max(0, warrior.Health - AttackPower);
    }

    public void Heal(Wizzard wizzard)
    {
       wizzard.Health += 40;
    }
}