# Výnimky (Exceptions) v `C#`

V tejto časti sa budeme zaoberať výnimkami (Exceptions) v jazyku C#. Výnimky sú udalosti, ktoré sa vyskytnú počas vykonávania programu a narušia normálny chod programu. Môžu byť spôsobené rôznymi dôvodmi, napríklad nesprávnymi vstupnými údajmi, problémami so sieťou, prekročením rozsahu, atp.

Jazyk C# poskytuje podporu pre riešenie výnimiek pomocou špeciálneho bloku kódu, ktorý je navrhnutý tak, aby zachytil výnimku a správne ju ošetril (Error Handling). To je dôležité, pretože výnimky môžu viesť k neočakávanému ukončeniu programu, ak sa nezachytia a nezvládnu správne.

Tu je základná štruktúra kódu na ošetrovanie výnimiek v jazyku C#:

```csharp
try
{
    // Kód, ktorý môže vyvolať výnimku
}
catch (Exception ex)
{
    // Kód na spracovanie výnimky
}
finally
{
    // Kód, ktorý sa vykoná bez ohľadu na to, či výnimka nastala alebo nie
}
```

- `try`: Tento blok obsahuje kód, ktorý môže vyvolať výnimku.

- `catch`: Tento blok obsahuje kód na spracovanie výnimky. Ak nastane výnimka v bloku `try`, výkon sa presunie do príslušného bloku `catch`.

- `finally`: Tento blok obsahuje kód, ktorý sa vykoná bez ohľadu na to, či výnimka nastala alebo nie.

Pozrime sa na jednoduchý príklad:

```csharp
try
{
    int[] pole = new int[5];
    pole[10] = 100; // Toto vyvolá IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Výnimka: {ex.Message}");
}
finally
{
    Console.WriteLine("Tento blok kódu sa vykoná vždy.");
}
```

V tomto príklade sa pokúsime pristupovať k indexu, ktorý je mimo rozsahu poľa, čo vyvolá výnimku typu `IndexOutOfRangeException` (index mimo rozsah). Túto výnimku potom zachytíme a vypíšeme jej správu.

Vždy by ste sa mali snažiť ošetrovať len tie výnimky, ktoré dokážete správne spracovať. Ak výnimku ošetríte a potom ju necháte pokračovať (t.z., vyvoláte ju opäť), môže to byť zavádzajúce pre ostatné časti kódu, ktoré sa snažia tú istú výnimku ošetriť.

Je tiež dobré používať vlastné výnimky na oznámenie chybových stavov vo vašom kóde. Môžete to dosiahnuť vytvorením novej triedy, ktorá dedí od triedy `Exception` alebo niektorého z jej potomkov.

## Príklady výnimiek

Teraz sa pozrieme na niekoľko špecifických typov výnimiek, ktoré sa môžu vyskytnúť v jazyku C#.

Všetky výnimky v jazyku C# sú odvodené od triedy `System.Exception`.

Niektoré z bežnejšie používaných typov výnimiek sú:

- `System.NullReferenceException`: Táto výnimka nastáva, keď sa pokúsite pracovať s objektom, ktorý je nastavený na `null`.

- `System.DivideByZeroException`: Táto výnimka nastáva, keď sa pokúsite deliť číslom nula.

- `System.IndexOutOfRangeException`: Táto výnimka nastáva, keď sa pokúsite pristupovať k prvku poľa alebo zoznamu pomocou indexu, ktorý je mimo rozsahu.

- `System.InvalidCastException`: Táto výnimka nastáva, keď sa pokúsite previesť hodnotu na typ, na ktorý sa nedá previesť.

- `System.IO.IOException`: Táto výnimka nastáva pri chybe vstupu/výstupu, napríklad pri čítaní alebo zápise do súboru, ktorý neexistuje alebo k nemu nemáte prístup.

- `System.OutOfMemoryException`: Táto výnimka nastáva, keď aplikácia nemá dostatok pamäte na pokračovanie v prevádzke.

- `System.StackOverflowException`: Táto výnimka nastáva, keď dôjde k pretečeniu zásobníka, čo je často spôsobené príliš veľkým množstvom rekurzívnych volaní.

**Poznámka:**

Zásobník (anglicky stack) je štruktúra údajov, ktorá sa využíva na ukladanie informácií o volaniach funkcií alebo metód. Keď voláte metódu, informácie o tomto volaní (vrátane lokálnych premenných) sa uložia na vrchol zásobníka. Keď sa metóda ukončí, tieto informácie sa odstránia zo zásobníka.

Keď dojde k veľkému množstvu vnorených alebo rekurzívnych volaní metód (metóda, ktorá volá samu seba), zásobník môže "pretiecť". To znamená, že dosiahne maximálnu veľkosť, ktorú môže mať, a systém už nemôže pridávať ďalšie informácie. To spôsobí `System.StackOverflowException`.

Webová stránka [StackOverflow.com](https://stackoverflow.com/) je populárna komunita programátorov, ktorí si navzájom pomáhajú s problémami, na ktoré narazili pri programovaní. Názov stránky je odkaz na tento typ výnimky - symbolizuje miesto, kde môžu programátori hľadať pomoc, keď narazia na problémy (alebo "výnimky") v ich kóde.

Pozrime sa teraz na príklad, kde narábame s niekoľkými z týchto výnimiek:

```csharp
try
{
    int[] pole = new int[5];
    pole[10] = 100; // Toto vyvolá IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Výnimka: {ex.Message}");
}

try
{
    object obj = null;
    Console.WriteLine(obj.ToString()); // Toto vyvolá NullReferenceException
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Výnimka: {ex.Message}");
}

try
{
    int x = 10;
    int y = 0;
    Console.WriteLine(x / y); // Toto vyvolá DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Výnimka: {ex.Message}");
}
```

Ako môžete vidieť, každý blok `try` môže obsahovať viacero blokov `catch`, aby sa ošetrili rôzne typy výnimiek. Môžete tiež použiť všeobecnú výnimku `Exception` na ošetrenie akéhokoľvek typu výnimky, ale je to všeobecne považované za menej ideálne, pretože by ste mali snažiť ošetrovať iba tie výnimky, ktoré viete správne spracovať.

## Bezné výnimky

Poďme sa pozrieť na niektoré bežné výnimky, kedy a prečo ich používame:

- `ArgumentException`: Túto výnimku by ste mali "vyhodiť" (throw), keď je nejaký argument, ktorý ste dostali do metódy, neplatný. Teda napríklad, ak očakávate kladné číslo, ale dostanete záporné, môžete "vyhodiť" (throw) `ArgumentException`.

- `ArgumentNullException`: Táto výnimka je špeciálny prípad `ArgumentException`. Môžete ju použiť, keď je argument metódy `null`, ale vy očakávate, že bude mať nejakú hodnotu.

- `InvalidOperationException`: Túto výnimku by ste mali hádzať, keď sa pokúsite vykonať operáciu, ktorá nie je platná v aktuálnom stave objektu. Napríklad, keď sa pokúsite odstrániť prvok zo zoznamu, ktorý je prázdny.

Pozrime sa na príklady, kedy by sme mohli použiť tieto výnimky:

```csharp
void SetAge(int age)
{
    if (age < 0)
    {
        throw new ArgumentException("Age cannot be negative number!");
    }
}

void SetName(string name)
{
    if (name == null)
    {
        throw new ArgumentNullException(nameof(name));
    }
}

List<int> numbers = new List<int>();
void Remove()
{
    if (numbers.Count == 0)
    {
        throw new InvalidOperationException("List is empty!");
    }
}
```

Tu vidíme, že `ArgumentException` a `ArgumentNullException` sa používajú na kontrolu platnosti argumentov metódy, zatiaľ čo `InvalidOperationException` kontroluje platnosť operácie vzhľadom na aktuálny stav objektu.

"Vyhodenie" (throw) týchto výnimiek nám umožňuje oznámiť chyby čo najskôr, hneď ako zistíme, že niečo nie je v poriadku. Toto nám pomáha predchádzať chybám, ktoré by sa mohli vyskytnúť neskôr a boli by ťažšie lokalizovať a opraviť.

## Ďalšie štúdium

Pre viac informácií o výnimkách navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Exceptions and Exception Handling](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať výnimky v C#.

## Možné úlohy na precvičenie práce so výnimkami

Teraz, keď ste sa naučili, ako pracovať s výnimkami v C#, je dobrý čas vrátiť k vašim predchádzajúcim cvičeniam a zamyslieť sa, kde by zmysluplné použitie spracovania chýb vylepšilo vaše riešenia.

Predstavte si, že máte metódu, ktorá ako parameter očakáva číslo. Čo sa stane, ak táto metóda dostane namiesto čísla prázdny reťazec alebo null? Alebo čo keď očakávate, že súbor bude existovať na určitej ceste, ale keď sa pokúsite o jeho otvorenie, zistíte, že tam nie je? To sú situácie, kedy spracovanie výnimiek môže byť veľmi užitočné.

Jedným zo základných princípov programovania je "Očakávajte neočakávané". Spracovanie výnimiek vám umožňuje očakávať a správne reagovať na rôzne neočakávané situácie, ktoré môžu nastať pri vykonávaní vášho programu.

Takže, choďte späť k svojim predchádzajúcim cvičeniam a skúste nájsť miesta, kde by ste mohli pridať spracovanie výnimiek. Je to skvelý spôsob, ako sa naučiť používať to, čo ste sa práve naučili, a zároveň zlepšiť svoje existujúce riešenia!
