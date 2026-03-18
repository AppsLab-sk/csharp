using System;

namespace Rpg_hra
{
    public class Hero
    {
        public const int AttackEnergyCost = 1;

        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int Hp { get; set; }
        public int MaxEnergy { get; set; }
        public int Energy { get; set; }
        public int BaseAttack { get; set; }
        public int Defense { get; set; }
        public int Money { get; set; }
        public string WeaponName { get; set; }
        public int WeaponAttack { get; set; }
        public string ArmorName { get; set; }
        public int ArmorDefense { get; set; }

        public Hero(string name, int maxHp, int maxEnergy, int baseAttack, int defense, int money)
        {
            Name = name;
            MaxHp = maxHp;
            Hp = maxHp;
            MaxEnergy = maxEnergy;
            Energy = maxEnergy;
            BaseAttack = baseAttack;
            Defense = defense;
            Money = money;
            WeaponName = "None";
            WeaponAttack = 0;
            ArmorName = "None";
            ArmorDefense = 0;
        }

        public int TotalAttack()
        {
            return BaseAttack + WeaponAttack;
        }

        public int TotalDefense()
        {
            return Defense + ArmorDefense;
        }

        public bool IsDead()
        {
            return Hp <= 0;
        }

        // deterministic attack: costs energy and returns damage
        public int Attack()
        {
            if (Energy < AttackEnergyCost)
            {
                return 0;
            }

            Energy -= AttackEnergyCost;
            return TotalAttack();
        }

        public void Rest()
        {
            // restore some energy (but not hp)
            int restored = Math.Max(1, MaxEnergy / 4);
            Energy += restored;
            if (Energy > MaxEnergy) Energy = MaxEnergy;
        }

        public void TakeDamage(int dmg)
        {
            Hp -= dmg;
            if (Hp < 0) Hp = 0;
        }

        public void EquipWeapon(int attackBonus, string name)
        {
            WeaponAttack = attackBonus;
            WeaponName = name;
        }

        public void EquipArmor(int defBonus, string name)
        {
            ArmorDefense = defBonus;
            ArmorName = name;
        }

        public void AddEnergy(int amount)
        {
            Energy += amount;
            if (Energy > MaxEnergy) Energy = MaxEnergy;
        }

        public string GetStatus()
        {
            // No string interpolation ($) — use concatenation so values print correctly
            return string.Join(Environment.NewLine, new[]
            {
                Name,
                "HP: " + Hp + "/" + MaxHp,
                "Energy: " + Energy + "/" + MaxEnergy,
                "ATK: " + TotalAttack() + " (Base " + BaseAttack + " + Weapon " + WeaponAttack + " " + WeaponName + ")",
                "DEF: " + TotalDefense() + " (Base " + Defense + " + Armor " + ArmorDefense + " " + ArmorName + ")",
                "Money: " + Money + " zl"
            });
        }
    }
}
