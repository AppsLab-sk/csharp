
//string [,] matrix = new string[30, 5];
//matrix[0, 2] = "Janko";
//matrix[0, 3] = "Fero";
//matrix[0, 4] = "Laco";
//matrix[0, 5] = "Palo";


////vloz 4 rozne mena
////vypis vsetky mena
//for (int i = 0; i < 30; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//         Console.Write(matrix[i, j] + ", ");
//    }
//          Console.WriteLine();
//}


//List<int> numbers = new List<int>();
//Console.WriteLine("Zadaj cislo");
//string vstup = Console.ReadLine();

//while (vstup != "+")
//{
//    numbers.Add(int.Parse(vstup));
//    Console.WriteLine("Zadaj cislo");
//    vstup = Console.ReadLine();
//}

//Console.WriteLine("Vysledok:");
//int sucet = 0;
//foreach (int i in numbers)
//    {
//    sucet += i;
//}
//Console.WriteLine(sucet);
string meno = ZiskajMeno();
int vek = ZiskajVek();
vypisudaje(meno, vek);

string ZiskajMeno()
{
    Console.WriteLine("Zadaj svoje meno");
    string meno = Console.ReadLine();
    return meno;
}

int ZiskajVek()
{
    Console.WriteLine("Zadaj svoj vek");
    int vek = int.Parse(Console.ReadLine());
    return vek;
}

void vypisudaje(string meno, int vek)
{
       Console.WriteLine($"Vitaj {meno} v programe");
    Console.WriteLine($"Mas {vek} rokov"); 
    
}
