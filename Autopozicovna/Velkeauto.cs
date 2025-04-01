class Velkeauto : Auto
{
    public int KapacitaPasazierov { get; set; }
    public int ObjemBatoziny { get; set; }

    public Velkeauto(string znacka, string model, decimal cenaZaDen, int kapacitaPasazierov, int objemBatoziny)
        : base(znacka, model, cenaZaDen)
    {
        KapacitaPasazierov = kapacitaPasazierov;
        ObjemBatoziny = objemBatoziny;
    }

    public override void VypisInfo()
    {
        base.VypisInfo();
        Console.WriteLine($"Kapacita pasažierov: {KapacitaPasazierov}, Objem batožiny: {ObjemBatoziny} litrov");
    }
}
