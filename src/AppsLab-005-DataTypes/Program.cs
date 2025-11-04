int mojeCislo = 15;
string mojeSlovo = "Ahoj, svet!";
bool mojaBoolHodnota = true;
DateTime dnesnyDatum = DateTime.Now;
float myFloat = 5.5f;
int sucet = mojeCislo + 5;
var myVar = "Toto je var string";
const int MaxStudents = 15;

Console.WriteLine(mojeCislo.ToString("000000"));
Console.WriteLine(mojeSlovo);
Console.WriteLine($"Súčet je: {sucet}");
Console.WriteLine($"Dnes je: {dnesnyDatum.ToString("yyyy-MM-dd")}");
Console.WriteLine($"Bool hodnota je: {mojaBoolHodnota}");
Console.WriteLine(myFloat);
Console.WriteLine(myVar);
Console.WriteLine("Maximálny počet študentov v triede je: " + MaxStudents);

