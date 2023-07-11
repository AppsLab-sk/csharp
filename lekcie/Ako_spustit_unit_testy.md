# Ako spustiť unit testy

Spustenie testov vám umožní skontrolovať, či vaše riešenie správne funguje. Testy sú už pripravené a vy ich môžete spustiť pomocou jednej z nasledujúcich metód:

## Visual Studio 2022

1. Otvorte riešenie (.sln súbor) v programe Visual Studio.
2. V okne `Test Explorer` (na pravej strane) môžete vidieť všetky dostupné testy.
   - Ak okno `Test Explorer` nevidíte, môžete ho zobraziť v menu prejdite na `Test` -> `Test Explorer`.
3. Ak chcete spustiť všetky testy, kliknite na tlačidlo `Run All Tests` v hornej časti okna `Test Explorer`.
4. Ak chcete spustiť len konkrétne testy pre cvičenie, rozbalte v `Test Explorer` zložku s názvom konkrétneho cvičenia a kliknite pravým tlačítkom myši na test, ktorý chcete spustiť, a potom kliknite na `Run Selected Tests`.

Poznámka: Ak všetky testy prejdú úspešne, znamená to, že ste úlohu správne vyriešili. Ak nejaký test zlyhá, prečítajte si jeho chybovú správu - môže vám pomôcť pochopiť, čo je na vašom riešení nesprávne.

## Visual Studio Code

1. Otvorte priečinok cvičenia v programe Visual Studio Code.
2. Otvorte terminál (`Ctrl+~`).

Terminál vám umožňuje navigovať medzi priečinkami vo vašom projekte pomocou príkazu `cd`:

- `cd nazov_priecinka` - presunie vás do priečinka `nazov_priecinka`.
- `cd ..` - presunie vás o jednu úroveň vyššie.

3. Prejdite do konkrétnej zložky testov. Napríklad, ak je názov zložky testov `AppsLab-007-Casting.Tests`, zadajte `cd AppsLab-007-Casting.Tests`.
4. Zadajte príkaz `dotnet test`.

Navigáciou do konkrétnej zložky testov obmedzíte spustené testy len na konkrétne cvičenie. Ak testy prejdú, úlohu ste správne vyriešili. Ak test zlyhá, chybová správa vám pomôže identifikovať, čo je na vašom riešení nesprávne.

## Terminál

1. Otvorte terminál.

Môžete navigovať medzi priečinkami vo vašom projekte pomocou príkazu `cd`:

- `cd nazov_priecinka` - presunie vás do priečinka `nazov_priecinka`.
- `cd ..` - presunie vás o jednu úroveň vyššie.

2. Prejdite do priečinku cvičenia s testami. Ak je názov priečinka cvičenia `tests\AppsLab-007-Casting.Tests\`, zadajte `cd tests\AppsLab-007-Casting.Tests\`.
3. Zadajte príkaz `dotnet test`.

Týmto spôsobom obmedzíte spustené testy len na konkrétne cvičenie. Ak všetky testy prejdú úspešne, znamená to, že ste úlohu správne vyriešili. Ak nejaký test zlyhá, prečítajte si jeho chybovú správu - môže vám pomôcť pochopiť, čo je na vašom riešení nesprávne.
