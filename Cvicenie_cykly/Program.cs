using System.Data;
using System.Threading.Channels;

namespace Cvicenie_cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");*/
            /*for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            /*
                        while (true)
                        {
                            string input = Console.ReadLine();

                            if (input == "okej")
                            {
                                Console.WriteLine("ahoj");
                            }
                            else if (input == "exit")
                            {
                                break;
                            }





                            while (true)
                            {
                                string input = Console.ReadLine();

                                if (input == "pozdrav")
                                {
                                    Console.WriteLine("ahoj");
                                }
                                else if (input == "exit")
                                {
                                    break;
                                }


                            }


                        }*/

            /*
                        while (true)
                        {
                            while (true)
                            {
                                string input = Console.ReadLine();

                                if (input == "exit")
                                {
                                    break;
                                }

                                Console.WriteLine("michal");




                                string inputdva = Console.ReadLine();



                                if (inputdva == "exit2")
                                {
                                    break;
                                }

                                Console.WriteLine("igor");



                            }



                        }

                        */

            Console.Write("znak ");
            string znak = Console.ReadLine();

            Console.Write("aky velky  ");
            int pocetRiadkov = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pocetRiadkov; i++)
            {
                string row = "";
                for (int j = 1; j <= i; j++)
                {
                    row += znak;
                }
                Console.WriteLine(row);











            }

        }
    }
}
