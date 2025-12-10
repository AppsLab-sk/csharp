using System.Timers;

bool on = true;
bool offSet = false;
string ff2 = "o";
string ff1 = "x";

string Map = "     o===o===o===o\n     |   |   |   |\n     o===o===o===o";
string MiddleMap = "     |   |   |   |";
int x = 11;
int y = 3;

Console.WriteLine($"{Map}\n{MiddleMap}\n{Map}");

Console.SetCursorPosition(x, y);
{
    Console.WriteLine(ff2);
}
while (on)
{
    string? userInput = Console.ReadLine();
    Console.Clear();

    Console.WriteLine($"{Map}\n{MiddleMap}\n{Map}");

    if (userInput == "w")
    {
        y -= 2;
        Console.SetCursorPosition(x, y);
        {
            Console.WriteLine(ff2);
        }
    }
    else if (userInput == "s")
    {
        y += 2;
        Console.SetCursorPosition(x, y);
        {
            Console.WriteLine(ff2);
        }
    }
    else if (userInput == "a")
    {
        CheckingEadge(userInput);
        if (offSet)
        {
            offSet = false;
            Console.SetCursorPosition(x, y);
            {
                Console.WriteLine(ff2);
            }
        }
        else
        {
            x -= 4;
            Console.SetCursorPosition(x, y);
            {
                Console.WriteLine(ff2);
            }
        }
    }
    else if (userInput == "d")
    {
        CheckingEadge(userInput);
        if (offSet)
        {
            offSet = false;
            Console.SetCursorPosition(x, y);
            {
                Console.WriteLine(ff2);
            }
        }
        else
        {
            x += 4;
            Console.SetCursorPosition(x, y);
            {
                Console.WriteLine(ff2);
            }
        }
    }
}

void CheckingEadge(string userInput)
{
    if (userInput == "a" && x == 7)
    {
        x = 8;
        offSet = true;
    }
    else if (userInput == "d" && x == 20)
    {
        x = 16;
        offSet = true;
    }
    
}

/*
Console.WriteLine(ff);

Console.SetCursorPosition(2, 1);
{
    Console.WriteLine(ff2);
}
string? next = Console.ReadLine();
Console.Clear();

Console.WriteLine(ff);

Console.SetCursorPosition(5, 1);
{
    Console.WriteLine(ff2);
}
next = Console.ReadLine();
Console.Clear();

Console.WriteLine(ff);

Console.SetCursorPosition(7, 3);
{
    Console.WriteLine(ff2);
}
*/