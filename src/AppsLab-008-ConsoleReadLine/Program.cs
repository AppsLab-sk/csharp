//Console.WriteLine("Zadaj prvé číslo");
//int cislo1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj druhé číslo");
//int cislo2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj operáciu +,-,*,/,%");
//string operacia = Console.ReadLine();

//int vysledok = operacia switch
//{
//    "+" => cislo1 + cislo2,
//    "-" => cislo1 - cislo2,
//    "*" => cislo1 * cislo2,
//    "/" => cislo1 / cislo2,
//    "%" => cislo1 % cislo2,
//};

//Console.WriteLine($"Tvoj vysledok je {vysledok}");

//Console.WriteLine("Zadaj číslom deň týždňa");
//int dayofweak = int .Parse(Console.ReadLine());

//switch (dayofweak)
//{
//    case 1:
//        Console.WriteLine("Pondelok");
//        break;
//        case 2:
//        Console.WriteLine("Utorok");
//        break;
//        case 3:
//        Console.WriteLine("Streda");
//        break;
//        case 4:
//        Console.WriteLine("Štvrtok");
//        break;
//        case 5:
//        Console.WriteLine("Piatok");
//        break;
//        case 6:
//        Console.WriteLine("Sobota");
//        break;
//        case 7:
//        Console.WriteLine("Nedeľa");
//        break;
//        default:
//        Console.WriteLine("Neplatný deň");
//        break;
//}
//int numberDescription;
//int; numberDescription  = numberDescription switch
//{
// 1 => "jeden",
// 2 => "dva",
// 3 => "tri",
// _ => "Neznáme číslo"
//};

//Console.WriteLine(numberDescription); //vypise:tri 

//Console.WriteLine("1");
//Console.WriteLine("2"); 
//Console.WriteLine("3");
//Console.WriteLine("4");
//Console.WriteLine("5");
//Console.WriteLine("6");
//Console.WriteLine("7");
//Console.WriteLine("8");
//Console.WriteLine("9");
//Console.WriteLine("10");

//int i = 1;
//while (i <= 1000)
//{
//    Console.WriteLine(i);
//    i++;
//}



//for (int i = 1; i <= 1000; i++)
//{
//    int modulo = i % 2;
//    if (modulo == 0) ;
//    {
//        Console.WriteLine(i);
//    }
//}

//int[] numbers = new int[5];

//numbers[0] = 10;
//numbers[1] = 300;
//numbers[2] = 20;
//numbers[3] = 40;
//numbers[4] = 50;
//int index = 0;

//while (index < 5) 
//{
//    Console.WriteLine(numbers[index]);
//    index++;
//}
//for (int i = 0; i <5; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//foreach (int i in numbers)
//{
//    Console.WriteLine(numbers);
//}
int[] numbers = new int[] { 10, 300, 20, 40, 50 };
string[] names = new string[] { "Janko", "Fero", "Miro", "Laco", "Palo" };
string[,] matrix = new string[30, 5];
matrix[0, 2] = "Janko";
matrix[1, 2] = "Fero";
matrix[25, 4] = "Miro";

for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++) 
    {
        Console.Write(matrix[i, j] + ", ");
    }
    Console.WriteLine();
}
