# Objektovo orientované programovanie (OOP)

Objektovo orientované programovanie (OOP) je paradigmou programovania, ktorá používa "objekty" - inštancie tried - na modelovanie a organizáciu aplikácií. OOP sa zameriava na tvorbu kódu, ktorý je znovupoužiteľný, flexibilný a ľahko sa udržiava. Existujú štyri základné koncepty OOP:

1. zapuzdrenie (encapsulation),
2. dedičnosť (inheritance),
3. polymorfizmus (polymorphism) a
4. abstrakcia (abstraction).

## Triedy a objekty

Trieda je definícia alebo "plán" pre vytvorenie objektu. Definuje štruktúru a správanie objektu. **Objekt je inštancia triedy.**

```csharp
public class Animal // Trieda
{
    public string Name { get; set; } // Vlastnosť

    public void Speak() // Metóda
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

Animal myAnimal = new Animal(); // myAnimal predstavuje Objekt typu Animal
```

## Syntax

Trieda definuje, aké vlastnosti (data) a metódy (funkcie) budú mať objekty vytvorené z tejto triedy. Syntax triedy v C# je nasledovná:

```csharp
public class ClassName
{
    // vlastnosti
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    // metódy
    public void Method1()
    {
        // kód metódy
    }

    public int Method2(int parameter)
    {
        // kód metódy
        return 0; // návratová hodnota metódy
    }
}
```

Kde:

- `public` je modifikátor prístupu, ktorý určuje, kde môže byť trieda prístupná. `public` znamená, že trieda je prístupná odkiaľkoľvek v kóde.
- `class` je kľúčové slovo použité na označenie, že ide o definíciu triedy.
- `ClassName` je názov triedy. Zvyčajne používame veľké písmená na začiatku každého slova v názve triedy (tzv. PascalCase).
- `{}` sú zložené zátvorky, ktoré obklopujú telo triedy.
- Vlastnosti (properties) a metódy sú členovia triedy. Reprezentujú dáta a správanie triedy.

Objekt je konkrétna inštancia triedy. Keď vytvoríte objekt z triedy, vytvoríte v pamäti miesto, kde sa skladujú jeho vlastnosti, a kde je možné volať jeho metódy. Objekt sa vytvára pomocou kľúčového slova `new` nasledovne:

```csharp
ClassName myObject = new ClassName();
```

Kde:

- `ClassName` je názov triedy, z ktorej vytvárate objekt.
- `myObject` je názov premennej, ktorá bude držať referenciu na objekt.
- `new` je kľúčové slovo použité na vytvorenie objektu.
- `ClassName()` je konštruktor triedy, ktorý sa volá, keď sa vytvára nový objekt.

## Zapuzdrenie (Encapsulation)

Enkapsulácia je jedným zo základných princípov objektovo orientovaného programovania. Tento princíp znamená, že stav objektu (jeho dáta) by mal byť skrytý pred ostatnými časťami programu/aplikácie a prístup k nemu by mal byť poskytnutý len prostredníctvom metód daného objektu, pripádne na to určenými vlastnosťami (properties).

V praxi sa enkapsulácia v C# dosahuje pomocou prístupových modifikátorov - `private`, `protected`, `public`, atď. Najčastejšie sú vlastnosti objektu nastavené na `private`, čo znamená, že k nim možno pristupovať len zvnútra danej triedy.

Pozrime sa na jednoduchý príklad:

```csharp
public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
```

V tomto príklade je field `balance` skrytý a chránený pred priamym prístupom. Je možné ho meniť len prostredníctvom metód `Deposit` a `Withdraw`. To nám umožňuje kontrolovať, ako sú tieto metódy používané - napríklad, zabezpečiť, že nemôžeme vložiť zápornú sumu alebo vybrať viac peňazí, ako je na účte.

Enkapsulácia je dôležitá pre dve hlavné dôvody:

1. **Bezpečnosť:** Skrýva a chráni dáta pred externým prístupom. Tým zabezpečuje, že dáta sa nemôžu zmeniť neúmyselne alebo na nesprávnom mieste v kóde.

2. **Flexibilita a udržateľnosť:** Zmeny vo vnútri triedy nemajú vplyv na ostatné časti programu, pokiaľ metódy zostávajú rovnaké. To umožňuje ľahšie a bezpečnejšie úpravy a rozširovanie kódu.

## Dedičnosť (Inheritance)

Dedičnosť je mechanizmus, ktorý umožňuje triede zdediť vlastnosti (properties) a metódy z inej triedy. Trieda, z ktorej sa dedí, sa nazýva nadradená (parent) trieda alebo trieda základná (base). Trieda, ktorá dedí, sa nazýva podradená (child) trieda alebo odvodená (derived) trieda.

```csharp
public class Mammal // Nadradená trieda (Parent class)
{
    public void Breathe()
    {
        Console.WriteLine("Breathing...");
    }
}

public class Dog : Mammal // Odvodená trieda (Derived class)
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}
```

Dedičnosť (Inheritance) je jeden z hlavných pilierov objektovo orientovaného programovania. Dedičnosť umožňuje definovať novú triedu na základe existujúcej triedy. Tento mechanizmus pomáha šetriť čas a znižovať duplicity v kóde tým, že umožňuje znovu použiť časti kódu z existujúcich tried.

Predstavme si to na príklade. Máme triedu `Vehicle`, ktorá má vlastnosti ako `Color`, `Weight` a metódu `Drive()`. Teraz potrebujeme definovať triedy `Car` a `Motorcycle`, ktoré majú tiež tieto vlastnosti a metódu. Namiesto toho, aby sme tieto vlastnosti a metódu definovali v každej z týchto tried, môžeme ich jednoducho zdediť z triedy `Vehicle`.

```csharp
public class Vehicle
{
    public string Color { get; set; }
    public double Weight { get; set; }

    public void Drive()
    {
        Console.WriteLine("Driving...");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
}
```

V tomto príklade, `Car` a `Motorcycle` sú odvodené triedy a `Vehicle` je ich základná trieda. `Car` a `Motorcycle` zdedili vlastnosti `Color` a `Weight`, a metódu `Drive()` z triedy `Vehicle`.

Takisto, dedičnosť umožňuje definovať "je to" vzťah medzi objektmi - `Car` je typom `Vehicle`, `Motorcycle` je tiež typom `Vehicle`.

Dedičnosť je preto dôležitá, pretože nám umožňuje vytvárať komplexnejšie modely v našom kóde, znižovať duplicitu a zlepšovať znovupoužiteľnosť kódu.

## Polymorfizmus (Polymorphism)

Polymorfizmus umožňuje objektom nadobudnúť mnoho foriem. V C#, existujú dva druhy polymorfizmu - statický (pri preťažení metód) a dynamický (pri prepísaní metód).

```csharp
public class Animal 
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void MakeSound() // Prepísanie metódy
    {
        Console.WriteLine("The dog barks.");
    }
}
```

Slovo "polymorfizmus" pochádza z gréčtiny a znamená "mnoho foriem".

Existujú dva druhy polymorfizmu - statický (alebo skorý, kompilačný) a dynamický (alebo neskorý, behový).

Statický polymorfizmus je založený na preťažení metód. Metóda je preťažená, keď existuje viac metód s rovnakým názvom, ale s rôznymi parametrami.

> [AppsLab-019-MethodsOverloading](/lekcie/AppsLab-019-MethodsOverloading.md)

Dynamický polymorfizmus je založený na prepisovaní metód. Metóda je prepísaná, keď podtrieda poskytuje svoju vlastnú implementáciu metódy, ktorá už existuje v jej nadtriede.

Polymorfizmus je dôležitý, pretože poskytuje schopnosť:

- Implementovať metódy, ktoré sú v triedach rovnakého typu, ale majú rôzne správanie.
- Definovať metódy v nadtriede, ktoré môžu byť prepísané v podtriede, čím sa zlepšuje použiteľnosť kódu.
- Vytvárať flexibilné a rozšíriteľné programy.

Príklad:

```csharp
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Zvuk zvierata");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Haf haf");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Mňau mňau");
    }
}

// použitie v kóde
Animal myDog = new Dog();
Animal myCat = new Cat();
myDog.MakeSound();  // vypíše "Haf haf"
myCat.MakeSound();  // vypíše "Mňau mňau"
```

V tomto príklade trieda `Animal` má virtuálnu metódu `MakeSound`. Táto metóda je prepísaná v triedach `Dog` a `Cat`, čo sú podtriedy triedy `Animal`. Keď voláme metódu `MakeSound` na objektoch `myDog` a `myCat`, vyvolá sa príslušná prepísaná verzia metódy. Toto je príklad dynamického polymorfizmu.

## Abstrakcia (Abstraction)

Abstrakcia je proces, pri ktorom sa skryjú zložité detaily a zobrazia len dôležité. V C# sa to dosiahne pomocou abstraktných tried a rozhraní.
Je to koncept, ktorý umožňuje zjednodušiť zložité systémy tým, že ich rozdelí na menšie, zrozumiteľnejšie časti.

Abstrakcia v OOP je o skrytí komplexných detailov za jednoduchým rozhraním, čo umožňuje programátorom pracovať na vyššej úrovni komplexity bez potreby porozumenia všetkým detailom.

Uvažujme napríklad o triede `Car`:

```csharp
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void Drive()
    {
        // Logika pre jazdu
    }

    public void Stop()
    {
        // Logika pre zastavenie
    }
}
```

V tomto prípade `Car` je abstrakcia reálneho auta. Trieda `Car` definuje vlastnosti ako `Make`, `Model` a `Year` a metódy ako `Drive` a `Stop`. Ale skutočná implementácia, teda detaily, ako presne auto jazdí alebo ako sa zastaví, sú skryté (sú v tele metód `Drive` a `Stop`). Keď používame auto v našom kóde, nemusíme vedieť, ako presne funguje metóda `Drive` alebo `Stop`.

Toto je sila abstrakcie - umožňuje nám skryť detaily a zložitosť a poskytnúť jednoduché a čisté rozhranie, čo nám umožňuje lepšie pochopiť a efektívnejšie používať triedy a objekty v našom kóde.

Abstrakcia nám teda pomáha riešiť problémy na vyššej úrovni, bez toho aby sme museli rozumieť všetkým detailom. Týmto spôsobom nám abstrakcia pomáha zlepšiť čitateľnosť, údržbu a znovupoužiteľnosť nášho kódu.

---

OOP je silný nástroj, ktorý nám umožňuje vytvárať zložité aplikácie, ktoré sú ľahko udržiavateľné a rozšíriteľné. Čím viac sa zoznámite s týmito konceptmi a naučíte sa ich efektívne využívať, tým lepšie budete schopní vytvárať robustné a flexibilné aplikácie.

Super! Poďme sa teda teraz zabaviť s jednoduchým simulátorom bitky v RPG (role-playing game) štýle. Táto úloha vám pomôže lepšie pochopiť objektovo orientované programovanie, keďže budeme pracovať s niekoľkými triedami a metódami.

## Úloha

Pracovný adresár pre túto úlohu je `src\AppsLab-020-OOP`.

V tejto úlohe budete vytvárať jednoduchý RPG bitkový simulátor. Vytvorte triedy `Character`, `Enemy` a `Battle`. Každá z týchto tried bude mať rôzne vlastnosti a metódy.

- Trieda `Character` môže mať vlastnosti ako `Name`, `Health`, `AttackPower` a metódy ako `Attack()`, `Defend()`, `Heal()`.
- Trieda `Enemy` môže mať podobné vlastnosti a metódy ako trieda `Character`.
- Trieda `Battle` bude obsahovať metódy na simulovanie bitky medzi postavou a nepriateľom.

Pre zjednodušenie simulácie nech metóda `Attack()` jednoducho zníži hodnotu `Health` nepriateľa o hodnotu `AttackPower` postavy. Podobne, metóda `Defend()` môže jednoducho zvýšiť hodnotu `Health` postavy.

Môžete tiež experimentovať s rôznymi typmi postáv alebo nepriateľov pomocou dedičnosti - napríklad môže existovať špeciálna trieda `Wizard` alebo `Orc`, ktoré budú dediť z triedy `Character` alebo `Enemy`.

### Konzolová aplikácia

Môžete použiť konzolovú aplikáciu (`src\AppsLab-020-OOP`), ktorá bude používať vaše triedy na vytvorenie a simuláciu jednoduchého RPG bitkového simulátora. Takto môžete vidieť vaše triedy v akcii a manuálne otestovať ich funkčnosť.

Veľa šťastia a zábavy pri programovaní!

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.
