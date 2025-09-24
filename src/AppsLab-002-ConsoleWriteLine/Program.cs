int mojeCislo = 1234;
string MojeSlovo = "Ahoj, svet!";
bool mojaBoolHodnota = true;
DateTime dnesnyDatum = DateTime.Now; 
float myFloat = 5.75f;
int sucet = mojeCislo + 5;
var myVar = "Toto je var string";

Console.WriteLine(mojeCislo.ToString("000000"));
Console.WriteLine(MojeSlovo);
Console.WriteLine($"Súčet je: {sucet}");
Console.WriteLine($"Dnes je: {dnesnyDatum.ToString("yyyy-MM-dd")}");
Console.WriteLine($" Bool hodnota je: {mojaBoolHodnota}");
Console.WriteLine($"float hodnota je: {myFloat}");
Console.WriteLine(myVar); 








