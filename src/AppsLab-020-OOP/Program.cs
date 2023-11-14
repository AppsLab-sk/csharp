 using AppsLab_020_OOP;
public static class Program
{
     static void Main(string[] args)
     {
        Mage mage = new Mage();
        mage.Name = "Octavius";
        mage.Health = 140;
        mage.AttackPower = 25;
        Warrior war = new Warrior();
        war.Name = "Hlien";
        war.Health = 240;
        war.AttackPower = 15;
    }
}

