# Práca s `List<T>`

## Čo je `List<T>`?

`List<T>` je veľmi populárna a často používaná dátová štruktúra v jazyku C#. Je to dynamické pole, čo znamená, že môže meniť svoju veľkosť počas behu programu. `"T"` je tzv. generický typ, ktorý umožňuje pracovať s rôznymi typmi dát. Môže to byť akýkoľvek typ, napríklad `int`, `string`, `bool`, alebo aj vlastné vytvorené triedy.

## Kedy a ako použiť `List<T>`?

`List<T>` je veľmi všestranný a je užitočný v mnohých situáciách. Môže sa použiť napríklad na ukladanie viacerých hodnôt rovnakého typu, na prácu s kolekciami dát alebo na efektívne manipulovanie s veľkými množstvami dát.

## Príklady použitia

Vytváranie nového zoznamu je jednoduché, ako je zobrazené v nasledujúcom príklade:

```csharp
List<int> numbers = new List<int>();
```

Teraz máme prázdny zoznam čísel. Prvky do zoznamu môžeme pridať použitím metódy `Add`:

```csharp
numbers.Add(5);
numbers.Add(10);
numbers.Add(15);
```

Na výpis prvkov zoznamu môžeme použiť napr. metódu `ForEach` a `Console.WriteLine`:

```csharp
numbers.ForEach(Console.WriteLine);
```

V tomto príklade sme pridali tri čísla do zoznamu a potom ich vypísali. Ako vidíte, práca s `List<T>` je veľmi jednoduchá a intuitívna.

Ak chceme získať konkrétny prvok zo zoznamu, môžeme to urobiť pomocou indexu, podobne ako pri poliach, napríklad:

```csharp
int firstNumber = numbers[0]; // získame prvý prvok zo zoznamu
```

Môžeme tiež zistiť, koľko prvkov je v zozname, pomocou property (vlastnosti) `Count`:

```csharp
int count = numbers.Count; // zistíme počet prvkov v zozname
```

Ďalšou výhodou `List<T>` je možnosť použitia viacerých funkcií, ktoré sú k dispozícii pre prácu s dátami.

Predstavme si, že chceme vymazať konkrétny prvok zo zoznamu. Môžeme na to použiť metódu `Remove`:

```csharp
numbers.Remove(10); // odstráni číslo 10 zo zoznamu
```

Alebo ak chceme vymazať prvok na konkrétnej pozícii, môžeme použiť metódu `RemoveAt`:

```csharp
numbers.RemoveAt(0); // odstráni prvok na indexe 0
```

Ak chcete vložiť prvok na konkrétnu pozíciu v zozname, môžete použiť metódu `Insert`:

```csharp
numbers.Insert(1, 20); // vloží číslo 20 na druhú pozíciu v zozname
```

Na otestovanie, či zoznam obsahuje konkrétnu hodnotu, môžeme použiť metódu `Contains`:

```csharp
bool hasFive = numbers.Contains(5); // vráti true, ak zoznam obsahuje číslo 5, inak vráti false
```

Ako vidíte, `List<T>` poskytuje množstvo funkcií, ktoré vám pomôžu efektívne manipulovať s dátami. Všetko, čo potrebujete, je pochopiť, ako tieto funkcie fungujú a kedy ich použiť. Práca s `List<T>` je jednou z najzákladnejších zručností, ktoré by ste mali ovládať pri práci s jazykom C#.

## Zhrnutie

V tomto tutoriále sme sa zoznámili s dátovou štruktúrou `List<T>` v jazyku C#. Ukázali sme si, ako vytvoriť zoznam, ako pridať, odstrániť a vložiť prvky, ako zistiť, či zoznam obsahuje konkrétnu hodnotu, a ako zistiť počet prvkov v zozname.

## Cvičenie: Práca so zoznamom mien

V tomto cvičení budete vytvárať jednoduchú konzolovú aplikáciu, ktorá bude obsahovať zoznam mien. Na manipuláciu so zoznamom budeme používať triedu `List<string>`.

Cieľom je naučiť sa prácu so zoznamom v praxi a zároveň si trochu viac "pohrať" s konzolovými vstupmi a výstupmi.

Vašou úlohou je v súbore `Program.cs` pod adresárom `"src\AppsLab-017-List"` pripraviť konzolovú aplikáciu, ktorá bude obsahovať zoznam mien. Aplikácia by mala umožniť užívateľovi pridať, odstrániť alebo skontrolovať prítomnosť mena v zozname a zároveň vypísať všetky mená zo zoznamu.

Aplikácia by mala byť postavená tak, že po spustení sa zobrazí hlavné menu s možnosťami:

- `1 - Pridať meno`
- `2 - Odstrániť meno`
- `3 - Skontrolovať prítomnosť mena`
- `4 - Vypísať všetky mená`
- `0 - Ukončiť program`

Pri výbere jednotlivých možností by sa malo správne zavolať dané spracovanie pre zoznam mien.

Toto cvičenie by vám malo pomôcť lepšie porozumieť práci so zoznamom a zároveň vám ukáže, ako pracovať s konzolovými vstupmi a výstupmi v jazyku C#. Veľa šťastia!

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

## Ďalšie štúdium

Pre viac informácií o `List<T>` navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[List<T> Class](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať listy v C#.
