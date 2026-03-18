using System.Reflection.Emit;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ct = 0;
            for (int i = 0; i < 1000; i++) 
            {
                bool result = Prob();
                if (result == true) ;
                {
                    ct++;

                }
        }
            Console.WriteLine("true bolo: " + ct + " x ");
    }

        public static bool Prob()
        {
           random r = new Random();
            int nahodnecislo = r.Next(0,101);
            if (nahodnecislo >= 73)
            {
                return true;
            }
        }
    }
