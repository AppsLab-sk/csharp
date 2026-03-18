using System;

namespace Rpg_hra
{
    public class Monster
    {
        private static readonly Random rng = new();

        public string Name { get; private set; }
        public int Hp { get; private set; }
        public int MinAttack { get; private set; }
        public int MaxAttack { get; private set; }
        public int Reward { get; private set; }
        public bool IsBoss { get; private set; }

        public Monster(string name, int hp, int minAtk, int maxAtk, int reward, bool isBoss)
        {
            Name = name;
            Hp = hp;
            MinAttack = minAtk;
            MaxAttack = maxAtk;
            Reward = reward;
            IsBoss = isBoss;
        }

        // Randomized vytváranie príšer
        public static Monster Create(int fightIndex, int attackBonus, bool isBoss)
        {
            if (isBoss)
            {
                var bosses = new[]
                {
                    new MonsterTemplate("Drak", 150, 18, 26, 100),
                    new MonsterTemplate("Nekromancer", 140, 16, 24, 90),
                    new MonsterTemplate("Obor", 160, 20, 28, 110),
                    new MonsterTemplate("Temný rytier", 130, 15, 22, 95)
                };

                var tpl = bosses[rng.Next(bosses.Length)];

                // small random variation plus light scaling by fightIndex
                int levelScale = Math.Max(0, (fightIndex - 1) / 5);
                int hp = tpl.Hp + rng.Next(-15, 16) + levelScale * 10;
                int minAtk = tpl.MinAtk + attackBonus + rng.Next(-3, 4) + levelScale;
                int maxAtk = tpl.MaxAtk + attackBonus + rng.Next(-3, 4) + levelScale;
                int reward = tpl.Reward + rng.Next(-10, 21) + levelScale * 20;
                if (hp < 1) hp = 1;
                if (minAtk < 1) minAtk = 1;
                if (reward < 1) reward = 1;

                return new Monster(tpl.Name, hp, minAtk, maxAtk, reward, true);
            }
            else
            {
                string[] types = new string[] { "Goblin", "Vlkolak", "Pavúk", "Bandita", "Skelet" };
                int i = rng.Next(types.Length);
                string name = types[i];

                int[] hpVals = new int[] { 33, 30, 22, 28, 20 };
                int[] minVals = new int[] { 4, 6, 5, 6, 4 };
                int[] maxVals = new int[] { 6, 8, 7, 9, 6 };
                int[] rewards = new int[] { 10, 14, 12, 13, 9 };

                // random variation and light scaling with fightIndex
                int levelScale = Math.Max(0, (fightIndex - 1) / 3);
                int hp = hpVals[i] + rng.Next(-5, 6) + levelScale * 3;
                int minAtk = minVals[i] + attackBonus + rng.Next(-2, 3) + levelScale;
                int maxAtk = maxVals[i] + attackBonus + rng.Next(-2, 3) + levelScale;
                int reward = rewards[i] + rng.Next(-3, 6) + levelScale * 2;
                if (hp < 1) hp = 1;
                if (minAtk < 1) minAtk = 1;
                if (reward < 1) reward = 1;

                return new Monster(name, hp, minAtk, maxAtk, reward, false);
            }
        }

        // Náhodný útok v rámci min-max
        public int Attack()
        {
            if (MinAttack >= MaxAttack) return MinAttack;
            return rng.Next(MinAttack, MaxAttack + 1);
        }

        public void TakeDamage(int dmg)
        {
            Hp -= dmg;
            if (Hp < 0) Hp = 0;
        }

        public bool IsDead()
        {
            return Hp <= 0;
        }
    }

    // návrh, vlož do Monster.cs alebo do samostatného súboru
    record MonsterTemplate(string Name, int Hp, int MinAtk, int MaxAtk, int Reward);
}
