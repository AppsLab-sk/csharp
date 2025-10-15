//int a = 6;
//int b = 2;

//int Sčítanie = a + b;
//int Odčítanie = a - b;
//int Násobenie = a * b;
//int Delenie = a / b;
//int Zvyšok = a % b;

//bool Rovnosť = a == b;
//bool Nerovnosť = a != b;
//bool Väčšíako = a > b;
//bool Menšíako = a < b;
//bool Väčšíaleborovnýako = a >= b;
//bool Menšíaleborovnýako = a <= b;


//bool a = true;
//int b = 74;
//int c = 67;

//bool andBool1 = a && (b > c);
//bool andBool2 = a && (b == c);
//bool andBool3 = a && (b == c) || (c < b);
//bool andBool4 = a && ((b == c) || (c < b));


//bool a = true;
//int b = 20;
//int c = 15;
//bool d = false;
//int e = 20;

//bool vysledok = ((c <= b) || !a) && (a == (e == b));

//bool vysledok2 = (!(a && d) || (!(b < e) && !vysledok));


//int age = 21;
//if (age <= 18)
//{
//    Console.WriteLine("Som už veľký");
//    Console.WriteLine("Dám si veľké pivo");
//}

//string? input = Console.ReadLine();
//int number = int.Parse(input);
//if (number >= 1 && number <= 6)
//{
//    Console.WriteLine("Hurá! mám kocku");
//}
//else
//{
//    Console.WriteLine("Hej! Daj mi kocku!");
//}


//string text = "querty";
//text = "čauko";
//text += ",koľko máš rokov?";

//int vek = int.Parse(Console.ReadLine());

//if (vek > 18) 
//{
//    Console.WriteLine("Dám si veľké pivo");
//}
//else if (vek <= 18)
//{
//    Console.WriteLine("Dám si malú kofolu");
//}




//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<double> numbers = new List<double>();
//        string input;

//        Console.WriteLine("Zadávaj čísla. Ak chceš skončiť, zadaj '+'.");

//        while (true)
//        {
//            Console.Write("Zadaj číslo alebo '+': ");
//            input = Console.ReadLine();

//            if (input == "+")
//            {
//                break;
//            }

//            if (double.TryParse(input, out double number))
//            {
//                numbers.Add(number);
//            }
//            else
//            {
//                Console.WriteLine("Zadaj platné číslo alebo '+'.");
//            }
//        }

//        double sum = 0;
//        foreach (double num in numbers)
//        {
//            sum += num;
//        }

//        Console.WriteLine($"Súčet zadaných čísel je: {sum}");
//    }
//}




string meno = ZiskajMeno();
string vek = Ziskajvek();
VypisUdaje(meno , vek);

string ZiskajMeno()
{
    Console.WriteLine("Zadaj meno");
    string meno = Console.ReadLine();
    return meno;
}

string Ziskajvek()
{
    Console.WriteLine("Zadaj vek");
    string vek = Console.ReadLine();
    return vek;
}
Console.WriteLine($"Ahoj {meno}. Tvoj vek je {vek} rokov");

















