Console.WriteLine("Zadaj Cislo: ");
int cislo1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhe cislo: ");
int cislo2 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operaciu(+,-,*,/)");
var Operacia = Console.ReadLine();
int vysledok = 0;
if (Operacia == "+")
{
    vysledok = cislo1 + cislo2;
}
else if (Operacia == "-")
{
     vysledok = cislo1 + cislo2;
}
else if (Operacia == "*")
{
     vysledok = cislo1 * cislo2;
}
else if (Operacia == "/")
{
     vysledok = cislo1 / cislo2;
}
Console.WriteLine($"vysledok je {vysledok}");





