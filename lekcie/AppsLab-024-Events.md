# Udalosti (Events) v `C#`

Udalosti sú dôležitou súčasťou programovania v C#. Umožňujú jednému objektu oznámiť iným objektom, keď určitá činnosť alebo udalosť nastane. Táto metóda komunikácie medzi objektami je veľmi užitočná v situáciách, kedy jeden objekt potrebuje byť informovaný o zmene v inom objekte, ale nechce byť neustále aktívny a sledovať ten objekt.

Pozrime sa na príklad. Predstavme si, že máme časovač (timer), ktorý každú sekundu generuje udalosť. Objekt, ktorý sleduje tento časovač, sa môže "prihlásiť" k odberu týchto udalostí a zareagovať na ne tak, že napríklad vypíše aktuálny čas na konzolu.

Teraz sa pozrieme, ako by sme mohli implementovať takýto systém v C#.

## Vytvorenie časovača a jeho udalostí

V našom projekte `src\AppsLab-024-Events` vytvoríme jednoduchú triedu `MyTimer`, ktorá bude generovať udalosť každú sekundu.

```csharp
using System;
using System.Timers;

public class MyTimer
{
    private Timer timer;

    public event Action Tick;

    public MyTimer()
    {
        timer = new Timer(1000);
        timer.Elapsed += HandleTick;
        timer.Start();
    }

    private void HandleTick(Object source, ElapsedEventArgs e)
    {
        Tick?.Invoke();
    }
}
```

V tejto triede `MyTimer` vytvárame udalosť `Tick`, ktorá je typu `Action`. Toto je delegát, ktorý označuje metódu, ktorá nevracia hodnotu a nemá žiadne parametre. Ak chceme, aby udalosť mala parametre, môžeme použiť iný typ delegáta, napríklad `Func<T>` alebo `Action<T>`.

V konštruktore vytvárame nový časovač, ktorý vysiela udalosť `Elapsed` každú sekundu (1000 ms). Potom sa prihlásime k tejto udalosti a spustíme časovač.

Metóda `HandleTick` je volaná, keď časovač vysiela udalosť `Elapsed`. Táto metóda potom vysiela našu vlastnú udalosť `Tick`.

## Odoberanie udalostí

Teraz, keď máme triedu, ktorá generuje udalosti, môžeme vytvoriť objekt, ktorý sa prihlási na odber týchto udalostí.

```csharp
var timer = new MyTimer();

timer.Tick += () =>
{
    Console.WriteLine(DateTime.Now);
};

// Necháme hlavný vlákno bežať, aby časovač mohol generovať udalosti
while (true)
{
}
```

V metóde `Program.cs` vytvárame nový objekt `MyTimer` a prihlásime sa na odber jeho udalosti `Tick`. Keď časovač generuje udalosť `Tick`, naša lambda funkcia sa vykoná a vypíše aktuálny čas na konzolu.

Dôležité je si uvedomiť, že náš hlavný program musí pokračovať v behu, aby mohol časovač generovať udalosti. Ak by sme okamžite ukončili hlavný program, časovač by sa zastavil a už by negeneroval žiadne udalosti. Preto máme nekonečný cyklus `while (true)`, ktorý nechá hlavný program bežať.

Takto jednoduchý príklad ukazuje, ako fungujú udalosti v C#. Udalosti sú veľmi užitočné v mnohých rôznych situáciách, napríklad pri programovaní GUI, kde sa môžu vyskytnúť udalosti ako kliknutie na tlačidlo, zmena textu v textovom poli a podobne. Ak si zvyknete na používanie udalostí, otvorí sa vám nový svet možností pri tvorbe sofistikovanejších a interaktívnejších aplikácií.

V našom príklade sme použili `Action` ako typ našej udalosti `Tick`, pretože sme nepotrebovali poskytnúť žiadne ďalšie informácie spolu s touto udalosťou. `Action` je jednoduchý delegát, ktorý reprezentuje metódu, ktorá nevracia žiadnu hodnotu a nemá žiadne parametre.

Na druhej strane, `EventHandler` je typ delegáta, ktorý sa štandardne používa pri vytváraní udalostí v .NET. Je definovaný ako metóda, ktorá nevracia žiadnu hodnotu, ale prijíma dva parametre: `sender` a `e`. `Sender` je objekt, ktorý vyvolal udalosť, a `e` je objekt, ktorý obsahuje dodatočné dáta o udalosti.

`EventHandler` je užitočný, keď chcete spolu s udalosťou poslať aj ďalšie informácie. Napríklad, ak máte udalosť `ButtonClick`, mohli by ste chcieť poslať informácie o tom, ktoré tlačidlo bolo stlačené, alebo aké sú jeho súradnice.

V našom prípade sme chceli len signalizovať, že prebehla jedna sekunda, a nemuseli sme posielať žiadne ďalšie informácie. Preto sme sa rozhodli použiť jednoduchší `Action` namiesto `EventHandler`.

## Ďalšie štúdium

Pre viac informácií o udalostiach navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Handle and raise events](https://learn.microsoft.com/en-us/dotnet/standard/events/)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať udalosti (eventy) v C#.

## Možné úlohy na precvičenie práce s udalosťami

1. **Textové dobrodružná hra**: Vytvorte jednoduchú textovú dobrodružnú hru, kde užívateľ môže preskúmať miestnosti, nájsť predmety a poraziť nepriateľov zadaním príkazov. Môžete pridať udalosti, ako napríklad "ItemFound" alebo "EnemyKilled".

2. **Test rýchlosti písania**: Napíšte program, ktorý testuje rýchlosť písania užívateľa. Generujte náhodnú vetu, nechajte užívateľa napísať vetu a potom zobrazte jeho slová za minútu. Môžete pridať udalosti ako "TestStarted" alebo "TestFinished".

3. **Virtuálny domáci miláčik**: Vytvorte virtuálneho domáceho miláčika, ktorého užívateľ môže kŕmiť, hrať sa s ním a starať sa o neho. Môžete pridať udalosti, ako je "PetHungry" alebo "PetTired".

Pamätajte, že tieto cvičenia sú určené na to, aby ste sa naučili riešiť problémy, navrhovať aplikácie a písať čistý a efektívny kód. Nebojte sa zabrať do projektu, ktorý sa zdá byť náročný - takto sa môžete rozvíjať ako vývojár!

Pracujte v konzolovom projekte `src\AppsLab-024-Events`.

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.




## Možné úlohy na precvičenie práce so súbormi