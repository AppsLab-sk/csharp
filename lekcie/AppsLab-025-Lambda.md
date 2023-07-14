# Lambda výrazy (Lambda Expressions) v `C#`

Lambda výrazy (lambda expressions) sú veľmi silnou súčasťou C# a LINQ, ale aj iných moderných programovacích jazykov.

## Čo je to Lambda výraz?

Lambda výrazy v jazyku C# sú funkcie, ktoré môžu byť použité ako argumenty metód alebo priradené k premenným. Sú kompaktné a môžu byť použité na manipuláciu s údajmi v rôznych kontextoch.

Lambda výrazy sú bežne používané pri práci s kolekciami údajov, pri programovaní asynchrónnych operácií a v mnohých ďalších situáciách.

Lambda výrazy môžu byť použité na vytvorenie jednoduchých funkcií alebo metód. Lambda výraz je tvorený parametrami (vstupmi), operátorom lambda `=>` a telom funkcie.

## Príklad lambda výrazu

```csharp
x => x * x
```

Tento lambda výraz má jeden parameter `x` a vráti druhú mocninu tohoto parametra.

Ak máme viacero parametrov, musíme ich zahrnúť do zátvoriek, napríklad:

```csharp
(x, y) => x * y
```

Tento lambda výraz prijme dva parametre `x` a `y` a vráti ich súčin.

## Použitie lambda výrazov

Lambda výrazy sa často používajú pri práci s kolekciami údajov. Vďaka nim môžeme jednoducho filtrovať, triediť alebo transformovať údaje.

Ukážeme si, ako môžeme použiť lambda výrazy na filtrovanie zoznamu čísel.

Predstavme si, že máme nasledujúci zoznam čísel:

```csharp
List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
```

Chceme nájsť všetky párne čísla v tomto zozname. To môžeme dosiahnuť pomocou metódy `Where` a lambda výrazu:

```csharp
List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}
```

V tomto prípade `n => n % 2 == 0` je lambda výraz, ktorý slúži ako filter. Pre každé číslo `n` v našom zozname sa vyhodnotí, či je párne. Ak je, je pridané do nového zoznamu `evenNumbers`.

Všimni si, že tento kód je veľmi čitateľný a kompaktný. To je jednou z výhod použitia lambda výrazov v jazyku C#.

V konzolovej aplikácii "AppsLab-025-Lambda" môžeš skúsiť použiť tieto lambda výrazy, aby si lepšie porozumel tomu, ako fungujú.

Teraz sa pozrime na niekoľko ďalších príkladov, ktoré ukazujú, ako môžeme používať lambda výrazy v rôznych situáciách.

## Transformácia zoznamu čísel

Predstavme si, že chceme každé číslo v našom zozname umocniť na druhú. To môžeme dosiahnuť pomocou metódy `Select` a lambda výrazu:

```csharp
List<int> squaredNumbers = numbers.Select(n => n * n).ToList();

foreach (var num in squaredNumbers)
{
    Console.WriteLine(num);
}
```

V tomto prípade `n => n * n` je lambda výraz, ktorý sa používa na transformáciu každého čísla v našom zozname.

## Zoradenie zoznamu

Lambda výrazy môžeme použiť aj na zoradenie zoznamu. Napríklad, ak chceme zoradiť náš zoznam čísel v zostupnom poradí, môžeme to dosiahnuť pomocou metódy `OrderByDescending` a lambda výrazu:

```csharp
List<int> sortedNumbers = numbers.OrderByDescending(n => n).ToList();

foreach (var num in sortedNumbers)
{
    Console.WriteLine(num);
}
```

V tomto prípade `n => n` je lambda výraz, ktorý sa používa na definovanie, podľa čoho chceme zoradiť naše čísla. Keďže chceme zoradiť čísla podľa ich hodnoty, jednoducho vrátime hodnotu `n`.

Teraz, keď máme základné pochopenie o tom, ako fungujú lambda výrazy a kde ich môžeme použiť, môžeme prejsť na niektoré pokročilejšie koncepty, ako je vytváranie vlastných lambda funkcií.

## Vytváranie vlastných lambda funkcií

Lambda výrazy nie sú obmedzené len na použitie s metódami, ako sú `Select`, `OrderBy` atď. Môžete ich použiť aj na vytváranie vlastných funkcií.

Predstavte si, že chcete vytvoriť funkciu, ktorá zistí, či je číslo deliteľné troma. To môžete urobiť pomocou lambda výrazu:

```csharp
Func<int, bool> isDivisibleByThree = n => n % 3 == 0;

Console.WriteLine(isDivisibleByThree(9));  // vypíše: True
Console.WriteLine(isDivisibleByThree(10)); // vypíše: False
```

V tomto príklade `Func<int, bool>` je typ našej funkcie. Tento typ nám hovorí, že funkcia prijíma jeden parameter typu `int` a vracia hodnotu typu `bool`. `n => n % 3 == 0` je naša lambda funkcia, ktorá prijíma číslo a vráti `true`, ak je toto číslo deliteľné troma, inak vráti `false`.

## Použitie viacerých parametrov

Lambda výrazy môžu prijať aj viacero parametrov. Napríklad, môžeme vytvoriť funkciu, ktorá sčíta dve čísla:

```csharp
Func<int, int, int> add = (x, y) => x + y;

Console.WriteLine(add(3, 4));  // vypíše: 7
```

V tomto prípade `(x, y) => x + y` je lambda funkcia, ktorá prijíma dva parametre a vráti ich súčet. Môžeme vidieť, že parametre sú oddelené čiarkou a ohraničené zátvorkami.

## Použitie bez parametrov

Lambda výrazy môžu byť aj bez parametrov. V tomto prípade používame prázdne zátvorky `()` na označenie, že funkcia neprijíma žiadne parametre:

```csharp
Action sayHello = () => Console.WriteLine("Ahoj!");

sayHello();  // vypíše: Ahoj!
```

V tomto prípade `() => Console.WriteLine("Ahoj!")` je lambda funkcia, ktorá neprijíma žiadne parametre a vypíše na konzolu slovo `"Ahoj!"`. Môžeme vidieť, že na vytvorenie takéhoto lambda výrazu používame typ `Action`, ktorý označuje funkciu bez návratovej hodnoty.

Teraz, keď vieme, ako vytvárať vlastné lambda funkcie, môžeme začať experimentovať a vytvárať vlastné komplexnejšie funkcie.

## Ďalšie štúdium

Pre viac informácií o lambda výrazoch navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Lambda expressions and anonymous functions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať lambda výrazy v C#.

## Možné úlohy na precvičenie práce s lambda výrazmi

Niektoré z týchto cvičení môžu byť upravené tak, aby boli vhodné na precvičenie práce s lambda výrazmi v C#. Tu sú niektoré príklady:

1. **Textové dobrodružstvo**: Vytvor aplikáciu, ktorá filtruje zoznam príkazov od užívateľa pomocou lambda výrazov.

2. **Test rýchlosti písania**: Použi lambda výrazy na porovnanie rýchlosti písania užívateľa s priemernou rýchlosťou.

3. **Virtuálne zviera**: Implementuj funkciu, ktorá kontroluje, či je zviera hladné, unavené atď., pomocou lambda výrazov.

Pracujte v konzolovom projekte `src\AppsLab-025-Lambda`.

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
