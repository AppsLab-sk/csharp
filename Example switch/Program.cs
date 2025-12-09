// See https://aka.ms/new-console-template for more information



int number = 3;

string numberDescription = number switch
{
    1 => "jeden",
    2 => "dva",
    3 => "tri",
    _ => "nezname cislo",
};
Console.WriteLine(numberDescription); // vypise: tri