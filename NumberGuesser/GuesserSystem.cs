using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class GuesserSystem
    {
        public string filename = @"\\fs1\Data_studenti$\2025\mahutm25\Desktop\Mause\text.txt";
        public string text = "";

        public int MaxNumber = 0;
        public int tip = 0;
        //private readonly Random _random = new();


                //for (int i = 0; i<length; i++)
                //generuje 27 cisiel
                // int randomNumber = _random.Next(27);


        private int LoadingNumber()
        {
            Console.WriteLine("Pick The Max Number");
            int userInput = int.Parse(Console.ReadLine());

            MaxNumber = userInput;

            return MaxNumber;
        }

        private int UserTip()
        {
            Console.WriteLine("What's your guess?");
            int userInput = int.Parse(Console.ReadLine());
            tip = userInput;

            return tip;
        }
        private void DaNumberGeneration()
        {
            int randomNumber = new Random().Next(0, MaxNumber + 1);


        }
        private void CheckingDaNumber()
        {


           // return something true/false;
        }




        public void DaGame()
        {
            LoadingNumber();
            UserTip();
            CheckingDaNumber();


        }

    }
}
