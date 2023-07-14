# .NET knižnice a NuGet balíčky (.NET libraries and NuGet packages)

.NET knižnice a NuGet balíčky sú dôležitou súčasťou .NET ekosystému. Majú veľkú hodnotu pre vašu aplikáciu, keďže sú často používané pre znovupoužitie kódu a pre rozšírenie funkcionality vašich aplikácií. Poďme sa teda pozrieť, čo to vlastne sú a ako ich používať.

## Čo sú .NET knižnice?

.NET knižnice sú kusy kódu, ktoré boli napísané a skompilované do DLL (Dynamic Link Library) súborov. Tieto knižnice môžu obsahovať triedy, metódy a vlastnosti, ktoré môžu byť použité v iných .NET projektoch. To znamená, že kód, ktorý bol napísaný a otestovaný raz, môže byť znova použitý bez toho, aby ste ho museli znova písať.

## Čo sú NuGet balíčky?

NuGet je správca balíčkov pre .NET. Balíček NuGet je jednoducho spôsob, ako distribuovať kusy softvéru. Tieto balíčky môžu obsahovať .NET knižnice, ale aj iné súčasti, ako sú nástroje, skripty alebo dokonca obrázky a štýly pre webové projekty. NuGet balíčky môžete hľadať a inštalovať priamo z Visual Studio alebo môžete použiť NuGet CLI (Command Line Interface).

## Ako používať NuGet balíčky?

NuGet balíčky môžete inštalovať do svojho projektu priamo z Visual Studio. Postup je nasledovný:

1. V riešení pravým kliknutím na váš projekt a zvoľte možnosť `"Manage NuGet Packages..."`.
2. Na obrazovke, ktorá sa zobrazí, prejdite na kartu `"Browse"`.
3. Do vyhľadávacieho poľa zadajte názov balíčka, ktorý chcete inštalovať. Napríklad, ak chcete inštalovať populárny balíček `"Newtonsoft.Json"` pre prácu s JSON, jednoducho zadajte `"Newtonsoft.Json"`.
4. Keď nájdete balíček, ktorý chcete inštalovať, kliknite na neho a potom na tlačidlo `"Install"`.
5. Potvrďte inštaláciu a súhlas s licenčnými podmienkami, ak sa zobrazia.

Po inštalácii balíčka môžete používať triedy a metódy, ktoré balíček poskytuje, v rámci vášho kódu. Môžete to urobiť pridaním príslušného `using` príkazu na vrchu svojho súboru.

## Ako používať .NET knižnice?

Ak máte DLL súbor pre .NET knižnicu, môžete ho pridať do svojho projektu nasledovne:

1. V `Solution Explorer` pravým kliknutím na váš projekt a zvoľte možnosť `"Add"` > `"Reference..."`.
2. Na obrazovke, ktorá sa zobrazí, prejdite na kartu `"Browse"` a nájdite a vyberte DLL súbor, ktorý chcete pridať.
3. Kliknite na tlačidlo "OK".

Ako pri NuGet balíčkoch, môžete potom používať triedy a metódy z knižnice v rámci vášho kódu pridaním príslušného `using` príkazu na vrch svojho súboru.

## Prečo by ste sa mali naučiť používať .NET knižnice a NuGet balíčky?

.NET knižnice a NuGet balíčky sú dôležité, pretože vám umožňujú znovu používať kód a pridať funkcionalitu do vašich aplikácií bez toho, aby ste museli písať všetko od nuly. Toto znamená, že môžete rýchlejšie a efektívnejšie vytvárať robustné a funkčné aplikácie. Mnoho bežných úloh, ako napríklad práca s databázami, práca s dátumami a časom, manipulácia s reťazcami a mnoho ďalších, už boli vyriešené v týchto balíčkoch. Použitím týchto hotových riešení môžete ušetriť čas a energiu a sústrediť sa na jedinečné aspekty vašej aplikácie.

## Príklad

V projekte `"AppsLab-033-NuGet"` v adresári `"src\AppsLab-033-NuGet"` vytvorte jednoduchú konzolovú aplikáciu, ktorá používa NuGet balíček `"Newtonsoft.Json"`. Tento balíček je veľmi užitočný pre prácu s JSON dátami.

```csharp
using Newtonsoft.Json;
using System;

namespace AppsLab_033_NuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "Jano", Age = 25 };

            string json = JsonConvert.SerializeObject(person, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}
```

V tomto príklade sme vytvorili anonymný objekt `person` a potom sme ho previedli na JSON reťazec pomocou metódy `JsonConvert.SerializeObject` z balíčka `"Newtonsoft.Json"`. Toto je jednoduchý príklad, ako môžete používať kód z NuGet balíčka vo vašom projekte.
