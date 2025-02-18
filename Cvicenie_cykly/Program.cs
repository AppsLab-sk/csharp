using System;

class TestClass
{
    static void Main(string[] args)
    {

        int i = 0;
        while (true)
        {
            Console.WriteLine(i);
            i++;
            if (i == 50000)
            {
                break;
            }
        }
    }
}

