Console.WriteLine("Stlač Klávesu");
var key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine($"Stlačili ste klávesu: {key.KeyChar}");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");
