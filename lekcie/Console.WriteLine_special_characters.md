# Špeciálne znaky a Console.WriteLine

Pri použití `Console.WriteLine` v jazyku C# môže byť niekedy potrebné pracovať so špeciálnymi znakmi, ako sú úvodzovky `"` alebo lomítka `\`. V týchto prípadoch je potrebné použiť tzv. "escape sekvencie", aby sa tieto špeciálne znaky správne vypísali na konzolu.

"Escape sekvencia" je postupnosť znakov, ktorá začína spätným lomítkom (`\`) a signalizuje kompilátoru, že nasledujúci znak má špeciálny význam. Napríklad, ak chcete vypísať dvojité úvodzovky v reťazci, môžete použiť escape sekvenciu `\"`.

Príklad:

```csharp
Console.WriteLine("Toto je \"špeciálny\" reťazec.");
```

V tomto prípade by sa na konzolu vypísalo: Toto je "špeciálny" reťazec.

Podobne, ak chcete vypísať spätné lomítko, môžete použiť dvojité spätné lomítka `\\`.

Príklad:

```csharp
Console.WriteLine("Cesta k súboru je C:\\Program Files\\Subor.txt");
```

Na konzolu by sa vypísalo: Cesta k súboru je C:\Program Files\Subor.txt

Existuje aj niekoľko ďalších escape sekvencií, ktoré môžete v C# používať, napríklad:

- `\n` pre nový riadok
- `\t` pre tabulátor
- `\a` pre zvukový signál

Pri práci s týmito špeciálnymi znakmi je dôležité pamätať na to, že ich správne použitie pomáha udržiavať váš kód čitateľný a funkčný.

V jazyku C# môžete pred reťazec umiestniť znak `@`. Tento znak nazývame "verbatim string literal" a jeho použitie mení spôsob, akým kompilátor spracováva špeciálne znaky a escape sekvencie v reťazci.

Ak umiestnite `@` pred reťazec, kompilátor spracuje reťazec presne tak, ako je napísaný, bez ohľadu na escape sekvencie. To je užitočné napríklad pri práci s cestami k súborom, kde sa často vyskytujú spätné lomítka.

Napríklad:

```csharp
Console.WriteLine(@"Cesta k súboru je C:\Program Files\Subor.txt");
```

V tomto prípade sa na konzolu vypíše: Cesta k súboru je `C:\Program Files\Subor.txt`

Keďže sme použili `@` pred reťazcom, nemusíme použiť dvojité spätné lomítka pre vypísanie jedného spätného lomítka.

Taktiež, keď použijete `@`, nové riadky vo vašom reťazci sa zachovajú. Takže, ak máte v reťazci viacero riadkov, všetky sa zobrazia pri výpise na konzolu.

Napríklad:

```csharp
Console.WriteLine(@"Toto je reťazec
rozložený na
viacero riadkov");
```

Na konzolu sa vypíše presne to, čo je v reťazci, vrátane nových riadkov:

``` terminal
Toto je reťazec
rozložený na
viacero riadkov
```

Použitie `@` môže urobiť váš kód čitateľnejším, keď pracujete s reťazcami obsahujúcimi špeciálne znaky alebo formátovaním na viacero riadkov.
