int[] numbers = new int[100000000];

//for (int i = 0;  i < numbers.Length; i++)
//{
//    for (int j = 0; j < numbers.Length; j++)
//    {
//        int buble = numbers[i + 1];
//        if (buble == 0)
//        {
//            numbers[j + 1] = buble;
//            numbers[j] = buble;


//        }
//    }
//}
DateTime now = DateTime.Now;
numbers = numbers.Order().ToArray();
Console.WriteLine(DateTime.Now - now);

now = DateTime.Now;
for (int j = 0; j < numbers.Length - 1; j++)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int cislo1 = numbers[i];
        int cislo2 = numbers[i + 1];
        if (cislo1 > cislo2)
        {
            int buble = cislo1;
            cislo1 = cislo2;
            cislo2 = buble;
            numbers[i] = cislo1;
            numbers[i + 1] = cislo2;
        }
    }
}
Console.WriteLine(DateTime.Now - now);
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}