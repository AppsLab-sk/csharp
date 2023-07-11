# Vytvorenie konzolovej aplikácie v C# pomocou príkazového riadka .NET, Visual Studio 2022, alebo Visual Studio Code

V tejto príručke vám ukážem, ako vytvoriť konzolovú aplikáciu v C# v špecifickom adresári `src\AppsLab-004-Variables\` pomocou Visual Studio 2022, Visual Studio Code alebo príkazového riadka `dotnet`.

## Použitie Visual Studio 2022

1. Spustite Visual Studio 2022.
2. Kliknite na "Create a new project".
3. Vo wizardovi pre vytvorenie nového projektu vyberte šablónu `Console App` (A project for creating a command-line application that can run on .NET on Windows, Linux and macOS).
4. Kliknite na tlačidlo "Next".
5. Zadajte názov projektu `AppsLab-004-Variables` a umiestnenie (`src\AppsLab-004-Variables\`) pod vaším naklonovaným `csharp` repozitárom.
6. Kliknite na tlačidlo "Next".
7. Zvoľte Framework `.NET 7 (Standard Term Support)`.
8. Kliknite na tlačidlo "Create".

Týmto ste vytvorili nový konzolový projekt .NET pomocou Visual Studio 2022.

## Použitie Visual Studio Code

1. Spustite Visual Studio Code.
2. Otvorte terminál (View -> Terminal).
3. Prejdite do priečinka, v ktorom chcete vytvoriť svoj projekt (`src\AppsLab-004-Variables\`) pod vaším naklonovaným `csharp` repozitárom.

``` terminal
cd src\AppsLab-004-Variables\
```

4. Vytvorte nový konzolový projekt .NET pomocou príkazu `dotnet new console`.

```
dotnet new console
```

5. Po vytvorení projektu môžete otvoriť priečinok projektu vo Visual Studio Code (File -> Open Folder).

Týmto ste vytvorili nový konzolový projekt .NET pomocou Visual Studio Code.

## Použitie príkazového riadka .NET

1. Otvorte terminál.
2. Prejdite do priečinka, v ktorom chcete vytvoriť svoj projekt. V našom prípade to bude `src\AppsLab-004-Variables\`.

    ```
    cd src\AppsLab-004-Variables\
    ```

3. Teraz môžeme vytvoriť nový konzolový projekt .NET použitím príkazu `dotnet new console`.

    ```
    dotnet new console
    ```

Týmto ste vytvorili nový konzolový projekt s `dotnet` príkazom.

---

Teraz môžete začať programovať vo svojom novom konzolovom projekte. Nezabudnite, že po dokončení práce by ste mali commit a push vašich zmien na váš fork repozitára na GitHub.
