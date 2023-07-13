# Operátory v jazyku `C#`

Operátory sú symboly, ktoré určujú, aký typ operácie sa má vykonať na jednom alebo viacerých operandoch. Operand je hodnota alebo premenná, na ktorú sa operácia aplikuje. V jazyku C# sa rozlišujú rôzne druhy operátorov. Pozrime sa na niektoré z nich.

## Aritmetické operátory

Aritmetické operátory sa používajú na vykonávanie základných matematických operácií. Tu je niekoľko príkladov:

- `+` - sčítanie (napr. `5 + 3` vráti `8`)
- `-` - odčítanie (napr. `5 - 3` vráti `2`)
- `*` - násobenie (napr. `5 * 3` vráti `15`)
- `/` - delenie (napr. `5 / 2` vráti `2.5`)
- `%` - zvyšok po delení (modulo) (napr. `5 % 2` vráti `1`)

### Relačné operátory

Relačné operátory sa používajú na porovnávanie dvoch hodnôt. Výsledkom takéhoto porovnania je buď `true` (pravda) alebo `false` (nepravda).

- `==` - rovnosť (napr. `5 == 3` vráti `false`)
- `!=` - nerovnosť (napr. `5 != 3` vráti `true`)
- `>` - väčší ako (napr. `5 > 3` vráti `true`)
- `<` - menší ako (napr. `5 < 3` vráti `false`)
- `>=` - väčší alebo rovný ako (napr. `5 >= 3` vráti `true`)
- `<=` - menší alebo rovný ako (napr. `5 <= 3` vráti `false`)

### Logické operátory

Logické operátory sa používajú na kombinovanie viacerých logických výrazov.

- `&&` - logické a (AND) (napr. `(5 > 3) && (2 < 4)` vráti `true`)
- `||` - logické alebo (OR) (napr. `(5 < 3) || (2 < 4)` vráti `true`)
- `!` - logická negácia (NOT) (napr. `!(5 < 3)` vráti `true`)

Existujú aj iné typy operátorov v jazyku C#, ako sú napríklad priradzovacie operátory, bitové operátory, operátory inkrementácie a dekrementácie a mnohé iné. V tomto návode sme sa však zamerali na základné operátory, ktoré sa najčastejšie používajú pri bežnom programovaní.

### Príklad

Predstavte si, že máme dve premenné, `a` a `b`, ktoré sú obidve typu `int`. Môžeme s nimi vykonať rôzne operácie:

```csharp
int a = 5;
int b = 3;

int sum = a + b;  // 8
int difference = a - b;  // 2
int product = a * b;   // 15
double division = (double)a / b;  // 1.66666666666667
int remainder = a % b;   // 2

bool equality = a == b;  // false
bool inequality = a != b;  // true
bool greater = a > b;  // true
bool lesser = a < b;  // false
bool greaterEqual = a >= b;  // true
bool lesserEqual = a <= b;  // false
```

Všimnite si, že sme použili `(double)a / b` pre delenie, aby sme získali desatinný výsledok. Bez toho by sme získali celočíselný výsledok delenia.

Tieto operátory môžete vyskúšať a experimentovať s nimi vo vašom kóde, aby ste lepšie pochopili, ako fungujú.

## Cvičenie - Operátory

V tomto cvičení budete pracovať s operátormi v jazyku C#. Vytvorený je pre vás už projekt a taktiež trieda `Calculator` v adresári `src\AppsLab-009-Operators`.

1. Otvorte projekt v obľúbenom vývojovom prostredí (Visual Studio 2022 alebo Visual Studio Code).

2. V triede `Calculator` nájdete niekoľko neimplementovaných metód:

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        throw new NotImplementedException();
    }

    public int Subtract(int a, int b)
    {
        throw new NotImplementedException();
    }

    public int Multiply(int a, int b)
    {
        throw new NotImplementedException();
    }

    public double Divide(int a, int b)
    {
        throw new NotImplementedException();
    }

    public int Remainder(int a, int b)
    {
        throw new NotImplementedException();
    }

    public bool AreEqual(int a, int b)
    {
        throw new NotImplementedException();
    }

    public bool AreNotEqual(int a, int b)
    {
        throw new NotImplementedException();
    }

    public bool IsGreater(int a, int b)
    {
        throw new NotImplementedException();
    }

    public bool IsLesser(int a, int b)
    {
        throw new NotImplementedException();
    }

    public bool IsGreaterOrEqual(int a, int b)
    {
        throw new NotImplementedException();
    }

    public bool IsLesserOrEqual(int a, int b)
    {
        throw new NotImplementedException();
    }
}
```

3. Vašou úlohou je nahradenie riadkov `throw new NotImplementedException();` reálnym kódom, ktorý využije príslušné operátory a vráti správne výsledky.

4. Po dokončení uložte zmeny, vykonajte commit a potom push do repozitára.

### Príklad:

Nasledujúci kód ukazuje, ako by mohla vyzerať implementácia metódy `Add`:

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

V tomto príklade metóda `Add` prijíma dva parametre `a` a `b`, sčíta ich hodnoty a výsledok vráti.

### Pomoc

Tu môžete násť návod:

> [Ako "vrátiť" alebo odoslať návratovú hodnotu v metóde](/lekcie/Navratove_hodnoty_metod.md)

## Spustenie testov

Pre overenie správnosti vášho riešenia, máte k dispozícii testy. Spustenie týchto testov vám poskytne rýchlu spätnú väzbu a pomôže vám identifikovať a opraviť chyby vo vašom kóde.

Testy pre toto cvičenie sa nachádzajú v priečinku `tests\AppsLab-009-Operators.Tests`.
Predtým, ako začnete testy spúšťať, prejdite do tohto priečinku, aby ste obmedzili rozsah testovania len na toto cvičenie.

Tu je postup, ako spustiť testy v rôznych prostrediach:
> [Ako spustiť unit testy](/lekcie/Ako_spustit_unit_testy.md)

---

Ak si chcete prečítať viac informácií o operátoroch v C#, môžete sa pozrieť na oficiálnu dokumentáciu od Microsoftu. Dokumentácia je komplexná a obsahuje detailné informácie o každom operátore, vrátane príkladov kódu. Môže byť veľmi užitočná pri získavaní hlbšieho porozumenia tomu, ako operátory fungujú a kedy ich používať.

Pre prístup k dokumentácii kliknite na nasledujúci odkaz:

[Oficiálna dokumentácia k operátorom v C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)

Pamätajte, že aj keď dokumentácia je veľmi užitočná, najlepším spôsobom, ako sa naučiť programovať, je prax a experimentovanie. Takže neváhajte a skúšajte rôzne príklady, robte cvičenia a skúšajte vytvárať svoje vlastné malé projekty.
