# AppsLab - 001 - Začíname tu

Tento projekt je určený pre prvú úlohu v našom kurze C#. Vašou úlohou je zmeniť výsledok funkcie `Hello()` tak, aby namiesto reťazca `"Hello World!"` vrátila `"Hello AppsLab!"`.

## Kde urobiť zmeny

V priečinku `src\AppsLab-001-StartHere` nájdete súbor `Greetings.cs`. Tento súbor obsahuje triedu `Greetings` s funkciou `Hello()`. Úpravte túto funkciu tak, aby namiesto reťazca `"Hello World!"` vrátila `"Hello AppsLab!"`.

Váš upravený kód by mal vyzerať takto:

```csharp
namespace AppsLab_001_StartHere
{
    public class Greetings
    {
        public string Hello()
        {
            return "Hello AppsLab!";
        }
    }
}
```

## Testovanie vašich zmien

Aby ste overili, či vaše zmeny sú správne, mali by ste spustiť jednotkové (unit) testy. Testy nájdete v priečinku `tests\AppsLab-001-StartHere.Tests` v súbore `GreetingsTests.cs`.

Tento súbor obsahuje triedu `GreetingsTests` s testovacou metódou `HelloAppsLab()`. Táto metóda overuje, či funkcia `Hello()` vráti `"Hello AppsLab!"`.

Po správnom vykonaní úprav by mal tento test prejsť.

## Spustenie testov

Pre spustenie testov je potrebné sa navigovať do priečinka `tests\AppsLab-001-StartHere.Tests`.

Môžete to urobiť otvorením terminálu a zadáním nasledujúceho príkazu:

``` terminal
cd tests\AppsLab-001-StartHere.Tests
```

Následne môžete spustiť testy príkazom `dotnet test`. Tento príkaz spustí len tie testy, ktoré sú relevantné pre túto konkrétnu úlohu.

Veľa šťastia a dobre sa zabavte!
