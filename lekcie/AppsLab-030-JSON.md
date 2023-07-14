# `C#` Súvisiace koncepty (Related Concepts) - JSON

## Čo je JSON?

JSON (JavaScript Object Notation) je formát pre výmenu dát. Je to textový formát, ktorý je ľahko čitateľný pre ľudí a jednoduchý na spracovanie a generovanie pre počítače.

V C#, môžeme použiť `System.Text.Json` pre prácu s JSON. Pomocou tejto knižnice môžeme ľahko prevádzať C# objekty na JSON a naopak.

## Kedy používať JSON?

JSON sa bežne používa pri výmene dát medzi klientom a serverom v webových aplikáciách, ako aj pre konfiguračné súbory alebo pre ukladanie dát v ľahko čitateľnej forme.

## Ako používať JSON v C#?

V našej konzolovej aplikácii v "src\AppsLab-030-JSON" môžeme začať s vytvorením jednoduchého C# objektu a jeho prevodom na JSON. Predstavte si, že máme triedu `Student` s vlastnosťami `Name` a `Age`:

```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

Potom by sme mohli vytvoriť inštanciu tejto triedy a previesť ju na JSON:

```csharp
var student = new Student { Name = "Janko", Age = 21 };

string json = JsonSerializer.Serialize(student);
Console.WriteLine(json);
```

Výstup by bol JSON reťazec, ktorý vyzerá takto: `{"Name":"Janko","Age":21}`

## Ako previesť JSON späť na C# objekt?

Môžeme tiež previesť JSON späť na C# objekt. Predpokladajme, že máme nasledujúci JSON reťazec:

```json
{"Name":"Marienka","Age":20}
```

Môžeme ho previesť na C# objekt takto:

```csharp
string json = @"{"Name":"Marienka","Age":20}";

Student student = JsonSerializer.Deserialize<Student>(json);
Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
```

Výstup by bol: `Name: Marienka, Age: 20`
