﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Warior
    {
      

        public string name { get; set; }
        public int health { get; set; }
        public int AttackPower  { get; set; }

        public Warior( string name, int health, int attackPower) 
        {
            this.name = name;
            this.health = health;
            AttackPower = attackPower;
        }

      

        public void Attack(Wizard enemy)
        {
           Random random = new Random();
            int attackpower = random.Next(AttackPower);
            enemy.health-=attackpower;
        }
        public bool StillAlive()
        {
            return health > 0;
        }
        public override string? ToString()
        {
            return name + "(" + health + ")";
        }

    }
}