Console.WriteLine("Ako sa voláš?");
string meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine();
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");

Console.WriteLine("Stlač klávesu: ");
var key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine($"Stlačili ste klávesu: {key.KeyChar}");