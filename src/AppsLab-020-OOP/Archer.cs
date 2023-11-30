using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppsLab_020_OOP
{
    internal class Archer
    {


        public Archer(string v1, int v2, int v3)
        {
            Name = v1;
            AttackPower = v2;
            Health = v3;
            //this.v4 = v4;
        }

        public string Name { get; set; }
        public int  AttackPower { get; set; }
        public int Health { get; set; }

        //public int Defend {  get; set; }

        public void Attack(Enemy enemy)
        {
            enemy.Health -= AttackPower;
        }
            
    }
}
