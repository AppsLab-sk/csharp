Console.WriteLine("Gamble time!");



Console.WriteLine("Chose a number between 1-6 to gamble");
string? Spin = Console.ReadLine();
int FirstAttampt = int.Parse(Spin);
if (Spin == "3")
{
    Console.WriteLine("You've won"!);
}
else
{
    Console.WriteLine("Try again");
}    

