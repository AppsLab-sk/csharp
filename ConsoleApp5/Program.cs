using ObcanMesto;

namespace ObcanMesto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mesto bratislava = Mesto.NacitajZoSuboru("mesto.json");
            if (bratislava == null)
            {
                bratislava = new Mesto("Bratislava");

                Obcan o;

                while (bratislava.obcania.Count < 31)
                {
                    o = GeneratorObcanov.GenerujObcana();
                    bratislava.PridajObcana(o);
                }

                for (int i = 0; i < 31; i++)
                {
                    o = GeneratorObcanov.GenerujObcana();
                    bratislava.PridajObcana(o);
                }
                string subor = "mesto.json";
                bratislava.UlozDoSuboru(subor);

                bratislava.VypisObcanov();
            }
        }
    }
}