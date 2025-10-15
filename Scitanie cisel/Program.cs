// See https://aka.ms/new-console-template for more information

int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 54 };
int vysledok = 0;

for (int i = 0; i < numbers.Length; i++)
{
    vysledok += numbers[i];
}
Console.WriteLine(vysledok);