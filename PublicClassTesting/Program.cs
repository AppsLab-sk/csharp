
using PublicClassTesting;


string? playerName = Console.ReadLine();




Player player = new Player();
player.SetName(playerName);

Monster monster = new Monster();

player.DealDamage(monster);
monster.DealDamage(player);


Console.WriteLine(playerName);




