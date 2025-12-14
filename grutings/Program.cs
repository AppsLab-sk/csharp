

string name = GetMyName();
string age = GetMyAge();

PrintStuff(name, age);




string GetMyName()
{
    Console.WriteLine("Name?");
    string? name = Console.ReadLine();

    return name;
}

string GetMyAge()
{
    Console.WriteLine("Age?");
    string? age = Console.ReadLine();

    return age;
}


void PrintStuff(string name, string age)
{
    Console.WriteLine($"Your name is {name} and you're {age} years old");
}