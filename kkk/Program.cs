/*
int u = 1;
//change one thing and its a infinity loop :>
while (1 <= 1000)
{
    Console.WriteLine(u);
    u++;
}
*/

//loop
/*
for (int i = 1; i <= 1000; i++)
{
    //to make it go like 2,4,6,8...
    int modulo = i % 2;
    if (modulo == 0) 
        //the write thing ofc
    {
        Console.WriteLine(i);
    }
}
*/





/*
int[,] matrix = new int[3, 4];
matrix[0, 0] = 1;
matrix[2, 2] = 2;
matrix[4, 7] = 3;
*/





int[] numbers = new int[] { 10, 300, 20, 40, 50 };
string[] names = new string[] { "Janko", "Fero", "Jozo", "Miro", "Laco" };

string[,] matrix = new string[30, 5];
matrix[0, 2] = "Janko";
matrix[1, 2] = "Fero";
matrix[25, 4] = "Miro";


for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + ",");
    }
    Console.WriteLine();
}

/*
// it writes the whole numbers table
int index = 0;

while (index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
    index++;
}


// it writes the whole numbers table

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(numbers[i]);
}


// it writes the whole numbers table

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
*/