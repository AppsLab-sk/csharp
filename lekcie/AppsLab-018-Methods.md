# Metódy v `C#`

V C# (a všeobecne v objektovo orientovaných programovacích jazykoch) sú metódy akcie, ktoré môžu objekty vykonať. Môžu prijať vstupné dáta, môžu vykonať nejakú akciu a môžu vrátiť nejaký výsledok.

## Ako vytvoriť metódu

Jednoduchú metódu vytvoríme tak, že najprv napíšeme prístupový modifikátor (napríklad `public` alebo `private`), potom typ návratovej hodnoty, názov metódy a zátvorky s prípadnými parametrami. Nakoniec pridáme telo metódy, ktoré je ohraničené zloženými zátvorkami `{}`.

```csharp
public void SayHello()
{
    Console.WriteLine("Ahoj svet!");
}
```

## Návratové hodnoty

Nie všetky metódy sú typu `void`. Niekedy chceme, aby metóda niečo vypočítala a vrátila nám výsledok. To dosiahneme zmenou `void` na typ návratovej hodnoty a použitím príkazu `return`.

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

Táto metóda prijíma dva parametre `a` a `b`, sčíta ich a vráti ich súčet.

## Parametre a argumenty

Parametre sú premenné, ktoré sú uvedené v definícii metódy. Sú to hodnoty, ktoré môže metóda prijať.

```csharp
public void Greet(string name)
{
    Console.WriteLine($"Ahoj, {name}!");
}
```

Keď voláme metódu, hodnoty, ktoré do nej vkladáme, sa nazývajú argumenty.

```csharp
Greet("Peter");
```

V tomto prípade je "Peter" argumentom pre metódu `Greet`.

## Spôsoby použitia metód

Metódy môžeme použiť na rôzne účely. Mohli by sme ich napríklad použiť na:

- Výpočet výsledku na základe určitých vstupov.
- Vykonať nejakú akciu, ako je napríklad výpis na konzolu.
- Organizáciu kódu do menších, prehľadnejších blokov.

Metódy sú kľúčovou súčasťou programovania a sú veľmi dôležité pre čitateľnosť a organizáciu kódu. Vždy, keď sa vám zdá, že niektorá časť vášho kódu sa opakuje, alebo je príliš komplikovaná, je dobrým kandidátom na vytvorenie metódy.

### Príklad použitia metód

Predstavte si, že máte úlohu vypočítať priemer zo zoznamu čísel. Môžete napísať funkciu, ktorá to urobí:

```csharp
public double CalculateAverage(List<int> numbers)
{
    int sum = 0;
    foreach(int number in numbers)
    {
        sum += number;
    }

    double average = (double)sum / numbers.Count;
    return average;
}
```

Táto metóda prijíma ako parameter zoznam čísel `numbers`. Potom prechádza cez všetky čísla a sčíta ich do premennej `sum`. Nakoniec vypočíta priemer delením súčtu všetkými číslami a vráti tento priemer.

Môžeme ju využiť tak, že vytvoríme zoznam čísel a potom zavoláme metódu `CalculateAverage`:

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
double average = CalculateAverage(numbers);
Console.WriteLine($"Priemer čísel je: {average}");
```

Výsledok by mal byť `3`.

### Parametre metód

Parametre v metódach nám umožňujú flexibilitu. Môžeme ich použiť na prechádzanie hodnôt do metód a tým nám umožňujú vytvárať funkcie, ktoré môžu robiť rôzne veci na základe vstupných dát.

Pre príklad, môžeme mať metódu, ktorá vypočíta sumu dvoch čísel:

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

Táto metóda prijíma dva parametre, `a` a `b`, a vráti ich súčet. Keď voláme túto metódu, môžeme jej poskytnúť ľubovoľné dve čísla a ona vráti ich súčet:

```csharp
int sum = Add(3, 4);
Console.WriteLine(sum);  // vypíše 7
```

Toto je len základné použitie parametrov, ale môžu byť oveľa mocnejšie. Môžeme napríklad prijať zoznam alebo pole ako parameter, alebo môžeme použiť parametre na konfiguráciu, ako sa má metóda správať.

### Návratové hodnoty metód

Tu môžete násť návod:

- [Návratové hodnoty metód](/lekcie/Navratove_hodnoty_metod.md)

## Metódy bez návratovej hodnoty

Niekedy potrebujeme metódu, ktorá len vykoná určitú úlohu, ale nevracia žiadnu hodnotu. Takéto metódy sú označené ako `void`. Napríklad:

```csharp
public void SayHello()
{
    Console.WriteLine("Ahoj, svet!");
}
```

Táto metóda nevracia žiadnu hodnotu, ale keď ju zavoláme, vypíše "Ahoj, svet!" na konzolu.

```csharp
SayHello();  // vypíše "Ahoj, svet!"
```

## Metódy a ich použitie v `C#`

Metódy sú veľmi dôležitou súčasťou programovania v C#. Umožňujú nám zapúzdrať kód do samostatných, opakovateľných blokov, ktoré môžu byť ľahko testované a opakovane používané. Metódy nám tiež pomáhajú udržať náš kód organizovaný a ľahko čitateľný, pretože každá metóda by mala mať jasne definovanú úlohu.

Práca s metódami je základným stavebným kameňom programovania a čím viac budete cvičiť s metódami a ich použitím, tým lepšie budete rozumieť tomu, ako napísať efektívny a čistý kód.

## Cvičenie

V tejto lekcii ste sa naučili o metódach, parametrách, argumentoch a návratových hodnotách. Teraz je čas tieto nové vedomosti vyskúšať na zábavnom a kreatívnom cvičení.

### Úloha

Vašou úlohou je vytvoriť metódu `string FizzBuzz(int number)` v triede `"Exercise"` v projekte `"src\AppsLab-018-Methods"`, ktorá prijme ako vstupné číslo `number` a vráti `"Fizz"`, ak je číslo deliteľné 3, `"Buzz"`, ak je číslo deliteľné 5, `"FizzBuzz"`, ak je číslo deliteľné 3 aj 5, inak vráti číslo vo formáte reťazca.

### Postup

1. Otvorte pracovný adresár `"src\AppsLab-018-Methods"`
2. Nájdite a otvorte súbor `Exercise.cs` v projekte Class Library. Táto trieda je už vopred vytvorená, ale bez implementácie metódy.
3. Implementujte metódu `FizzBuzz` podľa zadania.

### Príklad

```csharp
string result = FizzBuzz(3); // výsledok by mal byť "Fizz"
string result = FizzBuzz(5); // výsledok by mal byť "Buzz"
string result = FizzBuzz(15); // výsledok by mal byť "FizzBuzz"
string result = FizzBuzz(2); // výsledok by mal byť "2"
```

Očakávané výsledky:

1. FizzBuzz(1) = "1"
2. FizzBuzz(2) = "2"
3. FizzBuzz(3) = "Fizz"
4. FizzBuzz(4) = "4"
5. FizzBuzz(5) = "Buzz"
6. FizzBuzz(6) = "Fizz"
7. FizzBuzz(7) = "7"
8. FizzBuzz(8) = "8"
9. FizzBuzz(9) = "Fizz"
10. FizzBuzz(10) = "Buzz"
11. FizzBuzz(11) = "11"
12. FizzBuzz(12) = "Fizz"
13. FizzBuzz(13) = "13"
14. FizzBuzz(14) = "14"
15. FizzBuzz(15) = "FizzBuzz"
16. atď.

Tieto výsledky by ste mali dostať, ak správne implementujete metódu `FizzBuzz`. Skúste ju napísať a otestovať so týmito číslami!

V tomto cvičení máte možnosť pracovať nielen s testovacím projektom, ale aj s konzolovou aplikáciou. Tá vám umožní interaktívne experimentovať s rôznymi číslami a vidieť výsledky priamo na výstupe konzoly.

V projekte "src\AppsLab-018-Methods" nájdete konzolovú aplikáciu, v ktorej môžete zadávať rôzne čísla a skúšať, či výsledky metódy `FizzBuzz` zodpovedajú vašim očakávaniam. To vám pomôže lepšie pochopiť, ako táto metóda funguje a ako sa správa pri rôznych vstupných hodnotách.

Pozn.: Predtým, ako budete spúšťať konzolovú aplikáciu, uistite sa, že ste správne implementovali metódu `FizzBuzz` vo vašej triede `Exercise`. Ak ste tak urobili, mali by ste byť schopní spustiť konzolovú aplikáciu a zadávať čísla do konzoly, aby ste videli výsledky. Ak nájdete chyby alebo nezrovnalosti, skúste sa vrátiť k implementácii a skontrolovať, či ste všetko správne pochopili a implementovali.

Toto cvičenie vám pomôže lepšie pochopiť, ako fungujú metódy a ako ich využiť v rôznych situáciách. Veľa šťastia!
