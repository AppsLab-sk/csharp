public class Warrior
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack(Wizzard wizzard)
    {
        //wizzard.Health -= AttackPower;
        wizzard.Health = Math.Max(0, wizzard.Health - AttackPower);
    }

    public void Heal(Warrior warrior)
    {
        warrior.Health += 50;
    }
}