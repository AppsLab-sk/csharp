
string cislo1 = Console.ReadLine    ();
decimal prvecislo = decimal.Parse (cislo1);
string operacia = Console.ReadLine();
string cislo2 = Console.ReadLine();
decimal druhecislo = decimal.Parse (cislo2);

if (operacia == "-")
{
    decimal vysledok = prvecislo - druhecislo;
    Console.WriteLine($"vysledok je {vysledok}");
}

else if (operacia == "+")
{
    decimal vysledok = prvecislo + druhecislo;
    Console.WriteLine($"Vysledok je {vysledok}.");
}

else if (operacia == "*")
{
    decimal vysledok = prvecislo * druhecislo;
    Console.WriteLine($"Vysledok je{vysledok}.");
}
else if (operacia == "/")
{
    decimal vysledok = prvecislo / druhecislo;
    Console.WriteLine($"Vysledok je {vysledok}");
}

else if (operacia == "%")
{
    decimal vysledok = prvecislo % druhecislo;
    Console.WriteLine($"Vysledok je:{vysledok}.");
}
Console.WriteLine("dakujem ze si pouzil moju kalkulacku dovidenia");