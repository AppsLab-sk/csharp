# Boolean v `C#`

## Čo je boolean?

Boolean je dátový typ v jazyku C#, ktorý môže nadobúdať dve hodnoty: `true` (pravda) a `false` (nepravda). Tento typ sa najčastejšie používa na vytváranie logických podmienok - napríklad na rozhodovanie, či sa má vykonať určitý kód alebo nie.

## Príklady použitia boolean

### Deklarácia a inicializácia

Deklarácia a inicializácia boolean premennej je rovnaká ako pri iných dátových typoch:

```csharp
bool isSunny = true;
bool isRaining = false;
```

V tomto príklade sme deklarovali dve premenné typu boolean, `isSunny` a `isRaining`, a inicializovali ich hodnotami `true` a `false`.

### Porovnávanie hodnôt

Boolean hodnoty sa často vytvárajú porovnávaním dvoch hodnôt pomocou porovnávacích operátorov (`==`, `!=`, `<`, `>`, `<=`, `>=`). Výsledkom takéhoto porovnania je hodnota `true` alebo `false`.

```csharp
int a = 5;
int b = 3;
bool isALarger = a > b;  // true
```

V tomto príklade porovnávame dve čísla a výsledok (či je `a` väčšie ako `b`) ukladáme do boolean premennej `isALarger`.

### Logické operátory

S boolean hodnotami môžeme pracovať aj pomocou logických operátorov `&&` (a zároveň), `||` (alebo) a `!` (nie).

#### Operátor AND - `&&`

```csharp
bool isSunny = true;
bool isWarm = false;

bool isGoodWeather = isSunny && isWarm;  // false
```

#### Operátor OR - `||`

Operátor `||` (alebo) je ďalší logický operátor, ktorý sa používa v boolean logike. Tento operátor vráti `true`, ak je aspoň jedna z hodnôt `true`. Inak vráti `false`.

Pozrime sa na príklad:

```csharp
bool isSunny = true;
bool isWarm = false;

bool isGoodWeather = isSunny || isWarm;  // true
```

V tomto príklade je premenná `isGoodWeather` `true`, pretože aspoň jedna z hodnôt (`isSunny` alebo `isWarm`) je `true`.

V kombinácii s operátorom `&&` a `!` vám operátor `||` umožňuje vytvárať komplexné logické výrazy a podmienky, ktoré môžu riadiť, ako sa váš program správa. Skúste experimentovať s týmito operátormi, aby ste lepšie pochopili, ako fungujú.

#### Operátor NOT - `!`

```csharp
bool isCold = false;
bool isNotCold = !isCold;  // true
```

V tomto príklade sme použili operátor `!` na zmenu hodnoty premennej `isCold` na opačnú.

Samozrejme, tu je príklad cvičenia pre prácu s boolean hodnotami.

## Cvičenie - Práca s boolean

V tomto cvičení budeme pracovať so základnými boolean operáciami. Cieľom je naprogramovať niekoľko metód, ktoré vykonajú rôzne logické operácie.

Pracovný adresár pre toto cvičenie je `src\AppsLab-012-Boolean`. V tomto adresári už je vytvorený projekt, ktorý obsahuje jednu triedu s názvom `BooleanLogic`.

Vašou úlohou je implementovať nasledujúce metódy v tejto triede:

```csharp
public bool And(bool a, bool b)
{
    throw new NotImplementedException();
}

public bool Or(bool a, bool b)
{
    throw new NotImplementedException();
}

public bool Not(bool a)
{
    throw new NotImplementedException();
}
```

1. Metóda `And` by mala vrátiť výsledok logického operátora `&&` na dvoch zadaných hodnotách.
2. Metóda `Or` by mala vrátiť výsledok logického operátora `||` na dvoch zadaných hodnotách.
3. Metóda `Not` by mala vrátiť výsledok logického operátora `!` na zadanej hodnote.

Keď implementujete tieto metódy, nezabudnite, že operátor `&&` vráti `true` iba vtedy, keď sú obe hodnoty `true`. Operátor `||` vráti `true`, keď je aspoň jedna hodnota `true`. A operátor `!` vráti opačnú hodnotu zadanej hodnoty.

Po implementácii týchto metód skontrolujte svoju prácu pomocou unit testov v projekte `tests\AppsLab-012-Boolean.Tests`. Ak všetky testy prejdú, vaše riešenie je správne. Ak niektorý z testov zlyhá, prečítajte si správu o chybe a skúste svoje riešenie opraviť.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

## Ďalšie štúdium

V prípade, že by ste chceli vedieť viac o logických operátoroch v jazyku C# (AND, OR, NOT, XOR), odporúčam navštíviť oficiálnu dokumentáciu od Microsoftu, ktorá poskytuje podrobné informácie o každom z týchto operátorov. Dokumentácia obsahuje aj príklady kódu, ktoré vám pomôžu lepšie porozumieť, ako sa tieto operátory používajú.

Oficiálna dokumentácia od Microsoftu je dostupná na tomto odkaze:

[Boolean logical operators - AND, OR, NOT, XOR](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators)

Nezabudnite, že prax a skúmanie je kľúčové pre porozumenie a ovládanie týchto konceptov. Nebojte sa experimentovať a vytvárať vlastné príklady kódu, aby ste lepšie pochopili, ako tieto operátory fungujú.

## Bonusové cvičenia

Tu je zopár bonusových cvičení o boolean logike:

1. **Vytvorenie metódy pre overenie rovnosti dvoch booleanov:**
   Implementujte metódu, ktorá prijme dva boolean parametre a vráti `true` len v prípade, ak sú oba vstupy rovnaké. V opačnom prípade vráti `false`.

2. **Kombinovanie viacerých boolean hodnôt:**
   Vytvorte metódu, ktorá prijme tri boolean hodnoty ako parametre. Metóda by mala vrátiť `true`, iba ak aspoň dva vstupy sú `true`. Inak vráti `false`.

3. **Implementácia XOR operátora:**
   Vytvorte metódu, ktorá implementuje funkčnosť XOR operátora. XOR je operátor, ktorý vráti `true`, iba ak je jedna z vstupných hodnôt `true`, ale nie obe.

4. **Overovanie pravdivosti reťazcov:**
   Vytvorte metódu, ktorá prijme reťazec ako parameter a vráti `true`, ak reťazec obsahuje slovo "pravda" alebo "true" a zároveň neobsahuje slovo "nepravda" alebo "false".

Pracujte v priečinku `src\AppsLab-012-Boolean`. Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

Vezmite na vedomie, že tieto cvičenia sú zamerané na prax a experimentovanie s boolean logikou, a teda môžu byť niektoré z nich trochu náročné. Ale nebojte sa, pokračujte v skúšaní a učení sa z vašich chýb, to je najlepší spôsob, ako sa naučiť programovať!
