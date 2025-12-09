using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vykreslenie_4_uholnika
{
    internal class TheSystem
    {
        private int x = 0;
        private int y = 0;
        private int hight = 0;
        private int scale = 0;
        public void Run()
        {
            UserInputPart();
            UpperPart();
            MiddlePart();
            LowerPart();
        }

        private void UpperPart()
        {
            Console.SetCursorPosition(x, y);
            {
                Console.WriteLine("╔");
            }
            int i = 1;
            int j = 0;
            while (i < scale - 1)
            {
                Console.SetCursorPosition(x + i, y);
                {
                    Console.WriteLine("═");
                }
                i++;
                j++;
            }
            Console.SetCursorPosition(x + 1 + j, y);
            {
                Console.WriteLine("╗");
            }
        }
        private void MiddlePart()
        {
            hight += 1;
            int i = 1;
            while (i < hight - 2)
            {
                Console.SetCursorPosition(x, y + i);
                {
                    Console.WriteLine("║");
                }
                Console.SetCursorPosition(x + scale - 1, y + i);
                {
                    Console.WriteLine("║");
                }
                i++;
            }
        }
        private void LowerPart()
        {
            Console.SetCursorPosition(x - 1, y + hight - 2);
            {
                Console.WriteLine(" ╚");
            }
            int i = 1;
            int j = 0;
            while (i < scale - 1)
            {
                Console.SetCursorPosition(x + i, y + hight - 2);
                {
                    Console.WriteLine("═");
                }
                i++;
                j++;
            }
            Console.SetCursorPosition(x + 1 + j, y + hight - 2);
            {
                Console.WriteLine("╝");
            }
        }
        private void UserInputPart()
        {
            Console.WriteLine("The x?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("The y?");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("The Scale?");
            scale = int.Parse(Console.ReadLine());
            Console.WriteLine("The Hight");
            hight = int.Parse(Console.ReadLine());
            if (scale == 1)
            {
                Console.WriteLine("scale can't be 1");
                ResetStuff();
                UserInputPart();
            }
            if (hight == 1)
            {
                Console.WriteLine("hight can't be 1");
                ResetStuff();
                UserInputPart();
            }
        }
        private void ResetStuff()
        {
            x = 0;
            y = 0;
            scale = 0;
            hight = 0;
        }
    }
}
