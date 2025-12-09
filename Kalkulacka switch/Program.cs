// See https://aka.ms/new-console-template for more information

Console.WriteLine("vyber si prve cislo");
string? number1Text = Console.ReadLine();
decimal number1 = decimal.Parse(number1Text);

Console.WriteLine("+, -, /, *, %");
string? znamienko = Console.ReadLine();

Console.WriteLine("vyber si druhe cislo");
string? number2Text = Console.ReadLine();
decimal number2 = decimal.Parse(number2Text);



switch (znamienko)
{
    case "+":
        Console.WriteLine(number1 + number2);
        break;
    case "-":
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;
    case "/":
        if (number2 == 0)
        {
            Console.WriteLine("Chyba: nemozes delit nulou");
            break;
        }
        Console.WriteLine(number1 / number2);
        break;
    case "%":
        Console.WriteLine(number1 % number2);
        break;
}
