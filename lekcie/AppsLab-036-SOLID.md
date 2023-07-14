# Zásady SOLID (SOLID Principles)

## Úvod

SOLID je akronym, ktorý sa označuje päť základných princípov objektovo orientovaného programovania a návrhu. Tieto princípy vám pomôžu vytvárať aplikácie, ktoré sú ľahko udržiavateľné, rozšíriteľné. Aj keď sú tieto princípy určené pre objektovo orientované programovanie, sú užitočné a uplatniteľné aj v iných paradigách programovania.

## Single Responsibility Principle (SRP) - Princíp jednej zodpovednosti

Každá trieda by mala mať iba jednu zodpovednosť. Inými slovami, jedna trieda by mala byť zodpovedná len za jednu vec. Ak sa zmení požiadavka týkajúca sa tejto jednej veci, potom by sa mala zmeniť iba táto trieda.

```csharp
// Nesprávne
public class User
{
    public void Add() { /* pridáva užívateľa */ }
    public void Get() { /* získava užívateľa */ }
    public void SaveToFile(string filePath) { /* ukladá užívateľa do súboru */ }
}

// Správne
public class User
{
    public void Add() { /* pridáva užívateľa */ }
    public void Get() { /* získava užívateľa */ }
}

public class FileManager
{
    public void SaveToFile(User user, string filePath) { /* ukladá užívateľa do súboru */ }
}
```

## Open/Closed Principle (OCP) - Princíp otvorenosti/zatvorenosti

Triedy by mali byť otvorené pre rozšírenie, ale zatvorené pre úpravy. To znamená, že by sme mali byť schopní pridať nové funkcionality bez toho, aby sme museli meniť existujúci kód.

```csharp
public class Rectangle
{
    public double Height { get; set; }
    public double Width { get; set; }
}

public class AreaCalculator
{
    public double TotalArea(Rectangle[] rectangles)
    {
        double area = 0;
        foreach(var rectangle in rectangles)
        {
            area += rectangle.Height * rectangle.Width;
        }
        return area;
    }
}
```

V tomto príklade je trieda `AreaCalculator` závislá na triede `Rectangle`. Ak by sme chceli pridať podporu pre výpočet plochy kruhu, museli by sme zmeniť kód triedy `AreaCalculator`. Ak by sme chceli dodržať princíp otvorenosti/zatvorenosti, mohli by sme vytvoriť abstraktnú triedu alebo rozhranie `Shape` s metódou `Area()` a nechať `Rectangle` a `Circle` implementovať toto rozhranie.

## Liskov Substitution Principle (LSP) - Princíp náhrady Liskovovej

Podtriedy musia byť schopné nahradiť ich základné triedy bez toho, aby to ovplyvnilo správnosť programu. Inými slovami, metódy, ktoré používajú ukazatele na základné triedy, by mali byť schopné používať objekty podtried bez toho, aby o tom vedeli.

```csharp
public class Bird
{
    public virtual void Fly() 
    {
        // kód pre let
    }
}

public class Duck : Bird { }

public class Ostrich : Bird
{
    public override void Fly() 
    {
        throw new Exception("Cannot fly.");
    }
}
```

V tomto príklade, trieda Ostrich (pštros) je podtriedou Bird (vták), ale pštrosi nevedia lietať. Teda ak máme kód, ktorý očakáva, že všetky vtáky môžu lietať, tak máme problém. LSP nám hovorí, že by sme mali štruktúrovať naše triedy a dedičnosť tak, aby takéto porušenie nevzniklo.

## Interface Segregation Principle (ISP) - Princíp segregácie rozhraní

Žiadna trieda by nemala byť nútená implementovať metódy, ktoré nepoužíva. Každé rozhranie by malo byť špecifické pre jednu funkciu alebo funkcionalitu a nemalo by obsahovať metódy, ktoré by nemuseli byť vždy relevantné pre triedy, ktoré ho implementujú.

```csharp
// Nesprávne
public interface IWorker
{
    void Work();
    void Eat();
}

public class Robot : IWorker
{
    public void Work() { /* kód pre prácu */ }
    public void Eat() { /* Roboti nejedia! */ }
}

// Správne
public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public class Human : IWorker, IEater
{
    public void Work() { /* kód pre prácu */ }
    public void Eat() { /* kód pre jedenie */ }
}

public class Robot : IWorker
{
    public void Work() { /* kód pre prácu */ }
}
```

## Dependency Inversion Principle (DIP) - Princíp inverzie závislostí

Vysokej úrovni moduly by nemali závisieť na moduloch nízkej úrovne. Obe by mali závisieť na abstrakciách. Abstrakcie by nemali závisieť na detailoch. Detaily by mali závisieť na abstrakciách.

To znamená, že by sme mali programovať na úrovni rozhraní, nie implementácií. Tento princíp nám umožňuje vytvárať flexibilnejšie a odolnejšie systémy, pretože zmeny v jednej časti systému nemusia ovplyvňovať ostatné časti.

```csharp
public class PasswordReminder
{
    private IDatabase _db;

    public PasswordReminder(IDatabase db)
    {
        _db = db;
    }

    // ...
}
```

V tomto príklade trieda `PasswordReminder` nie je závislá na konkrétnej implementácii databázy, ale na abstrakcii `IDatabase`. Takže ak sa zmení databázový systém, nemusíme meniť kód triedy `PasswordReminder`.

Tieto princípy nám pomáhajú vytvárať kód, ktorý je ľahko udržiavateľný, rozšíriteľný a testovateľný. Ale ako všetko v programovaní, aj tieto princípy by sa mali používať s rozumom a nie slepo. Vždy by sme mali brať do úvahy konkrétny kontext a požiadavky našich projektov.
