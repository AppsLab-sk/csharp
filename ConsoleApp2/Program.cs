string[] names = new string[] { "Michal", "Matej", "Alex", "David", "Eva" };
string[,] matrix = new string [ 30, 5 ];
matrix [0, 2] = "Michal";
matrix [1, 2] = "Matej";
matrix [25, 4] = "Alex";
matrix [29, 0] = "David";
for (int i =0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine(matrix [i, j] + ", ");
    }
    Console.WriteLine();
}



