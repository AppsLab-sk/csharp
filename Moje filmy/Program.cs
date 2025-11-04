
// uvod

Console.WriteLine("Vitaj v mojom svete filmov! ");
Console.WriteLine("Mozes si vybrat film ktory chces pozerat. ");
Console.WriteLine("Vsetky ktore tu vidi su moje oblubene. ");
//

// ukazka co to dokaze 

Console.WriteLine("Tu mas moznosti, ktore mozes robit v mojej verzii 'kukaj to'!");
Console.WriteLine("1 = Zoznam filmov!");
Console.WriteLine("2 = Pridat film!");
Console.WriteLine("3 = Vyhladat film!");
Console.WriteLine("4 = Zmazat film!");
Console.WriteLine("5 = Ukoncit program!");
Console.WriteLine("Podla toho co chces urobit tak zadaj cislo od 1 - 5: ");
string program = Console.ReadLine();
string vysledok = "";
//


//opakovanie moznosti
bool koniec = false;
while (!koniec)


{
    // vypisanie moznosti 
    switch (program)
    {
        case "1":
            ZobrazZoznamFilmov(ZoznamFilmov);
            break;

        case "2":
            Console.WriteLine("Zadaj nazov filmu na pridanie: ");
            string novy = Console.ReadLine();
            ZoznamFilmov.Add(novy);
            Console.WriteLine("Film bol pridany!");
            break;

        case "3":
            string hladany = ZiskanieFilmu();
            bool najdeny = VyhladatFilm(ZoznamFilmov, hladany);
            ZobrazitVysledok(hladany, najdeny);
            break;

        case "4":
            Console.WriteLine("Zadaj nazov filmu na vymazanie: ");
            string mazany = Console.ReadLine();
            bool vymazany = VymazFilm(ZoznamFilmov, mazany);
            ZobrazVysledokVymazania(mazany, vymazany);
            break;

        case "5":
            UkoncenieProgramu();
            break;

     }




    // zoznam filmov
    List<string> ZoznamFilmov = new List<string>();
    if (program == "1")
    {
        Console.WriteLine("Tu je moj zoznam! ");
        Console.WriteLine("(1) = Rychlo a zbesilo! ");
        Console.WriteLine("(2) = Thor! ");
        Console.WriteLine("(3) = Hulk! ");
        Console.WriteLine("(4) = Capiatn America! ");
        Console.WriteLine("(5) = Spider man! ");
        Console.WriteLine("(6) = Hobit! ");
        Console.WriteLine("(7) = Zaklinac! ");
        Console.WriteLine("(8) = Pan prstenov! ");
        Console.WriteLine("(9) = Ocelova pest! ");
        Console.WriteLine("(10) = Transformers! ");
    }
    //


    // pridanie filmov do zoznmau
    Console.WriteLine("Zadaj nazov filmu na pridanie: ");
    string novyFilm = Console.ReadLine();
    PridatFilm.Add(novyFilm);
    ZoznamFilmov.AddRange(PridatFilm);
    PridatFilm.Clear();
    Console.WriteLine($"Film '{novyFilm}' bol pridany do zoznamu!");
    //


    // hladanie filmu
    string ZiskanieFilmu()
    {
        Console.WriteLine(" Ziskavanie filmu! ");
        Console.WriteLine("Zadaj nazov filmu ktory chces pozerat!: ");
        return Console.ReadLine();
    }

    bool VyhladatFilm(List<string> filmy, string HladanyFilm)
    {
        return filmy.Exists(f => f.Equals(HladanyFilm, StringComparison.OrdinalIgnoreCase));
    }

    void ZobrazitVysledok(string HladanyFilm, bool najdeny)
    {
        if (najdeny)
        {
            Console.WriteLine($"Film {HladanyFilm} sa nasiel v zozname! ");
        }
        else
        {
            Console.WriteLine($"Film {HladanyFilm} sa nenasiel v zozname! ");
        }
    }
    //


    // vymazanie filmov

    void ZobrazZoznamFilmov(List<string> filmy)
    {
        Console.WriteLine("Aktualny zoznam filmov! ");
        foreach (string film in filmy)
        {
            Console.WriteLine($"{film}");
        }
        Console.WriteLine();
    }
    bool VymazFilm(List<string> filmy, string FilmNaVymazanie)
    {
        string film = filmy.Find(f => f.Equals(FilmNaVymazanie, StringComparison.OrdinalIgnoreCase));
        if (film != null)
        {
            filmy.Remove(film);
            return true;
        }
        else
        {
            return false;
        }
    }
    void ZobrazVysledokVymazania(string FilmNaVymazanie, bool vymazany)
    {
        if (vymazany)
        {
            Console.WriteLine($"Film {FilmNaVymazanie} bol vymazany zo zoznamu! ");
        }
        else
        {
            Console.WriteLine($"Film {FilmNaVymazanie} sa nepodarilo vymazat! ");
        }
    }
    //


    //ukoncenie programu
    void UkoncenieProgramu()
    {
        Console.WriteLine("Ukoncenie programu! ");
        Console.WriteLine("Naozaj chces ukoncit program? (A/N): ");
        string odpoved = Console.ReadLine();
    }
    void UkoncienieProgramu()
    {
        Console.WriteLine("Naozaj chces ukoncit program? (A/N): ");
        string odpoved = Console.ReadLine();

        if (odpoved.Equals("A", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Program sa ukoncuje... Dakujem za pouzitie!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Ukoncenie programu bolo zrusene. Pokracujes dalej!");
        }
    }
    void ZrusitUkoncenie()
    {
        Console.WriteLine("Ukonacenie programu bolo zrusene. pokracijes dalej! ");
    }
} 