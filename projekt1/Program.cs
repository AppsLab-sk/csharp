
string [,] matrix = new string[30, 5];
matrix[0, 2] = "Janko";
matrix[0, 3] = "Fero";
matrix[0, 4] = "Laco";
matrix[0, 5] = "Palo";


//vloz 4 rozne mena
//vypis vsetky mena
for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
         Console.Write(matrix[i, j] + ", ");
    }
          Console.WriteLine();
}


