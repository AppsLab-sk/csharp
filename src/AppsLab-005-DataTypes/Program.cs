

//int mojeCislo = 1234;
//string mojeSlovo = "Ahoj , Svet!";
//bool mojaBoolHodnota = true;
//DateTime dnesnyDatum = DateTime.Now;
//float myFloat = 5.75f;
//int sucet = mojeCislo + 5;
//var myVar = "Toto je var string";
//Console.WriteLine(mojeCislo.ToString("777777"));
//Console.WriteLine(mojeSlovo);
//Console.WriteLine($"Súčet je:{sucet}");
//Console.WriteLine($"Dnes je: {dnesnyDatum.ToString("yyyy-MM-dd")}");
//Console.WriteLine($"Bool hodnota je: {mojaBoolHodnota}");
//const int MaxStudents = 15;
//Console.WriteLine("Maximálny počet študentov v triede je:" +  MaxStudents);




Console.Write("zadajte cislo 1: *");
int cislo1 = int.Parse(Console.ReadLine());

Console.Write("zadajte cislo2 : *");
decimal cislo2 = int.Parse(Console.ReadLine());

Console.Write("zadajte operaciu:");
string operacia = Console.ReadLine();
decimal vysledok = 0;
switch(operacia)
{

case "+":
    vysledok = cislo1 + cislo2;
    break;
    case "-":
    vysledok = cislo1 - cislo2;
    break;
case "*":
    vysledok = cislo1 * cislo2;
    break;
case "/":
    if (cislo2 != 0)
    {
        vysledok = cislo1 / cislo2;

    }
    else
    {
        Console.WriteLine("chyba: delenie nulou nie");
    }
    break;
default:
    Console.WriteLine("neznama operacia." );
        break;
}

