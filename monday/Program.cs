Console.WriteLine("Zadaj cislo od 1 do 7");
int dayOfWeek = int.Parse(Console.ReadLine());




{
    switch (dayOfWeek)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Error: Invalid day of the week.");
            break;

    }
}

int number = 3;
string result = number switch
{
    1 => "One",
    2 => "Two",
    3 => "Three",
    _ => "Other"
};
Console.WriteLine(result);
