
class Auto
{
    public string Znacka { get; set; }
    public string Model { get; set; }
    public decimal CenaZaDen { get; set; }

    public Auto(string znacka, string model, decimal cenaZaDen)
    {
        Znacka = znacka;
        Model = model;
        CenaZaDen = cenaZaDen;
    }

    public virtual void VypisInfo()
    {
        Console.WriteLine($"Značka: {Znacka}, Model: {Model}, Cena za deň: {CenaZaDen}€");
    }

    public decimal VypocitajCenu(int dni)
    {
        return CenaZaDen * dni;
    }
}