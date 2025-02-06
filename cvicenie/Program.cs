using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadaj text");
            
            string text = Console.ReadLine();
            
            int length = Dlzkatextu(text);
           
            Console.WriteLine("Dlzka textu " + length);
        }
        public static int Dlzkatextu(string text)
        {
            return text.Length;
        }
        //metoda ktora spocita samohlasky A/a



    }




}