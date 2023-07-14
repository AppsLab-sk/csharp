# `C#` Súvisiace koncepty (Related Concepts) - XML

## Úvod

XML (eXtensible Markup Language) je jazyk, ktorý umožňuje definovať vlastné značky na označenie dát a ich štruktúr. Je veľmi populárny pre svoju jednoduchosť a univerzálnosť - dáta vo formáte XML možno ľahko prenášať a čítať na rôznych platformách a v rôznych jazykoch.

C# poskytuje niekoľko spôsobov, ako pracovať s XML, ale v tomto príklade sa zameriame na triedu `XDocument`.

## Čo je trieda XDocument?

Trieda `XDocument` je súčasťou knižnice LINQ to XML v .NET a je určená na manipuláciu s XML dátami. S touto triedou môžete vytvárať, čítať, modifikovať a ukladať XML dokumenty.

## Ako načítať XML dokument

Môžete načítať XML dokument z reťazca, súboru alebo URL. Príklad načítania XML z reťazca je nasledovný:

```csharp
string xmlString = "<books><book><name>Moja kniha</name></book></books>";
XDocument doc = XDocument.Parse(xmlString);
```

Ak chcete načítať XML z súboru, môžete použiť metódu `XDocument.Load()`. Napríklad:

```csharp
XDocument doc = XDocument.Load("myBooks.xml");
```

## Ako vytvoriť a uložiť XML dokument

Vytvorenie nového XML dokumentu je tiež veľmi jednoduché. Môžete použiť triedy `XElement` a `XAttribute` na vytvorenie prvkov a atribútov XML. Napríklad:

```csharp
XDocument doc = new XDocument(
    new XElement("books",
        new XElement("book",
            new XElement("name", "Moja kniha"),
            new XElement("author", "Ja"))));

doc.Save("myBooks.xml");
```

Toto vytvorí XML súbor s nasledujúcim obsahom:

```xml
<books>
  <book>
    <name>Moja kniha</nazov>
    <author>Ja</autor>
  </book>
</books>
```

Existujú rôzne spôsoby, ako pracovať s XML dátami v triede `XDocument`. Môžete napríklad prechádzať prvky pomocou metód `Descendants` alebo `Elements`, vyhľadávať prvky pomocou metódy `XPathSelectElements`, modifikovať prvky a ich obsah a mnoho ďalších.

Prejdite do priečinka "src\AppsLab-031-XML" a použite konzolovú aplikáciu s názvom `"AppsLab-031-XML"`, kde môžete experimentovať s triedou `XDocument` a ďalšími triedami LINQ pre XML.
