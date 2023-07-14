# Generické typy (Generic types) v `C#`

## Čo sú Generické typy

Generické typy sú jedným z najdôležitejších konceptov v C#, ktorý umožňuje vytvárať triedy, štruktúry, rozhrania a metódy, ktoré môžu pracovať s akýmkoľvek typom, pričom typ sa špecifikuje neskôr pri vytváraní objektu. Generické typy sú široko využívané v C# a .NET, napríklad v kolekciách ako `List<T>` alebo `Dictionary<TKey, TValue>`.

## Ako sa vytvárajú a používajú generické typy

Generické typy sa vytvárajú pomocou tzv. placeholdera pre typ, ktorý sa značí `<T>`. `T` je len konvencia, môže to byť akýkoľvek platný identifikátor, ale často sa používa `T` pre jednoduchosť. Napríklad, môžeme vytvoriť vlastnú generickú triedu `Box<T>` takto:

```csharp
public class Box<T>
{
    private T item;

    public void SetItem(T newItem)
    {
        item = newItem;
    }

    public T GetItem()
    {
        return item;
    }
}
```

V tejto triede môžeme použiť metódu `SetItem` na uloženie hodnoty akéhokoľvek typu do `item` a metódu `GetItem` na vrátenie tejto hodnoty.

Použitie tejto triedy by potom mohlo vyzerať takto:

```csharp
var box1 = new Box<int>();
box1.SetItem(5);
Console.WriteLine(box1.GetItem());  // vypíše: 5

var box2 = new Box<string>();
box2.SetItem("Hello");
Console.WriteLine(box2.GetItem());  // vypíše: Hello
```

Vidíme, že keď vytvárame objekt triedy `Box<T>`, musíme špecifikovať, čo `T` bude. V prvom príklade sme použili `int` a v druhom príklade `string`.

## Prečo sú generické typy dôležité

Generické typy sú veľmi dôležité pretože nám umožňujú vytvárať kód, ktorý je flexibilný a znovupoužiteľný. Bez generických typov by sme museli pre každý typ, s ktorým chceme pracovať, vytvoriť samostatnú triedu alebo metódu, čo by viedlo k veľkému množstvu duplicitného kódu. Generické typy nám tiež umožňujú pracovať s typmi bezpečným spôsobom, pretože všetky kontroly typov sa vykonávajú počas kompilácie.

## Ako pracovať s viacerými generickými typmi

Môžeme pracovať aj s viacerými generickými typmi naraz. Napríklad, môžeme vytvoriť triedu `Pair<TFirst, TSecond>`, ktorá ukladá dve hodnoty rôznych typov:

```csharp
public class Pair<TFirst, TSecond>
{
    public TFirst First { get; set; }
    public TSecond Second { get; set; }
}
```

A potom ju môžeme použiť takto:

```csharp
var pair = new Pair<int, string> { First = 1, Second = "one" };
Console.WriteLine(pair.First);    // vypíše: 1
Console.WriteLine(pair.Second);   // vypíše: one
```

## Generické rozhrania

Rovnako ako triedy, aj rozhrania môžu byť generické. To znamená, že môžu prijímať jeden alebo viac typov.

Pozrime sa na príklad generického rozhrania:

```csharp
public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    IEnumerable<T> GetAll();
}
```

Toto rozhranie by mohlo byť použité v rôznych situáciách, napríklad pri práci s databázou alebo pri manipulácii s kolekciami v pamäti.

## Generické metódy

Rovnako ako triedy a rozhrania, aj metódy môžu byť generické. To znamená, že môžu pracovať s rôznymi typmi dát. Generické metódy sú užitočné, keď chceme vytvoriť metódu, ktorá môže pracovať s rôznymi typmi, ale vykonáva rovnakú logiku bez ohľadu na konkrétny typ.

Napríklad, môžeme vytvoriť generickú metódu `PrintItems<T>`, ktorá vypíše všetky položky v kolekcii nezávisle na ich type:

```csharp
public void PrintItems<T>(IEnumerable<T> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
```

Túto metódu môžeme potom použiť takto:

```csharp
PrintItems(new List<int> { 1, 2, 3 });       // vypíše: 1, 2, 3
PrintItems(new List<string> { "a", "b" });   // vypíše: a, b
```

## Obmedzenia na generické typy

V niektorých prípadoch môžeme chcieť obmedziť, aké typy môžu byť použité ako parametre pre naše generické triedy, rozhrania alebo metódy. To môžeme dosiahnuť pomocou tzv. obmedzení na generické typy (constraints).

Napríklad, môžeme chcieť vytvoriť generickú triedu `Comparer<T>`, ktorá porovnáva dve hodnoty, ale chceme zabezpečiť, že typ `T` implementuje rozhranie `IComparable<T>`. To môžeme dosiahnuť takto:

```csharp
public class Comparer<T> where T : IComparable<T>
{
    public int Compare(T x, T y)
    {
        return x.CompareTo(y);
    }
}
```

Teraz môžeme použiť triedu `Comparer<T>` len s typmi, ktoré implementujú `IComparable<T>`:

```csharp
var intComparer = new Comparer<int>();
Console.WriteLine(intComparer.Compare(1, 2));  // vypíše: -1

var stringComparer = new Comparer<string>();
Console.WriteLine(stringComparer.Compare("a", "b"));  // vypíše: -1
```

Pokiaľ sa pokúsite použiť `Comparer<T>` s typom, ktorý `IComparable<T>` neimplementuje, kompilátor vás upozorní na chybu.

Generické typy v C# sú veľmi mocný nástroj, ktorý umožňuje vytvárať flexibilný a znovupoužiteľný kód. Vďaka nim môžeme napríklad pracovať s kolekciami rôznych typov v jednotnom a type-safe spôsobe, alebo vytvárať všeobecné API, ktoré môže pracovať s rôznymi typmi.

## Ďalšie štúdium

Pre viac informácií o generikách navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Generic classes and methods](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať generiká v C#.

## Možné úlohy na precvičenie práce s generikami

Tu je zoznam niektorých cvičení s vysvetlením, ako ich použiť:

1. **Simulácia balíčka kariet**: Môžete vytvoriť generickú triedu "Deck", kde každá karta je inštancia generického typu. Metódy na zamiešanie a ťahanie kariet môžu byť tiež generické.

2. **Vytvorenie jednoduchého automatu na nápoje**: Generická trieda "Automat" môže byť vytvorená s generickými metodami pre výber nápoja a vrátenie mincí.

3. **Vytvorenie jednoduchého knižného fondu**: Vytvorte generickú triedu "Library" a generické metódy na pridávanie a odstraňovanie kníh, nech sú knihy reprezentované akýmkoľvek typom.

4. **Implementácia hry "Hádaj číslo"**: Generická trieda "Game" by mohla byť vytvorená s generickými metodami na začatie hry, overenie hádania a ukončenie hry.

5. **Simulácia jednoduchého hudobného playlistu**: Generická trieda "Playlist" by mohla obsahovať generickú kolekciu piesní. Metódy pre pridanie, odstránenie a premiešanie piesní by mohli byť tiež generické.

6. **Vytvorenie jednoduchého RPG bojového systému**: Vytvorte generickú triedu "BattleSystem" s generickými metodami na výber útoku, obrany a liečenia.

7. **Simulácia jednoduchého nákupného košíka**: Generická trieda "ShoppingBasket" by mohla byť vytvorená s generickými metodami na pridávanie a odstraňovanie položiek.

8. **Vytvorenie jednoduchého šachového programu**: Generická trieda "Chess" by mohla byť vytvorená s generickými metodami na pohyb šachových figúrok.

9. **Simulácia jednoduchého počítačového systému**: Generická trieda "Computer" by mohla byť vytvorená s generickými metodami na pridávanie a odstraňovanie komponentov.

10. **Vytvorenie jednoduchého programu na kreslenie geometrických tvarov**: Generická trieda "Painter" by mohla byť vytvorená s generickými metodami na kreslenie rôznych tvarov.

Používaním generických tried a metód vo vašich cvičeniach môžete vytvárať viac flexibilný a znovupoužiteľný kód. V prípade generických tried a metód je dôležité dbať na to, aby sa tieto typy používali tam, kde majú skutočne zmysel a pridávajú hodnotu kódu.

Pracujte v konzolovom projekte `src\AppsLab-027-Generics`.

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
