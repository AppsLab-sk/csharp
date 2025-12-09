internal class Player
{
    private int _hp;
    private int _damage;

    public Player()
    {
        _hp = 100;
        _damage = 10;
    }

    internal void DoDamage(Monster monster)
    {
        monster.TakeDamage(_damage);
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
