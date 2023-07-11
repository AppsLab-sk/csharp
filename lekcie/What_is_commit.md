# Čo je "commit"?

## Úvod

V tomto návode sa budeme zaoberať konceptom "commitu" v rámci používania na GitHube. "Commit" je základná jednotka zmeny, ktorú môžete aplikovať na váš projekt.

"Commit" v GitHube je v podstate instantná snímka vášho projektu, ktorá uchováva všetky zmeny, ktoré ste vykonali od posledného commitu. Každý commit má unikátne ID (ktoré sa často nazýva "hash"), ktoré vám umožňuje nájsť, sledovať a odkazovať na konkrétnu zmenu. Keď vytvoríte commit, môžete k nemu pridať krátky popis (commit message), ktorý opisuje, o aké zmeny ide.

## Commit v Visual Studio 2022

1. Otvorte svoj projekt s Visual Studio 2022.
2. Choďte do `View > Team Explorer`.
3. V paneli `Team Explorer` prejdite na `Changes`.
4. Tu uvidíte zoznam všetkých zmenených súborov. Môžete ich pridať do stage kliknutím na `Stage`.
5. V textovom poli na vrchu panela `Changes` zadajte správu commitu (commit message) a potom kliknite na `Commit Staged`.

## Commit s Visual Studio Code

1. Otvorte svoj projekt v Visual Studio Code.
2. Kliknite na ikonu "Source Control" v bočnom paneli (táto ikona vyzerá ako vetvičky).
3. Tu uvidíte zoznam všetkých zmenených súborov. Môžete ich pridať do stage pomocou kliknutia na plus vedľa každého súboru alebo kliknutím na "Stage All Changes" na vrchu panela.
4. Potom môžete vytvoriť commit zadaním správy commitu do textového poľa na vrchu panela a stlačením klávesovej skratky `Ctrl+Enter` (alebo `Cmd+Enter` na Mac).

## Commit s Command Line

Ako sme prešli v predošlej časti, commit v terminálu vyžaduje dve základné kroky:

### 1. **Príprava zmien na commit** pomocou príkazu `git add`

``` bash
git add <meno-súboru>
```

Ak chcete pridať všetky zmeny, môžete použiť:

``` bash
git add .
```

### 2. **Vytvorenie commitu** pomocou príkazu `git commit`

``` bash
git commit -m "Váš popis commitu"
```

## Čo je "stage" (pripravenie zmien)?

"Stage" v kontexte Gitu a GitHubu je koncept, ktorý sa týka procesu vytvárania commitov. Keď vykonáte zmeny v súboroch vo svojom repozitári, Git ich automaticky nezahrnie do vášho ďalšieho commitu. Predtým musíte tieto zmeny explicitne "pripraviť" alebo "stage" - to znamená, že povieme Gitu, že chceme tieto konkrétne zmeny zahrnúť do nášho ďalšieho commitu.

Tento proces umožňuje flexibilitu pri vytváraní commitov. Môžete napríklad vykonať množstvo rôznych zmien v rôznych súboroch, ale potom sa rozhodnúť vytvoriť rôzne commit pre rôzne skupiny zmien. Toto môže byť užitočné, ak chcete, aby každý commit reprezentoval samostatnú jednotku práce a uľahčoval sledovanie a prehľad histórie zmien.

"Stage" zmien môžete pomocou príkazu `git add <meno-súboru>` v príkazovom riadku. Ak chcete pridať všetky zmeny, použite `git add .`.

V prostrediach s grafickým používateľským rozhraním, ako je Visual Studio Code alebo Visual Studio 2022, sa proces "stage" zmeny môže líšiť, ale základný koncept je rovnaký: musíte explicitne označiť, ktoré zmeny chcete zahrnúť do vášho ďalšieho commitu.

## Záver

Bez ohľadu na to, či pracujete s terminálom, Visual Studio Code, alebo Visual Studio 2022, commit je dôležitým nástrojom pre správu a sledovanie zmien vo vašom projekte. Pamätajte, že každý commit by mal byť samostatná jednotka zmien, ktorá má jasný a konzistentný účel.
