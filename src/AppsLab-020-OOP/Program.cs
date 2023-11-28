// See https://aka.ms/new-console-template for more information
using AppsLab_020_OOP;

var save = File.ReadAllLines("Save/Saves.txt");

string teamA = save[0];
string teamB = save[6];

List<Warrior> warriors = new List<Warrior>();
List<Wizard> wizards = new List<Wizard>();

for (int i = 1; i <= 5; i++)
{
    var warriorData = save[0].Split(";");
    var warrior = new Warrior();
    warrior.Name = warriorData[0];
    warrior.Health = Int32.Parse(warriorData[1]);
    warrior.attackpower = Int32.Parse(warriorData[2]);
    warrior.mana = Int32.Parse(warriorData[3]);
    warriors.Add(warrior)
 }

for (int i = 7; i <= 11; i++)

    var wizardData = save[1].Split(";");
{
    var wizard = new Wizard();
    wizard.Name = wizardData[0];
    wizard.Health = Int32.Parse(wizardData[1]);
    wizard.mana = Int32.Parse(wizardData[2]);
    wizard.attackpower = Int32.Parse(wizardData[3]);
    wizard.Add(wizards)

}

Console.WriteLine("Hello World!");

var warrior = new Warrior();
warrior.Name = warriorData[0];
warrior.Health = Int32.Parse(warriorData[1]);
warrior.attackpower = Int32.Parse(warriorData[2]);
warrior.mana = Int32.Parse(wizardData[3]);


var wizard = new Wizard();
wizard.Name = wizardData[0];
wizard.Health = Int32.Parse(wizardData[1]);
wizard.mana = Int32.Parse(wizardData[2]);
wizard.attackpower = Int32.Parse(wizardData[3]);


int round = 0;
while (wizard.StillAlive() && warrior.StillAlive())
{
    wizard.Attack(warrior);
    warrior.Attack(wizard);
    Console.WriteLine((round++) + " " + warrior.Name + " vs." + wizard.Name);
}



if (warrior.StillAlive())
{
    Console.WriteLine("vyhral bojovnik s menom: " + warrior.Name);
}
if (wizard.StillAlive())
{
    Console.WriteLine("vyhral bojovnik s menom: " + wizard.Name);
}
if (!wizard.StillAlive() && !warrior.StillAlive())
{
    Console.WriteLine("remiza :( ");
}

