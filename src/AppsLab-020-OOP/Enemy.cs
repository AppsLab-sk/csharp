﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }

    }
    public void Attack(Warrior warrior)
    {
        Random r = new Random();
        int Attack = r.Next(Attack);
        warrior.Health -= Attack;
    }

    public void Defend()
    {

    }
    public void Heal()
    {

    }

}
