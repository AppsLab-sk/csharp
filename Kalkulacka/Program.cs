// See https://aka.ms/new-console-template for more information


Console.WriteLine("vyber si prve cislo");
string? number1Text = Console.ReadLine();
decimal number1 = decimal.Parse(number1Text);

Console.WriteLine("+, -, /, *, %");
string? znamienko = Console.ReadLine();

Console.WriteLine("vyber si druhe cislo");
string? number2Text = Console.ReadLine();
decimal number2 = decimal.Parse(number2Text);


if (znamienko == "+")
{
    decimal sucet = number1 + number2;
    Console.WriteLine("Je to " + sucet);
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
else if (znamienko == "%")
{
    decimal idk = number1 % number2;
    Console.WriteLine("Je to " + idk);
}
