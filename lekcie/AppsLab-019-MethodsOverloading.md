# Preťaženie metód v `C#`

Preťaženie metód je veľmi užitočná vlastnosť jazyka C#, ktorá nám umožňuje definovať viacero metód s rovnakým názvom, ale s rôznymi parametrami. Tieto metódy môžu mať rôzny počet parametrov, rôzne typy parametrov, alebo rôzne poradie parametrov.

## Príklad

Pozrime sa na jednoduchý príklad, ktorý ilustruje preťaženie metód:

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}
```

V tomto príklade sme definovali dve metódy `Add`. Prvá metóda berie dva parametre typu `int` a druhá metóda berie dva parametre typu `double`. Obe metódy majú rovnaký názov, ale berú rôzne typy parametrov, takže sú preťažené.

## Ako to funguje?

Keď voláte preťaženú metódu, kompilátor sa rozhodne, ktorú verziu metódy použiť na základe parametrov, ktoré ste poskytli. Tento proces sa nazýva "rozlíšenie preťaženia".

Jednoduchý príklad:

```csharp
public class Greeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }

    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }
}
```

V tomto prípade máme metódu `SayHello`, ktorú môžeme zavolať buď bez akýchkoľvek parametrov, alebo s jedným reťazcovým parametrom. Keď ju zavoláme bez parametrov, jednoducho vypíše "Hello". Keď ju zavoláme s parametrom, použije tento parameter na vytvorenie personalizovaného pozdravu.

Použitie týchto metód by potom mohlo vyzerať takto:

```csharp
Greeting greeting = new Greeting();
greeting.SayHello(); // vypíše: Hello
greeting.SayHello("Peter"); // vypíše: Hello, Peter
```

Preťažovanie metód je dôležitá súčasť C#, ktorá nám umožňuje vytvárať kód, ktorý je flexibilnejší a jednoduchšie sa číta a rozumie. Prináša nám to možnosť poskytnúť viaceré varianty metódy pre rôzne použitia, pričom zachovávame jasné a zrozumiteľné meno metódy.

## Cvičenie: Generátor hesiel

V tejto úlohe budete vytvárať jednoduchý generátor hesiel. Cieľom je naučiť sa prácu s preťaženými metódami.

Cesta k zdrojovým kódom: `"src\AppsLab-019-MethodsOverloading"`

- V triede `PasswordGenerator` v projekte `AppsLab-019-MethodsOverloading` naimplementujte metódu `GeneratePassword()`, ktorá vygeneruje heslo s predvolenou dĺžkou a zložitosťou:
  - Heslo má mať predvolenú dĺžku 8 znakov.
  - Toto heslo bude obsahovať iba písmena.

```csharp
public class PasswordGenerator
{
    public string GeneratePassword()
    {
        // Vaša implementácia ide sem
    }
}
```

- Následne preťažte metódu `GeneratePassword(int length)`, aby bolo možné vytvoriť heslo s vlastnou dĺžkou.
- `GeneratePassword(int length)` generuje heslo so špecifikovanou dĺžkou v parametroch metódy.
- Heslo bude obsahovať iba písmena.

```csharp
public string GeneratePassword(int length)
{
    // Vaša implementácia ide sem
}
```

- Nakoniec preťažte metódu `GeneratePassword(int length, bool includeSpecialChars, bool includeNumbers)`, aby bolo možné generovať heslo s vlastnou dĺžkou a zložitosťou.
- `GeneratePassword(int length, bool includeSpecialChars, bool includeNumbers)` generuje heslo so špecifikovanou dĺžkou v parametroch metódy.
- Ak je `includeSpecialChars` nastavené na true, heslo bude obsahovať aspoň jeden špeciálny znak.
- Ak je `includeNumbers` nastavené na true, heslo bude obsahovať aspoň jedno číslo.
- Ak sú obidva parametre nastavené na `false`, heslo bude obsahovať iba písmena.

```csharp
public string GeneratePassword(int length, bool includeSpecialChars, bool includeNumbers)
{
    // Vaša implementácia ide sem
}
```

Zložitosť hesla je daná prítomnosťou špeciálnych znakov a čísel v hesle. Ak je `includeSpecialChars` nastavené na `true`, heslo by malo obsahovať aspoň jeden špeciálny znak. Ak je `includeNumbers` nastavené na `true`, heslo by malo obsahovať aspoň jedno číslo.

### Tipy

- Môžete použiť triedu [Random](/lekcie/Random.md) na generovanie náhodných čísel, ktoré potom použijete na indexovanie do reťazca obsahujúceho všetky možné znaky pre heslo.
- Môžete vytvoriť reťazce obsahujúce všetky písmená, číslice a špeciálne znaky, ktoré chcete v hesle použiť.
- Predvolené hodnoty môžu byť ľubovoľné, napríklad 8 znakov pre dĺžku, `includeSpecialChars = false` a `includeNumbers = true`.

Pokiaľ chcete vyskúšať rôzne možnosti a vidieť, ako fungujú rôzne metódy pre generovanie hesiel, môžete použiť konzolovú aplikáciu, ktorá je súčasťou tohto cvičenia. Konzolová aplikácia sa nachádza v adresári `"src\AppsLab-019-MethodsOverloading"`.

V konzolovej aplikácii môžete vytvárať inštancie triedy `PasswordGenerator` a volať metódy `GeneratePassword` s rôznymi parametrami, aby ste videli, ako menia výsledok. Môžete skúsiť generovať heslá s rôznymi dĺžkami, prípadne s alebo bez špeciálnych znakov alebo čísel.

Toto je skvelý spôsob, ako si prakticky vyskúšať a lepšie porozumieť konceptu preťažovania metód v C#.

Napíšte niečo ako:

```csharp
var generator = new PasswordGenerator();

// Generovanie hesla s predvolenými nastaveniami
Console.WriteLine("Generovanie hesla s predvolenými nastaveniami:");
Console.WriteLine(generator.GeneratePassword());
Console.WriteLine(); // prázdný riadok pre lepšiu čitateľnosť

// Generovanie 12-znakového hesla
Console.WriteLine("Generovanie 12-znakového hesla:");
Console.WriteLine(generator.GeneratePassword(12));
Console.WriteLine(); // prázdný riadok pre lepšiu čitateľnosť

// Generovanie 15-znakového hesla so špeciálnymi znakmi a číslami
Console.WriteLine("Generovanie 15-znakového hesla so špeciálnymi znakmi a číslami:");
Console.WriteLine(generator.GeneratePassword(15, true, true));
```

Toto vám umožní vidieť rôzne výsledky a lepšie pochopiť, ako preťažovanie metód funguje.

Po dokončení implementácie si môžete svoju prácu otestovať pomocou unit testov, ktoré sú k dispozícii v projekte `AppsLab-019-MethodsOverloading.Tests`.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

## Ďalšie štúdium

Pre viac informácií o preťažovaní metód navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Member Overloading](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/member-overloading)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať preťažovanie metód v C#.
