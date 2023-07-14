# LINQ v `C#`

## Úvod do LINQ

LINQ, alebo Language Integrated Query, je súčasťou .NET Framework, ktorá nám umožňuje pracovať s dátami efektívnym a čitateľným spôsobom. LINQ umožňuje vytvárať dotazy nad dátami bez ohľadu na to, kde sú dáta uložené alebo aký je ich formát.

## Základy LINQ

V základnej forme sa LINQ používa na filtrovanie, triedenie a transformáciu kolekcií v C#.

Predstavte si, že máme zoznam mien a chceme nájsť všetky mená, ktoré začínajú na písmeno "A". To by sme mohli urobiť takto:

```csharp
List<string> names = new List<string>() { "Anna", "Bob", "Alice", "Charlie" };

IEnumerable<string> namesStartingWithA = names.Where(n => n.StartsWith("A"));

foreach (string name in namesStartingWithA)
{
    Console.WriteLine(name);
}
```

V tomto príklade `Where` je metóda LINQ, ktorá filtruje zoznam mien. Použili sme lambda výraz `n => n.StartsWith("A")` na definovanie podmienky, ktorú musia splniť mená, aby sa dostali do výsledného zoznamu.

### `IEnumerable<T>`

`IEnumerable<string>` je rozhranie, ktoré predstavuje zoznam objektov, ktoré je možné prechádzať pomocou cyklu `foreach`. Všeobecnejšie povedané, `IEnumerable<T>` je rozhranie, ktoré reprezentuje sekvenciu hodnôt určitého typu `T` - v našom prípade je to `string`.

Tento typ sa často používa ako návratový typ pre metódy, ktoré vracajú zoznam hodnôt, a tiež v metódach LINQ, ako je `Where`, `Select`, `OrderBy` atď.

### Metóda `StartsWith`

`StartsWith` je metóda v triede `System.String` v .NET Framework. Táto metóda kontroluje, či reťazec začína konkrétnym podreťazcom. Napríklad:

```csharp
string name = "Alice";
bool startsWithA = name.StartsWith("A"); // vráti true
```

V tomto príklade metóda `StartsWith` vráti `true`, pretože reťazec `"Alice"` začína písmenom `"A"`.

V kontexte LINQ sa metóda `StartsWith` často používa v lambda výrazoch pri filtrovaní zoznamu reťazcov podľa toho, či začínajú konkrétnym podreťazcom.

## LINQ a lambda výrazy

Ako môžete vidieť, LINQ úzko spolupracuje s lambda výrazmi. LINQ metódy, ako je `Where`, `Select`, `OrderBy` atď., prijímajú lambda výrazy ako argumenty a tieto lambda výrazy definujú, ako sa majú tieto metódy správať.

## Používanie metódy `Select`

Metóda `Select` v LINQ sa používa na transformáciu prvkov kolekcie. Predstavte si, že máme triedu `Student`:

```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

A máme zoznam študentov:

```csharp
List<Student> students = new List<Student>()
{
    new Student { Name = "Anna", Age = 20 },
    new Student { Name = "Bob", Age = 22 },
    new Student { Name = "Charlie", Age = 18 }
};
```

Keď chceme získať zoznam mien študentov. Môžeme to urobiť pomocou metódy `Select`:

```csharp
IEnumerable<string> studentNames = students.Select(s => s.Name);

foreach (string name in studentNames)
{
    Console.WriteLine(name);
}
```

V tomto príklade `Select` prejde cez zoznam študentov a pre každého študenta vráti jeho meno. Výsledkom je zoznam mien študentov.

## Používanie metódy `OrderBy`

Metóda `OrderBy` v LINQ sa používa na usporiadanie prvkov kolekcie. Môžeme napríklad usporiadať študentov podľa ich veku:

```csharp
IEnumerable<Student> studentsByAge = students.OrderBy(s => s.Age);

foreach (Student student in studentsByAge)
{
    Console.WriteLine($"{student.Name}, {student.Age}");
}
```

V tomto príklade `OrderBy` prejde cez zoznam študentov a usporiada ich podľa veku. Výsledkom je zoznam študentov, ktorý je usporiadaný od najmladšieho po najstaršieho.

## Používanie metódy `GroupBy`

Metóda `GroupBy` v LINQ sa používa na zoskupenie prvkov kolekcie. Predstavte si, že chceme zoskupiť študentov podľa prvého písmena ich mena. Môžeme to urobiť takto:

```csharp
var studentsGrouped = students.GroupBy(s => s.Name[0]);

foreach (var group in studentsGrouped)
{
    Console.WriteLine($"Group {group.Key}:");

    foreach (var student in group)
    {
        Console.WriteLine($"{student.Name}, {student.Age}");
    }
}
```

V tomto príklade `GroupBy` vytvára nové skupiny študentov, kde každá skupina obsahuje študentov s menami, ktoré začínajú na rovnaké písmeno. Výsledkom je kolekcia skupín, kde každá skupina má kľúč (prvé písmeno mena) a zoznam študentov, ktorí patria do tejto skupiny.

Toto sú len niektoré z mnohých metód, ktoré LINQ ponúka. Ďalšie metódy zahŕňajú `First`, `Last`, `Single`, `Any`, `All`, `Count`, `Max`, `Min`, `Sum`, `Average` a mnoho ďalších. Všetky tieto metódy môžete použiť na efektívnu a čitateľnú prácu s dátami v C#.

## Ďalšie štúdium

Pre viac informácií o LINQ navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Language Integrated Query (LINQ) (C#)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať LINQ v C#.

## Možné úlohy na precvičenie práce s LINQ

Tu je zoznam niekoľkých cvičení s vysvetlením, ako ich použiť na precvičenie LINQ:

1. **Vytvorenie triedy, ktorá simuluje balíček kariet:** Môžete použiť LINQ na filtrovanie kariet podľa farby, hodnoty alebo typu.

2. **Vytvorenie triedy, ktorá simuluje jednoduchú knižnicu:** LINQ môžete použiť na vyhľadávanie kníh podľa názvu, autora alebo žánru.

3. **Vytvorenie triedy, ktorá simuluje jednoduchý hudobný playlist:** LINQ môžete použiť na usporadúvanie skladieb podľa umelca, žánru alebo dĺžky skladby.

4. **Vytvorenie triedy, ktorá simuluje zoo s rôznymi druhmi zvierat:** Môžete použiť LINQ na filtrovanie zvierat podľa druhu, veku alebo stravy.

5. **Vytvorenie programu, ktorý simuluje jednoduchý nákupný vozík:** LINQ môžete použiť na výpočet celkových nákladov, filtrovanie produktov podľa kategórie alebo zoradenie produktov podľa ceny.

6. **Vytvorenie triedy, ktorá simuluje jednoduchý počítačový systém s rôznymi komponentmi:** Môžete použiť LINQ na filtrovanie komponentov podľa typu, výrobcu alebo ceny.

7. **Vytvorenie triedy, ktorá simuluje jednoduchý systém rezervácie v kine:** LINQ môžete použiť na filtrovanie filmov podľa žánru, hodnotenia alebo dátumu vydania.

LINQ poskytuje rôzne metódy na manipuláciu s kolekciami dát, ako sú `Where` (pre filtrovanie), `OrderBy`/`OrderByDescending` (pre zoradenie), `Select` (pre transformáciu), `GroupBy` (pre zoskupenie) a ďalšie. Tieto metódy je možné použiť v rôznych kombináciách, aby ste dosiahli požadované výsledky.

Napríklad, ak chcete získať zoznam všetkých kníh v knižnici od určitého autora, môžete použiť LINQ nasledovne:

```csharp
var booksByAuthor = library.Books.Where(book => book.Author == "Dan Brown");
```

Alebo ak chcete usporiadať zvieratá v zoo podľa veku, môžete použiť:

```csharp
var animalsOrderedByAge = zoo.Animals.OrderBy(animal => animal.Age);
```

Pracujte v konzolovom projekte `src\AppsLab-026-LINQ`.

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
