# Kontinuálna integrácia (Continuous Integration) (CI)

**Kontinuálna integrácia (CI)** je jednou z kľúčových súčastí modernej softvérovej vývojovej praxe. Podstata CI spočíva v častom začleňovaní zmien kódu do hlavnej vetvy projektu, najlepšie niekoľkokrát denne. Tento prístup znižuje riziko konfliktov pri zlučovaní kódu a umožňuje rýchlejšie odhalenie a nápravu chýb.

## Prečo je CI dôležité?

- **Rýchle odhalenie chýb**: Keďže zmeny sú integrované často a automaticky sa testujú, problémy s kódom sa odhalia omnoho skôr.
- **Menšie konflikty pri zlučovaní**: Čím častejšie sa kód integruje, tým menšie sú konflikty pri zlučovaní kódu (merging).
- **Kvalitnejší kód**: CI zvyšuje kvalitu kódu a zjednodušuje jeho údržbu, keďže zmeny sú menšie a lepšie otestované.

## Ako funguje CI?

Najčastejšie sa používa **CI server**, ktorý monitoruje repozitár s kódom (napríklad na GitHube). Keď sa do repozitára nahrajú nové zmeny, CI server ich stiahne, zostaví aplikáciu, spustí testy a vygeneruje správu o výsledku. Tento proces sa automaticky spúšťa pri každej novej zmene v repozitári.

## Príklad použitia CI

Predstavme si, že pracujeme na projekte s niekoľkými ľuďmi. Máme repozitár na GitHube a pracujeme na rôznych častiach kódu. Keď dokončíme svoje zmeny, nahrajeme ich do repozitára.

Ak máme nastavený CI server (napríklad GitHub Actions), ten automaticky detekuje nové zmeny, stiahne ich, zostaví aplikáciu a spustí všetky testy. Ak všetko prejde úspešne, vieme, že naše zmeny nepriniesli žiadne nové chyby. Ak niektorý z testov zlyhá, CI nám o tom dá vedieť a môžeme problém hneď opraviť.

To znamená, že nie je potrebné čakať na testovanie kódu až po jeho kompletnom napísaní. Tento proces nám umožňuje pracovať rýchlejšie a efektívnejšie, a to vďaka častým kontrolám a testovaniu kódu počas vývoja.

## Ako sa naučiť pracovať s CI?

Najlepším spôsobom, ako sa naučiť pracovať s CI, je vyskúšať si ho na reálnom projekte. Môžete začať tým, že si vytvoríte vlastný malý projekt na GitHube a nastavíte si na ňom CI pomocou nástroja GitHub Actions, ktorý je pre verejné repozitáre zadarmo. GitHub Actions vám umožní automaticky spúšťať vaše testy pri každej novej zmene v repozitári.
