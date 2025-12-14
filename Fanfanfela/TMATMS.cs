using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fanfanfela
{
    internal class TMATMS // The Map And The Move System
    {
        private List<string> the3x1 = new List<string>() { "nothing", "nothing", "Zombie" };
        private List<string> the3x2 = new List<string>() { "nothing", "nothing", "Zombie" };
        private List<string> the3x3 = new List<string>() { "nothing", "nothing", "Zombie" };
        private List<int> ThePositionsY = new List<int>() { 1, 3, 5 };
        private List<int> ThePositionsX = new List<int>() { 7, 11, 15 };

        private int DaThingX = 0;
        private int DaThingY = 0;
        private int TheY = 0;
        private int TheX = 0;

        private bool on = true;
        private bool offSet = false;

        private string ff2 = "o";
        private string ff1 = "x";

        private string Map = "     o=====o=====o=====o\n     |     |     |     |\n     o=====o=====o=====o"; //10 == center
        private string MiddleMap = "     |     |     |     |";

        private int x = 11;
        private int y = 3;


        public void DaMapLoading(SettingTheMonster setting)
        {
            Console.WriteLine($"{Map}\n{MiddleMap}\n{Map}");

            SetPlayerPosition();

            DaMapMovment(setting);
        }
        private void DaMapMovment(SettingTheMonster setting)
        {
            while (on)
            {
                string? userInput = Console.ReadLine();
                Console.Clear();

                //Console.WriteLine($"{Map}\n{MiddleMap}\n{Map}");
                MapLoader();

                if (userInput == "w")
                {
                    CheckingEadge(userInput);
                    if (offSet)
                    {
                        offSet = false;
                        SetPlayerPosition();
                    }
                    else
                    {
                        y -= 2;
                        SetPlayerPosition();
                    }
                }
                else if (userInput == "s")
                {
                    CheckingEadge(userInput);
                    if (offSet)
                    {
                        offSet = false;
                        SetPlayerPosition();
                    }
                    else
                    {
                        y += 2;
                        SetPlayerPosition();
                    }
                }
                else if (userInput == "a")
                {
                    CheckingEadge(userInput);
                    if (offSet)
                    {
                        offSet = false;
                        SetPlayerPosition();
                    }
                    else
                    {
                        x -= 4;
                        SetPlayerPosition();
                    }
                }
                else if (userInput == "d")
                {
                    CheckingEadge(userInput);
                    if (offSet)
                    {
                        offSet = false;
                        SetPlayerPosition();
                    }
                    else
                    {
                        x += 4;
                        SetPlayerPosition();
                    }
                }
                else
                {
                    SetPlayerPosition();
                }
                SavingWhatsOnTheBlock(setting);
                Console.WriteLine(setting.DaChosenOne);

            }
        }
        private void CheckingEadge(string userInput)
        {
            if (userInput == "a" && x == 7)
            {
                x = 7;
                offSet = true;
            }
            else if (userInput == "d" && x == 15)
            {
                x = 15;
                offSet = true;
            }

            if (userInput == "w" && y == 1)
            {
                y = 1;
                offSet = true;
            }
            else if (userInput == "s" && y == 5)
            {
                y = 5;
                offSet = true;
            }

        }
        private void SetPlayerPosition()
        {
            Console.SetCursorPosition(x, y);
            {
                Console.WriteLine(ff2);
            }
            Console.WriteLine($"y{y}x{x}");
        }
        private void SavingWhatsOnTheBlock(SettingTheMonster setting)
        {
            for (int i = 0; i < ThePositionsX.Count; i++)
            {
                if (ThePositionsX[i] == x)
                {
                    DaThingX = x;
                    DaThingY = y;
                    PleaseWORK();
                    PrettyPleaseWork(setting);
                    TheX = 0;
                }
            }
            for (int j = 0; j < ThePositionsY.Count; j++)
            {
                if (ThePositionsY[j] == y)
                {
                    DaThingY += y;
                    PleaseWORK();
                    PrettyPleaseWork(setting);
                    TheY = 0;
                }
            }
        }
        private void PleaseWORK()
        {
            if (DaThingY == 1)
            {
                TheY = 1;
            }
            else if (DaThingY == 3)
            {
                TheY = 2;
            }
            else if (DaThingY == 5)
            {
                TheY = 3;

            }
            if (DaThingX == 7)
            {
                TheX = 0;
            }
            else if (DaThingX == 11)
            {
                TheX = 1;
            }
            else if (DaThingX == 15)
            {
                TheX = 2;
            }
        }
        private void PrettyPleaseWork(SettingTheMonster setting)
        {
            for (int j = 0; j < 3; j++)
            {
                if (TheY == 1)
                {
                    setting.DaChosenOne = the3x1[TheX];
                }
                else if (TheY == 2)
                {
                    setting.DaChosenOne = the3x2[TheX];
                }
                else if (TheY == 3)
                {
                    setting.DaChosenOne = the3x3[TheX];
                }
            }
        }
        private void MapLoader()
        {

        }
    }
}
