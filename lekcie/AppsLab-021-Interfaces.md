# Úvod do rozhraní (Interfaces) v jazyku `C#`

## Čo je rozhranie (interface)?

Rozhranie v programovaní definuje kontrakt (contract) medzi objektom a svetom mimo neho. Hovorí, čo objekt dokáže robiť. Rozhranie môže obsahovať deklarácie metód, vlastností, udalostí alebo indexov. Všetky tieto prvky sú vždy verejné a nemajú žiadnu implementáciu (teda žiadny kód, ktorý by definuje, ako majú tieto metódy fungovať).

## Ako definovať rozhranie v C#?

Rozhranie v C# definujeme pomocou kľúčového slova `interface`. 

Poďme vytvoriť jednoduché rozhranie:

```csharp
public interface IRunner
{
    void Run();
}
```

Toto rozhranie definuje jeden kontrakt - akýkoľvek objekt, ktorý implementuje toto rozhranie, musí mať metódu `Run`.

## Ako implementovať rozhranie?

Rozhranie implementujeme v triede pomocou kľúčového slova `:`, nasledovaného názvom rozhrania. Napríklad:

```csharp
public class Human : IRunner
{
    public void Run()
    {
        Console.WriteLine("Human is running!");
    }
}
```

V tejto triede `Human` implementujeme rozhranie `IRunner` a definujeme, ako metóda `Run` funguje.

## Kedy a ako používať rozhrania?

Rozhrania sú veľmi užitočné, keď chceme zabezpečiť, že určitá trieda bude mať určitý set metód, alebo ak chceme definovať, aké metódy musí implementovať trieda, aby sa dala použiť v určitom kontexte. Napríklad, ak máme metódu, ktorá očakáva objekt s metódou `Run`, môžeme namiesto konkrétnej triedy ako parameter metódy zadať rozhranie `IRunner`.

Rozhrania tiež umožňujú viacnásobnú dedičnosť - trieda môže implementovať viacero rozhraní.

```csharp
public interface IRunner
{
    void Run();
}

public interface ISwimmer
{
    void Swim();
}

public class Triathlete : IRunner, ISwimmer
{
    public void Run()
    {
        Console.WriteLine("Triathlete is running!");
    }

    public void Swim()
    {
        Console.WriteLine("Triathlete is swimming!");
    }
}
```

V tomto príklade trieda `Triathlete` implementuje dve rozhrania - `IRunner` a `ISwimmer`. To znamená, že musí poskytnúť implementáciu pre metódy `Run` a `Swim`.

Takže rozhrania nám pomáhajú vytvárať kód, ktorý je flexibilnejší a lepšie štrukturovaný. Sú základným stavebným kameňom v objektovo orientovanom programovaní a dizajne.

## Default implementácie v rozhraniach

Od verzie C# 8.0 môžeme definovať predvolené implementácie metód v rozhraniach. To znamená, že môžeme poskytnúť základnú implementáciu, ktorá môže byť prepísaná v triedach, ktoré rozhranie implementujú.

Ukážme si to na príklade. Máme rozhranie `IRunner` a chceme pridať metódu `WarmUp`, ktorá bude mať základnú implementáciu.

```csharp
public interface IRunner
{
    void Run();
    
    void WarmUp()
    {
        Console.WriteLine("Default warm-up.");
    }
}
```

Ak teraz implementujeme toto rozhranie v triede, môžeme si vybrať, či chceme metódu `WarmUp` prepísať, alebo použiť predvolenú implementáciu.

```csharp
public class Human : IRunner
{
    public void Run()
    {
        Console.WriteLine("Human is running!");
    }

    // môžeme prepísať metódu WarmUp
    public void WarmUp()
    {
        Console.WriteLine("Human is warming up!");
    }
}
```

V tomto prípade sme sa rozhodli prepísať metódu `WarmUp` v triede `Human`. Keby sme to neurobili, použila by sa predvolená implementácia z rozhrania.

## Zhrnutie

Rozhrania v C# sú mocným nástrojom, ktorý nám umožňuje definovať kontrakty pre triedy a zabezpečiť, že určité metódy budú prítomné. Tiež nám umožňujú vytvárať flexibilnejší a lepšie štrukturovaný kód. Rozhrania sú základným stavebným kameňom v objektovo orientovanom programovaní a dizajne.

## Ďalšie štúdium

Pre viac informácií o interfaces navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Interfaces - define behavior for multiple types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať interfaces v C#.

## Možné úlohy na precvičenie rozhraní

1. **Textové dobrodružstvo**: Vytvor konzolovú hru, kde hráč môže preskúmavať miestnosti, nachádzať predmety a porážať nepriateľov pomocou príkazov. Rozhrania by sa mohli použiť na definovanie vlastností predmetov a nepriateľov.

2. **Zoznam kontaktov**: Navrhnite jednoduchý zoznam kontaktov, kde môže užívateľ pridávať, odstraňovať, upravovať a vyhľadávať kontakty. Rozhrania by sa mohli použiť na definovanie operácií so zoznamom kontaktov.

3. **Kvízová aplikácia**: Vytvorte kvíz s otázkami s viacerými možnosťami. Rozhrania by sa mohli použiť na definovanie štruktúry otázok a odpovedí.

4. **To-Do List**: Vytvorte konzolovú aplikáciu to-do list, kde môže užívateľ pridávať úlohy, označiť úlohy ako hotové a zobraziť svoje úlohy. Rozhrania by sa mohli použiť na definovanie operácií so zoznamom úloh.

5. **Simulátor Bitky RPG**: Rozšírte základný systém bitky pre hru na hrdinov (RPG) z predchádzajúceho cvičenia. Môžete mať triedy postáv, schopnosti a jednoduchú AI pre nepriateľov. Rozhrania by sa mohli použiť na definovanie vlastností postáv a nepriateľov.

Pracujte v konzolovom projekte `src\AppsLab-021-Interfaces`.

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
