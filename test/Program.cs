/*string i = "*";
while (i.Length < 6)
{
    Console.WriteLine(i);
    i += "*";
}
string j = "*****";
while (j.Length > 0)
{
    Console.WriteLine(j);
    j = j.Substring(0, j.Length -1);
}

string s = "abcd";
    s = s.Substring(1,3);
Console.WriteLine(s);

*
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

int[] cisla = new int[10] {1, 2, 3, 5, 6, 4, 7, 8, 9, 10};
int i = 0;
int sucet = 0;
for (i = 0; i < cisla.Length; i++)
{
    sucet += cisla[i];
}
Console.WriteLine($"Sucet je {sucet}");
*

string[] names = new string[4] { "dnes", "sa", "mam", "dobre", };
foreach (string name in names)
{
  Console.Write($" {name} ");
}
*


using System.Globalization;

List<int> numbers = new List<int> { 1, 2, 3 };

foreach (var number in numbers)
    numbers.Add(45);

{     
    Console.WriteLine(numbers);
}
*

List <int> numbers = new List<int>();
Console.WriteLine("zadaj cislo");
string vstup = Console.ReadLine();
while (vstup != "+")
{
    numbers.Add(int.Parse(vstup));
    Console.WriteLine("zadaj cislo");
    vstup = Console.ReadLine();
}
Console.WriteLine("vysledok scitania:");
int sucet = 0;
foreach (int i in numbers)
{
    sucet += i;

}
Console.WriteLine(sucet);
*/
string meno = ziskajMeno();
int vek = ziskajVek();
VypisUdaje(meno, vek);
        
string ziskajMeno()
{
    Console.WriteLine("zadaj svoje meno");
    string meno = Console.ReadLine();
    return meno;
}

int ziskajVek()
{
    Console.WriteLine("zadaj svoj vek");
    int vek = int.Parse(Console.ReadLine());
    return vek;
}

void VypisUdaje (string meno, int vek)
{
    Console.WriteLine($"Ahoj {meno}, mas {vek} rokov.");
}