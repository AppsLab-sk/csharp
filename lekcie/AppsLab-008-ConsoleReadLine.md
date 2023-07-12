# Používanie metódy `Console.ReadLine` v `C#`

Metóda `Console.ReadLine` je veľmi užitočná funkcia, ktorú nájdeme v jazyku C#. Slúži na načítanie riadku textu, ktorý používateľ zadá v konzole, a na jeho konverziu na reťazec (string).

Použitie tejto metódy je jednoduché. Stačí ju zavolať v rámci programu v konzolovej aplikácii, aby sa program zastavil a počkal, kým používateľ zadá text a stlačí klávesu `Enter`. Toto je veľmi užitočné v situáciách, keď chcete od používateľa požadovať nejaké informácie alebo dáta.

Nasledujúci príklad ukazuje, ako získať meno používateľa:

```csharp
Console.WriteLine("Ako sa voláš?");
string meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);
```

V tomto príklade program vypíše otázku `"Ako sa voláš?"`, potom použije metódu `Console.ReadLine` na načítanie mena, ktoré používateľ zadá, a nakoniec toto meno použije v uvítacej správe.

Ak chcete konvertovať vstup získaný pomocou `Console.ReadLine` na iný dátový typ, napríklad `int` alebo `double`, môžete použiť metódy `int.Parse` alebo `double.Parse`. Napríklad:

```csharp
Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine();
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");
```

V tomto príklade program vypíše otázku "Koľko máš rokov?", načíta vstup od používateľa, premení ho na celé číslo a vypíše vek používateľa. Ak používateľ zadá niečo, čo nie je možné premeniť na celé číslo, program vygeneruje chybu. Preto je dôležité pridať ošetrenie chýb pri práci s užívateľským vstupom.

## Spustenie príkladov v konzolovej aplikácii

Tieto príklady môžete skúsiť priamo v konzolovej aplikácii. V tomto prípade máme už vytvorenú ukážkovú konzolovú aplikáciu v adresári `src\AppsLab-008-ConsoleReadLine`.

### Spustenie konzolovej aplikácie pomocou Visual Studio 2022

1. Otvorte riešenie (solution) `AppsLab.CSharp.Exercises.sln` v programe Visual Studio 2022.
2. Nájdite projekt AppsLab-008-ConsoleReadLine v rámci riešenia v paneli Solution Explorer.
3. Kliknite pravým tlačidlom myši na projekt a zvoľte možnosť `Set as Startup Project`.
4. Stlačte tlačidlo `F5` na klávesnici alebo kliknite na tlačidlo `Start Debugging` na nástrojovej lište, aby ste spustili aplikáciu.

### Spustenie konzolovej aplikácie pomocou Visual Studio Code

1. Otvorte priečinok `AppsLab-008-ConsoleReadLine` v programe Visual Studio Code.
2. Otvorte terminál (`Ctrl+~`).
3. Zadajte príkaz `dotnet run`.

### Spustenie konzolovej aplikácie pomocou terminálu

1. Otvorte terminál.
2. Prejdite do priečinku `AppsLab-008-ConsoleReadLine` pomocou príkazu `cd`.
3. Zadajte príkaz `dotnet run`.

Po spustení týchto príkazov sa spustí vaša konzolová aplikácia a môžete začať pracovať s užívateľským vstupom pomocou metódy `Console.ReadLine`.

## Cvičenie - Čítanie údajov z konzoly

Cieľom tohto cvičenia je upraviť existujúci projekt `AppsLab-008-ConsoleReadLine` tak, aby ste vedeli načítať od užívateľa ďalšie informácie. Toto cvičenie vám pomôže lepšie pochopiť, ako funguje načítanie údajov z konzoly.

### Úloha 1: Načítanie mena a veku

1. Upravte existujúci kód tak, aby ste načítali meno a vek užívateľa. Načítanie mena môže prebiehať podobne ako v príklade s otázkou "Ako sa voláš?", ale namiesto odpovede "Ahoj, {meno}!" nech vypíše "Ahoj, {meno}! Koľko máš rokov?".

2. Potom necháte užívateľa zadať vek a vypíšete správu "Aha, máš teda {vek} rokov.".

### Úloha 2: Načítanie obľúbeného jedla

1. Pridajte do programu ďalšiu otázku: "Aké je tvoje obľúbené jedlo?".

2. Po zadaní odpovede vypíšte správu "Hmm, {jedlo} znie skvele!".

Pracujte v priečinku `src\AppsLab-008-ConsoleReadLine`. Po dokončení úloh nezabudnite uložiť a otestovať váš program.

### Rady pre úlohy

Pri implementácii týchto úloh sa môžete riadiť nasledovnými krokmi:

1. Použite príkaz `Console.WriteLine()` na výpis otázky do konzoly.

2. Použite príkaz `Console.ReadLine()` na načítanie odpovede od užívateľa.

3. Uložte odpoveď do premennej a využite ju v nasledujúcom výpise.

Popracujte na formátovaní reťazcov a zabezpečte, aby vaše otázky a odpovede zneli prirodzene. Veľa šťastia!

## Bonusové cvičenie - Čítanie jedného znaku

Cieľom tohto cvičenia je preskúmať čítanie jedného znaku z konzoly pomocou metódy `Console.ReadKey()`. Táto metóda je užitočná, keď chcete načítať len jeden znak, namiesto celej riadky textu.

1. Upravte svoj existujúci kód tak, aby obsahoval nasledujúci riadok:

```csharp
Console.WriteLine("Stlač klávesu: ");
```

2. Pridajte nasledujúci riadok kódu za výpis:

```csharp
var key = Console.ReadKey();
```

3. Pridajte ešte jeden riadok kódu, ktorý vypíše, akú klávesu ste stlačili:

```csharp
Console.WriteLine();
Console.WriteLine($"Stlačili ste klávesu: {key.KeyChar}");
```

Použitie `Console.WriteLine();` bez argumentov, ako sme to urobili medzi načítaním a vypísaním klávesy, slúži len na presunutie kurzora na nový riadok. To nám umožňuje oddeliť výpis stlačenej klávesy od výzvy pre užívateľa.

4. Spustite svoj program a skúste stlačiť rôzne klávesy na klávesnici.

Pracujte v priečinku `src\AppsLab-008-ConsoleReadLine`. Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

**Poznámka:** Metóda `Console.ReadKey()` načíta stlačenú klávesu a vráti ju ako hodnotu typu `ConsoleKeyInfo`. Tento typ obsahuje rôzne vlastnosti, ktoré môžete využiť, ako napríklad `KeyChar`, ktorý predstavuje znak stlačenej klávesy. Preto sme v poslednom riadku kódu použili `key.KeyChar` na zobrazenie stlačenej klávesy.

**Pozor!** Keďže ešte nepoznáme cykly a podmienky, metódu `Console.ReadKey()` je možné použiť len na načítanie jedného znaku. Neskôr sa naučíme, ako načítať viac klávesových stlačení a ako reagovať na konkrétne stlačené klávesy.
