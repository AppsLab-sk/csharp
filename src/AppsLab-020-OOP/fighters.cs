namespace AppsLab_020_OOP
{
    internal class fighters 
    {
     public string Name { get; set; }
     public int Health { get; set; }
     public int AttackPower { get; set; }

     public void Attack (Enemy enemy)
        {
            Random r = new Random();
            int atackpower = r.Next(AttackPower);
            enemy.AttackPower = atackpower;
        }
  
     
     public void Defend ()
        {

        }


     public void Heal()
        {

        }


    }





}
