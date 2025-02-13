using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Text");
            string text = Console.ReadLine();

            int lenght = DlzkaTextu(text);

            Console.WriteLine("Text lenght:" + lenght);
        }

        public static int DlzkaTextu(string text)
        {
    
            return text.Length; 
    }   }
}




  
