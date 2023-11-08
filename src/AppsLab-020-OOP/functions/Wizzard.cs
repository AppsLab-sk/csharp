public class Wizzard //: Warrior
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack(Warrior warrior)
    {
        //warrior.Health -= AttackPower;
        warrior.Health = Math.Max(0, warrior.Health - AttackPower);
    }

    public void Heal(Wizzard wizzard)
    {
        wizzard.Health += 50;
    }
}