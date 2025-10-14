int mojeCislo = 1234;
string mojeSlovo = "Ahoj kamarádi";
bool mojaBoolhodnota = true;
float myFloat = 2.5f;
var noveCislo = 255;
DateTime dnesnyDatum = DateTime.Now;
const int MaxStudents = 15 
int sucet = mojeCislo + 10;
Console.WriteLine(mojeCislo.ToString("00000"));   
Console.WriteLine(mojeSlovo);
Console.WriteLine($"Súčet je: {sucet}");   
Console.WriteLine($"Dnes je: {dnesnyDatum.ToString ("yyyy-MM-dd")}");
Console.WriteLine($"Bool hodnota je: {mojaBoolhodnota}");
Console.WriteLine(myFloat); 
Console.WriteLine(noveCislo);
Console.WriteLine("Maximalny pocet studentov je: " + MaxStudents);


Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine($"Ahoj, {meno}! Kolko mas rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Aha, mas teda 15 rokov");
Console.WriteLine("Ake je tvoje oblubene jedlo ?");
string jedlo = Console.ReadLine() ?? "0";
Console.WriteLine($"Hmm, {jedlo} znie skvele!");
Console.WriteLine("Daj mi vsetky peniaze co mas!");
string text = Console.ReadLine() ?? "0";
Console.WriteLine("Nevadi tak nabuduce!");
Console.WriteLine("Stlac klavesu: ");
var key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine($"Stlacili ste klavesu: {key.KeyChar}");





