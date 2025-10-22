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

//string[,] matrix = new string[30, 5];
//// vloz 4 roznych mien
//// vypis cele pole na obrayovku
//matrix[0, 2] = "Ferko";
//matrix[1, 2] = "Janko";
//matrix[25, 4] = "Misko";

//for (int i = 0; i < 30; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write(matrix[i, j] + ", ");
//    }
//            Console.WriteLine();
//        }


//Console.WriteLine("*");
//Console.WriteLine("**");
//Console.WriteLine("***");
//Console.WriteLine("****");
//Console.WriteLine("*****");
//Console.WriteLine("*****");
//Console.WriteLine("****");
//Console.WriteLine("***");
//Console.WriteLine("**");
//Console.WriteLine("*");


//string s = "*";
//while (s.Length < 5)
//{
//    Console.WriteLine(s);
//    s += "*";

//}
//while (s.Length > 0)
//{


//using System.Globalization;

//int[] pole = new int[10] { 50, 60, 75, 98, 23, 45, 67, 98, 11, 5 };
//int i = 0;
//int vysledok = 0;
//for ( i = 0; i < pole.Length; i++)
//{
//   vysledok += pole[i];


//}
//Console.WriteLine(vysledok);

//string[] names = { "Dnes", "sa", "mam", "dobre" };
//foreach (string name in names)
//{
//    Console.Write($"{name} ");
//}

// spravim zoznam
//using System.Globalization;

//List<int> cisla = new List<int>();
//Console.WriteLine("Zadaj cislo");
//string vstup = Console.ReadLine();

//while (vstup != "+")
//{
//    cisla.Add(int.Parse(vstup));
//    Console.WriteLine("Zadaj cislo");
//    vstup = Console.ReadLine();
// }

//Console.WriteLine("Vysledok scitania:");
//int sucet = 0;
//foreach (int i in cisla)
//{
//       sucet += i;
//}
//Console.WriteLine(sucet);

// zadam svoje meno a vek a privita ma to ahoj
string meno = ZiskajMeno();
int vek = ZiskajVek();
VypisUdaje(meno, vek);
string ZiskajMeno()
{
   Console.WriteLine("Zadaj svoje meno: ");
    string meno = Console.ReadLine()!;
    return meno;
}

int ZiskajVek()
{
    Console.WriteLine("Zadaj svoj vek: ");
    int vek = int.Parse(Console.ReadLine());
    return vek;
}
void VypisUdaje(string meno, int vek)
{
    Console.WriteLine($"Ahoj, {meno} tvoj vek je {vek}");
}


