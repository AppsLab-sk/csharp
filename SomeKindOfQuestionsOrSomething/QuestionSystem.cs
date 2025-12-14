using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeKindOfQuestionsOrSomething
{
    internal class QuestionSystem
    {
   
        public string fileName = "C:\\Users\\MexNan\\Desktop\\Otayky.OOP\\txt.txt";
        public string DaWholeText = "";

        public string correctAnwcer = "";

        private List<string> UserInputColector = new List<string> {};
        public List<string> questionSaver = new List<string> { };
        public List<string> answerASaver = new List<string> { };

        public void QuestionPicker()
        {
            Console.WriteLine("\nPick between a,b,c");
            string? userInput = Console.ReadLine();
            if (userInput == "a")
            {
                correctAnwcer = "a";
            }
            if (userInput == "b")
            {
                correctAnwcer = "b";
            }
            if (userInput == "c")
            {
                correctAnwcer = "c";
            }
            else if (userInput != "a" && userInput != "b" && userInput != "c")
            {
                Console.WriteLine("Taking that as d...");
            }
            UserInputColector.Add(userInput);

            userInput = "";

        }


        public void FileThingIg()
        {
            int loop = 0;
            string firstText = "---------------------------------\nWelcome to this very intresing quiz!\n";

            while (loop < questionSaver.Count)
            {
                if (loop >= 1)
               {
                    DaWholeText = DaWholeText +  "\n" + questionSaver[loop] + "\n" + UserInputColector[loop] + "\n" + answerASaver[loop];
                    loop++;
                }
               else
                {
                    DaWholeText = firstText + questionSaver[loop] + "\n" + UserInputColector[loop] + "\n" + answerASaver[loop] + "\n";
                    loop++;
                }
            }
        }
    }
}
