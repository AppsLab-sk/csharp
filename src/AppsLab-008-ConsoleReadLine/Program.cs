/*//Ako sa volas
Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();

//Kolko mas rokov
Console.WriteLine("\nKoľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);

//Ake je tvoje oblubene jedlo
Console.WriteLine("\nAké je tvoje obľúbené jedlo?");
string? jedlo = Console.ReadLine();

//Konecny verdikt
Console.WriteLine("\nAhoj, tvoje meno je " + meno + ", máš " + vek + " rokov a tvoje obľúbené jedlo je " + jedlo + ".");*/


//------------------------------------------------------------------------------------------------------------------------------


//Operacie
/*int prveCislo = 55;
int druheCislo = 80;

Console.WriteLine(prveCislo + druheCislo);
Console.WriteLine(prveCislo - druheCislo);
Console.WriteLine(prveCislo * druheCislo);
Console.WriteLine(prveCislo / druheCislo);

Console.WriteLine();

Console.WriteLine(10 == 50);
Console.WriteLine(50 == 50);

Console.WriteLine();

Console.WriteLine(10 != 50);
Console.WriteLine(50 != 50);

Console.WriteLine();

Console.WriteLine(10 < 50);
Console.WriteLine(50 > 50);

Console.WriteLine();

Console.WriteLine(10 <= 50);
Console.WriteLine(50 >= 50);

Console.WriteLine();

var vysledok = 50 + 10;
Console.WriteLine(vysledok); 

 
 //------------------------------------------------------------------------------------------------------------------------------


 */


//Z databazy
var menoUzivatela = "Jakub";
var hesloPouzivatela = "123456789";

//zadavanie mena
Console.WriteLine("Zadajte svoje meno: ");
var zadaneMeno = Console.ReadLine();

//zadavanie hesla
Console.WriteLine("Zadajte svoje heslo: ");
var zadaneHeslo = Console.ReadLine();


//odpoved
if (menoUzivatela == zadaneMeno && hesloPouzivatela == zadaneHeslo)
{
    Console.WriteLine("Heslo sa zhoduje, vitaj " + menoUzivatela);
}
else
{
    Console.WriteLine("Vase heslo alebo meno sa nezhoduje!");
}