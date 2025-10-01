int mojeCislo = 1234;
string mojeSlovo = "Ahoj, svet!";
bool mojaBoolHodnota = true;
DateTime dnesnyDatum = DateTime.Now;
float myFloat = 5.75f;
int sucet = mojeCislo + 65;
var myVar = "Toto je var string";

Console.WriteLine(mojeCislo.ToString("000000"));
Console.WriteLine(mojeSlovo);
Console.WriteLine($"Súčet je: {sucet}");
Console.WriteLine($"dnes je robotkac{dnesnyDatum.ToString("yyyy-MM-dd")}");
Console.WriteLine($"mojaBoolHodnota je: {mojaBoolHodnota}");
Console.WriteLine(myVar);
Console.WriteLine(myFloat);
Console.WriteLine("Maximálny počet študentov v triede je: " + 30);
