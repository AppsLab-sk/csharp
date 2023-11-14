using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System;
using System;

public class Heroes
{
    public class Wizard
    {
        public int Hp = 57;
        public int Defense = 33;
        public int AttackPower;
        private bool hasTakenAction = false;
        private int roundsSinceLastDebuffRemoval = 0;

        public Wizard()
        {
            Random random = new Random();

            if (Hp + Defense >= 50)
            {
                AttackPower = 50;
            }
            else
            {
                AttackPower = random.Next(10, 26);
            }
        }

        public void Attack(Wizard enemy)
        {
            if (!hasTakenAction)
            {
                Console.WriteLine("Wizard is attacking with magic: " + AttackPower);
                enemy.Hp -= AttackPower;
                Console.WriteLine("Enemy's Health after attack is: " + enemy.Hp);

                if (enemy.Hp <= 0)
                {
                    Console.WriteLine("Enemy has died!");
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
                Console.WriteLine("Wizard is healing. Hp before healing: " + Hp);
                Hp += 40;
                Console.WriteLine("Hp after healing: " + Hp);

                hasTakenAction = true;
            }
            else
            {
                Console.WriteLine("Wizard has already taken an action this turn.");
            }
        }

        public void Defend()
        {
            Console.WriteLine("Wizard is defending");
            Hp += Defense;
            Console.WriteLine("Wizard's Health after defending is: " + Hp);

            if (Hp <= 0)
            {
                Console.WriteLine("Wizard has died!");
            }
        }

        public void RemoveDebuffs()
        {
            if (roundsSinceLastDebuffRemoval >= 10 && !hasTakenAction)
            {
                Console.WriteLine("Wizard removes debuffs.");
                roundsSinceLastDebuffRemoval = 0;
            }
            else
            {
                Console.WriteLine("Cannot remove debuffs. Cooldown not reached or already took an action this turn.");
            }
        }

        public void IncrementRoundCounter()
        {
            roundsSinceLastDebuffRemoval++;
        }
    }
    public class MasterOfSwords
    {
        public int Hp = 50;
        public int Defense = 241;
        public int AttackPower;

        public bool Stun { get; set; }
        public int StunRounds { get; set; }
        public int StunCooldown { get; set; }

        public bool FireDamageOverTime { get; set; }
        public int FireDamageRounds { get; set; }
        public int FireDamageCooldown { get; set; }

        public bool Blind { get; set; }
        public bool Freeze { get; set; }
        public int FreezeRounds { get; set; }
        public int FreezeCooldown { get; set; }

        public void SetEquippedSword(string swordType)
        {
            Random random = new Random();

            if (swordType == "WoodSword")
            {
                AttackPower = random.Next(35, 50);
            }
            else if (swordType == "SteelSword")
            {
                AttackPower = random.Next(50, 75);
            }
            else if (swordType == "FireSword")
            {
                AttackPower = (random.Next(0, 2) == 0) ? 15 : 35;
                FireDamageOverTime = true;
                FireDamageRounds = (random.Next(0, 2) == 0) ? 15 : 35;
                FireDamageCooldown = 6;
            }
            else if (swordType == "LightningSword")
            {
                AttackPower = (random.Next(0, 2) == 0) ? 40 : 60;
                Stun = true;
                StunRounds = 2;
                StunCooldown = 3;
            }
            else if (swordType == "LightSword")
            {
                AttackPower = random.Next(10, 20);
                Blind = true;
            }
            else if (swordType == "IceSword")
            {
                AttackPower = (random.Next(0, 2) == 0) ? 10 : 25;
                Freeze = true;
                FreezeRounds = 3;
                FreezeCooldown = 6;
            }
            else if (swordType == "TrollSword")
            {
                AttackPower = random.Next(-20, -10);
            }
            else
            {
                AttackPower = random.Next(5, 15);
            }
            void Attack(MasterOfSwords enemy)
            {
                 Console.WriteLine("MasterOfSwords is attacking with swords: " + AttackPower);
                 enemy.Hp -= AttackPower;
                 Console.WriteLine("Enemy's Health after attack is: " + enemy.Hp);

                 if (enemy.Hp <= 0)
                 {
                     Console.WriteLine("Enemy has died!");
                 }
            }

            void Defend()
            {
                Console.WriteLine("MasterOfSwords is defending");
                Hp += Defense;
                Console.WriteLine("MasterOfSwords's Health after defending is: " + Hp);

                if (Hp <= 0)
                {
                    Console.WriteLine("MasterOfSwords has died!");
                }
            }
        }
    }

    public void ApplySpecialEffects(int FreezeCooldown, bool Freeze,bool Blind,bool Stun, int StunCooldown, int FireDamageRounds, bool FireDamageOverTime, int FireDamageCooldown)
    {
        if (Stun)
        {
            Console.WriteLine("Enemy is stunned!");
            Thread.Sleep(1000);
            Stun = false;
            StunCooldown = 0;
        }

        if (FireDamageOverTime)
        {
            Console.WriteLine("Enemy is taking fire damage over time!");
            FireDamageRounds--;
            if (FireDamageRounds == 0)
            {
                FireDamageOverTime = false;
                FireDamageCooldown = 0;
            }
        }

        if (Blind)
        {
            Console.WriteLine("Enemy is blinded!");
        }

        if (Freeze)
        {
            Console.WriteLine("Enemy is frozen!");
            Thread.Sleep(1000);
            Freeze = false;
            FreezeCooldown = 0;
        }
    }
}
public class Enemies
{
    public class Orc
    {
        public int Hp = 87;
        public int Defense = 69;
        public int AttackPower = 49;

        public void Attack(Orc enemy)
        {
            Console.WriteLine("Orc is attacking with power: " + AttackPower);
            Console.WriteLine("Heroes's Health after attack is: " + enemy.Hp);

            if (enemy.Hp <= 0)
            {
                Console.WriteLine("Orc has died!");
            }
        }

        public void Defend()
        {
            Console.WriteLine("Orc is defending");
            Hp += Defense;
            Console.WriteLine("Orc's Health after defending is: " + Hp);

            if (Hp <= 0)
            {
                Console.WriteLine("Orc has died!");
            }
        }
    }
    public class Zombie
    {
        public int Hp = 41;
        public int Defense = 74;
        public int AttackPower = 20;
        public int PoisonDamageOverTime = 10;
        public bool IsImmuneToPoison = true;

        private int roundsRemaining = 5;

        public void Attack(Zombie enemy, bool targetIsImmuneToPoisonDamageOverTime)
        {
            Console.WriteLine("Zombie is attacking with power: " + (AttackPower + (roundsRemaining > 0 ? PoisonDamageOverTime : 0)));
            enemy.TakeDamage(AttackPower + (targetIsImmuneToPoisonDamageOverTime ? 0 : (roundsRemaining > 0 ? PoisonDamageOverTime : 0)));
            Console.WriteLine("Hero's Health after attack is: " + enemy.Hp);

            if (enemy.Hp <= 0)
            {
                Console.WriteLine("Wizard has died!");
            }

            if (!targetIsImmuneToPoisonDamageOverTime && roundsRemaining > 0)
            {
                Console.WriteLine("Zombie is affected by Poison Damage Over Time: " + PoisonDamageOverTime);
                TakeDamage(PoisonDamageOverTime);
                Console.WriteLine("Zombie's Health after Poison Damage Over Time is: " + Hp);

                if (Hp <= 0)
                {
                    Console.WriteLine("Zombie has died!");
                }

                roundsRemaining--;

                if (roundsRemaining == 0)
                {
                    Console.WriteLine("Poison damage over time has worn off.");
                }
            }
        }

        public void Defend()
        {
            Console.WriteLine("Zombie is defending");
            Hp += Defense;
            Console.WriteLine("Zombie's Health after defending is: " + Hp);

            if (Hp <= 0)
            {
                Console.WriteLine("Zombie has died!");
            }
        }

        public void ApplyPoisonDamageOverTime()
        {
            PoisonDamageOverTime = 10;
            roundsRemaining = 5;
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;
        }
    }
    public void ApplySpecialEffects(int FreezeCooldown, bool Freeze, bool Blind, bool Stun, int StunCooldown, int FireDamageRounds, bool FireDamageOverTime, int FireDamageCooldown)
    {
        if (Stun)
        {
            Console.WriteLine("Enemy is stunned!");
            Thread.Sleep(1000);
            Stun = false;
            StunCooldown = 0;
        }

        if (FireDamageOverTime)
        {
            Console.WriteLine("Enemy is taking fire damage over time!");
            FireDamageRounds--;
            if (FireDamageRounds == 0)
            {
                FireDamageOverTime = false;
                FireDamageCooldown = 0;
            }
        }

        if (Blind)
        {
            Console.WriteLine("Enemy is blinded!");
        }

        if (Freeze)
        {
            Console.WriteLine("Enemy is frozen!");
            Thread.Sleep(1000);
            Freeze = false;
            FreezeCooldown = 0;
        }
    }
}