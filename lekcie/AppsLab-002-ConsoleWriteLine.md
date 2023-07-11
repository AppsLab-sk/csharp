# AppsLab-002-Console.WriteLine - Ako používať Console.WriteLine v `C#`

`Console.WriteLine` je metóda v jazyku C#, ktorá sa používa na výpis textu do konzoly.

## Čo je to konzola?

Konzola, niekedy nazývaná aj terminál, je textové rozhranie pre počítač. Môžete zadávať príkazy pomocou klávesnice a počítač vám odpovie textovým výstupom.

## Ako funguje Console.WriteLine?

Keď sa metóda `Console.WriteLine` používa v C# programe, vypíše text, ktorý je v jej zátvorkách, do konzoly a pridá na koniec nový riadok.

Tu je príklad:

```csharp
Console.WriteLine("Hello World!");
```

Tento príkaz vypíše "Hello World!" do konzoly a potom pridá nový riadok. Keď použijete `Console.WriteLine` viackrát, každý text sa vypíše na nový riadok, pretože `WriteLine` automaticky pridáva nový riadok na koniec každého výstupu.

`Console.WriteLine` môže tiež vypísať hodnoty premenných. Napríklad:

```csharp
string name = "Ján";
Console.WriteLine(name);
```

Tento príkaz vypíše "Ján" do konzoly.

Metóda `Console.WriteLine` je veľmi užitočná pre testovanie a ladenie programov, pretože vám umožňuje vidieť hodnoty premenných a výsledky operácií.

Teraz, keď viete, ako funguje `Console.WriteLine`, môžete ju začať používať vo svojich programoch!

## Úlohy na precvičenie `Console.WriteLine`

Po dokončení úvodnej úlohy [AppsLab-001-StartHere](/lekcie/AppsLab-001-StartHere.md) môžete pokračovať s cvičeniami, ktoré vám pomôžu pochopiť použitie `Console.WriteLine` v C#. Tieto cvičenia by ste mali vyskúšať v console projekte, ktorý bol vytvorený v priečinku `src/AppsLab-002-ConsoleWriteLine`.

Každé cvičenie je navrhnuté tak, aby ste mohli pracovať samostatne a postupovať vlastným tempom. Môžete ich vyskúšať v akomkoľvek poradí, ale odporúčame začať od prvého a postupovať smerom k poslednému, pretože sú zoradené od najjednoduchších po najnáročnejšie.

Pred každým cvičením sa uistite, že ste v aktuálnom priečinku `src/AppsLab-002-ConsoleWriteLine` vo svojom vývojovom prostredí alebo konzole. To zabezpečí, že všetky vaše zmeny budú správne umiestnené a organizované.

Samozrejme, nižšie je návod na spustenie konzolového projektu `src/AppsLab-002-ConsoleWriteLine` pomocou konzoly, Visual Studio 2022, alebo Visual Studio Code:

### Ako spustiť projekt

Môžete spustiť tento projekt rôznymi spôsobmi, vrátane konzoly, Visual Studio 2022 alebo Visual Studio Code.

#### Konzola

1. Otvorte konzolu a navigujte do priečinku s projektom: `src/AppsLab-002-ConsoleWriteLine`.
2. Zadajte príkaz `dotnet run` a stlačte `Enter`. Toto spustí váš konzolový projekt.

#### Visual Studio 2022

1. Otvorte Visual Studio 2022.
2. Kliknite na `File -> Open -> Project/Solution`.
3. Navigujte do priečinku `src/AppsLab-002-ConsoleWriteLine` a vyberte súbor `AppsLab-002-ConsoleWriteLine.csproj`.
4. Kliknite na `Debug -> Start Debugging` alebo stlačte `F5` na klávesnici.

#### Visual Studio Code

1. Otvorte Visual Studio Code.
2. Kliknite na `File -> Open Folder`.
3. Navigujte do priečinku `src/AppsLab-002-ConsoleWriteLine` a kliknite na `Select Folder`.
4. Otvorte terminál (kliknite na `View -> Terminal`).
5. V termináli zadajte príkaz `dotnet run` a stlačte `Enter`.

Majte na pamäti, že pred spustením projektu musíte mať nainštalovaný .NET 7. Ak ho nemáte nainštalovaný, môžete ho stiahnuť a nainštalovať z [oficiálnej webovej stránky .NET](https://dotnet.microsoft.com/download).

Nezabudnite, že po dokončení každého cvičenia by ste mali sledovať rovnaký postup pre commit a push vašich zmien na váš fork repozitára na GitHub-e.

Držíme vám palce pri riešení úloh!

### 1. Aplikácia "Ahoj, svet!"

Upravte konzolovú aplikáciu, aby vypísala "Ahoj, svet!" pomocou `Console.WriteLine` namiesto "Hello, World!".

### 2. Výpis premennej

Upravte konzolovú aplikáciu, aby deklarovala premennú s názvom `name` typu `string` s vaším menom a vypíše "Ahoj, [Vaše Meno]!" pomocou `Console.WriteLine`.

### 3. Výpis text faces

Upravte konzolovú aplikáciu, aby vypísala pomocou `Console.WriteLine` textovú tvár zo stránky [https://texteditor.com/text-faces/](https://texteditor.com/text-faces/) - napr. "¯\\_(ツ)_/¯".

> [Špeciálne znaky a Console.WriteLine](/lekcie/Console.WriteLine_special_characters.md)

### 4. Výpis so znakmi potrebujúcimi escape sekvenciu

Upravte konzolovú aplikáciu, tak aby vypísala reťazec obsahujúci špeciálne znaky (ako úvodzovky) pomocou `Console.WriteLine` a escape sekvencií.

### 5. Viacriadkový výpis

Vytvorte konzolovú aplikáciu, ktorá vypíše viacriadkový reťazec (napr. báseň alebo text piesne) pomocou `Console.WriteLine`.

---

## Užitočné linky

- [Console.WriteLine Method](https://learn.microsoft.com/en-us/dotnet/api/system.console.writeline?view=net-7.0)
