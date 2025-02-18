static class Pole
{
    static char[,] gameBoard = new char[6, 6];

    static void Main()
    {
        InitializeBoard();
        DisplayBoard();
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                gameBoard[i, j] = ' ';
            }
        }
    }

    static void DisplayBoard()
    {
        Console.Clear();

        
        Console.Write("    ");
        for (char col = 'A'; col < 'A' + 6; col++)
        {
            Console.Write(col + "   ");
        }
        Console.WriteLine();
        Console.WriteLine("  " + new string('-', 25));

        for (int i = 0; i < 6; i++)
        {
           
            Console.Write((i + 1) + " | ");
            for (int j = 0; j < 6; j++)
            {
                Console.Write(gameBoard[i, j] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("  " + new string('-', 25));
        }
    }
}

