Console.WriteLine("Aké máš obľubené jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("Tvoje obľubene jedlo je, " + jedlo);

Console.WriteLine("Ako sa máš");
string stav = Console.ReadLine() ?? "0";
Console.WriteLine("Mám sa " + stav);
