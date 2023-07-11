# Ako naklonovať GitHub repozitár

## Úvod do klonovania repozitárov na GitHube

GitHub je populárny nástroj používaný mnohými vývojármi na zdieľanie a spoluprácu na softvérových projektoch. "Klonovanie" je jednou zo základných funkcionalít, ktorú GitHub ponúka. Ale čo to presne znamená?

Klonovanie na GitHube je proces, pri ktorom sa vytvorí lokálna kópia vzdialeného repozitára. Tento proces umožňuje vývojárom stiahnuť celý repozitár, vrátane všetkých jeho súborov a histórie commitov, priamo na svoj počítač. Po klonovaní repozitára máte možnosť pracovať na projekte offline, teda bez pripojenia na internet, čo môže byť veľmi užitočné.

Klonovanie je potrebné, keďže vám umožňuje mať vlastnú verziu repozitára, ktorú môžete upravovať a testovať bez toho, aby ste ovplyvnili pôvodný projekt. Vďaka tomu môžete experimentovať a vytvárať zmeny, bez obáv z pokazenia pôvodného kódu. Následne, keď ste pripravení zdieľať svoje zmeny, môžete ich "pushnúť" späť do pôvodného repozitára alebo ich poslať ako "pull request", aby ich mohol revízovať majiteľ pôvodného repozitára.

Nasledujúci návod vám ukáže, ako môžete klonovať repozitáre na GitHub pomocou webového rozhrania na GitHube, Visual Studio, alebo pomocou príkazového riadku.

## A. Klonovanie pomocou webového rozhrania GitHub

- Prejdite na stránku vášho forknutého repozitára na GitHub.
- Kliknite na tlačidlo "Code" vpravo hore a skopírujte URL repozitára.

![GitHub Clone](https://docs.github.com/assets/images/help/repository/code-button.png)

### A.1 Klonovanie v Visual Studio 2022

- Otvorte Visual Studio 2022.
- Kliknite na "Clone a repository".
- Do políčka "Repository location" vložte skopírovanú URL.
- Zvoľte, kam chcete repozitár uložiť v "Local path".
- Kliknite na "Clone".

### A.2 Klonovanie v Visual Studio Code

- Otvorte Visual Studio Code.
- Kliknite na ikonu zobraziť panel "Source Control" (Ctrl+Shift+G).
- Kliknite na "Clone Repository".
- Vložte skopírovanú URL do otvoreného dialógu a stlačte Enter.
- Zvoľte, kam chcete repozitár uložiť.

## B. Klonovanie pomocou príkazového riadku

``` terminal
git clone https://github.com/vasemeno/nazov-repozitara.git
```

Potom môžete začať s prácou na kóde. Všetky zmeny, ktoré urobíte, budú sa týkať len vašej kópie repozitára.
