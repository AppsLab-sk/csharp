// See https://aka.ms/new-console-template for more information

List<int> numbers = new List<int>();
Console.WriteLine("Type numbers");
string vstup =Console.ReadLine();

while (vstup != "+")
{
    numbers.Add(int.Parse(vstup));
    vstup = Console.ReadLine();
}
Console.WriteLine("Vysledok scitania:");
int sucet = 0;
foreach (int i in numbers)
    {
        sucet += i;
    }
Console.WriteLine(sucet);


