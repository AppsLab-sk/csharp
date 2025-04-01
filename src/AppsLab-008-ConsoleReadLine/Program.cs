//Robenie viet pomocu príkazov
/*Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);
Console.WriteLine("Ahoj, " + meno + "\n");

Console.WriteLine("Koľko máš rokov?");
Console.WriteLine("Koľko máš rokov? " + meno);
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");
Console.WriteLine("Máš " + vek + " rokov." + "\n");

Console.WriteLine("Aké je tvoje obľúbené jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine($"Hmm,  {jedlo}  znie skvele !" + "\n");
Console.WriteLine($"Volám sa {meno}, mám {vek} rokov a moje obľúbené jedlo je {jedlo}.");*/

//Výpočty

/*int PrveCislo = 60;
int DruheCislo = 6;
Console.WriteLine(PrveCislo + DruheCislo);
Console.WriteLine(PrveCislo - DruheCislo);
Console.WriteLine(PrveCislo * DruheCislo);
Console.WriteLine(PrveCislo / DruheCislo);


Console.WriteLine(PrveCislo == DruheCislo);
Console.WriteLine(PrveCislo != DruheCislo);
Console.WriteLine(PrveCislo > DruheCislo);
Console.WriteLine(PrveCislo < DruheCislo);
Console.WriteLine(PrveCislo >= DruheCislo);
Console.WriteLine(PrveCislo <= DruheCislo);*/




/*var vysledok = (40 + 10) + "55" + "10";
Console.WriteLine(vysledok);*/

// Z databazy
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Dataflow;

var menoUzivatela = "Martin";
var hesloUzivatela = "123456789";

//Zadane uzivatelom
var zadaneMeno = "Martin";
var zadaneHeslo = "123456789";

//var porovnavanieMena = menoUzivatela == zadaneMeno;
//var porovnavanieHesiel = hesloUzivatela == zadaneHeslo;
//var prijatPristup = porovnavanieMena && porovnavanieHesiel;

/*Console.WriteLine("Meno zhoda: " + porovnavanieMena);
Console.WriteLine("Heslo zhoda: " + porovnavanieHesiel);
Console.WriteLine("pustime pouzivatela " + prijatPristup);*/

// if (prijatPristup)
if (menoUzivatela == zadaneMeno && hesloUzivatela == zadaneHeslo)
{
    Console.WriteLine("Heslo sa zhoduje, vitaj! " + menoUzivatela);
}
else
{
    Console.WriteLine("Heslo sa NEZHODUJE, skus znova! ");
}






string message = "Hello, World";
message = message.Trim();
