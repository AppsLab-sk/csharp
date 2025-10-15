Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();


Console.WriteLine("Vitaj v kalkulacke");
Console.WriteLine("Zadaj prve cislo:");
string?  cislo1 = Console.ReadLine() ?? "0";
Console.WriteLine("Zadaj druhe cislo:");
string?  cislo2 = Console.ReadLine() ?? "0";
int sucet =  int.Parse(cislo1) + int.Parse(cislo2);
Console.WriteLine($"Suma {cislo1} a {cislo2} je {sucet}"); 








