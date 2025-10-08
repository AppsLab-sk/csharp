Console.WriteLine("Zadaj prve cislo: ");
decimal cislo1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhe cislo:");
decimal cislo2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operaciu (+, -, *, /, %):");
string operacia = Console.ReadLine();
if (operacia == "/" && cislo2 == 0)
{
    Console.WriteLine("Chyba: Delenie nulou nie je povolene.");
    return;
}
if (operacia != "+" && operacia != "-" && operacia != "*" && operacia != "/" && operacia != "%")
{
    Console.WriteLine("Chyba: Neplatna operacia.");
    return;
}

decimal vysedlok = operacia switch
{
    "+" => (cislo1 + cislo2),
    "-" => (cislo1 - cislo2),
    "*" => (cislo1 * cislo2),
    "/" => (cislo1 / cislo2),
    "%" => (cislo1 % cislo2),
};
Console.WriteLine($"Vysledok je: {vysedlok}");
Console.WriteLine("Stlac ENTER pre spustenie kalkulacky");
Console.ReadLine();
System.Diagnostics.Process.Start("kalkulacka.exe");
System.Environment.Exit(0);




// nacitam prve cslo
//nacitam operaciu
//nacitam druhe cislo
//vypisem vypisem operaciu
//vypisem vysledok

