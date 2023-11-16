using AppsLab_020_OOP;

string value = Console.ReadLine();

static void Main(string[] args)
{
    var warrior = new Warrior();
    warrior.Name = "Bojovník";
    warrior.Health = 2000;
    warrior.AttackPower = 10;

    var wizzard = new Wizzard
    wizzard.Name = "carodejnik";
    wizzard.Health = 1000;
    wizzard.Mana = 1000;
    wizzard.AttackPower = 20;


    int round = 0;
    while (wizzard.stillAlive()) ;