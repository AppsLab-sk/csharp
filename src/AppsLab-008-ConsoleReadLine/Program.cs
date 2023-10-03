Console.WriteLine("Ako sa voláš?");
string? Juraj = Console.ReadLine();
Console.WriteLine("Ahoj, " + Juraj);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "15";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");
