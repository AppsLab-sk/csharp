int mojeCislo = 20;
string mojeSlovo = "Ahoj Svet!";
bool mojaBoolHodnota = true;
DateTime dnesnyDatum = DateTime.Now;
float myFloat = 5.75f;
int sucet = mojeCislo + 5;
var myVar = "Toto je var string";

Console.WriteLine(mojeCislo.ToString("000000"));
Console.WriteLine(mojeSlovo);
Console.WriteLine($"Sučet je: {sucet}");
Console.WriteLine($"Dnes je: {dnesnyDatum.ToShortDateString()}");
Console.WriteLine($"Bool hodnota je: {mojaBoolHodnota}");
Console.WriteLine($"Float hodnota je: {myFloat}");
Console.WriteLine(myVar);

//char c = 'AA';
//Console.WriteLine(myByte);
//Console.WriteLine(age);
//Console.WriteLine(name)

//Console.WriteLine($"My name is {name} and I am {age} years