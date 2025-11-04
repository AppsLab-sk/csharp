/*
string i = "*";
while (i.Length < 6)
{
    Console.WriteLine(i);
    i = "*";
}
string j = "*****";
while (j.Length > 0)
{
    Console.WriteLine(j);
   j = j.Substring(0, j.Length -1);
}
*/


/*
int[] cislo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int i = 0;
int vysledok = 0;
for (i = 0; i < cislo.Length; i++)
{
    vysledok += cislo[i];
}
Console.WriteLine(vysledok);
*/


/*
string[] names = { "Dnes", "sa", "mam", "dobre" };
foreach (string name in names)
{
    Console.Write($" {name} ");
}
*/


/*
List<int> numbers = new List<int>();
Console.WriteLine("Zadaj cislo");
string vstup = Console.ReadLine();

while (vstup != "+") 
{
    numbers.Add(int.Parse(vstup));
    Console.WriteLine("Zadaj cislo");
    vstup = Console.ReadLine();
}

    Console.WriteLine("Vysledok scitania:");
    int sucet = 0;
    foreach  (int i in numbers)
    {
        sucet += i;
    }
    Console.WriteLine(sucet);
*/


/*
Console.WriteLine("Zadaj svoje meno");
string meno = Console.ReadLine();
Console.WriteLine("Zadaj svoj vek");
string vek =Console.ReadLine();
*/


/*
string meno = ZiskajMeno();
string vek = ZiskajVek();

VypisUdaje(meno, vek);

string ZiskajMeno()
{ 
    Console.WriteLine("Zadaj meno");
    string meno = Console.ReadLine();
    return meno;
}


string ZiskajVek()
{
    Console.WriteLine("Zadaj vek");
    string vek = Console.ReadLine();
    return vek;
}

void VypisUdaje(string meno, string vek)
{
    Console.WriteLine($"Ahoj {meno}, tvoj vek je {vek} rokov.");
}
*/
