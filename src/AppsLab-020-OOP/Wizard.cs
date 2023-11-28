using System;

namespace AppsLab_020_OOP
{
    public class Wizard : ICharacter
    {
        private static Random random = new Random();

        public string Name { get; set; } = "Wizard";
        public int Hp { get; set; } = 57;
        public int Manna { get; set; } = 79;
        public int Defense { get; set; } = 34;
        public int AttackPower { get; set; }
        private bool hasTakenAction = false;

        public Wizard()
        {
            AttackPower = random.Next(30, 46);
        }

        public void Attack(Orc enemy)
        {
            if (!hasTakenAction)
            {
                if (Manna >= 4)
                {
                    Console.WriteLine("Wizard is attacking with magic: " + AttackPower);
                    int damage = AttackPower - enemy.Defense;
                    damage = Math.Max(0, damage);
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