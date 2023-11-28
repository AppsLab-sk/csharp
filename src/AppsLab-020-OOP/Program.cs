using AppsLab_020_OOP;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello World!");

var save = File.ReadAllLines("Save/Saves.txt");

string teamA = save[0];
string teamB = save[6];

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
    string[] warriorData = save[0].Split(';');
    var mage = new Mage(save[0].Split(';')[0], Int32.Parse(save[0].Split(';')[1]), Int32.Parse(save[0].Split(';')[2]), Int32.Parse(save[0].Split(';')[3]));
    mages.Add(mage);
}
Random r = new Random();
int round = 0;
while (mages.Count>0 && warriors.Count>0)
{
    int mageIndex = r.Next(mages.Count-1);
    int warriorIndex = r.Next(warriors.Count - 1);


    mages[mageIndex].Attack(warriors[warriorIndex]);
    warriors[warriorIndex].Attack(mages[mageIndex]);

    if (mages[mageIndex].Health < 0)
        mages.RemoveAt(mageIndex);
    if (warriors[warriorIndex].Health < 0)
        warriors.RemoveAt(warriorIndex);

    Console.WriteLine(round++ + " " + warrior + " vs " + mage);
}

if (warrior.StillALive())
{
    Console.WriteLine("vyhral bojovnik s menom: " + warrior.Name);
}
if (mage.StillALive())
{
    Console.WriteLine("vyhral bojovnik s menom: " + mage.Name);
}
if (!mage.StillALive() && !warrior.StillALive())
{
    Console.WriteLine("remiza :( ");
}
