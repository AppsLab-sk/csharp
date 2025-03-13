namespace PozicovnaAut
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto totoya = new Auto("Toyota", "Corolla", 65);
            SportoveAuto audi = new SportoveAuto("Audi", "A7", 125, 180, 4);
            VelkeAuto citron = new VelkeAuto("Citroen", "C4", 75, 7, 170);  

            totoya.VypisInfo();
            audi.VypisInfo();
            citron.VypisInfo();
        }
    }
}