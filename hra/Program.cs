using ConsoleApp1;

Console.WriteLine("Zadaj meno hráčovy");
string playername = Console.ReadLine();
Console.WriteLine("Zadaj meno príšeri");
string monstername = Console.ReadLine();


Player player = new Player();
player.SetName(playername);

Monster monster = new Monster(monstername);

player.DealDamage(monster);

Console.WriteLine();

monster.DealDamage(player);

Console.WriteLine();

