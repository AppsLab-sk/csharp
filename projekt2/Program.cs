//string i = "*";
//while (i.Length <= 5)
//{
//    Console.WriteLine(i);
//    i +="*";
//}
//while (i.Length > 1)
//{
//    i = i.Remove(i.Length - 1);
//    Console.WriteLine(i);
//}

//int[] cisla = { 10, 25, 36, 45, 84, 45, 47, 75, 56, 55 };
//int i = 0;
//int vysledek = 0;
//for (i = 0; i < cisla.Length;i++)
//{
//    vysledek += cisla[i];
//}
//Console.WriteLine(vysledek);

string[] names = { "dnes", "sa", "mam","dobre" };
foreach (string name in names)
{
    Console.Write($" {name}" );
}

