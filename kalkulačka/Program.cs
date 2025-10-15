//Console.WriteLine("Zadaj prve cislo");
//int cislo1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj druhe cislo:");
//int cislo2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj operaciu (+, -, *, /, %):");
//string operacia = Console.ReadLine();

//int vysledok = operacia switch
//{
//    "+" => (cislo1 + cislo2),
//    "*" => (cislo1 * cislo2),
//    "/" => (cislo1 / cislo2),
//    "%" => (cislo1 % cislo2),
//};
//Console.WriteLine($"Vysledok je: {vysledok}");
//Console.WriteLine("Stlac ENTER pre spustenie kalkulacky");
//Console.ReadLine();
//System.Environment.Exit(0);


//for (int i = 1; i <= 1000; i++)
//{
//    int modulo = i % 2;
//    if (modulo == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

int[] numbers = new int[] { 10, 300, 20, 40, 50 };
string[] names = new string[] { "Janko", "Fero", "Miro", "Laco", "Palo" };

string[,] matrix = new string[30, 5];
matrix[0, 2] = "Janko";
matrix[1, 2] = "Fero";
matrix[25, 4] = "Miro";

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 30; j++)
    {
        Console.Write(matrix[i, j] + ",");
    }
    Console.WriteLine();
}





