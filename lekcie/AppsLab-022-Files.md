# Práca so súbormi v `C#`

V tejto časti sa budeme zaoberať prácou so súbormi v jazyku C#. C# poskytuje niekoľko tried a metód na čítanie a zápis do súborov, vrátane `File`, `FileInfo`, `FileStream`, `StreamReader`, `StreamWriter` atď. Pre jednoduchosť sa v tejto lekcii zameriame na triedy `File` a `File.ReadAllText`, `File.WriteAllText`.

## Vytvorenie a zápis do súboru

Ak chceme vytvoriť nový textový súbor a zapísať doň nejaký text, môžeme použiť metódu `File.WriteAllText`. Táto metóda vytvorí súbor, ak neexistuje, a zapíše doň určený text. Ak súbor už existuje, prepíše jeho obsah.

Ukážme si príklad:

```csharp
string filename = @"C:\Temp\MyFile.txt";
string text = "Ahoj, svet!";

File.WriteAllText(filename, text);
```

V tomto príklade sme vytvorili súbor `MyFile.txt` v adresári `C:\Temp` a zapísali doň text `"Ahoj, svet!"`.

Poznámka: Pritom musí existovať priečinok `"C:\Temp\"`.

## Čítanie zo súboru

Ak chceme prečítať obsah textového súboru, môžeme použiť metódu `File.ReadAllText`. Táto metóda načíta celý obsah súboru do reťazca.

Ukážme si príklad:

```csharp
string filename = @"C:\Temp\MyFile.txt";

string text = File.ReadAllText(filename);

Console.WriteLine(text);
```

V tomto príklade sme prečítali obsah súboru `MyFile.txt` a vypísali ho na konzolu.

## Pridávanie textu do súboru

Ak chceme pridať text do existujúceho súboru namiesto toho, aby sme jeho obsah prepísali, môžeme použiť metódu `File.AppendAllText`.

Ukážme si príklad:

```csharp
string filename = @"C:\Temp\MyText.txt";
string text = " Dobrý deň!";

File.AppendAllText(filename, text);
```

V tomto príklade sme pridali text `" Dobrý deň!"` na koniec súboru `MyFile.txt`.

Poznámka: Musí existovať súbor `MyFile.txt` v priečinku `C:\Temp\`.

## Zhrnutie

Trieda `File` v jazyku C# poskytuje jednoduché na čítanie a zápis do súborov. V tejto lekcii sme sa pozreli na to, ako vytvoriť súbor a zapísať doň text, ako prečítať obsah súboru a ako pridať text do existujúceho súboru. V budúcnosti sa pozrieme na to, ako spracovávať chyby pri práci so súbormi a ako používať ďalšie metódy a triedy na prácu so súbormi v jazyku C#.

## Ďalšie štúdium

Pre viac informácií o práce so súbormi navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Use Visual C# to read from and write to a text file](https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať súbory v C#.

## Možné úlohy na precvičenie práce so súbormi

Tu je zoznam niekoľkých jednoduchých a zábavných príkladov na konzolové aplikácie v C#, ktoré sa zameriavajú na prácu so súborami:

1. **Čítač slov:** Vytvorte program, ktorý prečíta textový súbor a spočíta počet slov.

2. **Denník:** Napíšte konzolovú aplikáciu, ktorá umožní používateľovi písať denníkové záznamy, ktoré sa ukladajú do textového súboru.

3. **Správca receptov:** Vytvorte aplikáciu na ukladanie a získavanie receptov na varenie. Používatelia môžu pridávať, odstraňovať a vyhľadávať recepty uložené v textových súboroch.

4. **Kontaktný zoznam:** Napíšte jednoduchú aplikáciu na ukladanie kontaktov, ktorá umožňuje používateľovi pridať, odstrániť, upraviť a vyhľadať kontakty v textovom súbore.

5. **To-Do List:** Vytvorte konzolovú aplikáciu pre to-do list (zoznam úloh), kde môžu používatelia pridať úlohy, označiť ich ako hotové a zobraziť svoje úlohy. Údaje ukladajte do textového súbore.

6. **Generátor kvízov:** Vytvorte konzolovú aplikáciu kvízu, ktorá načíta otázky a odpovede z textového súboru.

7. **Prekladač Morseovej abecedy:** Napíšte program, ktorý prekladá anglický text do Morseovej abecedy a naopak. Kódy pre jednotlivé znaky môžu byť uložené v textovom súbore.

Tieto cvičenia pomôžu zlepšiť vaše schopnosti manipulácie so súbormi v C# a tiež rozšíriť vaše všeobecné programovacie zručnosti.

Pracujte v konzolovom projekte `src\AppsLab-022-Files`.

Po dokončení úlohy nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
