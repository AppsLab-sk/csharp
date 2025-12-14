using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("chose,buddy");
int stage = int.Parse(Console.ReadLine());
if (stage == 1)
{

        Console.WriteLine("Switch calculator");
    int i = 0;

    while (i < 1)
    {
        Console.WriteLine("----------");

        Console.WriteLine("Calculation time!");


        Console.WriteLine("Select the first number");
        decimal number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Select: +, -, *, /, % ?");
        string? sucetselection = Console.ReadLine();

        Console.WriteLine("Now, select the second number");
        decimal number2 = decimal.Parse(Console.ReadLine());

        decimal vysledok = 0;

        switch (sucetselection)
        {
            case "+":
                vysledok = number1 + number2;
                break;

            case "-":
                vysledok = number1 - number2;
                break;

            case "*":
                vysledok = number1 * number2;
                break;

            case "/":
                if (number2 == 0)
                {
                    Console.WriteLine("error");
                    break;
                }
                vysledok = number1 / number2;
                break;

            case "%":
                vysledok = number1 % number2;
                break;

            default:
                Console.WriteLine("Operacion is unknowed");
                break;
        }
        Console.WriteLine($"It's " + vysledok);

        Console.WriteLine("do you wanna continue?");
        string end = Console.ReadLine();
        if (end == "n")
            i = 1;
    }
}
else if (stage == 2)
{
    Console.WriteLine("n2t");
    Console.WriteLine("----------");

    Console.WriteLine("Number to text time!");

    decimal number = int.Parse(Console.ReadLine());

    string numberDescription = number switch
    {
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        _ => "NEIN!!!"

    };
    Console.WriteLine(numberDescription);
}
else if (stage == 3)
{
    Console.WriteLine("Original If Calculator");
    Console.WriteLine("----------");

    Console.WriteLine("Calculation time!");

    Console.WriteLine("Select the first number");
    string? number1Text = Console.ReadLine();
    decimal number1 = decimal.Parse(number1Text);

    Console.WriteLine("Select: +, -, *, / ?");
    string? sucetselection = Console.ReadLine();

    Console.WriteLine("Now, select the second number");
    string? number2Text = Console.ReadLine();
    decimal number2 = decimal.Parse(number2Text);
    //skus swich

    if (sucetselection == "+")

    {
        decimal sucet = number1 + number2;

        Console.WriteLine($"It's " + sucet);
    }
    else if (sucetselection == "-")

    {
        decimal sucet = number1 - number2;

        Console.WriteLine($"It's " + sucet);
    }
    else if (sucetselection == "*")

    {
        decimal sucet = number1 * number2;

        Console.WriteLine($"It's " + sucet);
    }
    else if (sucetselection == "/")

    {
        decimal sucet = number1 / (decimal)number2;

        Console.WriteLine($"It's " + sucet);
    }
}
else if (stage == 4)
{
    Console.WriteLine("short calculator");
    Console.WriteLine("----------");

    Console.WriteLine("Calculation time!");


    Console.WriteLine("Select the first number");
    decimal number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Select: +, -, *, /, % ?");
    string? sucitselection = Console.ReadLine();

    Console.WriteLine("Now, select the second number");
    decimal number2 = decimal.Parse(Console.ReadLine());

    decimal vysledok = 0;

    string CalculatorDescription = sucitselection switch
    {

    };





}
else
    Console.WriteLine("not included");





