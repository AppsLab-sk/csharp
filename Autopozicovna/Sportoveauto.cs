
namespace Autopozicovna
{
    class Sportoveauto : Auto
    {
        public int MaximalnaRychlost { get; set; }
        public double Zrychlenie { get; set; }
        public Sportoveauto(string znacka, string model, decimal cenaZaDen, int maximalnaRychlost, double zrychlenie) : base(znacka, model, cenaZaDen)
        {
            MaximalnaRychlost = maximalnaRychlost;
            Zrychlenie = zrychlenie;
        }
        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Max. rýchlosť: {MaximalnaRychlost} km/h, Zrýchlenie: {Zrychlenie} s");
        }
    }
}

