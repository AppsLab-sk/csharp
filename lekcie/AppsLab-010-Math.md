# Matematická trieda v `C#`

V C# je k dispozícii trieda `Math`, ktorá poskytuje metódy na vykonávanie základných matematických operácií, ako sú odmocnina, zaokrúhľovanie, výpočet absolútnej hodnoty a mnoho iných.

## Využitie triedy Math

Pozrime sa na niektoré základné príklady využitia triedy `Math`.

```csharp
double number = 9.5;

// Zaokrúhľovanie
double rounded = Math.Round(number);  // Výsledok: 10

// Odmocnina
double squareRoot = Math.Sqrt(number);  // Výsledok: 3.08220700148449

// Absolútna hodnota
double absoluteValue = Math.Abs(-10);  // Výsledok: 10

// Max a Min hodnoty
double max = Math.Max(3, 7);  // Výsledok: 7
double min = Math.Min(3, 7);  // Výsledok: 3
```

### Kedy a ako používať triedu Math

Trieda `Math` je veľmi užitočná v prípade, keď potrebujete vykonať matematické operácie, ktoré by boli zložité alebo neefektívne implementovať manuálne. Je dôležité si uvedomiť, že metódy triedy `Math` sú statické, čo znamená, že ich môžete volať priamo z triedy `Math`, bez toho, aby ste museli vytvárať inštanciu tejto triedy.

Zaujímavým príkladom použitia triedy `Math` je výpočet vzdialenosti medzi dvoma bodmi v 2D priestore. Na tento účel môžeme použiť metódu `Math.Sqrt` na výpočet odmocniny a metódu `Math.Pow` na umocnenie.

```csharp
double x1 = 0, y1 = 0;  // Prvý bod
double x2 = 5, y2 = 5;  // Druhý bod

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));  // Výsledok: 7.07106781186548
```

## Cvičenie - Matematická trieda v `C#`

Cieľom tohto cvičenia je upraviť už existujúci kód triedy `SphereCalculator`, ktorý vypočíta povrch a objem gule. Na tento účel budeme potrebovať použiť niektoré z metód matematickej triedy, konkrétne `Math.Pow` a `Math.PI`.

1. Otvorte existujúci projekt `AppsLab-010-Math` v adresári `src\AppsLab-010-Math`.

2. V triede `SphereCalculator` nájdete dve metódy: `CalculateSurface` a `CalculateVolume`. Tieto metódy momentálne obsahujú riadok `throw new NotImplementedException();`, ktorý musíte nahradiť reálnym kódom.

```csharp
public double CalculateSurface(double radius)
{
    throw new NotImplementedException();
}

public double CalculateVolume(double radius)
{
    throw new NotImplementedException();
}
```

Jednou z najdôležitejších zručností, ktorú by mal mať každý softvérový inžinier, je schopnosť vyhľadať potrebné informácie na internete. Ako programátori sa často stretávame so situáciami, keď si niečo nepamätáme alebo niečomu nerozumieme. V takom prípade je náš najlepší priateľ vyhľadávač, ako je napríklad Google.

Pre implementáciu metód `CalculateSurface` a `CalculateVolume` budete potrebovať vzorce pre výpočet povrchu a objemu gule. Ak si tieto vzorce nepamätáte alebo ich neviete, skúste ich vyhľadať na internete. Je to skvelý spôsob, ako si precvičiť vaše vyhľadávacie zručnosti.

Ak máte pochybnosti o presnosti vzorcov, ktoré ste našli, môžete sa pokúsiť porovnať výsledky z viacerých zdrojov. Môžete tiež hľadať ďalšie zdroje, ktoré vysvetľujú, ako sú tieto vzorce odvodené, aby ste lepšie pochopili, prečo fungujú.

Pracujte v priečinku `src\AppsLab-010-Math`. Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

**Poznámka:** Pri práci s matematickými výpočtami je dôležité mať na pamäti, že výsledky nemusia byť presne rovné očakávaným hodnotám kvôli chybam zaokrúhľovania pri práci s číslami s plávajúcou desatinnou čiarkou (`double`).

## Otázky na kontrolu porozumenia

1. Čo je to trieda `Math` v C# a na čo sa používa?
2. Ako môžete vypočítať druhú odmocninu pomocou triedy `Math`?
3. Ako by ste vypočítali odmocninu zo záporného čísla?
4. Ako môžete zaokrúhliť číslo s desatinnými miestami na najbližšie celé číslo?
5. Ako by ste zaokrúhlili číslo s desatinnými miestami na dve desatinné miesta?
6. Ako môžete vypočítať sinus alebo kosinus uhla pomocou triedy `Math`?
7. Aké konštanty poskytuje trieda `Math` a na čo sa môžu použiť?
8. Aké sú nejaké bežné príklady použitia triedy `Math`?
9. Ako by ste vytvorili vlastnú metódu na výpočet povrchu a objemu kocky pomocou triedy `Math`?

Tieto otázky vám pomôžu overiť, či ste správne porozumeli informáciám a konceptom v tejto lekcii. Ak na niektorú z otázok neviete odpovedať, môžete sa vrátiť späť a preštudovať si príslušnú časť lekcie. Tiež nezabudnite, že ak máte akékoľvek otázky, môžete sa obrátiť na svojho inštruktora alebo vyhľadať viac informácií online.

## Ďalšie štúdium

Pre viac detailov a informácií o triede `Math` si môžete prečítať oficiálnu dokumentáciu Microsoftu. Dokumentácia obsahuje podrobný popis všetkých metód a konštánt, ktoré trieda `Math` poskytuje, vrátane príkladov ich použitia. Oficiálna dokumentácia je kľúčový zdroj informácií pre každého vývojára softvéru.

Oficiálna dokumentácia triedy `Math` je dostupná na tejto adrese:
[https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-7.0](https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-7.0)

Je dôležité si uvedomiť, že schopnosť efektívne vyhľadávať informácie na internete je jednou z kľúčových zručností vývojára softvéru. Dokážete si predstaviť situáciu, kedy sa nemôžete spoliehať na svoju pamäť a potrebujete rýchlo nájsť potrebné informácie? Dokumentácia Microsoftu je vynikajúci zdroj informácií, ale existujú aj ďalšie stránky a fóra, kde môžete nájsť odpovede na svoje otázky alebo zistiť, ako iní riešili podobné problémy. Jednou z takýchto stránok je napríklad Stack Overflow.

Nezabudnite, že ako vývojári softvéru sa musíme neustále učiť. Bez ohľadu na to, akú úroveň odbornosti dosiahnete, vždy sa budú vyskytovať nové technológie, nástroje a postupy, ktoré sa budete musieť naučiť. Využitie internetu na rýchle a efektívne vyhľadávanie informácií vám pomôže udržať krok s týmito rýchlymi zmenami.
