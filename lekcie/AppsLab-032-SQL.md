# `C#` Súvisiace koncepty (Related Concepts) - Databázy a SQL

V tejto lekcii sa pozrieme na dôležitú súčasť väčšiny softvérových aplikácií - databázy a SQL.

Databáza je organizovaná kolekcia dát. V kontexte softvéru sa tieto dáta zvyčajne týkajú informácií, ktoré aplikácia potrebuje na svoju činnosť. Napríklad, e-shop môže mať databázu produktov, zákazníkov a objednávok.

SQL (Structured Query Language) je jazyk používaný na komunikáciu s databázami. S jeho pomocou môžeme vytvárať, modifikovať a dotazovať sa na dáta uložené v databáze.

Ukážeme si základy SQL pomocou jednoduchého príkladu.

Pozn.: Predtým, než začneme, uistite sa, že máte nainštalovaný SQL server a prístup k nástroju na správu databáz, ako je napríklad SSMS (SQL Server Management Studio) alebo Azure Data Studio.

## 1. Vytvorenie databázy

   Vytvorenie databázy je jednoduché. Tu je príklad, ako vytvoriť databázu s názvom "MyDatabase":

   ```sql
   CREATE DATABASE MyDatabase;
   ```

## 2. Vytvorenie tabuľky

   Keď máme databázu, môžeme vytvoriť tabuľku. Predstavte si tabuľku ako špecifickú kategóriu dát, ktoré chcete uchovať. Napríklad, môžeme mať tabuľku "Customers" pre informácie o našich zákazníkoch.

   Tu je príklad, ako vytvoriť tabuľku "Customers":

   ```sql
   USE MyDatabase;

   CREATE TABLE Customers (
       Id INT PRIMARY KEY,
       Name NVARCHAR(50),
       Email NVARCHAR(50)
   );
   ```

   Tento príklad vytvorí tabuľku s tromi stĺpcami: "Id", "Name", a "Email". Každý zákazník v tabuľke bude mať jedinečné ID, meno a emailovú adresu.

## 3. Vloženie dát

   Keď máme tabuľku, môžeme do nej vložiť nejaké dáta. Tu je príklad, ako vložiť zákazníka do tabuľky "Customers":

   ```sql
   INSERT INTO Customers (Id, Name, Email) VALUES (1, 'John Doe', 'john.doe@example.com');
   ```

## 4. Dotazovanie dát

   Keď máme v databáze nejaké dáta, môžeme na ne vytvoriť dotaz. Napríklad, môžeme chcieť získať všetkých zákazníkov, ktorí sú v našej databáze. Na to môžeme použiť nasledujúci SQL príkaz:

   ```sql
   SELECT * FROM Customers;
   ```

## 5. Úprava dát

   Môžeme tiež upravovať existujúce dáta. Napríklad, môžeme chcieť zmeniť emailovú adresu zákazníka. Môžeme to urobiť pomocou nasledujúceho príkazu:

   ```sql
   UPDATE Customers SET Email = 'new.email@example.com' WHERE Id = 1;
   ```

## 6. Mazanie dát

   Nakoniec môžeme tiež mazať dáta. Ak napríklad chceme vymazať zákazníka z našej databázy, môžeme použiť nasledujúci príkaz:

   ```sql
   DELETE FROM Customers WHERE Id = 1;
   ```

Toto sú základy SQL. V reálnych aplikáciách sú tieto operácie často oveľa komplexnejšie, ale tieto základy sú dôležitým východiskovým bodom.

Prečo je dôležité učiť sa SQL? Databázy sú kľúčovou súčasťou väčšiny softvérových aplikácií, a SQL je najčastejšie používaný jazyk na interakciu s nimi. Bez porozumenia SQL by bolo veľmi ťažké efektívne pracovať s databázami.

Čo sa týka najlepších postupov, je dôležité myslieť na bezpečnosť pri práci s SQL. Napríklad, mali by ste sa vyvarovať takzvaných SQL injection útokov, kedy niekto môže manipulovať s vašimi SQL príkazmi a potenciálne spôsobiť škodu. Toto môžete urobiť napríklad použitím parametrizovaných príkazov.

Ďalej je dobré myslieť na efektívnosť. Niektoré SQL príkazy môžu byť veľmi náročné na výkon a môžu spôsobiť, že vaša aplikácia bude pomalá. Vždy sa snažte písať efektívny SQL kód.

Ako cvičenie, skúste vytvoriť vlastnú databázu a tabuľku a experimentujte s vkladaním, dotazovaním, upravovaním a mazaním dát. Potom sa pokúste napísať C# kód, ktorý bude interagovať s vašou databázou pomocou SQL.
