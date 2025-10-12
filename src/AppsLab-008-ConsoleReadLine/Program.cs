Console.WriteLine("Vitaj v kalkulacke");
Console.WriteLine("Zadaj prve cislo: ");
decimal cislo1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhe cislo: ");
decimal cislo2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operaciu (+,-,*,/,%):");
string operacia = Console.ReadLine();

int vysledok = operacia switch
{
    "+" => (int)(cislo1 + cislo2),
    "-" => (int)(cislo1 - cislo2),
    "*" => (int)(cislo1 * cislo2),
    "/" => (int)(cislo1 / cislo2),
    "%" => (int)(cislo1 % cislo2),
    _ => throw new Exception("Neznamy operator")
};