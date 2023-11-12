using System.Threading;

public class Wizzard //: Warrior
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public void Attack(Warrior warrior)
    {
        //warrior.Health -= AttackPower;
        warrior.Health = Math.Max(0, warrior.Health - AttackPower);
    }

    public void Heal(Wizzard wizzard, Warrior warrior)
    {
        if (wizzard.HealAmount > 0)
        {
            wizzard.HealAmount = Math.Max(0, wizzard.HealAmount - 1);
            wizzard.Health += 40;
        }
        else 
        { 
            wizzard.Attack(warrior);
        }
    }
}