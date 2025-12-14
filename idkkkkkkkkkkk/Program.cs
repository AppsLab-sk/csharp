int[] numbers = new int[] { 10, 300, 20, 40, 50 };
string[] names = new string[] { "Janko", "Fero", "Jozo", "Miro", "Laco" };

string[,] matrix = new string[30, 5];
matrix[0, 2] = "Janko";
matrix[1, 2] = "Fero";
matrix[25, 4] = "Miro";

for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + ",");
    }
    Console.WriteLine();
}