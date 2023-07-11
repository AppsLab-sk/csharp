# Konštanty v `C#`

Konštanty sú nemenné hodnoty, ktoré sa používajú v programe. Hodnota konštanty je nastavená pri jej deklarácii a nemôže byť neskôr zmenená. V C# sa konštanty definujú pomocou kľúčového slova `const`.

## Deklarácia a inicializácia konštánt

Konštantu môžete deklarovať a inicializovať nasledovne:

```csharp
const int MojaKonstanta = 10;
```

V tomto príklade je `mojaKonstanta` konštanta typu `int`, ktorej hodnota je `10`.

Konštanty môžu byť deklarované pre akýkoľvek dátový typ, vrátane číselných, `string`, `bool`, a tak ďalej.

```csharp
const string Welcome = "Vitajte v AppsLabe!";
const bool IsSunny = true;
```

## Pravidlá a obmedzenia

- Hodnota konštanty musí byť známa v čase kompilácie. To znamená, že hodnota nemôže byť výsledkom výpočtu alebo operácie, ktorá sa vykonáva za behu programu.

```csharp
// Nesprávne: Hodnota nie je známa v čase kompilácie
const int Seconds = DateTime.Now.Second;
```

- Konštanty sú implicitne `static`, takže k nim môžete pristupovať bez inštancie triedy alebo štruktúry.

- Nemôžete deklarovať konštantu typu `object`, `dynamic` alebo polia.

## Použitie konštánt

Konštanty sa najčastejšie používajú tam, kde je potrebné aby sa hodnota nemohla zmeniť. To môže byť napríklad matematická konštanta, maximálna alebo minimálna hodnota alebo špecifický reťazec, ktorý sa používa na viacerých miestach v programe.

```csharp
const int MaxStudents = 30;
Console.WriteLine("Maximálny počet študentov v triede je: " + MaxStudents);
```

Vo vašom programe využívajte konštanty tam, kde potrebujete garantovať, že hodnota sa nezmení počas behu programu. To pomáha zlepšiť čitateľnosť a bezpečnosť vášho kódu.

## Konvencia pomenovania konštánt

V C# sa pre pomenovanie konštánt často používa tzv. "PascalCase" konvencia. To znamená, že prvý znak každého slova v názve je veľké a ostatné sú malé. Ak je názov konštanty zložený z viacerých slov, tieto slová sa spájajú bez medzier a každé slovo začína veľkým písmenom. Napríklad:

```csharp
const int MaxHitPoints = 100;
```

Táto konvencia je len odporúčaná a nie je povinná. Môžete používať aj iné konvencie pomenovania, ale je dôležité, aby ste boli konzistentní a vaše názvy boli zrozumiteľné pre iných programátorov.

Zároveň, pri pomenovaní konštánt by ste mali zvoliť názov, ktorý jasne vystihuje, čo konštanta reprezentuje. Názov by mal byť dostatočne konkrétny, aby bolo z jeho kontextu jasné, k čomu sa používa.

## Cvičenie: Práca s konštantami v `C#`

Vašou úlohou v tomto cvičení je pracovať s konštantami v C#.

**Kroky:**

1. Navigujte do pracovného priečinka `src\AppsLab-006-Constants\`.

2. Otvorte existujúci konzolový projekt vo vášom preferovanom vývojovom prostredí (Visual Studio 2022 alebo Visual Studio Code).

3. V hlavnej triede `Program` definujte niekoľko konštánt rôznych dátových typov. Napríklad, môžete vytvoriť konštantu pre maximálny počet bodov v hre, minimálny vek pre vodičský preukaz, alebo správu, ktorú chcete vypísať na konzolu.

```csharp
const int MaxPoints = 100;
const int MinAgeForDriversLicense = 17;
const string WelcomeMessage = "Vitajte v našej hre!";
```

4. Potom v metóde `Main` vypíšte hodnoty týchto konštánt na konzolu pomocou `Console.WriteLine`.

```csharp
Console.WriteLine(MaxPoints);
Console.WriteLine(MinAgeForDriversLicense);
Console.WriteLine(WelcomeMessage);
```

5. Spustite program a uistite sa, že sa hodnoty konštánt správne vypíšu na konzolu.

**Poznámka:** V tomto cvičení si môžete vyskúšať rôzne dátové typy a vidieť, ako fungujú konštanty v praxi. Nezabudnite, že hodnota konštanty nemôže byť zmenená po jej deklarácii.

---

Viac informácii o konštantách najdete na oficiálnej stránke od Microsoft:
- [Constants (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants)
