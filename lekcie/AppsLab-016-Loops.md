# Cykly v `C#`

Cykly sú jedným z najdôležitejších konceptov v programovaní. Umožňujú nám opakovane vykonávať určitý blok kódu. C# poskytuje niekoľko typov cyklov: `while`, `for` a `foreach`.

## While cyklus

Cyklus `while` je jeden z cyklov v C#. Pozostáva z podmienky a bloku kódu. Blok kódu sa opakuje, kým je podmienka pravdivá.

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

V tomto príklade je blok kódu (dve príkazy) vykonaný päťkrát. Počiatočná hodnota `i` je 0 a po každom prechode cyklom sa zvyšuje o jedna. Keď `i` dosiahne 5, podmienka `i < 5` sa stane nepravdivou a cyklus sa ukončí.

## For cyklus

Cyklus `for` je špeciálne prispôsobený na situácie, kedy presne vieme, koľkokrát chceme nejaký kód opakovať. Skladá sa z troch častí: inicializácie, podmienky a inkrementácie.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

V tomto príklade je opäť blok kódu vykonaný päťkrát. Prvá časť `for` cyklu (`int i = 0;`) nastavuje počiatočnú hodnotu. Druhá časť (`i < 5;`) je podmienka, ktorá musí byť pravdivá, aby sa cyklus mohol pokračovať. Tretia časť (`i++`) sa vykonáva po každom prechode cyklom.

## Foreach cyklus

Cyklus `foreach` je špeciálne navrhnutý pre prácu s kolekciami a poliami. Umožňuje prechádzať každým prvkom bez potreby vedieť, koľko prvkov kolekcia alebo pole obsahuje.

```csharp
string[] names = { "John", "Jane", "Alex" };

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

V tomto príklade cyklus `foreach` prechádza každým prvkom poľa `names`. Pre každý prvok vypíše jeho hodnotu na konzolu.

Cykly sú dôležité v rôznych aspektoch programovania - či už ide o prechádzanie cez prvky poľa alebo kolekcie, opakované vykonávanie kódu, kým je splnená určitá podmienka, alebo generovanie opakujúcich sa vzorcov. Čím lepšie ovládate prácu s cyklami, tým efektívnejšie budete schopní riešiť rôzne programovacie úlohy.

## Zložitejšie využitie cyklov

Cykly môžeme využiť na mnoho zaujímavých vecí. Pozrime sa na niekoľko príkladov:

### Sčítanie prvkov poľa

Predstavme si, že máme pole celých čísel a chceme vypočítať ich súčet. Môžeme to urobiť pomocou cyklu `for`.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);  // vypíše 15
```

Použili sme `numbers.Length` na získanie počtu prvkov v poli. Cyklus `for` sa potom opakuje pre každý prvok a sčíta hodnoty do premennej `sum`.

### Hľadanie prvku v poli

Pomocou cyklu môžeme aj prechádzať cez pole a hľadať konkrétny prvok.

```csharp
string[] names = { "John", "Jane", "Alex" };
string search = "Jane";
bool found = false;

foreach (string name in names)
{
    if (name == search)
    {
        found = true;
        break;
    }
}

Console.WriteLine(found ? "Found" : "Not Found");
```

Cyklus `foreach` prechádza každým prvkom poľa `names`. Ak nájde zhodu s hľadaným menom, nastaví premennú `found` na `true` a ukončí cyklus pomocou príkazu `break`.

Tieto príklady sú len špičkou ľadovca toho, čo môžete s cyklami dosiahnuť. Sú základným nástrojom v arsenále každého programátora a čím viac ich budete používať, tým lepšie budete rozumieť, ako a kedy ich využiť.

### Využitie `while` cyklu

Cyklus `while` je ďalším druhom cyklu, ktorý môže byť obzvlášť užitočný, keď neviete presne, koľkokrát sa cyklus má opakovať. `while` cyklus vykonáva blok kódu tak dlho, pokiaľ je podmienka pravdivá.

Predstavme si situáciu, kde máte číslo a chcete ho deliť dvoma, až kým nebude menšie alebo rovné jednej. Toto je ideálna situácia pre využitie `while` cyklu:

```csharp
double number = 32;

while (number > 1)
{
    number /= 2;
}

Console.WriteLine(number);
```

V tomto príklade, `while` cyklus sa opakuje, kým `number` je väčšie ako 1. Po každom opakovaní, `number` je delené dvoma.

### Využitie `do-while` cyklu

`do-while` cyklus je podobný `while` cyklu, s tým rozdielom, že podmienka je kontrolovaná až po vykonaní bloku kódu. To znamená, že blok kódu sa vždy vykoná aspoň raz.

Predstavme si, že chcete generovať náhodné čísla, až kým nevygenerujete číslo menšie ako 0.5. Môžete to urobiť pomocou `do-while` cyklu:

```csharp
Random random = new Random();
double number;

do
{
    number = random.NextDouble();
}
while (number >= 0.5);

Console.WriteLine(number);  // vypíše číslo menšie ako 0.5
```

> [Ako pracovať s triedou Random?](/lekcie/Random.md)

V tomto príklade, `do-while` cyklus generuje náhodné číslo (medzi 0 a 1) a pokračuje, pokiaľ je číslo väčšie alebo rovné 0.5. Keďže podmienka je kontrolovaná až po vykonaní bloku kódu, garantujeme, že aspoň jedno náhodné číslo bude vygenerované.

### Cvičenie: Štatistika počasia

V projekte v adresári `src\AppsLab-016-Loops` už je vytvorená trieda `WeatherStats` s prázdnymi metódami, ktoré potrebujete implementovať.

**Úloha 1: Metóda `AverageTemperature`**

Táto metóda prijíma pole `double` hodnôt reprezentujúcich teploty za posledné dni. Vašou úlohou je doplniť implementáciu, aby metóda vrátila priemernú hodnotu týchto teplôt.

**Úloha 2: Metóda `MaxTemperature`**

Táto metóda prijíma pole `double` hodnôt reprezentujúcich teploty za posledné dni. Vašou úlohou je doplniť implementáciu, aby metóda vrátila najvyššiu nameranú teplotu.

**Úloha 3: Metóda `MinTemperature`**

Táto metóda prijíma pole `double` hodnôt reprezentujúcich teploty za posledné dni. Vašou úlohou je doplniť implementáciu, aby metóda vrátila najnižšiu nameranú teplotu.

**Poznámka:** Predpokladajte, že vstupné pole je vždy platné a má aspoň jednu hodnotu.

Po dokončení implementácie si môžete svoju prácu otestovať pomocou unit testov, ktoré sú k dispozícii v projekte `AppsLab-016-Loops.Tests`.

Unit testy spustíte nasledujúcim spôsobom:
> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.

Cykly sú dôležitým nástrojom pri programovaní a je dôležité, aby ste vedeli, kedy a ako ich využiť. Prax je kľúčom k úspechu, takže neváhajte a vyskúšajte si vytvoriť svoje vlastné príklady!

## Ďalšie štúdium

Pre viac informácií o cykloch navštívte oficiálnu dokumentáciu Microsoftu na nasledujúcom odkaze:

[C# if statements and loops - conditional logic tutorial](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops-local)

Študovanie týchto zdrojov vám umožní lepšie pochopiť a efektívne využívať cykly v C#.

## Bonusové cvičenia

1. **Súčet čísel:** Napíšte program, ktorý bude od užívateľa žiadať čísla až kým neuvedie číslo 0. Po zadaní nuly, program vypíše súčet všetkých zadanych čísel.

2. **Faktoriál:** Faktoriál čísla n je súčin všetkých celých čísel od 1 po n. Napíšte metódu, ktorá vráti faktoriál zadaného čísla.

3. **Ciferný súčet:** Ciferný súčet čísla je súčet všetkých jeho cifier. Napíšte metódu, ktorá vypočíta ciferný súčet zadaného čísla.

4. **Suma párnych a nepárnych čísel:** Napíšte program, ktorý spočíta sumu párnych a nepárnych čísel zadaných vo vstupnom poli.

5. **Inverzia poradia prvkov v poli:** Napíšte program, ktorý inverzuje poradie prvkov v poli. Napríklad pre pole `[1, 2, 3, 4, 5]` by výsledkom bolo `[5, 4, 3, 2, 1]`.

6. **Odpočítavanie**: Vytvorte konzolovú aplikáciu, ktorá odpočíta od zadanej hodnoty k nule. Použite `for` cyklus na odpočítavanie.
