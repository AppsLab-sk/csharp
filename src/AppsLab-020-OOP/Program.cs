using AppsLab_020_OOP;

string PlayerName = Console.ReadLine();

Player Matej = new Player();
Matej.SetName(PlayerName);

Monster monster = new Monster();

Matej.DealDamage(monster);
monster.DealDamage(Matej);