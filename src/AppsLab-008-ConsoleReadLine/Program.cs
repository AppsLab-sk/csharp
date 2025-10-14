//// privitanie
//using Microsoft.Win32.SafeHandles;

//string Privitanie = "Ahoj, vitaj v kalkulacke;";
//Console.WriteLine(Privitanie);

//// nacitam cislo
//string? prveCislo = Console.ReadLine();


//// nacitam 2. cislo
//string? druheCislo = Console.ReadLine();
//// spravim sucet 
//int sucet = int.Parse(prveCislo) + int.Parse(druheCislo);



//// vypisem sucet
//Console.WriteLine($"Sucet cisel  je {sucet}");
////






//int a = 5;
//int b = 3;
//int scitanie = a + b; // 8
//int odcitanie = a - b; // 2
//decimal deleno = a /(decimal) b; // 1
//int modulo = a % b; // 2

//int nasobenie = a * b; // 15

//int zostatok = a % b; // 2

//bool suRovne = a == b; // false
//bool nieSurovne = a != b; // true
//bool vacsie = a > b; // true
//bool mensie = a < b; // false
//bool vacsieRovne = a >= b; // true
//bool mensieRovne = a <= b; // false









// nacitam 1. cislo (konverzia na cislo)
using System.ComponentModel.Design;

Console.WriteLine("Zadaj prve cislo: ");
int prveCislo = int.Parse(Console.ReadLine()!);



// nacitam operaciu ( nacitam ako string)
string operacia = ("+, -, *, /, %");
Console.WriteLine("Zadaj operaciu (+, -, *, /, %): ");
operacia = Console.ReadLine();

//nacitam 2. cislo (konverzia na cislo)
Console.WriteLine("Zadaj druhe cislo: ");
int druheCislo = int.Parse(Console.ReadLine()!);


// vykonam operaciu
int vysledok = operacia switch
{
    "+" => prveCislo + druheCislo,
    "-" => prveCislo - druheCislo,
    "*" => prveCislo * druheCislo,
    "/" => prveCislo / druheCislo,
    "%" => prveCislo % druheCislo,
    _ => throw new InvalidOperationException("Neplatna operacia")
};
// vypisem vysledok
Console.WriteLine($"Vysledok je: {vysledok}");


































