# AppsLab-003-Comments - Práca s komentármi

V tomto cvičení sa naučíme, ako pracovať s komentármi v jazyku C#. Komentáre sú časť kódu, ktorú kompilátor pri preklade ignoruje. Slúžia na vysvetlenie kódu a sú užitočné pre ľudí čítajúcich a udržiavajúcich kód.

Existujú dva druhy komentárov v C#:

- **Jednoriadkový komentár**: začína sa dvojitým lomítkom `//`. Kompilátor ignoruje všetko, čo nasleduje po týchto dvoch lomítkach na tom istom riadku.

- **Viacriadkový komentár**: začína sa lomítkom a hviezdičkou `/*` a končí sa hviezdičkou a lomítkom `*/`. Kompilátor ignoruje všetko medzi týmito dvoma sekvenciami, čo môže byť na jednom alebo na viacerých riadkoch.

Vašou úlohou v tomto cvičení je pridať do hlavného programu `Program.cs` v projekte `src\AppsLab-002-ConsoleWriteLine` nasledujúce komentáre:

1. Pred volanie `Console.WriteLine("Hello World!");` pridajte jednoriadkový komentár, ktorý vysvetlí, čo táto metóda robí.

2. Na koniec súboru `Program.cs` pridajte viacriadkový komentár, ktorý vysvetlí, čo celý program robí.

Tento program by mohol vyzerať napríklad takto:

```csharp
// vypíše na konzolu reťazec "Hello World!"
Console.WriteLine("Hello World!");

/* Tento program je jednoduchá konzolová aplikácia v jazyku C#, ktorá pri spustení vypíše na konzolu reťazec "Hello World!". 
Slúži na demonštráciu základného použitia metódy Console.WriteLine a práce s komentármi v jazyku C#. */
```

Nezabudnite, že po dokončení tohto cvičenia by ste mali dať commit a push vašich zmien na váš fork repozitára na GitHub-e.
