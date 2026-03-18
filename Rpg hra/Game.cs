using System;
using System.Collections.Generic;

namespace Rpg_hra
{
    public class Game
    {
        private Hero hero;
        private int fightCount;
        private int monsterAttackBonus;

        public Game()
        {
            fightCount = 0;
            monsterAttackBonus = 0;
        }

        public void Run()
        {
            Console.WriteLine("Vitaj v jednoduchej konzolovej RPG hre.");
            Console.Write("Zadaj meno hrdinu: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Hrdina";
            }

            hero = new Hero(name, 2000, 100, 20, 2, 20);

            while (true)        
            {
                if (hero.IsDead())
                {
                    Console.WriteLine("Tvoj hrdina zomrel. Koniec hry.");
                    break;
                }

                fightCount++;
                bool isBoss = (fightCount % 5) == 0;
                Monster monster = Monster.Create(fightCount, monsterAttackBonus, isBoss);

                Console.WriteLine("");
                Console.WriteLine("--- Súboj " + fightCount + (isBoss ? " (BOSS)" : ""));
                // multi-line monster info
                Console.WriteLine(monster.Name);
                Console.WriteLine("HP: " + monster.Hp);
                Console.WriteLine("Útok: " + monster.MinAttack + "-" + monster.MaxAttack);
                Console.WriteLine("Odmena: " + monster.Reward + " zl.");

                // bojový cyklus
                while (!monster.IsDead() && !hero.IsDead())
                {
                    Console.WriteLine("");
                    // multi-line hero status (uses Hero.GetStatus())
                    Console.WriteLine(hero.GetStatus());
                    Console.WriteLine("");
                    Console.WriteLine(monster.Name + " — HP: " + monster.Hp);
                    Console.Write("Akcia ([A] Útok, [O] Oddych, [S] Stav): ");
                    string choice = Console.ReadLine();
                   

                    choice = choice.ToUpper();

                    if (choice == "S")
                    {
                        Console.WriteLine();
                        Console.WriteLine(hero.GetStatus());
                        continue;
                    }

                    if (choice == "A")
                    {
                        if (hero.Energy < Hero.AttackEnergyCost)
                        {
                            Console.WriteLine("Nedostatok energie. Musíš oddychovať.");
                            hero.Rest();
                        }
                        else
                        {
                            int dmg = hero.Attack();
                            monster.TakeDamage(dmg);
                            Console.WriteLine("Útok: zranil si " + monster.Name + " za " + dmg + " dmg.");
                        }
                    }
                    else if (choice == "O")
                    {
                        hero.Rest();
                        Console.WriteLine("Oddych - doplnil si energiu.");
                    }
                    else
                    {
                        Console.WriteLine("Neplatná voľba.");
                        continue;
                    }

                    // príšera útočí ak je ešte nažive
                    if (!monster.IsDead())
                    {
                        int mAtk = monster.Attack();
                        int actual = mAtk - hero.TotalDefense();  //(actual < 0) actual = 0;
                        if (actual > 0) ; 
                        {
                            actual < 0  Console.WriteLine("si slaby");
                            

                        }
                        hero.TakeDamage(actual);
                        Console.WriteLine(monster.Name + " útočí za " + mAtk + " dmg. Po zohľadnení obrany prijímaš " + actual + " dmg.");
                    }
                }

                // výsledok súboja
                if (hero.IsDead())
                {
                    if (isBoss)
                    {
                        Console.WriteLine("Zomrel si pri boji s bossom - hra sa okamžite končí.");
                        break;
                    }
                    Console.WriteLine("Zomrel si. Koniec hry.");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Porazil si " + monster.Name + " Získavaš " + monster.Reward + " zl.");
                    hero.Money += monster.Reward;

                    if (isBoss)
                    {
                        Console.WriteLine("Boss porazený! Dostávaš bonus a príšery zosilnejú.");
                        int bonus = monster.Reward / 2;
                        hero.Money += bonus;
                        Console.WriteLine("Bonus za bossa: +" + bonus + " zl.");
                        monsterAttackBonus += 2;
                    }

                    // jednoduchý obchod po boji
                    bool afterFight = true;
                    while (afterFight)
                    {
                        Console.WriteLine("");
                        // use multi-line status for after-fight display
                        Console.WriteLine(hero.GetStatus());
                        Console.WriteLine("");

                        // split shop options into separate lines for better readability
                        Console.WriteLine("Obchod:");
                        Console.WriteLine("  [1] Zbraň +5 útok (40 zl)");
                        Console.WriteLine("  [2] Brnenie +3 obrana (35 zl)");
                        Console.WriteLine("  [3] Elixír energie +30 (20 zl)");
                        Console.WriteLine("  [4] Pokračovať");
                        Console.WriteLine("  [5] Ukončiť");

                        Console.Write("Voľba: ");
                        string shop = Console.ReadLine();
                        

                        if (shop == "1")
                        {
                            if (hero.Money >= 40)
                            {
                                hero.Money -= 40;
                                hero.EquipWeapon(5, "Lepšia zbraň");
                                Console.WriteLine("Kúpil si zbraň +5 útok.");
                            }
                            else
                            {
                                Console.WriteLine("Nemáš dosť peňazí.");
                            }
                        }
                        else if (shop == "2")
                        {
                            if (hero.Money >= 35)
                            {
                                hero.Money -= 35;
                                hero.EquipArmor(3, "Lepšie brnenie");
                                Console.WriteLine("Kúpil si brnenie +3 obrana.");
                            }
                            else
                            {
                                Console.WriteLine("Nemáš dosť peňazí.");
                            }
                        }
                        else if (shop == "3")
                        {
                            if (hero.Money >= 20)
                            {
                                hero.Money -= 20;
                                hero.AddEnergy(30);
                                Console.WriteLine("Použil si elixír energie.");
                            }
                            else
                            {
                                Console.WriteLine("Nemáš dosť peňazí.");
                            }
                        }
                        else if (shop == "4")
                        {
                            afterFight = false; // pokračovať do ďalšieho boja
                        }
                        else if (shop == "5")
                        {
                            Console.WriteLine("Ukončujem hru. Vďaka za hranie!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Neplatná voľba.");
                        }
                    }
                }
            }
        }
    }
}
