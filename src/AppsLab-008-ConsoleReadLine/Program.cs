Console.WriteLine("Ako sa voláš?"); 
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno + " kolko maš rokov?");


string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Aha,Máš teda " + vek + " rokov.");
Console.WriteLine("Ake je tvoje oblubene jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("Hmm Svieckova z rizou znie skvele");
Console.WriteLine("pozicaj my peniaze prosim");
string? text = Console.ReadLine();
Console.WriteLine("skap");