# Indexátori (Indexers) v `C#`

## Úvod

V niektorých prípadoch môže byť užitočné pristupovať k niektorým hodnotám vo vašom objekte rovnakým spôsobom, ako by ste pristupovali k položkám v poli. C# vám umožňuje definovať indexátory v triedach a štruktúrach na poskytnutie poli-podobného prístupu k dátam. To sa môže hodiť pri vytváraní vlastných kolekčných typov.

## Syntax

Syntax indexátorov je veľmi podobná metódam s get a set prístupovými metódami. Avšak, namiesto definovania mena pre metódu, použijete kľúčové slovo `this` a definujete typ a počet indexov.

```csharp
public class MyCollection
{
    private int[] data = new int[10];

    public int this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}
```

V tomto príklade je `MyCollection` trieda, ktorá má indexátor, ktorý pracuje rovnako ako jednoduché pole. Používateľ môže pristupovať k položkám v `data` priamo cez objekt `MyCollection`, ako by to bolo pole.

```csharp
MyCollection collection = new MyCollection();
collection[0] = 1;
Console.WriteLine(collection[0]);  // Vypíše: 1
```

## Indexátory s viacerými parametrami

Indexátory môžu mať viacero parametrov, čo umožňuje pristupovať k dátam na základe viacerých indexov. Napríklad, môžeme mať triedu `Matrix`, ktorá má dvojrozmerné pole a chceme pristupovať k hodnotám na základe dvoch indexov.

```csharp
public class Matrix
{
    private int[,] data = new int[10, 10];

    public int this[int row, int column]
    {
        get { return data[row, column]; }
        set { data[row, column] = value; }
    }
}

Matrix matrix = new Matrix();
matrix[0, 0] = 1;
Console.WriteLine(matrix[0, 0]);  // Vypíše: 1
```

Takýto prístup je bežný v matematických aplikáciách alebo pri práci s maticami v počítačovej grafike.

## Použitie

Indexátory sa najčastejšie používajú pri implementácii vlastných kolekcií, kontajnerov alebo dátových štruktúr, kde je prirodzené pristupovať k dátam pomocou indexu alebo kľúča. Sú však aj situácie, kedy sa indexátory používajú na prístup k špecifickým členom objektu, ktoré sú na základe nejakého indexu alebo kľúča.

### Príklad použitia indexátorov

Predstavme si, že máme triedu `Students`, ktorá obsahuje zoznam študentov. Chceme vytvoriť spôsob, ako jednoducho pristupovať k študentom na základe ich mena. Môžeme vytvoriť indexátor, ktorý nám to umožní.

```csharp
public class Students
{
    private Dictionary<string, string> data = new Dictionary<string, string>();

    public string this[string name]
    {
        get { return data.ContainsKey(name) ? data[name] : null; }
        set { data[name] = value; }
    }
}
```

Použitie by potom vyzeralo takto:

```csharp
Students students = new Students();
students["Jozef"] = "Maturita z matematiky: 1";
Console.WriteLine(students["Jozef"]);  // Vypíše: Maturita z matematiky: 1
```

Všimnite si, že v tomto prípade používame indexátor s typom `string`. Toto nám umožňuje pristupovať k študentom priamo cez ich meno.

## Ďalšie štúdium

Pre viac informácií o indexátoroch navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Indexers (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať indexátory v C#.

## Možné úlohy na precvičenie práce s indexátormi

Tu je uvedený zoznam cvičení, ktoré by mohli byť využité na precvičenie indexov:

1. **Simulácia balíka kariet**: Vytvorte triedu, ktorá reprezentuje balík kariet. Pri tomto cvičení by sa indexovanie mohlo využiť na prístup k jednotlivým kartám v balíku.

2. **Simulácia knižnice**: Vytvorte triedu, ktorá reprezentuje jednoduchú knižnicu. Indexer by mohol byť použitý na prístup k jednotlivým knihám v knižnici.

3. **Hudobný playlist**: Vytvorte triedu, ktorá reprezentuje jednoduchý hudobný playlist. Indexovanie by umožnilo prístup k jednotlivým skladbám v playliste.

4. **Nakupovací vozík**: Vytvorte triedu, ktorá simuluje jednoduchý nakupovací vozík. Pomocou indexera by sa mohlo pristupovať k jednotlivým položkám v nákupnom vozíku.

5. **Šachová hra**: Implementujte program, ktorý simuluje základnú šachovú hru. Indexovanie by sa mohlo použiť na prístup k jednotlivým políčkam na šachovnici.

Ako príklad, môžeme si predstaviť triedu `DeckOfCards` (Balík kariet), ktorá by mohla využiť indexer na prístup k jednotlivým kartám:

```csharp
public class DeckOfCards
{
    private Card[] cards;

    public DeckOfCards()
    {
        // Initialize the cards array...
    }

    // This is the indexer.
    public Card this[int i]
    {
        get { return cards[i]; }
        set { cards[i] = value; }
    }
}
```

Potom môžeme použiť triedu `DeckOfCards` takto:

```csharp
DeckOfCards deck = new DeckOfCards();
Card firstCard = deck[0]; // Get the first card.
```

Indexer nám teda umožňuje pracovať s objektom triedy `DeckOfCards` rovnako ako by to bol bežný pole.

Pracujte v konzolovom projekte `src\AppsLab-028-Indexers`.

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
