using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace cvicenie_8._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "ADD")
                {
                    string numberText = Console.ReadLine();
                    int number = int.Parse(numberText);
                    numbers.Add(number);
                }

                if (command == "DEL")
                {
                    string numberText = Console.ReadLine();
                    int number = int.Parse(numberText);
                    numbers.Remove(number);

                }

                if (command == "DELI")
                {
                    string numberText = Console.ReadLine();
                    int number = int.Parse(numberText);

                    int MaxIndex = numbers.Count - 1;
                    if (number <= MaxIndex)
                    {
                        numbers.RemoveAt(number);
                    }
                    else
                    {
                        Console.WriteLine("zly index");
                    }

                }

                if (command == "HAS")
                {
                    string numberText = Console.ReadLine();
                    int number = int.Parse(numberText);
                    bool Contains = numbers.Contains(number);
                    if (Contains)
                    {
                        Console.WriteLine("ANO");
                    }

                    else
                    {
                        Console.WriteLine("NIE");
                    }

                }

                if (command == "LIST")
                {
                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number);
                    }
                }
                if (command == "COUNT")

                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }

                else if (command == "END")
                {
                    break;
                }

            }


            string command = Console.ReadLine();
            switch (command)
            {
                case "ADD":
                    {
                        string numberText = Console.ReadLine();
                        int number = int.Parse(numberText);
                        numbers.Add(number);
                        break;
                    }
                case "DEL":
                    {
                        string numberText = Console.ReadLine();
                        int number = int.Parse(numberText);
                        numbers.Remove(number);
                        break;
                    }
                case "DELI":
                    {
                        string numberText = Console.ReadLine();
                        int number = int.Parse(numberText);

                        int MaxIndex = numbers.Count - 1;
                        if (number <= MaxIndex)
                        {
                            numbers.RemoveAt(number);
                        }
                        else
                        {
                            Console.WriteLine("zly index");
                        }

                        break;
                    }
                case "HAS":
                    {
                        string numberText = Console.ReadLine();
                        int number = int.Parse(numberText);
                        bool Contains = numbers.Contains(number);
                        if (Contains)
                        {
                            Console.WriteLine("ANO");
                        }

                        else
                        {
                            Console.WriteLine("NIE");
                        }

                        break;
                    }
                case "LIST":
                    {
                        foreach (int number in numbers)
                        {
                            Console.WriteLine(number);

                        }
                        break;
                    }
                case "COUNT":
                    {
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                    }
            }






        }

    }
}






    


