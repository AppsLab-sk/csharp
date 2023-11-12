public class Warrior
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int HealAmount { get; set; }

    public void Attack(Wizzard wizzard)
    {
        //wizzard.Health -= AttackPower;
        wizzard.Health = Math.Max(0, wizzard.Health - AttackPower);
    }

    public void Heal(Warrior warrior, Wizzard wizzard)
    {
        //warrior.Health += 40;
        if (warrior.HealAmount > 0) 
        {
            warrior.HealAmount = Math.Max(0, warrior.HealAmount - 1);
            warrior.Health += 40;
        }
        else 
        {
            warrior.Attack(wizzard);
        }
    }
}