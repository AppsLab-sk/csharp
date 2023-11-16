using System.Threading;

public class Wizzard //: Warrior
{
    public string? Name;
    public int Health;
    public int AttackPower;
    public int HealAmount;
    private string v1;
    private int v2;
    private int v3;
    private int v4;

    public Wizzard(string v1, int v2, int v3, int v4)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
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

public class Wizzard2 : Warrior
{
    public Wizzard2(string v1, int v2, int v3, int v4) : base(v1, v2, v3, v4)
    {
    }
}