// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Type a number 1-6");
string s = Console.ReadLine();
int number = int.Parse(s);

if (number >= 1 && number <= 5)
{
    Console.WriteLine("hura mas kocku");
}
else if( number == 6 )
{
    Console.WriteLine("ides este raz");
}
else
{
    Console.WriteLine("Nemas kocku :(");
} */




//nacitam prve cislo
//nacitam operaciu(+, -, /, *)
//nacitam druhe cislo
//vykonam operaciu
//vypisem vysledok


Console.WriteLine("vyber si prve cislo");
string? number1Text  = Console.ReadLine();
decimal number1 = decimal.Parse(number1Text);

Console.WriteLine("+, -, /, *");
string? znamienko  = Console.ReadLine();

Console.WriteLine("vyber si druhe cislo");
string? number2Text = Console.ReadLine();
decimal number2 = decimal.Parse(number2Text);


if (znamienko == "+")
{
    decimal sucet = number1 + number2;
    Console.WriteLine("Je to " +  sucet);
}
else if (znamienko == "-")
{
    decimal rozdiel = number1 - number2;
    Console.WriteLine("Je to " + rozdiel);
}
else if (znamienko == "*")
{
    decimal sucin = number1 * number2;
    Console.WriteLine("Je to " + sucin);
}
else if (znamienko == "/")
{
    decimal podiel = number1 / number2;
    Console.WriteLine("Je to " + podiel);
}
