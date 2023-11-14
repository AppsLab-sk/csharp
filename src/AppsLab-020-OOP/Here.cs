﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Character
    {
        public string Name {  get; set; }
        public int Health {  get; set; }
        public int AttackPower {  get; set; }

        public int Attack(Enemy enemy)
        {
            Random random = new Random();
            int attackPower = random.Next(AttackPower);
            enemy.Health-=attackPower;
        }
    
        public void Defend()
        {

        }

        public void Heal()
        {

        }
    }

}
