using System.Runtime.CompilerServices;

namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player kladnaPostava = new Player() { Name = "Witcher", AttackPower = 10, HP = 100, Mana = 50, CritChance = 25, };
            Player zapornaPostava = new Player() { Name = "Magician", AttackPower = 10, HP = 100, Mana = 50, CritChance = 25 };

            //Pokus o boj postav

            while (true)
            {
                Console.WriteLine("Witcher :" + kladnaPostava.HP);
                Console.WriteLine("Magician :" + zapornaPostava.HP);
                kladnaPostava.DamagePlayer(zapornaPostava);
                zapornaPostava.DamagePlayer(kladnaPostava);

                //Pokus o ozdravenie kladnej postavy a nasledny vypis ci sa to podarilo

                if (kladnaPostava.HP < 20)
                {
                    bool wasHealed = kladnaPostava.Heal();
                    if (wasHealed)
                    {
                        Console.WriteLine("Witcher bol ozdraveny");
                    }
                    else
                    {
                        Console.WriteLine("Witcher uz nema manu a nebol ozdraveny");
                    }
                }

                //Pokus o ozdravenie zapornej postavy a nasledny vypis ci sa to podarilo

                if (zapornaPostava.HP <= 20)
                {
                    bool wasHealed = zapornaPostava.Heal();
                    if (wasHealed)
                    {
                        Console.WriteLine("Magician bol ozdraveny");
                    }
                    else
                    {
                        Console.WriteLine("Magician uz nema manu a nebol ozdraveny");
                    }
                }

                //Pokus o pridanie many kaldnej postave pocas suboja
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, 50);
                    if (randomNumber <= 5)
                    { 
                        kladnaPostava.RefillMana(10);
                        Console.WriteLine("---Witcher dostal dar od Boha a dpolnila sa mu mana---");
                    }

                    //Pokus o pridanie many zapornej posatve pocas suboja

                    int randomNumber2 = random.Next(0, 50);
                    if (randomNumber2 <= 5)
                    {
                        kladnaPostava.RefillMana(10);
                        Console.WriteLine("---Magician dostal dar od Boha a dpolnila sa mu mana---");
                    }

                    // Vypis po suboji

                    if (kladnaPostava.HP < 0)
                    {
                        Console.WriteLine("Magician vyhral !");
                        break;
                    }
                    if (zapornaPostava.HP < 0)

                    {
                        Console.WriteLine("Witcher vyhral !");
                        break;
                    }
                }
            }
        }
    }
}