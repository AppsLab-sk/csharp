# Asynchrónne programovanie (Async Programming) v `C#`

## Úvod do Multithreadingu a použitia Task triedy v `C#`

Multithreading v C# je technika, ktorá umožňuje simultánne vykonávanie viacerých operácií vo vašom kóde. To môže výrazne zlepšiť výkonnosť aplikácie, najmä v prípadoch, kde musíte spracovať veľké množstvo dát, alebo vykonať operácie, ktoré by mohli trvať dlhú dobu a blokovať hlavné vlákno programu (napríklad čítanie z databázy alebo sťahovanie súborov z internetu).

C# poskytuje mnoho nástrojov na prácu s multithreadingom, ale jedným z najjednoduchších a najpopulárnejších spôsobov, ako implementovať multithreading, je pomocou triedy `Task`.

Trieda `Task` v C# reprezentuje jednu asynchrónnu operáciu, ktorá môže vrátiť hodnotu (ak používate triedu `Task<T>`). `Task` sa často používa v spojení s kľúčovými slovami `async` a `await`, ktoré vám umožňujú písať asynchrónny kód, ktorý je ľahko čitateľný a pochopiteľný.

Napríklad, tu je jednoduchý konzolový kód, ktorý demonštruje, ako môžete použiť `Task`:

```csharp
static async Task Main(string[] args)
{
    Console.WriteLine("Začiatok metódy Main.");

    Task task = DoWorkAsync();

    Console.WriteLine("Pokračujem v metóde Main zatiaľ čo DoWorkAsync beží na pozadí...");

    await task; // Počkáme, kým sa úloha dokončí.

    Console.WriteLine("Koniec metódy Main.");
}

static async Task DoWorkAsync()
{
    Console.WriteLine("Začiatok metódy DoWorkAsync.");

    // Predstavme si, že tu robíme nejakú dlhotrvajúcu operáciu.
    await Task.Delay(5000); // Pauza 5 sekúnd.

    Console.WriteLine("Koniec metódy DoWorkAsync.");
}
```

V tomto príklade, keď spustíme metódu `Main`, začne sa vykonávať metóda `DoWorkAsync` na pozadí. Zatiaľ čo `DoWorkAsync` beží na pozadí, metóda `Main` pokračuje v jej vykonávaní, kým sa nedostane na príkaz `await`, ktorý čaká, kým sa `DoWorkAsync` neukončí.

Kľúčové slovo `async` v deklaráciách metód znamená, že metóda môže obsahovať príkaz `await`, a `await` môže byť použitý len na metódy označené ako `async`.

Týmto spôsobom môžeme vykonávať dlhotrvajúce operácie na pozadí a zároveň udržiavať hlavný vlákno programu responzívne.

Povedzme, že chceme vytvoriť jednoduchú konzolovú aplikáciu, ktorá stiahne obsah webovej stránky. Táto operácia môže trvať nejaký čas, a preto by sme ju mali vykonať asynchrónne, aby sme neblokovali hlavné vlákno aplikácie.

Prvým krokom je vytvorenie metódy, ktorá vykoná metódu `HttpClient.GetStringAsync` na stiahnutie obsahu webovej stránky. Táto metóda vráti `Task<string>`, čo znamená, že je to asynchrónna operácia, ktorá vráti reťazec.

```csharp
static async Task<string> DownloadWebPageContent(string url)
{
    HttpClient client = new HttpClient();
    return await client.GetStringAsync(url);
}
```

Teraz môžeme túto metódu použiť v našej hlavnej metóde `Main`:

```csharp
static async Task Main(string[] args)
{
    Console.WriteLine("Začínam sťahovanie...");
    string content = await DownloadWebPageContent("http://example.com");
    Console.WriteLine("Sťahovanie dokončené. Obsah webovej stránky je:");
    Console.WriteLine(content);
}
```

V tomto kóde sa metóda `StiahniObsahWebovejStranky` spustí asynchrónne a hlavné vlákno aplikácie bude môcť pokračovať vo vykonávaní, kým čaká na dokončenie tejto operácie. Keď operácia skončí, jej výsledok sa priradí do premennej `content` a potom sa tento obsah vypíše na konzolu.

Dôležité je si všimnúť, že keď používame `await`, musíme označiť našu metódu kľúčovým slovom `async`. Toto nám umožní používať `await` v našej metóde. Ak by sme toto nevykonali, dostali by sme chybu kompilácie.

Týmto sme si ukázali základné použitie triedy `Task` pre asynchrónne programovanie v C#. Existujú aj pokročilejšie techniky, ako napríklad použitie `Task.Run` na vytvorenie nového vlákna, alebo použitie `Task.WhenAll` na čakanie na dokončenie viacerých úloh naraz, ale to už je mimo rámca tohto úvodu.

## Ďalšie štúdium

Pre viac informácií o asynchrónnom programovaní navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Asynchronous programming](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať asynchrónne programovanie v C#.

## Možné úlohy na precvičenie práce s asynchrónnym programovaním

Tu je zoznam niektorých úloh a návrh, ako by sa mohli použiť:

1. **Simulácia jednoduchej hry RPG:** Asynchrónne posielať informácie o bitke.
2. **Simulácia dopravného svetelného systému:** Posielať asynchrónne informácie o aktuálnej farbe.

V každom z týchto príkladov môžete využiť asynchrónne funkcie C# k dosiahnutiu lepšej efektívnosti a prirodzenejších interakcií. Môžete tiež experimentovať s použitím viacerých vlákien a zamykaním na zlepšenie synchronizácie a pre elimináciu možných problémov súvisiacich s asynchrónnym programovaním.
