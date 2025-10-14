//Console.WriteLine("Ako sa voláš?");
//string? meno = Console.ReadLine();
//Console.WriteLine("Ahoj, " + meno + " Kolko máš rokov?");

//string vstup = Console.ReadLine() ?? "0";
//int vek = int.Parse(vstup);
//Console.WriteLine("Aha, máš teda " + vek + " rokov. ");


//Console.WriteLine("Aké je tvoje oblubené jedlo");
//    string? jedlo = Console.ReadLine();
//Console.WriteLine("Hmm, " + jedlo + " to znie skvelo.");


//Console.WriteLine("Ahoj vitaj v kalkulačke");
//string? prveCislo = Console.ReadLine();
//string? druheCislo = Console.ReadLine();
//int sucet = int.Parse(prveCislo) + int.Parse(druheCislo);
//Console.WriteLine($"Sucet: {sucet}");

//int a = 5;
//int b = 1;

//int sum = a + b;
//int difference = a - b;
//int product a * b;
//double division = (double)a / b;
//int remainder = (int)a % b;

//bool equality = a == b;
//bool inequality = a != b;
//bool greater = a > b;
//bool lesser = a < b;
//bool greaterEqual = a >= b;
//bool lesserEqual = a <= b;

//bool a = true;
//bool b = false;

//bool andBool = a && b;
//bool orBool = a || b;
//bool notA = !a;

//int c = 0;

//bool a = true;
//int b = 70;
//int c = 40;

//bool andbool1 = a && (b > c);
//bool andbool2 = a && (b == c);
//bool andbool3 = a && (b == c) || (c < b);
//bool andbool4 = a && ((b == c) || (c < b));
//int d = 0;

//bool a = false;
//int b = 40;
//int c = 20;
//bool d = true;
//int e = 0;

//bool vysledok = ((c <= b) || !a) && (a == (e == b));
//Console.WriteLine(vysledok);

//string number;
//number = Console.ReadLine();
//int n = int.Parse(number);
//if (n >= 1 && n <= 6)
//{
//    Console.WriteLine("máš kocku");
//}
//else
//{
//    Console.WriteLine("daj mi kocku");
//}



//Console.WriteLine("Zadaj čislo");
//string? prveCislo = Console.ReadLine();
//Console.WriteLine("Zadaj Operator (+, -, *, /, %)");
//string oper = Console.ReadLine();
//Console.WriteLine("Zadaj čislo");
//string? druheCislo = Console.ReadLine();
//double n1 = double.Parse(prveCislo);
//double n2 = double.Parse(druheCislo);
//double sucet = 0;
//switch (oper)
//{
//    case "+":
//        sucet = n1 + n2;
//        break;
//}
//switch (oper)
//{
//    case "-":
//        sucet = n1 - n2;
//        break;
//}
//switch (oper)
//{
//    case "*":
//        sucet = n1 * n2;
//        break;
//}
//switch (oper)
//{
//    case "/":
//        sucet = n1 / n2;
//        break;
//}
//switch (oper)
//{
//    case "%":
//        sucet = n1 % n2;
//        break;
//}
//if (sucet == 0)
//{
//    Console.WriteLine("Neplatna operacia!");
//    return;
//}

//Console.WriteLine($"Vysledok: {sucet}");






//string text = "qwerty";
//text = "iny text";
//text += " pridany text";

//int vek = 10;
//int vek1 = 20;
//vek = 30;
//vek += 5;

//if (vek > 18)
//{
//    Console.WriteLine



//int number = 3;

//string numberDescription = number switch
//{
//    1 => "jeden",
//    2 => "dva",
//    3 => "tri",
//    _ => "nezname cislo"
//};

//Console.WriteLine(numberDescription);


//int i = 1;
//while (i < 1001)
//{
//    Console.WriteLine(i);
//    i++;

//}


//for (int i = 1; i <= 1000; i++)
//{
//    int modulo = i % 2;
//    if (modulo == 0)
//    { 
//    Console.WriteLine(i);
//    }
//}







//int[] numbers = new int[5];
//numbers[0] = 20;
//numbers[1] = 400;
//numbers[2] = 30;
//numbers[3] = 45;
//numbers[4] = 60;
//Console.WriteLine(numbers[0]);
//    Console.WriteLine(numbers[1]);
//    Console.WriteLine(numbers[2]);
//    Console.WriteLine(numbers[3]); 
//    Console.WriteLine(numbers[4]);
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
//    Console.WriteLine(number);
//}







int[] numbers = new int[] { 10, 300, 20, 40, 50 };

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}

Console.WriteLine()

string[,] matrix = new string[30, 5];
matrix[0, 2] = "Janko";
matrix[1, 2] = "Fero";
matrix[25, 4] = "Miro";

for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
{
        Console.WriteLine(matrix[i, j] + ",");
}
    Console.WriteLine();
}