using System.Reflection.Metadata;
using System.Xml.Linq;

public class Warrior
{
    public string? Name;
    public int Health;
    public int AttackPower;
    public int HealAmount;
    private string v1;
    private int v2;
    private int v3;
    private int v4;

    public Warrior(string v1, int v2, int v3, int v4)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }

    public void Attack(Wizzard wizzard)
    {
        //wizzard.Health -= AttackPower;
        wizzard.Health = Math.Max(0, wizzard.Health - AttackPower);
    }

    public void Heal(Warrior warrior)
    {
        warrior.Health += 40;        
    }
}

public class Warrior2 : Warrior
{
    public Warrior2(string v1, int v2, int v3, int v4) : base(v1, v2, v3, v4)
    {
    }
}


//public class WarriorList 
//{ 
//    private var warriorlist = new List<Warrior>();

  //  public void AddWarrior(string name, int health, int attackpower, int healamount) 
    //{
      //  warriorlist.Add(new Warrior {  Name = name, Health = health, AttackPower = attackpower, HealAmount = healamount }); 
   // }
//}