
//Console.SetCursorPosition(10, 4);
//{ 
//    Console.WriteLine("╔");
//}
bool Highty = false;

Console.WriteLine("Lenght? Careful with the window size, tho");
int lenght = int.Parse(Console.ReadLine());

Console.WriteLine("Hight? Careful with the window size, tho");
int hight = int.Parse(Console.ReadLine());
if (hight <= 1)
{
    Highty = true;
}
int x = 0;
int y = 0;
if (Highty)
{
    Console.WriteLine("That can't work, bro");
}
else
{
    Console.WriteLine("x?");
     x = int.Parse(Console.ReadLine());

    Console.WriteLine("y?");
     y = int.Parse(Console.ReadLine());
up();
middle();
end();
}

void up()
{
    Console.SetCursorPosition(x, y);
    {
        Console.WriteLine("╔");
    }
    int i = 1;
    while (i < lenght - 1)
    {
        Console.SetCursorPosition(x + i, y);
        {
            Console.WriteLine("═");
        }
        i++;
    }

    Console.SetCursorPosition(x + i, y);
    {
        Console.WriteLine("╗");
    }
}

void middle()
{
for (int i = 1; i <= hight - 2; i++)
    {
        Console.SetCursorPosition(x, y + i);
        {
            Console.WriteLine("║");
        }
        Console.SetCursorPosition(x + lenght - 1, y + i);
        {
            Console.WriteLine("║");
        }
    }
}

void end()
{
    int weirdY = y + hight - 1;
    Console.SetCursorPosition(x, weirdY);
    {
        Console.WriteLine("╚");
    }
    int i = 1;
    while (i < lenght - 1)
    {
        Console.SetCursorPosition(x + i, weirdY);
        {
            Console.WriteLine("═");
        }
        i++;
    }

    Console.SetCursorPosition(x + i, weirdY);
    {
        Console.WriteLine("╝");
    }
}