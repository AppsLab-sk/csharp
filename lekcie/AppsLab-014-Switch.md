# Switch v jazyku `C#`

`switch` je nástroj, ktorý umožňuje výber jednej možnosti z mnohých na základe hodnoty premennej alebo výrazu. Toto je v podstate podmienka, ktorá umožňuje jednoduchý výber z mnohých možností.

Jednoduchý príklad použitia `switch`:

```csharp
int dayOfWeek = 3;

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Pondelok");
        break;
    case 2:
        Console.WriteLine("Utorok");
        break;
    case 3:
        Console.WriteLine("Streda");
        break;
    case 4:
        Console.WriteLine("Štvrtok");
        break;
    case 5:
        Console.WriteLine("Piatok");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Nedeľa");
        break;
    default:
        Console.WriteLine("Neplatný deň");
        break;
}
```

V tomto príklade `switch` kontroluje hodnotu premennej `dayOfWeek`. Na základe jej hodnoty vypíše príslušný deň týždňa. Ak `dayOfWeek` nie je medzi 1 a 7, program vypíše "Neplatný deň".

## Syntax `switch`

- `switch` - kľúčové slovo, ktoré začína `switch` príkaz.
- `(dayOfWeek)` - premenná alebo výraz, ktorý sa má kontrolovať.
- `{}` - zátvorky obsahujúce jednotlivé `case`.
- `case` - označuje možnú hodnotu. Ak sa hodnota zhoduje s hodnotou v `switch`, vykonajú sa príkazy za `case`.
- `:` - používa sa na oddelenie hodnoty `case` od príkazov, ktoré sa majú vykonať.
- `break` - ukončuje `switch` príkaz. Ak je vynechaný, vykonajú sa všetky príkazy `case` až po najbližší `break`.
- `default` - voliteľný. Vykoná sa, ak sa žiadna hodnota `case` nezhoduje s hodnotou v `switch`.

Poznámka: V niektorých prípadoch môžete namiesto `break` použiť `return`, alebo `throw`. V týchto prípadoch `break` nie je potrebný.

### Výber podľa reťazca

`switch` môže byť tiež použitý na výber na základe reťazca. Napríklad:

```csharp
string dayOfWeek = "Pondelok";

switch (dayOfWeek)
{
    case "Pondelok":
        Console.WriteLine("Začiatok týždňa");
        break;
    case "Piatok":
        Console.WriteLine("Koniec týždňa");
        break;
    case "Sobota":
    case "Nedeľa":
        Console.WriteLine("Víkend");
        break;
    default:
        Console.WriteLine("Stred týždňa");
        break;
}
```

V tomto príklade sa hodnota `dayOfWeek` kontroluje proti rôznym dňom v týždni. Ak je to `"Pondelok"`, program vypíše `"Začiatok týždňa"`. Ak je to `"Piatok"`, vypíše `"Koniec týždňa"`. Ak je to `"Sobota"` alebo `"Nedeľa"`, vypíše `"Víkend"`. Ak to nie je žiadny z týchto dní, vypíše `"Stred týždňa"`.

## Switch expressions v C# 8.0 a novších

Od verzie C# 8.0 je dostupná nová funkcia zvaná switch expressions. Táto funkcia je užitočná, ak chcete priradiť hodnotu na základe výsledku `switch`.

Jednoduchý príklad použitia switch expressions:

```csharp
int number = 3;

string numberDescription = number switch
{
    1 => "jeden",
    2 => "dva",
    3 => "tri",
    _ => "neznáme číslo"
};

Console.WriteLine(numberDescription);  // vypíše: tri
```

V tomto príklade sa hodnota `number` kontroluje proti rôznym hodnotám. Na základe toho sa priradí hodnota premennej `numberDescription`.

### Switch na základe typu

`switch` môže byť tiež použitý na výber na základe typu objektu. Ak chcete toto urobiť, použite `switch` s `case` a `when`.

```csharp
object shape = new Circle();

switch (shape)
{
    case Circle c:
        Console.WriteLine($"It's a circle with radius {c.Radius}");
        break;
    case Rectangle r when r.Width == r.Height:
        Console.WriteLine($"It's a square with side {r.Width}");
        break;
    case Rectangle r:
        Console.WriteLine($"It's a rectangle with width {r.Width} and height {r.Height}");
        break;
    default:
        Console.WriteLine("Unknown shape");
        break;
}
```

V tomto príklade, `switch` kontroluje typ objektu `shape`. Ak je to `Circle`, program vypíše správu s polomerom kruhu. Ak je to `Rectangle` s rovnakou šírkou a výškou, vypíše, že je to štvorec. Ak je to `Rectangle` s rôznou šírkou a výškou, vypíše, že je to obdĺžnik. Ak to nie je ani jeden z týchto typov, vypíše `"Unknown shape"`.

## Zhrnutie

`switch` je silný nástroj pre výber jednej z mnohých možností na základe hodnoty premennej alebo výrazu. Umožňuje jednoduchý výber a čítačku kódu na základe mnohých možností. Od verzie C# 8.0 môžete použiť `switch` expressions pre jednoduché priradenie hodnôt na základe výsledku `switch`.

## Cvičenie: Hodnotenie filmov

Vašou úlohou v tomto cvičení je implementovať metódu `GetRatingDescription` triedy `MovieRating`, ktorá berie ako parameter celé číslo reprezentujúce hodnotenie filmu a vráti reťazec opisujúci toto hodnotenie.

Hodnotenia sú nasledovné:

- 1: "Veľmi zlý"
- 2: "Zlý"
- 3: "Priemerný"
- 4: "Dobrý"
- 5: "Výborný"

Pre všetky iné hodnoty metóda by mala vrátiť reťazec "Neplatné hodnotenie".

Trieda `MovieRating` sa nachádza v adresári `src\AppsLab-014-Switch` vo vašom pracovnom adresári. Implementujte túto metódu tak, aby splňovala vyššie uvedené požiadavky.

V rámci tohto cvičenia budete potrebovať použiť príkaz `switch` na určenie, aký reťazec vrátiť na základe hodnotenia.

Toto je štruktúra metódy, ktorú budete potrebovať implementovať:

```csharp
public string GetRatingDescription(int rating)
{
    throw new NotImplementedException();
}
```

Po implementácii tejto metódy skontrolujte svoju prácu pomocou unit testov v projekte `tests\AppsLab-014-Switch.Tests`. Ak všetky testy prejdú, vaše riešenie je správne. Ak niektorý z testov zlyhá, prečítajte si správu o chybe a skúste svoje riešenie opraviť.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

## Ďalšie štúdium

Pre viac informácií o `switch` navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Selection statements - if, if-else, and switch](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať podmienky v C#.

## Bonusové cvičenia

Samozrejme, tu je niekoľko bonusových cvičení, ktoré si môžete vyskúšať pre precvičenie práce so `switch` v jazyku C#:

1. **Kalkulačka**
   Vytvorte jednoduchú kalkulačku, ktorá na základe zadaného operátora (`+`, `-`, `*`, `/`) vykoná matematickú operáciu medzi dvoma číslami. Použite príkaz `switch` pre určenie operácie na základe zadaného operátora.

2. **Rozpoznávanie tvarov**
   Vytvorte program, ktorý na základe počtu strán určí názov tvaru. Napríklad, pre číslo 3 by mal vrátiť `"trojuholník"`, pre číslo 4 `"štvorec"` atď. Pre počet strán väčší ako 10 môže program vrátiť `"mnohouholník"`.

3. **Smer kompasu**
   Napíšte program, ktorý na základe zadanej hodnoty určí smer kompasu. Pre hodnotu 0 by mal vrátiť `"Sever"`, pre hodnotu 90 `"Východ"`, pre hodnotu 180 `"Juh"` a pre hodnotu 270 `"Západ"`. Pre iné hodnoty môže vrátiť `"Neplatný smer"`.

4. **Prevodník mesiacov**
   Vytvorte program, ktorý na základe čísla mesiaca (1 - 12) vráti názov mesiaca. Pre číslo 1 by mal vrátiť `"Január"`, pre číslo 2 `"Február"` atď.

Skúste si tieto úlohy vyskúšať a uvidíte, ako dobre ovládate prácu so `switch` v jazyku C#.

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
