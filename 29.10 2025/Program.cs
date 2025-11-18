
using _29._10_2025;
Console.WriteLine("Zadaj meno hracovy");
string playerName = Console.ReadLine();
Player player = new Player();
player.SetName(playerName);
Monster monster = new Monster();

player.DealDamage(monster);
Monster.DealDamage(player);

Console.WriteLine();

