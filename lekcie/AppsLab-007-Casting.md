# Implicitné a explicitné pretypovanie v `C#`

## Prečo je pretypovanie dôležité a kedy ho používať?

Pretypovanie je kľúčový koncept v programovaní, ktorý nám umožňuje pracovať s rôznymi dátovými typmi efektívne. Predstavte si, že máte hodnotu ako celé číslo, ale potrebujete ju použiť ako desatinné číslo v matematickej operácii, ktorá vyžaduje väčšiu presnosť. V takom prípade je pretypovanie nástroj, ktorý vám umožní previesť hodnotu na požadovaný dátový typ.

Pretypovanie sa používa v mnohých situáciách:

1. **Práca s knižnicami alebo API:** Môžete pracovať s knižnicami alebo API, ktoré vrátia dáta v určitom dátovom type, ale vy potrebujete použiť tieto dáta v inom type. V takom prípade môžete pretypovať dáta na požadovaný dátový typ.

2. **Zjednodušenie matematických operácií:** Ako sme už spomenuli, niekedy potrebujete previesť celé číslo na desatinné číslo, aby ste mohli vykonávať matematické operácie s väčšou presnosťou.

3. **Prechod medzi rôznymi dátovými typmi:** Niektoré programovacie jazyky, ako je C#, sú silne typované (strongly typed), čo znamená, že pre každú premennú musíte explicitne špecifikovať jej dátový typ. V takýchto jazykoch je pretypovanie často potrebné pre prechod medzi rôznymi dátovými typmi.

Aj keď je pretypovanie užitočné, je dôležité ho používať opatrne. Explicitné pretypovanie môže viesť k strate informácií, ak napríklad pretypujete väčší dátový typ na menší. Preto je dôležité vždy vedieť, kedy a ako používať pretypovanie.

## Implicitné pretypovanie

Implicitné pretypovanie, známe aj ako automatické pretypovanie, je proces, kedy kompilátor automaticky prevádza jeden dátový typ na iný bez potreby explicitnej inštrukcie od programátora. Implicitné pretypovanie sa môže vykonať len vtedy, ak neexistuje riziko stráty údajov, teda ak je cieľový typ väčší ako zdrojový typ.

Napríklad, hodnotu typu `int` je možné implicitne pretypovať na `long`, pretože `long` môže obsahovať všetky hodnoty, ktoré môže obsahovať `int`.

```csharp
int myNumber = 10;
long myBigNumber = myNumber; // implicitné pretypovanie
```

## Explicitné pretypovanie

Explicitné pretypovanie, známe aj ako type casting, je proces, kedy programátor výslovne uvádza, na aký dátový typ chce pretypovať hodnotu. Explicitné pretypovanie je potrebné vtedy, keď existuje riziko stráty údajov, napríklad keď chceme pretypovať `long` na `int`.

```csharp
long myBigNumber = 3000000000;
int myNumber = (int)myBigNumber; // explicitné pretypovanie
```

Všimnite si, že pri explicitnom pretypovaní môže dôjsť k strate údajov, pretože `int` nemôže reprezentovať tak veľké hodnoty ako `long`. Je teda dôležité byť si vedomý týchto rizík pri explicitnom pretypovaní.

## Typové konverzie

V niektorých prípadoch môžete použiť aj metódy pre konverziu dátových typov, ako sú `Convert.ToInt32()`, `Convert.ToDouble()`, atď. Tieto metódy sú často bezpečnejšie ako explicitné pretypovanie, pretože poskytujú ošetrenie chýb.

```csharp
string myString = "123";
int myNumber = Convert.ToInt32(myString); // konverzia zo string na int
```

Vždy si však dajte pozor na možné výnimky, ktoré môžu vzniknúť pri konverzii - napríklad, ak sa pokúsite premeniť reťazec, ktorý neobsahuje platné číslo.

## Úloha

Táto cvičebná úloha vás naučí, ako v praxi používať implicitné a explicitné pretypovanie (casting) v jazyku C#.

V rámci tohto cvičenia budete upravovať triedu `Converter`, ktorá má metódy navrhnuté tak, aby konvertovali hodnoty medzi rôznymi dátovými typmi. Triedu `Converter` nájdete v súbore `Converter.cs` v adresári `src\AppsLab-007-Casting\`.

Vašou úlohou je implementovať každú metódu v triede `Converter`. Každá z týchto metód momentálne vyvoláva výnimku `NotImplementedException`, ktorá znamená, že daná metóda ešte nebola implementovaná. Vašou úlohou je nahradit tieto riadky kódu skutočným kódom, ktorý bude vykonávať požadovanú konverziu.

Tu je zoznam metód, ktoré budete implementovať:

```csharp
public double IntToDouble(int number)
{
    throw new NotImplementedException();
}

public int DoubleToInt(double number)
{
    throw new NotImplementedException();
}

public double StringToDouble(string number)
{
    throw new NotImplementedException();
}

public string DoubleToString(double number)
{
    throw new NotImplementedException();
}

public string IntToString(int number)
{
    throw new NotImplementedException();
}

public bool StringToBool(string boolValue)
{
    throw new NotImplementedException();
}

public string BoolToString(bool boolValue)
{
    throw new NotImplementedException();
}
```

Všimnite si, že návratový typ metódy sa zhoduje s typom, na ktorý chcete hodnotu pretypovať. Napríklad metóda `IntToDouble` prijíma celé číslo (`int`) a má vrátiť desatinné číslo (`double`). V rámci tejto metódy budete musieť napísať kód, ktorý prevedie celé číslo na desatinné.

## Pomoc

Pretypovanie v C# sa uskutočňuje pomocou syntaxe `(type)value`, kde `type` je typ, na ktorý chcete hodnotu pretypovať, a `value` je hodnota, ktorú chcete pretypovať. Napríklad `(double)5` prevedie celé číslo `5` na desatinné číslo `5.0`.

Konverzia medzi stringami a ostatnými typmi je trochu komplikovanejšia a vyžaduje použitie metód ako `int.Parse()`, `double.Parse()`, `bool.Parse()`, `ToString()` a podobne.

Tu môžete násť návod:

> [Ako "vrátiť" alebo odoslať pretypovanú hodnotu v metóde](/lekcie/Navratove_hodnoty_metod.md)

Po dokončení implementácie každej metódy si môžete skontrolovať svoje riešenia spustením jednotkových testov.

> [Ako spustiť unit testy?](/lekcie/Ako_spustit_unit_testy.md)

Po dokončení úloh nezabudnite váš program uložiť, zmeny komitnúť (commit) a pushnúť do zdieľaného repozitára.