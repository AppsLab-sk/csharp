/*Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");

Console.WriteLine("Aké je tvoje oblubené jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("Mňam," + jedlo);

Console.WriteLine("Volam sa " + meno + " mám " + vek + " a moje oblubene jedlo je " + jedlo);

int prveCislo = 45562;
int druheCislo = 0;

Console.WriteLine(prveCislo + druheCislo);
Console.WriteLine(prveCislo - druheCislo);
Console.WriteLine(prveCislo / druheCislo);
Console.WriteLine(prveCislo * druheCislo);

Console.WriteLine(10 == 50);
Console.WriteLine(10 != 50);
Console.WriteLine(10 > 50);
Console.WriteLine(10 < 50);
Console.WriteLine(10 >= 50);
Console.WriteLine(10 <= 50);


// z uživatela
var zadaneMeno = "Michal";
var zadaneHeslo = "123456789";

//zadanie uzivatelom 
var zadanieMeno = "Michal";
var zadanieHeslo = "123456789";

string menoUzivatela = null;
string hesloUzivatela = null;

var porovnavanieMena = menoUzivatela == zadanieMeno;
var porovnavanieHesla = hesloUzivatela == zadanieHeslo;

var prijatPristup = porovnavanieMena && porovnavanieHesla;

if (prijatPristup)
{
      string menoUzivatela = null;

    Console.WriteLine("Heslo sa zhoduje, vitaj" + menoUzivatela);
}
else
{
    Console.WriteLine("Heslo sa neZhoduje"); 
}

string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName; 
Console.WriteLine(fullName); */


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine sum( 3, 4 );
    }
}