Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine(" Ahoj, " + meno + " koľko máš rokov? ");

string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Aha,máš teda " + vek + " rokov.");

Console.WriteLine("Aké je tvoje obľúbené jedlo? ");
string jedlo = Console.ReadLine() ?? "0";
Console.WriteLine(jedlo + " to znie skvele. ");
