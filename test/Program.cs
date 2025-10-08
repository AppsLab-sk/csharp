
string[] names = new string[] {"Jozef", "Marek", "Anna", "Eva", "Peter"};
string[,] matrix = new string[30,5];
matrix [0,2] = "Jozef";
matrix [1,2] = "Marek";
matrix [2,2] = "Anna";
matrix [25,2] = "Eva";
for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
     
        Console.Write(matrix[i, j ] + " ,");
    }
    Console.WriteLine();
}
