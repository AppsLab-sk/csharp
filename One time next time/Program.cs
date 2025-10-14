//Console.WriteLine("Zadaj den v tyzdni (1-7): ");
//int dayOfWeek = int.Parse(Console.ReadLine()!);
//{
//    switch (dayOfWeek)
//    {
//        case 1:
//            Console.WriteLine("Pondelok");
//            break;
//        case 2:
//            Console.WriteLine("Utorok");
//            break;
//        case 3:
//            Console.WriteLine("Streda");
//            break;
//        case 4:
//            Console.WriteLine("Stvrtok");
//            break;
//        case 5:
//            Console.WriteLine("Piatok");
//            break;
//        case 6:
//            Console.WriteLine("Sobota");
//            break;
//        case 7:
//            Console.WriteLine("Nedela");
//            break;
//        default:
//            Console.WriteLine("Neplatny den v tyzdni");
//            break;

//    }
//}
//int number = 5;
//string result = number switch
//{
//    1 => "One",
//    2 => "Two",
//    3 => "Three",
//    4 => "Four",
//    5 => "Five",
//    _ => "Unknown"
//};
//Console.WriteLine(result);





//for (int i = 1; i <= 1000; i++)
//{
//    int modulo = i % 2;
//if (modulo == 0)
//{
//    Console.WriteLine(i);
//}
//}

//int[] numbers = new int[5] { 10, 100, 80, 150, 2000 };


//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

string[,] matrix = new string[30, 5];
// vloz 4 roznych mien
// vypis cele pole na obrayovku
matrix[0, 2] = "Ferko";
matrix[1, 2] = "Janko";
matrix[25, 4] = "Misko";

for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + ", ");
    }
            Console.WriteLine();
        }
    
        
    

