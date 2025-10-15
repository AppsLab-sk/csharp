//int i = 1;
//while (i <= 1000)
//{
//    Console.WriteLine(i);
//    i++;
//}

using System.ComponentModel.Design;
using System.Numerics;

for (int i = 1; i <= 1000; i++)
{
    int modulo = i % 2;
    if (modulo == 0)
    {
        Console.WriteLine(i);
    }
}

