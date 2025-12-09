using System.Net.Security;
using Witcher_Arena;

internal class Engine
{
    Player player = new Player();
    Monster monster = new Ghoul(50, 10);
    public int DragonBreath;

    internal void Play()
    {
         while (player.IsAlive())
         {
             TakeTurns();
         }
    }
    private void TakeTurns()
    {
         while (monster.IsAlive())
         {
             player.DoDamage(monster);
             monster.DoDamage(player);
         }
         monster = ChooseNewMonster();
    }

    private Monster ChooseNewMonster()
    {
        Random rnd = new Random();
        int vyber = rnd.Next(0, 3);
        if (vyber == 0)
        {
            return new Ghoul(50, 10);
        }
        if (vyber == 1)
        {
            return new Dragon(50, 10);
        }

        return new Basilisk(500, 1);
    }
    public void SpecialAttack(Random random, Dragon dragon)
    {
        
        {
            player.TakeDamage(DragonBreath);
        }
    }  
}

