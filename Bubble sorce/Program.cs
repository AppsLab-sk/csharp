int[] numbers = new int[] { 10, 100, 6, 7, 33, 68, 77 };




for (int j = 0; j < numbers.Length; j++)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int first = numbers[i];
        int second = numbers[i + 1];

        if (first > second)
        {
            int bubble = first;
            first = second;
            second = bubble;
            numbers[i] = first;
            numbers[i + 1] = second;
        }
    }
}
foreach (int i in numbers)
{
    Console.WriteLine(i);
}