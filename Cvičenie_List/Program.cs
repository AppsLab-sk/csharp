using System.Globalization;

namespace Cvičenie_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int[] numbers = new int[5];
            //10 15 20 25 45
            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 20;
            numbers[3] = 25;
            numbers[4] = 45;

            Console.WriteLine(numbers[2] + numbers[4]);

            List<int> listNumbers = new List<int>();

            listNumbers.Add[10];
            listNumbers.Add[15];
            listNumbers.Add[20];
            listNumbers.Add[25];
            listNumbers.Add[45];

            listNumbers[1] = 10000;

            Console.WriteLine(numbers[1] + numbers[3]);*/

            List<string> listNames = new List<string>();

            listNames.Add("Michal");
            listNames.Add("Matúš");
            listNames.Add("Peter");
            listNames.Add("Filip");
            listNames.Add("Andrej");

            Console.WriteLine(listNames[0]);
            Console.WriteLine(listNames[1]);
            Console.WriteLine(listNames[2]);
            Console.WriteLine(listNames[3]);
            Console.WriteLine(listNames[4]);
        }
}