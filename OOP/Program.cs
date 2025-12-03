using OOP;

string PlayerName = Console.ReadLine();


Player player = new Player();
player.setName(PlayerName);

Monster monster = new Monster();


player.DealDamage(monster);

monster.GiveDamage(player);

Console.WriteLine(PlayerName);
