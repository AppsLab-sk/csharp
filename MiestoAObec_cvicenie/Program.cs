using MiestoAObec_cvicenie;
using MiestoAObec_cvicenie.PovolanoeMenoMesto_cvicenie;
using System.Collections.Generic;

namespace MiestoAObec_cvicenie
{
    public class Program
    {
        static void Main(string[] args)
        {
            mesto mesto = mesto.NacitajZoSuboru("mesto.json");
            if (bratislava == null)
            {



                mesto bratislava = new mesto("bratislava");

                for (int i = 0; i < 31; i++)
                {
                    Obcan o = GeneratorObcanov.GenerujObcana();
                    bratislava.PridajObcana(o);
                }
                for (int i = 0; i < 31; i++)
                {
                    Programator programator = GeneratorObcanov.GenerujProgramatora();
                    bratislava.PridajObcana(programator);
                }
                string subor = "mesto.json";
                bratislava.UlozDoSuboru(subor);
            }
            bratislava.VypisObcana();

        }
    }
}