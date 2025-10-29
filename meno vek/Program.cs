    using meno_vek;
Console.WriteLine("zadaj meno");
    string meno = Console.ReadLine();
    Clovek clovek  = new Clovek();
    clovek.SetName(meno);
    Console.WriteLine(meno);
Console.WriteLine($"zadaj vek {meno}");
int vekInput = int.Parse(Console.ReadLine());
clovek.SetAge(vekInput);
bool mozes = clovek.MozesPit();
    if (mozes == false)
    {
        Console.WriteLine("nemozes pit ujo");
    }
    else
    {
        Console.WriteLine("uz mozes pit ");
    }



