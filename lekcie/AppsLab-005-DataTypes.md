# Úvod do dátových typov v `C#`

V programovacích jazykoch, vrátane C#, dátové typy určujú aký druh hodnoty môže premenná obsahovať. C# je staticky typovaný jazyk, čo znamená, že typ premennej je definovaný v čase kompilácie a nemožno ho zmeniť počas behu programu.

## Celé čísla

Existuje niekoľko typov pre celé čísla, ktoré sa líšia podľa rozsahu hodnôt, ktoré môžu obsahovať, a či môžu reprezentovať záporné hodnoty.

- `byte`: 8-bitové celé číslo bez znamienka (0 až 255).
- `sbyte`: 8-bitové celé číslo so znamienkom (-128 až 127).
- `short`: 16-bitové celé číslo so znamienkom (-32768 až 32767).
- `ushort`: 16-bitové celé číslo bez znamienka (0 až 65535).
- `int`: 32-bitové celé číslo so znamienkom (-2 147 483 648 až 2 147 483 647).
- `uint`: 32-bitové celé číslo bez znamienka (0 až 4 294 967 295).
- `long`: 64-bitové celé číslo so znamienkom (-9 223 372 036 854 775 808 až 9 223 372 036 854 775 807).
- `ulong`: 64-bitové celé číslo bez znamienka (0 až 18 446 744 073 709 551 615).

## Čísla s plávajúcou desatinnou čiarkou

Tieto typy sa používajú pre reprezentáciu čísel s desatinnou čiarkou.

- `float`: 32-bitové číslo s plávajúcou desatinnou čiarkou.
- `double`: 64-bitové číslo s plávajúcou desatinnou čiarkou.
- `decimal`: 128-bitové desatinné číslo. Tento typ je určený pre finančné a menové výpočty.

## Znak

Typ `char` sa používa na reprezentáciu jedného znaku.

## Reťazec

Typ `string` sa používa na reprezentáciu postupnosti znakov.

## Boolovský typ

Boolovský typ `bool` môže mať len dve hodnoty: `true` alebo `false`.

## Dátum a čas

Typ `DateTime` sa používa na reprezentáciu dátumu a času.

## Objekt

Typ `object` je základným typom pre všetky ostatné typy v C#. Každý typ je buď priamo alebo nepriamo odvodený z typu `object`.

## Dynamický typ

Kľúčové slovo `dynamic` sa používa na vytváranie premenných, ktorých typ je určený za behu.

## Práca s dátovými typmi

Vytvorenie premennej a priradenie jej hodnoty v C# je jednoduché:

```csharp
int mojeCislo = 10;
string mojeSlovo = "Ahoj, svet!";
bool mojaBoolHodnota = true;
DateTime dnesnyDatum = DateTime.Now;
```

V C# môžete tiež použiť kľúčové slovo `var` na vytvorenie premennej, ktorú kompilátor automaticky typizuje na základe inicializátora.

```csharp
var mojeCislo = 10;  // kompilátor určí, že mojeCislo je int
var mojeSlovo = "Ahoj, svet!";  // kompilátor určí, že mojeSlovo je string
```

Toto je len základný prehľad dátových typov v C#. Každý typ má svoje vlastné metódy a vlastnosti, ktoré môžete využiť. Viac informácií o jednotlivých typoch a ich metódach a vlastnostiach nájdete v dokumentácii .NET ([Built-in types - C# reference](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)).

## Cvičenie: Práca s dátovými typmi v `C#`

Toto cvičenie je zamerané na prácu s rôznymi dátovými typmi v C#. Vytvorená je už konzolová aplikácia "Hello World!" v priečinku `src\AppsLab-005-DataTypes\`, ktorú budete rozširovať o prácu s rôznymi dátovými typmi.

### Úloha 1

- Vytvorte premennú celočíselného typu `int` a priraďte jej hodnotu.
- Potom vypíšte hodnotu tejto premennej na konzolu.

### Úloha 2

- Vytvorte premennú typu `string` a priraďte jej nejaký text.
- Potom vypíšte hodnotu tejto premennej na konzolu.

### Úloha 3

- Vytvorte premennú typu `bool` a priraďte jej hodnotu.
- Potom vypíšte hodnotu tejto premennej na konzolu.

### Úloha 4

- Vytvorte premennú typu `DateTime` a priraďte jej aktuálny dátum a čas.
- Potom vypíšte hodnotu tejto premennej na konzolu.

### Úloha 5

- Vytvorte premennú typu `float`, priraďte jej desatinnú hodnotu.
- Potom vypíšte hodnotu tejto premennej na konzolu.

### Úloha 6

- Vytvorte premennú pomocou `var` a priraďte jej hodnotu.
- Potom vypíšte hodnotu tejto premennej na konzolu.
- Skúste priradiť rôzne typy hodnôt a pozorujte, čo sa stane.

Tieto úlohy sú zamerané na to, aby ste pochopili, ako pracovať s rôznymi dátovými typmi v C#. Väčšina programovacích jazykov má podobné dátové typy, takže všeobecné porozumenie týmto konceptom vám bude prospešné nielen v C#, ale aj v ostatných jazykoch.

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.