using System;

internal class Monster
{
    private int _hp;
    private int _damage;
    private int _DragonBreath;

    public Monster(int hp, int damage)
    {
        _hp = hp;
        _damage = damage;
        _DragonBreath = damage * 3;
    }


    internal void DoDamage(Player player, Random random)
    {
        int randomNumber = random.Next(3);
        if (randomNumber == 0)
        {
            player.TakeDamage(_DragonBreath);
        }
        else
        {
            player.TakeDamage(_damage);
        }
    }

    internal bool IsAlive()
    {
        return _hp > 0;
    }

    internal void TakeDamage(int damage)
    {
        _hp -= damage;
    }
}
