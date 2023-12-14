using AppsLab_020_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



public class Warrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Warrior(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack(Wizzard enemy) 
    {
        enemy.Health = Math.Max(0, enemy.Health - AttackPower);
    }
}
































