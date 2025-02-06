/*Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
//Console.WriteLine("Ahoj, " + meno + "\n");

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
//Console.WriteLine("Máš " + vek + " rokov." + "\n");

/*Console.WriteLine("kolko penazi mas na ucte????");
string money = Console.ReadLine() ?? "0";
float peniaze = float.Parse(money);
Console.WriteLine("Máš " + money + " $ GG" + "\n");

Console.WriteLine("ake je tvoje oblubene jedlo?");
string? jedlo = Console.ReadLine();
//Console.WriteLine("Hmmmmmmmmm " + jedlo + " znie dobre" );
Console.WriteLine($"Volas sa {meno}, mas {vek} rokov a tvoje oblubene jedlo je {jedlo} ." + "\n"); */


/*int prvecislo = 20;
int druhecislo = 5;
Console.WriteLine(prvecislo + druhecislo);
Console.WriteLine(prvecislo - druhecislo);
Console.WriteLine(prvecislo /  druhecislo);
Console.WriteLine(prvecislo * druhecislo);

Console.WriteLine(prvecislo == druhecislo);
Console.WriteLine(prvecislo != druhecislo);
Console.WriteLine(prvecislo <  druhecislo);
Console.WriteLine(prvecislo > druhecislo);
Console.WriteLine(prvecislo >= druhecislo);
Console.WriteLine(prvecislo <= druhecislo);*/




//databazy
var menopouzivatela = "Jakub";
var heslopouzivatela = 125;

//zadane uzivatelom
var zadanemeno = "Jakub";
var zadaneheslo = 125;

//var porovnanieMena = menopouzivatela == zadanemeno;
//var porovnavanieHesla = heslopouzivatela == zadaneheslo;
//var prijatPristup = porovnanieMena && porovnavanieHesla;

/*Console.WriteLine("Meno zhoda: " + porovnanieMena);
Console.WriteLine("Heslo zhoda: " + porovnavanieHesla);
Console.WriteLine("pustime pouzivatela: " + prijatPristup);*/

//if (prijatPristup)
if (menopouzivatela == zadanemeno && heslopouzivatela == zadaneheslo)
{
    Console.WriteLine("heslo sa zhoduje, vitaj! " + menopouzivatela);
    //
    //
}
else
{
    Console.WriteLine("Heslo sa NEZHODUJE, mas este 3 pokusy inak budes elminovany :)");
}
