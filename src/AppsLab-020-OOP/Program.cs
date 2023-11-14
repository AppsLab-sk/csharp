// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
class Character 
{
    def __init__(self, name, health, attack_power)
        self.name = name
        self.health = health
        self.attack_power = attack_power

    def attack(self, enemy):
        enemy.defend(self.attack_power)

    def defend(self, attack_power)
        self.health -= attack_power

    def heal(self, amount):
        self.health += amount
}



                        
