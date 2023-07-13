# Návratové hodnoty metód

Metóda môže špecifikovať typ hodnoty, ktorú má metóda vrátiť. To sa robí pred názvom metódy.
Napríklad: metóda `Add`, uvádza `int` pred názvom metódy, aby sme určili, že táto metóda vráti celé číslo:

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

Kľúčové slovo `return` sa používa na určenie hodnoty, ktorú metóda vráti. Keď sa vykoná príkaz `return`, metóda okamžite skončí a vráti hodnotu, ktorá nasleduje po `return`.

V našom príklade `Add` metóda vráti súčet dvoch čísel `a` a `b`.
