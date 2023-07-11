# Premenné v jazyku `C#`

Premenná je základný stavebný prvok v programovacích jazykoch. V jazyku C# sa premenná používa na ukladanie údajov. Každá premenná má typ, ktorý určuje, aký druh údajov môže obsahovať. Napríklad premenná typu `int` môže obsahovať celé čísla, premenná typu `string` môže obsahovať reťazce atď.

## Deklarácia premennej

Predtým, než môžete premennú použiť, musíte ju deklarovať. Deklarácia premennej v C# má nasledovný formát:

```csharp
typ nazov;
```

Napríklad:

```csharp
int age;
string name;
```

V tomto prípade sme deklarovali premennú `age` typu `int` a `name` typu `string`. Zatiaľ tieto premenné neobsahujú žiadne hodnoty.

## Inicializácia premennej

Inicializácia premennej znamená priradenie hodnoty do premennej. To môžete urobiť pri deklarácii premennej alebo neskôr v kóde.

```csharp
int age = 14;
string name = "Peter";
```

## Zmena hodnoty premennej

Hodnotu premennej môžete kedykoľvek zmeniť priradením novej hodnoty.

```csharp
age = 15;
name = "Jakub";
```

## Cvičenie

Vytvorte nový konzolový projekt v rámci našej štruktúry `src\AppsLab-004-Variables` a vytvorte jednoduchý program, ktorý deklaruje, inicializuje a mení hodnoty premennej. Program by mal vypísať hodnoty premennej pred a po zmene.

> [Ako vytvoriť konzolový projekt](/lekcie/How_to_create_console_app.md)

Príklad kódu:

```csharp
// Deklarácia a inicializácia premennej
string greetings = "Ahoj svet!";
Console.WriteLine(greetings);

// Zmena hodnoty premennej
greetings = "Dovidenia svet!";
Console.WriteLine(greetings);
```

Po skompilovaní a spustení programu by ste mali vidieť na konzole tieto výpisy:

``` terminal
Ahoj svet!
Dovidenia svet!
```

> Pripomienka: [Ako spustiť konzolový projekt](/lekcie/AppsLab-002-ConsoleWriteLine.md#ako-spustiť-projekt)

Nezabudnite, že po dokončení tohto cvičenia by ste mali commit a push vašich zmien na váš fork repozitára na GitHub a potom vytvoriť pull request do hlavného repozitára "csharp".
