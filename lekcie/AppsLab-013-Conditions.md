# Podmienky `if`, `else` v `C#`

Podmienky sú základným stavebným kameňom v programovaní. Pomocou nich môžeme rozhodovať, ktorú časť kódu vykonať v závislosti od splnenia určitej podmienky. Podmienky v jazyku C# používajú kľúčové slová `if` a `else`.

## Podmienka `if`

Podmienka `if` vykoná kód v bloku `if`, ak je podmienka pravdivá.

```csharp
int age = 20;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
```

V tomto príklade sa správa `"You are an adult."` vypíše na konzolu len v prípade, ak je hodnota premennej `age` väčšia alebo rovná 18.

## Podmienka `else`

Slovíčko `else` sa používa na definovanie bloku kódu, ktorý sa má vykonať, ak je podmienka `if` nepravdivá.

```csharp
int age = 16;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are not an adult.");
}
```

V tomto príklade sa správa `"You are not an adult."` vypíše na konzolu, pretože hodnota premennej `age` je menšia ako 18.

## Viacnásobné podmienky `else if`

Ak máme viacero podmienok na kontrolu, môžeme použiť `else if`.

```csharp
int age = 20;
if (age > 18)
{
    Console.WriteLine("You are an adult.");
}
else if (age > 13)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are a kid.");
}
```

Tento kód zistí, či je človek dospelý, teenager alebo dieťa.

## Skrátená syntax

Ak máme v bloku `if` alebo `else` len jeden príkaz, môžeme vynechať zložené zátvorky `{}`.

```csharp
int age = 20;
if (age >= 18)
    Console.WriteLine("You are an adult.");
else
    Console.WriteLine("You are not an adult.");
```

Použitie tejto skrátené syntaxe však nie je odporúčané, pretože môže viesť k chybám, keď kód upravujeme.

Často sa v praxi stretávame s podmienkami. Napríklad, ak chceme overiť, či je užívateľ prihlásený, alebo ak chceme zobraziť rôzne správy v závislosti od výsledkov podmienky. Všetky tieto príklady vyžadujú použitie podmienok `if` a `else`.

## Príklad: Jednoduchá kalkulačka

Pozrime sa na praktický príklad, ako by sme mohli použiť podmienky v reálnom kóde. Napíšeme jednoduchú kalkulačku, ktorá môže vykonávať základné matematické operácie.

```csharp
string operation = "+";
double number1 = 10;
double number2 = 5;

if (operation == "+")
{
    Console.WriteLine(number1 + number2);  // 15
}
else if (operation == "-")
{
    Console.WriteLine(number1 - number2);  // 5
}
else if (operation == "*")
{
    Console.WriteLine(number1 * number2);  // 50
}
else if (operation == "/")
{
    // Skontrolujeme, či je deliteľ nulový
    if (number2 != 0)
    {
        Console.WriteLine(number1 / number2);  // 2
    }
    else
    {
        Console.WriteLine("Cannot divide by zero.");
    }
}
else
{
    Console.WriteLine("Invalid operation.");
}
```

V tomto príklade sa najprv overí, akú operáciu chceme vykonať. Ak je operácia neplatná, vypíše sa správa `"Invalid operation."`. Ak je operácia delenie, skontroluje sa, či deliteľ nie je nula a potom sa vykoná operácia delenia. Ak je deliteľ nula, vypíše sa správa `"Cannot divide by zero."`.

Tento príklad ukazuje, ako môžeme kombinovať podmienky a ako môžeme používať podmienky `if` a `else`.

## Otestovanie viacerých podmienok naraz

V pracovnom adresári `src\AppsLab-013-Conditions` máte už vytvorený projekt so základnou triedou `GameRules`. Táto trieda bude obsahovať nasledujúce metódy:

1. `CanPlayerEnterGame(string playerName, int playerAge)`: Táto metóda by mala skontrolovať, či hráč môže vstúpiť do hry. Hráč môže vstúpiť do hry, ak jeho vek je rovný alebo väčší ako 15 a jeho meno nie je prázdne.

2. `IsGameOver(int playerHealth)`: Táto metóda by mala skontrolovať, či je hra už skončená. Hra je skončená, ak je zdravie hráča menšie alebo rovné nule.

3. `ShouldOpenSecretDoor(bool hasKey, bool knowsPassword)`: Táto metóda by mala skontrolovať, či sa má otvoriť tajné dvere. Tajné dvere sa otvoria, ak hráč má kľúč a zároveň pozná heslo.

Vašou úlohou je implementovať tieto metódy v triede `GameRules`.

Po implementácii týchto metód skontrolujte svoju prácu pomocou unit testov v projekte `tests\AppsLab-013-Conditions.Tests`. Ak všetky testy prejdú, vaše riešenie je správne. Ak niektorý z testov zlyhá, prečítajte si správu o chybe a skúste svoje riešenie opraviť.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

## Ďalšie štúdium

Pre viac informácií o podmienkach `if` a `else` navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Selection statements - if, if-else, and switch](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať podmienky v C#.

## Bonusové cvičenia

Tu je zopár nápadov na bonusové cvičenia na precvičenie podmienok v C#:

1. **Hodnotenie výsledkov testu:** Napíšte metódu, ktorá bude prijímať percentuálny výsledok testu a vráti hodnotenie. Ak je výsledok 90% a viac, vráti "A", ak je medzi 80 a 89%, vráti "B", atď. Ako riešiť situáciu, keď percentuálny výsledok je menej ako 0 alebo viac ako 100?

2. **Rok narodenia:** Napíšte metódu, ktorá prijme rok narodenia a vráti, či je človek dospelý (18 rokov a viac).

3. **Práca s dátumami:** Napíšte metódu, ktorá prijme dátum a vráti, či je tento deň víkend alebo nie.

4. **Zmena farby semaforu:** Napíšte metódu, ktorá bude prijímať aktuálnu farbu na semafore a vráti nasledujúcu farbu. Ak je aktuálna farba červená, vráti zelenú, ak je zelená, vráti oranžovú, a ak je oranžová, vráti červenú.

5. **Rozhodovanie podľa počasia:** Napíšte metódu, ktorá prijme aktuálnu teplotu a vráti odporúčané oblečenie. Ak je teplota pod 0, vráti `"oblečte si bundu"`, ak je medzi 0 a 15, vráti `"oblečte si sveter"`, a ak je nad 15, vráti `"oblečte si tričko"`.

6. **Výpočet ceny poštovného:** Napíšte metódu, ktorá prijme hmotnosť balíka a vráti cenu za poštovné. Cena sa mení v závislosti od hmotnosti balíka.

Tieto cvičenia vám pomôžu precvičiť používanie podmienok v C#. Buďte kreatívni a nebojte sa experimentovať s rôznymi príkladmi a scenármi.
