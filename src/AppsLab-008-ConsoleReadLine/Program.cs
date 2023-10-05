Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Aha ! Máš " + vek + " rokov.");

Console.WriteLine("Aké je tvoje obľúbené jedlo ? ");
string? jedlo = Console.ReadLine();
Console.WriteLine("Hmmmm " + jedlo + " by som si dal.");

Console.WriteLine("Stlač klávesu: ");
var key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine($"Stlačili ste klávesu: {key.KeyChar}");