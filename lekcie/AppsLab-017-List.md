# Práca s `List<T>`

## Čo je `List<T>`?

`List<T>` je veľmi populárna a často používaná dátová štruktúra v jazyku C#. Je to dynamické pole, čo znamená, že môže meniť svoju veľkosť počas behu programu. `"T"` je tzv. generický typ, ktorý umožňuje pracovať s rôznymi typmi dát. Môže to byť akýkoľvek typ, napríklad `int`, `string`, `bool`, alebo aj vlastné vytvorené triedy.

## Kedy a ako použiť `List<T>`?

`List<T>` je veľmi všestranný a je užitočný v mnohých situáciách. Môže sa použiť napríklad na ukladanie viacerých hodnôt rovnakého typu, na prácu s kolekciami dát alebo na efektívne manipulovanie s veľkými množstvami dát.

## Príklady použitia

### Deklarácia

Vytváranie nového zoznamu je jednoduché, ako je zobrazené v nasledujúcom príklade:

```csharp
List<int> numbers = new List<int>();
```

### Pridávanie prvkov

Teraz máme prázdny zoznam čísel. Prvky do zoznamu môžeme pridať použitím metódy `Add`:

```csharp
numbers.Add(5);
numbers.Add(10);
numbers.Add(15);
```

V tomto príklade sme pridali tri čísla do zoznamu a potom ich vypísali. Ako vidíte, práca s `List<T>` je veľmi jednoduchá a intuitívna.

### Výpis prvkov

Na výpis prvkov zoznamu môžeme použiť napr. metódu `ForEach` a `Console.WriteLine`:

```csharp
numbers.ForEach(Console.WriteLine);
```

### Čítanie prvku na konkrétnej pozícii

Ak chceme získať konkrétny prvok zo zoznamu, môžeme to urobiť pomocou indexu, podobne ako pri poliach, napríklad:

```csharp
int firstNumber = numbers[0]; // získame prvý prvok zo zoznamu
```

### Počet prvkov

Môžeme tiež zistiť, koľko prvkov je v zozname, pomocou property (vlastnosti) `Count`:

```csharp
int count = numbers.Count; // zistíme počet prvkov v zozname
```

### Odstránenie prvku

Predstavme si, že chceme vymazať konkrétny prvok zo zoznamu. Môžeme na to použiť metódu `Remove`:

```csharp
numbers.Remove(10); // odstráni číslo 10 zo zoznamu
```

### Odstránenie prvku na konkrétnej pozícii

Alebo ak chceme vymazať prvok na konkrétnej pozícii, môžeme použiť metódu `RemoveAt`:

```csharp
numbers.RemoveAt(0); // odstráni prvok na indexe 0
```

### Vloženie prvku na konkrétnu pozíciu

Ak chcete vložiť prvok na konkrétnu pozíciu v zozname, môžete použiť metódu `Insert`:

```csharp
numbers.Insert(1, 20); // vloží číslo 20 na druhú pozíciu v zozname
```

### Kontrola, či zoznam obsahuje prvok

Na otestovanie, či zoznam obsahuje konkrétnu hodnotu, môžeme použiť metódu `Contains`:

```csharp
bool hasFive = numbers.Contains(5); // vráti true, ak zoznam obsahuje číslo 5, inak vráti false
```

### Triedenie zoznamu

Pozrime sa na to, ako je možné zoradiť čísla v zozname. C# poskytuje metódu `Sort()`, ktorú môžete zavolať na objekte typu `List<T>`.

Predstavme si, že máme `List<int>` s názvom `numbers`, ktorý obsahuje nasledovné hodnoty: `4, 2, 9, 6`.

```csharp
List<int> numbers = new List<int> {4, 2, 9, 6};
```

Ak chceme zoradiť tento zoznam od najmenšieho po najväčšie číslo, použijeme metódu `Sort()`:

```csharp
numbers.Sort();
```

Po zavolaní tejto metódy bude náš zoznam `numbers` vyzerať nasledovne: `2, 4, 6, 9`.

Ak by sme chceli zoradiť čísla v opačnom poradí (od najväčšieho po najmenšie), môžeme použiť metódu `Reverse()`:

```csharp
numbers.Reverse();
```

Po zavolaní tejto metódy bude náš zoznam `numbers` vyzerať nasledovne: `9, 6, 4, 2`.

Je dôležité si uvedomiť, že metódy `Sort()` a `Reverse()` menia pôvodný zoznam, nie vracajú nový zoznam. Ak nechcete zmeniť pôvodný zoznam, budete musieť skopírovať zoznam do nového zoznamu pred zoradením alebo reverzíciou.

Tiež je možné zoradiť zoznam podľa vlastnej funkcie porovnávania, ale to je pokročilé téma, ktoré by ste mohli preskúmať po zvládnutí základov.

## Zhrnutie

Ako vidíte, `List<T>` poskytuje množstvo funkcií, ktoré vám pomôžu efektívne manipulovať s dátami. Všetko, čo potrebujete, je pochopiť, ako tieto funkcie fungujú a kedy ich použiť. Práca s `List<T>` je jednou z najzákladnejších zručností, ktoré by ste mali ovládať pri práci s jazykom C#.

V tomto tutoriále sme sa zoznámili s dátovou štruktúrou `List<T>` v jazyku C#. Ukázali sme si, ako vytvoriť zoznam, ako pridať, odstrániť a vložiť prvky, ako zistiť, či zoznam obsahuje konkrétnu hodnotu, a ako zistiť počet prvkov v zozname.

## Cvičenie: Implementácia fronty (Queue) pomocou `List<T>`

V tomto cvičení budete pracovať na implementácii základnej fronty (Queue) pomocou triedy `List<string>`. Fronta je špeciálny typ dátového štruktúru, ktorý pracuje na princípe FIFO (First-In, First-Out). Toto znamená, že prvok, ktorý je pridaný ako prvý, bude aj prvý odstránený.

Vašou úlohou je v triede `Queue` implementovať dve metódy: `Enqueue(string item)` a `Dequeue()`.

Metóda `Enqueue(string item)` pridáva prvok na koniec fronty. Metóda `Dequeue()` odstraňuje prvok zo začiatku fronty a vracia ho.

Zdrojový kód pre triedu `Queue` je už vytvorený v projekte konzolovej aplikácie `"src\AppsLab-017-List"`, avšak nebude použitý v konzolovej aplikácii - namiesto toho budeme overovať jeho správnosť pomocou unit testov.

Toto cvičenie vám poskytne praktickú skúsenosť s prácou so zoznamom a zároveň vám umožní lepšie pochopiť, ako funguje fronta.

**Vysvetlenie:**

1. `private List<string> elements;` je field v našej triede `Queue`. Fields, tiež známe ako dátové členy triedy alebo atribúty, sú premenné, ktoré uchovávajú dáta, ktoré sú relevantné pre objekty danej triedy. V tomto prípade je `elements` zoznam reťazcov, ktorý uchováva prvky našej fronty.

    `private` je modifikátor prístupu, ktorý určuje, kde je pole viditeľné alebo prístupné. Keď je pole označené ako `private`, znamená to, že je prístupné len z metód v rámci rovnakej triedy. Inými slovami, iba metódy v triede `Queue` môžu pristupovať k tomuto poľu. To je užitočné pre zapuzdrenie alebo skrytie vnútorných detailov triedy a zabránenie neoprávnenému prístupu k dátam.

2. `public Queue() {..}` je konštruktor triedy `Queue`. Konštruktory sú špeciálne metódy v triede, ktoré sa automaticky vyvolajú pri vytváraní novej inštancie triedy (nového objektu). Slúžia hlavne na inicializáciu fieldu triedy. V tomto prípade konštruktor `Queue()` inicializuje náš field `elements` ako nový zoznam reťazcov. Bez tohto konštruktora by náš field `elements` zostal neinicializovaný a ak by sme sa pokúsili na ňom vykonať akúkoľvek operáciu, program by vygeneroval výnimku - chybu.

Po dokončení implementácie si môžete svoju prácu otestovať pomocou unit testov, ktoré sú k dispozícii v projekte `AppsLab-017-List.Tests`.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

## Bonusové cvičenie: Práca so zoznamom mien

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
