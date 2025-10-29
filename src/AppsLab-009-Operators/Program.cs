// privitanie
Console.WriteLine("Vitaj v kalkulacke!");
// zadame cislo a operciu
Console.WriteLine("Zadaj prve cislo:");
int cislo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Zadaj druhe cislo:");
int cislo2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Zadaj operaciu (+, -, *, /, ):");
string operacia = Console.ReadLine()!;
int vysledok = operacia switch
// zvolim operaciu a spocittamm
{
    "+" => cislo + cislo2,
    "-" => cislo - cislo2,
    "*" => cislo * cislo2,
    "/" => cislo / cislo2,
};
// vypisem vysledok
Console.WriteLine($"Vysledok je: {vysledok}");




