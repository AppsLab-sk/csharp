using AppsLab_020_OOP;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello World!");

var save = File.ReadAllLines("Save/Saves.txt");

string warriorsTeamName = save[0];
string magesTeamName = save[6];

List<Warrior> warriors = new List<Warrior>();
List<Mage> mages = new List<Mage>();

for (int i = 1; i <= 5; i++) 
{
    string[] mageData = save[i].Split(";");
    var mage = new Warrior(mageData[0], Int32.Parse(mageData[1]), Int32.Parse(mageData[2]));
    warriors.Add(mage);
}

for (int i = 7; i <= 11; i++)
{
    string[] warriorData = save[i].Split(';');
    var mage = new Mage(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]), Int32.Parse(warriorData[3]));
    mages.Add(mage);
}
Random r = new Random();
int round = 0;
while (mages.Count > 0 && warriors.Count > 0) 
{
    int mageIndex = r.Next(mages.Count-1);
    int warriorIndex = r.Next(warriors.Count - 1); 


    mages[mageIndex].Attack(warriors[warriorIndex]);
    warriors[warriorIndex].Attack(mages[mageIndex]);

    if (mages[mageIndex].Health < 0)
        mages.RemoveAt(mageIndex);
    if (warriors[warriorIndex].Health < 0)
        warriors.RemoveAt(warriorIndex);
}

if (warriors.Count > 0)
{
    Console.WriteLine("vyhral team s menom: " + warriorsTeamName);
}
if (mages.Count > 0)
{
    Console.WriteLine("vyhral team s menom: " + magesTeamName);
}
if (mages.Count==0 && warriors.Count==0)
{
    Console.WriteLine("remiza :( ");
}
