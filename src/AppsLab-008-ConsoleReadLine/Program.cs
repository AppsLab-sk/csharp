//Console.WriteLine("Moja Kalkulačka");
//String? prveCislo = Console.ReadLine();
//string? druheCislo  = Console.ReadLine();
//int sucet = int.Parse(prveCislo) + int.Parse(druheCislo);
//Console.WriteLine($"Sucet: {sucet}");


//int a = 1;
//int b = 2;
//int sum =a + b;
//Console.WriteLine("Zadaj Cislo: ");
//int cislo1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj druhe cislo: ");
//int cislo2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj operaciu(+,-,*,/)");
//var Operacia = Console.ReadLine();

//int vysledok = Operacia switch
//{
//    "+" => cislo1 + cislo2;
//  "-" => cislo1 - cislo2;
//  "+" => cislo1 + cislo2;
//  "/" +> cislo1 / cislo2;
//}



//}
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
//    if (modulo==0)
//    {
//        Console.WriteLine(i);
//    }

//}
//int[] numbers = new int[] { 10, 300, 20, 40, 50 };
//string[] names = new string[] { "Janko", "Fero", "Miro", "Laco", "Palo" };
//string[,] matrix = new string[30, 5];
//matrix[0, 2] = "Janko";
//matrix[1, 2] = "Fero";
//matrix[25, 4] = "Miro";
//for (int i = 0; i < 30; i++)
//{
//for (int j = 0; j < 30; j++)
//    {
//        Console.Write(matrix[i, j] + ",");
//    }
//Console.WriteLine();
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

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//foreach (int number in numbers)
//{ 
// Console.WriteLine(number);
//}


//string meno = ZiskajMeno();
//string vek  = ZiskajVek();

//Console.WriteLine($"Ahoj {meno}.Tvoj vek je {vek} rokov");

//string ZiskajMeno()
//{
//    Console.WriteLine("Zadaj meno");
//    string meno = Console.ReadLine();
//    return meno;
//}
//string ZiskajVek()
//{
//    Console.WriteLine("Zadaj vej");
//    string vek = Console.ReadLine();
//    return vek;

//}
//void VypisUdaje(string meno, string vek)
//{
//    Console.WriteLine($"Ahoj {meno}. Tvoj vek je {vek} rokov");
//}

