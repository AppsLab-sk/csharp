# Čo je "push"?

"Push" je termín používaný v kontrole verzií (source control), ako je GitHub. Keď vykonáte "push", odošlete svoje lokálne zmeny na vzdialený repozitár. Ak ste napríklad urobili nejaké zmeny v kóde na svojom počítači a chcete, aby boli tieto zmeny dostupné aj pre ostatných, potom ich "pushnete" na vzdialený repozitár.

## Ako vykonať "push" pomocou Visual Studio 2022

1. Otvorte riešenie vo Visual Studio 2022, ktoré máte prepojené s repozitárom na GitHub-e.
2. Vykonajte svoje zmeny v kóde a uložte súbory.
3. [Vykonajte commit svojich zmien.](/lekcie/What_is_commit.md)
4. Teraz môžete svoje zmeny "pushnúť". Kliknite na `Push` v okne `Git Changes`.

## Ako vykonať "push" pomocou Visual Studio Code

1. Otvorte projekt vo Visual Studio Code, ktorý je prepojený s repozitárom na GitHub-e.
2. Vykonajte zmeny v kóde a uložte súbory.
3. Kliknite na ikonu 'Source Control' (vyzerá ako vetvičky stromu) na bočnom paneli.
4. [Vykonajte commit svojich zmien.](/lekcie/What_is_commit.md)
5. Teraz môžete svoje zmeny "pushnúť". Kliknite na `...` v pravom hornom rohu panela `Source Control` a potom vyberte `Push`.

## Ako vykonať "push" pomocou príkazového riadku

1. Otvorte príkazový riadok v priečinku, ktorý je prepojený s repozitárom na GitHub-e.
2. Vykonajte zmeny v kóde a uložte súbory.
3. [Vykonajte commit svojich zmien.](/lekcie/What_is_commit.md)
4. Nakoniec, zadajte `git push origin main` na odoslanie zmien na vzdialený repozitár. Ak pushujete do inej vetvy, namiesto `main` použite názov tej vetvy.

Takto môžete vykonať "push" na GitHub pomocou Visual Studio 2022, Visual Studio Code alebo príkazového riadku!
