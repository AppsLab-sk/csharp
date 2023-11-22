int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 4)
    {
        continue;
    }
    else
    {
        sum += numbers[i];
    }
}

Console.WriteLine(sum); 


