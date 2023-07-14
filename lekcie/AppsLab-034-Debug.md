# Debugovanie a testovanie (Debugging and testing) v `C#`

Keď programujete, nie vždy všetko ide hladko. Niektoré chyby v kóde môžu byť zrejmé hneď, ako ich napíšete, ale iné sa môžu skrývať a prejaviť až pri konkrétnych situáciách. Na identifikáciu a opravu týchto chýb sa používa proces nazývaný debugovanie. Testovanie je zase proces, kedy overujeme, že naša aplikácia funguje tak, ako očakávame.

V tomto tutoriáli sa naučíme základy debugovania a testovania v C#.

## 1. Debugovanie v `C#`

Jedným z najdôležitejších nástrojov, ktorý vývojári používajú na identifikáciu problémov v kóde, je debugger. Debugger je nástroj, ktorý vám umožňuje spustiť váš program krok za krokom, sledovať hodnoty premenných a analyzovať chovanie vášho kódu.

Predtým, než začneme, otvorte si váš projekt v IDE. Vo Visual Studiu môžete na ľavej strane vidieť uzký sivý pás vedľa každého riadka kódu. Kliknutím na tento pás vložíte do kódu tzv. breakpoint, čo je miesto, kde sa váš program zastaví, keď ho debugujete.

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Ahoj svet!"); // Pridajte sem breakpoint kliknutím do sivého pasu na ľavej strane vo vašom Visual Studio 2022
}
```

Keď máte breakpoint, môžete spustiť váš program v debug móde. Vo Visual Studiu to urobíte kliknutím na tlačidlo s chybovým symbolom alebo stlačením klávesy `F5`. Keď program dosiahne riadok s breakpointom, zastaví sa. Potom môžete krokovať kód krok za krokom a sledovať hodnoty premenných.

## 2. Testovanie v `C#`

Ak chcete zabezpečiť, aby váš kód fungoval správne, mali by ste ho otestovať. Na testovanie môžeme použiť unit testy. Unit test je kód, ktorý testuje konkrétnu funkciu alebo metódu vo vašom programe.

Vytvorme si jednoduchý testovací príklad. Predstavme si, že máme triedu `Calculator` s metódou `Add`, ktorá sčíta dve čísla. Chceme overiť, či táto metóda skutočne správne sčíta čísla. Na to vytvoríme unit test:

```csharp
[Test]
public void Add_ReturnsCorrectResult()
{
    // Arrange
    var calculator = new Calculator();

    // Act
    var result = calculator.Add(1, 2);

    // Assert
    Assert.That(result, Is.EqualTo(3));
}
```

Unit testy sú veľmi silný nástroj, ktorý vám umožní urobiť váš kód spoľahlivejší a ľahšie udržiavateľný.

Ak chcete, pozrite si existujúce unit testy napísané pre naše cvičenia pod adresárom `"\tests\"`.

## Zhrnutie

Debugovanie a testovanie sú dva kľúčové aspekty vývoja softvéru, ktoré vám pomôžu identifikovať a opraviť chyby vo vašom kóde. Debugovanie vám umožní sledovať a analyzovať chovanie vášho kódu, zatiaľ čo testovanie vám umožní overiť, že váš kód funguje správne.

V prípade otázok alebo problémov s týmito konceptmi sa neváhajte obrátiť na vašich lab mastrov. Sú tu, aby vám pomohli naučiť sa tieto dôležité zručnosti.

Nakoniec, skúste si vytvoriť vlastné debugovacie scenáre a unit testy pre svoje existujúce projekty. Je to skvelý spôsob, ako tieto koncepty zúročiť v praxi!
