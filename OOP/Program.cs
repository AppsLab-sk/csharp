using OOP;
string Pname = Console.ReadLine();
player player = new player();
player.SetName(Pname);
string MonName = Console.ReadLine();
Monster monster = new Monster();
monster.SetName(MonName);
player.DealDamage(monster);
monster.DealDamage(player);
Console.WriteLine();

/*
 *  random damage
 *   prisera robi damage
 *   hrac dostane meno
 */
