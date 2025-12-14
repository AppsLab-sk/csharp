
using System;
using System.Xml;


int xx = 5;
int yy = 25;

bool offSet = false;

string upperBox = "■-------■"; // 1 + 7 + 1, 4 = center

string middleBox = "|"; // meowino fofinino fiaovino... don't ask, bro

bool moving = true;


string movement = "o";

int daMapPositionX = 0;
int daMapPositionY = 0;



int x = 14;
int y = 7;

string userInput = "";

//x{xU + 4 - daMapPositionX},y{yU + i - daMapPositionY}" just in case, yk?

DaMapThing();


void DaMapThing()
{
    MapLoader();
    SpawningDaPlayer();

    while (moving)
    { 
        userInput = Console.ReadLine();
        Console.Clear();
        MapLoader();

        if (userInput == "w")
        {
            CheckingEadges();
            if (offSet)
            {
                offSet = false;
                SpawningDaPlayer();
            }
            else
            {
                y -= 5;
                SpawningDaPlayer();
            }
        }
        else if (userInput == "s")
        {
            CheckingEadges();
            if (offSet)
            {
                offSet = false;
                SpawningDaPlayer();
            }
            else
            {
                y += 5;
                SpawningDaPlayer();
            }
        }
        else if (userInput == "a")
        {
            CheckingEadges();
            if (offSet)
            {
                offSet = false;
                SpawningDaPlayer();
            }
            else
            {
                x -= 10;
                SpawningDaPlayer();
            }
        }
        else if (userInput == "d")
        {
            CheckingEadges();
            if (offSet)
            {
                offSet = false;
                SpawningDaPlayer();
            }
            else
            {
                x += 10;
                SpawningDaPlayer();
            }
        }
        else if (userInput == "?")
        {
            Settings();
        }
        else
        {
            SpawningDaPlayer();
        }

        Console.SetCursorPosition(xx, yy);
        {
            Console.WriteLine($"x{x},y{y}, ? = settings");
        }
    }
    Console.Clear();
}
 void MapLoader()
 {
    for (int jj = 0; jj < 3; jj++)
    {
        int yY = 5 * jj;
        int j = 0;
        for (j = 0; j < 3; j++)
        {
            int xX = 10 * j;

            int xU = daMapPositionX + xX;
            int yU = daMapPositionY + yY;
            int i = 1;

            Console.SetCursorPosition(xU, yU);
            {
                Console.WriteLine(upperBox);
            }

            while (i < 3 + 1)
            {
                Console.SetCursorPosition(xU, yU + i);
                {
                    Console.WriteLine(middleBox);
                }
                if (i == 2)
                {
                    Console.SetCursorPosition(xU + 4, yU + i);
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("x");
                        Console.ResetColor();
                    }
                }

                Console.SetCursorPosition(xU + 8, yU + i);
                {
                    Console.WriteLine(middleBox);
                }
                i++;
            }

            Console.SetCursorPosition(xU, yU + i);
            {
                Console.WriteLine(upperBox);
            }
        }
    }
 }
    void CheckingEadges()
    {
    if (userInput == "a" && x - daMapPositionX == 4)
    {
        x = 4 + daMapPositionX;
        offSet = true;
    }
    else if (userInput == "d" && x - daMapPositionX == 24)
    {
        x = 24;
        offSet = true;
    }

    if (userInput == "w" && y - daMapPositionY == 2)
    {
        y = 2 + daMapPositionY;
        offSet = true;
    }
    else if (userInput == "s" && y - daMapPositionY == 12)
    {
        y = 12;
        offSet = true;
    }

}
    void CheckingBeforeMoving()
    {
        CheckingEadges();
    }
    void SpawningDaPlayer()
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(x - 1, y);
        {
            Console.WriteLine("|");
        }

        Console.SetCursorPosition(x, y);
        {
        
        Console.WriteLine(movement);
        }
        Console.SetCursorPosition(x + 1, y);
        {
            Console.WriteLine("|");
        }
    Console.ResetColor();
}
void SettingUpTheMapPlacement()
{
    Console.SetCursorPosition(20, 5);
    {
        Console.WriteLine("da Map Position? X");
    }
    daMapPositionX = int.Parse(Console.ReadLine()); // 90 - max
    if (daMapPositionX < 90)
    {
        daMapPositionX = 90;
    }
    Console.SetCursorPosition(20, 5);
    {
        Console.WriteLine("da Map Position? Y");
    }
    daMapPositionY = int.Parse(Console.ReadLine()); //14 - max
    if (daMapPositionY < 14)
    {
        daMapPositionX = 14;
    }

    x += daMapPositionX;
    y += daMapPositionY;

    Console.Clear();
}
void Settings()
{
    bool settingLoop = true;
    while (settingLoop)
    {
        Console.Clear();
        Console.SetCursorPosition(20, 5);
        {
            Console.WriteLine("Change the Map location on the screen(change)");
        }
        Console.SetCursorPosition(20, 6);
        {
            Console.WriteLine("End the game(end)");
        }

        string? userSettingsInput = Console.ReadLine();
        Console.Clear();

        if (userSettingsInput == "change")
        {
            SettingUpTheMapPlacement();
            settingLoop = false;

        }
        else if (userSettingsInput == "end")
        {
            moving = false;
            settingLoop = false;
        }
        else
        {
            Console.SetCursorPosition(20, 6);
            {
                Console.WriteLine("What?");
            }
        }
        Console.Clear();
        MapLoader();
        SpawningDaPlayer();
    }
}

