# Trieda `Random`

Trieda `Random` v C# je zabudovaná trieda jazyka, ktorá sa používa na generovanie náhodných čísel. Táto trieda poskytuje niekoľko metód na generovanie rôznych typov náhodných čísel.

Najbežnejšie používané metódy sú `Next` a `NextDouble`.

`Next()` metóda vráti náhodné celé číslo.

```csharp
Random random = new Random();
int number = random.Next();
```

`Next(int maxValue)` metóda vráti náhodné celé číslo, ktoré je menšie ako zadané maximum.

```csharp
Random random = new Random();
int number = random.Next(10);  // Vráti náhodné číslo medzi 0 a 9
```

`Next(int minValue, int maxValue)` metóda vráti náhodné celé číslo v zadanom rozsahu.

```csharp
Random random = new Random();
int number = random.Next(5, 10);  // Vráti náhodné číslo medzi 5 a 9
```

`NextDouble()` metóda vráti náhodné desatinné číslo medzi 0.0 a 1.0.

```csharp
Random random = new Random();
double number = random.NextDouble();  // Vráti náhodné desatinné číslo medzi 0.0 a 1.0
```

Použitie triedy `Random` je veľmi užitočné pri generovaní náhodných dát, napríklad pri testovaní, alebo pri simulácii náhodných udalostí v hre.
