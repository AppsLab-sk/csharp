/*Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno + "\n");
Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
Console.WriteLine("Aké je tvoje obľúbené jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("Hmm, " + jedlo + " znie skvele");
Console.WriteLine("Volám sa "  + meno + " Mám " + vstup + " Moje obľúbené jedlo je " + jedlo);*/

/*int prvecislo = 50;
int druhecislo = 60;
Console.WriteLine(prvecislo + druhecislo);
int tretiecislo = 505484789;
int stvrtecislo = 458962558;
Console.WriteLine(tretiecislo - stvrtecislo);
int piatecislo = 96;
int siestecislo = 7;
Console.WriteLine(piatecislo / siestecislo);

Console.WriteLine(10 == 50);
Console.WriteLine(50 == 50);
Console.WriteLine(50 > 60);
Console.WriteLine(60 < 70);*/

var menoUzivatela = "Martin";
var heslopouzivatela = "123456789";
var zadanemeno = "Martin";
var zadaneheslo = "123456789";
var porovnaniemena = menoUzivatela == zadanemeno;
var porovnaniehesiel = heslopouzivatela == zadaneheslo;
var prijatPristup = porovnaniemena || porovnaniehesiel;

Console.WriteLine("Meno zhoda: " + porovnaniemena);
Console.WriteLine("Heslo zhoda: " + porovnaniehesiel);
Console.WriteLine("pustime uzivatela " + prijatPristup);
if (porovnaniemena && porovnaniehesiel)
{
    Console.WriteLine("Heslo sa zhoduje, vitaj " + menoUzivatela);
}
else
{
    Console.WriteLine("Heslo sa NEZHODUJE");
}






