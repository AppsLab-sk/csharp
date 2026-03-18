namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourHero = new Hero();
            Monster monster1 = new Monster("Goblin", 150, 3);
            Monster monster2 = new Monster("Ork", 200, 5);
            Monster monster3 = new Monster("Dragon", 300, 10);
            List<int> cisla = new List<int>();
            List<Monster> monsters = new List<Monster>();
            monsters.Add(monster1);
            monsters.Add(monster2);
            monsters.Add(monster3);

           

            while (true)
            {
                //Hero dostal utok od monstra
                monster1.MonsterAttack(ourHero);
                monster2.MonsterAttack(ourHero);
                monster3.MonsterAttack(ourHero);
                Console.WriteLine("HERO:HP " + ourHero.HP);

                //Monster dostal utok od hrdinu
                bool wasAttack = ourHero.HeroAttack(monster1);
                if (wasAttack)
                {
                    {
                        Console.WriteLine("---Not enough energy to attack! Restoring energy...");
                        Console.WriteLine("HERO:energy " + ourHero.Eng);
                    }

                    if (ourHero.HP <= 0)
                    {
                        Console.WriteLine("Hero is dead!");
                        break;
                    }

                    if (monster1.HP <= 0)
                    {
                        Console.WriteLine("Monster is dead!");
                        break;
                    }
                }
            }
        }
    }
}