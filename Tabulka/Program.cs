// See https://aka.ms/new-console-template for more information



int[] numbers = new int[] { 10, 300, 20, 40, 50 };
string[] names = new string[] { "Jano", "Feri", "Jozo", "Miro", "Laco" };

foreach (string name in names)
{
    Console.WriteLine("Ahoj " + name);
}



/*string[,] matrix = new string[30, 5];
matrix[0, 2] = "Jano";
matrix[1, 2] = "Feri";
matrix[25, 4] = "Miro";

for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + ",");
    }
    Console.WriteLine();
}
*/