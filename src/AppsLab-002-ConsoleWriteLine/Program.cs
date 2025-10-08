using System.ComponentModel.Design;

Console.Write("zadajte čislo 1:");
decimal cislo1 = int.Parse(Console.ReadLine());

Console.WriteLine("zadajte cislo 2");
decimal cislo2 = int.Parse(Console.ReadLine());

Console.WriteLine("načitaj operaciu");
string operacia = Console.ReadLine();

decimal vysledok = 0;

switch (operacia)
{
    case "+":
        vysledok = cislo1 + cislo2;
        break;

    case "-":
        vysledok = cislo1 - cislo2;
        break;

    case "*":
        vysledok = cislo1 - cislo2;
        break;

    case "/":
        vysledok = cislo1 - cislo2;
        break;
}
Console.WriteLine($"výsledok:{vysledok}");

