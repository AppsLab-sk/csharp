// See https://aka.ms/new-console-template for more information

string meno = ZiskajMeno();
string vek = ZiskajVek();

Console.WriteLine($"Ahoj {meno}. Tvoj vek je {vek}");

string ZiskajMeno()
{
    Console.WriteLine("Zadaj Meno");
    string meno = Console.ReadLine();
    return meno;
}
string ZiskajVek()
{
    Console.WriteLine("Zadaj vek");
    string vek = Console.ReadLine();
    return vek;
}

void VypisUdaje(string meno, string vek)
{
    Console.WriteLine($"Ahoj {meno}. Tvoj vek je {vek} ");
}