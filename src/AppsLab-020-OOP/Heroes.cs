using System;

namespace AppsLab_020_OOP
{
    public class Wizard
    {
        private static Random random = new Random();

        public string Name { get; set; } = "Wizard";
        public int Hp { get; set; } = 57;
        public int Manna { get; set; } = 79;
        public int Defense { get; set; } = 34;
        public int AttackPower { get; set; }
        private bool hasTakenAction = false;
        private int roundsSinceLastDebuffRemoval = 0;

        public Wizard()
        {
            if (Hp + Defense >= 50)
            {
                AttackPower = 60;
            }
            else
            {
                AttackPower = random.Next(30, 46);
            }
        }

        public void Attack(Orc enemy)
        {
            if (!hasTakenAction)
            {
                if (Manna >= 4)
                {
                    Console.WriteLine("Wizard is attacking with magic: " + AttackPower);
                    int damage = AttackPower - enemy.Defense;
                    damage = Math.Max(0, damage); // Ensure damage is not negative
                    enemy.Hp -= damage;

                    Console.WriteLine("Enemy's Health after attack is: " + enemy.Hp);

                    if (enemy.Hp <= 0)
                    {
                        Console.WriteLine("Enemy has died!");
                    }

                    Manna -= 4;
                }
                else
                {
                    Console.WriteLine("Not enough mana to perform the attack!");
                }

                hasTakenAction = true;
            }
            else
            {
                Console.WriteLine("Wizard has already taken an action this turn.");
            }
        }

        public void Heal()
        {
            if (!hasTakenAction)
            {
                if (Manna >= 28)
                {
                    Console.WriteLine("Wizard is healing. Hp before healing: " + Hp);
                    Hp += 40;
                    Console.WriteLine("Hp after healing: " + Hp);

                    Manna -= 28;
                }
                else
                {
                    Console.WriteLine("Not enough mana to perform the heal!");
                }

                hasTakenAction = true;
            }
            else
            {
                Console.WriteLine("Wizard has already taken an action this turn.");
            }
        }

        public void IncrementRoundCounter()
        {
            roundsSinceLastDebuffRemoval++;
        }

        public void GainMana()
        {
            Manna += 9;
        }

        public void ResetAction()
        {
            hasTakenAction = false;
        }

        public bool StillAlive()
        {
            return Hp > 0;
        }

        public override string ToString()
        {
            return Name + "(" + Hp + ")";
        }
    }
}