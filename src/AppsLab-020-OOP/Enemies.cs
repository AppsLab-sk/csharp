using AppsLab_020_OOP;

public class Orc
{
    public string Name { get; set; } = "Orc";
    public int Hp { get; set; } = 87;
    public int Defense { get; set; } = 19;
    public int AttackPower { get; set; } = 49;
    private bool hasTakenAction = false;

    public void Attack(Wizard enemy)
    {
        if (hasTakenAction)
        {
            Console.WriteLine("Orc has already taken action in this turn.");
            return;
        }

        int damage = AttackPower - enemy.Defense;
        damage = Math.Max(0, damage);

        Console.WriteLine("Orc is attacking with power: " + damage);
        enemy.Hp -= damage;

        Console.WriteLine("Wizard's Health after attack is: " + enemy.Hp);

        if (enemy.Hp <= 0)
        {
            Console.WriteLine("Orc has died!");
        }

        hasTakenAction = true;
    }

    public void ResetAction()
    {
        hasTakenAction = false;
    }

    public bool StillAlive()
    {
        return Hp > 0;
    }

    public override string ToString()
    {
        return Name + "(" + Hp + ")";
    }
}
