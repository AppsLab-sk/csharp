//int number = 3;
//
////{

//////// _ => "neznáme čislo"
//};

//int i = 1;
//while (i < 1001)
//{
//Console.WriteLine(i);
// i++;
//}


////if (modulo == 0)
// {
// Console.WriteLine(i);
//}
//}

using System.Numerics;
///for (int i = 1; i <= 1000;){


string[,] matrix = new string[30, 5];
matrix[0, 2] = "Janko";
matrix[1, 2] = "Fero";
matrix[1, 2] = "Miro";

for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + ", ");
    }
    Console.WriteLine();
}