namespace Obcan_a_Mesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto zilina = Mesto.NacitajZoSuboru("mesto.json");
            if (zilina == null)
            {
                zilina = new Mesto("Zilina");
                for (int i = 0; i < 31; i++)
                {
                    Obcan obcan = GeneratorObcanov.GenreujObcana();
                    zilina.PridajObcanaDoMesta(obcan);
                }
                string subor = "mesto.json";
                zilina.UlozDoSUboru(subor);
            }
            zilina.VypisObcanov();
        }
    }
}