List<int> numbers = new List<int>();
Console.WriteLine("Put a number here ig?");
string vstup = Console.ReadLine();

while (vstup != "+")
{
    numbers.Add(int.Parse(vstup));
    Console.WriteLine("Next number");
    vstup = Console.ReadLine();

}

Console.WriteLine("it's:");
int sucet = 0;
foreach (int i in numbers)
{
    sucet += i;
}
Console.WriteLine(sucet);


//extras... continue jumps over one cycle and break stops the whole thing.. use break as least as possible... soposibly