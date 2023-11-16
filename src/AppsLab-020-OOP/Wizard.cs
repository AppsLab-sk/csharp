using AppsLab_020_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class Wizard
{
    public string Name { get; set; }    
    public int Health = 100;
    public int AttackPower = 15;
    
    public Wizard(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    // Attack method to attack an enemy
    public void Attack(Wizard enemy)
    {
        enemy.Health -= AttackPower;
    }

    // Defend method for defending
    public void Defend()
    {
        // Implement defense logic here if needed
        Console.WriteLine($"Wizard is defending!");
    }

    // Heal method for healing
    public void Heal()
    {
        // Implement healing logic here if needed
        Console.WriteLine($"Wizard is healing!");
    }


    public bool StillAlive()
    {
        return Health > 0;
    }



    public override string? ToString()
    {
        return Name + "(" + Health + ")";
    }
}
     