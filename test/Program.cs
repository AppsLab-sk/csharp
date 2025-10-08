/*Console.WriteLine("zadaj svoje meno");
string name = Console.ReadLine();
Console.WriteLine("zadaj svoj vek");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"ahoj tvoje meno je {name} a mas {age} rokov");
*/
Console.WriteLine("zadaj cislo od 1 do 7");
int dayOfweek = int.Parse(Console.ReadLine());
switch (dayOfweek)
{
    case 1:
        Console.WriteLine("Pondelok");
        break;
    case 2:
        Console.WriteLine("Utorok");
        break;
    case 3:
        Console.WriteLine("Streda");
        break;
    case 4:
        Console.WriteLine("Stvrtok");
        break;
    case 5:
        Console.WriteLine("Piatok");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Nedela");
        break;
}
if (dayOfweek <1 || dayOfweek > 7)
{
    Console.WriteLine("Zadal si nespravne cislo");
}








