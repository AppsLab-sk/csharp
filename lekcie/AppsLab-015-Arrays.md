# Polia (Arrays)

Polia v C# sú štruktúrou dát, ktorá umožňuje ukladať viacero prvkov rovnakého dátového typu do jednej premennej. Polia sú užitočné, keď chceme pracovať s množstvom hodnôt rovnakého typu.

## Definícia poľa

Ak chcete definovať pole, musíte určiť typ prvkov a počet prvkov v poli. Tu je príklad, ako môžete definovať pole typu `int` s piatimi prvkami:

```csharp
int[] numbers = new int[5];
```

V tomto prípade `new int[5]` vytvára pole s piatimi prvkami typu `int`.

## Práca s poľom

Hodnoty v poli môžete pristupovať pomocou indexu. Index je celé číslo, ktoré udáva polohu prvku v poli. Prvý prvok má index 0, druhý prvok index 1 atď.

Tu je príklad, ako môžete pristupovať k hodnotám v poli:

```csharp
int[] numbers = new int[5];
numbers[0] = 10;  // Prvý prvok
numbers[1] = 20;  // Druhý prvok
```

## Inicializácia poľa

Môžete inicializovať pole pri jeho definícii, teda priradiť mu hodnoty hneď pri vytvorení:

```csharp
int[] numbers = new int[] { 10, 20, 30, 40, 50 };
```

Alebo ešte stručnejšie:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

V tomto prípade nemusíte určovať veľkosť poľa, pretože kompilátor ju určí automaticky na základe počtu hodnôt.

## Dĺžka poľa

Môžete získať počet prvkov v poli pomocou vlastnosti `Length`. Napríklad:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
int length = numbers.Length;  // 5
```

## Prístup k prvkom v poli

Ako sme už spomenuli, k prvkom v poli môžeme pristupovať pomocou ich indexov. Prvý prvok má index 0, druhý prvok má index 1, atď.

```csharp
string[] names = { "Peter", "Paul", "Mary" };
Console.WriteLine(names[0]);  // Vypíše "Peter"
Console.WriteLine(names[1]);  // Vypíše "Paul"
Console.WriteLine(names[2]);  // Vypíše "Mary"
```

## Modifikácia prvkov v poli

Pomocou ich indexov môžeme meniť hodnoty prvkov v poli.

```csharp
int[] numbers = { 10, 20, 30 };
numbers[1] = 25;  // Zmení druhý prvok na 25
Console.WriteLine(numbers[1]);  // Vypíše 25
```

## Multidimenzionálne polia

V C# môžeme definovať aj multidimenzionálne polia, napríklad dvojrozmerné polia (maticu).

```csharp
int[,] matrix = new int[2, 2];
matrix[0, 0] = 1;  // Prvý riadok, prvý stĺpec
matrix[0, 1] = 2;  // Prvý riadok, druhý stĺpec
matrix[1, 0] = 3;  // Druhý riadok, prvý stĺpec
matrix[1, 1] = 4;  // Druhý riadok, druhý stĺpec
```

## Pozor na pretečenie

Pri práci s poiami je dôležité si uvedomiť, že prístup k prvku mimo rozsahu poľa (index je menší ako 0 alebo väčší alebo rovný počtu prvkov v poli) spôsobí výnimku typu `IndexOutOfRangeException`. Teda je vždy dôležité skontrolovať, že index je v správnom rozsahu.

```csharp
int[] numbers = { 10, 20, 30 };
// numbers[3] = 40;  // Vyhodí výnimku IndexOutOfRangeException
```

## Pole a reťazce

Reťazce v C# sú v skutočnosti polia znakov, takže môžeme pristupovať k jednotlivým znakom reťazca ako k prvkom poľa.

```csharp
string message = "Hello, World!";
Console.WriteLine(message[0]);  // Vypíše 'H'
Console.WriteLine(message[12]);  // Vypíše '!'
```

Polia v C# predstavujú kľúčový koncept tohto programovacieho jazyka, umožňujúci efektívne manipulovať s množstvom hodnôt rovnakého typu. Majú široké využitie v rôznorodých scenároch - od práce s dátami, manipulácie s reťazcami, cez spracovanie súborov a grafické programovanie, až po komplexné vedecké výpočty. Ich univerzálnosť a flexibilita umožňujú riešiť mnohé úlohy programovania. Čím hlbšie pochopíte ich vlastnosti a možnosti, ktoré poskytujú, tým efektívnejšie ich budete schopní využiť vo svojich projektoch.

## Cvičenie

V tejto úlohe budete pracovať s poľom čísel typu `int`. Vašou úlohou bude implementovať triedu `ArrayProcessor`, ktorá bude obsahovať metódy na manipuláciu s poľom čísel.

Máte k dispozícii projekt s názvom `AppsLab-015-Arrays`, ktorý sa nachádza v adresári `src`.

Vaša trieda `ArrayProcessor` by mala obsahovať tieto metódy:

1. `GetFirstElement`: Táto metóda by mala vrátiť prvý prvok poľa.
2. `GetLastElement`: Táto metóda by mala vrátiť posledný prvok poľa.
3. `GetElementAtPosition`: Táto metóda by mala vrátiť prvok poľa na zvolenej pozícii. Pozícia je parameter metódy.
4. `GetLength`: Táto metóda by mala vrátiť dĺžku poľa.

Tieto metódy budú musieť správne manipulovať s poľom a vrátiť správne hodnoty na základe vstupných parametrov. Ak je pole prázdne, metódy by mali vrátiť 0.

Pre implementáciu vašej triedy otvorte súbor `ArrayProcessor.cs`, ktorý nájdete v projekte `src\AppsLab-015-Arrays`. V tomto súbore už je pripravená šablóna pre triedu `ArrayProcessor`, do ktorej budete písať svoj kód.

Na základe pokynov uvedených vyššie implementujte metódy `GetFirstElement`, `GetLastElement`, `GetElementAtPosition` a `GetLength` v triede `ArrayProcessor`.

Po dokončení implementácie si môžete svoju prácu otestovať pomocou unit testov, ktoré sú k dispozícii v projekte `AppsLab-015-Arrays.Tests`.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

## Ďalšie štúdium

Pre viac informácií o poliach navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[Arrays (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať polia v C#.

## Bonusové cvičenia

1. **Párne a nepárne čísla**: Napíšte metódu, ktorá zoberie pole celých čísel ako vstup a vráti dve polia: jedno s párnymi a druhé s nepárnymi číslami.

2. **Hľadanie prvku**: Napíšte metódu, ktorá zoberie pole celých čísel a ďalšie číslo ako vstup. Táto metóda by mala vrátiť `true`, ak sa dané číslo nachádza v poli, alebo `false`, ak sa v poli nenachádza.

3. **Súčet čísel v poli**: Napíšte metódu, ktorá zoberie pole celých čísel ako vstup a vráti súčet všetkých čísel v tomto poli.

4. **Najväčší prvok**: Napíšte metódu, ktorá zoberie pole celých čísel ako vstup a vráti najväčšie číslo v tomto poli.

5. **Konkatenácia reťazcov**: Napíšte metódu, ktorá zoberie pole reťazcov ako vstup a vráti jeden reťazec, ktorý je spojením všetkých reťazcov v poli.
