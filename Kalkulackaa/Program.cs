ConsoleColor consoleColor = ConsoleColor.DarkGray;
Console.BackgroundColor = consoleColor;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
System.Console.Title = "Kalkulacka v0.1 by Patrik";







//nacitam prve cislo
//nacitam druhe cislo
//nacitam operaciu
//vypisem vysledok
Console.WriteLine("Vitaj v kalkulacke");
Console.WriteLine("Zadaj prve cislo");
double prveCislo = double.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhe cislo");
double druheCislo = double.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operaciu (+, -, *, /)");
string operacia = Console.ReadLine();
double vysledok = 0;

if (operacia == "-")
{
    vysledok = prveCislo - druheCislo;
}
else if (operacia == "+")
{
    vysledok = prveCislo + druheCislo;
}
else if (operacia == "*")
{
    vysledok = prveCislo * druheCislo;
}
else if (operacia == "/")
{
    if (druheCislo != 0)
    {
        vysledok = prveCislo / druheCislo;
    }
    else
    {
        Console.WriteLine("SynTax EROR : nulou sa neda delit");
        return; // Ukonci program, aby sa nevypisal nespravny vysledok
    }
}
else
{
    Console.WriteLine("Chyba: neplatna operacia.");
    return; // Ukonci program, aby sa nevypisal nespravny vysledok
}
Console.WriteLine($"Tvoj v7sledok je : {vysledok}");

Console.WriteLine("Pre reset programu strac ENTER");
Console.ReadLine();
System.Diagnostics.Process.Start("Kalkulackaa.exe");
Environment.Exit(0);


