# Reťazce a špeciálne znaky v `C#`

Reťazce (strings) sú v C# veľmi dôležité. Slúžia na uchovávanie a manipuláciu s textovými údajmi. Reťazec je séria znakov. V C# definujeme reťazce pomocou dvojitých úvodzoviek `" "`.

## Definícia reťazcov

Reťazec môžete definovať nasledovne:

```csharp
string message = "Hello World!";
```

### Konkatenácia reťazcov

Dva alebo viac reťazcov môžete spojiť pomocou operátora `+`. Toto sa nazýva konkatenácia.

```csharp
string hello = "Hello, ";
string name = "John!";
string greeting = hello + name;  // "Hello, John!"
```

### Špeciálne znaky

C# podporuje špeciálne escape sekvencie, ktoré môžete použiť na zobrazenie špeciálnych znakov. Napríklad:

- `\n` - nový riadok
- `\t` - tabulátor
- `\"` - dvojitá úvodzovka
- `\\` - spätné lomítko

Príklad použitia:

```csharp
string message = "Hello\nWorld!";  // výsledok: Hello
                                   //           World!
```

### Interpolácia reťazcov

Interpolácia reťazcov je moderný spôsob formátovania reťazcov v C#. Je čitateľnejšia a flexibilnejšia ako tradičné metódy.

Interpolovaný reťazec začína znakom `$` a umožňuje vkladať hodnoty premenných priamo do textu reťazca.

```csharp
string name = "John";
string greeting = $"Hello, {name}!";  // "Hello, John!"
```

### Práca s reťazcami

C# obsahuje mnoho metód na manipuláciu s reťazcami. Napríklad:

- `ToUpper()` a `ToLower()`
- `Trim()`
- `Contains()`
- `Replace()`
- a mnoho ďalších

Príklad použitia:

```csharp
string message = "  Hello World!  ";
message = message.Trim();  // "Hello World!"
```

**Poznámka:** Reťazce v C# sú nemenné. To znamená, že keď vykonáte operáciu na reťazci, vytvorí sa nový reťazec. Pôvodný reťazec zostane nezmenený.

### Indexovanie reťazcov

Reťazce môžete indexovať ako polia. Prvý znak v reťazci má index 0.

```csharp
string message = "Hello";
char firstChar = message[0];  // 'H'
```

## Príklady

### Spojenie dvoch reťazcov do jedného

V tomto príklade sa používa operátor `+` na spojenie dvoch reťazcov a vytvorenie jedného reťazca, ktorý obsahuje meno a priezvisko.

```csharp
string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;  // "John Doe"
```

### Formátovanie reťazca pomocou interpolácie

Tento príklad ukazuje, ako vložiť hodnotu premennej priamo do reťazca pomocou tzv. string interpolácie.

```csharp
int age = 25;
string message = $"I am {age} years old.";  // "I am 25 years old."
```

### Použitie špeciálnych znakov

V tomto príklade je ukázané, ako používať špeciálne znaky, napr. znak pre lomítko (`\`), v reťazci.

```csharp
string path = "C:\\Users\\John\\Documents";  // C:\Users\John\Documents
```

### Práca s Trim metódou

Metóda `Trim()` odstraňuje prázdne znaky na začiatku a na konci reťazca.

```csharp
string message = "   Hello World!   ";
message = message.Trim();  // "Hello World!"
```

### Dĺžka reťazca

Property (vlastnosť) `Length` vracia počet znakov v reťazci.

```csharp
string message = "Hello, World!";
int length = message.Length;  // 13
```

### Delenie reťazca

Použite metódu `Split()`, ak chcete rozdeliť reťazec na viac častí podľa určitého oddeľovača.

```csharp
string names = "John,Jane,Jim";
string[] splitNames = names.Split(',');  // ["John", "Jane", "Jim"]
```

### Vyhľadávanie v reťazci

Metóda `IndexOf()` vracia index prvého výskytu určitého znaku alebo podreťazca v reťazci. Ak sa znak alebo podreťazec v reťazci nenájde, vráti hodnotu `-1`.

```csharp
string message = "Hello, World!";
int index = message.IndexOf('W');  // 7
```

### Podreťazce

Metóda `Substring()` vytvára nový reťazec, ktorý obsahuje časť pôvodného reťazca.

```csharp
string message = "Hello, World!";
string part = message.Substring(7, 5);  // "World"
```

### Porovnávanie reťazcov

Porovnávanie reťazcov je veľmi dôležitou súčasťou práce s nimi. V C# môžete porovnať reťazce pomocou metódy `Equals()` alebo pomocou operátorov `==` a `!=`.

```csharp
string str1 = "Hello";
string str2 = "hello";

bool areEqualCaseSensitive = str1.Equals(str2);  // false
bool areEqualCaseInsensitive = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);  // true
```

Pozor, porovnávanie reťazcov je defaultne *case-sensitive*. Ak chcete porovnať reťazce bez ohľadu na veľké a malé písmená, môžete použiť `StringComparison.OrdinalIgnoreCase`.

### Konverzia reťazca na veľké písmená

```csharp
string message = "Hello, World!";
message = message.ToUpper();  // "HELLO, WORLD!"
```

Metóda `ToUpper()` prevedie všetky písmená reťazca na veľké.

### Konverzia reťazca na malé písmená

Metóda `ToLower()` prevedie všetky písmená reťazca na malé.

```csharp
string message = "Hello, World!";
message = message.ToLower();  // "hello, world!"
```

### Kontrola, či reťazec obsahuje daný podreťazec

Metóda `Contains()` skontroluje, či reťazec obsahuje zadaný podreťazec.

```csharp
string message = "Hello, World!";
bool containsWorld = message.Contains("World");  // true
```

### Kontrola, či reťazec začína daným podreťazcom

Metóda `StartsWith()` skontroluje, či reťazec začína zadaným podreťazcom.

```csharp
string message = "Hello, World!";
bool startsWithHello = message.StartsWith("Hello");  // true
```

### Kontrola, či reťazec končí daným podreťazcom

Metóda `EndsWith()` skontroluje, či reťazec končí zadaným podreťazcom.

```csharp
string message = "Hello, World!";
bool endsWithWorld = message.EndsWith("World!");  // true
```

### Nahradenie časti reťazca

Metóda `Replace()` nahrádza všetky výskyty zadaného podreťazca v reťazci novým podreťazcom.

```csharp
string message = "Hello, World!";
message = message.Replace("World", "Universe");  // "Hello, Universe!"
```

Práca s reťazcami je veľmi dôležitou súčasťou programovania v C#, takže je dobré ovládať rôzne operácie, ktoré môžete s reťazcami vykonávať.

## Cvičenie - Práca s reťazcami

V tomto cvičení si precvičíme prácu s reťazcami. Vytvorili sme pre vás projekt `AppsLab-011-Strings`, ktorý obsahuje triedu `StringManipulator`. Táto trieda obsahuje niekoľko metód, ktoré budete musieť implementovať. Každá metóda obsahuje komentár, ktorý vám pomôže pochopiť, čo od vás metóda očakáva.

Vašou úlohou je upraviť tieto metódy tak, aby vykonávali očakávané operácie s reťazcami. Metódy, ktoré budete musieť implementovať, sú nasledovné:

```csharp
public string AppendStrings(string first, string second)

public string ConvertToUpper(string input)

public string ConvertToLower(string input)

public bool ContainsSubstring(string input, string substring)

public bool StartsWithSubstring(string input, string substring)
```

Po implementácii týchto metód môžete spustiť unit testy, ktoré sme pre vás pripravili, aby ste overili správnosť svojej implementácie. Unit testy nájdete v projekte `tests\AppsLab-011-Strings.Tests`.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

## Ďalšie štúdium

Hoci sme prešli niektorými základnými operáciami s reťazcami, C# poskytuje mnoho ďalších možností pre prácu s reťazcami. Reťazce sú jedným z najpoužívanejších typov pri programovaní, takže je dôležité porozumieť tomu, ako s nimi pracovať efektívne a správne.

Pre hlbšie pochopenie témy reťazcov a špeciálnych znakov v C# odporúčame študovať oficiálnu dokumentáciu Microsoftu.

Pozrite si [Strings and string literals](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/) pre podrobné informácie o reťazcoch v C#. Táto časť dokumentácie obsahuje podrobné informácie o reťazcoch, vrátane ich deklarácie a inicializácie, manipulácie s reťazcami, formátovania reťazcov, porovnávania reťazcov, konverzie reťazcov a ďalších pokročilých tém.

Keď budete pokračovať v učení C#, určite sa vráťte k tejto dokumentácii a prečítajte si ju podrobne. Je to skvelý zdroj informácií, ktorý vám pomôže lepšie pochopiť a ovládať prácu s reťazcami v C#.

## Bonusové cvičenia

Ak chcete viac precvičiť prácu s reťazcami, skúste nasledujúce cvičenia:

1. **Spojovanie reťazcov:** Vytvorte dva reťazce a spojte ich do jedného reťazca. Skúste pridať medzeru alebo iný znak medzi ne pri spojení.

2. **Rôzne formáty reťazcov:** Skúste vytvoriť reťazce s rôznymi formátmi, ako sú dátumy, časy alebo čísla, a skúste ich spojiť do jedného reťazca.

3. **Zmena veľkosti písmen:** Vytvorte reťazec a skúste zmeniť veľkosť všetkých písmen na veľké alebo malé písmená.

4. **Práca so špeciálnymi znakmi:** Vytvorte reťazec, ktorý obsahuje špeciálne znaky, ako sú úvodzovky, tabulátory alebo znaky pre nový riadok.

5. **Odstraňovanie bielych znakov:** Vytvorte reťazec, ktorý na začiatku alebo na konci obsahuje medzery, a odstráňte tieto medzery.

6. **Zistenie dĺžky reťazca:** Vytvorte reťazec a zistite jeho dĺžku.

7. **Výpis reťazca naopak:** Vytvorte reťazec a vypíšte ho naopak pomocou indexovania znakov v reťazci (pamätajte, že prvý znak v reťazci má index 0).

8. **Podreťazce:** Vytvorte dlhší reťazec a vytvorte z neho podreťazec, ktorý obsahuje len určitú časť tohto reťazca.

Každé z týchto cvičení vám poskytne príležitosť precvičiť rôzne operácie s reťazcami a pomôže vám lepšie porozumieť tomu, ako s nimi pracovať v C#.
